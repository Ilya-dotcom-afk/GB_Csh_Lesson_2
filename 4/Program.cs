// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("введите первое число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите второе число");
double b = Convert.ToDouble(Console.ReadLine());
if (a == b*b)
{
Console.WriteLine("число " + a + " является квадратом числа " + b);
}
else if (b == a*a)
{
Console.WriteLine("число " + b + " является квадратом числа " + a);
}
else
{
Console.WriteLine("числа не являются квадратами друг друга");
}