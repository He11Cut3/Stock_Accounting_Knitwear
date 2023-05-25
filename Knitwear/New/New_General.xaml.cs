using Knitwear.User_Control;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для New_General.xaml
    /// </summary>
    public partial class New_General : Window
    {
        KnitwearsEntities _context = new KnitwearsEntities();
        private UC_Plan _uc;
        private UC_Plan_Month _uc_m;
        private UC_Plan_Week _uc_w;
        private UC_Plan_General plan_General;
        public New_General(UC_Plan_General plan_General)
        {
            InitializeComponent();
            this.plan_General = plan_General;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Back))
            {
                e.Handled = true;
            }
        }
        private void Month_Click(object sender, RoutedEventArgs e)
        {
            var selectedComboBoxItem = myComboBox.SelectedItem as ComboBoxItem;
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                if (selectedComboBoxItem != null)
                {
                    if (selectedComboBoxItem.Content.ToString() == "День")
                    {
                        string time_now = DateTime.Now.AddDays(1).ToString("dd.MM.yyyy");
                        string time_ = DateTime.Now.ToString("dd.MM.yyyy") + " - " + time_now;
                        _context.Knitwears_Plan_Day.Add(new Knitwears_Plan_Day()
                        {
                            Knitwears_Plan_Day_Nomenclature = Nomen.Text,
                            Knitwears_Plan_Day_Date = time_,
                            Knitwears_Plan_Day_Volume = (myComboBox1.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                            Knitwears_Plan_Day_Note = Note.Text,
                            Knitwears_Plan_Day_Status = "Не выполнено ╳",
                        });

                       

                        _context.SaveChanges();
                        plan_General.Update_and_Check_Gen_Day();
                        this.Close();
                    }
                    else if (selectedComboBoxItem.Content.ToString() == "Месяц")
                    {
                        string time_now = DateTime.Now.AddDays(31).ToString("dd.MM.yyyy");
                        string time_ = DateTime.Now.ToString("dd.MM.yyyy") + " - " + time_now;

                        _context.Knitwears_Plan_Month.Add(new Knitwears_Plan_Month()
                        {
                            Knitwears_Plan_Month_Nomenclature = Nomen.Text,
                            Knitwears_Plan_Month_Date = time_,
                            Knitwears_Plan_Month_Volume = (myComboBox1.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                            Knitwears_Plan_Month_Note = Note.Text,
                            Knitwears_Plan_Month_Status = "Не выполнено ╳",
                        });
                        _context.SaveChanges();
                        plan_General.Update_and_Check_Month_Gen();
                        this.Close();
                    }
                    else if (selectedComboBoxItem.Content.ToString() == "Неделя")
                    {
                        string time_now = DateTime.Now.AddDays(7).ToString("dd.MM.yyyy");
                        string time_ = DateTime.Now.ToString("dd.MM.yyyy") + " - " + time_now;
                        _context.Knitwears_Plan_Week.Add(new Knitwears_Plan_Week()
                        {
                            Knitwears_Plan_Week_Nomenclature = Nomen.Text,
                            Knitwears_Plan_Week_Date = time_,
                            Knitwears_Plan_Week_Volume = (myComboBox1.SelectedItem as ComboBoxItem)?.Content?.ToString(),
                            Knitwears_Plan_Week_Note = Note.Text,
                            Knitwears_Plan_Week_Status = "Не выполнено ╳",
                        });
                        _context.SaveChanges();
                        plan_General.Update_and_Check_Week_Gen();
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
