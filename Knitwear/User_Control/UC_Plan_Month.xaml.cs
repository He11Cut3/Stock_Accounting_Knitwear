using Knitwear.Edit;
using Knitwear.New;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Knitwear.User_Control
{
    /// <summary>
    /// Логика взаимодействия для UC_Plan_Month.xaml
    /// </summary>
    public partial class UC_Plan_Month : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Plan_Month> _list = new List<Knitwears_Plan_Month>();
        private UC_Plan_General plan_General;

        public UC_Plan_Month()
        {
            InitializeComponent();
            Update_and_Check_Month();
        }

        private void Finder_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = Finder.Text;
            var query3 = from emp in _context.Knitwears_Plan_Month
                         where emp.Knitwears_Plan_Month_Note.Contains(searchText)
                             || emp.Knitwears_Plan_Month_Nomenclature.Contains(searchText)
                             || emp.Knitwears_Plan_Month_Status.Contains(searchText)
                             || emp.Knitwears_Plan_Month_Date.Contains(searchText)
                         select emp;

            LV_Plan_Week_.ItemsSource = query3.ToList();
        }

        public void Update_and_Check_Month()
        {
            string time_now = DateTime.Now.ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.Knitwears_Plan_Month.Where(x => x.Knitwears_Plan_Month_Date == time_now).ToList();

            foreach (var duplicate in recordsToUpdate)
            {
                if (duplicate.Knitwears_Plan_Month_Status != "Задача выполнена ✓")
                {
                    duplicate.Knitwears_Plan_Month_Status = "Не выполнено (просрочено)";
                }
            }
            _context.SaveChanges();
            _list = _context.Knitwears_Plan_Month.ToList();
            LV_Plan_Week_.ItemsSource = _list;

        }

        private void Edit_Del_Month_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Month edit_Del_Month = new Edit_Del_Month(_context, sender, this, plan_General);
            edit_Del_Month.ShowDialog();
        }

        private void Ex_Plan_Month_Click(object sender, RoutedEventArgs e)
        {
            List<Knitwears_Plan_Month> data = _context.Knitwears_Plan_Month.ToList();

            // Определяем наименования столбцов
            string[] columnNames = new string[] { "Наименование", "Дата", "Обьём работы", "Описание работы", "Статус" };
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Создаем новый файл Excel
            using (ExcelPackage package = new ExcelPackage())
            {
                // Добавляем лист
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Месяц");

                // Записываем наименования столбцов
                for (int i = 0; i < columnNames.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnNames[i];
                }

                // Записываем данные
                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = data[i].Knitwears_Plan_Month_Nomenclature;
                    worksheet.Cells[i + 2, 2].Value = data[i].Knitwears_Plan_Month_Date;
                    worksheet.Cells[i + 2, 3].Value = data[i].Knitwears_Plan_Month_Volume;
                    worksheet.Cells[i + 2, 4].Value = data[i].Knitwears_Plan_Month_Note;
                    worksheet.Cells[i + 2, 5].Value = data[i].Knitwears_Plan_Month_Status;
                }

                // Сохраняем файл
                File.WriteAllBytes("Данные_План_Месяц.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "Данные_План_Месяц.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
