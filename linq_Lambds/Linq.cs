using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_Lambds
{
    public class Linq
    {
        //static void Main(string[] args)
        //{
        //    var lis = Formula1.GetChampions();

        //    LinqQuery();
        //    Console.ReadLine();
        //}

        static void LinqQuery()
        {
            #region Intro

            //var query = from racer in Formula1.GetChampions()
            //            where racer.Country == "Brazil"
            //            orderby racer.Wins descending
            //           select racer;
            //var query = Formula1.GetChampions().Where(delegate (Racer r) { return r.Country == "Brazil"; }).OrderByDescending(r => r.Wins).Select(r => r);

            //var query = Formula1.GetChampions().Where(x => x.Country == "Brazil").OrderByDescending(x => x.Wins);
            //ShowAllRacers(query);

            #endregion

            #region Filtering
            //var query = from r in Formula1.GetChampions()
            //            where r.Wins > 15 &&
            //                (r.Country == "Brazil" || r.Country == "Austria")
            //            select r;

            //var filtering = Formula1.GetChampions().Where(r => 2+1>3 ).Where(x => x.Wins >= 15);

            //// Write query using extension methods
            //List<Racer> ChampionList = new Formula1.GetChampions();

            //ShowAllRacers(filtering);

            #endregion

            #region Filtering with Index

            //write a query with where() overload here...

            //var query2 = Formula1.GetChampions().Where((r, i) => r.FirstName.StartsWith("A") && i % 2 == 0).ToList();

            // int index = 2;
            //var filteringIndex = Formula1.filteringIndex(Formula1.GetChampions(), index);
            //ShowAllRacers(query2);

            #endregion

            #region Compound from

            // Filter all racers who were champions with ferrari

            //var query = from racer in Formula1.GetChampions()
            //            from car in racer.Cars
            //            where car == "Ferrari"
            //            orderby racer.LastName
            //            select racer.FirstName + " " + racer.LastName;
            //Show(query);

            //var query = Formula1.GetChampions().
            //   SelectMany(r =>
            //       r.Cars,
            //           (r, c) => new { racer = r, Car = c }).
            //           Where(r => r.Car == "Ferrari").OrderBy(r => r.racer.LastName).
            //           Select(r => r.racer.LastName + " " + r.racer.FirstName + " " + r.Car);

            //Write SelectMany() Extension Method here ...

            //var query3 = Formula1.GetChampions().SelectMany(r => r.Cars,
            // (r, c) => new { racer = r, car = c }).ToList();

            //var query4 = Formula1.GetChampions().SelectMany(r => r.Years,
            //    (r, y) => new { racer = r, Counrty = r.Country, year = y }).Where(r => r.year > 1940);

            //var query4 = Formula1.GetChampions().SelectMany(r => r.Cars,
            //    (r, c) => new { racer = r, car = c }).Where(r => (r.racer.Country == "Italy" || r.racer.Country == "UK") && r.car == "Ferrari").ToList();
            //Console.ReadKey();
            //var query3 = Formula1.GetChampions().SelectMany(r => r.Cars,
            //    (r, c) => new { racer = r, car = c }).Where(r => r.car == "Farrari").OrderBy(r => r.racer.FirstName ).Select(r => r.racer.FirstName + " " + r.car );

            //var list = Formula1.GetChampions().SelectMany(r => r.Years, (r, c) => new { racer = r, year = c }).Where(r => r.year > 1970).ToList();

            //var list1 = Formula1.GetChampions().SelectMany(r => r.FirstName ).ToList();
            //Show(query3);

            //var query4 = Formula1.GetChampions().Where(x => x.Cars.Contains("Ferrari")).OrderBy(x => x.LastName).SelectMany(x => x.FirstName + " " + x.LastName);
            //Show (query4);

            //Console.ReadKey();
            #endregion

            #region Sorting

            //var query = (from racer in Formula1.GetChampions()
            //             orderby racer.Country, racer.LastName, racer.FirstName
            //             select racer).Take(10);

            //var query7 = Formula1.GetChampions().OrderBy(r => r.Country).ThenBy(r => r.LastName).ThenBy(r => r.FirstName).Take(10);

            //write sort query with extension methods here...

            //  ShowAllRacers(query7);

            #endregion

            #region Grouping

            //formula-1 champions should be gouped by country and the number of champions within a country should be listed.

            //var countries = from racer in Formula1.GetChampions()
            //                group racer by racer.Country into g
            //                orderby g.Count() descending, g.Key
            //                where g.Count() >= 2
            //                select new
            //                {
            //                    Country = g.Key,
            //                    Count = g.Count(),
            //                };

            //var Grouping = Formula1.GetChampions()
            //    .Select(r => new { _country = r.Country }).GroupBy(r => r._country).ToList()
            //    .Select(r => new { key = r.Key, count = r.Count() }).OrderByDescending(r => r.count).Where(r => r.count >= 2).ToList();

            //  var query5 = Formula1.GetChampions().SelectMany(r => r.Cars, (r, c) => new

            //  {
            //      racer = r,
            //      car = c
            //  }
            //).SelectMany(r => r.racer.Years, (r, y) => new
            //{
            //    racer = r.racer,

            //}
            //  )
            //  GroupBy(r => r.car).Select(r => new
            //  {
            //      car = r.Key,
            //      count = r.Count()
            //  }
            //  ).OrderByDescending(r => r.count).ToList();


            //var grouping = Formula1.GetChampions().Select(r => new
            //{
            //    //name = r.FirstName,
            //    //family = r.LastName,
            //    //country = r.Country,
            //    //starts = r.Starts,
            //    //wins = r.Wins,
            //    //years = r.Years,
            //    cars = r.Cars
            //}
            //).GroupBy(r => r.cars).ToList().Select(r => new
            //{
            //    cars = r.Key,
            //    count = r.Count()
            //}
            //).ToList();


            //write extension method version here...
            //Console.ReadKey();
            #endregion

            #region Grouping with Nested Objects

            //In previous example, the returned countries should contain not only 
            //the properties for the name of the country and the number of racers, 
            //but also a sequence of the names of the racers.

            //write linq query here...
            //var Groupings = Formula1.GetChampions()
            //    .Select(r => new { _country = r.Country }).GroupBy(r => r._country).ToList()
            //    .Select(r => new { key = r.Key, count = r.Count() }).OrderByDescending(r => r.count).Where(r => r.count >= 2).ToList();


            //var Grouping = Formula1.GetChampions().GroupBy(r => r.Country)
            //    .OrderByDescending(g => g.Count()).ThenBy(g => g.Key)
            //    .Where(r => r.Count() >= 2)
            //    .Select(r => new { country = r.Key, count = r.Count(), racer = string.Join(",", r.ToList())}).ToList ();




            //Console.ReadKey();
            #endregion

            #region Join
            //var racers = from r in Formula1.GetChampions()
            //             from y in r.Years
            //             where y > 2003
            //             select new
            //             {
            //                 Year = y,
            //                 Name = r.FirstName + " " + r.LastName
            //             };

            var racersLambda = Formula1.GetChampions().SelectMany(r => r.Years, (r, y) => new { racer = r, year = y }).Where(r => r.year > 2003).Select(r => new { name = r.racer.FirstName + "" + r.racer.LastName, year = r.year });
            //var teams = from t in Formula1.GetContructorChampions()
            //            from y in t.Years
            //            where y > 2003
            //            select new
            //            {
            //                Year = y,
            //                Name = t.Name
            //            };
            var teamss = Formula1.GetContructorChampions().SelectMany(t => t.Years, (t, y) => new { team = t, year = y })
                .Where(t => t.year > 2003).Select(t => new { Name = t.team.Name, Year = t.year });

            //var racersAndTeams = from r in racers
            //                     join t in teams on r.Year equals t.Year
            //                     select new
            //                     {
            //                         Year = r.Year,
            //                         Racer = r.Name,
            //                         Team = t.Name
            //                     };

            ////write extension method verion here...
            var join = racersLambda.Join(teamss, r => r.year, t => t.Year, (r, t) => new { racer = r.name, team = t.Name, year = t.Year }).ToList();
            //foreach (var item in racersAndTeams)
            //{
            //    Console.WriteLine("{0,-5} {1,-20} {2, -10}", item.Year, item.Racer, item.Team);
            //}
            Console.ReadKey();
            #endregion

            #region Set Operations

            Func<string, IEnumerable<Racer>> racersByCar = car => from r in Formula1.GetChampions()
                                                                  from c in r.Cars
                                                                  where c == car
                                                                  orderby r.LastName
                                                                  select r;


            #endregion

            #region Zip

            //var racerNames = from r in Formula1.GetChampions()
            //                 where r.Country == "Italy"
            //                 orderby r.Wins descending
            //                 select new
            //                 {
            //                     Name = r.FirstName + " " + r.LastName
            //                 };

            //var racerNamesAndStarts = from r in Formula1.GetChampions()
            //                          where r.Country == "Italy"
            //                          orderby r.Wins descending
            //                          select new
            //                          {
            //                              LastName = r.LastName,
            //                              Starts = r.Starts
            //                          };
            var zip = Formula1.GetChampions().Where(x => x.Country == "Italy").OrderBy(x => x.Wins).Select(x => new { x.Country, x.Wins });
            //Show (zip );
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
