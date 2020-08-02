using System;
using System.Collections.Generic;

namespace linq_Lambds
{
    [Serializable]
    public class Racer : IComparable<Racer>, IFormattable
    {
        public Racer(string firstName = null, string lastName = null, string country = null,
            int starts = 0, int wins = 0, IEnumerable<int> years = null, IEnumerable<string> cars = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Starts = starts;
            this.Wins = wins;

            var yearList = new List<int>();
            foreach (var year in years)
            {
                yearList.Add(year);
            }
            this.Years = yearList.ToArray();

            var carList = new List<string>();
            foreach (var car in cars)
            {
                carList.Add(car);
            }
            this.Cars = carList.ToArray();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Wins { get; set; }
        public string Country { get; set; }
        public int Starts { get; set; }
        public string[] Cars { get; private set; }
        public int[] Years { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public int CompareTo(Racer other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            return this.LastName.CompareTo(other.LastName);
        }

        public string ToString(string format)
        {
            return ToString(format, null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case null:
                case "N": return ToString();
                case "F": return FirstName;
                case "L": return LastName;
                case "C": return Country;
                case "S": return Starts.ToString();
                case "W": return Wins.ToString();
                case "A": return string.Format("{0} {1}, {2}; starts: {3}, wins: {4}", FirstName, LastName, Country, Starts, Wins);
                default:
                    throw new FormatException(string.Format("Format {0} not supported.", format));
            }
        }
    }
}
