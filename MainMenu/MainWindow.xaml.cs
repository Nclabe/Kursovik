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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Page> list;
        public MainWindow()
        {
            InitializeComponent();
            this.list = new List<Page>();
            list.Add(new ArrayA());
            list.Add(new ArrayB());
            list.Add(new ArrayC());
            list.Add(new ArrayY());
            list.Add(new GraphC());
            list.Add(new TextResult());
        }

        private void ArrayA_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[0];
        }

        private void ArrayB_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[1];
        }

        private void ArrayC_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[2];
        }
        private void ArrayY_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[3];
        }

        private void GraphC_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[4];
        }

        private void TextResult_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[5];
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
