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
    /// Логика взаимодействия для UC_Plan.xaml
    /// </summary>
    public partial class UC_Plan : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Plan_Day> _list = new List<Knitwears_Plan_Day>();
        private Knitwears_Plan_Day _plan;
        private UC_Plan_General _general;
        public UC_Plan()
        {
            InitializeComponent();
            Update_and_Check();
        }

        private void Finder_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = Finder.Text;
            var query1 = from emp in _context.Knitwears_Plan_Day
                         where emp.Knitwears_Plan_Day_Note.Contains(searchText)
                             || emp.Knitwears_Plan_Day_Nomenclature.Contains(searchText)
                             || emp.Knitwears_Plan_Day_Status.Contains(searchText)
                             || emp.Knitwears_Plan_Day_Date.Contains(searchText)
                         select emp;
            LV_Plan_Day_.ItemsSource = query1.ToList();
        }

        public void Update_and_Check()
        {
            string time_now = DateTime.Now.ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.Knitwears_Plan_Day.Where(x => x.Knitwears_Plan_Day_Date == time_now).ToList();

            foreach (var duplicate in recordsToUpdate)
            {
                if (duplicate.Knitwears_Plan_Day_Status != "Задача выполнена ✓")
                {
                    duplicate.Knitwears_Plan_Day_Status = "Не выполнено (просрочено)";
                }
            }
            _context.SaveChanges();
            _list = _context.Knitwears_Plan_Day.ToList();
            LV_Plan_Day_.ItemsSource = _list;

        }

        


        //Изменить/удалить // Изменить
        private void Edit_del_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Day edit_Del_Day = new Edit_Del_Day(_context, sender, this, _general);
            edit_Del_Day.ShowDialog();
        }

        private void Ex_Order_Click(object sender, RoutedEventArgs e)
        {
            List<Knitwears_Plan_Day> data = _context.Knitwears_Plan_Day.ToList();

            // Определяем наименования столбцов
            string[] columnNames = new string[] { "Наименование", "Дата", "Обьём работы", "Описание работы", "Статус" };
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Создаем новый файл Excel
            using (ExcelPackage package = new ExcelPackage())
            {
                // Добавляем лист
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("День");

                // Записываем наименования столбцов
                for (int i = 0; i < columnNames.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnNames[i];
                }

                // Записываем данные
                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = data[i].Knitwears_Plan_Day_Nomenclature;
                    worksheet.Cells[i + 2, 2].Value = data[i].Knitwears_Plan_Day_Date;
                    worksheet.Cells[i + 2, 3].Value = data[i].Knitwears_Plan_Day_Volume;
                    worksheet.Cells[i + 2, 4].Value = data[i].Knitwears_Plan_Day_Note;
                    worksheet.Cells[i + 2, 5].Value = data[i].Knitwears_Plan_Day_Status;
                }

                // Сохраняем файл
                File.WriteAllBytes("Данные_План_День.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "Данные_План_День.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
