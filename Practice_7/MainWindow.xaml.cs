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

namespace Practice_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            Rational firstPair = new Rational(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            Rational secondPair = new Rational(int.Parse(FIRSTP2.Text), int.Parse(SECONDP2.Text));
            result.Text = Rational.ToString(firstPair + secondPair);
        }

        private void Segmentation_Click(object sender, RoutedEventArgs e)
        {
            Rational firstPair = new Rational(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            Rational secondPair = new Rational(int.Parse(FIRSTP2.Text), int.Parse(SECONDP2.Text));
            result.Text = Rational.ToString(firstPair / secondPair);
        }

        private void Substraction_Click(object sender, RoutedEventArgs e)
        {
            Rational firstPair = new Rational(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            Rational secondPair = new Rational(int.Parse(FIRSTP2.Text), int.Parse(SECONDP2.Text));
            result.Text = Rational.ToString(firstPair - secondPair);
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
