using System;
using System.Collections.Generic;
using System.Text;

namespace large
{
   
    class child
    {
        public delegate void del();
        public event del d;
         
       
        List<string> subj = new List<string>() {
            "Английский",
            "Базы Данных",
            "Программирование на C#",
            "Мат.Анализ"
        };
         
     
        
       public void output()
        {
            int x;
            Console.WriteLine("Введите успеваемость студента:");
            foreach(var pair in subj)
            {
                Console.Write(pair+" -");
                x=int.Parse(Console.ReadLine());
                if (x == 2)
                {
                    d?.Invoke();
                    scholaship = 0;
                     
                }
                      
                
            }

        }
        public void Del()
        {
            int x = 10;
            for (int i=0;i<15;i++)
            {
                if (i == 3)
                {
                    d?.Invoke();
                }
            }
        }
        
       
        public string stud_bilet { get; set; }
        public int num_of_coures { get; set; }
        public int scholaship { get; set; }
        public override string ToString()
        {
            return $"Зачетная книжка студента:{stud_bilet} курс:{num_of_coures} стипендия:{scholaship}";
        }

    }
}
