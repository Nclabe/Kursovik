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
    /// Логика взаимодействия для GraphC.xaml
    /// </summary>
    public partial class GraphC : Page
    {
        public GraphC()
        {
            InitializeComponent();

            #region Оси
            //Ось Y
            Line vertL = new Line();
            vertL.X1 = 400;
            vertL.Y1 = 0;
            vertL.X2 = 400;
            vertL.Y2 = 720;
            vertL.Stroke = Brushes.Black;
            grid1.Children.Add(vertL);

            //Ось X
            Line horL = new Line();
            horL.X1 = 40;
            horL.X2 = 760;
            horL.Y1 = 360;
            horL.Y2 = 360;
            horL.Stroke = Brushes.Black;
            grid1.Children.Add(horL);
            #endregion

            #region Сетка
            //Сетка X
            for (int i = 2; i < 19; i++)
            {
                Line a = new Line();
                a.X1 = i * 40;
                a.X2 = i * 40;
                a.Y1 = 355;
                a.Y2 = 365;
                a.Stroke = Brushes.Black;
                grid1.Children.Add(a);
            }

            //Сетка Y
            for (byte i = 1; i < 18; i++)
            {
                Line a = new Line();
                a.X1 = 395;
                a.X2 = 405;
                a.Y1 = i * 40;
                a.Y2 = i * 40;
                a.Stroke = Brushes.Black;
                grid1.Children.Add(a);
            }

            //Координаты X
            for (int i = -8; i < 9; i++)
            {
                Label a = new Label();
                if (i == 0) { }
                else if(i < 0)
                {
                    a.Margin = new Thickness(387 + i * 40, 365, 0, 0);
                    a.Content = $"{i}";
                    grid1.Children.Add(a);
                }
                else if(i > 0)
                {
                    a.Margin = new Thickness(392 + i * 40, 365, 0, 0);
                    a.Content = $"{i}";
                    grid1.Children.Add(a);
                }
                    
            }

            //Координаты Y
            for (int i = -8; i < 9; i++)
            {
                Label a = new Label();
                if (i == 0) { }
                else if (i > 0)
                {
                    a.Margin = new Thickness(376, 347 - i * 40, 0, 0);
                    a.Content = $"{i}";
                    grid1.Children.Add(a);
                }
                else if (i < 0)
                {
                    a.Margin = new Thickness(374, 347 - i * 40, 0, 0);
                    a.Content = $"{i}";
                    grid1.Children.Add(a);
                }
            }


            #region Указатели
            //Верхний указатель
            Polyline vertArr = new Polyline();
            vertArr.Points = new PointCollection();
            vertArr.Points.Add(new Point(395, 10));
            vertArr.Points.Add(new Point(400, 0));
            vertArr.Points.Add(new Point(405, 10));
            vertArr.Stroke = Brushes.Black;
            grid1.Children.Add(vertArr);

            //Правый указатель
            Polyline RightArr = new Polyline();
            RightArr.Points = new PointCollection();
            RightArr.Points.Add(new Point(750, 355));
            RightArr.Points.Add(new Point(760, 360));
            RightArr.Points.Add(new Point(750, 365));
            RightArr.Stroke = Brushes.Black;
            grid1.Children.Add(RightArr);
            #endregion

            #endregion

        }

        private void PrintGraph_Click(object sender, RoutedEventArgs e)
        {
            #region График
            //График
            Polyline graph = new Polyline();
            graph.Points = new PointCollection();

            double xStart = 400, yStart = 360;

            for (int i = 0; i < AllData.ArrayY.Length; i++)
            {
                double pointX = xStart + 40 * i;
                double pointY = yStart + (AllData.ArrayY[i] + 40);
                graph.Points.Add(new Point(pointX, pointY));
            }

            graph.Stroke = Brushes.Black;
            grid1.Children.Add(graph);
            #endregion
        }
    }
}
