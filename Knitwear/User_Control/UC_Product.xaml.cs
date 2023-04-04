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
    /// Логика взаимодействия для UC_Product.xaml
    /// </summary>
    public partial class UC_Product : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Product> _list = new List<Knitwears_Product>();
        Edit_Del_Product edit_;
        public UC_Product()
        {
            InitializeComponent();
            Update_and_Check_Product();
        }

        public void Update_and_Check_Product()
        {
            string time_now = DateTime.Now.ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.Knitwears_Product.Where(x => x.Knitwears_Product_Date == time_now).ToList();

            foreach (var duplicate in recordsToUpdate)
            {

            }
            _context.SaveChanges();
            _list = _context.Knitwears_Product.ToList();
            LV_Product_.ItemsSource = _list;

        }

        private void Edit_del_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Product edit_Del_Product = new Edit_Del_Product(_context, sender, this);
            edit_Del_Product.ShowDialog();
        }

        private void Product_New_Click(object sender, RoutedEventArgs e)
        {
            New_Product new_Product = new New_Product(_context, this);
            new_Product.ShowDialog();
        }

        private void Ex_Plan_Product_Click(object sender, RoutedEventArgs e)
        {
            List<Knitwears_Product> data = _context.Knitwears_Product.ToList();

            // Определяем наименования столбцов
            string[] columnNames = new string[] { "Наименование", "Вес", "Образец", "Описание работы", "Дата", "Статус" };
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Создаем новый файл Excel
            using (ExcelPackage package = new ExcelPackage())
            {
                // Добавляем лист
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Продукт");

                // Записываем наименования столбцов
                for (int i = 0; i < columnNames.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columnNames[i];
                }

                // Записываем данные
                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = data[i].Knitwears_Product_Name;
                    worksheet.Cells[i + 2, 2].Value = data[i].Knitwears_Product_Weight;
                    worksheet.Cells[i + 2, 3].Value = data[i].Knitwears_Product_Sample;
                    worksheet.Cells[i + 2, 4].Value = data[i].Knitwears_Product_Description;
                    worksheet.Cells[i + 2, 5].Value = data[i].Knitwears_Product_Date;
                    worksheet.Cells[i + 2, 6].Value = data[i].Knitwears_Product_Status;
                }

                // Сохраняем файл
                File.WriteAllBytes("Данные_Продукт.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "Данные_Продукт.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
