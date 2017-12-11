using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    /// <summary>
    /// abstract class for create some figures
    /// </summary>
    abstract class Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point StartPoint { get; set; }
    }
}
