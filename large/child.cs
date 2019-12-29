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
        LinkedList<child> marks = new LinkedList<child>();
     
        
       public void output()
        {
            foreach(var pair in subj)
            {
                Console.WriteLine(pair);
            }
        }
        
       
        public string Name { get; set; }
        public int Age { get; set; }


    }
}
