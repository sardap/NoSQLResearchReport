using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DumpBasicGraphDatabase
{
    public class NodeHolder
    {
		private Dictionary<string, HashSet<Node>> _nodes = new Dictionary<string, HashSet<Node>>();

		public Node GetNodeForValue(string label, string value)
		{
			foreach(Node node in _nodes[label])
			{
				if(node.GetT == value)
				{
					return node;
				}
			}

			return null;
		}

		public void AddNode(Node toAdd)
		{
			if (!_nodes.ContainsKey(toAdd.GetLabel))
			{
				_nodes.Add(toAdd.GetLabel, new HashSet<Node>());
			}

			_nodes[toAdd.GetLabel].Add(toAdd);
		}
    }
}
