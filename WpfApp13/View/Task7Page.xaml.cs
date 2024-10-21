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
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();

            Random rnd = new Random();
            int[,] array = new int[3, 4];
            int[] temp_array1 = new int[array.GetLength(1)];
            int[] temp_array2 = new int[array.GetLength(1)];

            Text1.Text += ("Исходный массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (i == 0)
                    {
                        temp_array1[j] = array[i, j];
                    }
                    if (i == 2)
                    {
                        temp_array2[j] = array[i, j];
                    }
                    Text1.Text += ($" {array[i, j]}");
                }
                Text1.Text += "\n";
            }


            int index_1 = Array.IndexOf(temp_array1, temp_array1.Min());
            int index_2 = Array.IndexOf(temp_array2, temp_array2.Min());

            array.SetValue(temp_array1[index_1], 2, index_2);
            array.SetValue(temp_array2[index_2], 0, index_1);

            Text1.Text += ("\nИтоговый массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Text1.Text += ($" {array[i, j]}");
                }
                Text1.Text += "\n";
            }
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            ServiceNavigateHelper.FrameNavigate.Navigate(new Task8Page());
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            ServiceNavigateHelper.FrameNavigate.Navigate(new Task6Page());
        }
    }
}