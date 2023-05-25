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
    /// Логика взаимодействия для Edit_Del_Week.xaml
    /// </summary>
    public partial class Edit_Del_Week : Window
    {
        private KnitwearsEntities _context;
        private UC_Plan_Week uC_Plan_Week;
        private Knitwears_Plan_Week _Plan_Week;
        private UC_Plan_General _General;

        public Edit_Del_Week(KnitwearsEntities analytic_DbEntities1, object o, UC_Plan_Week uC_Plan, UC_Plan_General plan_General)
        {
            InitializeComponent();
            _context = analytic_DbEntities1;
            _Plan_Week = (o as Button).DataContext as Knitwears_Plan_Week;
            uC_Plan_Week = uC_Plan;
            _General = plan_General;
            Nomen.Text = _Plan_Week.Knitwears_Plan_Week_Nomenclature;
            Note.Text = _Plan_Week.Knitwears_Plan_Week_Note;
            myComboBox1.Text = _Plan_Week.Knitwears_Plan_Week_Volume;
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

        private void Week_Check_Click(object sender, RoutedEventArgs e)
        {
            _Plan_Week.Knitwears_Plan_Week_Status = "Задача выполнена ✓";
            _context.SaveChanges();
            if (uC_Plan_Week != null)
            {
                uC_Plan_Week.Update_and_Check_Week();
            }
            if (_General != null)
            {
                _General.Update_and_Check_Week_Gen();
            }
            this.Close();
        }

        private void Plan_Week_Edit_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _Plan_Week.Knitwears_Plan_Week_Nomenclature = Nomen.Text;
                _Plan_Week.Knitwears_Plan_Week_Note = Note.Text;
                _Plan_Week.Knitwears_Plan_Week_Volume = (myComboBox1.SelectedItem as ComboBoxItem)?.Content?.ToString();
                _context.SaveChanges();
                if (uC_Plan_Week != null)
                {
                    uC_Plan_Week.Update_and_Check_Week();
                }
                if (_General != null)
                {
                    _General.Update_and_Check_Week_Gen();
                }
                this.Close();
            }
        }

        private void Week_Del_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Knitwears_Plan_Week.Remove(_Plan_Week);
                _context.SaveChanges();
                if (uC_Plan_Week != null)
                {
                    uC_Plan_Week.Update_and_Check_Week();
                }
                if (_General != null)
                {
                    _General.Update_and_Check_Week_Gen();
                }
                this.Close();
            }
        }
    }
}
