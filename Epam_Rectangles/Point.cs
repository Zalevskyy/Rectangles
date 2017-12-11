using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Override method ToString for Point
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "("+X+", "+Y+")";
        }
    }
}
