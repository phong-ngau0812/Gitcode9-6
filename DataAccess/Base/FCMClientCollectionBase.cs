
// <fileinfo name="Base\FCMClientCollectionBase.cs">
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
/// The base class for <see cref="FCMClientCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="FCMClientCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FCMClientCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string FCMClient_IDColumnName  = "FCMClient_ID";
	public const string Device_IDColumnName  = "Device_ID";
	public const string OSColumnName  = "OS";
	public const string FirebaseTokenColumnName  = "FirebaseToken";
	public const string CreateDateColumnName  = "CreateDate";
	public const string UserNameColumnName  = "UserName";
	public const string UserIDColumnName  = "UserID";
	public const string TopicColumnName  = "Topic";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public FCMClientCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "FCMClient";
	}

	public FCMClientCollectionBase() : base()
	{
		this.TABLENAME = "FCMClient";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>FCMClient</c> table.
	/// </summary>
	/// <returns>An array of <see cref="FCMClientRow"/> objects.</returns>
	public virtual FCMClientRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>FCMClient</c> table.
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
	/// to retrieve all records from the <c>FCMClient</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("FCMClient_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="FCMClientRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="FCMClientRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public FCMClientRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			FCMClientRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="FCMClientRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="FCMClientRow"/> objects.</returns>
	public FCMClientRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="FCMClientRow"/> objects that 
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
	/// <returns>An array of <see cref="FCMClientRow"/> objects.</returns>
	public virtual FCMClientRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			FCMClientRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("FCMClient_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("FCMClient_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="FCMClientRow"/> by the primary key.
	/// </summary>
	/// <param name="fCMClient_ID">The <c>FCMClient_ID</c> column value.</param>
	/// <returns>An instance of <see cref="FCMClientRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual FCMClientRow GetByPrimaryKey(System.Guid fCMClient_ID)
	{
		string LOCATION = "GetByPrimaryKey(System.Guid fCMClient_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("FCMClient_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "FCMClient_ID", fCMClient_ID);
			FCMClientRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>FCMClient</c> table.
	/// </summary>
	/// <param name="value">The <see cref="FCMClientRow"/> object to be inserted.</param>
	public virtual void Insert(FCMClientRow value)
	{
		string LOCATION = "Insert(FCMClientRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("FCMClient_Insert", CommandType.StoredProcedure);
					// FCMClient_ID
			if (value.IsFCMClient_IDNull )
				AddParameter(cmd, "FCMClient_ID", DBNull.Value);
			else
				AddParameter(cmd, "FCMClient_ID", value.FCMClient_ID);
			
				// Device_ID
			if (value.IsDevice_IDNull )
				AddParameter(cmd, "Device_ID", DBNull.Value);
			else
				AddParameter(cmd, "Device_ID", value.Device_ID);
			
				// OS
			if (value.IsOSNull )
				AddParameter(cmd, "OS", DBNull.Value);
			else
				AddParameter(cmd, "OS", value.OS);
			
				// FirebaseToken
			if (value.IsFirebaseTokenNull )
				AddParameter(cmd, "FirebaseToken", DBNull.Value);
			else
				AddParameter(cmd, "FirebaseToken", value.FirebaseToken);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// UserName
			if (value.IsUserNameNull )
				AddParameter(cmd, "UserName", DBNull.Value);
			else
				AddParameter(cmd, "UserName", value.UserName);
			
				// UserID
			if (value.IsUserIDNull)
				AddParameter(cmd, "UserID", DBNull.Value);
			else
				AddParameter(cmd, "UserID", value.UserID);
			
				// Topic
			if (value.IsTopicNull )
				AddParameter(cmd, "Topic", DBNull.Value);
			else
				AddParameter(cmd, "Topic", value.Topic);
			
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
	/// Updates a record in the <c>FCMClient</c> table.
	/// </summary>
	/// <param name="value">The <see cref="FCMClientRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(FCMClientRow value)
	{	
		string LOCATION = "Update(FCMClientRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("FCMClient_Update", CommandType.StoredProcedure);
					// Device_ID
			if (value.IsDevice_IDNull)
				AddParameter(cmd, "Device_ID", DBNull.Value);
			else
				AddParameter(cmd, "Device_ID", value.Device_ID);
				// OS
			if (value.IsOSNull)
				AddParameter(cmd, "OS", DBNull.Value);
			else
				AddParameter(cmd, "OS", value.OS);
				// FirebaseToken
			if (value.IsFirebaseTokenNull)
				AddParameter(cmd, "FirebaseToken", DBNull.Value);
			else
				AddParameter(cmd, "FirebaseToken", value.FirebaseToken);
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// UserName
			if (value.IsUserNameNull)
				AddParameter(cmd, "UserName", DBNull.Value);
			else
				AddParameter(cmd, "UserName", value.UserName);
				// UserID
			if (value.IsUserIDNull)
				AddParameter(cmd, "UserID", DBNull.Value);
			else
				AddParameter(cmd, "UserID", value.UserID);
			
				// Topic
			if (value.IsTopicNull)
				AddParameter(cmd, "Topic", DBNull.Value);
			else
				AddParameter(cmd, "Topic", value.Topic);
					AddParameter(cmd, "FCMClient_ID", value.FCMClient_ID);
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
		/// Inserts or Updates a record in the <c>FCMClient</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="FCMClientRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(FCMClientRow value)
		{
			string LOCATION = "Save(FCMClientRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("FCMClient_Save",CommandType.StoredProcedure);
					// Device_ID
				if (value.IsDevice_IDNull)
					AddParameter(cmd, "Device_ID", DBNull.Value);
				else
					AddParameter(cmd, "Device_ID", (object)(value.Device_ID));
				
					// OS
				if (value.IsOSNull)
					AddParameter(cmd, "OS", DBNull.Value);
				else
					AddParameter(cmd, "OS", (object)(value.OS));
				
					// FirebaseToken
				if (value.IsFirebaseTokenNull)
					AddParameter(cmd, "FirebaseToken", DBNull.Value);
				else
					AddParameter(cmd, "FirebaseToken", (object)(value.FirebaseToken));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// UserName
				if (value.IsUserNameNull)
					AddParameter(cmd, "UserName", DBNull.Value);
				else
					AddParameter(cmd, "UserName", (object)(value.UserName));
				
					// UserID
				if (value.IsUserIDNull)
					AddParameter(cmd, "UserID", DBNull.Value);
				else
					AddParameter(cmd, "UserID", (object)(value.UserID));
				
					// Topic
				if (value.IsTopicNull)
					AddParameter(cmd, "Topic", DBNull.Value);
				else
					AddParameter(cmd, "Topic", (object)(value.Topic));
				
						AddParameter(cmd, "FCMClient_ID", value.FCMClient_ID);
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
							DeleteByPrimaryKey((System.Guid)row["FCMClient_ID"]);
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
	/// Deletes the specified object from the <c>FCMClient</c> table.
	/// </summary>
	/// <param name="value">The <see cref="FCMClientRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(FCMClientRow value)
	{
		return DeleteByPrimaryKey(value.FCMClient_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>FCMClient</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="fCMClient_ID">The <c>FCMClient_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(System.Guid fCMClient_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(System.Guid fCMClient_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("FCMClient_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "FCMClient_ID", fCMClient_ID);
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
	/// Deletes <c>FCMClient</c> records that match the specified criteria.
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
	/// to delete <c>FCMClient</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("FCMClient_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>FCMClient</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("FCMClient_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="FCMClientRow"/> objects.</returns>
	protected FCMClientRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="FCMClientRow"/> objects.</returns>
	protected FCMClientRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="FCMClientRow"/> objects.</returns>
	protected virtual FCMClientRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// FCMClient_ID
		int fCMClient_IDColumnIndex = reader.GetOrdinal("FCMClient_ID");
		// Device_ID
		int device_IDColumnIndex = reader.GetOrdinal("Device_ID");
		// OS
		int osColumnIndex = reader.GetOrdinal("OS");
		// FirebaseToken
		int firebaseTokenColumnIndex = reader.GetOrdinal("FirebaseToken");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// UserName
		int userNameColumnIndex = reader.GetOrdinal("UserName");
		// UserID
		int userIDColumnIndex = reader.GetOrdinal("UserID");
		// Topic
		int topicColumnIndex = reader.GetOrdinal("Topic");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				FCMClientRow record = new FCMClientRow();
				recordList.Add(record);

					record.FCMClient_ID = reader.GetGuid(fCMClient_IDColumnIndex);
					if(!reader.IsDBNull(device_IDColumnIndex))
						record.Device_ID = Convert.ToString(reader.GetValue(device_IDColumnIndex));
					if(!reader.IsDBNull(osColumnIndex))
						record.OS = Convert.ToString(reader.GetValue(osColumnIndex));
					if(!reader.IsDBNull(firebaseTokenColumnIndex))
						record.FirebaseToken = Convert.ToString(reader.GetValue(firebaseTokenColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(userNameColumnIndex))
						record.UserName = Convert.ToString(reader.GetValue(userNameColumnIndex));
					if(!reader.IsDBNull(userIDColumnIndex))
						record.UserID = reader.GetGuid(userIDColumnIndex);
					if(!reader.IsDBNull(topicColumnIndex))
						record.Topic = Convert.ToString(reader.GetValue(topicColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (FCMClientRow[])(recordList.ToArray(typeof(FCMClientRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="FCMClientRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="FCMClientRow"/> object.</returns>
	protected virtual FCMClientRow MapRow(DataRow row)
	{
		string LOCATION = "FCMClientRow MapRow(DataRow row)";
		FCMClientRow mappedObject = new FCMClientRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "FCMClient_ID"
		dataColumn = dataTable.Columns["FCMClient_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FCMClient_ID = (System.Guid)(row[dataColumn]);
		// Column "Device_ID"
		dataColumn = dataTable.Columns["Device_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Device_ID = (string)(row[dataColumn]);
		// Column "OS"
		dataColumn = dataTable.Columns["OS"];
		if (! row.IsNull(dataColumn) )
			mappedObject.OS = (string)(row[dataColumn]);
		// Column "FirebaseToken"
		dataColumn = dataTable.Columns["FirebaseToken"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FirebaseToken = (string)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "UserName"
		dataColumn = dataTable.Columns["UserName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserName = (string)(row[dataColumn]);
		// Column "UserID"
		dataColumn = dataTable.Columns["UserID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserID = (System.Guid)(row[dataColumn]);
		// Column "Topic"
		dataColumn = dataTable.Columns["Topic"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Topic = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>FCMClient</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "FCMClient";
		DataColumn dataColumn;
		// Create the "FCMClient_ID" column
		dataColumn = dataTable.Columns.Add("FCMClient_ID", typeof(System.Guid));
		dataColumn.AllowDBNull = false;
		// Create the "Device_ID" column
		dataColumn = dataTable.Columns.Add("Device_ID", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "OS" column
		dataColumn = dataTable.Columns.Add("OS", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "FirebaseToken" column
		dataColumn = dataTable.Columns.Add("FirebaseToken", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "UserName" column
		dataColumn = dataTable.Columns.Add("UserName", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "UserID" column
		dataColumn = dataTable.Columns.Add("UserID", typeof(System.Guid));
		// Create the "Topic" column
		dataColumn = dataTable.Columns.Add("Topic", typeof(string));
		dataColumn.MaxLength = 50;
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
			case "FCMClient_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "Device_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "OS":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "FirebaseToken":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "UserName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UserID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "Topic":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="FCMClientRow"/> by the primary key.
	/// </summary>
	/// <param name="fCMClient_ID">The <c>FCMClient_ID</c> column value.</param>
	/// <returns>An instance of <see cref="FCMClientRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(System.Guid fCMClient_ID)
	{
		string LOCATION = "Exist(System.Guid fCMClient_ID)";
		IDbCommand cmd = _db.CreateCommand("FCMClient_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "FCMClient_ID", fCMClient_ID);
		FCMClientRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




