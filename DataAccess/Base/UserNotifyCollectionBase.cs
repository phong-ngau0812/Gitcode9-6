
// <fileinfo name="Base\UserNotifyCollectionBase.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" >Smc SaleFrame1.0</generator>
// </fileinfo>


using System;
using System.Data;
using DbObj;


namespace Base
{

/// <summary>
/// The base class for <see cref="UserNotifyCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="UserNotifyCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class UserNotifyCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string UserNotify_IDColumnName  = "UserNotify_ID";
	public const string UserNotifyType_IDColumnName  = "UserNotifyType_ID";
	public const string ToUserIDColumnName  = "ToUserID";
	public const string SubjectColumnName  = "Subject";
	public const string ContentColumnName  = "Content";
	public const string URLColumnName  = "URL";
	public const string CreateDateColumnName  = "CreateDate";
	public const string ReadedColumnName  = "Readed";
	public const string ReadCountColumnName  = "ReadCount";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public UserNotifyCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "UserNotify";
	}

	public UserNotifyCollectionBase() : base()
	{
		this.TABLENAME = "UserNotify";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>UserNotify</c> table.
	/// </summary>
	/// <returns>An array of <see cref="UserNotifyRow"/> objects.</returns>
	public virtual UserNotifyRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>UserNotify</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public virtual DataTable GetAllAsDataTable()
	{	
		string LOCATION = "GetAllAsDataTable()";
		try
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
	}

	/// <summary>
	/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
	/// to retrieve all records from the <c>UserNotify</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("UserNotify_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="UserNotifyRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="UserNotifyRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public UserNotifyRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			UserNotifyRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			if (0 == rows.Length)
				return null;
			return rows[0];
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets an array of <see cref="UserNotifyRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="UserNotifyRow"/> objects.</returns>
	public UserNotifyRow[] GetAsArray(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql)";
		IDataReader reader = null;
		try
		{
			reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
			return MapRecords(reader);
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			if(reader != null)
				reader.Dispose();
            		_db.Dispose();
		}
	}

	/// <summary>
	/// Gets an array of <see cref="UserNotifyRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example:
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <param name="startIndex">The index of the first record to return.</param>
	/// <param name="length">The number of records to return.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>An array of <see cref="UserNotifyRow"/> objects.</returns>
	public virtual UserNotifyRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			UserNotifyRow[] rows = MapRecords(reader);
			reader.Close();
			System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
			totalRecordCount = (int)p.Value;
			return rows;
		}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
			cmd.Dispose();
			_db.Dispose();
		}
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public DataTable GetAsDataTable(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
		IDataReader reader = null;
		try
		{
			reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
			return MapRecordsToDataTable(reader);
		}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
            		_db.Dispose();
		}
		
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <param name="startIndex">The index of the first record to return.</param>
	/// <param name="length">The number of records to return.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public virtual DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			DataTable table = MapRecordsToDataTable(reader);
			reader.Close();
			System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
			totalRecordCount = (int)p.Value;
			return table;
		}
		catch(Exception ex)
		{

		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
			cmd.Dispose();
			_db.Dispose();
		}
	}

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
	{
		string LOCATION = "CreateGetCommand(string whereSql, string orderBySql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("UserNotify_GetAdHoc", CommandType.StoredProcedure);
			_db.AddParameter(cmd, "where", DbType.String, whereSql);
			_db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
			return cmd;
		}
        	catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
	/// <param name="startIndex">The index of the first record to return.</param>
	/// <param name="length">The number of records to return.</param>		
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)
	{
		string LOCATION = "CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("UserNotify_GetPageAdHoc", CommandType.StoredProcedure);
				
			_db.AddParameter(cmd, "where", DbType.String, whereSql);
			_db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
			_db.AddParameter(cmd, "startIndex", DbType.Int32, startIndex + 1);
			_db.AddParameter(cmd, "length", DbType.Int32, length);

			IDbDataParameter parameter = _db.AddParameter(cmd, "rows", DbType.Int32, -1);
			parameter.Direction = ParameterDirection.InputOutput;
						
			return cmd;
		}
        	catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}
		

	/// <summary>
	/// Gets <see cref="UserNotifyRow"/> by the primary key.
	/// </summary>
	/// <param name="userNotify_ID">The <c>UserNotify_ID</c> column value.</param>
	/// <returns>An instance of <see cref="UserNotifyRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual UserNotifyRow GetByPrimaryKey(System.Guid userNotify_ID)
	{
		string LOCATION = "GetByPrimaryKey(System.Guid userNotify_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("UserNotify_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "UserNotify_ID", userNotify_ID);
			UserNotifyRow[] tempArray = MapRecords(cmd);
			if( 0 == tempArray.Length)
				return null;
		
			return tempArray[0];
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}



	/// <summary>
	/// Adds a new record into the <c>UserNotify</c> table.
	/// </summary>
	/// <param name="value">The <see cref="UserNotifyRow"/> object to be inserted.</param>
	public virtual void Insert(UserNotifyRow value)
	{
		string LOCATION = "Insert(UserNotifyRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("UserNotify_Insert", CommandType.StoredProcedure);
					// UserNotify_ID
			if (value.IsUserNotify_IDNull )
				AddParameter(cmd, "UserNotify_ID", DBNull.Value);
			else
				AddParameter(cmd, "UserNotify_ID", value.UserNotify_ID);
			
				// UserNotifyType_ID
			if (value.IsUserNotifyType_IDNull)
				AddParameter(cmd, "UserNotifyType_ID", DBNull.Value);
			else
				AddParameter(cmd, "UserNotifyType_ID", value.UserNotifyType_ID);
			
				// ToUserID
			if (value.IsToUserIDNull)
				AddParameter(cmd, "ToUserID", DBNull.Value);
			else
				AddParameter(cmd, "ToUserID", value.ToUserID);
			
				// Subject
			if (value.IsSubjectNull )
				AddParameter(cmd, "Subject", DBNull.Value);
			else
				AddParameter(cmd, "Subject", value.Subject);
			
				// Content
			if (value.IsContentNull )
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
			
				// URL
			if (value.IsURLNull )
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// Readed
			if (value.IsReadedNull)
				AddParameter(cmd, "Readed", DBNull.Value);
			else
				AddParameter(cmd, "Readed", value.Readed);
			
				// ReadCount
			if (value.IsReadCountNull)
				AddParameter(cmd, "ReadCount", DBNull.Value);
			else
				AddParameter(cmd, "ReadCount", value.ReadCount);
			
					cmd.ExecuteNonQuery();
			}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
        	{
            		_db.Dispose();
        	}
	}

	/// <summary>
	/// Updates a record in the <c>UserNotify</c> table.
	/// </summary>
	/// <param name="value">The <see cref="UserNotifyRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(UserNotifyRow value)
	{	
		string LOCATION = "Update(UserNotifyRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("UserNotify_Update", CommandType.StoredProcedure);
					// UserNotifyType_ID
			if (value.IsUserNotifyType_IDNull)
				AddParameter(cmd, "UserNotifyType_ID", DBNull.Value);
			else
				AddParameter(cmd, "UserNotifyType_ID", value.UserNotifyType_ID);
			
				// ToUserID
			if (value.IsToUserIDNull)
				AddParameter(cmd, "ToUserID", DBNull.Value);
			else
				AddParameter(cmd, "ToUserID", value.ToUserID);
			
				// Subject
			if (value.IsSubjectNull)
				AddParameter(cmd, "Subject", DBNull.Value);
			else
				AddParameter(cmd, "Subject", value.Subject);
				// Content
			if (value.IsContentNull)
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
				// URL
			if (value.IsURLNull)
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// Readed
			if (value.IsReadedNull)
				AddParameter(cmd, "Readed", DBNull.Value);
			else
				AddParameter(cmd, "Readed", value.Readed);
			
				// ReadCount
			if (value.IsReadCountNull)
				AddParameter(cmd, "ReadCount", DBNull.Value);
			else
				AddParameter(cmd, "ReadCount", value.ReadCount);
			
					AddParameter(cmd, "UserNotify_ID", value.UserNotify_ID);
				return 0 != cmd.ExecuteNonQuery();
	}
        catch(Exception ex)
	{
            throw new Exceptions.DatabaseException(LOCATION, ex);
        }		
	finally
        {
            _db.Dispose();
        }
	}

		/// <summary>
		/// Inserts or Updates a record in the <c>UserNotify</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="UserNotifyRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(UserNotifyRow value)
		{
			string LOCATION = "Save(UserNotifyRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("UserNotify_Save",CommandType.StoredProcedure);
					// UserNotifyType_ID
				if (value.IsUserNotifyType_IDNull)
					AddParameter(cmd, "UserNotifyType_ID", DBNull.Value);
				else
					AddParameter(cmd, "UserNotifyType_ID", (object)(value.UserNotifyType_ID));
				
					// ToUserID
				if (value.IsToUserIDNull)
					AddParameter(cmd, "ToUserID", DBNull.Value);
				else
					AddParameter(cmd, "ToUserID", (object)(value.ToUserID));
				
					// Subject
				if (value.IsSubjectNull)
					AddParameter(cmd, "Subject", DBNull.Value);
				else
					AddParameter(cmd, "Subject", (object)(value.Subject));
				
					// Content
				if (value.IsContentNull)
					AddParameter(cmd, "Content", DBNull.Value);
				else
					AddParameter(cmd, "Content", (object)(value.Content));
				
					// URL
				if (value.IsURLNull)
					AddParameter(cmd, "URL", DBNull.Value);
				else
					AddParameter(cmd, "URL", (object)(value.URL));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// Readed
				if (value.IsReadedNull)
					AddParameter(cmd, "Readed", DBNull.Value);
				else
					AddParameter(cmd, "Readed", (object)(value.Readed));
				
					// ReadCount
				if (value.IsReadCountNull)
					AddParameter(cmd, "ReadCount", DBNull.Value);
				else
					AddParameter(cmd, "ReadCount", (object)(value.ReadCount));
				
						AddParameter(cmd, "UserNotify_ID", value.UserNotify_ID);
						cmd.ExecuteNonQuery();
			}
            	catch(Exception ex)
		{
	                throw new Exceptions.DatabaseException(LOCATION, ex);
            	}
		finally
        	{
            		_db.Dispose();
        	}
	}

	
	public virtual void Update(DataTable table, bool acceptChanges)
	{
		string LOCATION = "Update(DataTable table, bool acceptChanges)";
		try
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((System.Guid)row["UserNotify_ID"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}
        	catch(Exception ex)
		{
            		throw new Exceptions.DatabaseException(LOCATION, ex);
		}
        }

	/// <summary>
	/// Deletes the specified object from the <c>UserNotify</c> table.
	/// </summary>
	/// <param name="value">The <see cref="UserNotifyRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(UserNotifyRow value)
	{
		return DeleteByPrimaryKey(value.UserNotify_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>UserNotify</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="userNotify_ID">The <c>UserNotify_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(System.Guid userNotify_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(System.Guid userNotify_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("UserNotify_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "UserNotify_ID", userNotify_ID);
				return (0 < cmd.ExecuteNonQuery());
	}
        catch(Exception ex)
	{
            throw new Exceptions.DatabaseException(LOCATION, ex);
        }	
	finally
        {
            _db.Dispose();
        }	
}

	/// <summary>
	/// Deletes <c>UserNotify</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>The number of deleted records.</returns>
	public int Delete(string whereSql)
	{
		string LOCATION = "Delete(string whereSql)";
		try
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}
		catch(Exception ex)
		{
			throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
        	{
            		_db.Dispose();
        	}
	}

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
	/// to delete <c>UserNotify</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("UserNotify_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>UserNotify</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("UserNotify_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
			}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 
		finally
        	{
            		_db.Dispose();
        	}
        }

	/// <summary>
	/// Reads data using the specified command and returns 
	/// an array of mapped objects.
	/// </summary>
	/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
	/// <returns>An array of <see cref="UserNotifyRow"/> objects.</returns>
	protected UserNotifyRow[] MapRecords(IDbCommand command)
	{
		string LOCATION = "MapRecords(IDbCommand command)";
		IDataReader reader = _db.ExecuteReader(command);
		try
		{
			return MapRecords(reader);
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
		        _db.Dispose();
        		
		}
	}

	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// an array of mapped objects.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <returns>An array of <see cref="UserNotifyRow"/> objects.</returns>
	protected UserNotifyRow[] MapRecords(IDataReader reader)
	{
		int totalRecordCount = -1;
		return MapRecords(reader, 0, int.MaxValue,ref totalRecordCount);
	}

	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// an array of mapped objects.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <param name="startIndex">The index of the first record to map.</param>
	/// <param name="length">The number of records to map.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>An array of <see cref="UserNotifyRow"/> objects.</returns>
	protected virtual UserNotifyRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// UserNotify_ID
		int userNotify_IDColumnIndex = reader.GetOrdinal("UserNotify_ID");
		// UserNotifyType_ID
		int userNotifyType_IDColumnIndex = reader.GetOrdinal("UserNotifyType_ID");
		// ToUserID
		int toUserIDColumnIndex = reader.GetOrdinal("ToUserID");
		// Subject
		int subjectColumnIndex = reader.GetOrdinal("Subject");
		// Content
		int contentColumnIndex = reader.GetOrdinal("Content");
		// URL
		int urlColumnIndex = reader.GetOrdinal("URL");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// Readed
		int readedColumnIndex = reader.GetOrdinal("Readed");
		// ReadCount
		int readCountColumnIndex = reader.GetOrdinal("ReadCount");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				UserNotifyRow record = new UserNotifyRow();
				recordList.Add(record);

					record.UserNotify_ID = reader.GetGuid(userNotify_IDColumnIndex);
					if(!reader.IsDBNull(userNotifyType_IDColumnIndex))
						record.UserNotifyType_ID = Convert.ToInt32(reader.GetValue(userNotifyType_IDColumnIndex));
					if(!reader.IsDBNull(toUserIDColumnIndex))
						record.ToUserID = reader.GetGuid(toUserIDColumnIndex);
					if(!reader.IsDBNull(subjectColumnIndex))
						record.Subject = Convert.ToString(reader.GetValue(subjectColumnIndex));
					if(!reader.IsDBNull(contentColumnIndex))
						record.Content = Convert.ToString(reader.GetValue(contentColumnIndex));
					if(!reader.IsDBNull(urlColumnIndex))
						record.URL = Convert.ToString(reader.GetValue(urlColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(readedColumnIndex))
						record.Readed = Convert.ToBoolean(reader.GetValue(readedColumnIndex));
					if(!reader.IsDBNull(readCountColumnIndex))
						record.ReadCount = Convert.ToInt32(reader.GetValue(readCountColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (UserNotifyRow[])(recordList.ToArray(typeof(UserNotifyRow)));
	}

	/// <summary>
	/// Reads data using the specified command and returns 
	/// a filled <see cref="System.Data.DataTable"/> object.
	/// </summary>
	/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected DataTable MapRecordsToDataTable(IDbCommand command)
	{
		string LOCATION = "MapRecordsToDataTable(IDbCommand command)";
		IDataReader reader = _db.ExecuteReader(command);
		try
		{
			return MapRecordsToDataTable(reader);
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		}
		finally
		{
			reader.Dispose();
			_db.Dispose();
		}
	}
	
	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// a filled <see cref="System.Data.DataTable"/> object.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected DataTable MapRecordsToDataTable(IDataReader reader)
	{
		int totalRecordCount = 0;
		return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
	}
	
	/// <summary>
	/// Reads data from the provided data reader and returns 
	/// a filled <see cref="System.Data.DataTable"/> object.
	/// </summary>
	/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
	/// <param name="startIndex">The index of the first record to read.</param>
	/// <param name="length">The number of records to read.</param>
	/// <param name="totalRecordCount">A reference parameter that returns the total number 
	/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable MapRecordsToDataTable(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "MapRecordsToDataTable(reader,startIndex,length,ref totalRecordCount)";
		if(0 > startIndex)
			throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
		if(0 > length)
			throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");
		int columnCount = reader.FieldCount;
		int ri = -startIndex;
		
		DataTable dataTable = CreateDataTable();
		dataTable.BeginLoadData();
		object[] values = new object[columnCount];
		
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				reader.GetValues(values);
				dataTable.LoadDataRow(values, true);
				if(ri == length && 0 != totalRecordCount)
					break;
			}
		}
		dataTable.EndLoadData();

		if( 0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return dataTable;
	}

	/// <summary>
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="UserNotifyRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="UserNotifyRow"/> object.</returns>
	protected virtual UserNotifyRow MapRow(DataRow row)
	{
		string LOCATION = "UserNotifyRow MapRow(DataRow row)";
		UserNotifyRow mappedObject = new UserNotifyRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "UserNotify_ID"
		dataColumn = dataTable.Columns["UserNotify_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserNotify_ID = (System.Guid)(row[dataColumn]);
		// Column "UserNotifyType_ID"
		dataColumn = dataTable.Columns["UserNotifyType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserNotifyType_ID = (int)(row[dataColumn]);
		// Column "ToUserID"
		dataColumn = dataTable.Columns["ToUserID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ToUserID = (System.Guid)(row[dataColumn]);
		// Column "Subject"
		dataColumn = dataTable.Columns["Subject"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Subject = (string)(row[dataColumn]);
		// Column "Content"
		dataColumn = dataTable.Columns["Content"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Content = (string)(row[dataColumn]);
		// Column "URL"
		dataColumn = dataTable.Columns["URL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.URL = (string)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "Readed"
		dataColumn = dataTable.Columns["Readed"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Readed = (bool)(row[dataColumn]);
		// Column "ReadCount"
		dataColumn = dataTable.Columns["ReadCount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ReadCount = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>UserNotify</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "UserNotify";
		DataColumn dataColumn;
		// Create the "UserNotify_ID" column
		dataColumn = dataTable.Columns.Add("UserNotify_ID", typeof(System.Guid));
		dataColumn.AllowDBNull = false;
		// Create the "UserNotifyType_ID" column
		dataColumn = dataTable.Columns.Add("UserNotifyType_ID", typeof(int));
		// Create the "ToUserID" column
		dataColumn = dataTable.Columns.Add("ToUserID", typeof(System.Guid));
		// Create the "Subject" column
		dataColumn = dataTable.Columns.Add("Subject", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Content" column
		dataColumn = dataTable.Columns.Add("Content", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "URL" column
		dataColumn = dataTable.Columns.Add("URL", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "Readed" column
		dataColumn = dataTable.Columns.Add("Readed", typeof(bool));
		// Create the "ReadCount" column
		dataColumn = dataTable.Columns.Add("ReadCount", typeof(int));
		return dataTable;
	}
	
	/// <summary>
	/// Adds a new parameter to the specified command.
	/// </summary>
	/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
	/// <param name="paramName">The name of the parameter.</param>
	/// <param name="value">The value of the parameter.</param>
	/// <returns>A reference to the added parameter.</returns>
	protected virtual IDbDataParameter AddParameter(IDbCommand cmd, String paramName, object value)
	{
		string LOCATION = "AddParameter(IDbCommand cmd, String paramName, object value)";
		IDbDataParameter parameter;
		switch(paramName)
		{
			case "UserNotify_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "UserNotifyType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ToUserID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "Subject":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Content":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "URL":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Readed":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "ReadCount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="UserNotifyRow"/> by the primary key.
	/// </summary>
	/// <param name="userNotify_ID">The <c>UserNotify_ID</c> column value.</param>
	/// <returns>An instance of <see cref="UserNotifyRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(System.Guid userNotify_ID)
	{
		string LOCATION = "Exist(System.Guid userNotify_ID)";
		IDbCommand cmd = _db.CreateCommand("UserNotify_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "UserNotify_ID", userNotify_ID);
		UserNotifyRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




