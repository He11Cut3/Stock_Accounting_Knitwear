using Knitwear.Edit;
using Knitwear.New;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Knitwear.User_Control
{
    /// <summary>
    /// Логика взаимодействия для UC_Order.xaml
    /// </summary>
    public partial class UC_Order : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Order> _list = new List<Knitwears_Order>();


        public UC_Order()
        {
            InitializeComponent();
            LV_Order_.ItemsSource = _context.Knitwears_Order.OrderBy(A => A.Knitwears_Order_id).ToList();
            Update_Order();
        }

        public void Update_Order()
        {
            string time_now = DateTime.Now.ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.Knitwears_Order.Where(x => x.Knitwears_Order_Date == time_now).ToList();

            foreach (var duplicate in recordsToUpdate)
            {
                _context.Knitwears_Order.Remove(duplicate);
            }
            _context.SaveChanges();
            _list = _context.Knitwears_Order.ToList();
            LV_Order_.ItemsSource = _list;

        }

        private void Finder_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = Finder.Text;
            var query3 = from emp in _context.Knitwears_Order
                         where emp.Knitwears_Order_Name.Contains(searchText)
                             || emp.Knitwears_Order_Vendor_Code.Contains(searchText)
                             || emp.Knitwears_Order_Weight.Contains(searchText)
                             || emp.Knitwears_Order_Number_Boxes.Contains(searchText)
                             || emp.Knitwears_Order_Date.Contains(searchText)
                             || emp.Knitwears_Order_Status.Contains(searchText)
                         select emp;

            LV_Order_.ItemsSource = query3.ToList();
        }

        private void New_Order_Click(object sender, RoutedEventArgs e)
        {
            New_Order new_Order = new New_Order(_context, this);
            new_Order.ShowDialog();
        }

        private void Edit_del_Order_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Order edit_Del_Order = new Edit_Del_Order(_context, sender, this);
            edit_Del_Order.ShowDialog();
        }

        private void Ex_Order_Click(object sender, RoutedEventArgs e)
        {
            List<Knitwears_Order> data = _context.Knitwears_Order.ToList();

            // Определяем наименования столбцов
            string[] columnNames = new string[] { "Наименование", "Код", "Вес", "Содержимое коробок", "Дата", "Статус" };
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Создаем новый файл Excel
            using (ExcelPackage package = new ExcelPackage())
            {
                // Добавляем лист
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Заказы");

                // Записываем наименования столбцов
                for (int i = 0; i < columnNames.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnNames[i];
                }

                // Записываем данные
                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = data[i].Knitwears_Order_Name;
                    worksheet.Cells[i + 2, 2].Value = data[i].Knitwears_Order_Vendor_Code;
                    worksheet.Cells[i + 2, 3].Value = data[i].Knitwears_Order_Weight;
                    worksheet.Cells[i + 2, 4].Value = data[i].Knitwears_Order_Number_Boxes;
                    worksheet.Cells[i + 2, 5].Value = data[i].Knitwears_Order_Date;
                    worksheet.Cells[i + 2, 6].Value = data[i].Knitwears_Order_Status;
                }

                // Сохраняем файл
                File.WriteAllBytes("Данные_Заказы.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Данные_Заказы.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
