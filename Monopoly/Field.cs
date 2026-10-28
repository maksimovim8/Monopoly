using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TEST
{
    internal class Field
    {
        private string f_name;
        private int f_cost;

        public Field(string Name, int Cost)
        {
            this.f_name = Name;
            this.f_cost = Cost;
        }
        
        public int get_cost()
        {
            return f_cost;
        }

        public void field_touch(Player player)
        {
            Console.WriteLine("My name is " + f_name + " Player step on me.");
        }
    }
}
