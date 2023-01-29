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

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для ArrayB.xaml
    /// </summary>
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
                double a = Convert.ToInt32(lowerBound.Text);
                double b = Convert.ToInt32(upperBound.Text);

                //int count = 19;

                ////ArrayBGrid.CountTerms[0] = count;
                ////ArrayBGrid.ColumnCount = count;
                int[,] mas = new int[19, 19];
                int i, j;
                Random rand = new Random();


                for (i = 0; i < 19; i++)
                    for (j = 0; j < 19; j++)
                        mas[i,j] = rand.Next();


                //Выводим матрицу в dataGridView1
                //for (i = 0; i < dataGridView1.RowCount; i++)
                //    for (j = 0; j < dataGridView1.ColumnCount; j++)
                //        ArrayBGrid.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);

                
                        ArrayBGrid.ItemsSource = mas;

            }
            //использование
           

            catch
            {
                MessageBox.Show("Проверьте заполнение полей условий массива");
            }

        }
        
        

        private void FillInverseMatrix_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
