using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int width1 = 80;
            int height1 = 60;
            Point leftTop1 = new Point(0, 100);
            Rectangle rect1 = new Rectangle(width1,height1,leftTop1);
            IDrawFigure drawer = new DrawRectangle();
            drawer.Draw(rect1);
            drawer.Move(rect1, new Point(10,110));
            drawer.Draw(rect1);
            int width2 = 80;
            int height2 = 60;
            Point leftTop2 = new Point(50, 60);
            Rectangle rect2 = new Rectangle(width2, height2, leftTop2);
            drawer.Draw(rect2);
            Rectangle rect3 = Rectangle.MinJointedRectangle(rect1,rect2);
            Rectangle rect4 = Rectangle.CrossingRectangle(rect1,rect2);
            drawer.Draw(rect3);
            drawer.Draw(rect4);
            rect2.ReSize(-10, -20);
            drawer.Draw(rect2);
        }
    }
}
