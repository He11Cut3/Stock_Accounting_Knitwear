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
    /// Логика взаимодействия для Edit_Del_Day.xaml
    /// </summary>
    public partial class Edit_Del_Day : Window
    {
        private KnitwearsEntities _context;
        private UC_Plan _Plan;
        private Knitwears_Plan_Day _plan;
        public Edit_Del_Day(KnitwearsEntities analytic_DbEntities1, object o, UC_Plan uC_Plan)
        {
            InitializeComponent();
            _context = analytic_DbEntities1;
            _plan = (o as Button).DataContext as Knitwears_Plan_Day;
            _Plan = uC_Plan;
            DDay_Nomenclature.Text = _plan.Knitwears_Plan_Day_Nomenclature;
            DDay_Note.Text = _plan.Knitwears_Plan_Day_Note;
            DDay_Volume.Text = _plan.Knitwears_Plan_Day_Volume;
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

        private void Day_Check_Click(object sender, RoutedEventArgs e)
        {
            _plan.Knitwears_Plan_Day_Status = "Задача выполнена ✓";
            _context.SaveChanges();
            _Plan.Update_and_Check();
            this.Close();
        }

        private void Plan_Day_Edit_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _plan.Knitwears_Plan_Day_Nomenclature = DDay_Nomenclature.Text;
                _plan.Knitwears_Plan_Day_Note = DDay_Note.Text;
                _plan.Knitwears_Plan_Day_Volume = DDay_Volume.Text;
                _context.SaveChanges();
                _Plan.Update_and_Check();
                this.Close();
            }
        }

        private void Day_Del_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Plan_Day.Remove(_plan);
                _context.SaveChanges();
                _Plan.Update_and_Check();
                this.Close();
            }
        }
    }
}
