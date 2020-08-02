using System;

namespace Covariance
{
    class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[] data =
            {
            new Rectangle { Height = 1 ,Width = 2},
            new Rectangle { Height = 3 ,Width = 4},
            new Rectangle { Height = 5 ,Width = 6}
        };
        public int count
        {
            get { return this.data.Length; }
        }
        Rectangle IIndex<Rectangle>.this[int index]
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
        public static RectangleCollection GetRectangles()
        {
            return new RectangleCollection();
        }
    }
}
