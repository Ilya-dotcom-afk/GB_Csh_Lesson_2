// Показать числа от -N до N

Console.WriteLine("введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0)
{
PositivPrint(n);
}
else{
    NegativPrint(n);
}

void PositivPrint(int a){
for(int i = -a; i <= a; i++)
  {
      Console.Write(i + " ");
  }
}

void NegativPrint(int a){
for(int i = -a; i >= a; i--)
  {
      Console.Write(i + " ");
  }
}

