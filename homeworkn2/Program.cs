 
 Console.WriteLine("Выбрано два числа ") ;
int numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);

int max;
int min;

if (numberA > numberB) 
{
max = numberA ;
min = numberB ;
}
else 
{
max = numberB ;
min = numberA ;
}
Console.WriteLine(" max = ");
Console.WriteLine( max );
Console.WriteLine( "min = ");
Console.WriteLine( min );




