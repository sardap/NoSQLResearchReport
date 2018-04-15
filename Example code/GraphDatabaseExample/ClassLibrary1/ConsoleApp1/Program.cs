using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DumpBasicGraphDatabase;

namespace ConsoleApp1
{
	class Program
	{
		private const string LABEL_NAME = "Name";
		private const string LABEL_GAME = "Game";
		private const string LABEL_COUNTRY = "Country";


		static void Main(string[] args)
		{
			NodeHolder nodes = new NodeHolder();

			nodes.AddNode(new Node(LABEL_NAME, "Paul"));
			nodes.AddNode(new Node(LABEL_NAME, "John"));
			nodes.AddNode(new Node(LABEL_GAME, "Dota 2"));
			nodes.AddNode(new Node(LABEL_GAME, "AOE II"));


		}
	}
}
