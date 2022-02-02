 
 Console.WriteLine("Выбрано два числа ") ;

 int numberA = new Random().Next(1, 100);
 Console.WriteLine(numberA);
 int numberB = new Random().Next(1, 100) ;
 Console.WriteLine(numberB);
 int max = numberA ;
 int min = numberB ;
if (numberA > max) max = numberA ;
if (numberB > max) max = numberB ;
if (numberA < min) min = numberA ;
if (numberB < min) min = numberB ;
 
Console.WriteLine("max = ");
Console.WriteLine(max) ;

Console.WriteLine("min = ");
Console.WriteLine(min) ;


