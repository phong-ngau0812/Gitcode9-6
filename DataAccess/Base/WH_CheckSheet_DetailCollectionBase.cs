
// <fileinfo name="Base\WH_CheckSheet_DetailCollectionBase.cs">
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
/// The base class for <see cref="WH_CheckSheet_DetailCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_CheckSheet_DetailCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_CheckSheet_DetailCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string WH_CheckSheet_Detail_IDColumnName  = "WH_CheckSheet_Detail_ID";
	public const string WH_CheckSheetVsMaterial_IDColumnName  = "WH_CheckSheetVsMaterial_ID";
	public const string LengthColumnName  = "Length";
	public const string HeightColumnName  = "Height";
	public const string WidthColumnName  = "Width";
	public const string StatusColumnName  = "Status";
	public const string DescriptionColumnName  = "Description";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string ContentColumnName  = "Content";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WH_CheckSheet_DetailCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WH_CheckSheet_Detail";
	}

	public WH_CheckSheet_DetailCollectionBase() : base()
	{
		this.TABLENAME = "WH_CheckSheet_Detail";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WH_CheckSheet_DetailRow"/> objects.</returns>
	public virtual WH_CheckSheet_DetailRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WH_CheckSheet_Detail</c> table.
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
	/// to retrieve all records from the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WH_CheckSheet_Detail_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WH_CheckSheet_DetailRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WH_CheckSheet_DetailRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WH_CheckSheet_DetailRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WH_CheckSheet_DetailRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WH_CheckSheet_DetailRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WH_CheckSheet_DetailRow"/> objects.</returns>
	public WH_CheckSheet_DetailRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WH_CheckSheet_DetailRow"/> objects that 
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
	/// <returns>An array of <see cref="WH_CheckSheet_DetailRow"/> objects.</returns>
	public virtual WH_CheckSheet_DetailRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WH_CheckSheet_DetailRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WH_CheckSheet_DetailRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_CheckSheet_Detail_ID">The <c>WH_CheckSheet_Detail_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_CheckSheet_DetailRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WH_CheckSheet_DetailRow GetByPrimaryKey(int wH_CheckSheet_Detail_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_CheckSheet_Detail_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "WH_CheckSheet_Detail_ID", wH_CheckSheet_Detail_ID);
			WH_CheckSheet_DetailRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheet_DetailRow"/> object to be inserted.</param>
	public virtual void Insert(WH_CheckSheet_DetailRow value)
	{
		string LOCATION = "Insert(WH_CheckSheet_DetailRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_Insert", CommandType.StoredProcedure);
					// WH_CheckSheetVsMaterial_ID
			if (value.IsWH_CheckSheetVsMaterial_IDNull)
				AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", value.WH_CheckSheetVsMaterial_ID);
			
				// Length
			if (value.IsLengthNull)
				AddParameter(cmd, "Length", DBNull.Value);
			else
				AddParameter(cmd, "Length", value.Length);
			
				// Height
			if (value.IsHeightNull)
				AddParameter(cmd, "Height", DBNull.Value);
			else
				AddParameter(cmd, "Height", value.Height);
			
				// Width
			if (value.IsWidthNull)
				AddParameter(cmd, "Width", DBNull.Value);
			else
				AddParameter(cmd, "Width", value.Width);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
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
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
				// LastEditBy
			if (value.IsLastEditByNull)
				AddParameter(cmd, "LastEditBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditBy", value.LastEditBy);
			
				// Content
			if (value.IsContentNull )
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
			
						value.WH_CheckSheet_Detail_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheet_DetailRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WH_CheckSheet_DetailRow value)
	{	
		string LOCATION = "Update(WH_CheckSheet_DetailRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_Update", CommandType.StoredProcedure);
					// WH_CheckSheetVsMaterial_ID
			if (value.IsWH_CheckSheetVsMaterial_IDNull)
				AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", value.WH_CheckSheetVsMaterial_ID);
			
				// Length
			if (value.IsLengthNull)
				AddParameter(cmd, "Length", DBNull.Value);
			else
				AddParameter(cmd, "Length", value.Length);
			
				// Height
			if (value.IsHeightNull)
				AddParameter(cmd, "Height", DBNull.Value);
			else
				AddParameter(cmd, "Height", value.Height);
			
				// Width
			if (value.IsWidthNull)
				AddParameter(cmd, "Width", DBNull.Value);
			else
				AddParameter(cmd, "Width", value.Width);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
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
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
				// LastEditBy
			if (value.IsLastEditByNull)
				AddParameter(cmd, "LastEditBy", DBNull.Value);
			else
				AddParameter(cmd, "LastEditBy", value.LastEditBy);
			
				// Content
			if (value.IsContentNull)
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
					AddParameter(cmd, "WH_CheckSheet_Detail_ID", value.WH_CheckSheet_Detail_ID);
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
		/// Inserts or Updates a record in the <c>WH_CheckSheet_Detail</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WH_CheckSheet_DetailRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WH_CheckSheet_DetailRow value)
		{
			string LOCATION = "Save(WH_CheckSheet_DetailRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WH_CheckSheet_Detail_Save",CommandType.StoredProcedure);
					// WH_CheckSheetVsMaterial_ID
				if (value.IsWH_CheckSheetVsMaterial_IDNull)
					AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", DBNull.Value);
				else
					AddParameter(cmd, "WH_CheckSheetVsMaterial_ID", (object)(value.WH_CheckSheetVsMaterial_ID));
				
					// Length
				if (value.IsLengthNull)
					AddParameter(cmd, "Length", DBNull.Value);
				else
					AddParameter(cmd, "Length", (object)(value.Length));
				
					// Height
				if (value.IsHeightNull)
					AddParameter(cmd, "Height", DBNull.Value);
				else
					AddParameter(cmd, "Height", (object)(value.Height));
				
					// Width
				if (value.IsWidthNull)
					AddParameter(cmd, "Width", DBNull.Value);
				else
					AddParameter(cmd, "Width", (object)(value.Width));
				
					// Status
				if (value.IsStatusNull)
					AddParameter(cmd, "Status", DBNull.Value);
				else
					AddParameter(cmd, "Status", (object)(value.Status));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
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
				
					// LastEditDate
				if (value.IsLastEditDateNull)
					AddParameter(cmd, "LastEditDate", DBNull.Value);
				else
					AddParameter(cmd, "LastEditDate", (object)(value.LastEditDate));
				
					// LastEditBy
				if (value.IsLastEditByNull)
					AddParameter(cmd, "LastEditBy", DBNull.Value);
				else
					AddParameter(cmd, "LastEditBy", (object)(value.LastEditBy));
				
					// Content
				if (value.IsContentNull)
					AddParameter(cmd, "Content", DBNull.Value);
				else
					AddParameter(cmd, "Content", (object)(value.Content));
				
						AddParameter(cmd, "WH_CheckSheet_Detail_ID", value.WH_CheckSheet_Detail_ID);
						value.WH_CheckSheet_Detail_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["WH_CheckSheet_Detail_ID"]);
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
	/// Deletes the specified object from the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_CheckSheet_DetailRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WH_CheckSheet_DetailRow value)
	{
		return DeleteByPrimaryKey(value.WH_CheckSheet_Detail_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WH_CheckSheet_Detail</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="wH_CheckSheet_Detail_ID">The <c>WH_CheckSheet_Detail_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int wH_CheckSheet_Detail_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_CheckSheet_Detail_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "WH_CheckSheet_Detail_ID", wH_CheckSheet_Detail_ID);
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
	/// Deletes <c>WH_CheckSheet_Detail</c> records that match the specified criteria.
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
	/// to delete <c>WH_CheckSheet_Detail</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WH_CheckSheet_Detail_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WH_CheckSheet_DetailRow"/> objects.</returns>
	protected WH_CheckSheet_DetailRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WH_CheckSheet_DetailRow"/> objects.</returns>
	protected WH_CheckSheet_DetailRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WH_CheckSheet_DetailRow"/> objects.</returns>
	protected virtual WH_CheckSheet_DetailRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// WH_CheckSheet_Detail_ID
		int wH_CheckSheet_Detail_IDColumnIndex = reader.GetOrdinal("WH_CheckSheet_Detail_ID");
		// WH_CheckSheetVsMaterial_ID
		int wH_CheckSheetVsMaterial_IDColumnIndex = reader.GetOrdinal("WH_CheckSheetVsMaterial_ID");
		// Length
		int lengthColumnIndex = reader.GetOrdinal("Length");
		// Height
		int heightColumnIndex = reader.GetOrdinal("Height");
		// Width
		int widthColumnIndex = reader.GetOrdinal("Width");
		// Status
		int statusColumnIndex = reader.GetOrdinal("Status");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// Content
		int contentColumnIndex = reader.GetOrdinal("Content");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WH_CheckSheet_DetailRow record = new WH_CheckSheet_DetailRow();
				recordList.Add(record);

					record.WH_CheckSheet_Detail_ID = Convert.ToInt32(reader.GetValue(wH_CheckSheet_Detail_IDColumnIndex));
					if(!reader.IsDBNull(wH_CheckSheetVsMaterial_IDColumnIndex))
						record.WH_CheckSheetVsMaterial_ID = Convert.ToInt32(reader.GetValue(wH_CheckSheetVsMaterial_IDColumnIndex));
					if(!reader.IsDBNull(lengthColumnIndex))
						record.Length = Convert.ToDouble(reader.GetValue(lengthColumnIndex));
					if(!reader.IsDBNull(heightColumnIndex))
						record.Height = Convert.ToDouble(reader.GetValue(heightColumnIndex));
					if(!reader.IsDBNull(widthColumnIndex))
						record.Width = Convert.ToDouble(reader.GetValue(widthColumnIndex));
					if(!reader.IsDBNull(statusColumnIndex))
						record.Status = Convert.ToBoolean(reader.GetValue(statusColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(contentColumnIndex))
						record.Content = Convert.ToString(reader.GetValue(contentColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (WH_CheckSheet_DetailRow[])(recordList.ToArray(typeof(WH_CheckSheet_DetailRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WH_CheckSheet_DetailRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WH_CheckSheet_DetailRow"/> object.</returns>
	protected virtual WH_CheckSheet_DetailRow MapRow(DataRow row)
	{
		string LOCATION = "WH_CheckSheet_DetailRow MapRow(DataRow row)";
		WH_CheckSheet_DetailRow mappedObject = new WH_CheckSheet_DetailRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "WH_CheckSheet_Detail_ID"
		dataColumn = dataTable.Columns["WH_CheckSheet_Detail_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_CheckSheet_Detail_ID = (int)(row[dataColumn]);
		// Column "WH_CheckSheetVsMaterial_ID"
		dataColumn = dataTable.Columns["WH_CheckSheetVsMaterial_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_CheckSheetVsMaterial_ID = (int)(row[dataColumn]);
		// Column "Length"
		dataColumn = dataTable.Columns["Length"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Length = (double)(row[dataColumn]);
		// Column "Height"
		dataColumn = dataTable.Columns["Height"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Height = (double)(row[dataColumn]);
		// Column "Width"
		dataColumn = dataTable.Columns["Width"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Width = (double)(row[dataColumn]);
		// Column "Status"
		dataColumn = dataTable.Columns["Status"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Status = (bool)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditDate"
		dataColumn = dataTable.Columns["LastEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditBy"
		dataColumn = dataTable.Columns["LastEditBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
		// Column "Content"
		dataColumn = dataTable.Columns["Content"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Content = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>WH_CheckSheet_Detail</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WH_CheckSheet_Detail";
		DataColumn dataColumn;
		// Create the "WH_CheckSheet_Detail_ID" column
		dataColumn = dataTable.Columns.Add("WH_CheckSheet_Detail_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "WH_CheckSheetVsMaterial_ID" column
		dataColumn = dataTable.Columns.Add("WH_CheckSheetVsMaterial_ID", typeof(int));
		// Create the "Length" column
		dataColumn = dataTable.Columns.Add("Length", typeof(double));
		// Create the "Height" column
		dataColumn = dataTable.Columns.Add("Height", typeof(double));
		// Create the "Width" column
		dataColumn = dataTable.Columns.Add("Width", typeof(double));
		// Create the "Status" column
		dataColumn = dataTable.Columns.Add("Status", typeof(bool));
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "Content" column
		dataColumn = dataTable.Columns.Add("Content", typeof(string));
		dataColumn.MaxLength = 500;
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
			case "WH_CheckSheet_Detail_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WH_CheckSheetVsMaterial_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Length":
				parameter = _db.AddParameter(cmd, paramName, DbType.Double, value);
				break;

			case "Height":
				parameter = _db.AddParameter(cmd, paramName, DbType.Double, value);
				break;

			case "Width":
				parameter = _db.AddParameter(cmd, paramName, DbType.Double, value);
				break;

			case "Status":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "Content":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WH_CheckSheet_DetailRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_CheckSheet_Detail_ID">The <c>WH_CheckSheet_Detail_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_CheckSheet_DetailRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int wH_CheckSheet_Detail_ID)
	{
		string LOCATION = "Exist(int wH_CheckSheet_Detail_ID)";
		IDbCommand cmd = _db.CreateCommand("WH_CheckSheet_Detail_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "WH_CheckSheet_Detail_ID", wH_CheckSheet_Detail_ID);
		WH_CheckSheet_DetailRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




