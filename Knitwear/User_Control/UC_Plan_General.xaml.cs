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
    /// Логика взаимодействия для UC_Plan_General.xaml
    /// </summary>
    public partial class UC_Plan_General : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Plan_General> _list = new List<Knitwears_Plan_General>();
        List<Knitwears_Plan_Day> _list1 = new List<Knitwears_Plan_Day>();
        List<Knitwears_Plan_Week> _list2 = new List<Knitwears_Plan_Week>();
        List<Knitwears_Plan_Month> _list3 = new List<Knitwears_Plan_Month>();
        private Knitwears_Plan_General _plan;
        private UC_Plan c_Plan;
        private UC_Plan_Week _planWeek;
        private UC_Plan_Month _planMonth;

        public UC_Plan_General(UC_Plan c_Plan, UC_Plan_Week planWeek, UC_Plan_Month planMonth)
        {
            InitializeComponent();
            LV_Plan_Day_.ItemsSource = _context.Knitwears_Plan_Day.OrderBy(t => t.Knitwears_Plan_Day_id).ToList();
            LV_Plan_Week_.ItemsSource = _context.Knitwears_Plan_Week.OrderBy(t => t.Knitwears_Plan_Week_id).ToList();
            LV_Plan_Month_.ItemsSource = _context.Knitwears_Plan_Month.OrderBy(t => t.Knitwears_Plan_Month_id).ToList();
            this.c_Plan = c_Plan;
            _planWeek = planWeek;
            _planMonth = planMonth;
        }

        public void Update_and_Check()
        {
            

        }

        

        private void New_Plan_Click(object sender, RoutedEventArgs e)
        {
            New_General new_General = new New_General(this);
            new_General.ShowDialog();
        }

        private void Ex_Plan_Day_Click(object sender, RoutedEventArgs e)
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
        public void Update_and_Check_Gen_Day()
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
            _list1 = _context.Knitwears_Plan_Day.ToList();
            LV_Plan_Day_.ItemsSource = _list1;

        }

        public void Update_and_Check_Week_Gen()
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
            _list2 = _context.Knitwears_Plan_Week.ToList();
            LV_Plan_Week_.ItemsSource = _list2;

        }
        public void Update_and_Check_Month_Gen()
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
            _list3 = _context.Knitwears_Plan_Month.ToList();
            LV_Plan_Month_.ItemsSource = _list3;

        }

        private void Edit_del_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Day edit_Del_Day = new Edit_Del_Day(_context, sender, c_Plan, this);
            edit_Del_Day.ShowDialog();
        }

        private void Edit_Del_Month_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Month edit_Del_Month = new Edit_Del_Month(_context, sender, _planMonth, this);
            edit_Del_Month.ShowDialog();
        }

        private void Edit_Del_Week_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Week edit_Del_Week = new Edit_Del_Week(_context, sender, _planWeek, this);
            edit_Del_Week.ShowDialog();
        }
    }
}
