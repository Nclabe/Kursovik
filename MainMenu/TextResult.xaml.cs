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
using LibraryForCoursework;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для TextResult.xaml
    /// </summary>
    public partial class TextResult : Page
    {
        public TextResult()
        {
            InitializeComponent(); 
        }

        private void PrintResult_Click(object sender, RoutedEventArgs e)
        {
            Result.Text += "Массив A: \n";
            for (int j = 0; j < AllData.ArrayA.Length; j++)
                Result.Text += $"A[{j}] = {Convert.ToString(AllData.ArrayA[j, 0])} \n";
            Result.Text += "Массив B: \n";
            for (int i = 0; i < AllData.ArrayB.GetLength(0); i++)
            {
                for (int j = 0; j < AllData.ArrayB.GetLength(0); j++)
                    Result.Text += $"{Convert.ToString(AllData.ArrayB[i, j])}   ";
                Result.Text += $"\n";
            }
            Result.Text += "Массив C: \n";
            for (int j = 0; j < AllData.ArrayC.Length; j++)
                Result.Text += $"C[{j}] = {Convert.ToString(AllData.ArrayC[j, 0])} \n";

        }
    }
}
