// Найти сумму чисел одномерного массива ,стоящих на нечётной позиции. 

  void Function(int[] array)
   {
  int length = array.Length;
  int i = 0;
    for (i = 0; i < length; i++)
     {
        array[i] = new Random().Next(0,10);
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
void SumOddIn(int[] array)
{
    int count = array.Length;
    int i = 0 ;
    int sum = 0;
   for (i = 0 ; i <count; i = i+ 2)

    {  
         sum += array[ i + 1 ];     
    }
    Console.WriteLine($"Сумма чисел,стоящих на нечётной позиции в массиве = {sum}");
}
int[] newsum  = new int [6];
Console.WriteLine();
Function( newsum);
PrintArray( newsum );
Console.WriteLine();
SumOddIn( newsum );
Console.WriteLine();

