
// <fileinfo name="Base\WH_CheckSheetCollectionBase.cs">
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
/// The base class for <see cref="WH_CheckSheetCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_CheckSheetCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_CheckSheetCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string WH_CheckSheet_IDColumnName  = "WH_CheckSheet_ID";
	public const string CodeColumnName  = "Code";
	public const string TypeColumnName  = "Type";
	public const string LevelColumnName  = "Level";
	public const string WH_StandardCheck_IDColumnName  = "WH_StandardCheck_ID";
	public const string WH_DeliveryNoteColumnName  = "WH_DeliveryNote";
	public const string DateCheckColumnName  = "DateCheck";
	public const string LocationColumnName  = "Location";
	public const string StatusColumnName  = "Status";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WH_CheckSheetCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WH_CheckSheet";
	}

	public WH_CheckSheetCollectionBase() : base()
	{
		this.TABLENAME = "WH_CheckSheet";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WH_CheckSheetRow"/> objects.</returns>
	public virtual WH_CheckSheetRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WH_CheckSheet</c> table.
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
	/// to retrieve all records from the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WH_CheckSheet_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WH_CheckSheetRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WH_CheckSheetRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WH_CheckSheetRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WH_CheckSheetRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WH_CheckSheetRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WH_CheckSheetRow"/> objects.</returns>
	public WH_CheckSheetRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WH_CheckSheetRow"/> objects that 
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
	/// <returns>An array of <see cref="WH_CheckSheetRow"/> objects.</returns>
	public virtual WH_CheckSheetRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WH_CheckSheetRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WH_CheckSheetRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_CheckSheet_ID">The <c>WH_CheckSheet_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_CheckSheetRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WH_CheckSheetRow GetByPrimaryKey(int wH_CheckSheet_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_CheckSheet_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "WH_CheckSheet_ID", wH_CheckSheet_ID);
			WH_CheckSheetRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheetRow"/> object to be inserted.</param>
	public virtual void Insert(WH_CheckSheetRow value)
	{
		string LOCATION = "Insert(WH_CheckSheetRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Insert", CommandType.StoredProcedure);
					// Code
			if (value.IsCodeNull )
				AddParameter(cmd, "Code", DBNull.Value);
			else
				AddParameter(cmd, "Code", value.Code);
			
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
				// Level
			if (value.IsLevelNull)
				AddParameter(cmd, "Level", DBNull.Value);
			else
				AddParameter(cmd, "Level", value.Level);
			
				// WH_StandardCheck_ID
			if (value.IsWH_StandardCheck_IDNull)
				AddParameter(cmd, "WH_StandardCheck_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_StandardCheck_ID", value.WH_StandardCheck_ID);
			
				// WH_DeliveryNote
			if (value.IsWH_DeliveryNoteNull)
				AddParameter(cmd, "WH_DeliveryNote", DBNull.Value);
			else
				AddParameter(cmd, "WH_DeliveryNote", value.WH_DeliveryNote);
			
				// DateCheck
			if (value.IsDateCheckNull)
				AddParameter(cmd, "DateCheck", DBNull.Value);
			else
				AddParameter(cmd, "DateCheck", value.DateCheck);
			
				// Location
			if (value.IsLocationNull )
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
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
			
						value.WH_CheckSheet_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheetRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WH_CheckSheetRow value)
	{	
		string LOCATION = "Update(WH_CheckSheetRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Update", CommandType.StoredProcedure);
					// Code
			if (value.IsCodeNull)
				AddParameter(cmd, "Code", DBNull.Value);
			else
				AddParameter(cmd, "Code", value.Code);
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
				// Level
			if (value.IsLevelNull)
				AddParameter(cmd, "Level", DBNull.Value);
			else
				AddParameter(cmd, "Level", value.Level);
			
				// WH_StandardCheck_ID
			if (value.IsWH_StandardCheck_IDNull)
				AddParameter(cmd, "WH_StandardCheck_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_StandardCheck_ID", value.WH_StandardCheck_ID);
			
				// WH_DeliveryNote
			if (value.IsWH_DeliveryNoteNull)
				AddParameter(cmd, "WH_DeliveryNote", DBNull.Value);
			else
				AddParameter(cmd, "WH_DeliveryNote", value.WH_DeliveryNote);
			
				// DateCheck
			if (value.IsDateCheckNull)
				AddParameter(cmd, "DateCheck", DBNull.Value);
			else
				AddParameter(cmd, "DateCheck", value.DateCheck);
			
				// Location
			if (value.IsLocationNull)
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
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
			
					AddParameter(cmd, "WH_CheckSheet_ID", value.WH_CheckSheet_ID);
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
		/// Inserts or Updates a record in the <c>WH_CheckSheet</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WH_CheckSheetRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WH_CheckSheetRow value)
		{
			string LOCATION = "Save(WH_CheckSheetRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WH_CheckSheet_Save",CommandType.StoredProcedure);
					// Code
				if (value.IsCodeNull)
					AddParameter(cmd, "Code", DBNull.Value);
				else
					AddParameter(cmd, "Code", (object)(value.Code));
				
					// Type
				if (value.IsTypeNull)
					AddParameter(cmd, "Type", DBNull.Value);
				else
					AddParameter(cmd, "Type", (object)(value.Type));
				
					// Level
				if (value.IsLevelNull)
					AddParameter(cmd, "Level", DBNull.Value);
				else
					AddParameter(cmd, "Level", (object)(value.Level));
				
					// WH_StandardCheck_ID
				if (value.IsWH_StandardCheck_IDNull)
					AddParameter(cmd, "WH_StandardCheck_ID", DBNull.Value);
				else
					AddParameter(cmd, "WH_StandardCheck_ID", (object)(value.WH_StandardCheck_ID));
				
					// WH_DeliveryNote
				if (value.IsWH_DeliveryNoteNull)
					AddParameter(cmd, "WH_DeliveryNote", DBNull.Value);
				else
					AddParameter(cmd, "WH_DeliveryNote", (object)(value.WH_DeliveryNote));
				
					// DateCheck
				if (value.IsDateCheckNull)
					AddParameter(cmd, "DateCheck", DBNull.Value);
				else
					AddParameter(cmd, "DateCheck", (object)(value.DateCheck));
				
					// Location
				if (value.IsLocationNull)
					AddParameter(cmd, "Location", DBNull.Value);
				else
					AddParameter(cmd, "Location", (object)(value.Location));
				
					// Status
				if (value.IsStatusNull)
					AddParameter(cmd, "Status", DBNull.Value);
				else
					AddParameter(cmd, "Status", (object)(value.Status));
				
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
				
						AddParameter(cmd, "WH_CheckSheet_ID", value.WH_CheckSheet_ID);
						value.WH_CheckSheet_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["WH_CheckSheet_ID"]);
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
	/// Deletes the specified object from the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheetRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WH_CheckSheetRow value)
	{
		return DeleteByPrimaryKey(value.WH_CheckSheet_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WH_CheckSheet</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="wH_CheckSheet_ID">The <c>WH_CheckSheet_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int wH_CheckSheet_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_CheckSheet_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "WH_CheckSheet_ID", wH_CheckSheet_ID);
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
	/// Deletes <c>WH_CheckSheet</c> records that match the specified criteria.
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
	/// to delete <c>WH_CheckSheet</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WH_CheckSheet_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WH_CheckSheetRow"/> objects.</returns>
	protected WH_CheckSheetRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WH_CheckSheetRow"/> objects.</returns>
	protected WH_CheckSheetRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WH_CheckSheetRow"/> objects.</returns>
	protected virtual WH_CheckSheetRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// WH_CheckSheet_ID
		int wH_CheckSheet_IDColumnIndex = reader.GetOrdinal("WH_CheckSheet_ID");
		// Code
		int codeColumnIndex = reader.GetOrdinal("Code");
		// Type
		int typeColumnIndex = reader.GetOrdinal("Type");
		// Level
		int levelColumnIndex = reader.GetOrdinal("Level");
		// WH_StandardCheck_ID
		int wH_StandardCheck_IDColumnIndex = reader.GetOrdinal("WH_StandardCheck_ID");
		// WH_DeliveryNote
		int wH_DeliveryNoteColumnIndex = reader.GetOrdinal("WH_DeliveryNote");
		// DateCheck
		int dateCheckColumnIndex = reader.GetOrdinal("DateCheck");
		// Location
		int locationColumnIndex = reader.GetOrdinal("Location");
		// Status
		int statusColumnIndex = reader.GetOrdinal("Status");
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
				WH_CheckSheetRow record = new WH_CheckSheetRow();
				recordList.Add(record);

					record.WH_CheckSheet_ID = Convert.ToInt32(reader.GetValue(wH_CheckSheet_IDColumnIndex));
					if(!reader.IsDBNull(codeColumnIndex))
						record.Code = Convert.ToString(reader.GetValue(codeColumnIndex));
					if(!reader.IsDBNull(typeColumnIndex))
						record.Type = Convert.ToInt32(reader.GetValue(typeColumnIndex));
					if(!reader.IsDBNull(levelColumnIndex))
						record.Level = Convert.ToInt32(reader.GetValue(levelColumnIndex));
					if(!reader.IsDBNull(wH_StandardCheck_IDColumnIndex))
						record.WH_StandardCheck_ID = Convert.ToInt32(reader.GetValue(wH_StandardCheck_IDColumnIndex));
					if(!reader.IsDBNull(wH_DeliveryNoteColumnIndex))
						record.WH_DeliveryNote = Convert.ToInt32(reader.GetValue(wH_DeliveryNoteColumnIndex));
					if(!reader.IsDBNull(dateCheckColumnIndex))
						record.DateCheck = Convert.ToDateTime(reader.GetValue(dateCheckColumnIndex));
					if(!reader.IsDBNull(locationColumnIndex))
						record.Location = Convert.ToString(reader.GetValue(locationColumnIndex));
					if(!reader.IsDBNull(statusColumnIndex))
						record.Status = Convert.ToInt32(reader.GetValue(statusColumnIndex));
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

		return (WH_CheckSheetRow[])(recordList.ToArray(typeof(WH_CheckSheetRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WH_CheckSheetRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WH_CheckSheetRow"/> object.</returns>
	protected virtual WH_CheckSheetRow MapRow(DataRow row)
	{
		string LOCATION = "WH_CheckSheetRow MapRow(DataRow row)";
		WH_CheckSheetRow mappedObject = new WH_CheckSheetRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "WH_CheckSheet_ID"
		dataColumn = dataTable.Columns["WH_CheckSheet_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_CheckSheet_ID = (int)(row[dataColumn]);
		// Column "Code"
		dataColumn = dataTable.Columns["Code"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Code = (string)(row[dataColumn]);
		// Column "Type"
		dataColumn = dataTable.Columns["Type"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Type = (int)(row[dataColumn]);
		// Column "Level"
		dataColumn = dataTable.Columns["Level"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Level = (int)(row[dataColumn]);
		// Column "WH_StandardCheck_ID"
		dataColumn = dataTable.Columns["WH_StandardCheck_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_StandardCheck_ID = (int)(row[dataColumn]);
		// Column "WH_DeliveryNote"
		dataColumn = dataTable.Columns["WH_DeliveryNote"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_DeliveryNote = (int)(row[dataColumn]);
		// Column "DateCheck"
		dataColumn = dataTable.Columns["DateCheck"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DateCheck = (System.DateTime)(row[dataColumn]);
		// Column "Location"
		dataColumn = dataTable.Columns["Location"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location = (string)(row[dataColumn]);
		// Column "Status"
		dataColumn = dataTable.Columns["Status"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Status = (int)(row[dataColumn]);
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
	/// the <c>WH_CheckSheet</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WH_CheckSheet";
		DataColumn dataColumn;
		// Create the "WH_CheckSheet_ID" column
		dataColumn = dataTable.Columns.Add("WH_CheckSheet_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Code" column
		dataColumn = dataTable.Columns.Add("Code", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Type" column
		dataColumn = dataTable.Columns.Add("Type", typeof(int));
		// Create the "Level" column
		dataColumn = dataTable.Columns.Add("Level", typeof(int));
		// Create the "WH_StandardCheck_ID" column
		dataColumn = dataTable.Columns.Add("WH_StandardCheck_ID", typeof(int));
		// Create the "WH_DeliveryNote" column
		dataColumn = dataTable.Columns.Add("WH_DeliveryNote", typeof(int));
		// Create the "DateCheck" column
		dataColumn = dataTable.Columns.Add("DateCheck", typeof(System.DateTime));
		// Create the "Location" column
		dataColumn = dataTable.Columns.Add("Location", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Status" column
		dataColumn = dataTable.Columns.Add("Status", typeof(int));
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
			case "WH_CheckSheet_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Code":
				parameter = _db.AddParameter(cmd, paramName, DbType.StringFixedLength, value);
				break;

			case "Type":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Level":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WH_StandardCheck_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WH_DeliveryNote":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DateCheck":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Location":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Status":
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
	/// Exist <see cref="WH_CheckSheetRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_CheckSheet_ID">The <c>WH_CheckSheet_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_CheckSheetRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int wH_CheckSheet_ID)
	{
		string LOCATION = "Exist(int wH_CheckSheet_ID)";
		IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "WH_CheckSheet_ID", wH_CheckSheet_ID);
		WH_CheckSheetRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




