//  Написать программу масштабирования фигуры.
 // Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
 // Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
// В результате были выводились полученные координаты.
// При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"  
    
string m = "0,5";
double k = double.Parse(m);
string input = "(0,0) (2,0) (2,2) (0,2)";
string[] arrInput = input.Split(' ');

List<double> numbers = new List<double> { };
            foreach (string i in arrInput)
            {
                string element = i;
                element = element.Replace("(", "");
                element = element.Replace(")", "");
                numbers.Add(double.Parse(element));
            }


            foreach (double i in numbers)
                Console.Write($"({i * k:F1}) ");

Console.WriteLine();

        
    


