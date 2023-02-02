using static LibraryForCoursework.AllData;
namespace LibraryForCoursework
{
    public class InfiniteSeries
    {
        /// <summary>
        /// Метод возвращающий подсчитанное слагаемое
        /// </summary>
        /// <param name="x">Заданный X</param>
        /// <param name="i">i-ое слагаемое</param>
        /// <returns>Значение подсчитанного слагаемого</returns>
        private double GetSummand(double x, double i) => -x * (4 * i - 3) / (4 * i);

        /// <summary>
        /// Метод возвращающий подсчитанную контрольную формулу
        /// </summary>
        /// <param name="x">Заданный X</param>
        /// <returns>Значение контрольной формулы</returns>
        public double ControlSummand(double x) => 1 - 1 / Math.Sqrt(Math.Sqrt(1 + x));

        /// <summary>
        /// Метод выполняющий рекурсию заданного ряда
        /// </summary>
        /// <param name="summand">Первый член, в качестве параметра обычно передаётся цифра 1</param>
        /// <param name="sum">Переменная суммы ряда (передавайте её с нулевым значением)</param>
        /// <param name="x">Заданный X</param>
        /// <returns>Сумма ряда</returns>
        public double Recurse(double summand, double sum, double x)
        {
            ++I;
            summand *= GetSummand(x, I);
            sum += -summand;
            if (Math.Abs(summand) > E) // Выполняем рекурсию до достижения заданной точности
                return Recurse(summand, sum, x);
            else{
                I = 0; return sum;
            }
        }
    }
}