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

namespace Knitwear.Edit
{
    /// <summary>
    /// Логика взаимодействия для Edit_Del_Stock.xaml
    /// </summary>
    public partial class Edit_Del_Stock : Window
    {
        private KnitwearsEntities _context;
        private UC_Stock _Main;
        private Knitwears_Stock _stock;

        public Edit_Del_Stock(KnitwearsEntities analytic_DbEntities1, object o, UC_Stock uC_User)
        {
            InitializeComponent();
            _context = analytic_DbEntities1;
            _stock = (o as Button).DataContext as Knitwears_Stock;
            _Main = uC_User;
            SStock_Name.Text = _stock.Knitwears_Stock_Name;
            myComboBox3.Text = _stock.Knitwears_Stock_Feature;
            SStock_Weight.Text = _stock.Knitwears_Stock_Weight;
            SStock_Date.Text = _stock.Knitwears_Stock_Date;
            myComboBox1.Text = _stock.Knitwears_Stock_Status;
            SStock_Date.IsEnabled = false;
        }
        private void Time_Now_Click(object sender, RoutedEventArgs e)
        {
            _stock.Knitwears_Stock_Status = "Подходит для обработки";
            _context.SaveChanges();
            _Main.Update_and_Check_Stock();
            this.Close();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _stock.Knitwears_Stock_Name = SStock_Name.Text;
                _stock.Knitwears_Stock_Feature = (myComboBox3.SelectedItem as ComboBoxItem)?.Content?.ToString();
                _stock.Knitwears_Stock_Weight = SStock_Weight.Text;
                _stock.Knitwears_Stock_Status = (myComboBox1.SelectedItem as ComboBoxItem)?.Content?.ToString();
                _context.SaveChanges();
                _Main.Update_and_Check_Stock();
                this.Close();
            }
        }

        private void Stock_Del_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Stock.Remove(_stock);
                _context.SaveChanges();
                _Main.Update_and_Check_Stock();
                this.Close();
            }
        }
    }
}
