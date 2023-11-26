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
using static System.Math;

namespace MyPrac5
{
    /// <summary>
    /// Логика взаимодействия для DopPage1.xaml
    /// </summary>
    public partial class DopPage1 : Page
    {
        public DopPage1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberN.Text, out int n))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(NumberK.Text, out int k))
            {
                MessageBox.Show("Введите число!");
            }

            double answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer += Pow(i, k);
            }

            Answer.Text += $"{answer:f2}";
        }
    }
}
