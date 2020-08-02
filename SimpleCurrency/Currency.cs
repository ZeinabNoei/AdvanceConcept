using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCurrency
{
    struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return string.Format("${0}.{1,-2:00}", Dollars, Cents);
        }

        public static implicit operator float(Currency value)
        {
            //There is a slight cheat here — in fact, when converting a uint to a float, there can be a loss in precision, 
            //but Microsoft has deemed this error sufficiently marginal to count the uint-to-float cast as implicit.
            return value.Dollars + (value.Cents / 100.0f);
        }
        public static implicit operator long(Currency value)
        {
            //There is a slight cheat here — in fact, when converting a uint to a float, there can be a loss in precision, 
            //but Microsoft has deemed this error sufficiently marginal to count the uint-to-float cast as implicit.
            return value.Dollars + (value.Cents / 100L);
        }
        //if a float contains an inappropriate value, converting it to a Currency could give unpredictable results. Because of this risk, 
        //the conversion from float to Currency should be defined as explicit.
        public static explicit operator Currency(float value)
        {
            checked
            {
                // Fix this ...
                uint dollars = (uint)value;
                ushort cents = (ushort)((value - dollars) * 100);
                //ushort cents = System.Convert.ToUInt16((value - dollars) * 100);
                return new Currency(dollars, cents);
            }

        }

        // Fix this ...
        public static implicit operator Currency(uint value)
        {
            return new Currency(value / 100u, (ushort)(value % 100));
        }
        //public static implicit operator Currency(uint value)
        //{
        //    return new Currency(value, 0);
        //}

        //// Write cast from Curreny to uint here ...

        //public static implicit operator uint(Currency value)
        //{
        //    return value.Dollars;
        //}

    }
}
