
// <fileinfo name="Base\WEB_PromotionCollectionBase.cs">
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
/// The base class for <see cref="WEB_PromotionCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WEB_PromotionCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WEB_PromotionCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Promotion_IDColumnName  = "Promotion_ID";
	public const string TitleColumnName  = "Title";
	public const string DateStartColumnName  = "DateStart";
	public const string DateEndColumnName  = "DateEnd";
	public const string ProductList_IDColumnName  = "ProductList_ID";
	public const string ActiveColumnName  = "Active";
	public const string DescriptionColumnName  = "Description";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string ImageColumnName  = "Image";
	public const string ProductCategory_IDColumnName  = "ProductCategory_ID";
	public const string WarrantyDateColumnName  = "WarrantyDate";
	public const string TypeColumnName  = "Type";
	public const string LinkColumnName  = "Link";
	public const string ProductCategoryChild_IDColumnName  = "ProductCategoryChild_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WEB_PromotionCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WEB_Promotion";
	}

	public WEB_PromotionCollectionBase() : base()
	{
		this.TABLENAME = "WEB_Promotion";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WEB_PromotionRow"/> objects.</returns>
	public virtual WEB_PromotionRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WEB_Promotion</c> table.
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
	/// to retrieve all records from the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WEB_Promotion_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WEB_PromotionRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WEB_PromotionRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WEB_PromotionRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WEB_PromotionRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WEB_PromotionRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WEB_PromotionRow"/> objects.</returns>
	public WEB_PromotionRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WEB_PromotionRow"/> objects that 
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
	/// <returns>An array of <see cref="WEB_PromotionRow"/> objects.</returns>
	public virtual WEB_PromotionRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WEB_PromotionRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WEB_Promotion_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WEB_Promotion_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WEB_PromotionRow"/> by the primary key.
	/// </summary>
	/// <param name="promotion_ID">The <c>Promotion_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WEB_PromotionRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WEB_PromotionRow GetByPrimaryKey(int promotion_ID)
	{
		string LOCATION = "GetByPrimaryKey(int promotion_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WEB_Promotion_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Promotion_ID", promotion_ID);
			WEB_PromotionRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WEB_PromotionRow"/> object to be inserted.</param>
	public virtual void Insert(WEB_PromotionRow value)
	{
		string LOCATION = "Insert(WEB_PromotionRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WEB_Promotion_Insert", CommandType.StoredProcedure);
					// Title
			if (value.IsTitleNull )
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
			
				// DateStart
			if (value.IsDateStartNull)
				AddParameter(cmd, "DateStart", DBNull.Value);
			else
				AddParameter(cmd, "DateStart", value.DateStart);
			
				// DateEnd
			if (value.IsDateEndNull)
				AddParameter(cmd, "DateEnd", DBNull.Value);
			else
				AddParameter(cmd, "DateEnd", value.DateEnd);
			
				// ProductList_ID
			if (value.IsProductList_IDNull )
				AddParameter(cmd, "ProductList_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductList_ID", value.ProductList_ID);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
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
			
				// Image
			if (value.IsImageNull )
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
			
				// ProductCategory_ID
			if (value.IsProductCategory_IDNull )
				AddParameter(cmd, "ProductCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductCategory_ID", value.ProductCategory_ID);
			
				// WarrantyDate
			if (value.IsWarrantyDateNull)
				AddParameter(cmd, "WarrantyDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyDate", value.WarrantyDate);
			
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
				// Link
			if (value.IsLinkNull )
				AddParameter(cmd, "Link", DBNull.Value);
			else
				AddParameter(cmd, "Link", value.Link);
			
				// ProductCategoryChild_ID
			if (value.IsProductCategoryChild_IDNull )
				AddParameter(cmd, "ProductCategoryChild_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductCategoryChild_ID", value.ProductCategoryChild_ID);
			
						value.Promotion_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WEB_PromotionRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WEB_PromotionRow value)
	{	
		string LOCATION = "Update(WEB_PromotionRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WEB_Promotion_Update", CommandType.StoredProcedure);
					// Title
			if (value.IsTitleNull)
				AddParameter(cmd, "Title", DBNull.Value);
			else
				AddParameter(cmd, "Title", value.Title);
				// DateStart
			if (value.IsDateStartNull)
				AddParameter(cmd, "DateStart", DBNull.Value);
			else
				AddParameter(cmd, "DateStart", value.DateStart);
			
				// DateEnd
			if (value.IsDateEndNull)
				AddParameter(cmd, "DateEnd", DBNull.Value);
			else
				AddParameter(cmd, "DateEnd", value.DateEnd);
			
				// ProductList_ID
			if (value.IsProductList_IDNull)
				AddParameter(cmd, "ProductList_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductList_ID", value.ProductList_ID);
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
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
			
				// Image
			if (value.IsImageNull)
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
				// ProductCategory_ID
			if (value.IsProductCategory_IDNull)
				AddParameter(cmd, "ProductCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductCategory_ID", value.ProductCategory_ID);
				// WarrantyDate
			if (value.IsWarrantyDateNull)
				AddParameter(cmd, "WarrantyDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyDate", value.WarrantyDate);
			
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
				// Link
			if (value.IsLinkNull)
				AddParameter(cmd, "Link", DBNull.Value);
			else
				AddParameter(cmd, "Link", value.Link);
				// ProductCategoryChild_ID
			if (value.IsProductCategoryChild_IDNull)
				AddParameter(cmd, "ProductCategoryChild_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductCategoryChild_ID", value.ProductCategoryChild_ID);
					AddParameter(cmd, "Promotion_ID", value.Promotion_ID);
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
		/// Inserts or Updates a record in the <c>WEB_Promotion</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WEB_PromotionRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WEB_PromotionRow value)
		{
			string LOCATION = "Save(WEB_PromotionRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WEB_Promotion_Save",CommandType.StoredProcedure);
					// Title
				if (value.IsTitleNull)
					AddParameter(cmd, "Title", DBNull.Value);
				else
					AddParameter(cmd, "Title", (object)(value.Title));
				
					// DateStart
				if (value.IsDateStartNull)
					AddParameter(cmd, "DateStart", DBNull.Value);
				else
					AddParameter(cmd, "DateStart", (object)(value.DateStart));
				
					// DateEnd
				if (value.IsDateEndNull)
					AddParameter(cmd, "DateEnd", DBNull.Value);
				else
					AddParameter(cmd, "DateEnd", (object)(value.DateEnd));
				
					// ProductList_ID
				if (value.IsProductList_IDNull)
					AddParameter(cmd, "ProductList_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductList_ID", (object)(value.ProductList_ID));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
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
				
					// Image
				if (value.IsImageNull)
					AddParameter(cmd, "Image", DBNull.Value);
				else
					AddParameter(cmd, "Image", (object)(value.Image));
				
					// ProductCategory_ID
				if (value.IsProductCategory_IDNull)
					AddParameter(cmd, "ProductCategory_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductCategory_ID", (object)(value.ProductCategory_ID));
				
					// WarrantyDate
				if (value.IsWarrantyDateNull)
					AddParameter(cmd, "WarrantyDate", DBNull.Value);
				else
					AddParameter(cmd, "WarrantyDate", (object)(value.WarrantyDate));
				
					// Type
				if (value.IsTypeNull)
					AddParameter(cmd, "Type", DBNull.Value);
				else
					AddParameter(cmd, "Type", (object)(value.Type));
				
					// Link
				if (value.IsLinkNull)
					AddParameter(cmd, "Link", DBNull.Value);
				else
					AddParameter(cmd, "Link", (object)(value.Link));
				
					// ProductCategoryChild_ID
				if (value.IsProductCategoryChild_IDNull)
					AddParameter(cmd, "ProductCategoryChild_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductCategoryChild_ID", (object)(value.ProductCategoryChild_ID));
				
						AddParameter(cmd, "Promotion_ID", value.Promotion_ID);
						value.Promotion_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Promotion_ID"]);
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
	/// Deletes the specified object from the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WEB_PromotionRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WEB_PromotionRow value)
	{
		return DeleteByPrimaryKey(value.Promotion_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WEB_Promotion</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="promotion_ID">The <c>Promotion_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int promotion_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int promotion_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WEB_Promotion_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Promotion_ID", promotion_ID);
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
	/// Deletes <c>WEB_Promotion</c> records that match the specified criteria.
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
	/// to delete <c>WEB_Promotion</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WEB_Promotion_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WEB_Promotion_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WEB_PromotionRow"/> objects.</returns>
	protected WEB_PromotionRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WEB_PromotionRow"/> objects.</returns>
	protected WEB_PromotionRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WEB_PromotionRow"/> objects.</returns>
	protected virtual WEB_PromotionRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Promotion_ID
		int promotion_IDColumnIndex = reader.GetOrdinal("Promotion_ID");
		// Title
		int titleColumnIndex = reader.GetOrdinal("Title");
		// DateStart
		int dateStartColumnIndex = reader.GetOrdinal("DateStart");
		// DateEnd
		int dateEndColumnIndex = reader.GetOrdinal("DateEnd");
		// ProductList_ID
		int productList_IDColumnIndex = reader.GetOrdinal("ProductList_ID");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
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
		// Image
		int imageColumnIndex = reader.GetOrdinal("Image");
		// ProductCategory_ID
		int productCategory_IDColumnIndex = reader.GetOrdinal("ProductCategory_ID");
		// WarrantyDate
		int warrantyDateColumnIndex = reader.GetOrdinal("WarrantyDate");
		// Type
		int typeColumnIndex = reader.GetOrdinal("Type");
		// Link
		int linkColumnIndex = reader.GetOrdinal("Link");
		// ProductCategoryChild_ID
		int productCategoryChild_IDColumnIndex = reader.GetOrdinal("ProductCategoryChild_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WEB_PromotionRow record = new WEB_PromotionRow();
				recordList.Add(record);

					record.Promotion_ID = Convert.ToInt32(reader.GetValue(promotion_IDColumnIndex));
					if(!reader.IsDBNull(titleColumnIndex))
						record.Title = Convert.ToString(reader.GetValue(titleColumnIndex));
					if(!reader.IsDBNull(dateStartColumnIndex))
						record.DateStart = Convert.ToDateTime(reader.GetValue(dateStartColumnIndex));
					if(!reader.IsDBNull(dateEndColumnIndex))
						record.DateEnd = Convert.ToDateTime(reader.GetValue(dateEndColumnIndex));
					if(!reader.IsDBNull(productList_IDColumnIndex))
						record.ProductList_ID = Convert.ToString(reader.GetValue(productList_IDColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
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
					if(!reader.IsDBNull(imageColumnIndex))
						record.Image = Convert.ToString(reader.GetValue(imageColumnIndex));
					if(!reader.IsDBNull(productCategory_IDColumnIndex))
						record.ProductCategory_ID = Convert.ToString(reader.GetValue(productCategory_IDColumnIndex));
					if(!reader.IsDBNull(warrantyDateColumnIndex))
						record.WarrantyDate = Convert.ToInt32(reader.GetValue(warrantyDateColumnIndex));
					if(!reader.IsDBNull(typeColumnIndex))
						record.Type = Convert.ToBoolean(reader.GetValue(typeColumnIndex));
					if(!reader.IsDBNull(linkColumnIndex))
						record.Link = Convert.ToString(reader.GetValue(linkColumnIndex));
					if(!reader.IsDBNull(productCategoryChild_IDColumnIndex))
						record.ProductCategoryChild_ID = Convert.ToString(reader.GetValue(productCategoryChild_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (WEB_PromotionRow[])(recordList.ToArray(typeof(WEB_PromotionRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WEB_PromotionRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WEB_PromotionRow"/> object.</returns>
	protected virtual WEB_PromotionRow MapRow(DataRow row)
	{
		string LOCATION = "WEB_PromotionRow MapRow(DataRow row)";
		WEB_PromotionRow mappedObject = new WEB_PromotionRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Promotion_ID"
		dataColumn = dataTable.Columns["Promotion_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Promotion_ID = (int)(row[dataColumn]);
		// Column "Title"
		dataColumn = dataTable.Columns["Title"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Title = (string)(row[dataColumn]);
		// Column "DateStart"
		dataColumn = dataTable.Columns["DateStart"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DateStart = (System.DateTime)(row[dataColumn]);
		// Column "DateEnd"
		dataColumn = dataTable.Columns["DateEnd"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DateEnd = (System.DateTime)(row[dataColumn]);
		// Column "ProductList_ID"
		dataColumn = dataTable.Columns["ProductList_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductList_ID = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
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
		// Column "Image"
		dataColumn = dataTable.Columns["Image"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Image = (string)(row[dataColumn]);
		// Column "ProductCategory_ID"
		dataColumn = dataTable.Columns["ProductCategory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductCategory_ID = (string)(row[dataColumn]);
		// Column "WarrantyDate"
		dataColumn = dataTable.Columns["WarrantyDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantyDate = (int)(row[dataColumn]);
		// Column "Type"
		dataColumn = dataTable.Columns["Type"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Type = (bool)(row[dataColumn]);
		// Column "Link"
		dataColumn = dataTable.Columns["Link"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Link = (string)(row[dataColumn]);
		// Column "ProductCategoryChild_ID"
		dataColumn = dataTable.Columns["ProductCategoryChild_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductCategoryChild_ID = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>WEB_Promotion</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WEB_Promotion";
		DataColumn dataColumn;
		// Create the "Promotion_ID" column
		dataColumn = dataTable.Columns.Add("Promotion_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Title" column
		dataColumn = dataTable.Columns.Add("Title", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "DateStart" column
		dataColumn = dataTable.Columns.Add("DateStart", typeof(System.DateTime));
		// Create the "DateEnd" column
		dataColumn = dataTable.Columns.Add("DateEnd", typeof(System.DateTime));
		// Create the "ProductList_ID" column
		dataColumn = dataTable.Columns.Add("ProductList_ID", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "Image" column
		dataColumn = dataTable.Columns.Add("Image", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductCategory_ID" column
		dataColumn = dataTable.Columns.Add("ProductCategory_ID", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "WarrantyDate" column
		dataColumn = dataTable.Columns.Add("WarrantyDate", typeof(int));
		// Create the "Type" column
		dataColumn = dataTable.Columns.Add("Type", typeof(bool));
		// Create the "Link" column
		dataColumn = dataTable.Columns.Add("Link", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductCategoryChild_ID" column
		dataColumn = dataTable.Columns.Add("ProductCategoryChild_ID", typeof(string));
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
			case "Promotion_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Title":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DateStart":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "DateEnd":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ProductList_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
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

			case "Image":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductCategory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "WarrantyDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Type":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "Link":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductCategoryChild_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WEB_PromotionRow"/> by the primary key.
	/// </summary>
	/// <param name="promotion_ID">The <c>Promotion_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WEB_PromotionRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int promotion_ID)
	{
		string LOCATION = "Exist(int promotion_ID)";
		IDbCommand cmd = _db.CreateCommand("WEB_Promotion_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Promotion_ID", promotion_ID);
		WEB_PromotionRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




