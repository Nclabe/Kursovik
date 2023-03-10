using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ArrayB.xaml
    /// </summary>
    /// 
    public partial class ArrayB : Page
    {
        public ArrayB()
        {
            InitializeComponent();
            lowerBound.Text = "-25";
            upperBound.Text = "30";
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataController controller = new DataController();
                AllData.lowerBound = Convert.ToInt32(lowerBound.Text);
                AllData.upperBound = Convert.ToInt32(upperBound.Text);
                controller.SetArrayB();
                ArrayBGrid.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayB).DefaultView;
            }
            catch
            {
                MessageBox.Show("Проверьте заполнение полей!");
            }
        }
        
        private void Сlear_Click(object sender, RoutedEventArgs e)
        {
            //ArrayBGrid.Text = null;
        }
    }
}
