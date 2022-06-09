
// <fileinfo name="Base\LogHandlerCollectionBase.cs">
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
/// The base class for <see cref="LogHandlerCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="LogHandlerCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class LogHandlerCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Log_IDColumnName  = "Log_ID";
	public const string MessageRequestColumnName  = "MessageRequest";
	public const string TimeRequestColumnName  = "TimeRequest";
	public const string MessageResponseColumnName  = "MessageResponse";
	public const string TimeResponseColumnName  = "TimeResponse";
	public const string UserRequestColumnName  = "UserRequest";
	public const string UserResponseColumnName  = "UserResponse";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public LogHandlerCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "LogHandler";
	}

	public LogHandlerCollectionBase() : base()
	{
		this.TABLENAME = "LogHandler";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>LogHandler</c> table.
	/// </summary>
	/// <returns>An array of <see cref="LogHandlerRow"/> objects.</returns>
	public virtual LogHandlerRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>LogHandler</c> table.
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
	/// to retrieve all records from the <c>LogHandler</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("LogHandler_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="LogHandlerRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="LogHandlerRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public LogHandlerRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			LogHandlerRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="LogHandlerRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="LogHandlerRow"/> objects.</returns>
	public LogHandlerRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="LogHandlerRow"/> objects that 
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
	/// <returns>An array of <see cref="LogHandlerRow"/> objects.</returns>
	public virtual LogHandlerRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			LogHandlerRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("LogHandler_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("LogHandler_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="LogHandlerRow"/> by the primary key.
	/// </summary>
	/// <param name="log_ID">The <c>Log_ID</c> column value.</param>
	/// <returns>An instance of <see cref="LogHandlerRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual LogHandlerRow GetByPrimaryKey(int log_ID)
	{
		string LOCATION = "GetByPrimaryKey(int log_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("LogHandler_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Log_ID", log_ID);
			LogHandlerRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>LogHandler</c> table.
	/// </summary>
	/// <param name="value">The <see cref="LogHandlerRow"/> object to be inserted.</param>
	public virtual void Insert(LogHandlerRow value)
	{
		string LOCATION = "Insert(LogHandlerRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("LogHandler_Insert", CommandType.StoredProcedure);
					// MessageRequest
			if (value.IsMessageRequestNull )
				AddParameter(cmd, "MessageRequest", DBNull.Value);
			else
				AddParameter(cmd, "MessageRequest", value.MessageRequest);
			
				// TimeRequest
			if (value.IsTimeRequestNull )
				AddParameter(cmd, "TimeRequest", DBNull.Value);
			else
				AddParameter(cmd, "TimeRequest", value.TimeRequest);
			
				// MessageResponse
			if (value.IsMessageResponseNull )
				AddParameter(cmd, "MessageResponse", DBNull.Value);
			else
				AddParameter(cmd, "MessageResponse", value.MessageResponse);
			
				// TimeResponse
			if (value.IsTimeResponseNull )
				AddParameter(cmd, "TimeResponse", DBNull.Value);
			else
				AddParameter(cmd, "TimeResponse", value.TimeResponse);
			
				// UserRequest
			if (value.IsUserRequestNull)
				AddParameter(cmd, "UserRequest", DBNull.Value);
			else
				AddParameter(cmd, "UserRequest", value.UserRequest);
			
				// UserResponse
			if (value.IsUserResponseNull)
				AddParameter(cmd, "UserResponse", DBNull.Value);
			else
				AddParameter(cmd, "UserResponse", value.UserResponse);
			
						value.Log_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>LogHandler</c> table.
	/// </summary>
	/// <param name="value">The <see cref="LogHandlerRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(LogHandlerRow value)
	{	
		string LOCATION = "Update(LogHandlerRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("LogHandler_Update", CommandType.StoredProcedure);
					// MessageRequest
			if (value.IsMessageRequestNull)
				AddParameter(cmd, "MessageRequest", DBNull.Value);
			else
				AddParameter(cmd, "MessageRequest", value.MessageRequest);
				// TimeRequest
			if (value.IsTimeRequestNull)
				AddParameter(cmd, "TimeRequest", DBNull.Value);
			else
				AddParameter(cmd, "TimeRequest", value.TimeRequest);
				// MessageResponse
			if (value.IsMessageResponseNull)
				AddParameter(cmd, "MessageResponse", DBNull.Value);
			else
				AddParameter(cmd, "MessageResponse", value.MessageResponse);
				// TimeResponse
			if (value.IsTimeResponseNull)
				AddParameter(cmd, "TimeResponse", DBNull.Value);
			else
				AddParameter(cmd, "TimeResponse", value.TimeResponse);
				// UserRequest
			if (value.IsUserRequestNull)
				AddParameter(cmd, "UserRequest", DBNull.Value);
			else
				AddParameter(cmd, "UserRequest", value.UserRequest);
			
				// UserResponse
			if (value.IsUserResponseNull)
				AddParameter(cmd, "UserResponse", DBNull.Value);
			else
				AddParameter(cmd, "UserResponse", value.UserResponse);
			
					AddParameter(cmd, "Log_ID", value.Log_ID);
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
		/// Inserts or Updates a record in the <c>LogHandler</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="LogHandlerRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(LogHandlerRow value)
		{
			string LOCATION = "Save(LogHandlerRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("LogHandler_Save",CommandType.StoredProcedure);
					// MessageRequest
				if (value.IsMessageRequestNull)
					AddParameter(cmd, "MessageRequest", DBNull.Value);
				else
					AddParameter(cmd, "MessageRequest", (object)(value.MessageRequest));
				
					// TimeRequest
				if (value.IsTimeRequestNull)
					AddParameter(cmd, "TimeRequest", DBNull.Value);
				else
					AddParameter(cmd, "TimeRequest", (object)(value.TimeRequest));
				
					// MessageResponse
				if (value.IsMessageResponseNull)
					AddParameter(cmd, "MessageResponse", DBNull.Value);
				else
					AddParameter(cmd, "MessageResponse", (object)(value.MessageResponse));
				
					// TimeResponse
				if (value.IsTimeResponseNull)
					AddParameter(cmd, "TimeResponse", DBNull.Value);
				else
					AddParameter(cmd, "TimeResponse", (object)(value.TimeResponse));
				
					// UserRequest
				if (value.IsUserRequestNull)
					AddParameter(cmd, "UserRequest", DBNull.Value);
				else
					AddParameter(cmd, "UserRequest", (object)(value.UserRequest));
				
					// UserResponse
				if (value.IsUserResponseNull)
					AddParameter(cmd, "UserResponse", DBNull.Value);
				else
					AddParameter(cmd, "UserResponse", (object)(value.UserResponse));
				
						AddParameter(cmd, "Log_ID", value.Log_ID);
						value.Log_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Log_ID"]);
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
	/// Deletes the specified object from the <c>LogHandler</c> table.
	/// </summary>
	/// <param name="value">The <see cref="LogHandlerRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(LogHandlerRow value)
	{
		return DeleteByPrimaryKey(value.Log_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>LogHandler</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="log_ID">The <c>Log_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int log_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int log_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("LogHandler_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Log_ID", log_ID);
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
	/// Deletes <c>LogHandler</c> records that match the specified criteria.
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
	/// to delete <c>LogHandler</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("LogHandler_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>LogHandler</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("LogHandler_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="LogHandlerRow"/> objects.</returns>
	protected LogHandlerRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="LogHandlerRow"/> objects.</returns>
	protected LogHandlerRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="LogHandlerRow"/> objects.</returns>
	protected virtual LogHandlerRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Log_ID
		int log_IDColumnIndex = reader.GetOrdinal("Log_ID");
		// MessageRequest
		int messageRequestColumnIndex = reader.GetOrdinal("MessageRequest");
		// TimeRequest
		int timeRequestColumnIndex = reader.GetOrdinal("TimeRequest");
		// MessageResponse
		int messageResponseColumnIndex = reader.GetOrdinal("MessageResponse");
		// TimeResponse
		int timeResponseColumnIndex = reader.GetOrdinal("TimeResponse");
		// UserRequest
		int userRequestColumnIndex = reader.GetOrdinal("UserRequest");
		// UserResponse
		int userResponseColumnIndex = reader.GetOrdinal("UserResponse");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				LogHandlerRow record = new LogHandlerRow();
				recordList.Add(record);

					record.Log_ID = Convert.ToInt32(reader.GetValue(log_IDColumnIndex));
					if(!reader.IsDBNull(messageRequestColumnIndex))
						record.MessageRequest = Convert.ToString(reader.GetValue(messageRequestColumnIndex));
					if(!reader.IsDBNull(timeRequestColumnIndex))
						record.TimeRequest = Convert.ToString(reader.GetValue(timeRequestColumnIndex));
					if(!reader.IsDBNull(messageResponseColumnIndex))
						record.MessageResponse = Convert.ToString(reader.GetValue(messageResponseColumnIndex));
					if(!reader.IsDBNull(timeResponseColumnIndex))
						record.TimeResponse = Convert.ToString(reader.GetValue(timeResponseColumnIndex));
					if(!reader.IsDBNull(userRequestColumnIndex))
						record.UserRequest = reader.GetGuid(userRequestColumnIndex);
					if(!reader.IsDBNull(userResponseColumnIndex))
						record.UserResponse = reader.GetGuid(userResponseColumnIndex);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (LogHandlerRow[])(recordList.ToArray(typeof(LogHandlerRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="LogHandlerRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="LogHandlerRow"/> object.</returns>
	protected virtual LogHandlerRow MapRow(DataRow row)
	{
		string LOCATION = "LogHandlerRow MapRow(DataRow row)";
		LogHandlerRow mappedObject = new LogHandlerRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Log_ID"
		dataColumn = dataTable.Columns["Log_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Log_ID = (int)(row[dataColumn]);
		// Column "MessageRequest"
		dataColumn = dataTable.Columns["MessageRequest"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MessageRequest = (string)(row[dataColumn]);
		// Column "TimeRequest"
		dataColumn = dataTable.Columns["TimeRequest"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TimeRequest = (string)(row[dataColumn]);
		// Column "MessageResponse"
		dataColumn = dataTable.Columns["MessageResponse"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MessageResponse = (string)(row[dataColumn]);
		// Column "TimeResponse"
		dataColumn = dataTable.Columns["TimeResponse"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TimeResponse = (string)(row[dataColumn]);
		// Column "UserRequest"
		dataColumn = dataTable.Columns["UserRequest"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserRequest = (System.Guid)(row[dataColumn]);
		// Column "UserResponse"
		dataColumn = dataTable.Columns["UserResponse"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserResponse = (System.Guid)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>LogHandler</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "LogHandler";
		DataColumn dataColumn;
		// Create the "Log_ID" column
		dataColumn = dataTable.Columns.Add("Log_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "MessageRequest" column
		dataColumn = dataTable.Columns.Add("MessageRequest", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "TimeRequest" column
		dataColumn = dataTable.Columns.Add("TimeRequest", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "MessageResponse" column
		dataColumn = dataTable.Columns.Add("MessageResponse", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "TimeResponse" column
		dataColumn = dataTable.Columns.Add("TimeResponse", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "UserRequest" column
		dataColumn = dataTable.Columns.Add("UserRequest", typeof(System.Guid));
		// Create the "UserResponse" column
		dataColumn = dataTable.Columns.Add("UserResponse", typeof(System.Guid));
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
			case "Log_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "MessageRequest":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TimeRequest":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MessageResponse":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TimeResponse":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UserRequest":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "UserResponse":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="LogHandlerRow"/> by the primary key.
	/// </summary>
	/// <param name="log_ID">The <c>Log_ID</c> column value.</param>
	/// <returns>An instance of <see cref="LogHandlerRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int log_ID)
	{
		string LOCATION = "Exist(int log_ID)";
		IDbCommand cmd = _db.CreateCommand("LogHandler_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Log_ID", log_ID);
		LogHandlerRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




