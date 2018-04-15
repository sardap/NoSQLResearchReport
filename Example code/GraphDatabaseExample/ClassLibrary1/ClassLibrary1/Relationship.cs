using System;
using System.Collections.Generic;
using System.Text;

namespace DumpBasicGraphDatabase
{
    public class Relationship
    {
		private Node _first;
		private Node _secound;
		private string _nature;

		public Relationship(Node first, Node secound, string nature)
		{
			_first = first;
			_secound = secound;
			_nature = nature;
		}

		public Node First
		{
			get
			{
				return _first;
			}
		}

		public Node Secound
		{
			get
			{
				return _secound;
			}
		}

		public string Nature
		{
			get
			{
				return _nature;
			}
		}

	}
}
