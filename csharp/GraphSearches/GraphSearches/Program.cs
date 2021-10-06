using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearches
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            var biglist = CreateGraph(3);
            var medlist = CreateGraph(2);
            var smalllist = CreateGraph(1);

            Console.WriteLine("BIG:");
            PrintGraph(biglist);

            Console.WriteLine("MED:");
            PrintGraph(medlist);

            Console.WriteLine("SMALL:");
            PrintGraph(smalllist);


        }

        static void PrintGraph(List<GraphNode> nodes)
        {
            foreach (var item in nodes)
            {
                Console.WriteLine(item);
            }
        }

        static List<GraphNode> CreateGraph(int option)
        {
            var rng = new Random();
            int size;
            switch (option)
            {
                case 1:     // small list
                    size = rng.Next(2, 5);
                    break;
                case 2:     // medium list
                    size = rng.Next(6, 12);
                    break;
                case 3:     // big list
                    size = rng.Next(16, 24);
                    break;
                default:    // return nothing
                    return new List<GraphNode>();
            }
            List<GraphNode> nodes = new();
            for (int i = 0; i < size; i++)
            {
                nodes.Add(new(i));
            }

            for (int i = 0; i < size; i++)
            {
                var numConns = rng.Next(2, 5);
                for (int j = 0; j < numConns; j++)
                {
                    var next = rng.Next(size);
                    while (next == i)
                    {
                        next = rng.Next(size);
                    }
                    nodes[i].ConnectedNodes.Add(nodes[next]);
                }
            }
            return nodes;
        }
    }
}
