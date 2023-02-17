using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForCoursework
{
    public static class FormirationDataGrid //класс, который помогает выводить массивы в Дата Грид
    {
        public static DataTable ToDataTable<T>(this T[] arr)
        {
            var res = new DataTable();

            res.Columns.Add("Массив Y", typeof(T));
            for (int i = 0; i < arr.Length; i++)
            {
                
                var row = res.NewRow();
                row[0] = arr[i];
                res.Rows.Add(row);
            }


            return res;
        }


        public static DataTable ToDataTable<T>(T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add($"{i+1}", typeof(T));
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }
                res.Rows.Add(row);
            }
            return res;
        }
    }

}
