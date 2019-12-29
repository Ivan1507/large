using System;
using System.Collections.Generic;
using System.Text;

namespace large
{
   
    class child
    {
        public delegate void del(string mes);
        public del d;
        //public event del d;
       
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
                switch (x)
                {
                    case 2:
                        scholaship = 0;
                        break;
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
