using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    /// <summary>
    /// Interface for inheritance by some figure drowers
    /// </summary>
    interface IDrawFigure
    {
        void Draw(Figure figure);
        void Move(Figure figure, Point newPoint);
    }
}
