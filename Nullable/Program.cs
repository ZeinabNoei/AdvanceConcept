using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Nullable<T> where T : struct
    {
        public Nullable()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">شما باید مقدار را از نوع غیر ابجکت وارد کنید</param>
        public Nullable(T value)
        {
            Value = value;
        }
        private T _value;
        public T Value
        {
            get
            {

                return
                    _value;
            }

            set
            {

#pragma warning disable CS0183 // 'is' expression's given expression is always of the provided type
                HasValue = value is T;
#pragma warning restore CS0183 // 'is' expression's given expression is always of the provided type
                if (HasValue)
                {
                    _value = value;
                }
            }
        }

        public bool HasValue { get; set; }

        public static implicit operator Nullable<T>(T Value)
        {
            return new Nullable<T>(Value);
        }
        public static explicit operator T(Nullable<T> value)
        {
            return value.Value;
        }
    }
}
