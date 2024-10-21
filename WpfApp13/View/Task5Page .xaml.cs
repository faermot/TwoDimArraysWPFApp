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
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();

            Random rnd = new Random();
            int[,] array = new int[5, 4];
            int[] temp_array = new int[array.GetLength(0)];

            Text1.Text += ("Исходный массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (j == 3)
                    {
                        temp_array[i] = array[i, j];
                    }
                    Text1.Text += ($" {array[i, j]}");
                }
                Text1.Text += "\n";
            }

            Array.Sort(temp_array);

            Array.Reverse(temp_array);

            Text1.Text += ("\nИтоговый массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 3)
                    {
                        array[i, j] = temp_array[i];
                    }
                    Text1.Text += ($" {array[i, j]}");
                }
                Text1.Text += "\n";
            }
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            ServiceNavigateHelper.FrameNavigate.Navigate(new Task4Page());
        }
    }
}