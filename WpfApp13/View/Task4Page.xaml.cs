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
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();

            Random rnd = new Random();
            int[,] array = new int[5, 5];
            int[] diagonal = new int[5];
            int x = 52, count = 4;

            Text1.Text += ("Исходный массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    Text1.Text += ($" {array[i, j]}");
                    if (j == count)
                    {
                        count--;
                        if (array[i, j] < x) x = array[i, j];
                    }
                }
                Text1.Text += "\n";
            }

            Text1.Text += ($"\nНаименьший элемент на побочной диагонали: {x}");
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            ServiceNavigateHelper.FrameNavigate.Navigate(new Task5Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            ServiceNavigateHelper.FrameNavigate.Navigate(new Task3Page());
        }
    }
}