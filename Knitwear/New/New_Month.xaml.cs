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
    /// Логика взаимодействия для New_Month.xaml
    /// </summary>
    public partial class New_Month : Window
    {
        private KnitwearsEntities _context;
        private UC_Plan_Month _uc;

        public New_Month(KnitwearsEntities analytic_DbEntities1, UC_Plan_Month uC_Plan_Month)
        {
            InitializeComponent();
            this._context = analytic_DbEntities1;
            this._uc = uC_Plan_Month;
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

        private void Month_Click(object sender, RoutedEventArgs e)
        {
            string time_now = DateTime.Now.AddDays(31).ToString("dd.MM.yyyy");
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Plan_Month.Add(new Knitwears_Plan_Month()
                {
                    Knitwears_Plan_Month_Nomenclature = MMonth_Nomenclature.Text,
                    Knitwears_Plan_Month_Date = time_now,
                    Knitwears_Plan_Month_Volume = MMonth_Volume.Text,
                    Knitwears_Plan_Month_Note = MMonth_Note.Text,
                    Knitwears_Plan_Month_Status = "Не выполнено",
                });
                _context.SaveChanges();
                _uc.Update_and_Check_Month();

                this.Close();
            }
        }
    }
}
