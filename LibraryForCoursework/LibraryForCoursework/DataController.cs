using static LibraryForCoursework.AllData;
namespace LibraryForCoursework
{
    public class DataController
    {
        /// <summary>
        /// Метод используется для установки значений в массив А
        /// </summary>
        public void SetArrayA(){
            InfiniteSeries infiniteSeries = new InfiniteSeries();
            int i = 0;
            for (double x = xInitial; x <= xFinal; x += H){               
                Sum = 0;
                ArrayA[i] = infiniteSeries.Recurse(1, Sum, x);
                ArrayAControl[i] = infiniteSeries.ControlSummand(x);
                i++;
            }
        }

        /// <summary>
        /// Метод используется для установки значений в массив B
        /// </summary>
        public void SetArrayB(){
            Random random = new Random();
            for (int i = 0; i < ArrayB.GetLength(0); i++){
                for (int j = 0; j < ArrayB.GetLength(1); j++)
                    ArrayB[i, j] = random.Next(lowerBound, upperBound);
            }
        }

        /// <summary>
        /// Метод используется для установки значений в массив C
        /// </summary>
        public void SetArrayC(){
            for (int i = 0; i < ArrayB.GetLength(0); i++){
                for (int j = 0; j < ArrayB.GetLength(1); j++)
                    ArrayC[i] = ArrayB[i, j] * ArrayB[i, j] * ArrayA[j];
            }
        }

        public void SetArrayY(){

        }

        public void SaveDataToFile(){

        }

        public void SortData() {
        
        }
    }
}
