// Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
// Например: 4 -> 24; 5 -> 120

int Factorial(int num)
{
    int p = 1;
    for (int i = 1; i <= num; i++ )
    {
        p = p * i;
    }
    return p;
}
Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 0)
{
int f = Factorial(n);
Console.WriteLine($"Произведение чисел от 1 до {n} равно {f}");
}
else 
{
  Console.WriteLine("Введите положительное число");  
}
