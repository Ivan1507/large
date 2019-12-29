using System;

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
            var Ivan = new child()
            {
                stud_bilet="8172602",
                num_of_coures=3
            };
            Console.WriteLine(Ivan.ToString());
            Ivan.output();

        }
    }
}
