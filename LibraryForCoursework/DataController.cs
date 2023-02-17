using static LibraryForCoursework.AllData;
namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для работы с данными
    /// </summary>
    public class DataController
    {
        /// <summary>
        /// Метод используется для установки значений в массив А
        /// </summary>
        public void SetArrayA()
        {
            InfiniteSeries infiniteSeries = new InfiniteSeries();
            int i = 0;
            for (double x = xInitial; Math.Round(x, 1) <= xFinal; x += H)
            {
                if (Math.Abs(x) < 1)
                {
                    Sum = 0;
                    ArrayA[i, 0] = infiniteSeries.Recurse(1, Sum, x);
                    ArrayAControl[i] = infiniteSeries.ControlSummand(x);
                    i++;
                }
            }
        }

        /// <summary>
        /// Метод используется для установки значений в массив B
        /// </summary>
        public void SetArrayB()
        {
            Random random = new Random();
            for (int i = 0; i < ArrayB.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayB.GetLength(1); j++)
                    ArrayB[i, j] = random.Next(lowerBound, upperBound);
            }
        }

        /// <summary>
        /// Метод используется для установки значений в массив C
        /// </summary>
        public void SetArrayC()
        {
            Matrix matrix= new Matrix();
            double[,] ArrayBSqrt = matrix.Multiplication(ArrayB, ArrayB);
            ArrayC = matrix.Multiplication(ArrayBSqrt, ArrayA);
        }

        /// <summary>
        /// Метод используется для установки значений в массив Y
        /// </summary>
        public void SetArrayY(){
            Polynoms polynom = new Polynoms();
            int i = 0;
            double[] tempArray = new double[ArrayC.GetLength(0)];
            double[] tempArray2 = new double[ArrayC.GetLength(0)];
            double a = xInitial;
            for (i = 0; i < tempArray.Length; i++) {
                tempArray[i] = a;
                tempArray2[i] = ArrayC[i, 0];
                a += 0.1;
            }
            i = 0;
            for (double x = xInitial; Math.Round(x, 1) <= xFinal; x += G)
            {
                ArrayY[i] = polynom.FindCanonicalPolinom(tempArray, tempArray2, x);
                i++;
            }
        }

        public void SaveToFile(){

        }

        /// <summary>
        /// Метод сортировки простым выбором
        /// </summary>
        /// <param name="mas">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        public double[] Sort(double[] mas){
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++) //поиск минимального числа
                {
                    if (mas[j] < mas[min])
                        min = j;
                }
                double temp = mas[min]; //обмен элементов
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
    }
}