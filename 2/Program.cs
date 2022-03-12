// Показать четные числа от 1 до N
Console.WriteLine("Введите целое положительное число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for(int i = 0; i < array.Length; i++)
{
array[i] = i+1;
    if(array[i]%2 == 0)
    {
        Console.Write(array[i] + " ");
    }
}
