
// <fileinfo name="Base\tblTravelReportCollectionBase.cs">
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
/// The base class for <see cref="tblTravelReportCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="tblTravelReportCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class tblTravelReportCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string IDColumnName  = "ID";
	public const string TitleColumnName  = "Title";
	public const string SummaryColumnName  = "Summary";
	public const string DescriptionColumnName  = "Description";
	public const string ImageFileColumnName  = "ImageFile";
	public const string BannerFileColumnName  = "BannerFile";
	public const string RegDateColumnName  = "RegDate";
	public const string SeoTitleColumnName  = "SeoTitle";
	public const string SeoKeywordColumnName  = "SeoKeyword";
	public const string SeoDescriptionColumnName  = "SeoDescription";
	public const string StatusColumnName  = "Status";
	public const string FlgTopColumnName  = "FlgTop";
	public const string FlgHomeColumnName  = "FlgHome";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public tblTravelReportCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "tblTravelReport";
	}

	public tblTravelReportCollectionBase() : base()
	{
		this.TABLENAME = "tblTravelReport";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>tblTravelReport</c> table.
	/// </summary>
	/// <returns>An array of <see cref="tblTravelReportRow"/> objects.</returns>
	public virtual tblTravelReportRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>tblTravelReport</c> table.
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
	/// to retrieve all records from the <c>tblTravelReport</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("tblTravelReport_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="tblTravelReportRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="tblTravelReportRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public tblTravelReportRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			tblTravelReportRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="tblTravelReportRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="tblTravelReportRow"/> objects.</returns>
	public tblTravelReportRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="tblTravelReportRow"/> objects that 
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
	/// <returns>An array of <see cref="tblTravelReportRow"/> objects.</returns>
	public virtual tblTravelReportRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			tblTravelReportRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("tblTravelReport_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("tblTravelReport_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="tblTravelReportRow"/> by the primary key.
	/// </summary>
	/// <param name="id">The <c>ID</c> column value.</param>
	/// <returns>An instance of <see cref="tblTravelReportRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual tblTravelReportRow GetByPrimaryKey(int id)
	{
		string LOCATION = "GetByPrimaryKey(int id)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("tblTravelReport_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "ID", id);
			tblTravelReportRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>tblTravelReport</c> table.
	/// </summary>
	/// <param name="value">The <see cref="tblTravelReportRow"/> object to be inserted.</param>
	public virtual void Insert(tblTravelReportRow value)
	{
		string LOCATION = "Insert(tblTravelReportRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("tblTravelReport_Insert", CommandType.StoredProcedure);
					// Title
			if (value.IsTitleNull )
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
			
				// Summary
			if (value.IsSummaryNull )
				AddParameter(cmd, "Summary", DBNull.Value);
			else
				AddParameter(cmd, "Summary", value.Summary);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// ImageFile
			if (value.IsImageFileNull )
				AddParameter(cmd, "ImageFile", DBNull.Value);
			else
				AddParameter(cmd, "ImageFile", value.ImageFile);
			
				// BannerFile
			if (value.IsBannerFileNull )
				AddParameter(cmd, "BannerFile", DBNull.Value);
			else
				AddParameter(cmd, "BannerFile", value.BannerFile);
			
				// RegDate
			if (value.IsRegDateNull)
				AddParameter(cmd, "RegDate", DBNull.Value);
			else
				AddParameter(cmd, "RegDate", value.RegDate);
			
				// SeoTitle
			if (value.IsSeoTitleNull )
				AddParameter(cmd, "SeoTitle", DBNull.Value);
			else
				AddParameter(cmd, "SeoTitle", value.SeoTitle);
			
				// SeoKeyword
			if (value.IsSeoKeywordNull )
				AddParameter(cmd, "SeoKeyword", DBNull.Value);
			else
				AddParameter(cmd, "SeoKeyword", value.SeoKeyword);
			
				// SeoDescription
			if (value.IsSeoDescriptionNull )
				AddParameter(cmd, "SeoDescription", DBNull.Value);
			else
				AddParameter(cmd, "SeoDescription", value.SeoDescription);
			
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
				// FlgTop
			if (value.IsFlgTopNull)
				AddParameter(cmd, "FlgTop", DBNull.Value);
			else
				AddParameter(cmd, "FlgTop", value.FlgTop);
			
				// FlgHome
			if (value.IsFlgHomeNull)
				AddParameter(cmd, "FlgHome", DBNull.Value);
			else
				AddParameter(cmd, "FlgHome", value.FlgHome);
			
						value.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>tblTravelReport</c> table.
	/// </summary>
	/// <param name="value">The <see cref="tblTravelReportRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(tblTravelReportRow value)
	{	
		string LOCATION = "Update(tblTravelReportRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("tblTravelReport_Update", CommandType.StoredProcedure);
					// Title
			if (value.IsTitleNull)
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
				// Summary
			if (value.IsSummaryNull)
				AddParameter(cmd, "Summary", DBNull.Value);
			else
				AddParameter(cmd, "Summary", value.Summary);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// ImageFile
			if (value.IsImageFileNull)
				AddParameter(cmd, "ImageFile", DBNull.Value);
			else
				AddParameter(cmd, "ImageFile", value.ImageFile);
				// BannerFile
			if (value.IsBannerFileNull)
				AddParameter(cmd, "BannerFile", DBNull.Value);
			else
				AddParameter(cmd, "BannerFile", value.BannerFile);
				// RegDate
			if (value.IsRegDateNull)
				AddParameter(cmd, "RegDate", DBNull.Value);
			else
				AddParameter(cmd, "RegDate", value.RegDate);
			
				// SeoTitle
			if (value.IsSeoTitleNull)
				AddParameter(cmd, "SeoTitle", DBNull.Value);
			else
				AddParameter(cmd, "SeoTitle", value.SeoTitle);
				// SeoKeyword
			if (value.IsSeoKeywordNull)
				AddParameter(cmd, "SeoKeyword", DBNull.Value);
			else
				AddParameter(cmd, "SeoKeyword", value.SeoKeyword);
				// SeoDescription
			if (value.IsSeoDescriptionNull)
				AddParameter(cmd, "SeoDescription", DBNull.Value);
			else
				AddParameter(cmd, "SeoDescription", value.SeoDescription);
				// Status
			if (value.IsStatusNull)
				AddParameter(cmd, "Status", DBNull.Value);
			else
				AddParameter(cmd, "Status", value.Status);
			
				// FlgTop
			if (value.IsFlgTopNull)
				AddParameter(cmd, "FlgTop", DBNull.Value);
			else
				AddParameter(cmd, "FlgTop", value.FlgTop);
			
				// FlgHome
			if (value.IsFlgHomeNull)
				AddParameter(cmd, "FlgHome", DBNull.Value);
			else
				AddParameter(cmd, "FlgHome", value.FlgHome);
			
					AddParameter(cmd, "ID", value.ID);
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
		/// Inserts or Updates a record in the <c>tblTravelReport</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="tblTravelReportRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(tblTravelReportRow value)
		{
			string LOCATION = "Save(tblTravelReportRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("tblTravelReport_Save",CommandType.StoredProcedure);
					// Title
				if (value.IsTitleNull)
					AddParameter(cmd, "Title", DBNull.Value);
				else
					AddParameter(cmd, "Title", (object)(value.Title));
				
					// Summary
				if (value.IsSummaryNull)
					AddParameter(cmd, "Summary", DBNull.Value);
				else
					AddParameter(cmd, "Summary", (object)(value.Summary));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// ImageFile
				if (value.IsImageFileNull)
					AddParameter(cmd, "ImageFile", DBNull.Value);
				else
					AddParameter(cmd, "ImageFile", (object)(value.ImageFile));
				
					// BannerFile
				if (value.IsBannerFileNull)
					AddParameter(cmd, "BannerFile", DBNull.Value);
				else
					AddParameter(cmd, "BannerFile", (object)(value.BannerFile));
				
					// RegDate
				if (value.IsRegDateNull)
					AddParameter(cmd, "RegDate", DBNull.Value);
				else
					AddParameter(cmd, "RegDate", (object)(value.RegDate));
				
					// SeoTitle
				if (value.IsSeoTitleNull)
					AddParameter(cmd, "SeoTitle", DBNull.Value);
				else
					AddParameter(cmd, "SeoTitle", (object)(value.SeoTitle));
				
					// SeoKeyword
				if (value.IsSeoKeywordNull)
					AddParameter(cmd, "SeoKeyword", DBNull.Value);
				else
					AddParameter(cmd, "SeoKeyword", (object)(value.SeoKeyword));
				
					// SeoDescription
				if (value.IsSeoDescriptionNull)
					AddParameter(cmd, "SeoDescription", DBNull.Value);
				else
					AddParameter(cmd, "SeoDescription", (object)(value.SeoDescription));
				
					// Status
				if (value.IsStatusNull)
					AddParameter(cmd, "Status", DBNull.Value);
				else
					AddParameter(cmd, "Status", (object)(value.Status));
				
					// FlgTop
				if (value.IsFlgTopNull)
					AddParameter(cmd, "FlgTop", DBNull.Value);
				else
					AddParameter(cmd, "FlgTop", (object)(value.FlgTop));
				
					// FlgHome
				if (value.IsFlgHomeNull)
					AddParameter(cmd, "FlgHome", DBNull.Value);
				else
					AddParameter(cmd, "FlgHome", (object)(value.FlgHome));
				
						AddParameter(cmd, "ID", value.ID);
						value.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["ID"]);
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
	/// Deletes the specified object from the <c>tblTravelReport</c> table.
	/// </summary>
	/// <param name="value">The <see cref="tblTravelReportRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(tblTravelReportRow value)
	{
		return DeleteByPrimaryKey(value.ID);
	}

	/// <summary>
	/// Deletes a record from the <c>tblTravelReport</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="id">The <c>ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int id)
	{
		string LOCATION = "DeleteByPrimaryKey(int id)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("tblTravelReport_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "ID", id);
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
	/// Deletes <c>tblTravelReport</c> records that match the specified criteria.
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
	/// to delete <c>tblTravelReport</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("tblTravelReport_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>tblTravelReport</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("tblTravelReport_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="tblTravelReportRow"/> objects.</returns>
	protected tblTravelReportRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="tblTravelReportRow"/> objects.</returns>
	protected tblTravelReportRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="tblTravelReportRow"/> objects.</returns>
	protected virtual tblTravelReportRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ID
		int idColumnIndex = reader.GetOrdinal("ID");
		// Title
		int titleColumnIndex = reader.GetOrdinal("Title");
		// Summary
		int summaryColumnIndex = reader.GetOrdinal("Summary");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// ImageFile
		int imageFileColumnIndex = reader.GetOrdinal("ImageFile");
		// BannerFile
		int bannerFileColumnIndex = reader.GetOrdinal("BannerFile");
		// RegDate
		int regDateColumnIndex = reader.GetOrdinal("RegDate");
		// SeoTitle
		int seoTitleColumnIndex = reader.GetOrdinal("SeoTitle");
		// SeoKeyword
		int seoKeywordColumnIndex = reader.GetOrdinal("SeoKeyword");
		// SeoDescription
		int seoDescriptionColumnIndex = reader.GetOrdinal("SeoDescription");
		// Status
		int statusColumnIndex = reader.GetOrdinal("Status");
		// FlgTop
		int flgTopColumnIndex = reader.GetOrdinal("FlgTop");
		// FlgHome
		int flgHomeColumnIndex = reader.GetOrdinal("FlgHome");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				tblTravelReportRow record = new tblTravelReportRow();
				recordList.Add(record);

					record.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
					if(!reader.IsDBNull(titleColumnIndex))
						record.Title = Convert.ToString(reader.GetValue(titleColumnIndex));
					if(!reader.IsDBNull(summaryColumnIndex))
						record.Summary = Convert.ToString(reader.GetValue(summaryColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(imageFileColumnIndex))
						record.ImageFile = Convert.ToString(reader.GetValue(imageFileColumnIndex));
					if(!reader.IsDBNull(bannerFileColumnIndex))
						record.BannerFile = Convert.ToString(reader.GetValue(bannerFileColumnIndex));
					if(!reader.IsDBNull(regDateColumnIndex))
						record.RegDate = Convert.ToDateTime(reader.GetValue(regDateColumnIndex));
					if(!reader.IsDBNull(seoTitleColumnIndex))
						record.SeoTitle = Convert.ToString(reader.GetValue(seoTitleColumnIndex));
					if(!reader.IsDBNull(seoKeywordColumnIndex))
						record.SeoKeyword = Convert.ToString(reader.GetValue(seoKeywordColumnIndex));
					if(!reader.IsDBNull(seoDescriptionColumnIndex))
						record.SeoDescription = Convert.ToString(reader.GetValue(seoDescriptionColumnIndex));
					if(!reader.IsDBNull(statusColumnIndex))
						record.Status = Convert.ToInt32(reader.GetValue(statusColumnIndex));
					if(!reader.IsDBNull(flgTopColumnIndex))
						record.FlgTop = Convert.ToInt32(reader.GetValue(flgTopColumnIndex));
					if(!reader.IsDBNull(flgHomeColumnIndex))
						record.FlgHome = Convert.ToInt32(reader.GetValue(flgHomeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (tblTravelReportRow[])(recordList.ToArray(typeof(tblTravelReportRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblTravelReportRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="tblTravelReportRow"/> object.</returns>
	protected virtual tblTravelReportRow MapRow(DataRow row)
	{
		string LOCATION = "tblTravelReportRow MapRow(DataRow row)";
		tblTravelReportRow mappedObject = new tblTravelReportRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ID"
		dataColumn = dataTable.Columns["ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ID = (int)(row[dataColumn]);
		// Column "Title"
		dataColumn = dataTable.Columns["Title"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Title = (string)(row[dataColumn]);
		// Column "Summary"
		dataColumn = dataTable.Columns["Summary"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Summary = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "ImageFile"
		dataColumn = dataTable.Columns["ImageFile"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ImageFile = (string)(row[dataColumn]);
		// Column "BannerFile"
		dataColumn = dataTable.Columns["BannerFile"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BannerFile = (string)(row[dataColumn]);
		// Column "RegDate"
		dataColumn = dataTable.Columns["RegDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.RegDate = (System.DateTime)(row[dataColumn]);
		// Column "SeoTitle"
		dataColumn = dataTable.Columns["SeoTitle"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SeoTitle = (string)(row[dataColumn]);
		// Column "SeoKeyword"
		dataColumn = dataTable.Columns["SeoKeyword"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SeoKeyword = (string)(row[dataColumn]);
		// Column "SeoDescription"
		dataColumn = dataTable.Columns["SeoDescription"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SeoDescription = (string)(row[dataColumn]);
		// Column "Status"
		dataColumn = dataTable.Columns["Status"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Status = (int)(row[dataColumn]);
		// Column "FlgTop"
		dataColumn = dataTable.Columns["FlgTop"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FlgTop = (int)(row[dataColumn]);
		// Column "FlgHome"
		dataColumn = dataTable.Columns["FlgHome"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FlgHome = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>tblTravelReport</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "tblTravelReport";
		DataColumn dataColumn;
		// Create the "ID" column
		dataColumn = dataTable.Columns.Add("ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Title" column
		dataColumn = dataTable.Columns.Add("Title", typeof(string));
		dataColumn.MaxLength = 255;
		// Create the "Summary" column
		dataColumn = dataTable.Columns.Add("Summary", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ImageFile" column
		dataColumn = dataTable.Columns.Add("ImageFile", typeof(string));
		dataColumn.MaxLength = 255;
		// Create the "BannerFile" column
		dataColumn = dataTable.Columns.Add("BannerFile", typeof(string));
		dataColumn.MaxLength = 255;
		// Create the "RegDate" column
		dataColumn = dataTable.Columns.Add("RegDate", typeof(System.DateTime));
		// Create the "SeoTitle" column
		dataColumn = dataTable.Columns.Add("SeoTitle", typeof(string));
		dataColumn.MaxLength = 1500;
		// Create the "SeoKeyword" column
		dataColumn = dataTable.Columns.Add("SeoKeyword", typeof(string));
		dataColumn.MaxLength = 1500;
		// Create the "SeoDescription" column
		dataColumn = dataTable.Columns.Add("SeoDescription", typeof(string));
		dataColumn.MaxLength = 1500;
		// Create the "Status" column
		dataColumn = dataTable.Columns.Add("Status", typeof(int));
		// Create the "FlgTop" column
		dataColumn = dataTable.Columns.Add("FlgTop", typeof(int));
		// Create the "FlgHome" column
		dataColumn = dataTable.Columns.Add("FlgHome", typeof(int));
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
			case "ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Title":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Summary":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ImageFile":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "BannerFile":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "RegDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "SeoTitle":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SeoKeyword":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SeoDescription":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Status":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FlgTop":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FlgHome":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="tblTravelReportRow"/> by the primary key.
	/// </summary>
	/// <param name="id">The <c>ID</c> column value.</param>
	/// <returns>An instance of <see cref="tblTravelReportRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int id)
	{
		string LOCATION = "Exist(int id)";
		IDbCommand cmd = _db.CreateCommand("tblTravelReport_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "ID", id);
		tblTravelReportRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




