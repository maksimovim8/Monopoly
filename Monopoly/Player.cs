using System;
using System.Collections.Generic;
using System.Text;


namespace TEST
{
    class Player
    {
        float x = 0;
        float y = 0;
        public int money = 0;
        //x=0 , cube=3 newx=3
        //x=3, cube =5 newx=8
        //x=8 cube=2 newx=10

        public void Move(int cube)
        {
            float newx = x + cube;
            x = newx;
        }

        public void Buy(Field cur_field)
        {
            if (money >= cur_field.get_cost())
            {
                money -= cur_field.get_cost();
                Console.WriteLine("Player buy filed: ");
            }
        }

        public float GetX() 
        { 
            return x; 
        }
    }
}
