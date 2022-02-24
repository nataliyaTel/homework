// Задать массив,заполнить случайными положительными трёхзначными числами.Показать количество нечётных/четных чисел.

void Function(int[] array)
{
    int length = array.Length;
    int i = 0;
    for (i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    for (i= 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void QuanChetOdd(int[] array)
{
    int count = array.Length;
    int i = 0;
    int quanChet = 0;
    int quanOdd = 0;

    for (i = 0; i < count; i++)
    {
        if (array[i] % 2 == 0)
        {
            quanChet++;
        }
        else
        {
            quanOdd++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве  = {quanChet}");
    Console.WriteLine();
    Console.WriteLine($"Количество нечётных чисел в массиве = {quanOdd}");
}
int[] chetOdd = new int[9];
Console.WriteLine();
Function(chetOdd);
PrintArray(chetOdd);
Console.WriteLine();
QuanChetOdd(chetOdd);
Console.WriteLine();