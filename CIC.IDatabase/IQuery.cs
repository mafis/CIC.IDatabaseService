using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CIC.IDatabase
{
	public interface IQuery<T> : IEnumerable<T>
	{
		
		IQuery<U> Clone<U> ();

		int Count (Expression<Func<T, bool>> predExpr);

		int Count ();

		IQuery<T> Deferred ();

		T ElementAt (int index);

		T First ();

		T FirstOrDefault ();

		IQuery<TResult> Join<TInner, TKey, TResult> (IEnumerable<TInner> inner, Expression<Func<T, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<T, TInner, TResult>> resultSelector);

		IQuery<T> OrderBy<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQuery<T> OrderByDescending<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQuery<TResult> Select<TResult> (Expression<Func<T, TResult>> selector);

		IQuery<T> Skip (int n);

		IQuery<T> Take (int n);

		IQuery<T> ThenBy<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQuery<T> ThenByDescending<TValue> (Expression<Func<T, TValue>> orderExpr);

		IQuery<T> Where (Expression<Func<T, bool>> predExpr);
	}
}

