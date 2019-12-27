using System;

namespace large
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pis = new family(5)
            {
               Surename="Пискарев"
            };
            Console.WriteLine(Pis.ToString());
        }
    }
}
