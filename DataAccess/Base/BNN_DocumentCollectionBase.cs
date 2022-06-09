
// <fileinfo name="Base\BNN_DocumentCollectionBase.cs">
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
/// The base class for <see cref="BNN_DocumentCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_DocumentCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_DocumentCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Document_IDColumnName  = "Document_ID";
	public const string DocumentCategory_IDColumnName  = "DocumentCategory_ID";
	public const string TitleColumnName  = "Title";
	public const string SummaryColumnName  = "Summary";
	public const string DescriptionColumnName  = "Description";
	public const string ImageColumnName  = "Image";
	public const string TagColumnName  = "Tag";
	public const string ViewColumnName  = "View";
	public const string IsHotColumnName  = "IsHot";
	public const string IsHomeColumnName  = "IsHome";
	public const string AuthorColumnName  = "Author";
	public const string SourceColumnName  = "Source";
	public const string ActiveColumnName  = "Active";
	public const string SortColumnName  = "Sort";
	public const string SeoTitleColumnName  = "SeoTitle";
	public const string SeoKeywordColumnName  = "SeoKeyword";
	public const string SeoDescriptionColumnName  = "SeoDescription";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string Location_IDColumnName  = "Location_ID";
	public const string District_IDColumnName  = "District_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public BNN_DocumentCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "BNN_Document";
	}

	public BNN_DocumentCollectionBase() : base()
	{
		this.TABLENAME = "BNN_Document";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>BNN_Document</c> table.
	/// </summary>
	/// <returns>An array of <see cref="BNN_DocumentRow"/> objects.</returns>
	public virtual BNN_DocumentRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>BNN_Document</c> table.
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
	/// to retrieve all records from the <c>BNN_Document</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("BNN_Document_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="BNN_DocumentRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="BNN_DocumentRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public BNN_DocumentRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			BNN_DocumentRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="BNN_DocumentRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="BNN_DocumentRow"/> objects.</returns>
	public BNN_DocumentRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="BNN_DocumentRow"/> objects that 
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
	/// <returns>An array of <see cref="BNN_DocumentRow"/> objects.</returns>
	public virtual BNN_DocumentRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			BNN_DocumentRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("BNN_Document_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("BNN_Document_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="BNN_DocumentRow"/> by the primary key.
	/// </summary>
	/// <param name="document_ID">The <c>Document_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BNN_DocumentRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual BNN_DocumentRow GetByPrimaryKey(int document_ID)
	{
		string LOCATION = "GetByPrimaryKey(int document_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("BNN_Document_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Document_ID", document_ID);
			BNN_DocumentRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>BNN_Document</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_DocumentRow"/> object to be inserted.</param>
	public virtual void Insert(BNN_DocumentRow value)
	{
		string LOCATION = "Insert(BNN_DocumentRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Document_Insert", CommandType.StoredProcedure);
					// DocumentCategory_ID
			if (value.IsDocumentCategory_IDNull)
				AddParameter(cmd, "DocumentCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "DocumentCategory_ID", value.DocumentCategory_ID);
			
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
			
				// Image
			if (value.IsImageNull )
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
			
				// Tag
			if (value.IsTagNull )
				AddParameter(cmd, "Tag", DBNull.Value);
			else
				AddParameter(cmd, "Tag", value.Tag);
			
				// View
			if (value.IsViewNull)
				AddParameter(cmd, "View", DBNull.Value);
			else
				AddParameter(cmd, "View", value.View);
			
				// IsHot
			if (value.IsIsHotNull)
				AddParameter(cmd, "IsHot", DBNull.Value);
			else
				AddParameter(cmd, "IsHot", value.IsHot);
			
				// IsHome
			if (value.IsIsHomeNull)
				AddParameter(cmd, "IsHome", DBNull.Value);
			else
				AddParameter(cmd, "IsHome", value.IsHome);
			
				// Author
			if (value.IsAuthorNull )
				AddParameter(cmd, "Author", DBNull.Value);
			else
				AddParameter(cmd, "Author", value.Author);
			
				// Source
			if (value.IsSourceNull )
				AddParameter(cmd, "Source", DBNull.Value);
			else
				AddParameter(cmd, "Source", value.Source);
			
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
			
						value.Document_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>BNN_Document</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_DocumentRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(BNN_DocumentRow value)
	{	
		string LOCATION = "Update(BNN_DocumentRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Document_Update", CommandType.StoredProcedure);
					// DocumentCategory_ID
			if (value.IsDocumentCategory_IDNull)
				AddParameter(cmd, "DocumentCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "DocumentCategory_ID", value.DocumentCategory_ID);
			
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
				// Image
			if (value.IsImageNull)
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
				// Tag
			if (value.IsTagNull)
				AddParameter(cmd, "Tag", DBNull.Value);
			else
				AddParameter(cmd, "Tag", value.Tag);
				// View
			if (value.IsViewNull)
				AddParameter(cmd, "View", DBNull.Value);
			else
				AddParameter(cmd, "View", value.View);
			
				// IsHot
			if (value.IsIsHotNull)
				AddParameter(cmd, "IsHot", DBNull.Value);
			else
				AddParameter(cmd, "IsHot", value.IsHot);
			
				// IsHome
			if (value.IsIsHomeNull)
				AddParameter(cmd, "IsHome", DBNull.Value);
			else
				AddParameter(cmd, "IsHome", value.IsHome);
			
				// Author
			if (value.IsAuthorNull)
				AddParameter(cmd, "Author", DBNull.Value);
			else
				AddParameter(cmd, "Author", value.Author);
				// Source
			if (value.IsSourceNull)
				AddParameter(cmd, "Source", DBNull.Value);
			else
				AddParameter(cmd, "Source", value.Source);
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
			
					AddParameter(cmd, "Document_ID", value.Document_ID);
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
		/// Inserts or Updates a record in the <c>BNN_Document</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="BNN_DocumentRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(BNN_DocumentRow value)
		{
			string LOCATION = "Save(BNN_DocumentRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("BNN_Document_Save",CommandType.StoredProcedure);
					// DocumentCategory_ID
				if (value.IsDocumentCategory_IDNull)
					AddParameter(cmd, "DocumentCategory_ID", DBNull.Value);
				else
					AddParameter(cmd, "DocumentCategory_ID", (object)(value.DocumentCategory_ID));
				
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
				
					// Image
				if (value.IsImageNull)
					AddParameter(cmd, "Image", DBNull.Value);
				else
					AddParameter(cmd, "Image", (object)(value.Image));
				
					// Tag
				if (value.IsTagNull)
					AddParameter(cmd, "Tag", DBNull.Value);
				else
					AddParameter(cmd, "Tag", (object)(value.Tag));
				
					// View
				if (value.IsViewNull)
					AddParameter(cmd, "View", DBNull.Value);
				else
					AddParameter(cmd, "View", (object)(value.View));
				
					// IsHot
				if (value.IsIsHotNull)
					AddParameter(cmd, "IsHot", DBNull.Value);
				else
					AddParameter(cmd, "IsHot", (object)(value.IsHot));
				
					// IsHome
				if (value.IsIsHomeNull)
					AddParameter(cmd, "IsHome", DBNull.Value);
				else
					AddParameter(cmd, "IsHome", (object)(value.IsHome));
				
					// Author
				if (value.IsAuthorNull)
					AddParameter(cmd, "Author", DBNull.Value);
				else
					AddParameter(cmd, "Author", (object)(value.Author));
				
					// Source
				if (value.IsSourceNull)
					AddParameter(cmd, "Source", DBNull.Value);
				else
					AddParameter(cmd, "Source", (object)(value.Source));
				
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
				
						AddParameter(cmd, "Document_ID", value.Document_ID);
						value.Document_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Document_ID"]);
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
	/// Deletes the specified object from the <c>BNN_Document</c> table.
	/// </summary>
	/// <param name="value">The <see cref="BNN_DocumentRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(BNN_DocumentRow value)
	{
		return DeleteByPrimaryKey(value.Document_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>BNN_Document</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="document_ID">The <c>Document_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int document_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int document_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("BNN_Document_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Document_ID", document_ID);
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
	/// Deletes <c>BNN_Document</c> records that match the specified criteria.
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
	/// to delete <c>BNN_Document</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("BNN_Document_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>BNN_Document</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("BNN_Document_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="BNN_DocumentRow"/> objects.</returns>
	protected BNN_DocumentRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="BNN_DocumentRow"/> objects.</returns>
	protected BNN_DocumentRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="BNN_DocumentRow"/> objects.</returns>
	protected virtual BNN_DocumentRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Document_ID
		int document_IDColumnIndex = reader.GetOrdinal("Document_ID");
		// DocumentCategory_ID
		int documentCategory_IDColumnIndex = reader.GetOrdinal("DocumentCategory_ID");
		// Title
		int titleColumnIndex = reader.GetOrdinal("Title");
		// Summary
		int summaryColumnIndex = reader.GetOrdinal("Summary");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Image
		int imageColumnIndex = reader.GetOrdinal("Image");
		// Tag
		int tagColumnIndex = reader.GetOrdinal("Tag");
		// View
		int viewColumnIndex = reader.GetOrdinal("View");
		// IsHot
		int isHotColumnIndex = reader.GetOrdinal("IsHot");
		// IsHome
		int isHomeColumnIndex = reader.GetOrdinal("IsHome");
		// Author
		int authorColumnIndex = reader.GetOrdinal("Author");
		// Source
		int sourceColumnIndex = reader.GetOrdinal("Source");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");
		// SeoTitle
		int seoTitleColumnIndex = reader.GetOrdinal("SeoTitle");
		// SeoKeyword
		int seoKeywordColumnIndex = reader.GetOrdinal("SeoKeyword");
		// SeoDescription
		int seoDescriptionColumnIndex = reader.GetOrdinal("SeoDescription");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
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
				BNN_DocumentRow record = new BNN_DocumentRow();
				recordList.Add(record);

					record.Document_ID = Convert.ToInt32(reader.GetValue(document_IDColumnIndex));
					if(!reader.IsDBNull(documentCategory_IDColumnIndex))
						record.DocumentCategory_ID = Convert.ToInt32(reader.GetValue(documentCategory_IDColumnIndex));
					if(!reader.IsDBNull(titleColumnIndex))
						record.Title = Convert.ToString(reader.GetValue(titleColumnIndex));
					if(!reader.IsDBNull(summaryColumnIndex))
						record.Summary = Convert.ToString(reader.GetValue(summaryColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(imageColumnIndex))
						record.Image = Convert.ToString(reader.GetValue(imageColumnIndex));
					if(!reader.IsDBNull(tagColumnIndex))
						record.Tag = Convert.ToString(reader.GetValue(tagColumnIndex));
					if(!reader.IsDBNull(viewColumnIndex))
						record.View = Convert.ToInt32(reader.GetValue(viewColumnIndex));
					if(!reader.IsDBNull(isHotColumnIndex))
						record.IsHot = Convert.ToInt32(reader.GetValue(isHotColumnIndex));
					if(!reader.IsDBNull(isHomeColumnIndex))
						record.IsHome = Convert.ToInt32(reader.GetValue(isHomeColumnIndex));
					if(!reader.IsDBNull(authorColumnIndex))
						record.Author = Convert.ToString(reader.GetValue(authorColumnIndex));
					if(!reader.IsDBNull(sourceColumnIndex))
						record.Source = Convert.ToString(reader.GetValue(sourceColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(sortColumnIndex))
						record.Sort = Convert.ToInt32(reader.GetValue(sortColumnIndex));
					if(!reader.IsDBNull(seoTitleColumnIndex))
						record.SeoTitle = Convert.ToString(reader.GetValue(seoTitleColumnIndex));
					if(!reader.IsDBNull(seoKeywordColumnIndex))
						record.SeoKeyword = Convert.ToString(reader.GetValue(seoKeywordColumnIndex));
					if(!reader.IsDBNull(seoDescriptionColumnIndex))
						record.SeoDescription = Convert.ToString(reader.GetValue(seoDescriptionColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
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

		return (BNN_DocumentRow[])(recordList.ToArray(typeof(BNN_DocumentRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="BNN_DocumentRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="BNN_DocumentRow"/> object.</returns>
	protected virtual BNN_DocumentRow MapRow(DataRow row)
	{
		string LOCATION = "BNN_DocumentRow MapRow(DataRow row)";
		BNN_DocumentRow mappedObject = new BNN_DocumentRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Document_ID"
		dataColumn = dataTable.Columns["Document_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Document_ID = (int)(row[dataColumn]);
		// Column "DocumentCategory_ID"
		dataColumn = dataTable.Columns["DocumentCategory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DocumentCategory_ID = (int)(row[dataColumn]);
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
		// Column "Image"
		dataColumn = dataTable.Columns["Image"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Image = (string)(row[dataColumn]);
		// Column "Tag"
		dataColumn = dataTable.Columns["Tag"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Tag = (string)(row[dataColumn]);
		// Column "View"
		dataColumn = dataTable.Columns["View"];
		if (! row.IsNull(dataColumn) )
			mappedObject.View = (int)(row[dataColumn]);
		// Column "IsHot"
		dataColumn = dataTable.Columns["IsHot"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsHot = (int)(row[dataColumn]);
		// Column "IsHome"
		dataColumn = dataTable.Columns["IsHome"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsHome = (int)(row[dataColumn]);
		// Column "Author"
		dataColumn = dataTable.Columns["Author"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Author = (string)(row[dataColumn]);
		// Column "Source"
		dataColumn = dataTable.Columns["Source"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Source = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (int)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
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
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditDate"
		dataColumn = dataTable.Columns["LastEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
		// Column "LastEditBy"
		dataColumn = dataTable.Columns["LastEditBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
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
	/// the <c>BNN_Document</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "BNN_Document";
		DataColumn dataColumn;
		// Create the "Document_ID" column
		dataColumn = dataTable.Columns.Add("Document_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "DocumentCategory_ID" column
		dataColumn = dataTable.Columns.Add("DocumentCategory_ID", typeof(int));
		// Create the "Title" column
		dataColumn = dataTable.Columns.Add("Title", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Summary" column
		dataColumn = dataTable.Columns.Add("Summary", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Image" column
		dataColumn = dataTable.Columns.Add("Image", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Tag" column
		dataColumn = dataTable.Columns.Add("Tag", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "View" column
		dataColumn = dataTable.Columns.Add("View", typeof(int));
		// Create the "IsHot" column
		dataColumn = dataTable.Columns.Add("IsHot", typeof(int));
		// Create the "IsHome" column
		dataColumn = dataTable.Columns.Add("IsHome", typeof(int));
		// Create the "Author" column
		dataColumn = dataTable.Columns.Add("Author", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Source" column
		dataColumn = dataTable.Columns.Add("Source", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(int));
		// Create the "Sort" column
		dataColumn = dataTable.Columns.Add("Sort", typeof(int));
		// Create the "SeoTitle" column
		dataColumn = dataTable.Columns.Add("SeoTitle", typeof(string));
		dataColumn.MaxLength = 1500;
		// Create the "SeoKeyword" column
		dataColumn = dataTable.Columns.Add("SeoKeyword", typeof(string));
		dataColumn.MaxLength = 1500;
		// Create the "SeoDescription" column
		dataColumn = dataTable.Columns.Add("SeoDescription", typeof(string));
		dataColumn.MaxLength = 1500;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
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
			case "Document_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DocumentCategory_ID":
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

			case "Image":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Tag":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "View":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IsHot":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IsHome":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Author":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Source":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Sort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
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

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "LastEditBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
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
	/// Exist <see cref="BNN_DocumentRow"/> by the primary key.
	/// </summary>
	/// <param name="document_ID">The <c>Document_ID</c> column value.</param>
	/// <returns>An instance of <see cref="BNN_DocumentRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int document_ID)
	{
		string LOCATION = "Exist(int document_ID)";
		IDbCommand cmd = _db.CreateCommand("BNN_Document_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Document_ID", document_ID);
		BNN_DocumentRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




