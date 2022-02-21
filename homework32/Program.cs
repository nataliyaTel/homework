// Задайте массив из восьми элементов ,заполненных нулями и единицами.Выведите их на экран.

int[] array = {0,1,0,1,0,1,0,1};

void Function(int[]array)
{
     for (int i =0; i< array.Length; i++) 
     Console.WriteLine(array[i]);
}
Function(array);