// Покажите кубы чисел ,заканчивающися на чётную цифру .

Console.WriteLine("Введите число"); 
int a =1 ;
int b =int.Parse(Console.ReadLine());
 
   for (int i =a; i<=b; i++)
   { 
       if ( i*i*i %2 == 0)
     {    
      Console.WriteLine( i*i*i ) ;
     }      
      
   } 