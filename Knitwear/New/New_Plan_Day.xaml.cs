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
    /// Логика взаимодействия для New_Plan_Day.xaml
    /// </summary>
    public partial class New_Plan_Day : Window
    {
        private KnitwearsEntities _context;
        private UC_Plan _uc;

        public New_Plan_Day(KnitwearsEntities analytic_DbEntities1, UC_Plan uC_Plan)
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

        private void Day_Click(object sender, RoutedEventArgs e)
        {
            string time_now = DateTime.Now.AddDays(1).ToString("dd.MM.yyyy");
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Plan_Day.Add(new Knitwears_Plan_Day()
                {
                    Knitwears_Plan_Day_Nomenclature = DDay_Nomenclature.Text,
                    Knitwears_Plan_Day_Date = time_now,
                    Knitwears_Plan_Day_Volume = DDay_Volume.Text,
                    Knitwears_Plan_Day_Note = DDay_Note.Text,
                    Knitwears_Plan_Day_Status = "Не выполнено",
                });
                _context.SaveChanges();
                _uc.Update_and_Check();

                this.Close();
            }
        }
    }
}
