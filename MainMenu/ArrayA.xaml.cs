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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для ArrayA.xaml
    /// </summary>
    public partial class ArrayA : Page
    {
        public ArrayA()
        {
            InitializeComponent();
            xInitial.Text = "-0,9";
            xFinal.Text = "0,9";
            hStep.Text = "0,1";
            epsilon.Text = "0,001";
        }

        public void CalculateSumSeries_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataController controller = new DataController();
            AllData.E = Convert.ToDouble(epsilon.Text);
            AllData.xInitial = Convert.ToDouble(xInitial.Text);
            AllData.xFinal = Convert.ToDouble(xFinal.Text);
            AllData.H = Convert.ToDouble(hStep.Text);

            int c = 0;
            for (double i = AllData.xInitial; i <= AllData.xFinal; i += AllData.H)
            {
                c++;
                
            }
            AllData.LenghtA = c;
            AllData.ArrayA = new double[AllData.LenghtA];
            AllData.ArrayAControl = new double[AllData.LenghtA];
            AllData.ArrayB = new double[AllData.ArrayA.Length, AllData.ArrayA.Length];
            AllData.ArrayC = new double[AllData.ArrayA.Length];
            AllData.ArrayY = new double[AllData.ArrayA.Length];

            outpuAarrayA.Text += $"  X                             ";
            outpuAarrayA.Text += $"Суммы рядов         ";
            outpuAarrayA.Text += $"                               Контрольная формула\n";

            
                

                controller.SetArrayA();

                for (int j = 0; j < AllData.ArrayA.Length; j++)
                {
                    outpuAarrayA.Text += $" A[{j}]                       ";
                    outpuAarrayA.Text += $"   {AllData.ArrayA[j]:f5}        ";
                    outpuAarrayA.Text += $"                          " +
                    $"                       {AllData.ArrayAControl[j]:f5} \n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ ex}");
            }

            

            
        }

        private void Сlear_Click(object sender, RoutedEventArgs e)
        {
            outpuAarrayA.Text = null;
        }
    }
}
