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
    /// public ListViewDataBindingSample()	
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
                AllData.ArrayA = new double[AllData.LenghtA, 1];
                AllData.ArrayAControl = new double[AllData.LenghtA];
                AllData.ArrayB = new double[AllData.ArrayA.GetLength(0), AllData.ArrayA.GetLength(0)];
                AllData.ArrayC = new double[AllData.ArrayA.GetLength(0), 1];
                AllData.ArrayY = new double[AllData.ArrayA.GetLength(0)];

                controller.SetArrayA();
                List<ArrayAStruct> items = new List<ArrayAStruct>();

                for (int j = 0; j < AllData.ArrayA.Length; j++)
                    items.Add(new ArrayAStruct()
                    {
                        numberGrid = $"A[{j}]",
                        elementSumGrid = $"{AllData.ArrayAControl[j]:f5}",
                        elementGrid = $"{AllData.ArrayA[j, 0]:f5}"
                    });


                //outpuAarrayA.ItemsSource = FormirationDataGrid.ToDataTable<ArrayAStruct>(AllData.ArrayA);
                outpuAarrayA.ItemsSource = items;

               
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ ex}");
            }
        }

        private void Сlear_Click(object sender, RoutedEventArgs e)
        {
            //outpuAarrayA = null;
        }
    }
    public class ArrayAStruct
    {
        public string numberGrid { get; set; }
        public string elementSumGrid { get; set; }
        public string elementGrid { get; set; }
        public override string ToString()
        {
            return this.numberGrid + ", " + this.elementSumGrid + ", " + this.elementGrid;
        }
    }
}
