using System;
using System.Collections.Generic;
using System.Text;

namespace DumpBasicGraphDatabase
{
    public class Node
    {
		private string _label;
		private string _value;

		public Node(string label, string value)
		{
			_label = label;
			_value = value;
		}

		public string GetLabel
		{
			get
			{
				return _label;
			}
		}

		public string GetT
		{
			get
			{
				return _value;
			}
		}
    }
}
