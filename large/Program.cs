using System;
using System.IO;

namespace large
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var Piskarev = new family()
            //    {
            //        coc = 5,
            //        Surename = "Пискарев",
            //        benefit = 300
            //    };
            //    Piskarev.lrg();
            //    Console.WriteLine(Piskarev.ToString());
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //var Razinkin = new family()
            //{
            //    Count_of_child = 5,
            //    Surename = "Разинкин",
            //    benefit = 200
            //};
            //Razinkin.lrg();
            //Console.WriteLine(Razinkin.ToString());
            string path = @"C:\Users\Иван\Desktop\1.txt";
            var Ivan = new child()
            {
                stud_bilet = "8170828",
                num_of_coures = 2,
                scholaship = 2500
            };
            Console.WriteLine(Ivan.ToString());
            Ivan.output();
            Console.WriteLine(Ivan.ToString());
            string text = Ivan.ToString();
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(text);
            }
            
        }
    }
}


       