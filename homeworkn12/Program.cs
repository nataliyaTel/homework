// Удалить вторую цифру трёхзначного чиcла
  
Console.WriteLine("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine());
int num3 = a % 10;
int num1 = a / 100;
Console.Write( num1);
Console.Write( num3);


