using LibraryForCoursework;
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
    /// Логика взаимодействия для ArrayY.xaml
    /// </summary>
    public partial class ArrayY : Page
    {
        public ArrayY()
        {
            InitializeComponent();
        }
        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AllData.G = Convert.ToDouble(StepG.Text);
                DataController controller = new DataController();
                controller.SetArrayY();
                ArrayYGrid.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayY).DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        private void SortArray_Click(object sender, RoutedEventArgs e)
        {
            DataController controller = new DataController();
            AllData.ArrayYSort =  controller.Sort(AllData.ArrayY);
            ArrayYGridSort.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayYSort).DefaultView;
        }
    }
}
