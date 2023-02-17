namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для работы с матрицами
    /// </summary>
    internal class Matrix
    {
        /// <summary>
        /// Метод умножения двух матриц
        /// </summary>
        /// <param name="a">Двумерный массив (матрица)</param>
        /// <param name="b">Двумерный массив (матрица)</param>
        /// <returns>Перемноженная матрица</returns>
        /// <exception cref="Exception">Ошибка в случае неподходящего количества столбцов и строк</exception>
        public double[,] Multiplication(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
                throw new Exception("Матрицы нельзя перемножить");
            double[,] r = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// Метод прямого хода Гаусса
        /// </summary>
        /// <param name="A1"></param>
        /// <param name="B"></param>
        /// <returns>Одномерный массив</returns>
        public double[] Gaus(double[,] A1, double[] B)
        {
            int n = B.Length;
            double[] x = new double[n];

            double[,] A = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    A[i, j] = A1[i, j];
            }
            double s = 0;
            double M = 0;
            for (int k = 0; k < n; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    M = A[i, k] / A[k, k];
                    for (int j = k; j < n; j++) 
                        A[i, j] = A[i, j] - A[k, j] * M;
                    B[i] = B[i] - B[k] * M;
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + A[k, j] * x[j];
                x[k] = (B[k] - s) / A[k, k];
            }
            return x;
        }

        /// <summary>
        /// Метод вычисления обратной матрицы
        /// </summary>
        /// <param name="A">Двумерный массив (вычисляемая матрица)</param>
        /// <returns>Двумерный массив (вычисенная обратная матрица)</returns>
        public double[,] MOBR(double[,] A)
        {
            int n = A.GetLength(0);
            double[] B = new double[n];
            double[] x = new double[n];
            double[,] y = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        B[j] = 1;
                    else
                        B[j] = 0;
                }
                x = Gaus(A, B);
                for (int j = 0; j < n; j++)
                    y[j, i] = x[j];
            }
            return y;
        }

        /// <summary>
        /// Вычисление матрицы разделенных разностей для полинома Ньютона
        /// </summary>
        /// <param name="massX"></param>
        /// <param name="massY"></param>
        /// <returns></returns>
        public double[] MatrixDisaddiction(double[] massX, double[] massY)
        {
            int n = massX.Length;
            double[] massA = new double[n];
            double[,] matrixDisaddiction = new double[n, n]; // объявление матрицы разделенных разностей
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrixDisaddiction[i, 0] = massY[i]; // заполнение первого столбца из массива Y
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (i < j)
                        matrixDisaddiction[i, j] = 0; // заполнение нулями поля, которые выше нужной диагонали
                    else
                        matrixDisaddiction[i, j] = (matrixDisaddiction[i, j - 1] - matrixDisaddiction[j - 1, j - 1]) / (massX[i] - massX[j - 1]); // вычисление коэфициентов
                    if (i == j)
                        massA[i] = matrixDisaddiction[i, j]; // заполнение массива коэфициентов коэфициентами
                }
            }
            return massA;
        }
    }
}
