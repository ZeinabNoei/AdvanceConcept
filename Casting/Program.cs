using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //byte b = 255;
            //unchecked
            //{
            //    b++;
            //}         
            //Console.WriteLine(b);
            #endregion   
            #region
            byte value1 = 255;
            byte value2 = 23;
            byte total;
            unchecked
            {
                total = (byte)(value1 + value2);
            }
            //int total;
            //total = (value1 + value2);

            Console.WriteLine(total);

            #endregion
            #region
            double x = 8.768;
            float y = 0;
            y = (float)(x);
            Console.WriteLine(y);
            #endregion
            #region 
            object o1 = 10;
            object o2 = 10;

            bool value = o1 == o2;
            value = o1.Equals(o2);
            value = o1 == o2;

            Myclass c1 = new Myclass();
            c1.x = 10;

            Myclass c2 = new Myclass();
            c2.x = 10;

            value = c1.GetHashCode() == c2.GetHashCode();
            value = c1.Equals(c2);
            value = c1.x == c2.x;

            MyStruct s1 = new MyStruct();
            s1.x = 10;

            MyStruct s2 = new MyStruct();
            s2.x = 10;

            value = s1.GetHashCode() == s2.GetHashCode();
            value = s1.Equals(s2);
            //value = s1 == s2;

            string ss1 = "this";
            string ss2 = "this";
            //نکته 1:string  غیر قابل تغییرن یعنی Imutable هستن 
            //نکته 2: value هاشو به صورت Hashing با هم equal میکنه 
            //نکته 3: s1=="A" S1="B" در واقع دو تا خونه تو هیپ بهش اختصاص میده 
            value = ss1.GetHashCode() == ss2.GetHashCode();
            value = object.ReferenceEquals(ss1, ss2);
            value = ss1.Equals(ss2);
            value = ss1 == ss2;
            Console.ReadKey();
            #endregion

        }
    }
    public class Myclass
    {
        public int x { get; set; }
    }
    public struct MyStruct
    {
        public int x { get; set; }
    }
}
