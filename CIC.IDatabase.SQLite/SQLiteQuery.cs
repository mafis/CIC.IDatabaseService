using System;
using SQLite.Net;
using System.Collections.Generic;
using CIC.IDatabase;

namespace CIC.IDatabase.SQLite
{
	public class SQLiteQuery<T> : IQuery<T>
	{
		TableQuery<T> tableQuery;

		public SQLiteQuery (TableQuery<T> tableQuery)
		{
			this.tableQuery = tableQuery;
			
		}


		#region IQuery implementation
		public IQuery<U> Clone<U> ()
		{
			return new SQLiteQuery<U>(tableQuery.Clone<U> ());
		}

		public int Count (System.Linq.Expressions.Expression<Func<T, bool>> predExpr)
		{
			return tableQuery.Count (predExpr);
		}

		public int Count ()
		{
			return tableQuery.Count ();
		}

		public IQuery<T> Deferred ()
		{
			return new SQLiteQuery<T>(tableQuery.Deferred ());
		}

		public T ElementAt (int index)
		{
			return tableQuery.ElementAt(index);
		}
		public T First ()
		{
			return tableQuery.First ();
		}
		public T FirstOrDefault ()
		{
			return tableQuery.FirstOrDefault ();
		}
		public IQuery<TResult> Join<TInner, TKey, TResult> (IEnumerable<TInner> inner, System.Linq.Expressions.Expression<Func<T, TKey>> outerKeySelector, System.Linq.Expressions.Expression<Func<TInner, TKey>> innerKeySelector, System.Linq.Expressions.Expression<Func<T, TInner, TResult>> resultSelector)
		{
			return new SQLiteQuery<TResult>(tableQuery.Join<TInner,TKey,TResult> (inner as TableQuery<TInner>, outerKeySelector, innerKeySelector, resultSelector));
		}
		public IQuery<T> OrderBy<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteQuery<T>(tableQuery.OrderBy<TValue>(orderExpr));
		}

		public IQuery<T> OrderByDescending<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteQuery<T>(tableQuery.OrderBy<TValue>(orderExpr));
		}
		public IQuery<TResult> Select<TResult> (System.Linq.Expressions.Expression<Func<T, TResult>> selector)
		{
			return new SQLiteQuery<TResult>(tableQuery.Select<TResult>(selector));
		}
		public IQuery<T> Skip (int n)
		{
			return new SQLiteQuery<T>(tableQuery.Skip(n));
		}
		public IQuery<T> Take (int n)
		{
			return new SQLiteQuery<T>(tableQuery.Take(n));
		}
		public IQuery<T> ThenBy<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteQuery<T>(tableQuery.ThenBy<TValue>(orderExpr));
		}
		public IQuery<T> ThenByDescending<TValue> (System.Linq.Expressions.Expression<Func<T, TValue>> orderExpr)
		{
			return new SQLiteQuery<T>(tableQuery.ThenByDescending<TValue>(orderExpr));
		}
		public IQuery<T> Where (System.Linq.Expressions.Expression<Func<T, bool>> predExpr)
		{
			return new SQLiteQuery<T>(tableQuery.Where(predExpr));
		}
		#endregion
		#region IEnumerable implementation
		public System.Collections.Generic.IEnumerator<T> GetEnumerator ()
		{
			return tableQuery.GetEnumerator ();
		}
		#endregion
		#region IEnumerable implementation
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return tableQuery.GetEnumerator ();
		}
		#endregion
	}
}

