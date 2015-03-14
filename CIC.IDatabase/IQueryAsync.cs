using System;
using System.Threading.Tasks;
using System.Threading;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace CIC.IDatabase
{
	public interface IQueryAsync<T>
	{
		Task<int> CountAsync (CancellationToken cancellationToken = default(CancellationToken));

		Task<T> ElementAtAsync (int index, CancellationToken cancellationToken = default(CancellationToken));

		Task<T> FirstAsync (CancellationToken cancellationToken = default(CancellationToken));

		Task<T> FirstOrDefaultAsync (CancellationToken cancellationToken = default(CancellationToken));

		IQueryAsync<T> OrderBy<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQueryAsync<T> OrderByDescending<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQueryAsync<T> Skip (int n);

		IQueryAsync<T> Take (int n);

		IQueryAsync<T> ThenBy<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQueryAsync<T> ThenByDescending<TValue> (Expression<Func<T, TValue>> orderExpr);

		Task<List<T>> ToListAsync (CancellationToken cancellationToken = default(CancellationToken));

		IQueryAsync<T> Where (Expression<Func<T, bool>> predExpr);
	}
}

