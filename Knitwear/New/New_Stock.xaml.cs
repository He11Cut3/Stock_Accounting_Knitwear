using Knitwear.User_Control;
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
using System.Windows.Shapes;

namespace Knitwear.New
{
    /// <summary>
    /// Логика взаимодействия для New_Stock.xaml
    /// </summary>
    public partial class New_Stock : Window
    {
        private KnitwearsEntities _context;
        private UC_Stock _uc;

        public New_Stock(KnitwearsEntities analytic_DbEntities1, UC_Stock uC_User)
        {
            InitializeComponent();
            this._context = analytic_DbEntities1;
            this._uc = uC_User;
            SStock_Date.IsEnabled = false;
            string time_2_week = DateTime.Now.ToString("dd.MM.yyyy");
            SStock_Date.Text = time_2_week;
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

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                byte[] imageBytes = File.ReadAllBytes(filePath);
                if ((System.Windows.MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                {
                    _context.Knitwears_Stock.Add(new Knitwears_Stock()
                {
                    Knitwears_Stock_Image = imageBytes,
                    Knitwears_Stock_Name = SStock_Name.Text,
                    Knitwears_Stock_Feature = (myComboBox3.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                    Knitwears_Stock_Weight =  SStock_Weight.Text + " " + (myComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                    Knitwears_Stock_Date = SStock_Date.Text,
                    Knitwears_Stock_Status = (myComboBox1.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                });
                _context.SaveChanges();
                _uc.Update_and_Check_Stock();
                this.Close();
                }
            }
        }
    }
}
