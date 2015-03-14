using System;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using SQLiteNetExtensions.Extensions;
using CIC.IDatabase;

namespace CIC.IDatabase.SQLite
{
	public class SQLiteDatabase : IDatabase
	{
		SQLiteConnection sqliteConnection;

		
		public SQLiteDatabase (SQLiteConnection sqliteConnection)
		{
			this.sqliteConnection = sqliteConnection;
		}

		#region ISQLiteConnection implementation

		public void Dispose ()
		{
			sqliteConnection.Dispose ();
		}

		public int DropTable<T> ()
		{
			return sqliteConnection.DropTable<T> ();
		}

		public int CreateTable<T> (CreateFlags createFlags = CreateFlags.None)
		{
			return sqliteConnection.CreateTable<T> ((global::SQLite.Net.Interop.CreateFlags)createFlags);
		}

		public int CreateTable (Type ty, CreateFlags createFlags = CreateFlags.None)
		{
			return sqliteConnection.CreateTable (ty, (global::SQLite.Net.Interop.CreateFlags)createFlags);
		}

		public int CreateIndex (string indexName, string tableName, string[] columnNames, bool unique = false)
		{
			return sqliteConnection.CreateIndex (indexName, tableName, columnNames, unique);
		}

		public int CreateIndex (string indexName, string tableName, string columnName, bool unique = false)
		{
			return sqliteConnection.CreateIndex (indexName, tableName, columnName, unique);
		}

		public int CreateIndex (string tableName, string columnName, bool unique = false)
		{
			return sqliteConnection.CreateIndex (tableName, columnName, unique);
		}

		public int CreateIndex (string tableName, string[] columnNames, bool unique = false)
		{
			return sqliteConnection.CreateIndex (tableName, columnNames, unique);
		}

		public void CreateIndex<T> (System.Linq.Expressions.Expression<Func<T, object>> property, bool unique = false)
		{
			sqliteConnection.CreateIndex (property,unique);
		}

		public int Execute (string query, params object[] args)
		{
			return sqliteConnection.Execute (query,args);
		}

		public T ExecuteScalar<T> (string query, params object[] args)
		{
			return sqliteConnection.ExecuteScalar<T> (query,args);
		}

		public System.Collections.Generic.List<T> Query<T> (string query, params object[] args) where T : new()
		{
			return sqliteConnection.Query<T>(query, args);
		}

		public System.Collections.Generic.IEnumerable<T> DeferredQuery<T> (string query, params object[] args) where T : new()
		{
			return sqliteConnection.DeferredQuery<T>(query, args);
		}

		public T Get<T> (object pk) where T : new()
		{
			return sqliteConnection.Get<T>(pk);
		}

		public T Get<T> (System.Linq.Expressions.Expression<Func<T, bool>> predicate) where T : new()
		{
			return sqliteConnection.Get<T>(predicate);
		}

		public T Find<T> (object pk) where T : new()
		{
			return sqliteConnection.Find<T>(pk);
		}

		public T Find<T> (System.Linq.Expressions.Expression<Func<T, bool>> predicate) where T : new()
		{
			return sqliteConnection.Find<T>(predicate);
		}

		public void BeginTransaction ()
		{
			sqliteConnection.BeginTransaction();
		}

		public string SaveTransactionPoint ()
		{
			return sqliteConnection.SaveTransactionPoint();
		}

		public void Rollback ()
		{
			sqliteConnection.Rollback();
		}

		public void RollbackTo (string savepoint)
		{
			sqliteConnection.RollbackTo(savepoint);
		}

		public void Release (string savepoint)
		{
			sqliteConnection.Release(savepoint);
		}

		public void Commit ()
		{
			sqliteConnection.Commit();
		}

		public void RunInTransaction (Action action)
		{
			sqliteConnection.RunInTransaction(action);
		}

		public int InsertAll (System.Collections.IEnumerable objects)
		{
			return sqliteConnection.InsertAll(objects);
		}

		public int InsertAll (System.Collections.IEnumerable objects, string extra)
		{
			return sqliteConnection.InsertAll(objects,extra);
		}

		public int InsertAll (System.Collections.IEnumerable objects, Type objType)
		{
			return sqliteConnection.InsertAll (objects, objType);
		}

