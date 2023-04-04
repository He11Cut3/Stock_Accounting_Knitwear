using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Knitwear.Auth_Capt
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        private string text = String.Empty;
        KnitwearsEntities _context = new KnitwearsEntities();
        public Auth()
        {
            InitializeComponent();
        }


        private void Cls_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Avt_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var password = Password.Password;
            Knitwears_User users = null;
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                users = (Knitwears_User)_context.Knitwears_User.Where(b => b.Knitwears_User_Login == login && b.Knitwears_User_Password == password).FirstOrDefault();
            }
            if (users != null)
            {
                Capt captcha = new Capt();
                this.Close();
                captcha.ShowDialog();
            }
            else
            {
                System.Windows.MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
