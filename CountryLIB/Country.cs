using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CountryLIB
{
    public class Country
    {
        public string Name { get; }
        public string CapitalName { get; }
        public int NumberOfInhabitants { get; }
        public int CountryArea { get; }
        public List<string> RegionOfTheWorld { get; }

        public Country()
        {
            Name = "";
            CapitalName = "";
            NumberOfInhabitants = 11;
            CountryArea = 100;
            RegionOfTheWorld = new List<string>();
        }

        public Country(string Name, string CapitalName, int NumberOfInhabitants, int CountryArea,
            List<string> RegionOfTheWorld)
        {
            this.Name = Name;
            this.CapitalName = CapitalName;
            this.NumberOfInhabitants = NumberOfInhabitants;
            this.CountryArea = CountryArea;
            this.RegionOfTheWorld = RegionOfTheWorld;
        }
    }
}