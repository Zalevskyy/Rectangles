using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    /// <summary>
    /// Class represents a rectangle
    /// has two properties: Width and Height
    /// </summary>
    class Rectangle: Figure
    {
        /// <summary>
        /// Create a rectangle at width and height
        /// </summary>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <param name="startPoint">coordinate of left-top point</param>
        public Rectangle(int width, int height, Point startPoint)
        {
            try
            {
                if (width > 0 && height > 0)
                {
                    Width = width;
                    Height = height;
                }               
                else
                    throw new SizeException("Wrong size");
                StartPoint = startPoint;
            }
            catch (SizeException e)
            {
                Console.WriteLine("Creating error: " + e.Message);
            }
        }
        /// <summary>
        /// Create a rectangle at two points
        /// </summary>
        /// <param name="leftTop">coordinate of left-top point</param>
        /// <param name="rightBottom">coordinate of right-bottom point</param>
        public Rectangle(Point leftTop, Point rightBottom)
        {
            try
            {
                if (rightBottom.X > leftTop.X && leftTop.Y > rightBottom.Y)
                {
                    Width = rightBottom.X - leftTop.X;
                    Height = leftTop.Y - rightBottom.Y;
                }
                else
                    throw new SizeException("Wrong points");
                StartPoint = leftTop;
            }
            catch (SizeException e)
            {
                Console.WriteLine("Creating error: " + e.Message);
            }
        }
        /// <summary>
        /// Method resizes rectangle
        /// </summary>
        /// <param name="deltaWidth">increase of width</param>
        /// <param name="deltaHeight">increase of height</param>
        public void ReSize(int deltaWidth, int deltaHeight)
        {
            try
            {
                if (Width + deltaWidth > 0 && Height + deltaHeight > 0)
                {
                    Width += deltaWidth;
                    Height += deltaHeight;
                }
                else
                    throw new SizeException("Wrong size");
            }
            catch (SizeException e)
            {
                Console.WriteLine("ReSize error: "+e.Message);
            }
        }
        /// <summary>
        /// merger of two rectangles
        /// </summary>
        /// <param name="rectangle1"></param>
        /// <param name="startPoint1"></param>
        /// <param name="rectangle2"></param>
        /// <param name="startPoint2"></param>
        public static Rectangle MinJointedRectangle(Rectangle rectangle1, Rectangle rectangle2)
        {
            Point leftTop;
            Point rightBottom;
            try
            {
                if (rectangle1.StartPoint.X < rectangle2.StartPoint.X)
                    if (rectangle1.StartPoint.Y > rectangle2.StartPoint.Y)
                    {
                        leftTop = rectangle1.StartPoint;
                        rightBottom = new Point(rectangle2.StartPoint.X + rectangle2.Width, rectangle2.StartPoint.Y - rectangle2.Height);
                    }
                    else
                    {
                        leftTop = new Point(rectangle1.StartPoint.X, rectangle2.StartPoint.Y);
                        rightBottom = new Point(rectangle2.StartPoint.X + rectangle2.Width, rectangle1.StartPoint.Y - rectangle1.Height);
                    }
                else
                    if (rectangle2.StartPoint.Y > rectangle1.StartPoint.Y)
                {
                    leftTop = rectangle2.StartPoint;
                    rightBottom = new Point(rectangle1.StartPoint.X + rectangle1.Width, rectangle1.StartPoint.Y - rectangle1.Height);
                }
                else
                {
                    leftTop = new Point(rectangle2.StartPoint.X, rectangle1.StartPoint.Y);
                    rightBottom = new Point(rectangle1.StartPoint.X + rectangle1.Width, rectangle2.StartPoint.Y - rectangle2.Height);
                }
                return new Rectangle(leftTop, rightBottom);
            }
            catch (Exception e)
            {
                Console.WriteLine("MinJointedRectangle: " + e.Message);
            }
            return null;
        }
        /// <summary>
        /// cross of two rectangles
        /// </summary>
        /// <param name="rectangle1"></param>
        /// <param name="startPoint1"></param>
        /// <param name="rectangle2"></param>
        /// <param name="startPoint2"></param>
        public static Rectangle CrossingRectangle(Rectangle rectangle1, Rectangle rectangle2)
        {
            int width;
            int height;
            int x;
            int y;
            try
            {
                if (rectangle1.StartPoint.X < rectangle2.StartPoint.X)
                {
                    width = rectangle1.StartPoint.X + rectangle1.Width - rectangle2.StartPoint.X;
                    x = rectangle2.StartPoint.X;
                }
                else
                {
                    width = rectangle2.StartPoint.X + rectangle2.Width - rectangle1.StartPoint.X;
                    x = rectangle1.StartPoint.X;
                }
                    
                if (width <= 0)
                    throw new SizeException("Rectangles don`t cross");

                if (rectangle1.StartPoint.Y > rectangle2.StartPoint.Y)
                {
                    height = rectangle2.StartPoint.Y - rectangle1.StartPoint.Y + rectangle1.Height;
                    y = rectangle2.StartPoint.Y;
                }
                else
                {
                    height = rectangle1.StartPoint.Y - rectangle2.StartPoint.Y + rectangle2.Height;
                    y = rectangle1.StartPoint.Y;
                }                   
                if (height <= 0)
                        throw new SizeException("Rectangles don`t cross");
                return new Rectangle(width, height, new Point(x,y));
            }
            catch (SizeException e)
            {
                Console.WriteLine("CrossingRectangle: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("CrossingRectangle: " + e.Message);
            }
            return null;
        }
    }
}
