//  Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.WriteLine("Введите количество строк - m ");
 int m =  int.Parse(Console.ReadLine());
 Console.WriteLine("Введите количество строк - n ");
 int n = int.Parse( Console.ReadLine());
 int [,] matr = new int [m,n];

// void PrintArray( int [,]matr)
 //{
 
   for(int i=0; i< matr.GetLength(0); i++)
    {
      for(int j=0; j<matr.GetLength(1); j++)
       {
          Console.Write( $"{ matr [i,j] } ");
       }
      Console.WriteLine();
    }
// }
 Console.WriteLine();
 //void FillArray( int [,] matr)
  //{

    for(int i=0; i< matr.GetLength(0); i++)
    {
       for(int j=0; j<matr.GetLength(1); j++)
       {
           matr[i,j]= i+j ;
           Console.Write(matr [i,j] + " ");
       }
       Console.WriteLine();
    }
   Console.WriteLine();
  //}
      int res =0 ;
  for(int i=0; i< matr.GetLength(1); i++)
    {    
        
       for(int j=0; j<matr.GetLength(0); j++)
       {
           res += matr [j,i] ;
          
       }
       Console.WriteLine((double)res/matr.GetLength(0));
    }
 //PrintArray( matrix);
 //FillArray( matrix);
 Console.WriteLine( );
 //PrintArray( matrix);