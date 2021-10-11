using System;
using System.Collections.Generic;
using System.Linq;
using CountryLIB;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> listCountry = new List<Country>
            {
                new Country("Америка", "Вашингтон", 329, 9834000, new List<string> { "North", "South" }),
                new Country("Россия", "Москва", 144, 17130000, new List<string> { "Europe", "Asia" }),
                new Country("Великобритания", "Лондон", 67, 242495, new List<string> { "Europe" })
            };
            GetInfoCountry(new Country("!!!!!!!!", "!!!!!!!", 0, 0, new List<string> { "??????", "??????" }));
            GetInfoCountries(listCountry);
            GetCountriesName(listCountry);
            GetCountriesCapitalName(listCountry);
            GetCountriesRegionEU(listCountry);
            GetCountryAreaLargerNumber(listCountry, 10000000);
        }

        public static void GetCountryAreaLargerNumber(List<Country> listCountry, int area)
        {
            var request = from listCo in listCountry
                where listCo.CountryArea > area
                select listCo.CountryArea;
            PrintLinqRequest(request);
        }

        public static void PrintLinqRequest(IEnumerable<string> linqRequest)
        {
            foreach (var linq in linqRequest)
            {
                Console.WriteLine(linq);
            }
        }

        public static void PrintLinqRequest(IEnumerable<int> linqRequest)
        {
            foreach (var linq in linqRequest)
            {
                Console.WriteLine(linq);
            }
        }


        public static void GetCountriesRegionEU(List<Country> listCountry)
        {
            var countryRegion =
                from listCo in listCountry
                from country in listCo.RegionOfTheWorld
                where country.ToUpper().Contains("EU")
                select listCo.Name;
            PrintLinqRequest(countryRegion);
        }

        public static void GetCountriesName(List<Country> listCountry)
        {
            var countryName =
                from listCo in listCountry
                select listCo.Name;
            PrintLinqRequest(countryName);
        }

        public static void GetCountriesCapitalName(List<Country> listCountry)
        {
            var countryCapitalName =
                from listCo in listCountry
                select listCo.CapitalName;
            PrintLinqRequest(countryCapitalName);
        }


        public static void PrintCountry(Country co)
        {
            Console.Write(co.Name + " столица ");
            Console.WriteLine(co.CapitalName);
            Console.WriteLine("Площадь " + co.CountryArea + " км");
            Console.WriteLine(co.NumberOfInhabitants + " млн человек");

            foreach (var region in co.RegionOfTheWorld)
            {
                Console.Write(region + ";");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void GetInfoCountries(List<Country> listCountry)
        {
            var selectCountry =
                from co in listCountry
                select co;
            foreach (var select in selectCountry)
            {
                PrintCountry(select);
            }
        }

        public static void GetInfoCountry(Country country)
        {
            PrintCountry(country);
        }
    }
}