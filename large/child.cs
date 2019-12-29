using System;
using System.Collections.Generic;
using System.Text;

namespace large
{
   
    class child
    {
       
        List<string> subj = new List<string>() {
            "Английский",
            "Базы Данных",
            "Программирование на C#",
            "Мат.Анализ"
        };
         
     
        
       public void output()
        {
             
            Console.WriteLine("Введите успеваемость студента:");
            foreach(var pair in subj)
            {
                Console.Write(pair+" -");
                int x = int.Parse(Console.ReadLine());
                if (x == 2) Console.WriteLine("Студент имеет долги");
            }
           
        }
        
       
        public string stud_bilet { get; set; }
        public int num_of_coures { get; set; }
        public override string ToString()
        {
            return $"Зачетная книжка студента:{stud_bilet} курс:{num_of_coures}";
        }

    }
}
