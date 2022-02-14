// Дано число обозначающее день недели.Выяснить,является номер дня недели выходным днём.
Console.WriteLine(" Введите число от 1 до 7");
int a = int.Parse(Console.ReadLine());

  while (true)
  {
     if (  a ==1 || a== 2 || a== 3 || a==4 || a ==5)
      { 
        
         Console.WriteLine("будний день" );
  
      }
      else if (  a==6 || a ==7 )
      {

         Console.WriteLine("выходной день");
      
      }
   return;
  }   
      
      
  
    

            
    