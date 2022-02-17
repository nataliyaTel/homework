// Проверить истинность утверждения не (X v Y)= не X ^ не Y
 

foreach (bool x in new[] { false, true })
            {
                foreach (bool y in new[] { false, true })
                {
                    if (!(x | y) == (!x & !y))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
