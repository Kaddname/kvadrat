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

namespace kvadrat
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

        private void vniz_Click(object sender, RoutedEventArgs e)
        {
            // Проверить, не выйдет ли прямоугольник за нижнюю границу окна
            if (rec.Margin.Top + 80 + 10 <= this.ActualHeight)
            {
                rec.Margin = new Thickness(rec.Margin.Left, rec.Margin.Top + 10, 0, 0);
            }
        }

        private void vverh_Click(object sender, RoutedEventArgs e)
        {
            // Проверить, не выйдет ли прямоугольник за верхнюю границу окна
            if (rec.Margin.Top - 10 >= 0)
            {
                rec.Margin = new Thickness(rec.Margin.Left, rec.Margin.Top - 10, 0, 0);
            }
        }

        private void vlevo_Click(object sender, RoutedEventArgs e)
        {
            // Проверить, не выйдет ли прямоугольник за левую границу окна
            if (rec.Margin.Left - 10 >= 0)
            {
                rec.Margin = new Thickness(rec.Margin.Left - 10, rec.Margin.Top, 0, 0);
            }
        }

        private void vpravo_Click(object sender, RoutedEventArgs e)
        {
            // Проверить, не выйдет ли прямоугольник за правую границу окна
            if (rec.Margin.Left + 60 + 10 <= this.ActualWidth)
            {
                rec.Margin = new Thickness(rec.Margin.Left + 10, rec.Margin.Top, 0, 0);
            }
        }
    }
}