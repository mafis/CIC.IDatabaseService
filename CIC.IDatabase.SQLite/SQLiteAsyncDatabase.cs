using System;
using System.Threading;
using System.Threading.Tasks;
using SQLite.Net.Async;
using SQLiteNetExtensionsAsync.Extensions;

namespace CIC.IDatabase.SQLite
{
	public class SQLiteAsyncDatabase : IDatabaseAsync
	{
		SQLiteAsyncConnection sqliteAsyncConnection;

		public SQLiteAsyncDatabase (SQLiteAsyncConnection sqliteAsyncConnection)
		{
			this.sqliteAsyncConnection = sqliteAsyncConnection;
		}

		#region IDatabaseAsync implementation

		public void Dispose ()
		{
		}
		/*
		public Task<CreateTablesResult> CreateTableAsync<T> (CancellationToken cancellationToken = default(CancellationToken)) where T : new()
		{
			return sqliteAsyncConnection.CreateTableAsync<T> (cancellationToken);	
		}

		public Task<CreateTablesResult> CreateTablesAsync<T, T2, T3> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new() where T3 : new()
		{
			return sqliteAsyncConnection.CreateTablesAsync<T,T2,T3> (cancellationToken);
		}

		public Task<CreateTablesResult> CreateTablesAsync (params Type[] types)
		{
			return sqliteAsyncConnection.CreateTablesAsync(types);

		}

		public Task<CreateTablesResult> CreateTablesAsync<T, T2, T3, T4, T5> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new() where T3 : new() where T4 : new() where T5 : new()
		{
			return sqliteAsyncConnection.CreateTablesAsync<T,T2,T3,T4,T5> (cancellationToken);
		}

		public Task<CreateTablesResult> CreateTablesAsync<T, T2, T3, T4> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new() where T3 : new() where T4 : new()
		{
			return sqliteAsyncConnection.CreateTablesAsync<T,T2,T3,T4> (cancellationToken);
		}

		public Task<CreateTablesResult> CreateTablesAsync<T, T2> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new()
		{
			return sqliteAsyncConnection.CreateTablesAsync<T,T2> (cancellationToken);
		}

		public Task<CreateTablesResult> CreateTablesAsync (CancellationToken cancellationToken, params Type[] types)
		{
			return sqliteAsyncConnection.CreateTablesAsync (cancellationToken, types);
		}*/

		public Task<int> DeleteAllAsync<T> (CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.DeleteAllAsync<T> (cancellationToken);
		}

		public Task<int> DeleteAsync (object item, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.DeleteAsync (item,cancellationToken);
		}

		public Task<int> DeleteAsync<T> (object pk, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.DeleteAsync<T> (pk, cancellationToken);
		}

		public Task<int> DropTableAsync<T> (CancellationToken cancellationToken = default(CancellationToken)) where T : new()
		{
			return sqliteAsyncConnection.DropTableAsync<T> (cancellationToken);
		}

		public Task<int> ExecuteAsync (CancellationToken cancellationToken, string query, params object[] args)
		{
			return sqliteAsyncConnection.ExecuteAsync (cancellationToken, query,args);
		}

		public Task<int> ExecuteAsync (string query, params object[] args)
		{
			return sqliteAsyncConnection.ExecuteAsync(query,args);
		}

		public Task<T> ExecuteScalarAsync<T> (string sql, params object[] args)
		{
			return sqliteAsyncConnection.ExecuteScalarAsync<T> (sql,args);
		}

		public Task<T> ExecuteScalarAsync<T> (CancellationToken cancellationToken, string sql, params object[] args)
		{
			return sqliteAsyncConnection.ExecuteScalarAsync<T> (cancellationToken,sql,args);
		}

		public Task<T> FindAsync<T> (object pk, CancellationToken cancellationToken = default(CancellationToken)) where T : new()
		{
			return sqliteAsyncConnection.FindAsync<T> (pk, cancellationToken);
		}

		public Task<T> FindAsync<T> (System.Linq.Expressions.Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken)) where T : new()
		{
			return sqliteAsyncConnection.FindAsync<T> (predicate, cancellationToken);
		}

		public Task<T> GetAsync<T> (object pk, CancellationToken cancellationToken = default(CancellationToken)) where T : new()
		{
			return sqliteAsyncConnection.GetAsync<T> (pk, cancellationToken);
		}

