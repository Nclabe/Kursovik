using System.Diagnostics;

namespace LibraryForCoursework
{
    public class Utils
    {
        /// <summary>
        /// Метод для печати одномерного массива
        /// </summary>
        /// <param name="arr">Одномерный массив</param>
        //public void PrintArray(double[] arr) {
        //    for(int i = 0; i < arr.Length; i++)
        //        Console.Write($"{arr[i]:f4}" + " | ");
        //}

        ///// <summary>
        ///// Перегрузка метода для печати двумерного массива
        ///// </summary>
        ///// <param name="arr">Двумерный массив</param>
        //public void PrintArray(double[,] arr)
        //{
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //        for(int j = 0; j<arr.GetLength(1);j++)
        //            Console.Write($"{arr[i, j]:f4}" + " | ");
        //}

        ///// <summary>
        ///// Метод возвращающий отформатированную строку затраченного времени на кусок кода. Выполняйте данный метод после того, как засекли время!
        ///// </summary>
        ///// <param name="stopwatch">Объект класса Stopwatch</param>
        ///// <returns>Отформатированная строка затраченного времени</returns>
        //public string PrintTime(Stopwatch stopwatch)
        //{
        //    TimeSpan ts = stopwatch.Elapsed;
        //    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        //        ts.Hours, ts.Minutes, ts.Seconds,
        //        ts.Milliseconds / 10);
        //    return elapsedTime;
        //}
    }
}
