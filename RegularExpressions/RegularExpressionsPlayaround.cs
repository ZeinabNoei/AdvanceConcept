using System;
using System.Text.RegularExpressions;


namespace RegularExpressions
{
    public static class RegularExpressionsPlayaround
    {

        public const string text = @"XML has made a major impact in almost every aspect of 
            software development. Designed as an open, extensible, self-describing 
            language, it has become the standard for data and document delivery on 
            the web. The panoply of XML-related technologies continues to develop 
            at breakneck speed, to enable validation, navigation, transformation, 
            linking, querying, description, and messaging of data.";

        public static void Find1()
        {
            string pattern = @"\bn\S*ion\b";
            MatchCollection matches = Regex.Matches(text, pattern,
               RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace |
               RegexOptions.ExplicitCapture);
            WriteMatches(text, matches);
        }

        public static void Find2()
        {
            string pattern = @"\bn";
            MatchCollection matches = Regex.Matches(text, pattern,
              RegexOptions.IgnoreCase);
            WriteMatches(text, matches);
        }

        public static void WriteMatches(string text, MatchCollection matches)
        {
            Console.WriteLine("Original text was: \n\n" + text + "\n");
            Console.WriteLine("No. of matches: " + matches.Count);
            foreach (Match nextMatch in matches)
            {
                int index = nextMatch.Index;
                string result = nextMatch.ToString();
                int charsBefore = (index < 5) ? index : 5;
                int fromEnd = text.Length - index - result.Length;
                int charsAfter = (fromEnd < 5) ? fromEnd : 5;
                int charsToDisplay = charsBefore + charsAfter + result.Length;

                Console.WriteLine("Index: {0}, \tString: {1}, \t{2}",
                   index, result,
                   text.Substring(index - charsBefore, charsToDisplay));

            }
        }

