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
    /// Логика взаимодействия для New_Order.xaml
    /// </summary>
    public partial class New_Order : Window
    {
        private KnitwearsEntities _context;
        private UC_Order _uc;

        public New_Order(KnitwearsEntities analytic_DbEntities1, UC_Order _uc_order)
        {
            InitializeComponent();
            this._context = analytic_DbEntities1;
            this._uc = _uc_order;
            OOrder_Status.IsEnabled = false;
            OOrder_Status.Text = "В сборке";
            OOrder_Date.IsEnabled = false;
            string time_2_week = DateTime.Now.AddDays(1).ToString("dd.MM.yyyy");
            OOrder_Date.Text = time_2_week;
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

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Order.Add(new Knitwears_Order()
                {
                    Knitwears_Order_Name = OOrder_Name.Text,
                    Knitwears_Order_Vendor_Code = OOrder_Vendor_Code.Text,
                    Knitwears_Order_Weight = OOrder_Weight.Text,
                    Knitwears_Order_Number_Boxes = OOrder_Number_Boxes.Text,
                    Knitwears_Order_Date = OOrder_Date.Text,
                    Knitwears_Order_Status = OOrder_Status.Text,
                });
                _context.SaveChanges();
                _uc.Update_Order();
                this.Close();
            }
        }
    }
}
