namespace LibraryForCoursework
{
    /// <summary>
    /// Статический класс всех используемых данных
    /// </summary>
    public static class AllData
    {
        public static double I { get; set; } // Свойство используется в качетсве итерируемого слагаемого либо в качестве итерируемой переменной
        public static double E { get; set; } // Заданная точность
        public static double xInitial { get; set; } // Начальное значение X
        public static double xFinal { get; set; } // Конечное значение X
        public static double H { get; set; } // Шаг
        public static double G { get; set; } // Шаг №2
        public static double Sum { get; set; } // Сумма бесконечного ряда
        public static int lowerBound { get; set; } // НИжняя граница массива В
        public static int upperBound { get; set; } // Верхняя граница массива В
        public static int LenghtA { get; set; } // Размерность массива А 
        public static double[,]? ArrayA { get; set; } // Массив A
        public static double[]? ArrayAControl { get; set; } // Массив A c значениями контрольной формулы
        public static double[,]? ArrayB { get; set; } // Массив B
        public static double[,]? ArrayC { get; set; } // Массив С
        public static double[]? ArrayY { get; set; } // Массив Y
        public static double[]? ArrayYSort { get; set; } // Массив Y

        static AllData(){
            //ArrayA = new double[LenghtA, 1];
            //ArrayAControl = new double[LenghtA];
            //ArrayB = new double[ArrayA.GetLength(0), ArrayA.GetLength(0)];
            //ArrayC = new double[ArrayA.GetLength(0), 1];
            //ArrayY = new double[ArrayA.GetLength(0)];
            //ArrayYSort = new double[ArrayA.GetLength(0)];
        }
    }
}
