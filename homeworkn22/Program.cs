// Задача 22: Найти расстояние между точками в пространстве 2D/3D.

namespace nomer22
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Рассчитать расстояние  между точками в пространстве 2D или 3D. Введите цифру 1 для - 2D или 2 для -  3D ");
                string var = Console.ReadLine();
                if (var == "1")
                {
                    PlaneMode();
                    break;
                }
                else if ( var == "2")
                {
                    AreaMode();
                    break;
                }
                
                    
            }

        }

        private static void PlaneMode()
        {
            Console.WriteLine(" Для рассчёта в программе 2D необходимы координаты x1, x2, y1, y2");

            double x1 = InputDouble("Введите x1: ");
            double x2 = InputDouble("Введите x2: ");
            double y1 = InputDouble("Введите y1: ");
            double y2 = InputDouble("Введите y2: ");

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками в 2D равно {distance}");

        }

        private static void AreaMode()
        {
            Console.WriteLine(" Для рассчёта в программе 3D необходимы  координаты x1, x2, y1, y2, z1, z2");

            double x1 = InputDouble("Введите x1: ");
            double x2 = InputDouble("Введите x2: ");
            double y1 = InputDouble("Введите y1: ");
            double y2 = InputDouble("Введите y2: ");
            double z1 = InputDouble("Введите z1: ");
            double z2 = InputDouble("Введите z2: ");

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"Расстояние между двумя точками в 3D равно {distance}");
        }
    
        private static double InputDouble(string text)
        { 
            while (true)
            {
                Console.WriteLine(text);
                string input =Console.ReadLine();
                bool isDouble = double.TryParse(input,out double chDouble);
                if (isDouble)
                {
                    return chDouble;
                }
                else
                   Console.WriteLine("Некорректный ввод ,попробуйте ещё раз ");
            }          
        }
    }   
}    