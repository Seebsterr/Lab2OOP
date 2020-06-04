using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ex2
{
    public class Graph
    {
        Dictionary<string,City> vertices = new Dictionary<string,City>(); 

        public void AddVertex(string name, City city) 
        {
            vertices[name] = city;
        }

        public List<City> ShortestPath(City city, City city2)
        {
            var previous = new Dictionary<City, City>();
            var distances = new Dictionary<City, int>();
            var nodes = new List<City>();

            List<City> path = null;

            foreach (City vertex in vertices.Values)
            {
                if (vertex.Name == city.Name)
                {
                    distances[vertex] = 0;
                }
                else
                {
                    distances[vertex] = int.MaxValue;
                }

                nodes.Add(vertex);
            }

            while (nodes.Any())
            {
                nodes.Sort((x, y) => distances[x] - distances[y]);

                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest == city2)
                {
                    path = new List<City>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }

                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in vertices.First(c => c.Value.Name == smallest.Name).Value.NeighboringCities)
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if (alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
            }

            return path;
        }
    }

}
