using System;

namespace large
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pis = new family()
            {
                Count_of_child=-1,
               Surename="Пискарев",
               benefit=300
            };
            Pis.lrg();
            Console.WriteLine(Pis.ToString());
        }
    }
}
