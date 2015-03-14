using System;

namespace CIC.IDatabase
{
	public enum CreateFlags
	{
		None = 0,
		ImplicitPK = 1,
		ImplicitIndex = 2,
		AllImplicit = 3,
		AutoIncPK = 4
	}
}

