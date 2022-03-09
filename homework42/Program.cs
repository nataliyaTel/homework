// Определить, сколько чисел больше 0 введено с клавиатуры.

 Console.WriteLine("Введите значение N - количество чисел вводимых с клавиатуры ");
 int n = Convert.ToInt32( Console.ReadLine() );
 int col = 0;
 for (int i=0;i<n;i++)
  {
    Console.WriteLine("Введите число: "); 
    int a = Convert.ToInt32( Console.ReadLine() );
    if (a>0) col = col + 1 ;
    
  }  
 Console.WriteLine("количество положительных чисел = {0}", col);
 Console.ReadKey();

