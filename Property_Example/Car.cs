using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Example
{
    class Car
    {
        //public
        //private
        //protected
        //internal

        private int _speed;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("Bichare mimirihaaaaa ....");
                    _speed = 0;
                }
                else
                {
                    _speed = value;
                }
            }
        }


        private string _carName = "Pride";

        public string CarName
        {
            get
            {
                return _carName;
            }
        }
    }
}
