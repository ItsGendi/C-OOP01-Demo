using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP01
{
    internal struct Point01
    {
        public int x;
        public int y;

        public static implicit operator Point01(Point v)
        {
            throw new NotImplementedException();
        }
    }
}
