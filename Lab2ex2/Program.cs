using Lab2ex2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<City> cities = GetCities();
            Graph g = new Graph();

            cities.ForEach(c => g.AddVertex(c.Name, c));

            g.ShortestPath(cities.First(), cities.Last()).ForEach(x => Console.WriteLine(x.Name));

            Console.ReadKey();
        }

        private static List<City> GetCities()
        {
            var cities = new List<City>();
            var a = new City { Name = "A", Number = 1 };
            cities.Add(a);
            var b = new City { Name = "B", Number = 2 };
            cities.Add(b);
            var c = new City { Name = "C", Number = 3 };
            cities.Add(c);
            var d = new City { Name = "D", Number = 4 };
            cities.Add(d);
            var e = new City { Name = "E", Number = 5 };
            cities.Add(e);
            var f = new City { Name = "F", Number = 6 };
            cities.Add(f);
            var g = new City { Name = "G", Number = 7 };
            cities.Add(g);
            var h = new City { Name = "H", Number = 8 };
            cities.Add(h);

            a.NeighboringCities = new Dictionary<City, int>
            {
                {b, 7},
                {c, 8},
            };

            b.NeighboringCities = new Dictionary<City, int>
            {
                {a, 7},
                {f, 2},
            };

            c.NeighboringCities = new Dictionary<City, int>
            {
                {a, 8},
                {f, 6},
                {g, 4},
            };

            d.NeighboringCities = new Dictionary<City, int>
            {
                {f, 8},
            };

            e.NeighboringCities = new Dictionary<City, int>
            {
                {h, 1},
            };

            f.NeighboringCities = new Dictionary<City, int>
            {
                {b, 2},
                {c, 6},
                {d, 8},
                {g, 9},
                {h, 3}
            };

            g.NeighboringCities = new Dictionary<City, int>
            {
                {c, 4},
                {f, 9}
            };

            h.NeighboringCities = new Dictionary<City, int>
            {
                {e, 1},
                {f, 3}
            };


            return cities;
        }
    }
}