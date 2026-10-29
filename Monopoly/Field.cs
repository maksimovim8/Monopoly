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
        public bool isSold { get; private set; }

        public Field(string Name, int Cost)
        {
            this.f_name = Name;
            this.f_cost = Cost;
            isSold = false;
        }
        
        public int get_cost()
        {
            return f_cost;
        }

        public string get_name()
        {
            return f_name;
        }

        public void field_touch(Player player)
        {
            Console.WriteLine("My name is " + f_name + " Player " + player.p_Name + " step on me.");
            
            if (isSold)
            {
                Console.WriteLine("This field has already been sold.");
            }
        }
        public bool TryBuy()
        {
            if (isSold)
            {
                return false;
            }
            isSold = true;
            return true;
        }



    }
}
