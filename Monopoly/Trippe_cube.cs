using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    internal class Trippe_cube : Cube
    {
        public override int Throw_cube()
        {
            return random.Next(1, 7)*3;
        }
    }
}
