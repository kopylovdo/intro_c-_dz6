// Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Прямая задается уравнением y = k * x + b");

Console.Write("Введите значение b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Первое уравнение имеет вид y = {k1}x + {b1}");
Console.WriteLine($"Второе уравнение имеет вид y = {k2}x + {b2}");

if ((k1 == k2) & (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны. Точек пересечения нет.");
    }
    else
    {   
        double x = (b2-b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые пересекутся в точке с координатами ({Math.Round(x,2)};{Math.Round(y,2)})");
    }
}