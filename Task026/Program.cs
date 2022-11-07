// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// Например: 456 -> 3; 78 -> 2; 89126 -> 5

int CountNumber (int number)
{
    int count = default;
    for (count = 0; number % 10 > 0; count++)
    {
        number = number / 10;
    }
    return count;
}
Console.WriteLine("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 0)
{
    int c = CountNumber(n);
    Console.WriteLine($"В числе {n} содержитсся цифр {c}");
}
else
{
    int n1 = n*(-1);
    int c = CountNumber(n1);
    Console.WriteLine($"В числе {n1} содержитсся цифр {c}");
}