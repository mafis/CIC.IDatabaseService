using System;
using SQLite.Net.Async;

namespace CIC.IDatabase.SQLite
{
	public class SQLiteAsyncQuery<T> : IQueryAsync<T> where T : new()
	{
		AsyncTableQuery<T> asyncTableQuery;

		public SQLiteAsyncQuery (AsyncTableQuery<T> asyncTableQuery)
		{
			this.asyncTableQuery = asyncTableQuery;
		}

		#region IQueryAsync implementation
		public System.Threading.Tasks.Task<int> CountAsync (System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			return asyncTableQuery.CountAsync(cancellationToken);
		}
		public System.Threading.Tasks.Task<T> ElementAtAsync (int index, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			return asyncTableQuery.ElementAtAsync (index, cancellationToken);
		}
		public System.Threading.Tasks.Task<T> FirstAsync (System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			return asyncTableQuery.FirstAsync (cancellationToken);
		}
		public System.Threading.Tasks.Task<T> FirstOrDefaultAsync (System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			return asyncTableQuery.FirstOrDefaultAsync (cancellationToken);
		}
		public IQueryAsync<T> OrderBy<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.OrderBy<TValue> (orderExpr));
		}
		public IQueryAsync<T> OrderByDescending<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.OrderByDescending<TValue> (orderExpr));
		}
		public IQueryAsync<T> Skip (int n)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.Skip (n));
		}
		public IQueryAsync<T> Take (int n)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.Take (n));
		}
		public IQueryAsync<T> ThenBy<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.ThenBy<TValue> (orderExpr));
		}
		public IQueryAsync<T> ThenByDescending<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.ThenByDescending<TValue> (orderExpr));
		}
		public System.Threading.Tasks.Task<System.Collections.Generic.List<T>> ToListAsync (System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			return asyncTableQuery.ToListAsync (cancellationToken);
		}
		public IQueryAsync<T> Where (System.Linq.Expressions.Expression<Func<T, bool>> predExpr)
		{
			return new SQLiteAsyncQuery<T> (asyncTableQuery.Where(predExpr));

		}
		#endregion
	}
}

