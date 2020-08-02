using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "fg1";
            Palindrome(str);

            IsAllDigits(str);




            //RegularExpressionsPlayaround.greedey();
            //RegularExpressionsPlayaround.Find1();
            // RegularExpressionsPlayaround.ReplaceRegEx();
            // RegularExpressionsPlayaround.IdentifyDuplicatedWords(); 
            //RegularExpressionsPlayaround.ProtocolandProt();
            //var x = new Nullable<int>();
            //int? y = null;
            //y=y ?? 0;
            //if(x.HasValue)
            //Console.WriteLine(x.Value);

            // string pass = "1hasan1";
            //var xxx= Regex.IsMatch(pass, @"(?=.*\d.{2,}).{6,}");
            // RegularExpressionsPlayaround. Lookahead();
            //RegularExpressionsPlayaround. Lookbehind();
            //RegularExpressionsPlayaround.Anchors();
            //RegularExpressionsPlayaround.WordBoundaries();
            //RegularExpressionsPlayaround.RecipesSocialSecurity();
            //RegularExpressionsPlayaround.RecipesTimes();
            RegularExpressionsPlayaround.RecipesDates();
            //RegularExpressionsPlayaround.RecipesStrongpassword();
            //RegularExpressionsPlayaround.RecipesXML();
            //RegularExpressionsPlayaround.RecipesSplitting();

            Console.ReadKey();
        }

        public static bool Palindrome(string str)
        {
            var m = Regex.IsMatch(str, @"^[a-zA-Z]+$");
            if (m == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                    return true;
            }
            return false;
            }

    }
}
