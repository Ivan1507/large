using System;
using System.Collections.Generic;
using System.Text;

namespace large
{
    class family
    {
        public delegate void coc();
        public event coc c;
        public int Count_of_child { get; set; }
        public string Surename { get; set; }
        public bool large { get; set; }
        public override string ToString()
        {
            return $"Фамилия семьи:{Surename} Многодетная:{large}";
        }
        public family(int coc)
        {
            if (coc >= 3)
            {
                c?.Invoke();
                large = true;
            }
        }
    }
}
