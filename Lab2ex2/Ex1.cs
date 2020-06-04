using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ex2
{
    class Ex1
    {
        public static void Example1()
        {
            List<string> strings = new List<string> { "This", " class", " is", " awesome" };
            Console.WriteLine(ConcatenateCollection(strings));

            char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine(ConcatenateCollection(characters));

            int[] integers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(ConcatenateCollection(integers));
        }

        static string ConcatenateCollection<T>(IEnumerable<T> list)
        {
            return string.Join(string.Empty, list);
        }
    }
}
