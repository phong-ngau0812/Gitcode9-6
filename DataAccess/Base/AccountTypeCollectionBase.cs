
// <fileinfo name="Base\AccountTypeCollectionBase.cs">
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
/// The base class for <see cref="AccountTypeCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="AccountTypeCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class AccountTypeCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string AccountType_IDColumnName  = "AccountType_ID";
	public const string NameColumnName  = "Name";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string DescriptionColumnName  = "Description";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditedByColumnName  = "LastEditedBy";
	public const string LastEditedDateColumnName  = "LastEditedDate";
	public const string ActiveColumnName  = "Active";
	public const string SortColumnName  = "Sort";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public AccountTypeCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "AccountType";
	}

	public AccountTypeCollectionBase() : base()
	{
		this.TABLENAME = "AccountType";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>AccountType</c> table.
	/// </summary>
	/// <returns>An array of <see cref="AccountTypeRow"/> objects.</returns>
	public virtual AccountTypeRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>AccountType</c> table.
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
	/// to retrieve all records from the <c>AccountType</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("AccountType_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="AccountTypeRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="AccountTypeRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public AccountTypeRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			AccountTypeRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="AccountTypeRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="AccountTypeRow"/> objects.</returns>
	public AccountTypeRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="AccountTypeRow"/> objects that 
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
	/// <returns>An array of <see cref="AccountTypeRow"/> objects.</returns>
	public virtual AccountTypeRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			AccountTypeRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("AccountType_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("AccountType_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="AccountTypeRow"/> by the primary key.
	/// </summary>
	/// <param name="accountType_ID">The <c>AccountType_ID</c> column value.</param>
	/// <returns>An instance of <see cref="AccountTypeRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual AccountTypeRow GetByPrimaryKey(int accountType_ID)
	{
		string LOCATION = "GetByPrimaryKey(int accountType_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("AccountType_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "AccountType_ID", accountType_ID);
			AccountTypeRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>AccountType</c> table.
	/// </summary>
	/// <param name="value">The <see cref="AccountTypeRow"/> object to be inserted.</param>
	public virtual void Insert(AccountTypeRow value)
	{
		string LOCATION = "Insert(AccountTypeRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("AccountType_Insert", CommandType.StoredProcedure);
					// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
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
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
						value.AccountType_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>AccountType</c> table.
	/// </summary>
	/// <param name="value">The <see cref="AccountTypeRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(AccountTypeRow value)
	{	
		string LOCATION = "Update(AccountTypeRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("AccountType_Update", CommandType.StoredProcedure);
					// Name
			if (value.IsNameNull)
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
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
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
					AddParameter(cmd, "AccountType_ID", value.AccountType_ID);
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
		/// Inserts or Updates a record in the <c>AccountType</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="AccountTypeRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(AccountTypeRow value)
		{
			string LOCATION = "Save(AccountTypeRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("AccountType_Save",CommandType.StoredProcedure);
					// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", (object)(value.Name));
				
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
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
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// Sort
				if (value.IsSortNull)
					AddParameter(cmd, "Sort", DBNull.Value);
				else
					AddParameter(cmd, "Sort", (object)(value.Sort));
				
						AddParameter(cmd, "AccountType_ID", value.AccountType_ID);
						value.AccountType_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["AccountType_ID"]);
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
	/// Deletes the specified object from the <c>AccountType</c> table.
	/// </summary>
	/// <param name="value">The <see cref="AccountTypeRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(AccountTypeRow value)
	{
		return DeleteByPrimaryKey(value.AccountType_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>AccountType</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="accountType_ID">The <c>AccountType_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int accountType_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int accountType_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("AccountType_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "AccountType_ID", accountType_ID);
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
	/// Deletes <c>AccountType</c> records that match the specified criteria.
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
	/// to delete <c>AccountType</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("AccountType_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>AccountType</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("AccountType_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="AccountTypeRow"/> objects.</returns>
	protected AccountTypeRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="AccountTypeRow"/> objects.</returns>
	protected AccountTypeRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="AccountTypeRow"/> objects.</returns>
	protected virtual AccountTypeRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// AccountType_ID
		int accountType_IDColumnIndex = reader.GetOrdinal("AccountType_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditedBy
		int lastEditedByColumnIndex = reader.GetOrdinal("LastEditedBy");
		// LastEditedDate
		int lastEditedDateColumnIndex = reader.GetOrdinal("LastEditedDate");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				AccountTypeRow record = new AccountTypeRow();
				recordList.Add(record);

					record.AccountType_ID = Convert.ToInt32(reader.GetValue(accountType_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditedByColumnIndex))
						record.LastEditedBy = reader.GetGuid(lastEditedByColumnIndex);
					if(!reader.IsDBNull(lastEditedDateColumnIndex))
						record.LastEditedDate = Convert.ToDateTime(reader.GetValue(lastEditedDateColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(sortColumnIndex))
						record.Sort = Convert.ToInt32(reader.GetValue(sortColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (AccountTypeRow[])(recordList.ToArray(typeof(AccountTypeRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="AccountTypeRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="AccountTypeRow"/> object.</returns>
	protected virtual AccountTypeRow MapRow(DataRow row)
	{
		string LOCATION = "AccountTypeRow MapRow(DataRow row)";
		AccountTypeRow mappedObject = new AccountTypeRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "AccountType_ID"
		dataColumn = dataTable.Columns["AccountType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AccountType_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
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
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (int)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>AccountType</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "AccountType";
		DataColumn dataColumn;
		// Create the "AccountType_ID" column
		dataColumn = dataTable.Columns.Add("AccountType_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditedBy" column
		dataColumn = dataTable.Columns.Add("LastEditedBy", typeof(System.Guid));
		// Create the "LastEditedDate" column
		dataColumn = dataTable.Columns.Add("LastEditedDate", typeof(System.DateTime));
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(int));
		// Create the "Sort" column
		dataColumn = dataTable.Columns.Add("Sort", typeof(int));
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
			case "AccountType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Description":
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

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Sort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="AccountTypeRow"/> by the primary key.
	/// </summary>
	/// <param name="accountType_ID">The <c>AccountType_ID</c> column value.</param>
	/// <returns>An instance of <see cref="AccountTypeRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int accountType_ID)
	{
		string LOCATION = "Exist(int accountType_ID)";
		IDbCommand cmd = _db.CreateCommand("AccountType_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "AccountType_ID", accountType_ID);
		AccountTypeRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




