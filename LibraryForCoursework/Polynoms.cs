namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для работы с полиномами
    /// </summary>
    internal class Polynoms
    {
        Matrix matrix = new Matrix();

        /// <summary>
        /// Массив для нахождения полинома Ньютона
        /// </summary>
        /// <param name="massX">Массив X</param>
        /// <param name="massY">Массив значений</param>
        /// <param name="massA">Массив разностей</param>
        /// <param name="x">Шаг</param>
        /// <returns>Полином Ньютона</returns>
        public double FindNewtonPolynom(double[] massX, double[] massY, double[] massA, double x)
        {
            int n = massX.Length;
            massA[0] = massY[0];
            double polynom = 0;
            for (int i = 0; i < n; i++)
            {
                double recursion = 1;
                for (int j = 0; j <= i - 1; j++)
                    recursion *= x - massX[j];
                polynom += massA[i] * recursion;
            }
            return polynom;
        }

        /// <summary>
        /// Метод для нахождения канонического полинома
        /// </summary>
        /// <param name="massX">Одномерный массив X</param>
        /// <param name="massY">Одномерный массив значений</param>
        /// <param name="x">Шаг</param>
        /// <returns>Канонический полином</returns>
        public double FindCanonicalPolinom(double[] massX, double[] massY, double x)
        {
            int n = massX.Length;
            double[,] matrixA = new double[n, n];
            double[] massA = new double[n];
            double polynom;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    matrixA[i, j] = Math.Pow(massX[i], j);
            }
            matrixA = matrix.MOBR(matrixA);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    massA[i] += matrixA[i, j] * massY[j];
            }
            polynom = 0;
            for (int i = 0; i < n; i++)
                polynom += massA[i] * Math.Pow(x, i);
            return polynom;
        }
    }
}
