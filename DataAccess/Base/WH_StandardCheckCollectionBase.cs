
// <fileinfo name="Base\WH_StandardCheckCollectionBase.cs">
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
/// The base class for <see cref="WH_StandardCheckCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_StandardCheckCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_StandardCheckCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string WH_StandardCheck_IDColumnName  = "WH_StandardCheck_ID";
	public const string NameColumnName  = "Name";
	public const string WH_MaterialCategory_IDColumnName  = "WH_MaterialCategory_ID";
	public const string WH_MaterialList_IDColumnName  = "WH_MaterialList_ID";
	public const string DescriptionColumnName  = "Description";
	public const string ActiveColumnName  = "Active";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string SizeBasicColumnName  = "SizeBasic";
	public const string StandardTechniqueColumnName  = "StandardTechnique";
	public const string TestAndTryColumnName  = "TestAndTry";
	public const string TestParameterList_IDColumnName  = "TestParameterList_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WH_StandardCheckCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WH_StandardCheck";
	}

	public WH_StandardCheckCollectionBase() : base()
	{
		this.TABLENAME = "WH_StandardCheck";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WH_StandardCheckRow"/> objects.</returns>
	public virtual WH_StandardCheckRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WH_StandardCheck</c> table.
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
	/// to retrieve all records from the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WH_StandardCheck_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WH_StandardCheckRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WH_StandardCheckRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WH_StandardCheckRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WH_StandardCheckRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WH_StandardCheckRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WH_StandardCheckRow"/> objects.</returns>
	public WH_StandardCheckRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WH_StandardCheckRow"/> objects that 
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
	/// <returns>An array of <see cref="WH_StandardCheckRow"/> objects.</returns>
	public virtual WH_StandardCheckRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WH_StandardCheckRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WH_StandardCheckRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_StandardCheck_ID">The <c>WH_StandardCheck_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_StandardCheckRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WH_StandardCheckRow GetByPrimaryKey(int wH_StandardCheck_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_StandardCheck_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "WH_StandardCheck_ID", wH_StandardCheck_ID);
			WH_StandardCheckRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_StandardCheckRow"/> object to be inserted.</param>
	public virtual void Insert(WH_StandardCheckRow value)
	{
		string LOCATION = "Insert(WH_StandardCheckRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_Insert", CommandType.StoredProcedure);
					// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// WH_MaterialCategory_ID
			if (value.IsWH_MaterialCategory_IDNull)
				AddParameter(cmd, "WH_MaterialCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_MaterialCategory_ID", value.WH_MaterialCategory_ID);
			
				// WH_MaterialList_ID
			if (value.IsWH_MaterialList_IDNull )
				AddParameter(cmd, "WH_MaterialList_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_MaterialList_ID", value.WH_MaterialList_ID);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
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
			
				// SizeBasic
			if (value.IsSizeBasicNull )
				AddParameter(cmd, "SizeBasic", DBNull.Value);
			else
				AddParameter(cmd, "SizeBasic", value.SizeBasic);
			
				// StandardTechnique
			if (value.IsStandardTechniqueNull )
				AddParameter(cmd, "StandardTechnique", DBNull.Value);
			else
				AddParameter(cmd, "StandardTechnique", value.StandardTechnique);
			
				// TestAndTry
			if (value.IsTestAndTryNull )
				AddParameter(cmd, "TestAndTry", DBNull.Value);
			else
				AddParameter(cmd, "TestAndTry", value.TestAndTry);
			
				// TestParameterList_ID
			if (value.IsTestParameterList_IDNull )
				AddParameter(cmd, "TestParameterList_ID", DBNull.Value);
			else
				AddParameter(cmd, "TestParameterList_ID", value.TestParameterList_ID);
			
						value.WH_StandardCheck_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_StandardCheckRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WH_StandardCheckRow value)
	{	
		string LOCATION = "Update(WH_StandardCheckRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_Update", CommandType.StoredProcedure);
					// Name
			if (value.IsNameNull)
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
				// WH_MaterialCategory_ID
			if (value.IsWH_MaterialCategory_IDNull)
				AddParameter(cmd, "WH_MaterialCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_MaterialCategory_ID", value.WH_MaterialCategory_ID);
			
				// WH_MaterialList_ID
			if (value.IsWH_MaterialList_IDNull)
				AddParameter(cmd, "WH_MaterialList_ID", DBNull.Value);
			else
				AddParameter(cmd, "WH_MaterialList_ID", value.WH_MaterialList_ID);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
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
			
				// SizeBasic
			if (value.IsSizeBasicNull)
				AddParameter(cmd, "SizeBasic", DBNull.Value);
			else
				AddParameter(cmd, "SizeBasic", value.SizeBasic);
				// StandardTechnique
			if (value.IsStandardTechniqueNull)
				AddParameter(cmd, "StandardTechnique", DBNull.Value);
			else
				AddParameter(cmd, "StandardTechnique", value.StandardTechnique);
				// TestAndTry
			if (value.IsTestAndTryNull)
				AddParameter(cmd, "TestAndTry", DBNull.Value);
			else
				AddParameter(cmd, "TestAndTry", value.TestAndTry);
				// TestParameterList_ID
			if (value.IsTestParameterList_IDNull)
				AddParameter(cmd, "TestParameterList_ID", DBNull.Value);
			else
				AddParameter(cmd, "TestParameterList_ID", value.TestParameterList_ID);
					AddParameter(cmd, "WH_StandardCheck_ID", value.WH_StandardCheck_ID);
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
		/// Inserts or Updates a record in the <c>WH_StandardCheck</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WH_StandardCheckRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WH_StandardCheckRow value)
		{
			string LOCATION = "Save(WH_StandardCheckRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WH_StandardCheck_Save",CommandType.StoredProcedure);
					// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", (object)(value.Name));
				
					// WH_MaterialCategory_ID
				if (value.IsWH_MaterialCategory_IDNull)
					AddParameter(cmd, "WH_MaterialCategory_ID", DBNull.Value);
				else
					AddParameter(cmd, "WH_MaterialCategory_ID", (object)(value.WH_MaterialCategory_ID));
				
					// WH_MaterialList_ID
				if (value.IsWH_MaterialList_IDNull)
					AddParameter(cmd, "WH_MaterialList_ID", DBNull.Value);
				else
					AddParameter(cmd, "WH_MaterialList_ID", (object)(value.WH_MaterialList_ID));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
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
				
					// SizeBasic
				if (value.IsSizeBasicNull)
					AddParameter(cmd, "SizeBasic", DBNull.Value);
				else
					AddParameter(cmd, "SizeBasic", (object)(value.SizeBasic));
				
					// StandardTechnique
				if (value.IsStandardTechniqueNull)
					AddParameter(cmd, "StandardTechnique", DBNull.Value);
				else
					AddParameter(cmd, "StandardTechnique", (object)(value.StandardTechnique));
				
					// TestAndTry
				if (value.IsTestAndTryNull)
					AddParameter(cmd, "TestAndTry", DBNull.Value);
				else
					AddParameter(cmd, "TestAndTry", (object)(value.TestAndTry));
				
					// TestParameterList_ID
				if (value.IsTestParameterList_IDNull)
					AddParameter(cmd, "TestParameterList_ID", DBNull.Value);
				else
					AddParameter(cmd, "TestParameterList_ID", (object)(value.TestParameterList_ID));
				
						AddParameter(cmd, "WH_StandardCheck_ID", value.WH_StandardCheck_ID);
						value.WH_StandardCheck_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["WH_StandardCheck_ID"]);
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
	/// Deletes the specified object from the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WH_StandardCheckRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WH_StandardCheckRow value)
	{
		return DeleteByPrimaryKey(value.WH_StandardCheck_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WH_StandardCheck</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="wH_StandardCheck_ID">The <c>WH_StandardCheck_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int wH_StandardCheck_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_StandardCheck_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "WH_StandardCheck_ID", wH_StandardCheck_ID);
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
	/// Deletes <c>WH_StandardCheck</c> records that match the specified criteria.
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
	/// to delete <c>WH_StandardCheck</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WH_StandardCheck_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WH_StandardCheckRow"/> objects.</returns>
	protected WH_StandardCheckRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WH_StandardCheckRow"/> objects.</returns>
	protected WH_StandardCheckRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WH_StandardCheckRow"/> objects.</returns>
	protected virtual WH_StandardCheckRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// WH_StandardCheck_ID
		int wH_StandardCheck_IDColumnIndex = reader.GetOrdinal("WH_StandardCheck_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// WH_MaterialCategory_ID
		int wH_MaterialCategory_IDColumnIndex = reader.GetOrdinal("WH_MaterialCategory_ID");
		// WH_MaterialList_ID
		int wH_MaterialList_IDColumnIndex = reader.GetOrdinal("WH_MaterialList_ID");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// SizeBasic
		int sizeBasicColumnIndex = reader.GetOrdinal("SizeBasic");
		// StandardTechnique
		int standardTechniqueColumnIndex = reader.GetOrdinal("StandardTechnique");
		// TestAndTry
		int testAndTryColumnIndex = reader.GetOrdinal("TestAndTry");
		// TestParameterList_ID
		int testParameterList_IDColumnIndex = reader.GetOrdinal("TestParameterList_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WH_StandardCheckRow record = new WH_StandardCheckRow();
				recordList.Add(record);

					record.WH_StandardCheck_ID = Convert.ToInt32(reader.GetValue(wH_StandardCheck_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(wH_MaterialCategory_IDColumnIndex))
						record.WH_MaterialCategory_ID = Convert.ToInt32(reader.GetValue(wH_MaterialCategory_IDColumnIndex));
					if(!reader.IsDBNull(wH_MaterialList_IDColumnIndex))
						record.WH_MaterialList_ID = Convert.ToString(reader.GetValue(wH_MaterialList_IDColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(sizeBasicColumnIndex))
						record.SizeBasic = Convert.ToString(reader.GetValue(sizeBasicColumnIndex));
					if(!reader.IsDBNull(standardTechniqueColumnIndex))
						record.StandardTechnique = Convert.ToString(reader.GetValue(standardTechniqueColumnIndex));
					if(!reader.IsDBNull(testAndTryColumnIndex))
						record.TestAndTry = Convert.ToString(reader.GetValue(testAndTryColumnIndex));
					if(!reader.IsDBNull(testParameterList_IDColumnIndex))
						record.TestParameterList_ID = Convert.ToString(reader.GetValue(testParameterList_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (WH_StandardCheckRow[])(recordList.ToArray(typeof(WH_StandardCheckRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WH_StandardCheckRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WH_StandardCheckRow"/> object.</returns>
	protected virtual WH_StandardCheckRow MapRow(DataRow row)
	{
		string LOCATION = "WH_StandardCheckRow MapRow(DataRow row)";
		WH_StandardCheckRow mappedObject = new WH_StandardCheckRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "WH_StandardCheck_ID"
		dataColumn = dataTable.Columns["WH_StandardCheck_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_StandardCheck_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "WH_MaterialCategory_ID"
		dataColumn = dataTable.Columns["WH_MaterialCategory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_MaterialCategory_ID = (int)(row[dataColumn]);
		// Column "WH_MaterialList_ID"
		dataColumn = dataTable.Columns["WH_MaterialList_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WH_MaterialList_ID = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditBy"
		dataColumn = dataTable.Columns["LastEditBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditDate"
		dataColumn = dataTable.Columns["LastEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
		// Column "SizeBasic"
		dataColumn = dataTable.Columns["SizeBasic"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SizeBasic = (string)(row[dataColumn]);
		// Column "StandardTechnique"
		dataColumn = dataTable.Columns["StandardTechnique"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StandardTechnique = (string)(row[dataColumn]);
		// Column "TestAndTry"
		dataColumn = dataTable.Columns["TestAndTry"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TestAndTry = (string)(row[dataColumn]);
		// Column "TestParameterList_ID"
		dataColumn = dataTable.Columns["TestParameterList_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TestParameterList_ID = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>WH_StandardCheck</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WH_StandardCheck";
		DataColumn dataColumn;
		// Create the "WH_StandardCheck_ID" column
		dataColumn = dataTable.Columns.Add("WH_StandardCheck_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "WH_MaterialCategory_ID" column
		dataColumn = dataTable.Columns.Add("WH_MaterialCategory_ID", typeof(int));
		// Create the "WH_MaterialList_ID" column
		dataColumn = dataTable.Columns.Add("WH_MaterialList_ID", typeof(string));
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "SizeBasic" column
		dataColumn = dataTable.Columns.Add("SizeBasic", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "StandardTechnique" column
		dataColumn = dataTable.Columns.Add("StandardTechnique", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "TestAndTry" column
		dataColumn = dataTable.Columns.Add("TestAndTry", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "TestParameterList_ID" column
		dataColumn = dataTable.Columns.Add("TestParameterList_ID", typeof(string));
		dataColumn.MaxLength = 1073741823;
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
			case "WH_StandardCheck_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "WH_MaterialCategory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WH_MaterialList_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "SizeBasic":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StandardTechnique":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TestAndTry":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TestParameterList_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WH_StandardCheckRow"/> by the primary key.
	/// </summary>
	/// <param name="wH_StandardCheck_ID">The <c>WH_StandardCheck_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WH_StandardCheckRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int wH_StandardCheck_ID)
	{
		string LOCATION = "Exist(int wH_StandardCheck_ID)";
		IDbCommand cmd = _db.CreateCommand("WH_StandardCheck_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "WH_StandardCheck_ID", wH_StandardCheck_ID);
		WH_StandardCheckRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




