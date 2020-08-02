using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq_Lambds
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqQuery();
            Console.ReadLine();
        }

        static void LinqQuery()
        {
            #region Intro
            var IntroLinq = from racer in Formula1.GetChampions()
                            where racer.Country == "Brazil"
                            orderby racer.Wins descending
                            select racer;
            // Write query lambda
            var Introlambda = Formula1.GetChampions().Where(delegate (Racer r) { return r.Country == "Brazil"; }).OrderByDescending(r => r.Wins).Select(r => r);
            var Introlambda1 = Formula1.GetChampions().Where(x => x.Country == "Brazil").OrderByDescending(x => x.Wins);
            ShowAllRacers(Introlambda1);
            #endregion


            #region Filtering
            var FilteringLinq = from r in Formula1.GetChampions()
                                where r.Wins > 15 &&
                                (r.Country == "Brazil" || r.Country == "Austria")
                                select r;
            // Write query using extension methods
            //var FilteringLambda = Formula1.GetChampions().Where(r => 2 + 1 > 3).Where(x => x.Wins >= 15);
            var FilteringLambda = Formula1.GetChampions().Where(r => r.Country == "Brazil" || r.Country == "Austria").Where(x => x.Wins >= 15);
            ShowAllRacers(FilteringLambda);
            #endregion

            #region Filtering with Index
            //write a query with where() overload here...
            var IndexLinq = Formula1.GetChampions().Where((r, i) => r.FirstName.StartsWith("A") && i % 2 == 0).ToList();
            ShowAllRacers(IndexLinq);
            #endregion

            #region Compound from
            // Filter all racers who were champions with ferrari
            var CompoundLinq = from racer in Formula1.GetChampions()
                               from car in racer.Cars
                               where car == "Ferrari"
                               orderby racer.LastName
                               select racer.FirstName + " " + racer.LastName;
            Show(CompoundLinq);
            var CompoundLambda = Formula1.GetChampions().
               SelectMany(r =>
                   r.Cars,
                       (r, c) => new { racer = r, Car = c }).
                       Where(r => r.Car == "Ferrari").OrderBy(r => r.racer.LastName).
                       Select(r => r.racer.LastName + " " + r.Car);
            //Write SelectMany() Extension Method here ...
            var CompoundLambda1 = Formula1.GetChampions().SelectMany(r => r.Cars, (r, c) => new { racer = r, car = c })
                .Where(r => r.car == "Farrari").OrderBy(r => r.racer.FirstName).Select(r => r.racer.FirstName + " " + r.car);
            Show(CompoundLambda1);
            var CompoundLambda2 = Formula1.GetChampions().Where(x => x.Cars.Contains("Ferrari")).OrderBy(x => x.LastName).SelectMany(x => x.FirstName + " " + x.LastName);
            #endregion

            #region Sorting
            var SortingLinq = (from racer in Formula1.GetChampions()
                               orderby racer.Country, racer.LastName, racer.FirstName
                               select racer).Take(10);
            //write sort query with extension methods here...
            var Sortinglambda = Formula1.GetChampions().OrderBy(r => r.Country).ThenBy(r => r.LastName).ThenBy(r => r.FirstName).Take(10);
            ShowAllRacers(Sortinglambda);
            #endregion

            #region Grouping
            //formula-1 champions should be gouped by country and the number of champions within a country should be listed.
            var GroupingLinq = from racer in Formula1.GetChampions()
                               group racer by racer.Country into g
                               orderby g.Count() descending, g.Key
                               where g.Count() >= 2
                               select new
                               {
                                   Country = g.Key,
                                   Count = g.Count(),
                               };
            //write extension method version here...
            var GroupingLambda = Formula1.GetChampions().Select(r => new { C = r.Country }).GroupBy(r => r.C).ToList()
                .Select(r => new { Country = r.Key, count = r.Count() }).OrderByDescending(r => r.count).Where(r => r.count >= 2).ToList();

            //ShowAllRacers(GroupingLambda);


            #endregion

            #region Grouping with Nested Objects
            //In previous example, the returned countries should contain not only the properties for the name of the country and the number of racers, 
            //but also a sequence of the names of the racers.

            //write linq query here...
            var NestedObjectsLinq = from racer in Formula1.GetChampions()
                                    group racer by racer.Country into g
                                    from g2 in
                                    (from racer in g group racer by racer.FirstName)
                                    orderby g.Count() descending, g.Key
                                    where g.Count() >= 2
                                    select new
                                    {
                                        Country = g.Key,
                                        Count = g.Count()
                                    };
            var NestedObjectsLambda = Formula1.GetChampions().Select(r => new { c = r.Country }).GroupBy(r => r.c).ToList()
                .Select(r => new { Country = r.Key, count = r.Count() }).OrderByDescending(r => r.count).Where(r => r.count >= 2).SelectMany(r => r.Country, (r, c) => new { country = r, count = c }).ToList();
            #endregion

            #region Join
            var racers = from r in Formula1.GetChampions()
                         from y in r.Years
                         where y > 2003
                         select new
                         {
                             Year = y,
                             Name = r.FirstName + " " + r.LastName
                         };

            var teams = from t in Formula1.GetContructorChampions()
                        from y in t.Years
                        where y > 2003
                        select new
                        {
                            Year = y,
                            Name = t.Name
                        };

            var racersAndTeams = from r in racers
                                 join t in teams on r.Year equals t.Year
                                 select new
                                 {
                                     Year = r.Year,
                                     Racer = r.Name,
                                     Team = t.Name
                                 };

            //write extension method verion here...
            var racersLambda = Formula1.GetChampions().SelectMany(r => r.Years, (r, y) => new { racer = r, year = y }).Where(r => r.year > 2003).Select(r => r.racer.FirstName + "" + r.racer.LastName).ToList();
            var teamsLambda = Formula1.GetContructorChampions().SelectMany(t => t.Years, (t, y) => new { team = t, year = y }).Where(r => r.year > 2003).Select(t => new { t.year, t.team.Name }).ToList();
            //var racersAndTeamsLambda = racersLambda.Join()

            foreach (var item in racersAndTeams)
            {
                Console.WriteLine("{0,-5} {1,-20} {2, -10}", item.Year, item.Racer, item.Team);
            }
            #endregion

            #region Set Operations
            Func<string, IEnumerable<Racer>> racersByCar = car => from r in Formula1.GetChampions()
                                                                  from c in r.Cars
                                                                  where c == car
                                                                  orderby r.LastName
                                                                  select r;


            #endregion

            #region Zip

            var racerNames = from r in Formula1.GetChampions()
                             where r.Country == "Italy"
                             orderby r.Wins descending
                             select new
                             {
                                 Name = r.FirstName + " " + r.LastName
                             };

            var racerNamesAndStarts = from r in Formula1.GetChampions()
                                      where r.Country == "Italy"
                                      orderby r.Wins descending
                                      select new
                                      {
                                          LastName = r.LastName,
                                          Starts = r.Starts
                                      };
            var zip = Formula1.GetChampions().Where(x => x.Country == "Italy").OrderBy(x => x.Wins).Select(x => new { x.Country, x.Wins });
            //Show(zip);
            #endregion
        }

        static void ShowAllRacers(IEnumerable<Racer> racerCollection)
        {
            foreach (var racer in racerCollection)
            {
                Console.WriteLine("{0:A}", racer);
            }
        }

        static void Show(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

