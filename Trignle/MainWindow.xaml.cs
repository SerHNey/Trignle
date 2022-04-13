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

namespace Trignle
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            num1.Text = "Введите первую сторону треугольника";
            num2.Text = "Введите вторую сторону треугольника";
            num3.Text = "Введите третью сторону треугольника";
        }

        private void Vvod_Click(object sender, RoutedEventArgs e)
        {
            MethodTrigl trigl = new MethodTrigl();

            int number1 = trigl.Proverka(num1.Text);
            int number2 = trigl.Proverka(num2.Text);
            int number3 = trigl.Proverka(num3.Text);
            if (number1 != 0 && number2 != 0 && number3 != 0)
            {
                  trigl.Treug(number1, number2, number3);
                  OutResult.Text = trigl.Treug(number1, number2, number3);
            }
            else
            {
                OutResult.Text = "Введены некорректные данные";
            }
        }

        private void num1_GotFocus(object sender, RoutedEventArgs e)
        {
            num1.Clear();
        }

        private void num2_GotFocus(object sender, RoutedEventArgs e)
        {
            num2.Clear();
        }

        private void num3_GotFocus(object sender, RoutedEventArgs e)
        {
            num3.Clear();
        }
    }
}
