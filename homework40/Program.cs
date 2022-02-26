// В указанном массиве вещественных чисел найти разницу меду максимальным и минимальным элементами.

void Function(double[] array)
   {
  int length = array.Length;
  int i = 0;
    for (i = 0; i < length; i++)
     {
        array[i] = new Random().Next(-10,10);
     }
   }
void PrintArray(double[] array)
{
    int count = array.Length;
    int i = 0;
  for (i= 0; i < count; i++)
   {
        Console.Write($"{array[i]} ");
    }
}
void Delta(double[] array)
{
    int i= 0 ;
    int length = array.Length;
    double max = 0;
    double min = 0;
    for (i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");
}
double[] array = new double[9];
Console.WriteLine();
Function(array);
PrintArray(array);
Console.WriteLine();
Delta(array);
Console.WriteLine();

