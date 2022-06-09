
// <fileinfo name="Base\BNN_CountryCollectionBase.cs">
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
/// The base class for <see cref="BNN_CountryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_CountryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_CountryCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Country_IDColumnName  = "Country_ID";
	public const string CountColumnName  = "Count";
	public const string LocationColumnName  = "Location";
	public const string AreaColumnName  = "Area";
	public const string ClimateColumnName  = "Climate";
	public const string PopulationColumnName  = "Population";
	public const string VideoEmbedColumnName  = "VideoEmbed";
	public const string NoteColumnName  = "Note";
	public const string ActiveColumnName  = "Active";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string SortColumnName  = "Sort";
	public const string Location_IDColumnName  = "Location_ID";
	public const string District_IDColumnName  = "District_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public BNN_CountryCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "BNN_Country";
	}

	public BNN_CountryCollectionBase() : base()
	{
		this.TABLENAME = "BNN_Country";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>BNN_Country</c> table.
	/// </summary>
	/// <returns>An array of <see cref="BNN_CountryRow"/> objects.</returns>
	public virtual BNN_CountryRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>BNN_Country</c> table.
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
	/// to retrieve all records from the <c>BNN_Country</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("BNN_Country_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="BNN_CountryRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="BNN_CountryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public BNN_CountryRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			BNN_CountryRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="BNN_CountryRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="BNN_CountryRow"/> objects.</returns>
	public BNN_CountryRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="BNN_CountryRow"/> objects that 
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
	/// <returns>An array of <see cref="BNN_CountryRow"/> objects.</returns>
	public virtual BNN_CountryRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			BNN_CountryRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("BNN_Country_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("BNN_Country_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="BNN_CountryRow"/> by the primary key.
	/// </summary>
	/// <param name="country_ID">The <c>Country_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BNN_CountryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual BNN_CountryRow GetByPrimaryKey(int country_ID)
	{
		string LOCATION = "GetByPrimaryKey(int country_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("BNN_Country_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Country_ID", country_ID);
			BNN_CountryRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>BNN_Country</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_CountryRow"/> object to be inserted.</param>
	public virtual void Insert(BNN_CountryRow value)
	{
		string LOCATION = "Insert(BNN_CountryRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Country_Insert", CommandType.StoredProcedure);
					// Count
			if (value.IsCountNull )
				AddParameter(cmd, "Count", DBNull.Value);
			else
				AddParameter(cmd, "Count", value.Count);
			
				// Location
			if (value.IsLocationNull )
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
			
				// Area
			if (value.IsAreaNull )
				AddParameter(cmd, "Area", DBNull.Value);
			else
				AddParameter(cmd, "Area", value.Area);
			
				// Climate
			if (value.IsClimateNull )
				AddParameter(cmd, "Climate", DBNull.Value);
			else
				AddParameter(cmd, "Climate", value.Climate);
			
				// Population
			if (value.IsPopulationNull )
				AddParameter(cmd, "Population", DBNull.Value);
			else
				AddParameter(cmd, "Population", value.Population);
			
				// VideoEmbed
			if (value.IsVideoEmbedNull )
				AddParameter(cmd, "VideoEmbed", DBNull.Value);
			else
				AddParameter(cmd, "VideoEmbed", value.VideoEmbed);
			
				// Note
			if (value.IsNoteNull )
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
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
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
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
			
						value.Country_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>BNN_Country</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_CountryRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(BNN_CountryRow value)
	{	
		string LOCATION = "Update(BNN_CountryRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Country_Update", CommandType.StoredProcedure);
					// Count
			if (value.IsCountNull)
				AddParameter(cmd, "Count", DBNull.Value);
			else
				AddParameter(cmd, "Count", value.Count);
				// Location
			if (value.IsLocationNull)
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
				// Area
			if (value.IsAreaNull)
				AddParameter(cmd, "Area", DBNull.Value);
			else
				AddParameter(cmd, "Area", value.Area);
				// Climate
			if (value.IsClimateNull)
				AddParameter(cmd, "Climate", DBNull.Value);
			else
				AddParameter(cmd, "Climate", value.Climate);
				// Population
			if (value.IsPopulationNull)
				AddParameter(cmd, "Population", DBNull.Value);
			else
				AddParameter(cmd, "Population", value.Population);
				// VideoEmbed
			if (value.IsVideoEmbedNull)
				AddParameter(cmd, "VideoEmbed", DBNull.Value);
			else
				AddParameter(cmd, "VideoEmbed", value.VideoEmbed);
				// Note
			if (value.IsNoteNull)
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// CreateDate
			if (value.IsCreateDateNull)
				AddParameter(cmd, "CreateDate", DBNull.Value);
			else
				AddParameter(cmd, "CreateDate", value.CreateDate);
			
				// LastEditDate
			if (value.IsLastEditDateNull)
				AddParameter(cmd, "LastEditDate", DBNull.Value);
			else
				AddParameter(cmd, "LastEditDate", value.LastEditDate);
			
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
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
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
			
					AddParameter(cmd, "Country_ID", value.Country_ID);
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
		/// Inserts or Updates a record in the <c>BNN_Country</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="BNN_CountryRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(BNN_CountryRow value)
		{
			string LOCATION = "Save(BNN_CountryRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("BNN_Country_Save",CommandType.StoredProcedure);
					// Count
				if (value.IsCountNull)
					AddParameter(cmd, "Count", DBNull.Value);
				else
					AddParameter(cmd, "Count", (object)(value.Count));
				
					// Location
				if (value.IsLocationNull)
					AddParameter(cmd, "Location", DBNull.Value);
				else
					AddParameter(cmd, "Location", (object)(value.Location));
				
					// Area
				if (value.IsAreaNull)
					AddParameter(cmd, "Area", DBNull.Value);
				else
					AddParameter(cmd, "Area", (object)(value.Area));
				
					// Climate
				if (value.IsClimateNull)
					AddParameter(cmd, "Climate", DBNull.Value);
				else
					AddParameter(cmd, "Climate", (object)(value.Climate));
				
					// Population
				if (value.IsPopulationNull)
					AddParameter(cmd, "Population", DBNull.Value);
				else
					AddParameter(cmd, "Population", (object)(value.Population));
				
					// VideoEmbed
				if (value.IsVideoEmbedNull)
					AddParameter(cmd, "VideoEmbed", DBNull.Value);
				else
					AddParameter(cmd, "VideoEmbed", (object)(value.VideoEmbed));
				
					// Note
				if (value.IsNoteNull)
					AddParameter(cmd, "Note", DBNull.Value);
				else
					AddParameter(cmd, "Note", (object)(value.Note));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// CreateDate
				if (value.IsCreateDateNull)
					AddParameter(cmd, "CreateDate", DBNull.Value);
				else
					AddParameter(cmd, "CreateDate", (object)(value.CreateDate));
				
					// LastEditDate
				if (value.IsLastEditDateNull)
					AddParameter(cmd, "LastEditDate", DBNull.Value);
				else
					AddParameter(cmd, "LastEditDate", (object)(value.LastEditDate));
				
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
				
					// Sort
				if (value.IsSortNull)
					AddParameter(cmd, "Sort", DBNull.Value);
				else
					AddParameter(cmd, "Sort", (object)(value.Sort));
				
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
				
						AddParameter(cmd, "Country_ID", value.Country_ID);
						value.Country_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Country_ID"]);
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
	/// Deletes the specified object from the <c>BNN_Country</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_CountryRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(BNN_CountryRow value)
	{
		return DeleteByPrimaryKey(value.Country_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>BNN_Country</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="country_ID">The <c>Country_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int country_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int country_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Country_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Country_ID", country_ID);
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
	/// Deletes <c>BNN_Country</c> records that match the specified criteria.
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
	/// to delete <c>BNN_Country</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("BNN_Country_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>BNN_Country</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("BNN_Country_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="BNN_CountryRow"/> objects.</returns>
	protected BNN_CountryRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="BNN_CountryRow"/> objects.</returns>
	protected BNN_CountryRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="BNN_CountryRow"/> objects.</returns>
	protected virtual BNN_CountryRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Country_ID
		int country_IDColumnIndex = reader.GetOrdinal("Country_ID");
		// Count
		int countColumnIndex = reader.GetOrdinal("Count");
		// Location
		int locationColumnIndex = reader.GetOrdinal("Location");
		// Area
		int areaColumnIndex = reader.GetOrdinal("Area");
		// Climate
		int climateColumnIndex = reader.GetOrdinal("Climate");
		// Population
		int populationColumnIndex = reader.GetOrdinal("Population");
		// VideoEmbed
		int videoEmbedColumnIndex = reader.GetOrdinal("VideoEmbed");
		// Note
		int noteColumnIndex = reader.GetOrdinal("Note");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// District_ID
		int district_IDColumnIndex = reader.GetOrdinal("District_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				BNN_CountryRow record = new BNN_CountryRow();
				recordList.Add(record);

					record.Country_ID = Convert.ToInt32(reader.GetValue(country_IDColumnIndex));
					if(!reader.IsDBNull(countColumnIndex))
						record.Count = Convert.ToString(reader.GetValue(countColumnIndex));
					if(!reader.IsDBNull(locationColumnIndex))
						record.Location = Convert.ToString(reader.GetValue(locationColumnIndex));
					if(!reader.IsDBNull(areaColumnIndex))
						record.Area = Convert.ToString(reader.GetValue(areaColumnIndex));
					if(!reader.IsDBNull(climateColumnIndex))
						record.Climate = Convert.ToString(reader.GetValue(climateColumnIndex));
					if(!reader.IsDBNull(populationColumnIndex))
						record.Population = Convert.ToString(reader.GetValue(populationColumnIndex));
					if(!reader.IsDBNull(videoEmbedColumnIndex))
						record.VideoEmbed = Convert.ToString(reader.GetValue(videoEmbedColumnIndex));
					if(!reader.IsDBNull(noteColumnIndex))
						record.Note = Convert.ToString(reader.GetValue(noteColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(sortColumnIndex))
						record.Sort = Convert.ToInt32(reader.GetValue(sortColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(district_IDColumnIndex))
						record.District_ID = Convert.ToInt32(reader.GetValue(district_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (BNN_CountryRow[])(recordList.ToArray(typeof(BNN_CountryRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="BNN_CountryRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="BNN_CountryRow"/> object.</returns>
	protected virtual BNN_CountryRow MapRow(DataRow row)
	{
		string LOCATION = "BNN_CountryRow MapRow(DataRow row)";
		BNN_CountryRow mappedObject = new BNN_CountryRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Country_ID"
		dataColumn = dataTable.Columns["Country_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Country_ID = (int)(row[dataColumn]);
		// Column "Count"
		dataColumn = dataTable.Columns["Count"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Count = (string)(row[dataColumn]);
		// Column "Location"
		dataColumn = dataTable.Columns["Location"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location = (string)(row[dataColumn]);
		// Column "Area"
		dataColumn = dataTable.Columns["Area"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Area = (string)(row[dataColumn]);
		// Column "Climate"
		dataColumn = dataTable.Columns["Climate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Climate = (string)(row[dataColumn]);
		// Column "Population"
		dataColumn = dataTable.Columns["Population"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Population = (string)(row[dataColumn]);
		// Column "VideoEmbed"
		dataColumn = dataTable.Columns["VideoEmbed"];
		if (! row.IsNull(dataColumn) )
			mappedObject.VideoEmbed = (string)(row[dataColumn]);
		// Column "Note"
		dataColumn = dataTable.Columns["Note"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Note = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (int)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditDate"
		dataColumn = dataTable.Columns["LastEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "LastEditBy"
		dataColumn = dataTable.Columns["LastEditBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "District_ID"
		dataColumn = dataTable.Columns["District_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.District_ID = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>BNN_Country</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "BNN_Country";
		DataColumn dataColumn;
		// Create the "Country_ID" column
		dataColumn = dataTable.Columns.Add("Country_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Count" column
		dataColumn = dataTable.Columns.Add("Count", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Location" column
		dataColumn = dataTable.Columns.Add("Location", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Area" column
		dataColumn = dataTable.Columns.Add("Area", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Climate" column
		dataColumn = dataTable.Columns.Add("Climate", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Population" column
		dataColumn = dataTable.Columns.Add("Population", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "VideoEmbed" column
		dataColumn = dataTable.Columns.Add("VideoEmbed", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Note" column
		dataColumn = dataTable.Columns.Add("Note", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(int));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "Sort" column
		dataColumn = dataTable.Columns.Add("Sort", typeof(int));
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "District_ID" column
		dataColumn = dataTable.Columns.Add("District_ID", typeof(int));
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
			case "Country_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Count":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Area":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Climate":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Population":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "VideoEmbed":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Note":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "LastEditBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "Sort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "District_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="BNN_CountryRow"/> by the primary key.
	/// </summary>
	/// <param name="country_ID">The <c>Country_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BNN_CountryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int country_ID)
	{
		string LOCATION = "Exist(int country_ID)";
		IDbCommand cmd = _db.CreateCommand("BNN_Country_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Country_ID", country_ID);
		BNN_CountryRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




