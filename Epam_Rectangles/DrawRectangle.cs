using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    /// <summary>
    /// Class to draw rectangle
    /// </summary>
    class DrawRectangle : IDrawFigure
    {
        /// <summary>
        /// Method instead of (simulate) drawing rectangle
        /// </summary>
        /// <param name="rectangle">rectangle to draw</param>
        /// <param name="startPoint">point for start drawing (coordinate of right-top corner)</param>
        public void Draw(Figure rectangle)
        {
            try
            {
                Console.WriteLine($"Drawing rectangle with width {rectangle.Width} and height {rectangle.Height} start at point {rectangle.StartPoint}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Draw: Nothing to draw ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Draw: " + e.Message);
            }
        }
        /// <summary>
        /// Method simulate move rectangle
        /// </summary>
        /// <param name="rectangle">rectangle for move</param>
        /// <param name="newPoint">new coordinate of right-top corner</param>
        public void Move(Figure rectangle, Point newPoint)
        {
            try
            {
                rectangle.StartPoint = newPoint;
                Console.WriteLine($"Moving rectangle to new position");
                //Draw(rectangle);
            }
            catch (Exception e)
            {
                Console.WriteLine("Move: "+e.Message);
            }
        }
    }
}
