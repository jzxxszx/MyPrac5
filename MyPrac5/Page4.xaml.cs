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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(inputN.Text, out int n))
            {
                MessageBox.Show("Введите число!");
            }
            int sum = 0;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }
            Answer.Text += sum;
        }
    }
}
