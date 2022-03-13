// Найти расстояние между точками в пространстве 2D/3D
double[] point_1 = new double[3];
double[] point_2 = new double[3];
ReadArry(point_1);
ReadArry(point_2);
Console.WriteLine(SearchDinstance(point_1, point_2));

void ReadArry (double[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
    Console.WriteLine("введите координату");
    arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double SearchDinstance(double[] arr_1, double[] arr_2)
{
double distance = Math.Pow(Math.Pow(arr_1[0]-arr_2[0], 2) + Math.Pow(arr_1[1]-arr_2[1], 2)+Math.Pow(arr_1[2]-arr_2[2], 2),0.5);
return distance;
}


