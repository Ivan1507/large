using System;
using System.Collections.Generic;
using System.Text;

namespace large
{
    class family
    {
        public int  Count_of_child { get; set; }
        public int coc
        {
            get
            {
                return Count_of_child;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Детей не может быть меньше 0");
                }
                else
                {
                    Count_of_child = value;
                }
            }
        }
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
        public void dvo()
        {
            benefit -=200;
        }
       
    }
}
