// Найти третью цифру числа или сообщить, что её нет
internal class Program
{
    static void Main(string[] args)
    {
        int num = InputNumber();

        string str = num.ToString();
       try
       {
            Console.WriteLine(str[2]);
        }
       catch
        {
           Console.WriteLine($"Третьей цифры нет. Число {str.Length}-значное.");
        }

    }

private static int InputNumber()
{
    while (true)
    {
        Console.WriteLine("Введите число: ");
        string Str1 = Console.ReadLine();

        bool i = int.TryParse(Str1, out int chek1);

        if (!i)
        
            Console.WriteLine("Вы ввели не число. Попробуйте ещё раз");
        
        else 
        
            return chek1;
        }
    }
}

        
    

