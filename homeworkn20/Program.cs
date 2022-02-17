//Задача 20: Задать номер четверти, показать диапазоны для возможных координат
namespace nomer20
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = InputNumber();

            if (var == 1)
                Console.WriteLine(" Диапазон 1 координатной четверти от x 0,y 0 до x(inf), y(inf)");
            if (var == 2)
                Console.WriteLine(" Диапазон 2 координатной четверти от x 0,y 0 до -x(inf), y(inf)");
            if (var == 3)
                Console.WriteLine(" Диапазон 3 координатной четверти от x 0,y 0 до -x(inf), -y(inf)");
            if (var == 4)
                Console.WriteLine( "Диапазон 4 координатной четверти  от x 0,y 0 до x(inf), -y(inf)");
        }

        private static int InputNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите номер координатной четверти (1, 2, 3 или 4): ");
                string inputStr = Console.ReadLine();

                bool isCor = int.TryParse(inputStr, out int chCor);

                if (!isCor && chCor < 1 && chCor > 4)
                    Console.WriteLine("Некорректный ввод ,попробуйте ещё раз");
                else return chCor;
            }
        }
    }
}