		public int Insert (object obj)
		{
			return sqliteConnection.Insert (obj);
		}

		public int InsertOrReplace (object obj)
		{
			return sqliteConnection.InsertOrReplace (obj);
		}

		public int Insert (object obj, Type objType)
		{
			return sqliteConnection.Insert (obj, objType);
		}

		public int InsertOrReplace (object obj, Type objType)
		{
			return sqliteConnection.InsertOrReplace(obj,objType);
		}

		public int Insert (object obj, string extra)
		{
			return sqliteConnection.Insert (obj, extra);
		}

		public int Insert (object obj, string extra, Type objType)
		{
			return sqliteConnection.Insert (obj, extra, objType);
		}

		public int Update (object obj)
		{
			return sqliteConnection.Update (obj);
		}

		public int Update (object obj, Type objType)
		{
			return sqliteConnection.Update (obj, objType);
		}

		public int UpdateAll (System.Collections.IEnumerable objects)
		{
			return sqliteConnection.UpdateAll (objects);
		}

		public int Delete (object objectToDelete)
		{
			return sqliteConnection.Delete (objectToDelete);
		}

		public int Delete<T> (object primaryKey)
		{
			return sqliteConnection.Delete<T> (primaryKey);
		}

		public int DeleteAll<T> ()
		{
			return sqliteConnection.DeleteAll<T> ();
		}

		public void Close ()
		{
			sqliteConnection.Close ();
		}

		public bool IsInTransaction {
			get {
				return sqliteConnection.IsInTransaction;
			}
		}

		public IQuery<T> Table<T>() where T : class, new()
		{
			return new SQLiteQuery<T>(sqliteConnection.Table<T> ());
		}


		public T FindWithChildren<T> (object pk, bool recursive = false) where T : new()
		{
			return sqliteConnection.FindWithChildren<T> (pk, recursive);
		}

		public List<T> GetAllWithChildren<T> (System.Linq.Expressions.Expression<Func<T, bool>> filter = null, bool recursive = false) where T : new()
		{
			return sqliteConnection.GetAllWithChildren<T> (filter,recursive);
		}

		public void GetChild<T> (T element, System.Reflection.PropertyInfo relationshipProperty, bool recursive = false)
		{
			sqliteConnection.GetChild<T> (element,relationshipProperty, recursive);
		}

		public void GetChild<T> (T element, string relationshipProperty, bool recursive = false)
		{
			sqliteConnection.GetChild<T> (element, relationshipProperty, recursive);
		}

		public void GetChild<T> (T element, System.Linq.Expressions.Expression<Func<T, object>> propertyExpression, bool recursive = false)
		{
			sqliteConnection.GetChild<T> (element, propertyExpression, recursive);
		}

		public void GetChildren<T> (T element, bool recursive = false)
		{
			sqliteConnection.GetChildren<T> (element, recursive);
		}

		public T GetWithChildren<T> (object pk, bool recursive = false) where T : new()
		{
			return sqliteConnection.GetWithChildren<T> (pk, recursive);
		}

		public void Delete (object element, bool recursive)
		{
			sqliteConnection.Delete(element, recursive);
		}

		public void DeleteAll (System.Collections.IEnumerable objects, bool recursive = false)
		{
			sqliteConnection.DeleteAll (objects, recursive);
		}

		public void DeleteAllIds<T> (IEnumerable<object> primaryKeyValues)
		{
			sqliteConnection.DeleteAllIds<T> (primaryKeyValues);
		}

		public void InsertAllWithChildren (System.Collections.IEnumerable elements, bool recursive = false)
		{
			sqliteConnection.InsertAllWithChildren (elements, recursive);
		}

		public void InsertOrReplaceAllWithChildren (System.Collections.IEnumerable elements, bool recursive = false)
		{
			sqliteConnection.InsertOrReplaceAllWithChildren (elements, recursive);
		}

		public void InsertOrReplaceWithChildren (object element, bool recursive = false)
		{
			sqliteConnection.InsertOrReplaceWithChildren (element, recursive);
		}

		public void InsertWithChildren (object element, bool recursive = false)
		{
			sqliteConnection.InsertWithChildren (element, recursive);
		}

		public void UpdateWithChildren (object element)
		{
			sqliteConnection.UpdateWithChildren (element);
		}
		#endregion
	}
}