		public Task<T> GetAsync<T> (System.Linq.Expressions.Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken)) where T : new()
		{
			return sqliteAsyncConnection.GetAsync<T> (predicate, cancellationToken);
		}

		public Task<int> InsertAllAsync (System.Collections.IEnumerable items, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.InsertAllAsync (items, cancellationToken);
		}

		public Task<int> InsertAsync (object item, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.InsertAsync (item, cancellationToken);
		}

		public Task<int> InsertOrReplaceAllAsync (System.Collections.IEnumerable items, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.InsertOrReplaceAllAsync (items, cancellationToken);
		}

		public Task<int> InsertOrReplaceAsync (object item, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.InsertOrReplaceAsync (item, cancellationToken);
		}

		public Task<System.Collections.Generic.List<T>> QueryAsync<T> (string sql, params object[] args) where T : new()
		{
			return sqliteAsyncConnection.QueryAsync<T> (sql, args);
		}

		public Task<System.Collections.Generic.List<T>> QueryAsync<T> (CancellationToken cancellationToken, string sql, params object[] args) where T : new()
		{
			return sqliteAsyncConnection.QueryAsync<T> (cancellationToken, sql,args);
		}

		public Task RunInTransactionAsync (Action<IDatabase> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw new NotImplementedException ();
			//return sqliteAsyncConnection.RunInTransactionAsync (action,cancellationToken);
		}

		public IQueryAsync<T> Table<T> () where T : new()
		{
			return new SQLiteAsyncQuery<T>(sqliteAsyncConnection.Table<T>());
		}

		public Task<int> UpdateAllAsync (System.Collections.IEnumerable items, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.UpdateAllAsync (items, cancellationToken);
		}

		public Task<int> UpdateAsync (object item, CancellationToken cancellationToken = default(CancellationToken))
		{
			return sqliteAsyncConnection.UpdateAsync (item, cancellationToken);
		}

		public Task<T> FindWithChildrenAsync<T> (object pk, bool recursive = false) where T : new()
		{
			return sqliteAsyncConnection.FindWithChildrenAsync<T> (pk, recursive);
		}

		public Task<System.Collections.Generic.List<T>> GetAllWithChildrenAsync<T> (System.Linq.Expressions.Expression<Func<T, bool>> filter = null, bool recursive = false) where T : new()
		{
			return sqliteAsyncConnection.GetAllWithChildrenAsync<T> (filter, recursive);
		}

		public Task GetChildAsync<T> (T element, string relationshipProperty, bool recursive = false)
		{
			return sqliteAsyncConnection.GetChildAsync<T> (element,relationshipProperty,recursive);
		}

		public Task GetChildAsync<T> (T element, System.Linq.Expressions.Expression<Func<T, object>> propertyExpression, bool recursive = false)
		{
			return sqliteAsyncConnection.GetChildAsync<T> (element,propertyExpression,recursive);
		}

		public Task GetChildAsync<T> (T element, System.Reflection.PropertyInfo relationshipProperty, bool recursive = false)
		{
			return sqliteAsyncConnection.GetChildAsync<T> (element,relationshipProperty,recursive);
		}

		public Task GetChildrenAsync<T> (T element, bool recursive = false)
		{
			return sqliteAsyncConnection.GetChildrenAsync<T> (element,recursive);
		}

		public Task<T> GetWithChildrenAsync<T> (object pk, bool recursive = false) where T : new()
		{
			return sqliteAsyncConnection.GetWithChildrenAsync<T> (pk, recursive);
		}

		public Task DeleteAllAsync (System.Collections.IEnumerable objects, bool recursive = false)
		{
			return sqliteAsyncConnection.DeleteAllAsync (objects, recursive);
		}

		public Task DeleteAllIdsAsync<T> (System.Collections.Generic.IEnumerable<object> primaryKeyValues)
		{
			return sqliteAsyncConnection.DeleteAllIdsAsync<T> (primaryKeyValues);
		}

		public Task DeleteAsync (object element, bool recursive)
		{
			return sqliteAsyncConnection.DeleteAsync (element, recursive);
		}

		public Task InsertAllWithChildrenAsync (System.Collections.IEnumerable elements, bool recursive = false)
		{
			return sqliteAsyncConnection.InsertAllWithChildrenAsync (elements ,recursive);
		}

		public Task InsertOrReplaceAllWithChildrenAsync (System.Collections.IEnumerable elements, bool recursive = false)
		{
			return sqliteAsyncConnection.InsertOrReplaceAllWithChildrenAsync(elements, recursive);
		}

		public Task InsertOrReplaceWithChildrenAsync (object element, bool recursive = false)
		{
			return sqliteAsyncConnection.InsertOrReplaceWithChildrenAsync(element, recursive);
		}

		public Task InsertWithChildrenAsync (object element, bool recursive = false)
		{
			return sqliteAsyncConnection.InsertWithChildrenAsync(element, recursive);
		}

		public Task UpdateWithChildrenAsync (object element)
		{
			return sqliteAsyncConnection.UpdateWithChildrenAsync (element);
		}

		#endregion
	}
}

