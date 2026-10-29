using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;


namespace TEST
{
    class Player
    {
        public string p_Name { get; }
        float x = 0;
        float y = 0;
        public int money = 0;
        public int PurchasedFields { get; private set; } = 0;


        //x=0 , cube=3 newx=3
        //x=3, cube =5 newx=8
        //x=8 cube=2 newx=10

        public Player(string Name, int startMoney)
        {
            p_Name = Name;
            money = startMoney;
        }

        public void Move(int cube)
        {
            float newx = x + cube;
            x = newx;
        }

        public void Buy(Field cur_field)
        {

            if (cur_field.isSold)
            {
                Console.WriteLine("Field is already sold.");
                return;
            }

            if (money < cur_field.get_cost())
            {
                Console.WriteLine("Not enough money to buy this field.");
                return;
            }

            if (cur_field.TryBuy())
            {
                money -= cur_field.get_cost();
                PurchasedFields++;

                Console.WriteLine( p_Name + " bought field " + cur_field.get_name() +" for " + cur_field.get_cost() + ".");
            }
        }

        public float GetX() 
        { 
            return x; 
        }
    }
}
