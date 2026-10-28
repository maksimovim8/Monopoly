using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    internal class Cube
    {
        protected System.Random random = new System.Random();

        public virtual int Throw_cube()
        {
            return random.Next(1,7);
        }
    }
}
