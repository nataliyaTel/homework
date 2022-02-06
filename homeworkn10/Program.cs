// Показать вторую цифру трёхзначного числа

int Numer(int k)
{
 int num =k / 10;
 return num ;
}    
int Numer1(int b)
{
 int num1 =b % 10;
 return num1 ;
}   
Console.WriteLine("Ввести трёхзначное число - ");
int a = int.Parse(Console.ReadLine());
int k =Numer(a);
int b =Numer1(k);
Console.WriteLine( "вторая цифра : " + b);