        public static void ReplaceRegEx()
        {
            //string pattern = "";//write a pattern to find Mr, Mr., Mrs., Miss, Ms, Ms."
            //string pattern = @"Mr?s?\.?|Miss";
            //string pattern = @"^Mr?\.?s?\.?\s";
            //string pattern = @"Mr?s?\.?";

            //string pattern = @"^M.?\s";
            string pattern = @"Mr?s?\.?|Miss";//write a pattern to find Mr, Mr., Mrs., Miss, Ms, Ms."
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
                         "Abraham Adams", "Ms. Nicole Norris" ,"Miss. Nicole Norris"};
            foreach (string name in names)
                Console.WriteLine(Regex.Match(name, pattern));
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, string.Empty));
        }

        public static void IdentifyDuplicatedWords()
        {

            //string pattern = @"\b(\w+)\s\1\b";//write pattern here...
            string pattern = @"\b(?<input>\w+)\s\<input>\b";//write pattern here...
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine("{0} (duplicates '{1})' at position {2}",
                                  match.Value, match.Groups[1].Value, match.Index);
        }

        public static void ProtocolandProt()
        {
            //Regex r = new Regex(@"(?i)a(?-i)a");



            //Console.WriteLine(r.Match("AAAa"));
            //Console.WriteLine(Regex.Match("say 25 miles more.", @"\d+\s(?=miles)"));

            //Console.WriteLine(Regex.Match("say 25 miles more.", @"\d+\s(?=miles).*"));

            //string pass = "1Hasan1";
            //bool ok = Regex.IsMatch(pass, @"(?=.*\d.{2,}).{6,}");

            //var x = 1;


            //string url = "http://www.contoso.com:8080/letters/readme.html";

            // Regex r = new Regex(@"^(?<proto>\w+://)(?<Address>[^/]+?)(?<port>:\d+)?/"); //modify this to extract address to

            //  Match m = r.Match(url);
            //  if (m.Success)
            //      //Console.WriteLine(r.Match(url).Result("${proto}${port}"));
            //      Console.WriteLine(r.Match(url).Result("${proto}${Address}${port}"));


            //Match m = r.Match(url);
            //if (m.Success)
            //    Console.WriteLine(r.Match(url).Result("${proto}${port}"));


            //Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/");
            // Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<Addres>\w)+:$+?(?<port>:\d+)?/");



            //Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/");
            //string protocol = (@"^(?<proto>\w+)://[^/0-9]+?(?<port>:\d+)?/");
            //string protocol = (@"^(?<proto>\w+)://");
            //string port = (@"$:[^/0-9]+?(?<port>:\d+)?/");
            ////string port = (@"^:[/0-9]+?(?<port>:\d+)");

            //foreach (Match match in Regex.Matches(url, protocol, RegexOptions.IgnoreCase))
            //    Console.WriteLine(Regex.Match(url, protocol));

            //foreach (Match match in Regex.Matches(url, port, RegexOptions.IgnoreCase))
            //    Console.WriteLine(Regex.Match(url, port));
            /////////////////////////////////////////////////////


            string url = "http://www.contoso.com:8080/letters/readme.html";

            // Regex r = new Regex(@"^(?<protocol>\w+)://[^/]+?(?<port>:\d+)?/"); //modify this to extract address to
            //Regex r = new Regex(@"^(?<protocol>\w+):*(?<sname>://\bw*?\.?\w+\.?com?\b)(?<port>:\d+)?/"); //modify this to
            Regex r = new Regex(@"^(?<protocol>\w+):*(?<sname>://\bw*?\.?\w+\.?com?\b)(?<port>:\d+)?/[^/]+?"); //modify this to

            Match m = r.Match(url);
            if (m.Success)
                Console.WriteLine(r.Match(url).Result("${protocol}${sname}${port}"));
        }

        public static void greedey()
        {
            //string Html = "<i>By default</i> quantifiers are <i>greedy</i> creatures";

            //foreach (Match  m in Regex.Matches (Html , @"<i>.*</i>"))
            //    Console.WriteLine(m);
            //foreach (Match m in Regex.Matches(Html, @"<i>.*?</i>"))
            //    Console.WriteLine(m);
            //////////////////////////////////////
            //string Text = "Don't loose (sic) your cool ";

            //Console.WriteLine(Regex.Match(Text, @"\b\w+\b\s(?=\(sic\))"));
            Console.Write("write a number:");
            var input = (Console.ReadLine());

            //string input = "";

            //do
            //{
            //    var key = Console.ReadKey();
            //    input += key.Key;
            //} while (Console.ReadKey(true).Key != ConsoleKey.Enter);



            string ssNum = @"\(\d{4}\)\s\d{2}(-|\s)\d{8}";
            Console.WriteLine(Regex.IsMatch(input, ssNum));
        }
        public static void Lookahead()
        {
            string regex = "(?!)good (?!)(however|but) ";

            Console.WriteLine(Regex.IsMatch("Good Work! But....", regex));
            Console.WriteLine(Regex.IsMatch("Good Work! Thanks!", regex));
        }

        public static void Lookbehind()
        {
            string regex = "(?i)(?<!however.*)good";
            Console.WriteLine(Regex.IsMatch("However good , we... ", regex));
            Console.WriteLine(Regex.IsMatch("Very good , thanks!", regex));
        }
        public static void Anchors()
        {
            string s = "";
            MatchCollection blankLines = Regex.Matches(s, "^[ \t]*(?=\r?$)", RegexOptions.Multiline);

        }

        public static void WordBoundaries()
        {

            string text = "Don't loose (sic) your cool";
            Console.WriteLine(Regex.Match(text, @"\b\w+\b\s(?=\(sic\))"));

        }

        public static void RecipesSocialSecurity()
        {
            string ssNum = @"\d{3}-\d{2}-\d{4}";
            Console.WriteLine(Regex.IsMatch("123-45-6789", ssNum));
            string phone = @"(?x)
                   ( \d{3}[-\s] | \(\d{3}\)\s?)
                    \d{3}[-\s]?
                     \d{4}";
            Console.WriteLine(Regex.IsMatch("123-456-7890", phone));

            Console.WriteLine(Regex.IsMatch("(123) 456-7890", phone));

        }
        public static void RecipesTimes()
        {
            string r = @"(?m)^\s*(?'name'\w+)\s*=\s*(?'value'.*)\s*(?=\r?$)";
            string text = @"id = 3
                            secure = true 
                                timeout = 30";

            foreach (Match m in Regex.Matches(text, r))
                Console.WriteLine(m.Groups["name"] + " is " + m.Groups["value"]);
        }
        public static void RecipesStrongpassword()
        {
            string r = @"(?x)^(?=.* ( \d | \p{P} | \p{S} )).{6,}";
            Console.WriteLine(Regex.IsMatch("abc12", r));
            Console.WriteLine(Regex.IsMatch("bcdef", r));
            Console.WriteLine(Regex.IsMatch("ab88yz", r));
        }
        public static void RecipesDates()
        {
            string r = @"(?x)(?i)
                   (\d{1,4}) [./-]
                   (\d{1,2})  [./-]
                   (\d{1,4}) [\sT]
                    (\d+):(\d+):(\d+) \s? (A\.?M\.?|P\.?M\.?)?";

            string text = "01/02/2008 5:20:50 PM";
            foreach (Group g in Regex.Match(text, r).Groups)
                Console.WriteLine(g.Value + " ");
        }

        public static void RecipesXML()
        {
            string r = @"<(?'tag'\w+?).*>" +
                 @"(?'text'.*?)" +
                 @"</\k'tag'>";

            string text = "<h1>hello</h1>";
            Match m = Regex.Match(text, r);
            Console.WriteLine(m.Groups["tag"]);
            Console.WriteLine(m.Groups["text"]);

        }
        public static void RecipesSplitting()
        {
            string r = @"(?=[A-Z])";
            foreach (string s in Regex.Split("oneTwoThree", r))
                Console.WriteLine(s + " ");

        }

    }
}
