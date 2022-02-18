// Возведите число А в натуральную степерь В,используя цикл.

Console.WriteLine("Введите число А- основание степени: ");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В -показатель степени : ");

int B = int.Parse(Console.ReadLine());

int erection = A;

for (int i = 1; B > i; i++) erection = erection * A;

Console.WriteLine($"Возведение числа {A} в степень {B} = {erection}");









