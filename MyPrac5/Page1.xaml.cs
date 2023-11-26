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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyPrac5
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = 0;
                int n = ListBoxData.Items.Count;
                int max = 0;
                for (int i = 0; i < n; i++)
                {
                    int m = Convert.ToInt32(ListBoxData.Items[i]);
                    if (m % 10 == 2 && m % 7 == 0)
                    {
                        max += m;
                        k++;
                    }
                }
                if (k != 0)
                {
                    TextBlockAnswer.Text = $"Ответ:\n{max}";
                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\nНеправильно!";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            ListBoxData.Items.Clear();
        }
    }
}
