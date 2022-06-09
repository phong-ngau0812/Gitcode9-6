
// <fileinfo name="Base\WardCollectionBase.cs">
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
/// The base class for <see cref="WardCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WardCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WardCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Ward_IDColumnName  = "Ward_ID";
	public const string Location_IDColumnName  = "Location_ID";
	public const string District_IDColumnName  = "District_ID";
	public const string CodeColumnName  = "Code";
	public const string NameColumnName  = "Name";
	public const string DescriptionColumnName  = "Description";
	public const string SortColumnName  = "Sort";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WardCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Ward";
	}

	public WardCollectionBase() : base()
	{
		this.TABLENAME = "Ward";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Ward</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WardRow"/> objects.</returns>
	public virtual WardRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Ward</c> table.
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
	/// to retrieve all records from the <c>Ward</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Ward_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WardRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WardRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WardRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WardRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WardRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WardRow"/> objects.</returns>
	public WardRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WardRow"/> objects that 
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
	/// <returns>An array of <see cref="WardRow"/> objects.</returns>
	public virtual WardRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WardRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Ward_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Ward_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WardRow"/> by the primary key.
	/// </summary>
	/// <param name="ward_ID">The <c>Ward_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WardRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WardRow GetByPrimaryKey(int ward_ID)
	{
		string LOCATION = "GetByPrimaryKey(int ward_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Ward_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Ward_ID", ward_ID);
			WardRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Ward</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WardRow"/> object to be inserted.</param>
	public virtual void Insert(WardRow value)
	{
		string LOCATION = "Insert(WardRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Ward_Insert", CommandType.StoredProcedure);
					// Ward_ID
			if (value.IsWard_IDNull )
				AddParameter(cmd, "Ward_ID", DBNull.Value);
			else
				AddParameter(cmd, "Ward_ID", value.Ward_ID);
			
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// District_ID
			if (value.IsDistrict_IDNull)
				AddParameter(cmd, "District_ID", DBNull.Value);
			else
				AddParameter(cmd, "District_ID", value.District_ID);
			
				// Code
			if (value.IsCodeNull )
				AddParameter(cmd, "Code", DBNull.Value);
			else
				AddParameter(cmd, "Code", value.Code);
			
				// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
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
	/// Updates a record in the <c>Ward</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WardRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WardRow value)
	{	
		string LOCATION = "Update(WardRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Ward_Update", CommandType.StoredProcedure);
					// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// District_ID
			if (value.IsDistrict_IDNull)
				AddParameter(cmd, "District_ID", DBNull.Value);
			else
				AddParameter(cmd, "District_ID", value.District_ID);
			
				// Code
			if (value.IsCodeNull)
				AddParameter(cmd, "Code", DBNull.Value);
			else
				AddParameter(cmd, "Code", value.Code);
				// Name
			if (value.IsNameNull)
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
					AddParameter(cmd, "Ward_ID", value.Ward_ID);
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
		/// Inserts or Updates a record in the <c>Ward</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WardRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WardRow value)
		{
			string LOCATION = "Save(WardRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Ward_Save",CommandType.StoredProcedure);
					// Location_ID
				if (value.IsLocation_IDNull)
					AddParameter(cmd, "Location_ID", DBNull.Value);
				else
					AddParameter(cmd, "Location_ID", (object)(value.Location_ID));
				
					// District_ID
				if (value.IsDistrict_IDNull)
					AddParameter(cmd, "District_ID", DBNull.Value);
				else
					AddParameter(cmd, "District_ID", (object)(value.District_ID));
				
					// Code
				if (value.IsCodeNull)
					AddParameter(cmd, "Code", DBNull.Value);
				else
					AddParameter(cmd, "Code", (object)(value.Code));
				
					// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", (object)(value.Name));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// Sort
				if (value.IsSortNull)
					AddParameter(cmd, "Sort", DBNull.Value);
				else
					AddParameter(cmd, "Sort", (object)(value.Sort));
				
						AddParameter(cmd, "Ward_ID", value.Ward_ID);
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
							DeleteByPrimaryKey((int)row["Ward_ID"]);
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
	/// Deletes the specified object from the <c>Ward</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WardRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WardRow value)
	{
		return DeleteByPrimaryKey(value.Ward_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Ward</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="ward_ID">The <c>Ward_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int ward_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int ward_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Ward_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Ward_ID", ward_ID);
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
	/// Deletes <c>Ward</c> records that match the specified criteria.
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
	/// to delete <c>Ward</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Ward_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Ward</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Ward_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WardRow"/> objects.</returns>
	protected WardRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WardRow"/> objects.</returns>
	protected WardRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WardRow"/> objects.</returns>
	protected virtual WardRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Ward_ID
		int ward_IDColumnIndex = reader.GetOrdinal("Ward_ID");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// District_ID
		int district_IDColumnIndex = reader.GetOrdinal("District_ID");
		// Code
		int codeColumnIndex = reader.GetOrdinal("Code");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WardRow record = new WardRow();
				recordList.Add(record);

					record.Ward_ID = Convert.ToInt32(reader.GetValue(ward_IDColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(district_IDColumnIndex))
						record.District_ID = Convert.ToInt32(reader.GetValue(district_IDColumnIndex));
					if(!reader.IsDBNull(codeColumnIndex))
						record.Code = Convert.ToString(reader.GetValue(codeColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
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

		return (WardRow[])(recordList.ToArray(typeof(WardRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WardRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WardRow"/> object.</returns>
	protected virtual WardRow MapRow(DataRow row)
	{
		string LOCATION = "WardRow MapRow(DataRow row)";
		WardRow mappedObject = new WardRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Ward_ID"
		dataColumn = dataTable.Columns["Ward_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Ward_ID = (int)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "District_ID"
		dataColumn = dataTable.Columns["District_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.District_ID = (int)(row[dataColumn]);
		// Column "Code"
		dataColumn = dataTable.Columns["Code"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Code = (string)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Ward</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Ward";
		DataColumn dataColumn;
		// Create the "Ward_ID" column
		dataColumn = dataTable.Columns.Add("Ward_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "District_ID" column
		dataColumn = dataTable.Columns.Add("District_ID", typeof(int));
		// Create the "Code" column
		dataColumn = dataTable.Columns.Add("Code", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 200;
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
			case "Ward_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "District_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Code":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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
	/// Exist <see cref="WardRow"/> by the primary key.
	/// </summary>
	/// <param name="ward_ID">The <c>Ward_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WardRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int ward_ID)
	{
		string LOCATION = "Exist(int ward_ID)";
		IDbCommand cmd = _db.CreateCommand("Ward_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Ward_ID", ward_ID);
		WardRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




