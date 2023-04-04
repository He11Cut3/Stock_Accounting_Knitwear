using iTextSharp.text;
using iTextSharp.text.pdf;
using Knitwear.User_Control;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Knitwear.MainW
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        List<Knitwears_Stock> _material = new List<Knitwears_Stock>();
        public Main()
        {
            InitializeComponent();
            Day.Visibility = Visibility.Collapsed;
            Week.Visibility = Visibility.Collapsed;
            Month.Visibility = Visibility.Collapsed;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            DragMove();
        }
        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Collapsed;
            Week.Visibility = Visibility.Collapsed;
            Month.Visibility = Visibility.Collapsed;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_Plan_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Order.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Product.Children.Clear();


            UC_Stock uC_User = new UC_Stock();
            LV_User_Grid.Children.Add(uC_User);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Visible;
            Week.Visibility = Visibility.Visible;
            Month.Visibility = Visibility.Visible;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Collapsed;
            Week.Visibility = Visibility.Collapsed;
            Month.Visibility = Visibility.Collapsed;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_User_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Product.Children.Clear();

            UC_Order uC_Order = new UC_Order();
            LV_Order.Children.Add(uC_Order);

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Collapsed;
            Week.Visibility = Visibility.Collapsed;
            Month.Visibility = Visibility.Collapsed;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_User_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Order.Children.Clear();

            UC_Product uC_Product = new UC_Product();
            LV_Product.Children.Add(uC_Product);
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Visible;
            Week.Visibility = Visibility.Visible;
            Month.Visibility = Visibility.Visible;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_User_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Order.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Product.Children.Clear();

            UC_Plan uC_Plan = new UC_Plan();
            LV_Plan_Grid.Children.Add(uC_Plan);
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Visible;
            Week.Visibility = Visibility.Visible;
            Month.Visibility = Visibility.Visible;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_User_Grid.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Order.Children.Clear();
            LV_Product.Children.Clear();


            UC_Plan_Week uC_Plan_Week = new UC_Plan_Week();
            LV_Plan_Week_Grid.Children.Add(uC_Plan_Week);
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            Day.Visibility = Visibility.Visible;
            Week.Visibility = Visibility.Visible;
            Month.Visibility = Visibility.Visible;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_User_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Order.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Product.Children.Clear();

            UC_Plan_Month uC_Plan_Month = new UC_Plan_Month();
            LV_Plan_Month_Grid.Children.Add(uC_Plan_Month);
        }

        private void RadioButton_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Day.Visibility = Visibility.Collapsed;
            Week.Visibility = Visibility.Collapsed;
            Month.Visibility = Visibility.Collapsed;
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;

            LV_User_Grid.Children.Clear();
            LV_Plan_Grid.Children.Clear();
            LV_Plan_Week_Grid.Children.Clear();
            LV_Recipe.Children.Clear();
            LV_Order.Children.Clear();
            LV_Product.Children.Clear();
            LV_Plan_Month_Grid.Children.Clear();
        }
        private void GenerateReport_Stock()
        {
            // Выборка данных из базы данных с помощью LINQ
            var data_stock = from c in _context.Knitwears_Stock
                       where c.Knitwears_Stock_Name != "1"
                       select new { c.Knitwears_Stock_Name, c.Knitwears_Stock_Status, c.Knitwears_Stock_Description };

            // Создание документа PDF
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "Отчёт_Склад.pdf");
            var doc_stock = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(doc_stock, new FileStream(filePath, FileMode.Create));


            BaseFont bf_stock = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font font_stock = new Font(bf_stock, 12);
            doc_stock.Open();

            // Добавление таблицы в документ
            var table_stock = new PdfPTable(3); // количество столбцов = 3
            table_stock.AddCell("NAME");
            table_stock.AddCell("DESCRIPTION");
            table_stock.AddCell("STATUS");

            foreach (var item_stock in data_stock)
            {
                table_stock.AddCell(new iTextSharp.text.Paragraph(item_stock.Knitwears_Stock_Name, font_stock));
                table_stock.AddCell(new iTextSharp.text.Paragraph(item_stock.Knitwears_Stock_Description, font_stock));
                table_stock.AddCell(new iTextSharp.text.Paragraph(item_stock.Knitwears_Stock_Status, font_stock));
            }

            doc_stock.Add(table_stock);
            doc_stock.Close();

        }
        private void GenerateReport_Order()
        {
            // Выборка данных из базы данных с помощью LINQ
            var data_order = from c in _context.Knitwears_Order
                       where c.Knitwears_Order_Name != "1"
                       select new { c.Knitwears_Order_Name, c.Knitwears_Order_Date, c.Knitwears_Order_Status};

            // Создание документа PDF
            var doc_order = new Document(PageSize.A4, 50, 50, 25, 25);
            BaseFont bf_order = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font font_order = new Font(bf_order, 12);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "Отчёт_Заказ.pdf");
            var doc_stock = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(doc_order, new FileStream(filePath, FileMode.Create));

            doc_order.Open();

            // Добавление таблицы в документ
            var table_order = new PdfPTable(3); // количество столбцов = 3
            table_order.AddCell("NAME");
            table_order.AddCell("DATE");
            table_order.AddCell("STATUS");

            foreach (var item_order in data_order)
            {
                table_order.AddCell(new iTextSharp.text.Paragraph(item_order.Knitwears_Order_Name, font_order));
                table_order.AddCell(new iTextSharp.text.Paragraph(item_order.Knitwears_Order_Date, font_order));
                table_order.AddCell(new iTextSharp.text.Paragraph(item_order.Knitwears_Order_Status, font_order));
            }

            doc_order.Add(table_order);
            doc_order.Close();
        }
        private void GenerateReport_Product()
        {
            // Выборка данных из базы данных с помощью LINQ
            var data_product = from c in _context.Knitwears_Product
                       where c.Knitwears_Product_Name != "1"
                       select new { c.Knitwears_Product_Name, c.Knitwears_Product_Description, c.Knitwears_Product_Date, c.Knitwears_Product_Status };

            // Создание документа PDF
            var doc_product = new Document(PageSize.A4, 50, 50, 25, 25);
            BaseFont bf_product = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font font_product = new Font(bf_product, 12);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "Отчёт_Продукты.pdf");
            var doc_stock = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(doc_product, new FileStream(filePath, FileMode.Create));

            doc_product.Open();

            // Добавление таблицы в документ
            var table_product = new PdfPTable(4); // количество столбцов = 3
            table_product.AddCell("NAME");
            table_product.AddCell("DESCRIPTION");
            table_product.AddCell("DATE");
            table_product.AddCell("STATUS");

            foreach (var item_product in data_product)
            {
                table_product.AddCell(new iTextSharp.text.Paragraph(item_product.Knitwears_Product_Name, font_product));
                table_product.AddCell(new iTextSharp.text.Paragraph(item_product.Knitwears_Product_Description, font_product));
                table_product.AddCell(new iTextSharp.text.Paragraph(item_product.Knitwears_Product_Date, font_product));
                table_product.AddCell(new iTextSharp.text.Paragraph(item_product.Knitwears_Product_Status, font_product));
            }

            doc_product.Add(table_product);
            doc_product.Close();
        }

        private void Stock_Checked(object sender, RoutedEventArgs e)
        {
            GenerateReport_Stock();
        }

        private void Order_Checked(object sender, RoutedEventArgs e)
        {
            GenerateReport_Order();
        }

        private void Product_Checked(object sender, RoutedEventArgs e)
        {
            GenerateReport_Product();
        }

        private void RadioButton_PreviewMouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            Stock.Visibility = Visibility.Collapsed;
            Order.Visibility = Visibility.Collapsed;
            Product.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            Stock.Visibility = Visibility.Visible;
            Order.Visibility = Visibility.Visible;
            Product.Visibility = Visibility.Visible;
        }
    }

}
