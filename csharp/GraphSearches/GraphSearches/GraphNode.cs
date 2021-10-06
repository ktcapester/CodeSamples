using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearches
{
    class GraphNode
    {
        public int Value;
        public List<GraphNode> ConnectedNodes;

        public GraphNode()
        {
            Value = 0;
            ConnectedNodes = new List<GraphNode>();
        }

        public GraphNode(int val)
        {
            Value = val;
            ConnectedNodes = new List<GraphNode>();
        }

        public GraphNode(int val, List<GraphNode> nodes)
        {
            Value = val;
            ConnectedNodes = nodes;
        }

        public override string ToString()
        {
            var outstring = $"Node {Value}:";
            foreach (var item in ConnectedNodes)
            {
                outstring += $" {item.Value}";
            }
            return outstring;
        }
    }
}
