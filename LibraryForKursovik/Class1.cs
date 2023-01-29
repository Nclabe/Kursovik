using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForKursovik
{
    public class Class1
    {

        public double CalculateSumSeries(double x, double e)
        {
            int i = 0;
            double sum = 0;
            double temp = 1;
            do
            {
                i++;
                temp = temp * (4 * i - 3) / (4 * i) * -x;
                sum += -temp;
            }
            while (Math.Abs(temp) > e);
            return sum;
        }

        public double Function(double x)
        {
            return 1 - (1 / Math.Sqrt(Math.Sqrt(1 + x)));
        }
    }
}
