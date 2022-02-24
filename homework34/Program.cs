// Написать программу для замены элементов массива на противоположные.


void Function(int[] array)
{
    int length = array.Length;
    int i = 0;
    for (i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
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


void OppositeArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    for (i = 0; i < count; i++)
    {
        array[i] = array[i] * -1;
        Console.Write($"{array[i]} ");
    }
}

int[] opposite = new int[20];

Function(opposite);
PrintArray(opposite);
Console.WriteLine();
OppositeArray(opposite);
Console.WriteLine();