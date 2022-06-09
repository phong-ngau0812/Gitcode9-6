
// <fileinfo name="Base\ProductCategoryCollectionBase.cs">
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
/// The base class for <see cref="ProductCategoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductCategoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductCategoryCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string ProductCategory_IDColumnName  = "ProductCategory_ID";
	public const string Parent_IDColumnName  = "Parent_ID";
	public const string Language_IDColumnName  = "Language_ID";
	public const string NameColumnName  = "Name";
	public const string URLColumnName  = "URL";
	public const string ImageColumnName  = "Image";
	public const string DescriptionColumnName  = "Description";
	public const string SortColumnName  = "Sort";
	public const string CounterColumnName  = "Counter";
	public const string DisplayMenuColumnName  = "DisplayMenu";
	public const string ActiveColumnName  = "Active";
	public const string CanDeleteColumnName  = "CanDelete";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditedByColumnName  = "LastEditedBy";
	public const string LastEditedDateColumnName  = "LastEditedDate";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductCategoryCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "ProductCategory";
	}

	public ProductCategoryCollectionBase() : base()
	{
		this.TABLENAME = "ProductCategory";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>ProductCategory</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	public virtual ProductCategoryRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>ProductCategory</c> table.
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
	/// to retrieve all records from the <c>ProductCategory</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("ProductCategory_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductCategoryRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductCategoryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductCategoryRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductCategoryRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="ProductCategoryRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	public ProductCategoryRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="ProductCategoryRow"/> objects that 
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
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	public virtual ProductCategoryRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductCategoryRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("ProductCategory_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("ProductCategory_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="ProductCategoryRow"/> by the primary key.
	/// </summary>
	/// <param name="productCategory_ID">The <c>ProductCategory_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductCategoryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual ProductCategoryRow GetByPrimaryKey(int productCategory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productCategory_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("ProductCategory_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "ProductCategory_ID", productCategory_ID);
			ProductCategoryRow[] tempArray = MapRecords(cmd);
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
	/// Gets an array of <see cref="ProductCategoryRow"/> objects 
	/// by the <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	public ProductCategoryRow[] GetByLanguage_ID(int language_ID)
	{
		return GetByLanguage_ID(language_ID, false);
	}

	/// <summary>
	/// Gets an array of <see cref="ProductCategoryRow"/> objects 
	/// by the <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <param name="language_IDNull">true if the method ignores the language_ID
	/// parameter value and uses DbNull instead of it; otherwise, false.</param>
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	public virtual ProductCategoryRow[] GetByLanguage_ID(int language_ID, bool language_IDNull)
	{
		return MapRecords(CreateGetByLanguage_IDCommand(language_ID, language_IDNull));
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object 
	/// by the <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public DataTable GetByLanguage_IDAsDataTable(int language_ID)
	{
		return GetByLanguage_IDAsDataTable(language_ID, false);
	}
	

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object 
	/// by the <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <param name="language_IDNull">true if the method ignores the language_ID
	/// parameter value and uses DbNull instead of it; otherwise, false.</param>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	public virtual DataTable GetByLanguage_IDAsDataTable(int language_ID, bool language_IDNull)
	{
		return MapRecordsToDataTable(CreateGetByLanguage_IDCommand(language_ID, language_IDNull));
	}
	

	/// <summary>
	/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
	/// return records by the <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <param name="language_IDNull">true if the method ignores the language_ID
	/// parameter value and uses DbNull instead of it; otherwise, false.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetByLanguage_IDCommand(int language_ID, bool language_IDNull)
	{
		string LOCATION = "";
		IDbCommand cmd = _db.CreateCommand("ProductCategory_GetBy_Language_ID", CommandType.StoredProcedure);
		if (language_IDNull)
			AddParameter(cmd, "Language_ID", null);
		else
			AddParameter(cmd, "Language_ID", language_ID);
		
		return cmd;
	}

	/// <summary>
	/// Adds a new record into the <c>ProductCategory</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductCategoryRow"/> object to be inserted.</param>
	public virtual void Insert(ProductCategoryRow value)
	{
		string LOCATION = "Insert(ProductCategoryRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductCategory_Insert", CommandType.StoredProcedure);
					// Parent_ID
			if (value.IsParent_IDNull)
				AddParameter(cmd, "Parent_ID", DBNull.Value);
			else
				AddParameter(cmd, "Parent_ID", value.Parent_ID);
			
				// Language_ID
			if (value.IsLanguage_IDNull)
				AddParameter(cmd, "Language_ID", DBNull.Value);
			else
				AddParameter(cmd, "Language_ID", value.Language_ID);
			
				// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// URL
			if (value.IsURLNull )
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
			
				// Image
			if (value.IsImageNull )
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
			
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
			
				// Counter
			if (value.IsCounterNull)
				AddParameter(cmd, "Counter", DBNull.Value);
			else
				AddParameter(cmd, "Counter", value.Counter);
			
				// DisplayMenu
			if (value.IsDisplayMenuNull)
				AddParameter(cmd, "DisplayMenu", DBNull.Value);
			else
				AddParameter(cmd, "DisplayMenu", value.DisplayMenu);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// CanDelete
			if (value.IsCanDeleteNull)
				AddParameter(cmd, "CanDelete", DBNull.Value);
			else
				AddParameter(cmd, "CanDelete", value.CanDelete);
			
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
			
						value.ProductCategory_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>ProductCategory</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductCategoryRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(ProductCategoryRow value)
	{	
		string LOCATION = "Update(ProductCategoryRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductCategory_Update", CommandType.StoredProcedure);
					// Parent_ID
			if (value.IsParent_IDNull)
				AddParameter(cmd, "Parent_ID", DBNull.Value);
			else
				AddParameter(cmd, "Parent_ID", value.Parent_ID);
			
				// Language_ID
			if (value.IsLanguage_IDNull)
				AddParameter(cmd, "Language_ID", DBNull.Value);
			else
				AddParameter(cmd, "Language_ID", value.Language_ID);
			
				// Name
			if (value.IsNameNull)
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
				// URL
			if (value.IsURLNull)
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
				// Image
			if (value.IsImageNull)
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
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
			
				// Counter
			if (value.IsCounterNull)
				AddParameter(cmd, "Counter", DBNull.Value);
			else
				AddParameter(cmd, "Counter", value.Counter);
			
				// DisplayMenu
			if (value.IsDisplayMenuNull)
				AddParameter(cmd, "DisplayMenu", DBNull.Value);
			else
				AddParameter(cmd, "DisplayMenu", value.DisplayMenu);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// CanDelete
			if (value.IsCanDeleteNull)
				AddParameter(cmd, "CanDelete", DBNull.Value);
			else
				AddParameter(cmd, "CanDelete", value.CanDelete);
			
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
			
					AddParameter(cmd, "ProductCategory_ID", value.ProductCategory_ID);
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
		/// Inserts or Updates a record in the <c>ProductCategory</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="ProductCategoryRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(ProductCategoryRow value)
		{
			string LOCATION = "Save(ProductCategoryRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("ProductCategory_Save",CommandType.StoredProcedure);
					// Parent_ID
				if (value.IsParent_IDNull)
					AddParameter(cmd, "Parent_ID", DBNull.Value);
				else
					AddParameter(cmd, "Parent_ID", (object)(value.Parent_ID));
				
					// Language_ID
				if (value.IsLanguage_IDNull)
					AddParameter(cmd, "Language_ID", DBNull.Value);
				else
					AddParameter(cmd, "Language_ID", (object)(value.Language_ID));
				
					// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", (object)(value.Name));
				
					// URL
				if (value.IsURLNull)
					AddParameter(cmd, "URL", DBNull.Value);
				else
					AddParameter(cmd, "URL", (object)(value.URL));
				
					// Image
				if (value.IsImageNull)
					AddParameter(cmd, "Image", DBNull.Value);
				else
					AddParameter(cmd, "Image", (object)(value.Image));
				
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
				
					// Counter
				if (value.IsCounterNull)
					AddParameter(cmd, "Counter", DBNull.Value);
				else
					AddParameter(cmd, "Counter", (object)(value.Counter));
				
					// DisplayMenu
				if (value.IsDisplayMenuNull)
					AddParameter(cmd, "DisplayMenu", DBNull.Value);
				else
					AddParameter(cmd, "DisplayMenu", (object)(value.DisplayMenu));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// CanDelete
				if (value.IsCanDeleteNull)
					AddParameter(cmd, "CanDelete", DBNull.Value);
				else
					AddParameter(cmd, "CanDelete", (object)(value.CanDelete));
				
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
				
						AddParameter(cmd, "ProductCategory_ID", value.ProductCategory_ID);
						value.ProductCategory_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["ProductCategory_ID"]);
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
	/// Deletes the specified object from the <c>ProductCategory</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductCategoryRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(ProductCategoryRow value)
	{
		return DeleteByPrimaryKey(value.ProductCategory_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>ProductCategory</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="productCategory_ID">The <c>ProductCategory_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int productCategory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productCategory_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductCategory_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "ProductCategory_ID", productCategory_ID);
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
	/// Deletes records from the <c>ProductCategory</c> table using the 
	/// <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <returns>The number of records deleted from the table.</returns>
	public int DeleteByLanguage_ID(int language_ID)
	{
		return DeleteByLanguage_ID(language_ID, false);
	}

	/// <summary>
	/// Deletes records from the <c>ProductCategory</c> table using the 
	/// <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <param name="language_IDNull">true if the method ignores the language_ID
	/// parameter value and uses DbNull instead of it; otherwise, false.</param>
	/// <returns>The number of records deleted from the table.</returns>
	public int DeleteByLanguage_ID(int language_ID, bool language_IDNull)
	{
		string LOCATION = "DeleteByLanguage_ID(int language_ID, bool language_IDNull)";	
		try
		{
			return CreateDeleteByLanguage_IDCommand(language_ID, language_IDNull).ExecuteNonQuery();
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
	/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
	/// delete records using the <c>FK_ProductCategory_Language</c> foreign key.
	/// </summary>
	/// <param name="language_ID">The <c>Language_ID</c> column value.</param>
	/// <param name="language_IDNull">true if the method ignores the language_ID
	/// parameter value and uses DbNull instead of it; otherwise, false.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	public virtual IDbCommand CreateDeleteByLanguage_IDCommand(int language_ID, bool language_IDNull)
	{
		string LOCATION = "CreateDeleteByLanguage_IDCommand(int language_ID, bool language_IDNull)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductCategory_DeleteBy_Language_ID", CommandType.StoredProcedure);
			if (language_IDNull)
				AddParameter(cmd, "Language_ID", null);
			else
				AddParameter(cmd, "Language_ID", language_ID);
		
			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 
		
	}

	/// <summary>
	/// Deletes <c>ProductCategory</c> records that match the specified criteria.
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
	/// to delete <c>ProductCategory</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductCategory_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>ProductCategory</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("ProductCategory_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	protected ProductCategoryRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	protected ProductCategoryRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="ProductCategoryRow"/> objects.</returns>
	protected virtual ProductCategoryRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ProductCategory_ID
		int productCategory_IDColumnIndex = reader.GetOrdinal("ProductCategory_ID");
		// Parent_ID
		int parent_IDColumnIndex = reader.GetOrdinal("Parent_ID");
		// Language_ID
		int language_IDColumnIndex = reader.GetOrdinal("Language_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// URL
		int urlColumnIndex = reader.GetOrdinal("URL");
		// Image
		int imageColumnIndex = reader.GetOrdinal("Image");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");
		// Counter
		int counterColumnIndex = reader.GetOrdinal("Counter");
		// DisplayMenu
		int displayMenuColumnIndex = reader.GetOrdinal("DisplayMenu");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// CanDelete
		int canDeleteColumnIndex = reader.GetOrdinal("CanDelete");
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
				ProductCategoryRow record = new ProductCategoryRow();
				recordList.Add(record);

					record.ProductCategory_ID = Convert.ToInt32(reader.GetValue(productCategory_IDColumnIndex));
					if(!reader.IsDBNull(parent_IDColumnIndex))
						record.Parent_ID = Convert.ToInt32(reader.GetValue(parent_IDColumnIndex));
					if(!reader.IsDBNull(language_IDColumnIndex))
						record.Language_ID = Convert.ToInt32(reader.GetValue(language_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(urlColumnIndex))
						record.URL = Convert.ToString(reader.GetValue(urlColumnIndex));
					if(!reader.IsDBNull(imageColumnIndex))
						record.Image = Convert.ToString(reader.GetValue(imageColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(sortColumnIndex))
						record.Sort = Convert.ToInt32(reader.GetValue(sortColumnIndex));
					if(!reader.IsDBNull(counterColumnIndex))
						record.Counter = Convert.ToInt32(reader.GetValue(counterColumnIndex));
					if(!reader.IsDBNull(displayMenuColumnIndex))
						record.DisplayMenu = Convert.ToBoolean(reader.GetValue(displayMenuColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(canDeleteColumnIndex))
						record.CanDelete = Convert.ToBoolean(reader.GetValue(canDeleteColumnIndex));
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

		return (ProductCategoryRow[])(recordList.ToArray(typeof(ProductCategoryRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductCategoryRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductCategoryRow"/> object.</returns>
	protected virtual ProductCategoryRow MapRow(DataRow row)
	{
		string LOCATION = "ProductCategoryRow MapRow(DataRow row)";
		ProductCategoryRow mappedObject = new ProductCategoryRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ProductCategory_ID"
		dataColumn = dataTable.Columns["ProductCategory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductCategory_ID = (int)(row[dataColumn]);
		// Column "Parent_ID"
		dataColumn = dataTable.Columns["Parent_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Parent_ID = (int)(row[dataColumn]);
		// Column "Language_ID"
		dataColumn = dataTable.Columns["Language_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Language_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "URL"
		dataColumn = dataTable.Columns["URL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.URL = (string)(row[dataColumn]);
		// Column "Image"
		dataColumn = dataTable.Columns["Image"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Image = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
		// Column "Counter"
		dataColumn = dataTable.Columns["Counter"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Counter = (int)(row[dataColumn]);
		// Column "DisplayMenu"
		dataColumn = dataTable.Columns["DisplayMenu"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DisplayMenu = (bool)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
		// Column "CanDelete"
		dataColumn = dataTable.Columns["CanDelete"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CanDelete = (bool)(row[dataColumn]);
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
	/// the <c>ProductCategory</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "ProductCategory";
		DataColumn dataColumn;
		// Create the "ProductCategory_ID" column
		dataColumn = dataTable.Columns.Add("ProductCategory_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Parent_ID" column
		dataColumn = dataTable.Columns.Add("Parent_ID", typeof(int));
		// Create the "Language_ID" column
		dataColumn = dataTable.Columns.Add("Language_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "URL" column
		dataColumn = dataTable.Columns.Add("URL", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Image" column
		dataColumn = dataTable.Columns.Add("Image", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Sort" column
		dataColumn = dataTable.Columns.Add("Sort", typeof(int));
		// Create the "Counter" column
		dataColumn = dataTable.Columns.Add("Counter", typeof(int));
		// Create the "DisplayMenu" column
		dataColumn = dataTable.Columns.Add("DisplayMenu", typeof(bool));
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "CanDelete" column
		dataColumn = dataTable.Columns.Add("CanDelete", typeof(bool));
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
			case "ProductCategory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Parent_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Language_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "URL":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Image":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Sort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Counter":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DisplayMenu":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "CanDelete":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
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
	/// Exist <see cref="ProductCategoryRow"/> by the primary key.
	/// </summary>
	/// <param name="productCategory_ID">The <c>ProductCategory_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductCategoryRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int productCategory_ID)
	{
		string LOCATION = "Exist(int productCategory_ID)";
		IDbCommand cmd = _db.CreateCommand("ProductCategory_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "ProductCategory_ID", productCategory_ID);
		ProductCategoryRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




