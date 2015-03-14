using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIC.IDatabase
{
	public class CreateTablesResult
	{
		public Dictionary<Type, int> Results {
			get;
			private set;
		}

		public CreateTablesResult ()
		{
		}
	}
}

