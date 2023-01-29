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
        public double[] A;
        public void CalculateSumSeries_Click(object sender, RoutedEventArgs e)
        {

            //string[] row = { "x=-0,9", "A[0]", "0,1231" };
            //ListViewItem lvi = new ListViewItem(new string[] { "x=-0,9", "A[0]", "0,1231" });
            //outpuAarrayA.Items.Add(lvi);
            //outpuAarrayA.Items.Add(new ListViewItem
            //{
            //    Content = new string[] { "x=-0,9", "A[0]", "0,1231" }
            //});


            //double eps = Convert.ToDouble(epsilon.Text);
            //double a = Convert.ToDouble(xInitial.Text);
            //double b = Convert.ToDouble(xFinal.Text);
            //double h = double.Parse(hStep.Text);
            double eps = 0.001;
            double a = -0.9;
            double b = 0.9;
            double h = 0.1;
            int j = 0;

            LibraryForKursovik.Class1 class1 = new LibraryForKursovik.Class1();

            outpuAarrayA.Text += $"  X                               ";
            outpuAarrayA.Text += $"Контрольная формула         ";
            outpuAarrayA.Text += $"                        Суммы рядов\n";

            for (double x = a; x < b; x += h)
            {
                //A[j] = class1.Function(x);
                outpuAarrayA.Text += $" A[{j}]                       ";
                outpuAarrayA.Text += $"   {class1.Function(x):f5}        ";
                outpuAarrayA.Text += $"                           " +
                $"                       {class1.CalculateSumSeries(x, eps):f5} \n";
                j++;
            }
        }

        private void Сlear_Click(object sender, RoutedEventArgs e)
        {
            outpuAarrayA.Text = null;
        }
    }
}
