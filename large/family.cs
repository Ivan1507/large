using System;
using System.Collections.Generic;
using System.Text;

namespace large
{
    class family
    {
        public int Count_of_child { get; set; }
        public string Surename { get; set; }
        public bool large { get; set; }
        public int benefit { get; set; }
        public override string ToString()
        {
            return $"Фамилия семьи:{Surename} Многодетная:{large} Пособие={benefit}";
        }
  
        public void lrg()
        {
            if (this.Count_of_child >= 3)
            {
                this.large = true;
                benefit += 500;
            }
        }
       
    }
}
