// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.WriteLine("Введите количество строк - m ");
 int m =  int.Parse(Console.ReadLine());
 Console.WriteLine("Введите количество строк - n ");
 int n = int.Parse( Console.ReadLine());
 int [,] arr = new int [m,n];

    

    
    for(int i=0; i< arr.GetLength(0); i++)
    {
       for(int j=0; j<arr.GetLength(1); j++)
       {
           
           arr[i,j] = m+n;
           n++ ;
           
           Console.Write( $"{ arr [i,j] } ");
       }
      Console.WriteLine(); 
    }

    

 
 







