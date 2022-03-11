// Показать двумерный массив размером m×n, заполненный вещественными числами.



 double [,] matrix = new double [4,3];

 void PrintArray(double[,]matr)
 {
 
   for(int i=0; i< matr.GetLength(0); i++)
    {
      for(int j=0; j<matr.GetLength(1); j++)
       {
          Console.Write( $"{ matr [i,j] } ");
       }
      Console.WriteLine();
    }
 }
 
 void FillArray(double[,] matr)
  {

    for(int i=0; i< matr.GetLength(0); i++)
    {
       for(int j=0; j<matr.GetLength(1); j++)
       {
           matr[i,j] = new Random().NextDouble();
       }
       
    }

  }
 PrintArray( matrix);
 FillArray( matrix);
 Console.WriteLine();
 PrintArray( matrix);