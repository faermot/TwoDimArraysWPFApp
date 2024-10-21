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
using WpfApp13.Services;
using WpfApp13.View;

namespace WpfApp13.View
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();

            Random rnd = new Random();
            int size = rnd.Next(1, 11);
            double[,] array = new double[size, size];
            double product = 1;

            Text1.Text += ("Исходный массив:\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = rnd.NextDouble() * 50;
                    Text1.Text += ($"{array[i, j]:F3}  ");
                }
                Text1.Text += "\n";
            }

            for (int j = 0; j < size; j++)
            {
                double min = array[0, j];
                for (int i = 1; i < size; i++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                product *= min;
            }

            Text1.Text += ($"\nПроизведение наименьших элементов каждого столбца массива: {product:F3}");
        }

        /*
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {

        }
        */

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            ServiceNavigateHelper.FrameNavigate.Navigate(new Task7Page());
        }
    }
}