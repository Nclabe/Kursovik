



double y = 1,
    sum = 0,
    model;
int i = 1;



const double e = 0.001; //Точность
double a = -0.9;
double b = 0.9;
double h = 0.1;


Console.WriteLine("Контрол. форм. | Сумма | Отклонение");
for (double x = a; x < b; x += h)
{
    sum = 0;
    sum = RecurseFunction(x, i, e);
    model = 1 - 1 / Math.Sqrt(Math.Sqrt(1 + x)); // Подсчет контрольного значения
    Console.WriteLine($"|{model}|{sum}|{Math.Abs(Math.Abs(sum) - Math.Abs(model))}:f5");
}

// Метод возвращающий значение заданной функции


// Метод выполняющий рекурсию
double RecurseFunction(double x, int i, double e)
{
    y *= x * (4 * i - 3) / (4 * i);
    ++i;
    x = -x;
    sum += y;
    if (Math.Abs(y) > e)
        return RecurseFunction(x, i, e);
    else
        return sum;
}




