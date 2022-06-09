
// <fileinfo name="Base\ProductCollectionBase.cs">
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
/// The base class for <see cref="ProductCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Product_IDColumnName  = "Product_ID";
	public const string Store_IDColumnName  = "Store_ID";
	public const string ProductCategory_IDColumnName  = "ProductCategory_ID";
	public const string ProductType_IDColumnName  = "ProductType_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Quality_IDColumnName  = "Quality_ID";
	public const string Customer_IDColumnName  = "Customer_ID";
	public const string Country_IDColumnName  = "Country_ID";
	public const string NameColumnName  = "Name";
	public const string DescriptionColumnName  = "Description";
	public const string ContentColumnName  = "Content";
	public const string ImageColumnName  = "Image";
	public const string QualityImagesColumnName  = "QualityImages";
	public const string PriceColumnName  = "Price";
	public const string PriceOldColumnName  = "PriceOld";
	public const string UnitColumnName  = "Unit";
	public const string ActiveColumnName  = "Active";
	public const string URLColumnName  = "URL";
	public const string QualityNameColumnName  = "QualityName";
	public const string QualityOrganizationNameColumnName  = "QualityOrganizationName";
	public const string QualityOrganizationAddressColumnName  = "QualityOrganizationAddress";
	public const string QualityDescriptionColumnName  = "QualityDescription";
	public const string GrowthByDayColumnName  = "GrowthByDay";
	public const string ExpiryColumnName  = "Expiry";
	public const string ExpiryByDateColumnName  = "ExpiryByDate";
	public const string WarrantyMonthColumnName  = "WarrantyMonth";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string ExpectedProductivityColumnName  = "ExpectedProductivity";
	public const string ExpectedOutputColumnName  = "ExpectedOutput";
	public const string ExpectedProductivityDescriptionColumnName  = "ExpectedProductivityDescription";
	public const string ExpectedOutputDescriptionColumnName  = "ExpectedOutputDescription";
	public const string SGTINColumnName  = "SGTIN";
	public const string AcreageColumnName  = "Acreage";
	public const string TrackingCodeColumnName  = "TrackingCode";
	public const string Product_ID_ParentColumnName  = "Product_ID_Parent";
	public const string StoryColumnName  = "Story";
	public const string PriorityColumnName  = "Priority";
	public const string TrongluongColumnName  = "Trongluong";
	public const string TrongluongThucColumnName  = "TrongluongThuc";
	public const string SizeColumnName  = "Size";
	public const string MaterialCategory_IDColumnName  = "MaterialCategory_ID";
	public const string SKU_IDColumnName  = "SKU_ID";
	public const string SKU_Web_IDColumnName  = "SKU_Web_ID";
	public const string Color_IDColumnName  = "Color_ID";
	public const string VideoColumnName  = "Video";
	public const string TagsColumnName  = "Tags";
	public const string AgencyNorthPriceColumnName  = "AgencyNorthPrice";
	public const string ProductSet_IDColumnName  = "ProductSet_ID";
	public const string Parent_IDColumnName  = "Parent_ID";
	public const string LevelColumnName  = "Level";
	public const string ClassifyColumnName  = "Classify";
	public const string WarrantyDateColumnName  = "WarrantyDate";
	public const string AgencySouthPriceColumnName  = "AgencySouthPrice";
	public const string IsHotColumnName  = "IsHot";
	public const string IsHomeColumnName  = "IsHome";
	public const string IsNewColumnName  = "IsNew";
	public const string IsPromotionColumnName  = "IsPromotion";
	public const string Space_IDColumnName  = "Space_ID";
	public const string ProductAttach_IDColumnName  = "ProductAttach_ID";
	public const string NoteAgencyNorthPriceColumnName  = "NoteAgencyNorthPrice";
	public const string NoteAgencySouthPriceColumnName  = "NoteAgencySouthPrice";
	public const string StarColumnName  = "Star";
	public const string NoteColumnName  = "Note";
	public const string KeywordColumnName  = "Keyword";
	public const string DeletedColumnName  = "Deleted";
	public const string IsQRCodeColumnName  = "IsQRCode";
	public const string SeoKeywordColumnName  = "SeoKeyword";
	public const string SeoDescriptionColumnName  = "SeoDescription";
	public const string IsProductTwoStampColumnName  = "IsProductTwoStamp";
	public const string ListProduct_ID_TwoStampColumnName  = "ListProduct_ID_TwoStamp";
	public const string ProductInWarehouseColumnName  = "ProductInWarehouse";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Product";
	}

	public ProductCollectionBase() : base()
	{
		this.TABLENAME = "Product";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Product</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductRow"/> objects.</returns>
	public virtual ProductRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Product</c> table.
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
	/// to retrieve all records from the <c>Product</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Product_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="ProductRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductRow"/> objects.</returns>
	public ProductRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="ProductRow"/> objects that 
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
	/// <returns>An array of <see cref="ProductRow"/> objects.</returns>
	public virtual ProductRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Product_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Product_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="ProductRow"/> by the primary key.
	/// </summary>
	/// <param name="product_ID">The <c>Product_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual ProductRow GetByPrimaryKey(int product_ID)
	{
		string LOCATION = "GetByPrimaryKey(int product_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Product_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Product_ID", product_ID);
			ProductRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Product</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductRow"/> object to be inserted.</param>
	public virtual void Insert(ProductRow value)
	{
		string LOCATION = "Insert(ProductRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Product_Insert", CommandType.StoredProcedure);
					// Store_ID
			if (value.IsStore_IDNull)
				AddParameter(cmd, "Store_ID", DBNull.Value);
			else
				AddParameter(cmd, "Store_ID", value.Store_ID);
			
				// ProductCategory_ID
			if (value.IsProductCategory_IDNull)
				AddParameter(cmd, "ProductCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductCategory_ID", value.ProductCategory_ID);
			
				// ProductType_ID
			if (value.IsProductType_IDNull)
				AddParameter(cmd, "ProductType_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductType_ID", value.ProductType_ID);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Quality_ID
			if (value.IsQuality_IDNull)
				AddParameter(cmd, "Quality_ID", DBNull.Value);
			else
				AddParameter(cmd, "Quality_ID", value.Quality_ID);
			
				// Customer_ID
			if (value.IsCustomer_IDNull)
				AddParameter(cmd, "Customer_ID", DBNull.Value);
			else
				AddParameter(cmd, "Customer_ID", value.Customer_ID);
			
				// Country_ID
			if (value.IsCountry_IDNull)
				AddParameter(cmd, "Country_ID", DBNull.Value);
			else
				AddParameter(cmd, "Country_ID", value.Country_ID);
			
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
			
				// Content
			if (value.IsContentNull )
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
			
				// Image
			if (value.IsImageNull )
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
			
				// QualityImages
			if (value.IsQualityImagesNull )
				AddParameter(cmd, "QualityImages", DBNull.Value);
			else
				AddParameter(cmd, "QualityImages", value.QualityImages);
			
				// Price
			if (value.IsPriceNull)
				AddParameter(cmd, "Price", DBNull.Value);
			else
				AddParameter(cmd, "Price", value.Price);
			
				// PriceOld
			if (value.IsPriceOldNull)
				AddParameter(cmd, "PriceOld", DBNull.Value);
			else
				AddParameter(cmd, "PriceOld", value.PriceOld);
			
				// Unit
			if (value.IsUnitNull )
				AddParameter(cmd, "Unit", DBNull.Value);
			else
				AddParameter(cmd, "Unit", value.Unit);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// URL
			if (value.IsURLNull )
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
			
				// QualityName
			if (value.IsQualityNameNull )
				AddParameter(cmd, "QualityName", DBNull.Value);
			else
				AddParameter(cmd, "QualityName", value.QualityName);
			
				// QualityOrganizationName
			if (value.IsQualityOrganizationNameNull )
				AddParameter(cmd, "QualityOrganizationName", DBNull.Value);
			else
				AddParameter(cmd, "QualityOrganizationName", value.QualityOrganizationName);
			
				// QualityOrganizationAddress
			if (value.IsQualityOrganizationAddressNull )
				AddParameter(cmd, "QualityOrganizationAddress", DBNull.Value);
			else
				AddParameter(cmd, "QualityOrganizationAddress", value.QualityOrganizationAddress);
			
				// QualityDescription
			if (value.IsQualityDescriptionNull )
				AddParameter(cmd, "QualityDescription", DBNull.Value);
			else
				AddParameter(cmd, "QualityDescription", value.QualityDescription);
			
				// GrowthByDay
			if (value.IsGrowthByDayNull)
				AddParameter(cmd, "GrowthByDay", DBNull.Value);
			else
				AddParameter(cmd, "GrowthByDay", value.GrowthByDay);
			
				// Expiry
			if (value.IsExpiryNull )
				AddParameter(cmd, "Expiry", DBNull.Value);
			else
				AddParameter(cmd, "Expiry", value.Expiry);
			
				// ExpiryByDate
			if (value.IsExpiryByDateNull)
				AddParameter(cmd, "ExpiryByDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpiryByDate", value.ExpiryByDate);
			
				// WarrantyMonth
			if (value.IsWarrantyMonthNull)
				AddParameter(cmd, "WarrantyMonth", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyMonth", value.WarrantyMonth);
			
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
			
				// ExpectedProductivity
			if (value.IsExpectedProductivityNull)
				AddParameter(cmd, "ExpectedProductivity", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedProductivity", value.ExpectedProductivity);
			
				// ExpectedOutput
			if (value.IsExpectedOutputNull)
				AddParameter(cmd, "ExpectedOutput", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedOutput", value.ExpectedOutput);
			
				// ExpectedProductivityDescription
			if (value.IsExpectedProductivityDescriptionNull )
				AddParameter(cmd, "ExpectedProductivityDescription", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedProductivityDescription", value.ExpectedProductivityDescription);
			
				// ExpectedOutputDescription
			if (value.IsExpectedOutputDescriptionNull )
				AddParameter(cmd, "ExpectedOutputDescription", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedOutputDescription", value.ExpectedOutputDescription);
			
				// SGTIN
			if (value.IsSGTINNull )
				AddParameter(cmd, "SGTIN", DBNull.Value);
			else
				AddParameter(cmd, "SGTIN", value.SGTIN);
			
				// Acreage
			if (value.IsAcreageNull)
				AddParameter(cmd, "Acreage", DBNull.Value);
			else
				AddParameter(cmd, "Acreage", value.Acreage);
			
				// TrackingCode
			if (value.IsTrackingCodeNull )
				AddParameter(cmd, "TrackingCode", DBNull.Value);
			else
				AddParameter(cmd, "TrackingCode", value.TrackingCode);
			
				// Product_ID_Parent
			if (value.IsProduct_ID_ParentNull)
				AddParameter(cmd, "Product_ID_Parent", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID_Parent", value.Product_ID_Parent);
			
				// Story
			if (value.IsStoryNull )
				AddParameter(cmd, "Story", DBNull.Value);
			else
				AddParameter(cmd, "Story", value.Story);
			
				// Priority
			if (value.IsPriorityNull)
				AddParameter(cmd, "Priority", DBNull.Value);
			else
				AddParameter(cmd, "Priority", value.Priority);
			
				// Trongluong
			if (value.IsTrongluongNull)
				AddParameter(cmd, "Trongluong", DBNull.Value);
			else
				AddParameter(cmd, "Trongluong", value.Trongluong);
			
				// TrongluongThuc
			if (value.IsTrongluongThucNull)
				AddParameter(cmd, "TrongluongThuc", DBNull.Value);
			else
				AddParameter(cmd, "TrongluongThuc", value.TrongluongThuc);
			
				// Size
			if (value.IsSizeNull )
				AddParameter(cmd, "Size", DBNull.Value);
			else
				AddParameter(cmd, "Size", value.Size);
			
				// MaterialCategory_ID
			if (value.IsMaterialCategory_IDNull )
				AddParameter(cmd, "MaterialCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "MaterialCategory_ID", value.MaterialCategory_ID);
			
				// SKU_ID
			if (value.IsSKU_IDNull )
				AddParameter(cmd, "SKU_ID", DBNull.Value);
			else
				AddParameter(cmd, "SKU_ID", value.SKU_ID);
			
				// SKU_Web_ID
			if (value.IsSKU_Web_IDNull )
				AddParameter(cmd, "SKU_Web_ID", DBNull.Value);
			else
				AddParameter(cmd, "SKU_Web_ID", value.SKU_Web_ID);
			
				// Color_ID
			if (value.IsColor_IDNull)
				AddParameter(cmd, "Color_ID", DBNull.Value);
			else
				AddParameter(cmd, "Color_ID", value.Color_ID);
			
				// Video
			if (value.IsVideoNull )
				AddParameter(cmd, "Video", DBNull.Value);
			else
				AddParameter(cmd, "Video", value.Video);
			
				// Tags
			if (value.IsTagsNull )
				AddParameter(cmd, "Tags", DBNull.Value);
			else
				AddParameter(cmd, "Tags", value.Tags);
			
				// AgencyNorthPrice
			if (value.IsAgencyNorthPriceNull)
				AddParameter(cmd, "AgencyNorthPrice", DBNull.Value);
			else
				AddParameter(cmd, "AgencyNorthPrice", value.AgencyNorthPrice);
			
				// ProductSet_ID
			if (value.IsProductSet_IDNull)
				AddParameter(cmd, "ProductSet_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductSet_ID", value.ProductSet_ID);
			
				// Parent_ID
			if (value.IsParent_IDNull)
				AddParameter(cmd, "Parent_ID", DBNull.Value);
			else
				AddParameter(cmd, "Parent_ID", value.Parent_ID);
			
				// Level
			if (value.IsLevelNull)
				AddParameter(cmd, "Level", DBNull.Value);
			else
				AddParameter(cmd, "Level", value.Level);
			
				// Classify
			if (value.IsClassifyNull)
				AddParameter(cmd, "Classify", DBNull.Value);
			else
				AddParameter(cmd, "Classify", value.Classify);
			
				// WarrantyDate
			if (value.IsWarrantyDateNull)
				AddParameter(cmd, "WarrantyDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyDate", value.WarrantyDate);
			
				// AgencySouthPrice
			if (value.IsAgencySouthPriceNull)
				AddParameter(cmd, "AgencySouthPrice", DBNull.Value);
			else
				AddParameter(cmd, "AgencySouthPrice", value.AgencySouthPrice);
			
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
			
				// IsNew
			if (value.IsIsNewNull)
				AddParameter(cmd, "IsNew", DBNull.Value);
			else
				AddParameter(cmd, "IsNew", value.IsNew);
			
				// IsPromotion
			if (value.IsIsPromotionNull)
				AddParameter(cmd, "IsPromotion", DBNull.Value);
			else
				AddParameter(cmd, "IsPromotion", value.IsPromotion);
			
				// Space_ID
			if (value.IsSpace_IDNull )
				AddParameter(cmd, "Space_ID", DBNull.Value);
			else
				AddParameter(cmd, "Space_ID", value.Space_ID);
			
				// ProductAttach_ID
			if (value.IsProductAttach_IDNull )
				AddParameter(cmd, "ProductAttach_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductAttach_ID", value.ProductAttach_ID);
			
				// NoteAgencyNorthPrice
			if (value.IsNoteAgencyNorthPriceNull )
				AddParameter(cmd, "NoteAgencyNorthPrice", DBNull.Value);
			else
				AddParameter(cmd, "NoteAgencyNorthPrice", value.NoteAgencyNorthPrice);
			
				// NoteAgencySouthPrice
			if (value.IsNoteAgencySouthPriceNull )
				AddParameter(cmd, "NoteAgencySouthPrice", DBNull.Value);
			else
				AddParameter(cmd, "NoteAgencySouthPrice", value.NoteAgencySouthPrice);
			
				// Star
			if (value.IsStarNull)
				AddParameter(cmd, "Star", DBNull.Value);
			else
				AddParameter(cmd, "Star", value.Star);
			
				// Note
			if (value.IsNoteNull )
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
			
				// Keyword
			if (value.IsKeywordNull )
				AddParameter(cmd, "Keyword", DBNull.Value);
			else
				AddParameter(cmd, "Keyword", value.Keyword);
			
				// Deleted
			if (value.IsDeletedNull)
				AddParameter(cmd, "Deleted", DBNull.Value);
			else
				AddParameter(cmd, "Deleted", value.Deleted);
			
				// IsQRCode
			if (value.IsIsQRCodeNull)
				AddParameter(cmd, "IsQRCode", DBNull.Value);
			else
				AddParameter(cmd, "IsQRCode", value.IsQRCode);
			
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
			
				// IsProductTwoStamp
			if (value.IsIsProductTwoStampNull)
				AddParameter(cmd, "IsProductTwoStamp", DBNull.Value);
			else
				AddParameter(cmd, "IsProductTwoStamp", value.IsProductTwoStamp);
			
				// ListProduct_ID_TwoStamp
			if (value.IsListProduct_ID_TwoStampNull )
				AddParameter(cmd, "ListProduct_ID_TwoStamp", DBNull.Value);
			else
				AddParameter(cmd, "ListProduct_ID_TwoStamp", value.ListProduct_ID_TwoStamp);
			
				// ProductInWarehouse
			if (value.IsProductInWarehouseNull)
				AddParameter(cmd, "ProductInWarehouse", DBNull.Value);
			else
				AddParameter(cmd, "ProductInWarehouse", value.ProductInWarehouse);
			
						value.Product_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>Product</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(ProductRow value)
	{	
		string LOCATION = "Update(ProductRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Product_Update", CommandType.StoredProcedure);
					// Store_ID
			if (value.IsStore_IDNull)
				AddParameter(cmd, "Store_ID", DBNull.Value);
			else
				AddParameter(cmd, "Store_ID", value.Store_ID);
			
				// ProductCategory_ID
			if (value.IsProductCategory_IDNull)
				AddParameter(cmd, "ProductCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductCategory_ID", value.ProductCategory_ID);
			
				// ProductType_ID
			if (value.IsProductType_IDNull)
				AddParameter(cmd, "ProductType_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductType_ID", value.ProductType_ID);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Quality_ID
			if (value.IsQuality_IDNull)
				AddParameter(cmd, "Quality_ID", DBNull.Value);
			else
				AddParameter(cmd, "Quality_ID", value.Quality_ID);
			
				// Customer_ID
			if (value.IsCustomer_IDNull)
				AddParameter(cmd, "Customer_ID", DBNull.Value);
			else
				AddParameter(cmd, "Customer_ID", value.Customer_ID);
			
				// Country_ID
			if (value.IsCountry_IDNull)
				AddParameter(cmd, "Country_ID", DBNull.Value);
			else
				AddParameter(cmd, "Country_ID", value.Country_ID);
			
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
				// Content
			if (value.IsContentNull)
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
				// Image
			if (value.IsImageNull)
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
				// QualityImages
			if (value.IsQualityImagesNull)
				AddParameter(cmd, "QualityImages", DBNull.Value);
			else
				AddParameter(cmd, "QualityImages", value.QualityImages);
				// Price
			if (value.IsPriceNull)
				AddParameter(cmd, "Price", DBNull.Value);
			else
				AddParameter(cmd, "Price", value.Price);
			
				// PriceOld
			if (value.IsPriceOldNull)
				AddParameter(cmd, "PriceOld", DBNull.Value);
			else
				AddParameter(cmd, "PriceOld", value.PriceOld);
			
				// Unit
			if (value.IsUnitNull)
				AddParameter(cmd, "Unit", DBNull.Value);
			else
				AddParameter(cmd, "Unit", value.Unit);
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// URL
			if (value.IsURLNull)
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
				// QualityName
			if (value.IsQualityNameNull)
				AddParameter(cmd, "QualityName", DBNull.Value);
			else
				AddParameter(cmd, "QualityName", value.QualityName);
				// QualityOrganizationName
			if (value.IsQualityOrganizationNameNull)
				AddParameter(cmd, "QualityOrganizationName", DBNull.Value);
			else
				AddParameter(cmd, "QualityOrganizationName", value.QualityOrganizationName);
				// QualityOrganizationAddress
			if (value.IsQualityOrganizationAddressNull)
				AddParameter(cmd, "QualityOrganizationAddress", DBNull.Value);
			else
				AddParameter(cmd, "QualityOrganizationAddress", value.QualityOrganizationAddress);
				// QualityDescription
			if (value.IsQualityDescriptionNull)
				AddParameter(cmd, "QualityDescription", DBNull.Value);
			else
				AddParameter(cmd, "QualityDescription", value.QualityDescription);
				// GrowthByDay
			if (value.IsGrowthByDayNull)
				AddParameter(cmd, "GrowthByDay", DBNull.Value);
			else
				AddParameter(cmd, "GrowthByDay", value.GrowthByDay);
			
				// Expiry
			if (value.IsExpiryNull)
				AddParameter(cmd, "Expiry", DBNull.Value);
			else
				AddParameter(cmd, "Expiry", value.Expiry);
				// ExpiryByDate
			if (value.IsExpiryByDateNull)
				AddParameter(cmd, "ExpiryByDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpiryByDate", value.ExpiryByDate);
			
				// WarrantyMonth
			if (value.IsWarrantyMonthNull)
				AddParameter(cmd, "WarrantyMonth", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyMonth", value.WarrantyMonth);
			
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
			
				// ExpectedProductivity
			if (value.IsExpectedProductivityNull)
				AddParameter(cmd, "ExpectedProductivity", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedProductivity", value.ExpectedProductivity);
			
				// ExpectedOutput
			if (value.IsExpectedOutputNull)
				AddParameter(cmd, "ExpectedOutput", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedOutput", value.ExpectedOutput);
			
				// ExpectedProductivityDescription
			if (value.IsExpectedProductivityDescriptionNull)
				AddParameter(cmd, "ExpectedProductivityDescription", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedProductivityDescription", value.ExpectedProductivityDescription);
				// ExpectedOutputDescription
			if (value.IsExpectedOutputDescriptionNull)
				AddParameter(cmd, "ExpectedOutputDescription", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedOutputDescription", value.ExpectedOutputDescription);
				// SGTIN
			if (value.IsSGTINNull)
				AddParameter(cmd, "SGTIN", DBNull.Value);
			else
				AddParameter(cmd, "SGTIN", value.SGTIN);
				// Acreage
			if (value.IsAcreageNull)
				AddParameter(cmd, "Acreage", DBNull.Value);
			else
				AddParameter(cmd, "Acreage", value.Acreage);
			
				// TrackingCode
			if (value.IsTrackingCodeNull)
				AddParameter(cmd, "TrackingCode", DBNull.Value);
			else
				AddParameter(cmd, "TrackingCode", value.TrackingCode);
				// Product_ID_Parent
			if (value.IsProduct_ID_ParentNull)
				AddParameter(cmd, "Product_ID_Parent", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID_Parent", value.Product_ID_Parent);
			
				// Story
			if (value.IsStoryNull)
				AddParameter(cmd, "Story", DBNull.Value);
			else
				AddParameter(cmd, "Story", value.Story);
				// Priority
			if (value.IsPriorityNull)
				AddParameter(cmd, "Priority", DBNull.Value);
			else
				AddParameter(cmd, "Priority", value.Priority);
			
				// Trongluong
			if (value.IsTrongluongNull)
				AddParameter(cmd, "Trongluong", DBNull.Value);
			else
				AddParameter(cmd, "Trongluong", value.Trongluong);
			
				// TrongluongThuc
			if (value.IsTrongluongThucNull)
				AddParameter(cmd, "TrongluongThuc", DBNull.Value);
			else
				AddParameter(cmd, "TrongluongThuc", value.TrongluongThuc);
			
				// Size
			if (value.IsSizeNull)
				AddParameter(cmd, "Size", DBNull.Value);
			else
				AddParameter(cmd, "Size", value.Size);
				// MaterialCategory_ID
			if (value.IsMaterialCategory_IDNull)
				AddParameter(cmd, "MaterialCategory_ID", DBNull.Value);
			else
				AddParameter(cmd, "MaterialCategory_ID", value.MaterialCategory_ID);
				// SKU_ID
			if (value.IsSKU_IDNull)
				AddParameter(cmd, "SKU_ID", DBNull.Value);
			else
				AddParameter(cmd, "SKU_ID", value.SKU_ID);
				// SKU_Web_ID
			if (value.IsSKU_Web_IDNull)
				AddParameter(cmd, "SKU_Web_ID", DBNull.Value);
			else
				AddParameter(cmd, "SKU_Web_ID", value.SKU_Web_ID);
				// Color_ID
			if (value.IsColor_IDNull)
				AddParameter(cmd, "Color_ID", DBNull.Value);
			else
				AddParameter(cmd, "Color_ID", value.Color_ID);
			
				// Video
			if (value.IsVideoNull)
				AddParameter(cmd, "Video", DBNull.Value);
			else
				AddParameter(cmd, "Video", value.Video);
				// Tags
			if (value.IsTagsNull)
				AddParameter(cmd, "Tags", DBNull.Value);
			else
				AddParameter(cmd, "Tags", value.Tags);
				// AgencyNorthPrice
			if (value.IsAgencyNorthPriceNull)
				AddParameter(cmd, "AgencyNorthPrice", DBNull.Value);
			else
				AddParameter(cmd, "AgencyNorthPrice", value.AgencyNorthPrice);
			
				// ProductSet_ID
			if (value.IsProductSet_IDNull)
				AddParameter(cmd, "ProductSet_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductSet_ID", value.ProductSet_ID);
			
				// Parent_ID
			if (value.IsParent_IDNull)
				AddParameter(cmd, "Parent_ID", DBNull.Value);
			else
				AddParameter(cmd, "Parent_ID", value.Parent_ID);
			
				// Level
			if (value.IsLevelNull)
				AddParameter(cmd, "Level", DBNull.Value);
			else
				AddParameter(cmd, "Level", value.Level);
			
				// Classify
			if (value.IsClassifyNull)
				AddParameter(cmd, "Classify", DBNull.Value);
			else
				AddParameter(cmd, "Classify", value.Classify);
			
				// WarrantyDate
			if (value.IsWarrantyDateNull)
				AddParameter(cmd, "WarrantyDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyDate", value.WarrantyDate);
			
				// AgencySouthPrice
			if (value.IsAgencySouthPriceNull)
				AddParameter(cmd, "AgencySouthPrice", DBNull.Value);
			else
				AddParameter(cmd, "AgencySouthPrice", value.AgencySouthPrice);
			
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
			
				// IsNew
			if (value.IsIsNewNull)
				AddParameter(cmd, "IsNew", DBNull.Value);
			else
				AddParameter(cmd, "IsNew", value.IsNew);
			
				// IsPromotion
			if (value.IsIsPromotionNull)
				AddParameter(cmd, "IsPromotion", DBNull.Value);
			else
				AddParameter(cmd, "IsPromotion", value.IsPromotion);
			
				// Space_ID
			if (value.IsSpace_IDNull)
				AddParameter(cmd, "Space_ID", DBNull.Value);
			else
				AddParameter(cmd, "Space_ID", value.Space_ID);
				// ProductAttach_ID
			if (value.IsProductAttach_IDNull)
				AddParameter(cmd, "ProductAttach_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductAttach_ID", value.ProductAttach_ID);
				// NoteAgencyNorthPrice
			if (value.IsNoteAgencyNorthPriceNull)
				AddParameter(cmd, "NoteAgencyNorthPrice", DBNull.Value);
			else
				AddParameter(cmd, "NoteAgencyNorthPrice", value.NoteAgencyNorthPrice);
				// NoteAgencySouthPrice
			if (value.IsNoteAgencySouthPriceNull)
				AddParameter(cmd, "NoteAgencySouthPrice", DBNull.Value);
			else
				AddParameter(cmd, "NoteAgencySouthPrice", value.NoteAgencySouthPrice);
				// Star
			if (value.IsStarNull)
				AddParameter(cmd, "Star", DBNull.Value);
			else
				AddParameter(cmd, "Star", value.Star);
			
				// Note
			if (value.IsNoteNull)
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
				// Keyword
			if (value.IsKeywordNull)
				AddParameter(cmd, "Keyword", DBNull.Value);
			else
				AddParameter(cmd, "Keyword", value.Keyword);
				// Deleted
			if (value.IsDeletedNull)
				AddParameter(cmd, "Deleted", DBNull.Value);
			else
				AddParameter(cmd, "Deleted", value.Deleted);
			
				// IsQRCode
			if (value.IsIsQRCodeNull)
				AddParameter(cmd, "IsQRCode", DBNull.Value);
			else
				AddParameter(cmd, "IsQRCode", value.IsQRCode);
			
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
				// IsProductTwoStamp
			if (value.IsIsProductTwoStampNull)
				AddParameter(cmd, "IsProductTwoStamp", DBNull.Value);
			else
				AddParameter(cmd, "IsProductTwoStamp", value.IsProductTwoStamp);
			
				// ListProduct_ID_TwoStamp
			if (value.IsListProduct_ID_TwoStampNull)
				AddParameter(cmd, "ListProduct_ID_TwoStamp", DBNull.Value);
			else
				AddParameter(cmd, "ListProduct_ID_TwoStamp", value.ListProduct_ID_TwoStamp);
				// ProductInWarehouse
			if (value.IsProductInWarehouseNull)
				AddParameter(cmd, "ProductInWarehouse", DBNull.Value);
			else
				AddParameter(cmd, "ProductInWarehouse", value.ProductInWarehouse);
			
					AddParameter(cmd, "Product_ID", value.Product_ID);
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
		/// Inserts or Updates a record in the <c>Product</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="ProductRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(ProductRow value)
		{
			string LOCATION = "Save(ProductRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Product_Save",CommandType.StoredProcedure);
					// Store_ID
				if (value.IsStore_IDNull)
					AddParameter(cmd, "Store_ID", DBNull.Value);
				else
					AddParameter(cmd, "Store_ID", (object)(value.Store_ID));
				
					// ProductCategory_ID
				if (value.IsProductCategory_IDNull)
					AddParameter(cmd, "ProductCategory_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductCategory_ID", (object)(value.ProductCategory_ID));
				
					// ProductType_ID
				if (value.IsProductType_IDNull)
					AddParameter(cmd, "ProductType_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductType_ID", (object)(value.ProductType_ID));
				
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// Quality_ID
				if (value.IsQuality_IDNull)
					AddParameter(cmd, "Quality_ID", DBNull.Value);
				else
					AddParameter(cmd, "Quality_ID", (object)(value.Quality_ID));
				
					// Customer_ID
				if (value.IsCustomer_IDNull)
					AddParameter(cmd, "Customer_ID", DBNull.Value);
				else
					AddParameter(cmd, "Customer_ID", (object)(value.Customer_ID));
				
					// Country_ID
				if (value.IsCountry_IDNull)
					AddParameter(cmd, "Country_ID", DBNull.Value);
				else
					AddParameter(cmd, "Country_ID", (object)(value.Country_ID));
				
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
				
					// Content
				if (value.IsContentNull)
					AddParameter(cmd, "Content", DBNull.Value);
				else
					AddParameter(cmd, "Content", (object)(value.Content));
				
					// Image
				if (value.IsImageNull)
					AddParameter(cmd, "Image", DBNull.Value);
				else
					AddParameter(cmd, "Image", (object)(value.Image));
				
					// QualityImages
				if (value.IsQualityImagesNull)
					AddParameter(cmd, "QualityImages", DBNull.Value);
				else
					AddParameter(cmd, "QualityImages", (object)(value.QualityImages));
				
					// Price
				if (value.IsPriceNull)
					AddParameter(cmd, "Price", DBNull.Value);
				else
					AddParameter(cmd, "Price", (object)(value.Price));
				
					// PriceOld
				if (value.IsPriceOldNull)
					AddParameter(cmd, "PriceOld", DBNull.Value);
				else
					AddParameter(cmd, "PriceOld", (object)(value.PriceOld));
				
					// Unit
				if (value.IsUnitNull)
					AddParameter(cmd, "Unit", DBNull.Value);
				else
					AddParameter(cmd, "Unit", (object)(value.Unit));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// URL
				if (value.IsURLNull)
					AddParameter(cmd, "URL", DBNull.Value);
				else
					AddParameter(cmd, "URL", (object)(value.URL));
				
					// QualityName
				if (value.IsQualityNameNull)
					AddParameter(cmd, "QualityName", DBNull.Value);
				else
					AddParameter(cmd, "QualityName", (object)(value.QualityName));
				
					// QualityOrganizationName
				if (value.IsQualityOrganizationNameNull)
					AddParameter(cmd, "QualityOrganizationName", DBNull.Value);
				else
					AddParameter(cmd, "QualityOrganizationName", (object)(value.QualityOrganizationName));
				
					// QualityOrganizationAddress
				if (value.IsQualityOrganizationAddressNull)
					AddParameter(cmd, "QualityOrganizationAddress", DBNull.Value);
				else
					AddParameter(cmd, "QualityOrganizationAddress", (object)(value.QualityOrganizationAddress));
				
					// QualityDescription
				if (value.IsQualityDescriptionNull)
					AddParameter(cmd, "QualityDescription", DBNull.Value);
				else
					AddParameter(cmd, "QualityDescription", (object)(value.QualityDescription));
				
					// GrowthByDay
				if (value.IsGrowthByDayNull)
					AddParameter(cmd, "GrowthByDay", DBNull.Value);
				else
					AddParameter(cmd, "GrowthByDay", (object)(value.GrowthByDay));
				
					// Expiry
				if (value.IsExpiryNull)
					AddParameter(cmd, "Expiry", DBNull.Value);
				else
					AddParameter(cmd, "Expiry", (object)(value.Expiry));
				
					// ExpiryByDate
				if (value.IsExpiryByDateNull)
					AddParameter(cmd, "ExpiryByDate", DBNull.Value);
				else
					AddParameter(cmd, "ExpiryByDate", (object)(value.ExpiryByDate));
				
					// WarrantyMonth
				if (value.IsWarrantyMonthNull)
					AddParameter(cmd, "WarrantyMonth", DBNull.Value);
				else
					AddParameter(cmd, "WarrantyMonth", (object)(value.WarrantyMonth));
				
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
				
					// ExpectedProductivity
				if (value.IsExpectedProductivityNull)
					AddParameter(cmd, "ExpectedProductivity", DBNull.Value);
				else
					AddParameter(cmd, "ExpectedProductivity", (object)(value.ExpectedProductivity));
				
					// ExpectedOutput
				if (value.IsExpectedOutputNull)
					AddParameter(cmd, "ExpectedOutput", DBNull.Value);
				else
					AddParameter(cmd, "ExpectedOutput", (object)(value.ExpectedOutput));
				
					// ExpectedProductivityDescription
				if (value.IsExpectedProductivityDescriptionNull)
					AddParameter(cmd, "ExpectedProductivityDescription", DBNull.Value);
				else
					AddParameter(cmd, "ExpectedProductivityDescription", (object)(value.ExpectedProductivityDescription));
				
					// ExpectedOutputDescription
				if (value.IsExpectedOutputDescriptionNull)
					AddParameter(cmd, "ExpectedOutputDescription", DBNull.Value);
				else
					AddParameter(cmd, "ExpectedOutputDescription", (object)(value.ExpectedOutputDescription));
				
					// SGTIN
				if (value.IsSGTINNull)
					AddParameter(cmd, "SGTIN", DBNull.Value);
				else
					AddParameter(cmd, "SGTIN", (object)(value.SGTIN));
				
					// Acreage
				if (value.IsAcreageNull)
					AddParameter(cmd, "Acreage", DBNull.Value);
				else
					AddParameter(cmd, "Acreage", (object)(value.Acreage));
				
					// TrackingCode
				if (value.IsTrackingCodeNull)
					AddParameter(cmd, "TrackingCode", DBNull.Value);
				else
					AddParameter(cmd, "TrackingCode", (object)(value.TrackingCode));
				
					// Product_ID_Parent
				if (value.IsProduct_ID_ParentNull)
					AddParameter(cmd, "Product_ID_Parent", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID_Parent", (object)(value.Product_ID_Parent));
				
					// Story
				if (value.IsStoryNull)
					AddParameter(cmd, "Story", DBNull.Value);
				else
					AddParameter(cmd, "Story", (object)(value.Story));
				
					// Priority
				if (value.IsPriorityNull)
					AddParameter(cmd, "Priority", DBNull.Value);
				else
					AddParameter(cmd, "Priority", (object)(value.Priority));
				
					// Trongluong
				if (value.IsTrongluongNull)
					AddParameter(cmd, "Trongluong", DBNull.Value);
				else
					AddParameter(cmd, "Trongluong", (object)(value.Trongluong));
				
					// TrongluongThuc
				if (value.IsTrongluongThucNull)
					AddParameter(cmd, "TrongluongThuc", DBNull.Value);
				else
					AddParameter(cmd, "TrongluongThuc", (object)(value.TrongluongThuc));
				
					// Size
				if (value.IsSizeNull)
					AddParameter(cmd, "Size", DBNull.Value);
				else
					AddParameter(cmd, "Size", (object)(value.Size));
				
					// MaterialCategory_ID
				if (value.IsMaterialCategory_IDNull)
					AddParameter(cmd, "MaterialCategory_ID", DBNull.Value);
				else
					AddParameter(cmd, "MaterialCategory_ID", (object)(value.MaterialCategory_ID));
				
					// SKU_ID
				if (value.IsSKU_IDNull)
					AddParameter(cmd, "SKU_ID", DBNull.Value);
				else
					AddParameter(cmd, "SKU_ID", (object)(value.SKU_ID));
				
					// SKU_Web_ID
				if (value.IsSKU_Web_IDNull)
					AddParameter(cmd, "SKU_Web_ID", DBNull.Value);
				else
					AddParameter(cmd, "SKU_Web_ID", (object)(value.SKU_Web_ID));
				
					// Color_ID
				if (value.IsColor_IDNull)
					AddParameter(cmd, "Color_ID", DBNull.Value);
				else
					AddParameter(cmd, "Color_ID", (object)(value.Color_ID));
				
					// Video
				if (value.IsVideoNull)
					AddParameter(cmd, "Video", DBNull.Value);
				else
					AddParameter(cmd, "Video", (object)(value.Video));
				
					// Tags
				if (value.IsTagsNull)
					AddParameter(cmd, "Tags", DBNull.Value);
				else
					AddParameter(cmd, "Tags", (object)(value.Tags));
				
					// AgencyNorthPrice
				if (value.IsAgencyNorthPriceNull)
					AddParameter(cmd, "AgencyNorthPrice", DBNull.Value);
				else
					AddParameter(cmd, "AgencyNorthPrice", (object)(value.AgencyNorthPrice));
				
					// ProductSet_ID
				if (value.IsProductSet_IDNull)
					AddParameter(cmd, "ProductSet_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductSet_ID", (object)(value.ProductSet_ID));
				
					// Parent_ID
				if (value.IsParent_IDNull)
					AddParameter(cmd, "Parent_ID", DBNull.Value);
				else
					AddParameter(cmd, "Parent_ID", (object)(value.Parent_ID));
				
					// Level
				if (value.IsLevelNull)
					AddParameter(cmd, "Level", DBNull.Value);
				else
					AddParameter(cmd, "Level", (object)(value.Level));
				
					// Classify
				if (value.IsClassifyNull)
					AddParameter(cmd, "Classify", DBNull.Value);
				else
					AddParameter(cmd, "Classify", (object)(value.Classify));
				
					// WarrantyDate
				if (value.IsWarrantyDateNull)
					AddParameter(cmd, "WarrantyDate", DBNull.Value);
				else
					AddParameter(cmd, "WarrantyDate", (object)(value.WarrantyDate));
				
					// AgencySouthPrice
				if (value.IsAgencySouthPriceNull)
					AddParameter(cmd, "AgencySouthPrice", DBNull.Value);
				else
					AddParameter(cmd, "AgencySouthPrice", (object)(value.AgencySouthPrice));
				
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
				
					// IsNew
				if (value.IsIsNewNull)
					AddParameter(cmd, "IsNew", DBNull.Value);
				else
					AddParameter(cmd, "IsNew", (object)(value.IsNew));
				
					// IsPromotion
				if (value.IsIsPromotionNull)
					AddParameter(cmd, "IsPromotion", DBNull.Value);
				else
					AddParameter(cmd, "IsPromotion", (object)(value.IsPromotion));
				
					// Space_ID
				if (value.IsSpace_IDNull)
					AddParameter(cmd, "Space_ID", DBNull.Value);
				else
					AddParameter(cmd, "Space_ID", (object)(value.Space_ID));
				
					// ProductAttach_ID
				if (value.IsProductAttach_IDNull)
					AddParameter(cmd, "ProductAttach_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductAttach_ID", (object)(value.ProductAttach_ID));
				
					// NoteAgencyNorthPrice
				if (value.IsNoteAgencyNorthPriceNull)
					AddParameter(cmd, "NoteAgencyNorthPrice", DBNull.Value);
				else
					AddParameter(cmd, "NoteAgencyNorthPrice", (object)(value.NoteAgencyNorthPrice));
				
					// NoteAgencySouthPrice
				if (value.IsNoteAgencySouthPriceNull)
					AddParameter(cmd, "NoteAgencySouthPrice", DBNull.Value);
				else
					AddParameter(cmd, "NoteAgencySouthPrice", (object)(value.NoteAgencySouthPrice));
				
					// Star
				if (value.IsStarNull)
					AddParameter(cmd, "Star", DBNull.Value);
				else
					AddParameter(cmd, "Star", (object)(value.Star));
				
					// Note
				if (value.IsNoteNull)
					AddParameter(cmd, "Note", DBNull.Value);
				else
					AddParameter(cmd, "Note", (object)(value.Note));
				
					// Keyword
				if (value.IsKeywordNull)
					AddParameter(cmd, "Keyword", DBNull.Value);
				else
					AddParameter(cmd, "Keyword", (object)(value.Keyword));
				
					// Deleted
				if (value.IsDeletedNull)
					AddParameter(cmd, "Deleted", DBNull.Value);
				else
					AddParameter(cmd, "Deleted", (object)(value.Deleted));
				
					// IsQRCode
				if (value.IsIsQRCodeNull)
					AddParameter(cmd, "IsQRCode", DBNull.Value);
				else
					AddParameter(cmd, "IsQRCode", (object)(value.IsQRCode));
				
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
				
					// IsProductTwoStamp
				if (value.IsIsProductTwoStampNull)
					AddParameter(cmd, "IsProductTwoStamp", DBNull.Value);
				else
					AddParameter(cmd, "IsProductTwoStamp", (object)(value.IsProductTwoStamp));
				
					// ListProduct_ID_TwoStamp
				if (value.IsListProduct_ID_TwoStampNull)
					AddParameter(cmd, "ListProduct_ID_TwoStamp", DBNull.Value);
				else
					AddParameter(cmd, "ListProduct_ID_TwoStamp", (object)(value.ListProduct_ID_TwoStamp));
				
					// ProductInWarehouse
				if (value.IsProductInWarehouseNull)
					AddParameter(cmd, "ProductInWarehouse", DBNull.Value);
				else
					AddParameter(cmd, "ProductInWarehouse", (object)(value.ProductInWarehouse));
				
						AddParameter(cmd, "Product_ID", value.Product_ID);
						value.Product_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Product_ID"]);
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
	/// Deletes the specified object from the <c>Product</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(ProductRow value)
	{
		return DeleteByPrimaryKey(value.Product_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Product</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="product_ID">The <c>Product_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int product_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int product_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Product_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Product_ID", product_ID);
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
	/// Deletes <c>Product</c> records that match the specified criteria.
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
	/// to delete <c>Product</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Product_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Product</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Product_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="ProductRow"/> objects.</returns>
	protected ProductRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="ProductRow"/> objects.</returns>
	protected ProductRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="ProductRow"/> objects.</returns>
	protected virtual ProductRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// Store_ID
		int store_IDColumnIndex = reader.GetOrdinal("Store_ID");
		// ProductCategory_ID
		int productCategory_IDColumnIndex = reader.GetOrdinal("ProductCategory_ID");
		// ProductType_ID
		int productType_IDColumnIndex = reader.GetOrdinal("ProductType_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Quality_ID
		int quality_IDColumnIndex = reader.GetOrdinal("Quality_ID");
		// Customer_ID
		int customer_IDColumnIndex = reader.GetOrdinal("Customer_ID");
		// Country_ID
		int country_IDColumnIndex = reader.GetOrdinal("Country_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Content
		int contentColumnIndex = reader.GetOrdinal("Content");
		// Image
		int imageColumnIndex = reader.GetOrdinal("Image");
		// QualityImages
		int qualityImagesColumnIndex = reader.GetOrdinal("QualityImages");
		// Price
		int priceColumnIndex = reader.GetOrdinal("Price");
		// PriceOld
		int priceOldColumnIndex = reader.GetOrdinal("PriceOld");
		// Unit
		int unitColumnIndex = reader.GetOrdinal("Unit");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// URL
		int urlColumnIndex = reader.GetOrdinal("URL");
		// QualityName
		int qualityNameColumnIndex = reader.GetOrdinal("QualityName");
		// QualityOrganizationName
		int qualityOrganizationNameColumnIndex = reader.GetOrdinal("QualityOrganizationName");
		// QualityOrganizationAddress
		int qualityOrganizationAddressColumnIndex = reader.GetOrdinal("QualityOrganizationAddress");
		// QualityDescription
		int qualityDescriptionColumnIndex = reader.GetOrdinal("QualityDescription");
		// GrowthByDay
		int growthByDayColumnIndex = reader.GetOrdinal("GrowthByDay");
		// Expiry
		int expiryColumnIndex = reader.GetOrdinal("Expiry");
		// ExpiryByDate
		int expiryByDateColumnIndex = reader.GetOrdinal("ExpiryByDate");
		// WarrantyMonth
		int warrantyMonthColumnIndex = reader.GetOrdinal("WarrantyMonth");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// ExpectedProductivity
		int expectedProductivityColumnIndex = reader.GetOrdinal("ExpectedProductivity");
		// ExpectedOutput
		int expectedOutputColumnIndex = reader.GetOrdinal("ExpectedOutput");
		// ExpectedProductivityDescription
		int expectedProductivityDescriptionColumnIndex = reader.GetOrdinal("ExpectedProductivityDescription");
		// ExpectedOutputDescription
		int expectedOutputDescriptionColumnIndex = reader.GetOrdinal("ExpectedOutputDescription");
		// SGTIN
		int sgtinColumnIndex = reader.GetOrdinal("SGTIN");
		// Acreage
		int acreageColumnIndex = reader.GetOrdinal("Acreage");
		// TrackingCode
		int trackingCodeColumnIndex = reader.GetOrdinal("TrackingCode");
		// Product_ID_Parent
		int product_ID_ParentColumnIndex = reader.GetOrdinal("Product_ID_Parent");
		// Story
		int storyColumnIndex = reader.GetOrdinal("Story");
		// Priority
		int priorityColumnIndex = reader.GetOrdinal("Priority");
		// Trongluong
		int trongluongColumnIndex = reader.GetOrdinal("Trongluong");
		// TrongluongThuc
		int trongluongThucColumnIndex = reader.GetOrdinal("TrongluongThuc");
		// Size
		int sizeColumnIndex = reader.GetOrdinal("Size");
		// MaterialCategory_ID
		int materialCategory_IDColumnIndex = reader.GetOrdinal("MaterialCategory_ID");
		// SKU_ID
		int sku_idColumnIndex = reader.GetOrdinal("SKU_ID");
		// SKU_Web_ID
		int sKU_Web_IDColumnIndex = reader.GetOrdinal("SKU_Web_ID");
		// Color_ID
		int color_IDColumnIndex = reader.GetOrdinal("Color_ID");
		// Video
		int videoColumnIndex = reader.GetOrdinal("Video");
		// Tags
		int tagsColumnIndex = reader.GetOrdinal("Tags");
		// AgencyNorthPrice
		int agencyNorthPriceColumnIndex = reader.GetOrdinal("AgencyNorthPrice");
		// ProductSet_ID
		int productSet_IDColumnIndex = reader.GetOrdinal("ProductSet_ID");
		// Parent_ID
		int parent_IDColumnIndex = reader.GetOrdinal("Parent_ID");
		// Level
		int levelColumnIndex = reader.GetOrdinal("Level");
		// Classify
		int classifyColumnIndex = reader.GetOrdinal("Classify");
		// WarrantyDate
		int warrantyDateColumnIndex = reader.GetOrdinal("WarrantyDate");
		// AgencySouthPrice
		int agencySouthPriceColumnIndex = reader.GetOrdinal("AgencySouthPrice");
		// IsHot
		int isHotColumnIndex = reader.GetOrdinal("IsHot");
		// IsHome
		int isHomeColumnIndex = reader.GetOrdinal("IsHome");
		// IsNew
		int isNewColumnIndex = reader.GetOrdinal("IsNew");
		// IsPromotion
		int isPromotionColumnIndex = reader.GetOrdinal("IsPromotion");
		// Space_ID
		int space_IDColumnIndex = reader.GetOrdinal("Space_ID");
		// ProductAttach_ID
		int productAttach_IDColumnIndex = reader.GetOrdinal("ProductAttach_ID");
		// NoteAgencyNorthPrice
		int noteAgencyNorthPriceColumnIndex = reader.GetOrdinal("NoteAgencyNorthPrice");
		// NoteAgencySouthPrice
		int noteAgencySouthPriceColumnIndex = reader.GetOrdinal("NoteAgencySouthPrice");
		// Star
		int starColumnIndex = reader.GetOrdinal("Star");
		// Note
		int noteColumnIndex = reader.GetOrdinal("Note");
		// Keyword
		int keywordColumnIndex = reader.GetOrdinal("Keyword");
		// Deleted
		int deletedColumnIndex = reader.GetOrdinal("Deleted");
		// IsQRCode
		int isQRCodeColumnIndex = reader.GetOrdinal("IsQRCode");
		// SeoKeyword
		int seoKeywordColumnIndex = reader.GetOrdinal("SeoKeyword");
		// SeoDescription
		int seoDescriptionColumnIndex = reader.GetOrdinal("SeoDescription");
		// IsProductTwoStamp
		int isProductTwoStampColumnIndex = reader.GetOrdinal("IsProductTwoStamp");
		// ListProduct_ID_TwoStamp
		int listProduct_ID_TwoStampColumnIndex = reader.GetOrdinal("ListProduct_ID_TwoStamp");
		// ProductInWarehouse
		int productInWarehouseColumnIndex = reader.GetOrdinal("ProductInWarehouse");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				ProductRow record = new ProductRow();
				recordList.Add(record);

					record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(store_IDColumnIndex))
						record.Store_ID = Convert.ToInt32(reader.GetValue(store_IDColumnIndex));
					if(!reader.IsDBNull(productCategory_IDColumnIndex))
						record.ProductCategory_ID = Convert.ToInt32(reader.GetValue(productCategory_IDColumnIndex));
					if(!reader.IsDBNull(productType_IDColumnIndex))
						record.ProductType_ID = Convert.ToInt32(reader.GetValue(productType_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(quality_IDColumnIndex))
						record.Quality_ID = Convert.ToInt32(reader.GetValue(quality_IDColumnIndex));
					if(!reader.IsDBNull(customer_IDColumnIndex))
						record.Customer_ID = Convert.ToInt32(reader.GetValue(customer_IDColumnIndex));
					if(!reader.IsDBNull(country_IDColumnIndex))
						record.Country_ID = Convert.ToInt32(reader.GetValue(country_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(contentColumnIndex))
						record.Content = Convert.ToString(reader.GetValue(contentColumnIndex));
					if(!reader.IsDBNull(imageColumnIndex))
						record.Image = Convert.ToString(reader.GetValue(imageColumnIndex));
					if(!reader.IsDBNull(qualityImagesColumnIndex))
						record.QualityImages = Convert.ToString(reader.GetValue(qualityImagesColumnIndex));
					if(!reader.IsDBNull(priceColumnIndex))
						record.Price = Convert.ToDecimal(reader.GetValue(priceColumnIndex));
					if(!reader.IsDBNull(priceOldColumnIndex))
						record.PriceOld = Convert.ToDecimal(reader.GetValue(priceOldColumnIndex));
					if(!reader.IsDBNull(unitColumnIndex))
						record.Unit = Convert.ToString(reader.GetValue(unitColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(urlColumnIndex))
						record.URL = Convert.ToString(reader.GetValue(urlColumnIndex));
					if(!reader.IsDBNull(qualityNameColumnIndex))
						record.QualityName = Convert.ToString(reader.GetValue(qualityNameColumnIndex));
					if(!reader.IsDBNull(qualityOrganizationNameColumnIndex))
						record.QualityOrganizationName = Convert.ToString(reader.GetValue(qualityOrganizationNameColumnIndex));
					if(!reader.IsDBNull(qualityOrganizationAddressColumnIndex))
						record.QualityOrganizationAddress = Convert.ToString(reader.GetValue(qualityOrganizationAddressColumnIndex));
					if(!reader.IsDBNull(qualityDescriptionColumnIndex))
						record.QualityDescription = Convert.ToString(reader.GetValue(qualityDescriptionColumnIndex));
					if(!reader.IsDBNull(growthByDayColumnIndex))
						record.GrowthByDay = Convert.ToInt32(reader.GetValue(growthByDayColumnIndex));
					if(!reader.IsDBNull(expiryColumnIndex))
						record.Expiry = Convert.ToString(reader.GetValue(expiryColumnIndex));
					if(!reader.IsDBNull(expiryByDateColumnIndex))
						record.ExpiryByDate = Convert.ToInt32(reader.GetValue(expiryByDateColumnIndex));
					if(!reader.IsDBNull(warrantyMonthColumnIndex))
						record.WarrantyMonth = Convert.ToInt32(reader.GetValue(warrantyMonthColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(expectedProductivityColumnIndex))
						record.ExpectedProductivity = Convert.ToInt32(reader.GetValue(expectedProductivityColumnIndex));
					if(!reader.IsDBNull(expectedOutputColumnIndex))
						record.ExpectedOutput = Convert.ToInt32(reader.GetValue(expectedOutputColumnIndex));
					if(!reader.IsDBNull(expectedProductivityDescriptionColumnIndex))
						record.ExpectedProductivityDescription = Convert.ToString(reader.GetValue(expectedProductivityDescriptionColumnIndex));
					if(!reader.IsDBNull(expectedOutputDescriptionColumnIndex))
						record.ExpectedOutputDescription = Convert.ToString(reader.GetValue(expectedOutputDescriptionColumnIndex));
					if(!reader.IsDBNull(sgtinColumnIndex))
						record.SGTIN = Convert.ToString(reader.GetValue(sgtinColumnIndex));
					if(!reader.IsDBNull(acreageColumnIndex))
						record.Acreage = Convert.ToInt32(reader.GetValue(acreageColumnIndex));
					if(!reader.IsDBNull(trackingCodeColumnIndex))
						record.TrackingCode = Convert.ToString(reader.GetValue(trackingCodeColumnIndex));
					if(!reader.IsDBNull(product_ID_ParentColumnIndex))
						record.Product_ID_Parent = Convert.ToInt32(reader.GetValue(product_ID_ParentColumnIndex));
					if(!reader.IsDBNull(storyColumnIndex))
						record.Story = Convert.ToString(reader.GetValue(storyColumnIndex));
					if(!reader.IsDBNull(priorityColumnIndex))
						record.Priority = Convert.ToBoolean(reader.GetValue(priorityColumnIndex));
					if(!reader.IsDBNull(trongluongColumnIndex))
						record.Trongluong = Convert.ToDouble(reader.GetValue(trongluongColumnIndex));
					if(!reader.IsDBNull(trongluongThucColumnIndex))
						record.TrongluongThuc = Convert.ToDouble(reader.GetValue(trongluongThucColumnIndex));
					if(!reader.IsDBNull(sizeColumnIndex))
						record.Size = Convert.ToString(reader.GetValue(sizeColumnIndex));
					if(!reader.IsDBNull(materialCategory_IDColumnIndex))
						record.MaterialCategory_ID = Convert.ToString(reader.GetValue(materialCategory_IDColumnIndex));
					if(!reader.IsDBNull(sku_idColumnIndex))
						record.SKU_ID = Convert.ToString(reader.GetValue(sku_idColumnIndex));
					if(!reader.IsDBNull(sKU_Web_IDColumnIndex))
						record.SKU_Web_ID = Convert.ToString(reader.GetValue(sKU_Web_IDColumnIndex));
					if(!reader.IsDBNull(color_IDColumnIndex))
						record.Color_ID = Convert.ToInt32(reader.GetValue(color_IDColumnIndex));
					if(!reader.IsDBNull(videoColumnIndex))
						record.Video = Convert.ToString(reader.GetValue(videoColumnIndex));
					if(!reader.IsDBNull(tagsColumnIndex))
						record.Tags = Convert.ToString(reader.GetValue(tagsColumnIndex));
					if(!reader.IsDBNull(agencyNorthPriceColumnIndex))
						record.AgencyNorthPrice = Convert.ToDecimal(reader.GetValue(agencyNorthPriceColumnIndex));
					if(!reader.IsDBNull(productSet_IDColumnIndex))
						record.ProductSet_ID = Convert.ToInt32(reader.GetValue(productSet_IDColumnIndex));
					if(!reader.IsDBNull(parent_IDColumnIndex))
						record.Parent_ID = Convert.ToInt32(reader.GetValue(parent_IDColumnIndex));
					if(!reader.IsDBNull(levelColumnIndex))
						record.Level = Convert.ToInt32(reader.GetValue(levelColumnIndex));
					if(!reader.IsDBNull(classifyColumnIndex))
						record.Classify = Convert.ToInt32(reader.GetValue(classifyColumnIndex));
					if(!reader.IsDBNull(warrantyDateColumnIndex))
						record.WarrantyDate = Convert.ToInt32(reader.GetValue(warrantyDateColumnIndex));
					if(!reader.IsDBNull(agencySouthPriceColumnIndex))
						record.AgencySouthPrice = Convert.ToDecimal(reader.GetValue(agencySouthPriceColumnIndex));
					if(!reader.IsDBNull(isHotColumnIndex))
						record.IsHot = Convert.ToInt32(reader.GetValue(isHotColumnIndex));
					if(!reader.IsDBNull(isHomeColumnIndex))
						record.IsHome = Convert.ToInt32(reader.GetValue(isHomeColumnIndex));
					if(!reader.IsDBNull(isNewColumnIndex))
						record.IsNew = Convert.ToInt32(reader.GetValue(isNewColumnIndex));
					if(!reader.IsDBNull(isPromotionColumnIndex))
						record.IsPromotion = Convert.ToInt32(reader.GetValue(isPromotionColumnIndex));
					if(!reader.IsDBNull(space_IDColumnIndex))
						record.Space_ID = Convert.ToString(reader.GetValue(space_IDColumnIndex));
					if(!reader.IsDBNull(productAttach_IDColumnIndex))
						record.ProductAttach_ID = Convert.ToString(reader.GetValue(productAttach_IDColumnIndex));
					if(!reader.IsDBNull(noteAgencyNorthPriceColumnIndex))
						record.NoteAgencyNorthPrice = Convert.ToString(reader.GetValue(noteAgencyNorthPriceColumnIndex));
					if(!reader.IsDBNull(noteAgencySouthPriceColumnIndex))
						record.NoteAgencySouthPrice = Convert.ToString(reader.GetValue(noteAgencySouthPriceColumnIndex));
					if(!reader.IsDBNull(starColumnIndex))
						record.Star = Convert.ToInt32(reader.GetValue(starColumnIndex));
					if(!reader.IsDBNull(noteColumnIndex))
						record.Note = Convert.ToString(reader.GetValue(noteColumnIndex));
					if(!reader.IsDBNull(keywordColumnIndex))
						record.Keyword = Convert.ToString(reader.GetValue(keywordColumnIndex));
					if(!reader.IsDBNull(deletedColumnIndex))
						record.Deleted = Convert.ToBoolean(reader.GetValue(deletedColumnIndex));
					if(!reader.IsDBNull(isQRCodeColumnIndex))
						record.IsQRCode = Convert.ToBoolean(reader.GetValue(isQRCodeColumnIndex));
					if(!reader.IsDBNull(seoKeywordColumnIndex))
						record.SeoKeyword = Convert.ToString(reader.GetValue(seoKeywordColumnIndex));
					if(!reader.IsDBNull(seoDescriptionColumnIndex))
						record.SeoDescription = Convert.ToString(reader.GetValue(seoDescriptionColumnIndex));
					if(!reader.IsDBNull(isProductTwoStampColumnIndex))
						record.IsProductTwoStamp = Convert.ToBoolean(reader.GetValue(isProductTwoStampColumnIndex));
					if(!reader.IsDBNull(listProduct_ID_TwoStampColumnIndex))
						record.ListProduct_ID_TwoStamp = Convert.ToString(reader.GetValue(listProduct_ID_TwoStampColumnIndex));
					if(!reader.IsDBNull(productInWarehouseColumnIndex))
						record.ProductInWarehouse = Convert.ToInt32(reader.GetValue(productInWarehouseColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (ProductRow[])(recordList.ToArray(typeof(ProductRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductRow"/> object.</returns>
	protected virtual ProductRow MapRow(DataRow row)
	{
		string LOCATION = "ProductRow MapRow(DataRow row)";
		ProductRow mappedObject = new ProductRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "Store_ID"
		dataColumn = dataTable.Columns["Store_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Store_ID = (int)(row[dataColumn]);
		// Column "ProductCategory_ID"
		dataColumn = dataTable.Columns["ProductCategory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductCategory_ID = (int)(row[dataColumn]);
		// Column "ProductType_ID"
		dataColumn = dataTable.Columns["ProductType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductType_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Quality_ID"
		dataColumn = dataTable.Columns["Quality_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Quality_ID = (int)(row[dataColumn]);
		// Column "Customer_ID"
		dataColumn = dataTable.Columns["Customer_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Customer_ID = (int)(row[dataColumn]);
		// Column "Country_ID"
		dataColumn = dataTable.Columns["Country_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Country_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Content"
		dataColumn = dataTable.Columns["Content"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Content = (string)(row[dataColumn]);
		// Column "Image"
		dataColumn = dataTable.Columns["Image"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Image = (string)(row[dataColumn]);
		// Column "QualityImages"
		dataColumn = dataTable.Columns["QualityImages"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityImages = (string)(row[dataColumn]);
		// Column "Price"
		dataColumn = dataTable.Columns["Price"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Price = (decimal)(row[dataColumn]);
		// Column "PriceOld"
		dataColumn = dataTable.Columns["PriceOld"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PriceOld = (decimal)(row[dataColumn]);
		// Column "Unit"
		dataColumn = dataTable.Columns["Unit"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Unit = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
		// Column "URL"
		dataColumn = dataTable.Columns["URL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.URL = (string)(row[dataColumn]);
		// Column "QualityName"
		dataColumn = dataTable.Columns["QualityName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityName = (string)(row[dataColumn]);
		// Column "QualityOrganizationName"
		dataColumn = dataTable.Columns["QualityOrganizationName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityOrganizationName = (string)(row[dataColumn]);
		// Column "QualityOrganizationAddress"
		dataColumn = dataTable.Columns["QualityOrganizationAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityOrganizationAddress = (string)(row[dataColumn]);
		// Column "QualityDescription"
		dataColumn = dataTable.Columns["QualityDescription"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityDescription = (string)(row[dataColumn]);
		// Column "GrowthByDay"
		dataColumn = dataTable.Columns["GrowthByDay"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GrowthByDay = (int)(row[dataColumn]);
		// Column "Expiry"
		dataColumn = dataTable.Columns["Expiry"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Expiry = (string)(row[dataColumn]);
		// Column "ExpiryByDate"
		dataColumn = dataTable.Columns["ExpiryByDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpiryByDate = (int)(row[dataColumn]);
		// Column "WarrantyMonth"
		dataColumn = dataTable.Columns["WarrantyMonth"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantyMonth = (int)(row[dataColumn]);
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
		// Column "ExpectedProductivity"
		dataColumn = dataTable.Columns["ExpectedProductivity"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedProductivity = (int)(row[dataColumn]);
		// Column "ExpectedOutput"
		dataColumn = dataTable.Columns["ExpectedOutput"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedOutput = (int)(row[dataColumn]);
		// Column "ExpectedProductivityDescription"
		dataColumn = dataTable.Columns["ExpectedProductivityDescription"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedProductivityDescription = (string)(row[dataColumn]);
		// Column "ExpectedOutputDescription"
		dataColumn = dataTable.Columns["ExpectedOutputDescription"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedOutputDescription = (string)(row[dataColumn]);
		// Column "SGTIN"
		dataColumn = dataTable.Columns["SGTIN"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SGTIN = (string)(row[dataColumn]);
		// Column "Acreage"
		dataColumn = dataTable.Columns["Acreage"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Acreage = (int)(row[dataColumn]);
		// Column "TrackingCode"
		dataColumn = dataTable.Columns["TrackingCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TrackingCode = (string)(row[dataColumn]);
		// Column "Product_ID_Parent"
		dataColumn = dataTable.Columns["Product_ID_Parent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID_Parent = (int)(row[dataColumn]);
		// Column "Story"
		dataColumn = dataTable.Columns["Story"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Story = (string)(row[dataColumn]);
		// Column "Priority"
		dataColumn = dataTable.Columns["Priority"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Priority = (bool)(row[dataColumn]);
		// Column "Trongluong"
		dataColumn = dataTable.Columns["Trongluong"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Trongluong = (double)(row[dataColumn]);
		// Column "TrongluongThuc"
		dataColumn = dataTable.Columns["TrongluongThuc"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TrongluongThuc = (double)(row[dataColumn]);
		// Column "Size"
		dataColumn = dataTable.Columns["Size"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Size = (string)(row[dataColumn]);
		// Column "MaterialCategory_ID"
		dataColumn = dataTable.Columns["MaterialCategory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.MaterialCategory_ID = (string)(row[dataColumn]);
		// Column "SKU_ID"
		dataColumn = dataTable.Columns["SKU_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SKU_ID = (string)(row[dataColumn]);
		// Column "SKU_Web_ID"
		dataColumn = dataTable.Columns["SKU_Web_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SKU_Web_ID = (string)(row[dataColumn]);
		// Column "Color_ID"
		dataColumn = dataTable.Columns["Color_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Color_ID = (int)(row[dataColumn]);
		// Column "Video"
		dataColumn = dataTable.Columns["Video"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Video = (string)(row[dataColumn]);
		// Column "Tags"
		dataColumn = dataTable.Columns["Tags"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Tags = (string)(row[dataColumn]);
		// Column "AgencyNorthPrice"
		dataColumn = dataTable.Columns["AgencyNorthPrice"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AgencyNorthPrice = (decimal)(row[dataColumn]);
		// Column "ProductSet_ID"
		dataColumn = dataTable.Columns["ProductSet_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductSet_ID = (int)(row[dataColumn]);
		// Column "Parent_ID"
		dataColumn = dataTable.Columns["Parent_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Parent_ID = (int)(row[dataColumn]);
		// Column "Level"
		dataColumn = dataTable.Columns["Level"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Level = (int)(row[dataColumn]);
		// Column "Classify"
		dataColumn = dataTable.Columns["Classify"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Classify = (int)(row[dataColumn]);
		// Column "WarrantyDate"
		dataColumn = dataTable.Columns["WarrantyDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantyDate = (int)(row[dataColumn]);
		// Column "AgencySouthPrice"
		dataColumn = dataTable.Columns["AgencySouthPrice"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AgencySouthPrice = (decimal)(row[dataColumn]);
		// Column "IsHot"
		dataColumn = dataTable.Columns["IsHot"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsHot = (int)(row[dataColumn]);
		// Column "IsHome"
		dataColumn = dataTable.Columns["IsHome"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsHome = (int)(row[dataColumn]);
		// Column "IsNew"
		dataColumn = dataTable.Columns["IsNew"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsNew = (int)(row[dataColumn]);
		// Column "IsPromotion"
		dataColumn = dataTable.Columns["IsPromotion"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsPromotion = (int)(row[dataColumn]);
		// Column "Space_ID"
		dataColumn = dataTable.Columns["Space_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Space_ID = (string)(row[dataColumn]);
		// Column "ProductAttach_ID"
		dataColumn = dataTable.Columns["ProductAttach_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductAttach_ID = (string)(row[dataColumn]);
		// Column "NoteAgencyNorthPrice"
		dataColumn = dataTable.Columns["NoteAgencyNorthPrice"];
		if (! row.IsNull(dataColumn) )
			mappedObject.NoteAgencyNorthPrice = (string)(row[dataColumn]);
		// Column "NoteAgencySouthPrice"
		dataColumn = dataTable.Columns["NoteAgencySouthPrice"];
		if (! row.IsNull(dataColumn) )
			mappedObject.NoteAgencySouthPrice = (string)(row[dataColumn]);
		// Column "Star"
		dataColumn = dataTable.Columns["Star"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Star = (int)(row[dataColumn]);
		// Column "Note"
		dataColumn = dataTable.Columns["Note"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Note = (string)(row[dataColumn]);
		// Column "Keyword"
		dataColumn = dataTable.Columns["Keyword"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Keyword = (string)(row[dataColumn]);
		// Column "Deleted"
		dataColumn = dataTable.Columns["Deleted"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Deleted = (bool)(row[dataColumn]);
		// Column "IsQRCode"
		dataColumn = dataTable.Columns["IsQRCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsQRCode = (bool)(row[dataColumn]);
		// Column "SeoKeyword"
		dataColumn = dataTable.Columns["SeoKeyword"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SeoKeyword = (string)(row[dataColumn]);
		// Column "SeoDescription"
		dataColumn = dataTable.Columns["SeoDescription"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SeoDescription = (string)(row[dataColumn]);
		// Column "IsProductTwoStamp"
		dataColumn = dataTable.Columns["IsProductTwoStamp"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsProductTwoStamp = (bool)(row[dataColumn]);
		// Column "ListProduct_ID_TwoStamp"
		dataColumn = dataTable.Columns["ListProduct_ID_TwoStamp"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ListProduct_ID_TwoStamp = (string)(row[dataColumn]);
		// Column "ProductInWarehouse"
		dataColumn = dataTable.Columns["ProductInWarehouse"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductInWarehouse = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Product</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Product";
		DataColumn dataColumn;
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Store_ID" column
		dataColumn = dataTable.Columns.Add("Store_ID", typeof(int));
		// Create the "ProductCategory_ID" column
		dataColumn = dataTable.Columns.Add("ProductCategory_ID", typeof(int));
		// Create the "ProductType_ID" column
		dataColumn = dataTable.Columns.Add("ProductType_ID", typeof(int));
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Quality_ID" column
		dataColumn = dataTable.Columns.Add("Quality_ID", typeof(int));
		// Create the "Customer_ID" column
		dataColumn = dataTable.Columns.Add("Customer_ID", typeof(int));
		// Create the "Country_ID" column
		dataColumn = dataTable.Columns.Add("Country_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Content" column
		dataColumn = dataTable.Columns.Add("Content", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Image" column
		dataColumn = dataTable.Columns.Add("Image", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "QualityImages" column
		dataColumn = dataTable.Columns.Add("QualityImages", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Price" column
		dataColumn = dataTable.Columns.Add("Price", typeof(decimal));
		// Create the "PriceOld" column
		dataColumn = dataTable.Columns.Add("PriceOld", typeof(decimal));
		// Create the "Unit" column
		dataColumn = dataTable.Columns.Add("Unit", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "URL" column
		dataColumn = dataTable.Columns.Add("URL", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "QualityName" column
		dataColumn = dataTable.Columns.Add("QualityName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "QualityOrganizationName" column
		dataColumn = dataTable.Columns.Add("QualityOrganizationName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "QualityOrganizationAddress" column
		dataColumn = dataTable.Columns.Add("QualityOrganizationAddress", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "QualityDescription" column
		dataColumn = dataTable.Columns.Add("QualityDescription", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "GrowthByDay" column
		dataColumn = dataTable.Columns.Add("GrowthByDay", typeof(int));
		// Create the "Expiry" column
		dataColumn = dataTable.Columns.Add("Expiry", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "ExpiryByDate" column
		dataColumn = dataTable.Columns.Add("ExpiryByDate", typeof(int));
		// Create the "WarrantyMonth" column
		dataColumn = dataTable.Columns.Add("WarrantyMonth", typeof(int));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "ExpectedProductivity" column
		dataColumn = dataTable.Columns.Add("ExpectedProductivity", typeof(int));
		// Create the "ExpectedOutput" column
		dataColumn = dataTable.Columns.Add("ExpectedOutput", typeof(int));
		// Create the "ExpectedProductivityDescription" column
		dataColumn = dataTable.Columns.Add("ExpectedProductivityDescription", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ExpectedOutputDescription" column
		dataColumn = dataTable.Columns.Add("ExpectedOutputDescription", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "SGTIN" column
		dataColumn = dataTable.Columns.Add("SGTIN", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Acreage" column
		dataColumn = dataTable.Columns.Add("Acreage", typeof(int));
		// Create the "TrackingCode" column
		dataColumn = dataTable.Columns.Add("TrackingCode", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Product_ID_Parent" column
		dataColumn = dataTable.Columns.Add("Product_ID_Parent", typeof(int));
		// Create the "Story" column
		dataColumn = dataTable.Columns.Add("Story", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Priority" column
		dataColumn = dataTable.Columns.Add("Priority", typeof(bool));
		// Create the "Trongluong" column
		dataColumn = dataTable.Columns.Add("Trongluong", typeof(double));
		// Create the "TrongluongThuc" column
		dataColumn = dataTable.Columns.Add("TrongluongThuc", typeof(double));
		// Create the "Size" column
		dataColumn = dataTable.Columns.Add("Size", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "MaterialCategory_ID" column
		dataColumn = dataTable.Columns.Add("MaterialCategory_ID", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "SKU_ID" column
		dataColumn = dataTable.Columns.Add("SKU_ID", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SKU_Web_ID" column
		dataColumn = dataTable.Columns.Add("SKU_Web_ID", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Color_ID" column
		dataColumn = dataTable.Columns.Add("Color_ID", typeof(int));
		// Create the "Video" column
		dataColumn = dataTable.Columns.Add("Video", typeof(string));
		dataColumn.MaxLength = 400;
		// Create the "Tags" column
		dataColumn = dataTable.Columns.Add("Tags", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "AgencyNorthPrice" column
		dataColumn = dataTable.Columns.Add("AgencyNorthPrice", typeof(decimal));
		// Create the "ProductSet_ID" column
		dataColumn = dataTable.Columns.Add("ProductSet_ID", typeof(int));
		// Create the "Parent_ID" column
		dataColumn = dataTable.Columns.Add("Parent_ID", typeof(int));
		// Create the "Level" column
		dataColumn = dataTable.Columns.Add("Level", typeof(int));
		// Create the "Classify" column
		dataColumn = dataTable.Columns.Add("Classify", typeof(int));
		// Create the "WarrantyDate" column
		dataColumn = dataTable.Columns.Add("WarrantyDate", typeof(int));
		// Create the "AgencySouthPrice" column
		dataColumn = dataTable.Columns.Add("AgencySouthPrice", typeof(decimal));
		// Create the "IsHot" column
		dataColumn = dataTable.Columns.Add("IsHot", typeof(int));
		// Create the "IsHome" column
		dataColumn = dataTable.Columns.Add("IsHome", typeof(int));
		// Create the "IsNew" column
		dataColumn = dataTable.Columns.Add("IsNew", typeof(int));
		// Create the "IsPromotion" column
		dataColumn = dataTable.Columns.Add("IsPromotion", typeof(int));
		// Create the "Space_ID" column
		dataColumn = dataTable.Columns.Add("Space_ID", typeof(string));
		dataColumn.MaxLength = 400;
		// Create the "ProductAttach_ID" column
		dataColumn = dataTable.Columns.Add("ProductAttach_ID", typeof(string));
		dataColumn.MaxLength = 400;
		// Create the "NoteAgencyNorthPrice" column
		dataColumn = dataTable.Columns.Add("NoteAgencyNorthPrice", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "NoteAgencySouthPrice" column
		dataColumn = dataTable.Columns.Add("NoteAgencySouthPrice", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Star" column
		dataColumn = dataTable.Columns.Add("Star", typeof(int));
		// Create the "Note" column
		dataColumn = dataTable.Columns.Add("Note", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Keyword" column
		dataColumn = dataTable.Columns.Add("Keyword", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Deleted" column
		dataColumn = dataTable.Columns.Add("Deleted", typeof(bool));
		// Create the "IsQRCode" column
		dataColumn = dataTable.Columns.Add("IsQRCode", typeof(bool));
		// Create the "SeoKeyword" column
		dataColumn = dataTable.Columns.Add("SeoKeyword", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "SeoDescription" column
		dataColumn = dataTable.Columns.Add("SeoDescription", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "IsProductTwoStamp" column
		dataColumn = dataTable.Columns.Add("IsProductTwoStamp", typeof(bool));
		// Create the "ListProduct_ID_TwoStamp" column
		dataColumn = dataTable.Columns.Add("ListProduct_ID_TwoStamp", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "ProductInWarehouse" column
		dataColumn = dataTable.Columns.Add("ProductInWarehouse", typeof(int));
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
			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Store_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductCategory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Quality_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Customer_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Country_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Content":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Image":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityImages":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Price":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "PriceOld":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "Unit":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "URL":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityOrganizationName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityOrganizationAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityDescription":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "GrowthByDay":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Expiry":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ExpiryByDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WarrantyMonth":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
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

			case "ExpectedProductivity":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ExpectedOutput":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ExpectedProductivityDescription":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ExpectedOutputDescription":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SGTIN":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Acreage":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "TrackingCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Product_ID_Parent":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Story":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Priority":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "Trongluong":
				parameter = _db.AddParameter(cmd, paramName, DbType.Double, value);
				break;

			case "TrongluongThuc":
				parameter = _db.AddParameter(cmd, paramName, DbType.Double, value);
				break;

			case "Size":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "MaterialCategory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SKU_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SKU_Web_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Color_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Video":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Tags":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "AgencyNorthPrice":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "ProductSet_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Parent_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Level":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Classify":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WarrantyDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AgencySouthPrice":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "IsHot":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IsHome":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IsNew":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "IsPromotion":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Space_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductAttach_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "NoteAgencyNorthPrice":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "NoteAgencySouthPrice":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Star":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Note":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Keyword":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Deleted":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "IsQRCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "SeoKeyword":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SeoDescription":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "IsProductTwoStamp":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "ListProduct_ID_TwoStamp":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductInWarehouse":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="ProductRow"/> by the primary key.
	/// </summary>
	/// <param name="product_ID">The <c>Product_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int product_ID)
	{
		string LOCATION = "Exist(int product_ID)";
		IDbCommand cmd = _db.CreateCommand("Product_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Product_ID", product_ID);
		ProductRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




