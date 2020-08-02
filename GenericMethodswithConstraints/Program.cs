using System.Collections.Generic;

namespace GenericMethodswithConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
        public static decimal Accumulate<TAccount>(IEnumerable<TAccount> source)
            where TAccount:IAccount
        {
            decimal sum = 0;
            foreach (TAccount a in source )
            {
                //sum += a.Balance;
            }
            return sum;
        }
    }
   
}
