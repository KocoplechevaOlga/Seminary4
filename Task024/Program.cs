// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers (int number)
{
    int sum = default;
    for (int i = 1; i <= number; i++ )
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine("Введите цело число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int s = SumNumbers(n);
    Console.WriteLine($"Сумма чисел от 1 до {n} составляет {s}");
}
else 
{
  Console.WriteLine("Введите целое положительное число");  
}
