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
    /// Логика взаимодействия для UC_Plan_Week.xaml
    /// </summary>
    public partial class UC_Plan_Week : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Plan_Week> _list = new List<Knitwears_Plan_Week>();
        private Knitwears_Plan_Week _plan;

        public UC_Plan_Week()
        {
            InitializeComponent();
            Update_and_Check_Week();
        }

        public void Update_and_Check_Week()
        {
            string time_now = DateTime.Now.ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.Knitwears_Plan_Week.Where(x => x.Knitwears_Plan_Week_Date == time_now).ToList();

            foreach (var duplicate in recordsToUpdate)
            {
                if (duplicate.Knitwears_Plan_Week_Status != "Задача выполнена ✓")
                {
                    duplicate.Knitwears_Plan_Week_Status = "Не выполнено (просрочено)";
                }
            }
            _context.SaveChanges();
            _list = _context.Knitwears_Plan_Week.ToList();
            LV_Plan_Week_.ItemsSource = _list;

        }


        private void New_Plan_Week_Click(object sender, RoutedEventArgs e)
        {
            New_Week new_plan_week = new New_Week(_context, this);
            new_plan_week.ShowDialog();
        }

        private void Edit_Del_Week_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Week edit_Del_Week = new Edit_Del_Week(_context, sender, this);
            edit_Del_Week.ShowDialog();
        }

        private void Ex_Plan_Week_Click(object sender, RoutedEventArgs e)
        {
            List<Knitwears_Plan_Week> data = _context.Knitwears_Plan_Week.ToList();

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
                    worksheet.Cells[i + 2, 1].Value = data[i].Knitwears_Plan_Week_Nomenclature;
                    worksheet.Cells[i + 2, 2].Value = data[i].Knitwears_Plan_Week_Date;
                    worksheet.Cells[i + 2, 3].Value = data[i].Knitwears_Plan_Week_Volume;
                    worksheet.Cells[i + 2, 4].Value = data[i].Knitwears_Plan_Week_Note;
                    worksheet.Cells[i + 2, 5].Value = data[i].Knitwears_Plan_Week_Status;
                }

                // Сохраняем файл
                File.WriteAllBytes("Данные_План_Неделя.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "Данные_План_Неделя.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
