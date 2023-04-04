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
    /// Логика взаимодействия для New_Week.xaml
    /// </summary>
    public partial class New_Week : Window
    {
        private KnitwearsEntities _context;
        private UC_Plan_Week _uc;

        public New_Week(KnitwearsEntities analytic_DbEntities1, UC_Plan_Week uC_Plan)
        {
            InitializeComponent();
            this._context = analytic_DbEntities1;
            this._uc = uC_Plan;
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

        private void Week_Click(object sender, RoutedEventArgs e)
        {
            string time_now = DateTime.Now.AddDays(7).ToString("dd.MM.yyyy");
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Plan_Week.Add(new Knitwears_Plan_Week()
                {
                    Knitwears_Plan_Week_Nomenclature = WWeek_Nomenclature.Text,
                    Knitwears_Plan_Week_Date = time_now,
                    Knitwears_Plan_Week_Volume = WWeek_Volume.Text,
                    Knitwears_Plan_Week_Note = WWeek_Note.Text,
                    Knitwears_Plan_Week_Status = "Не выполнено",
                });
                _context.SaveChanges();
                _uc.Update_and_Check_Week();

                this.Close();
            }
        }
    }
}
