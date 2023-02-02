using LibraryForCoursework;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
DataController controller= new DataController();
Utils utils = new Utils();
AllData.E = 0.001;
AllData.xInitial = -0.3;
AllData.xFinal = 0.3;
AllData.H = 0.1;
int c = 0;
for (double i = AllData.xInitial; i <= AllData.xFinal; i += AllData.H)
{
   ++c;

}
AllData.LenghtA = c;
AllData.ArrayA = new double[AllData.LenghtA];
AllData.ArrayAControl = new double[AllData.LenghtA];
AllData.ArrayB = new double[AllData.ArrayA.Length, AllData.ArrayA.Length];
AllData.ArrayC = new double[AllData.ArrayA.Length];
AllData.ArrayY = new double[AllData.ArrayA.Length];
controller.SetArrayA();
controller.SetArrayB();
controller.SetArrayC();



Console.WriteLine("============================== ARRAY A ==============================");
utils.PrintArray(AllData.ArrayA);
Console.WriteLine("\n============================================================");
Console.WriteLine("============================== ARRAY B ==============================");
utils.PrintArray(AllData.ArrayB);
Console.WriteLine("\n============================================================");
Console.WriteLine("============================== ARRAY C ==============================");
utils.PrintArray(AllData.ArrayC);
Console.WriteLine("\n============================================================");
stopwatch.Stop();
Console.WriteLine(utils.PrintTime(stopwatch));

Console.Read();