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
    /// Логика взаимодействия для UC_Stock.xaml
    /// </summary>
    public partial class UC_Stock : UserControl
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Stock> _list = new List<Knitwears_Stock>();
        private Knitwears_Stock _stock;

        public UC_Stock()
        {
            InitializeComponent();
            LV_User_.ItemsSource = _context.Knitwears_Stock.OrderBy(A => A.Knitwears_Stock_id).ToList();
            this._list = _context.Knitwears_Stock.ToList();
            _stock = DataContext as Knitwears_Stock;
            Update_and_Check_Stock();
        }

        public void Update_and_Check_Stock()
        {
            _list = _context.Knitwears_Stock.ToList();
            LV_User_.ItemsSource = _list;
        }
        // Добавление
        private void New_Siryu_Click(object sender, RoutedEventArgs e)
        {
            New_Stock new_Stock = new New_Stock(_context, this);
            new_Stock.ShowDialog();
        }

        //Изменить/удалить // Изменить
        private void Edit_del_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Stock edit = new Edit_Del_Stock(_context, sender, this);
            edit.ShowDialog();
        }

        private void Ex_Stock_Click(object sender, RoutedEventArgs e)
        {
            List<Knitwears_Stock> data = _context.Knitwears_Stock.ToList();

            // Определяем наименования столбцов
            string[] columnNames = new string[] { "Наименование", "Характеристики", "Вес", "Описание", "Дата", "Статус" };
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
                    worksheet.Cells[i + 2, 1].Value = data[i].Knitwears_Stock_Name;
                    worksheet.Cells[i + 2, 2].Value = data[i].Knitwears_Stock_Feature;
                    worksheet.Cells[i + 2, 3].Value = data[i].Knitwears_Stock_Weight;
                    worksheet.Cells[i + 2, 4].Value = data[i].Knitwears_Stock_Date;
                    worksheet.Cells[i + 2, 5].Value = data[i].Knitwears_Stock_Status;
                }

                // Сохраняем файл
                File.WriteAllBytes("Данные_Склад.xlsx", package.GetAsByteArray());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "Данные_Склад.xlsx");
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }

        private void Finder_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = Finder.Text;
            var query = from emp in _context.Knitwears_Stock
                        where emp.Knitwears_Stock_Name.Contains(searchText)
                            || emp.Knitwears_Stock_Date.Contains(searchText)
                            || emp.Knitwears_Stock_Status.Contains(searchText)
                            || emp.Knitwears_Stock_Feature.Contains(searchText)
                            || emp.Knitwears_Stock_Weight.Contains(searchText)
                        select emp;

            LV_User_.ItemsSource = query.ToList();
        }
    }
}
