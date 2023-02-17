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
    /// Логика взаимодействия для ArrayC.xaml
    /// </summary>
    public partial class ArrayC : Page
    {
        public ArrayC()
        {
            InitializeComponent();
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            DataController controller = new DataController();
            controller.SetArrayC();

            //List<ArrayCStruct> items = new List<ArrayCStruct>();

            //for (int j = 0; j < AllData.ArrayC.Length; j++)
            //    items.Add(new ArrayCStruct()
            //    {
            //        numberGridC = $"C[{j}]",
            //        elementGridC = $"{AllData.ArrayC[j, 0]:f5}"
            //    });

            ArrayCGrid.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayC).DefaultView;
            
        }
    }
    //public class ArrayCStruct
    //{
    //    public string numberGridC { get; set; }
    //    public string elementGridC { get; set; }
    //    public override string ToString()
    //    {
    //        return this.numberGridC + ", " + this.elementGridC;
    //    }
    //}
}
