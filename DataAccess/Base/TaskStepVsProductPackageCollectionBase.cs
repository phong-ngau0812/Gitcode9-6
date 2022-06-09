
// <fileinfo name="Base\TaskStepVsProductPackageCollectionBase.cs">
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
/// The base class for <see cref="TaskStepVsProductPackageCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TaskStepVsProductPackageCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TaskStepVsProductPackageCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string TaskStepVsProductPackage_IDColumnName  = "TaskStepVsProductPackage_ID";
	public const string TaskStep_IDColumnName  = "TaskStep_ID";
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string StartTimeColumnName  = "StartTime";
	public const string EndTimeColumnName  = "EndTime";
	public const string NoteColumnName  = "Note";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditedByColumnName  = "LastEditedBy";
	public const string LastEditedDateColumnName  = "LastEditedDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public TaskStepVsProductPackageCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "TaskStepVsProductPackage";
	}

	public TaskStepVsProductPackageCollectionBase() : base()
	{
		this.TABLENAME = "TaskStepVsProductPackage";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <returns>An array of <see cref="TaskStepVsProductPackageRow"/> objects.</returns>
	public virtual TaskStepVsProductPackageRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>TaskStepVsProductPackage</c> table.
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
	/// to retrieve all records from the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("TaskStepVsProductPackage_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="TaskStepVsProductPackageRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="TaskStepVsProductPackageRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public TaskStepVsProductPackageRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			TaskStepVsProductPackageRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="TaskStepVsProductPackageRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="TaskStepVsProductPackageRow"/> objects.</returns>
	public TaskStepVsProductPackageRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="TaskStepVsProductPackageRow"/> objects that 
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
	/// <returns>An array of <see cref="TaskStepVsProductPackageRow"/> objects.</returns>
	public virtual TaskStepVsProductPackageRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			TaskStepVsProductPackageRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="TaskStepVsProductPackageRow"/> by the primary key.
	/// </summary>
	/// <param name="taskStepVsProductPackage_ID">The <c>TaskStepVsProductPackage_ID</c> column value.</param>
	/// <returns>An instance of <see cref="TaskStepVsProductPackageRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual TaskStepVsProductPackageRow GetByPrimaryKey(int taskStepVsProductPackage_ID)
	{
		string LOCATION = "GetByPrimaryKey(int taskStepVsProductPackage_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "TaskStepVsProductPackage_ID", taskStepVsProductPackage_ID);
			TaskStepVsProductPackageRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <param name="value">The <see cref="TaskStepVsProductPackageRow"/> object to be inserted.</param>
	public virtual void Insert(TaskStepVsProductPackageRow value)
	{
		string LOCATION = "Insert(TaskStepVsProductPackageRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_Insert", CommandType.StoredProcedure);
					// TaskStep_ID
			if (value.IsTaskStep_IDNull)
				AddParameter(cmd, "TaskStep_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskStep_ID", value.TaskStep_ID);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// StartTime
			if (value.IsStartTimeNull)
				AddParameter(cmd, "StartTime", DBNull.Value);
			else
				AddParameter(cmd, "StartTime", value.StartTime);
			
				// EndTime
			if (value.IsEndTimeNull)
				AddParameter(cmd, "EndTime", DBNull.Value);
			else
				AddParameter(cmd, "EndTime", value.EndTime);
			
				// Note
			if (value.IsNoteNull )
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
			
				// CreateBy
			if (value.IsCreateByNull)
				AddParameter(cmd, "CreateBy", DBNull.Value);
			else
				AddParameter(cmd, "CreateBy", value.CreateBy);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditedBy
			if (value.IsLastEditedByNull)
				AddParameter(cmd, "LastEditedBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedBy", value.LastEditedBy);
			
				// LastEditedDate
			if (value.IsLastEditedDateNull)
				AddParameter(cmd, "LastEditedDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedDate", value.LastEditedDate);
			
						value.TaskStepVsProductPackage_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <param name="value">The <see cref="TaskStepVsProductPackageRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(TaskStepVsProductPackageRow value)
	{	
		string LOCATION = "Update(TaskStepVsProductPackageRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_Update", CommandType.StoredProcedure);
					// TaskStep_ID
			if (value.IsTaskStep_IDNull)
				AddParameter(cmd, "TaskStep_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskStep_ID", value.TaskStep_ID);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// StartTime
			if (value.IsStartTimeNull)
				AddParameter(cmd, "StartTime", DBNull.Value);
			else
				AddParameter(cmd, "StartTime", value.StartTime);
			
				// EndTime
			if (value.IsEndTimeNull)
				AddParameter(cmd, "EndTime", DBNull.Value);
			else
				AddParameter(cmd, "EndTime", value.EndTime);
			
				// Note
			if (value.IsNoteNull)
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
				// CreateBy
			if (value.IsCreateByNull)
				AddParameter(cmd, "CreateBy", DBNull.Value);
			else
				AddParameter(cmd, "CreateBy", value.CreateBy);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditedBy
			if (value.IsLastEditedByNull)
				AddParameter(cmd, "LastEditedBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedBy", value.LastEditedBy);
			
				// LastEditedDate
			if (value.IsLastEditedDateNull)
				AddParameter(cmd, "LastEditedDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditedDate", value.LastEditedDate);
			
					AddParameter(cmd, "TaskStepVsProductPackage_ID", value.TaskStepVsProductPackage_ID);
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
		/// Inserts or Updates a record in the <c>TaskStepVsProductPackage</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="TaskStepVsProductPackageRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(TaskStepVsProductPackageRow value)
		{
			string LOCATION = "Save(TaskStepVsProductPackageRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("TaskStepVsProductPackage_Save",CommandType.StoredProcedure);
					// TaskStep_ID
				if (value.IsTaskStep_IDNull)
					AddParameter(cmd, "TaskStep_ID", DBNull.Value);
				else
					AddParameter(cmd, "TaskStep_ID", (object)(value.TaskStep_ID));
				
					// ProductPackage_ID
				if (value.IsProductPackage_IDNull)
					AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));
				
					// StartTime
				if (value.IsStartTimeNull)
					AddParameter(cmd, "StartTime", DBNull.Value);
				else
					AddParameter(cmd, "StartTime", (object)(value.StartTime));
				
					// EndTime
				if (value.IsEndTimeNull)
					AddParameter(cmd, "EndTime", DBNull.Value);
				else
					AddParameter(cmd, "EndTime", (object)(value.EndTime));
				
					// Note
				if (value.IsNoteNull)
					AddParameter(cmd, "Note", DBNull.Value);
				else
					AddParameter(cmd, "Note", (object)(value.Note));
				
					// CreateBy
				if (value.IsCreateByNull)
					AddParameter(cmd, "CreateBy", DBNull.Value);
				else
					AddParameter(cmd, "CreateBy", (object)(value.CreateBy));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// LastEditedBy
				if (value.IsLastEditedByNull)
					AddParameter(cmd, "LastEditedBy", DBNull.Value);
				else
					AddParameter(cmd, "LastEditedBy", (object)(value.LastEditedBy));
				
					// LastEditedDate
				if (value.IsLastEditedDateNull)
					AddParameter(cmd, "LastEditedDate", DBNull.Value);
				else
					AddParameter(cmd, "LastEditedDate", (object)(value.LastEditedDate));
				
						AddParameter(cmd, "TaskStepVsProductPackage_ID", value.TaskStepVsProductPackage_ID);
						value.TaskStepVsProductPackage_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["TaskStepVsProductPackage_ID"]);
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
	/// Deletes the specified object from the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <param name="value">The <see cref="TaskStepVsProductPackageRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(TaskStepVsProductPackageRow value)
	{
		return DeleteByPrimaryKey(value.TaskStepVsProductPackage_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>TaskStepVsProductPackage</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="taskStepVsProductPackage_ID">The <c>TaskStepVsProductPackage_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int taskStepVsProductPackage_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int taskStepVsProductPackage_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "TaskStepVsProductPackage_ID", taskStepVsProductPackage_ID);
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
	/// Deletes <c>TaskStepVsProductPackage</c> records that match the specified criteria.
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
	/// to delete <c>TaskStepVsProductPackage</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("TaskStepVsProductPackage_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="TaskStepVsProductPackageRow"/> objects.</returns>
	protected TaskStepVsProductPackageRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="TaskStepVsProductPackageRow"/> objects.</returns>
	protected TaskStepVsProductPackageRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="TaskStepVsProductPackageRow"/> objects.</returns>
	protected virtual TaskStepVsProductPackageRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// TaskStepVsProductPackage_ID
		int taskStepVsProductPackage_IDColumnIndex = reader.GetOrdinal("TaskStepVsProductPackage_ID");
		// TaskStep_ID
		int taskStep_IDColumnIndex = reader.GetOrdinal("TaskStep_ID");
		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// StartTime
		int startTimeColumnIndex = reader.GetOrdinal("StartTime");
		// EndTime
		int endTimeColumnIndex = reader.GetOrdinal("EndTime");
		// Note
		int noteColumnIndex = reader.GetOrdinal("Note");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditedBy
		int lastEditedByColumnIndex = reader.GetOrdinal("LastEditedBy");
		// LastEditedDate
		int lastEditedDateColumnIndex = reader.GetOrdinal("LastEditedDate");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				TaskStepVsProductPackageRow record = new TaskStepVsProductPackageRow();
				recordList.Add(record);

					record.TaskStepVsProductPackage_ID = Convert.ToInt32(reader.GetValue(taskStepVsProductPackage_IDColumnIndex));
					if(!reader.IsDBNull(taskStep_IDColumnIndex))
						record.TaskStep_ID = Convert.ToInt32(reader.GetValue(taskStep_IDColumnIndex));
					if(!reader.IsDBNull(productPackage_IDColumnIndex))
						record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(startTimeColumnIndex))
						record.StartTime = Convert.ToDateTime(reader.GetValue(startTimeColumnIndex));
					if(!reader.IsDBNull(endTimeColumnIndex))
						record.EndTime = Convert.ToDateTime(reader.GetValue(endTimeColumnIndex));
					if(!reader.IsDBNull(noteColumnIndex))
						record.Note = Convert.ToString(reader.GetValue(noteColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditedByColumnIndex))
						record.LastEditedBy = reader.GetGuid(lastEditedByColumnIndex);
					if(!reader.IsDBNull(lastEditedDateColumnIndex))
						record.LastEditedDate = Convert.ToDateTime(reader.GetValue(lastEditedDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (TaskStepVsProductPackageRow[])(recordList.ToArray(typeof(TaskStepVsProductPackageRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="TaskStepVsProductPackageRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="TaskStepVsProductPackageRow"/> object.</returns>
	protected virtual TaskStepVsProductPackageRow MapRow(DataRow row)
	{
		string LOCATION = "TaskStepVsProductPackageRow MapRow(DataRow row)";
		TaskStepVsProductPackageRow mappedObject = new TaskStepVsProductPackageRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "TaskStepVsProductPackage_ID"
		dataColumn = dataTable.Columns["TaskStepVsProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaskStepVsProductPackage_ID = (int)(row[dataColumn]);
		// Column "TaskStep_ID"
		dataColumn = dataTable.Columns["TaskStep_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaskStep_ID = (int)(row[dataColumn]);
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
		// Column "StartTime"
		dataColumn = dataTable.Columns["StartTime"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StartTime = (System.DateTime)(row[dataColumn]);
		// Column "EndTime"
		dataColumn = dataTable.Columns["EndTime"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EndTime = (System.DateTime)(row[dataColumn]);
		// Column "Note"
		dataColumn = dataTable.Columns["Note"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Note = (string)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditedBy"
		dataColumn = dataTable.Columns["LastEditedBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditedBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditedDate"
		dataColumn = dataTable.Columns["LastEditedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditedDate = (System.DateTime)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>TaskStepVsProductPackage</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "TaskStepVsProductPackage";
		DataColumn dataColumn;
		// Create the "TaskStepVsProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("TaskStepVsProductPackage_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "TaskStep_ID" column
		dataColumn = dataTable.Columns.Add("TaskStep_ID", typeof(int));
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
		// Create the "StartTime" column
		dataColumn = dataTable.Columns.Add("StartTime", typeof(System.DateTime));
		// Create the "EndTime" column
		dataColumn = dataTable.Columns.Add("EndTime", typeof(System.DateTime));
		// Create the "Note" column
		dataColumn = dataTable.Columns.Add("Note", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditedBy" column
		dataColumn = dataTable.Columns.Add("LastEditedBy", typeof(System.Guid));
		// Create the "LastEditedDate" column
		dataColumn = dataTable.Columns.Add("LastEditedDate", typeof(System.DateTime));
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
			case "TaskStepVsProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "TaskStep_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "StartTime":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "EndTime":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Note":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditedBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="TaskStepVsProductPackageRow"/> by the primary key.
	/// </summary>
	/// <param name="taskStepVsProductPackage_ID">The <c>TaskStepVsProductPackage_ID</c> column value.</param>
	/// <returns>An instance of <see cref="TaskStepVsProductPackageRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int taskStepVsProductPackage_ID)
	{
		string LOCATION = "Exist(int taskStepVsProductPackage_ID)";
		IDbCommand cmd = _db.CreateCommand("TaskStepVsProductPackage_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "TaskStepVsProductPackage_ID", taskStepVsProductPackage_ID);
		TaskStepVsProductPackageRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




