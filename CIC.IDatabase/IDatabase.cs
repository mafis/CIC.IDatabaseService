using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;

namespace CIC.IDatabase
{
	public interface IDatabase : IDisposable
	{
		int DropTable<T> ();

		int CreateTable<T> (CreateFlags createFlags = CreateFlags.None);

		int CreateTable (Type ty, CreateFlags createFlags = CreateFlags.None);

		int CreateIndex (string indexName, string tableName, string[] columnNames, bool unique = false);

		int CreateIndex (string indexName, string tableName, string columnName, bool unique = false);

		int CreateIndex (string tableName, string columnName, bool unique = false);

		int CreateIndex (string tableName, string[] columnNames, bool unique = false);

		void CreateIndex<T> (Expression<Func<T, object>> property, bool unique = false);

		int Execute (string query, params object[] args);

		T ExecuteScalar<T> (string query, params object[] args);

		List<T> Query<T> (string query, params object[] args) where T : new();

		IEnumerable<T> DeferredQuery<T> (string query, params object[] args) where T : new();

		T Get<T> (object pk) where T : new();

		T Get<T> (Expression<Func<T, bool>> predicate) where T : new();

		T Find<T> (object pk) where T : new();

		T Find<T> (Expression<Func<T, bool>> predicate) where T : new();

		bool IsInTransaction { get; }

		void BeginTransaction ();

		string SaveTransactionPoint ();

		void Rollback ();

		void RollbackTo (string savepoint);

		void Release (string savepoint);

		void Commit ();

		void RunInTransaction (Action action);

		int InsertAll (System.Collections.IEnumerable objects);

		int InsertAll (System.Collections.IEnumerable objects, string extra);

		int InsertAll (System.Collections.IEnumerable objects, Type objType);

		int Insert (object obj);

		int InsertOrReplace (object obj);

		int Insert (object obj, Type objType);

		int InsertOrReplace (object obj, Type objType);

		int Insert (object obj, string extra);

		int Insert (object obj, string extra, Type objType);

		int Update (object obj);

		int Update (object obj, Type objType);

		int UpdateAll (System.Collections.IEnumerable objects);

		int Delete (object objectToDelete);

		int Delete<T> (object primaryKey);

		int DeleteAll<T> ();

		void Close ();

		IQuery<T> Table<T> () where T : class, new();


		T FindWithChildren<T> (object pk, bool recursive = false) where T : new();

		List<T> GetAllWithChildren<T> (Expression<Func<T, bool>> filter = null, bool recursive = false) where T : new();

		void GetChild<T> (T element, PropertyInfo relationshipProperty, bool recursive = false);

		void GetChild<T> (T element, string relationshipProperty, bool recursive = false);

		void GetChild<T> (T element, Expression<Func<T, object>> propertyExpression, bool recursive = false);

		void GetChildren<T> (T element, bool recursive = false);
				T GetWithChildren<T> (object pk, bool recursive = false) where T : new();

		void Delete (object element, bool recursive);

		void DeleteAll (IEnumerable objects, bool recursive = false);

		void DeleteAllIds<T> (IEnumerable<object> primaryKeyValues);
	
		void InsertAllWithChildren (IEnumerable elements, bool recursive = false);

		void InsertOrReplaceAllWithChildren (IEnumerable elements, bool recursive = false);

		void InsertOrReplaceWithChildren (object element, bool recursive = false);

		void InsertWithChildren (object element, bool recursive = false);

		void UpdateWithChildren (object element);
	}
}

