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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(inputA.Text, out int a))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(inputB.Text, out int b))
            {
                MessageBox.Show("Введите число!");
            }
            int summ = 0;
            for (int i = a; i <= b; i++)
            {
                summ += i * i;
            }
            Answer.Text += summ;
        }
    }
}
