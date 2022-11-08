// Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// Например: [1,0,1,1,0,1,0,0]

int[] FillArray(int l)
{
    int[] array = new int[l];
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0, 2);
        //Console.Write(array[i] + ", ");
    }
    return array;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());

int [] res = FillArray(length);
PrintArray(res);
