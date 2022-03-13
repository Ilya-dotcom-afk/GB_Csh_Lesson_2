// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Ведите значение Х оличное от нуля");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите значение Y оличное от нуля");
double y = Convert.ToDouble(Console.ReadLine());
DetectedQuadro(x, y);
void DetectedQuadro(double x, double y)
{

    if (x>0.0 && y>0.0) Console.WriteLine("1-ая четверть");
    else if (x>0.0 && y<0.0) Console.WriteLine("4-ая четверть");
    else if (x<0.0 && y<0.0) Console.WriteLine("3-я четверть");
    else if (x<0.0 && y>0.0) Console.WriteLine("2-ая четверть");
    else Console.WriteLine("Введены неверные данные");
}