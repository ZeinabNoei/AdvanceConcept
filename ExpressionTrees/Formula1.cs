using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTrees
{
   public  class Formula1
    {
        private static List<Racer> racers;
        public static IList<Racer> GetChampions()
        {
            if (racers == null)
            {
                racers = new List<Racer>(40);
                racers.Add(new Racer("Nino", "Farina", "Italy", 33, 5, new int[] { 1950 }, new string[] { "Alfa Romeo" }, "This is very sesitive."));
                racers.Add(new Racer("Alberto", "Ascari", "Italy", 32, 10, new int[] { 1952, 1953 }, new string[] { "Ferrari" }, "This racer is a blackboard."));
                racers.Add(new Racer("Juan Manuel", "Fangio", "Argentina", 51, 24, new int[] { 1951, 1954, 1955, 1956, 1957 }, new string[] { "Alfa Romeo", "Maserati", "Mercedes", "Ferrari" }, "Freak in nature."));
                racers.Add(new Racer("Mike", "Hawthorn", "UK", 45, 3, new int[] { 1958 }, new string[] { "Ferrari" }, "He plays guitar very good."));
                racers.Add(new Racer("Phil", "Hill", "USA", 48, 3, new int[] { 1961 }, new string[] { "Ferrari" }, "Founder of bullshit company."));
                racers.Add(new Racer("John", "Surtees", "UK", 111, 6, new int[] { 1964 }, new string[] { "Ferrari" }, "Hello everyone."));
                racers.Add(new Racer("Jim", "Clark", "UK", 72, 25, new int[] { 1963, 1965 }, new string[] { "Lotus" }, "Are you listening?"));
                racers.Add(new Racer("Jack", "Brabham", "Australia", 125, 14, new int[] { 1959, 1960, 1966 }, new string[] { "Cooper", "Brabham" }, "What are you doing right now?"));
                racers.Add(new Racer("Denny", "Hulme", "New Zealand", 112, 8, new int[] { 1967 }, new string[] { "Brabham" }, "I don't care."));
                racers.Add(new Racer("Graham", "Hill", "UK", 176, 14, new int[] { 1962, 1968 }, new string[] { "BRM", "Lotus" }, "This one is outrage."));
                racers.Add(new Racer("Jochen", "Rindt", "Austria", 60, 6, new int[] { 1970 }, new string[] { "Lotus" }, "Made of honer."));
                racers.Add(new Racer("Jackie", "Stewart", "UK", 99, 27, new int[] { 1969, 1971, 1973 }, new string[] { "Matra", "Tyrrell" }, "Oh, this is shit."));
                racers.Add(new Racer("Emerson", "Fittipaldi", "Brazil", 143, 14, new int[] { 1972, 1974 }, new string[] { "Lotus", "McLaren" }, "this one is made of scars."));
                racers.Add(new Racer("James", "Hunt", "UK", 91, 10, new int[] { 1976 }, new string[] { "McLaren" }, "oh bullshit."));
                racers.Add(new Racer("Mario", "Andretti", "USA", 128, 12, new int[] { 1978 }, new string[] { "Lotus" }, "Are you kidding?"));
                racers.Add(new Racer("Jody", "Scheckter", "South Africa", 112, 10, new int[] { 1979 }, new string[] { "Ferrari" }, "Nothing to say anymore 1."));
                racers.Add(new Racer("Alan", "Jones", "Australia", 115, 12, new int[] { 1980 }, new string[] { "Williams" }, "Nothing to say anymore 2."));
                racers.Add(new Racer("Keke", "Rosberg", "Finland", 114, 5, new int[] { 1982 }, new string[] { "Williams" }, "Nothing to say anymore 3."));
                racers.Add(new Racer("Niki", "Lauda", "Austria", 173, 25, new int[] { 1975, 1977, 1984 }, new string[] { "Ferrari", "McLaren" }, "Nothing to say anymore 4."));
                racers.Add(new Racer("Nelson", "Piquet", "Brazil", 204, 23, new int[] { 1981, 1983, 1987 }, new string[] { "Brabham", "Williams" }, "Nothing to say anymore 5."));
                racers.Add(new Racer("Ayrton", "Senna", "Brazil", 161, 41, new int[] { 1988, 1990, 1991 }, new string[] { "McLaren" }, "Nothing to say anymore 6."));
                racers.Add(new Racer("Nigel", "Mansell", "UK", 187, 31, new int[] { 1992 }, new string[] { "Williams" }, "Nothing to say anymore 7."));
                racers.Add(new Racer("Alain", "Prost", "France", 197, 51, new int[] { 1985, 1986, 1989, 1993 }, new string[] { "McLaren", "Williams" }, "Nothing to say anymore 8."));
                racers.Add(new Racer("Damon", "Hill", "UK", 114, 22, new int[] { 1996 }, new string[] { "Williams" }, "Nothing to say anymore 9."));
                racers.Add(new Racer("Jacques", "Villeneuve", "Canada", 165, 11, new int[] { 1997 }, new string[] { "Williams" }, "WoW..."));
                racers.Add(new Racer("Mika", "Hakkinen", "Finland", 160, 20, new int[] { 1998, 1999 }, new string[] { "McLaren" }, "Nothing to say anymore 10."));
                racers.Add(new Racer("Michael", "Schumacher", "Germany", 250, 91, new int[] { 1994, 1995, 2000, 2001, 2002, 2003, 2004 }, new string[] { "Benetton", "Ferrari" }, "Just nothing."));
                racers.Add(new Racer("Fernando", "Alonso", "Spain", 132, 21, new int[] { 2005, 2006 }, new string[] { "Renault" }, "Another bullshit."));
                racers.Add(new Racer("Kimi", "Räikkönen", "Finland", 148, 17, new int[] { 2007 }, new string[] { "Ferrari" }, "Another blackboard"));
                racers.Add(new Racer("Lewis", "Hamilton", "UK", 44, 9, new int[] { 2008 }, new string[] { "McLaren" }, "At last, the last bullshit."));
            }

            return racers;
        }

    }
}
