
// <fileinfo name="Base\SamplingPlanCollectionBase.cs">
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
/// The base class for <see cref="SamplingPlanCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SamplingPlanCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SamplingPlanCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string SamplingPlan_IDColumnName  = "SamplingPlan_ID";
	public const string LevelColumnName  = "Level";
	public const string AmountFromColumnName  = "AmountFrom";
	public const string AmountToColumnName  = "AmountTo";
	public const string AmountSamplingGetColumnName  = "AmountSamplingGet";
	public const string AmountSamplingErrorColumnName  = "AmountSamplingError";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public SamplingPlanCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "SamplingPlan";
	}

	public SamplingPlanCollectionBase() : base()
	{
		this.TABLENAME = "SamplingPlan";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>SamplingPlan</c> table.
	/// </summary>
	/// <returns>An array of <see cref="SamplingPlanRow"/> objects.</returns>
	public virtual SamplingPlanRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>SamplingPlan</c> table.
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
	/// to retrieve all records from the <c>SamplingPlan</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("SamplingPlan_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="SamplingPlanRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="SamplingPlanRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public SamplingPlanRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			SamplingPlanRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="SamplingPlanRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="SamplingPlanRow"/> objects.</returns>
	public SamplingPlanRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="SamplingPlanRow"/> objects that 
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
	/// <returns>An array of <see cref="SamplingPlanRow"/> objects.</returns>
	public virtual SamplingPlanRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			SamplingPlanRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("SamplingPlan_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("SamplingPlan_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="SamplingPlanRow"/> by the primary key.
	/// </summary>
	/// <param name="samplingPlan_ID">The <c>SamplingPlan_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SamplingPlanRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual SamplingPlanRow GetByPrimaryKey(int samplingPlan_ID)
	{
		string LOCATION = "GetByPrimaryKey(int samplingPlan_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("SamplingPlan_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "SamplingPlan_ID", samplingPlan_ID);
			SamplingPlanRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>SamplingPlan</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SamplingPlanRow"/> object to be inserted.</param>
	public virtual void Insert(SamplingPlanRow value)
	{
		string LOCATION = "Insert(SamplingPlanRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SamplingPlan_Insert", CommandType.StoredProcedure);
					// Level
			if (value.IsLevelNull)
				AddParameter(cmd, "Level", DBNull.Value);
			else
				AddParameter(cmd, "Level", value.Level);
			
				// AmountFrom
			if (value.IsAmountFromNull)
				AddParameter(cmd, "AmountFrom", DBNull.Value);
			else
				AddParameter(cmd, "AmountFrom", value.AmountFrom);
			
				// AmountTo
			if (value.IsAmountToNull)
				AddParameter(cmd, "AmountTo", DBNull.Value);
			else
				AddParameter(cmd, "AmountTo", value.AmountTo);
			
				// AmountSamplingGet
			if (value.IsAmountSamplingGetNull)
				AddParameter(cmd, "AmountSamplingGet", DBNull.Value);
			else
				AddParameter(cmd, "AmountSamplingGet", value.AmountSamplingGet);
			
				// AmountSamplingError
			if (value.IsAmountSamplingErrorNull)
				AddParameter(cmd, "AmountSamplingError", DBNull.Value);
			else
				AddParameter(cmd, "AmountSamplingError", value.AmountSamplingError);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// CreateBy
			if (value.IsCreateByNull)
				AddParameter(cmd, "CreateBy", DBNull.Value);
			else
				AddParameter(cmd, "CreateBy", value.CreateBy);
			
				// LastEditBy
			if (value.IsLastEditByNull)
				AddParameter(cmd, "LastEditBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditBy", value.LastEditBy);
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
						value.SamplingPlan_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>SamplingPlan</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SamplingPlanRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(SamplingPlanRow value)
	{	
		string LOCATION = "Update(SamplingPlanRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SamplingPlan_Update", CommandType.StoredProcedure);
					// Level
			if (value.IsLevelNull)
				AddParameter(cmd, "Level", DBNull.Value);
			else
				AddParameter(cmd, "Level", value.Level);
			
				// AmountFrom
			if (value.IsAmountFromNull)
				AddParameter(cmd, "AmountFrom", DBNull.Value);
			else
				AddParameter(cmd, "AmountFrom", value.AmountFrom);
			
				// AmountTo
			if (value.IsAmountToNull)
				AddParameter(cmd, "AmountTo", DBNull.Value);
			else
				AddParameter(cmd, "AmountTo", value.AmountTo);
			
				// AmountSamplingGet
			if (value.IsAmountSamplingGetNull)
				AddParameter(cmd, "AmountSamplingGet", DBNull.Value);
			else
				AddParameter(cmd, "AmountSamplingGet", value.AmountSamplingGet);
			
				// AmountSamplingError
			if (value.IsAmountSamplingErrorNull)
				AddParameter(cmd, "AmountSamplingError", DBNull.Value);
			else
				AddParameter(cmd, "AmountSamplingError", value.AmountSamplingError);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// CreateBy
			if (value.IsCreateByNull)
				AddParameter(cmd, "CreateBy", DBNull.Value);
			else
				AddParameter(cmd, "CreateBy", value.CreateBy);
			
				// LastEditBy
			if (value.IsLastEditByNull)
				AddParameter(cmd, "LastEditBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditBy", value.LastEditBy);
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
					AddParameter(cmd, "SamplingPlan_ID", value.SamplingPlan_ID);
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
		/// Inserts or Updates a record in the <c>SamplingPlan</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="SamplingPlanRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(SamplingPlanRow value)
		{
			string LOCATION = "Save(SamplingPlanRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("SamplingPlan_Save",CommandType.StoredProcedure);
					// Level
				if (value.IsLevelNull)
					AddParameter(cmd, "Level", DBNull.Value);
				else
					AddParameter(cmd, "Level", (object)(value.Level));
				
					// AmountFrom
				if (value.IsAmountFromNull)
					AddParameter(cmd, "AmountFrom", DBNull.Value);
				else
					AddParameter(cmd, "AmountFrom", (object)(value.AmountFrom));
				
					// AmountTo
				if (value.IsAmountToNull)
					AddParameter(cmd, "AmountTo", DBNull.Value);
				else
					AddParameter(cmd, "AmountTo", (object)(value.AmountTo));
				
					// AmountSamplingGet
				if (value.IsAmountSamplingGetNull)
					AddParameter(cmd, "AmountSamplingGet", DBNull.Value);
				else
					AddParameter(cmd, "AmountSamplingGet", (object)(value.AmountSamplingGet));
				
					// AmountSamplingError
				if (value.IsAmountSamplingErrorNull)
					AddParameter(cmd, "AmountSamplingError", DBNull.Value);
				else
					AddParameter(cmd, "AmountSamplingError", (object)(value.AmountSamplingError));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// CreateBy
				if (value.IsCreateByNull)
					AddParameter(cmd, "CreateBy", DBNull.Value);
				else
					AddParameter(cmd, "CreateBy", (object)(value.CreateBy));
				
					// LastEditBy
				if (value.IsLastEditByNull)
					AddParameter(cmd, "LastEditBy", DBNull.Value);
				else
					AddParameter(cmd, "LastEditBy", (object)(value.LastEditBy));
				
					// LastEditDate
				if (value.IsLastEditDateNull)
					AddParameter(cmd, "LastEditDate", DBNull.Value);
				else
					AddParameter(cmd, "LastEditDate", (object)(value.LastEditDate));
				
						AddParameter(cmd, "SamplingPlan_ID", value.SamplingPlan_ID);
						value.SamplingPlan_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["SamplingPlan_ID"]);
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
	/// Deletes the specified object from the <c>SamplingPlan</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SamplingPlanRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(SamplingPlanRow value)
	{
		return DeleteByPrimaryKey(value.SamplingPlan_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>SamplingPlan</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="samplingPlan_ID">The <c>SamplingPlan_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int samplingPlan_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int samplingPlan_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SamplingPlan_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "SamplingPlan_ID", samplingPlan_ID);
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
	/// Deletes <c>SamplingPlan</c> records that match the specified criteria.
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
	/// to delete <c>SamplingPlan</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("SamplingPlan_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>SamplingPlan</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("SamplingPlan_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="SamplingPlanRow"/> objects.</returns>
	protected SamplingPlanRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="SamplingPlanRow"/> objects.</returns>
	protected SamplingPlanRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="SamplingPlanRow"/> objects.</returns>
	protected virtual SamplingPlanRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// SamplingPlan_ID
		int samplingPlan_IDColumnIndex = reader.GetOrdinal("SamplingPlan_ID");
		// Level
		int levelColumnIndex = reader.GetOrdinal("Level");
		// AmountFrom
		int amountFromColumnIndex = reader.GetOrdinal("AmountFrom");
		// AmountTo
		int amountToColumnIndex = reader.GetOrdinal("AmountTo");
		// AmountSamplingGet
		int amountSamplingGetColumnIndex = reader.GetOrdinal("AmountSamplingGet");
		// AmountSamplingError
		int amountSamplingErrorColumnIndex = reader.GetOrdinal("AmountSamplingError");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				SamplingPlanRow record = new SamplingPlanRow();
				recordList.Add(record);

					record.SamplingPlan_ID = Convert.ToInt32(reader.GetValue(samplingPlan_IDColumnIndex));
					if(!reader.IsDBNull(levelColumnIndex))
						record.Level = Convert.ToInt32(reader.GetValue(levelColumnIndex));
					if(!reader.IsDBNull(amountFromColumnIndex))
						record.AmountFrom = Convert.ToInt32(reader.GetValue(amountFromColumnIndex));
					if(!reader.IsDBNull(amountToColumnIndex))
						record.AmountTo = Convert.ToInt32(reader.GetValue(amountToColumnIndex));
					if(!reader.IsDBNull(amountSamplingGetColumnIndex))
						record.AmountSamplingGet = Convert.ToInt32(reader.GetValue(amountSamplingGetColumnIndex));
					if(!reader.IsDBNull(amountSamplingErrorColumnIndex))
						record.AmountSamplingError = Convert.ToInt32(reader.GetValue(amountSamplingErrorColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (SamplingPlanRow[])(recordList.ToArray(typeof(SamplingPlanRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="SamplingPlanRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="SamplingPlanRow"/> object.</returns>
	protected virtual SamplingPlanRow MapRow(DataRow row)
	{
		string LOCATION = "SamplingPlanRow MapRow(DataRow row)";
		SamplingPlanRow mappedObject = new SamplingPlanRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "SamplingPlan_ID"
		dataColumn = dataTable.Columns["SamplingPlan_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SamplingPlan_ID = (int)(row[dataColumn]);
		// Column "Level"
		dataColumn = dataTable.Columns["Level"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Level = (int)(row[dataColumn]);
		// Column "AmountFrom"
		dataColumn = dataTable.Columns["AmountFrom"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AmountFrom = (int)(row[dataColumn]);
		// Column "AmountTo"
		dataColumn = dataTable.Columns["AmountTo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AmountTo = (int)(row[dataColumn]);
		// Column "AmountSamplingGet"
		dataColumn = dataTable.Columns["AmountSamplingGet"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AmountSamplingGet = (int)(row[dataColumn]);
		// Column "AmountSamplingError"
		dataColumn = dataTable.Columns["AmountSamplingError"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AmountSamplingError = (int)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditBy"
		dataColumn = dataTable.Columns["LastEditBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditDate"
		dataColumn = dataTable.Columns["LastEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>SamplingPlan</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "SamplingPlan";
		DataColumn dataColumn;
		// Create the "SamplingPlan_ID" column
		dataColumn = dataTable.Columns.Add("SamplingPlan_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Level" column
		dataColumn = dataTable.Columns.Add("Level", typeof(int));
		// Create the "AmountFrom" column
		dataColumn = dataTable.Columns.Add("AmountFrom", typeof(int));
		// Create the "AmountTo" column
		dataColumn = dataTable.Columns.Add("AmountTo", typeof(int));
		// Create the "AmountSamplingGet" column
		dataColumn = dataTable.Columns.Add("AmountSamplingGet", typeof(int));
		// Create the "AmountSamplingError" column
		dataColumn = dataTable.Columns.Add("AmountSamplingError", typeof(int));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
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
			case "SamplingPlan_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Level":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AmountFrom":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AmountTo":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AmountSamplingGet":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AmountSamplingError":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="SamplingPlanRow"/> by the primary key.
	/// </summary>
	/// <param name="samplingPlan_ID">The <c>SamplingPlan_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SamplingPlanRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int samplingPlan_ID)
	{
		string LOCATION = "Exist(int samplingPlan_ID)";
		IDbCommand cmd = _db.CreateCommand("SamplingPlan_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "SamplingPlan_ID", samplingPlan_ID);
		SamplingPlanRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




