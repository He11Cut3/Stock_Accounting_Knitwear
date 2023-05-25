using Knitwear.User_Control;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Knitwear.New
{
    /// <summary>
    /// Логика взаимодействия для New_Product.xaml
    /// </summary>
    public partial class New_Product : Window
    {
        private KnitwearsEntities _context;
        private UC_Product _uc;

        public New_Product(KnitwearsEntities analytic_DbEntities1, UC_Product uC_Product)
        {
            InitializeComponent();
            this._context = analytic_DbEntities1;
            this._uc = uC_Product;
            PProduct_Boxes.IsEnabled = false;
            PProduct_Status.IsEnabled = false;
            PProduct_Date.IsEnabled = false;
            PProduct_Status.Text = "2-х дневный карантин";
            string time_now = DateTime.Now.AddDays(2).ToString("dd.MM.yyyy");
            PProduct_Date.Text = time_now;
            PProduct_Boxes.Text = "В ожидании";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void New_Product_Add_Click(object sender, RoutedEventArgs e)
        {
            string time_now = DateTime.Now.AddDays(2).ToString("dd.MM.yyyy");
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Product.Add(new Knitwears_Product()
                {
                    Knitwears_Product_Name = PProduct_Name.Text,
                    Knitwears_Product_Date = time_now,
                    Knitwears_Product_Weight = PProduct_Weight.Text,
                    Knitwears_Product_Sample = PProduct_Boxes.Text,
                    Knitwears_Product_Description = PProduct_Description.Text,
                    Knitwears_Product_Status = "Отбор эталонный образца",
                });
                _context.SaveChanges();
                _uc.Update_and_Check_Product();

                this.Close();
            }
        }

        private void PProduct_Weight_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Back))
            {
                e.Handled = true;
            }
        }
    }
}
