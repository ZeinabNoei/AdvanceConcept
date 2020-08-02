﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public enum PersonCompareType
    {
        FirstName,
        LastName
    }
    public class PersonComparer : IComparer<Person>
    {
        private PersonCompareType compareType;
        public PersonComparer(PersonCompareType compareType)
        {
            this.compareType = compareType;
        }

        #region IComparer<Person> Members 
        public int Compare(Person x, Person y)
        {
            if (x == null) throw new ArgumentNullException("x");
            if (y == null) throw new ArgumentNullException("y");
            switch (compareType)
            {
                case PersonCompareType.FirstName:
                    return x.FirstName.CompareTo(y.FirstName);
                case PersonCompareType.LastName:
                    return x.LastName.CompareTo(y.LastName);
                default:
                    throw new ArgumentException("unexpected compare type");
            }
        }
        #endregion
        static void SortUsingPersonComparer(Person[] persons)
        {
            Array.Sort(persons, new PersonComparer(PersonCompareType.FirstName));
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }
    }
}
