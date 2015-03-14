using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Reflection;

namespace CIC.IDatabase
{
	public interface IDatabaseAsync
	{
		/*Task<CreateTablesResult> CreateTableAsync<T> (CancellationToken cancellationToken = default(CancellationToken)) where T : new();

		Task<CreateTablesResult> CreateTablesAsync<T, T2, T3> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new() where T3 : new();

		Task<CreateTablesResult> CreateTablesAsync (params Type[] types);

		Task<CreateTablesResult> CreateTablesAsync<T, T2, T3, T4, T5> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new() where T3 : new() where T4 : new() where T5 : new();

		Task<CreateTablesResult> CreateTablesAsync<T, T2, T3, T4> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new() where T3 : new() where T4 : new();

		Task<CreateTablesResult> CreateTablesAsync<T, T2> (CancellationToken cancellationToken = default(CancellationToken)) where T : new() where T2 : new();

		Task<CreateTablesResult> CreateTablesAsync (CancellationToken cancellationToken, params Type[] types);*/

		Task<int> DeleteAllAsync<T> (CancellationToken cancellationToken = default(CancellationToken));

		Task<int> DeleteAsync (object item, CancellationToken cancellationToken = default(CancellationToken));

		Task<int> DeleteAsync<T> (object pk, CancellationToken cancellationToken = default(CancellationToken));

		Task<int> DropTableAsync<T> (CancellationToken cancellationToken = default(CancellationToken)) where T : new();

		Task<int> ExecuteAsync (CancellationToken cancellationToken, string query, params object[] args);

		Task<int> ExecuteAsync (string query, params object[] args);

		Task<T> ExecuteScalarAsync<T> (string sql, params object[] args);

		Task<T> ExecuteScalarAsync<T> (CancellationToken cancellationToken, string sql, params object[] args);

		Task<T> FindAsync<T> (object pk, CancellationToken cancellationToken = default(CancellationToken)) where T : new();

		Task<T> FindAsync<T> (Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken)) where T : new();

		Task<T> GetAsync<T> (object pk, CancellationToken cancellationToken = default(CancellationToken)) where T : new();

		Task<T> GetAsync<T> (Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken)) where T : new();

		Task<int> InsertAllAsync (IEnumerable items, CancellationToken cancellationToken = default(CancellationToken));

		Task<int> InsertAsync (object item, CancellationToken cancellationToken = default(CancellationToken));

		Task<int> InsertOrReplaceAllAsync (IEnumerable items, CancellationToken cancellationToken = default(CancellationToken));

		Task<int> InsertOrReplaceAsync (object item, CancellationToken cancellationToken = default(CancellationToken));

		Task<List<T>> QueryAsync<T> (string sql, params object[] args) where T : new();

		Task<List<T>> QueryAsync<T> (CancellationToken cancellationToken, string sql, params object[] args) where T : new();

		Task RunInTransactionAsync (Action<IDatabase> action, CancellationToken cancellationToken = default(CancellationToken));

		IQueryAsync<T> Table<T> () where T : new();

		Task<int> UpdateAllAsync (IEnumerable items, CancellationToken cancellationToken = default(CancellationToken));

		Task<int> UpdateAsync (object item, CancellationToken cancellationToken = default(CancellationToken));

		Task<T> FindWithChildrenAsync<T> (object pk, bool recursive = false) where T : new();

		Task<List<T>> GetAllWithChildrenAsync<T> (Expression<Func<T, bool>> filter = null, bool recursive = false) where T : new();

		Task GetChildAsync<T> (T element, string relationshipProperty, bool recursive = false);

		Task GetChildAsync<T> (T element, Expression<Func<T, object>> propertyExpression, bool recursive = false);

		Task GetChildAsync<T> (T element, PropertyInfo relationshipProperty, bool recursive = false);

		Task GetChildrenAsync<T> (T element, bool recursive = false);

		Task<T> GetWithChildrenAsync<T> (object pk, bool recursive = false) where T : new();

		Task DeleteAllAsync (IEnumerable objects, bool recursive = false);

		Task DeleteAllIdsAsync<T> (IEnumerable<object> primaryKeyValues);

		Task DeleteAsync (object element, bool recursive);

		Task InsertAllWithChildrenAsync (IEnumerable elements, bool recursive = false);

		Task InsertOrReplaceAllWithChildrenAsync (IEnumerable elements, bool recursive = false);

		Task InsertOrReplaceWithChildrenAsync (object element, bool recursive = false);

		Task InsertWithChildrenAsync (object element, bool recursive = false);

		Task UpdateWithChildrenAsync (object element);

	}
}

