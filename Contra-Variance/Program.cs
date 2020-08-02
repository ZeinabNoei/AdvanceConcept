using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contra_Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
            IIndex<Shape> shapes = rectangles;
        }
     
    }
    interface IIndex<in T>
    {
        string Show(T item);
    }
    class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override string ToString()
        {
            return string.Format("Width: {0}, Height:{1}", Width, Height);
        }
        public string Show(Shape shape)
        {
            return string.Format("{0} Width: {1}, Height:{2}", shape.GetType().Name, shape.Width, shape.Height);
        }

    }

    class Rectangle : Shape { }
    class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[] data =
            {
            new Rectangle { Height= 1 , Width=2},
            new Rectangle { Height= 1 , Width=2},
            new Rectangle { Height= 1 , Width=2}
        };
        public static RectangleCollection GetRectangles()
        {
            return new RectangleCollection();
        }
        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index > this.data.Length)
                {
                    throw new ArgumentOutOfRangeException("index");

                }
                return this.data[index];
            }
        }
        public int count
        {
            get { return this.data.Length; }
        }
    }

}
