//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите чило дня недели (от 1 до 7)");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else{
    Console.WriteLine("Будний день");
}
