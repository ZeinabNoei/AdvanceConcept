using System;

namespace Covariance
{
     class Program
    {
        static void Main(string[] args)
        {
            IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
            IIndex<Shape> shapes = rectangles;
            Console.WriteLine(shapes[1].Height.ToString());
            Console.ReadKey();

            IDisplay<Shape> shapedisplay = new ShapeDisplay();
            IDisplay<Rectangle> rectangledisplay = shapedisplay;
            Console.WriteLine(rectangledisplay.Show(rectangles[0]));
            //Console.WriteLine(rectangledisplay.Show(shapes[0]));

            Console.WriteLine(shapedisplay.Show(rectangles[0]));
            Console.WriteLine(shapedisplay.Show(shapes[0]));

        }
    }
}
