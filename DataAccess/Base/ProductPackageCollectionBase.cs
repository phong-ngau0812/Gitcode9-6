
// <fileinfo name="Base\ProductPackageCollectionBase.cs">
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
/// The base class for <see cref="ProductPackageCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string Zone_IDColumnName  = "Zone_ID";
	public const string Area_IDColumnName  = "Area_ID";
	public const string Workshop_IDColumnName  = "Workshop_ID";
	public const string Farm_IDColumnName  = "Farm_ID";
	public const string ProductPackageStatus_IDColumnName  = "ProductPackageStatus_ID";
	public const string ProductPackageOrder_IDColumnName  = "ProductPackageOrder_ID";
	public const string CodeColumnName  = "Code";
	public const string NameColumnName  = "Name";
	public const string ProductNameColumnName  = "ProductName";
	public const string DescriptionColumnName  = "Description";
	public const string CultivarColumnName  = "Cultivar";
	public const string CameraURLColumnName  = "CameraURL";
	public const string LocationColumnName  = "Location";
	public const string SecretaryColumnName  = "Secretary";
	public const string StartDateColumnName  = "StartDate";
	public const string CropDateColumnName  = "CropDate";
	public const string EndDateColumnName  = "EndDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string TechnicalByColumnName  = "TechnicalBy";
	public const string QRCodePublicContentColumnName  = "QRCodePublicContent";
	public const string ItemCountColumnName  = "ItemCount";
	public const string AcreageColumnName  = "Acreage";
	public const string GrowthByDateColumnName  = "GrowthByDate";
	public const string ExpectedHarvestDateColumnName  = "ExpectedHarvestDate";
	public const string ExpectedProductivityColumnName  = "ExpectedProductivity";
	public const string ExpectedOutputColumnName  = "ExpectedOutput";
	public const string Customer_IDColumnName  = "Customer_ID";
	public const string SGTINColumnName  = "SGTIN";
	public const string SGTIN_HistoryColumnName  = "SGTIN_History";
	public const string Supplier_IDColumnName  = "Supplier_ID";
	public const string StorageTemperaturesColumnName  = "StorageTemperatures";
	public const string Secretary_UserIDColumnName  = "Secretary_UserID";
	public const string TestingCertificates_IDColumnName  = "TestingCertificates_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductPackageCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "ProductPackage";
	}

	public ProductPackageCollectionBase() : base()
	{
		this.TABLENAME = "ProductPackage";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>ProductPackage</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductPackageRow"/> objects.</returns>
	public virtual ProductPackageRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>ProductPackage</c> table.
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
	/// to retrieve all records from the <c>ProductPackage</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("ProductPackage_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductPackageRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductPackageRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductPackageRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductPackageRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="ProductPackageRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductPackageRow"/> objects.</returns>
	public ProductPackageRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="ProductPackageRow"/> objects that 
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
	/// <returns>An array of <see cref="ProductPackageRow"/> objects.</returns>
	public virtual ProductPackageRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductPackageRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("ProductPackage_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("ProductPackage_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="ProductPackageRow"/> by the primary key.
	/// </summary>
	/// <param name="productPackage_ID">The <c>ProductPackage_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductPackageRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual ProductPackageRow GetByPrimaryKey(int productPackage_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackage_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("ProductPackage_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "ProductPackage_ID", productPackage_ID);
			ProductPackageRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>ProductPackage</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductPackageRow"/> object to be inserted.</param>
	public virtual void Insert(ProductPackageRow value)
	{
		string LOCATION = "Insert(ProductPackageRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductPackage_Insert", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Zone_ID
			if (value.IsZone_IDNull)
				AddParameter(cmd, "Zone_ID", DBNull.Value);
			else
				AddParameter(cmd, "Zone_ID", value.Zone_ID);
			
				// Area_ID
			if (value.IsArea_IDNull)
				AddParameter(cmd, "Area_ID", DBNull.Value);
			else
				AddParameter(cmd, "Area_ID", value.Area_ID);
			
				// Workshop_ID
			if (value.IsWorkshop_IDNull)
				AddParameter(cmd, "Workshop_ID", DBNull.Value);
			else
				AddParameter(cmd, "Workshop_ID", value.Workshop_ID);
			
				// Farm_ID
			if (value.IsFarm_IDNull)
				AddParameter(cmd, "Farm_ID", DBNull.Value);
			else
				AddParameter(cmd, "Farm_ID", value.Farm_ID);
			
				// ProductPackageStatus_ID
			if (value.IsProductPackageStatus_IDNull)
				AddParameter(cmd, "ProductPackageStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageStatus_ID", value.ProductPackageStatus_ID);
			
				// ProductPackageOrder_ID
			if (value.IsProductPackageOrder_IDNull)
				AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);
			
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
			
				// ProductName
			if (value.IsProductNameNull )
				AddParameter(cmd, "ProductName", DBNull.Value);
			else
				AddParameter(cmd, "ProductName", value.ProductName);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// Cultivar
			if (value.IsCultivarNull )
				AddParameter(cmd, "Cultivar", DBNull.Value);
			else
				AddParameter(cmd, "Cultivar", value.Cultivar);
			
				// CameraURL
			if (value.IsCameraURLNull )
				AddParameter(cmd, "CameraURL", DBNull.Value);
			else
				AddParameter(cmd, "CameraURL", value.CameraURL);
			
				// Location
			if (value.IsLocationNull )
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
			
				// Secretary
			if (value.IsSecretaryNull )
				AddParameter(cmd, "Secretary", DBNull.Value);
			else
				AddParameter(cmd, "Secretary", value.Secretary);
			
				// StartDate
			if (value.IsStartDateNull)
				AddParameter(cmd, "StartDate", DBNull.Value);
			else
				AddParameter(cmd, "StartDate", value.StartDate);
			
				// CropDate
			if (value.IsCropDateNull)
				AddParameter(cmd, "CropDate", DBNull.Value);
			else
				AddParameter(cmd, "CropDate", value.CropDate);
			
				// EndDate
			if (value.IsEndDateNull)
				AddParameter(cmd, "EndDate", DBNull.Value);
			else
				AddParameter(cmd, "EndDate", value.EndDate);
			
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
			
				// TechnicalBy
			if (value.IsTechnicalByNull)
				AddParameter(cmd, "TechnicalBy", DBNull.Value);
			else
				AddParameter(cmd, "TechnicalBy", value.TechnicalBy);
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull )
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
			
				// ItemCount
			if (value.IsItemCountNull)
				AddParameter(cmd, "ItemCount", DBNull.Value);
			else
				AddParameter(cmd, "ItemCount", value.ItemCount);
			
				// Acreage
			if (value.IsAcreageNull)
				AddParameter(cmd, "Acreage", DBNull.Value);
			else
				AddParameter(cmd, "Acreage", value.Acreage);
			
				// GrowthByDate
			if (value.IsGrowthByDateNull)
				AddParameter(cmd, "GrowthByDate", DBNull.Value);
			else
				AddParameter(cmd, "GrowthByDate", value.GrowthByDate);
			
				// ExpectedHarvestDate
			if (value.IsExpectedHarvestDateNull)
				AddParameter(cmd, "ExpectedHarvestDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedHarvestDate", value.ExpectedHarvestDate);
			
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
			
				// Customer_ID
			if (value.IsCustomer_IDNull )
				AddParameter(cmd, "Customer_ID", DBNull.Value);
			else
				AddParameter(cmd, "Customer_ID", value.Customer_ID);
			
				// SGTIN
			if (value.IsSGTINNull )
				AddParameter(cmd, "SGTIN", DBNull.Value);
			else
				AddParameter(cmd, "SGTIN", value.SGTIN);
			
				// SGTIN_History
			if (value.IsSGTIN_HistoryNull )
				AddParameter(cmd, "SGTIN_History", DBNull.Value);
			else
				AddParameter(cmd, "SGTIN_History", value.SGTIN_History);
			
				// Supplier_ID
			if (value.IsSupplier_IDNull )
				AddParameter(cmd, "Supplier_ID", DBNull.Value);
			else
				AddParameter(cmd, "Supplier_ID", value.Supplier_ID);
			
				// StorageTemperatures
			if (value.IsStorageTemperaturesNull )
				AddParameter(cmd, "StorageTemperatures", DBNull.Value);
			else
				AddParameter(cmd, "StorageTemperatures", value.StorageTemperatures);
			
				// Secretary_UserID
			if (value.IsSecretary_UserIDNull)
				AddParameter(cmd, "Secretary_UserID", DBNull.Value);
			else
				AddParameter(cmd, "Secretary_UserID", value.Secretary_UserID);
			
				// TestingCertificates_ID
			if (value.IsTestingCertificates_IDNull )
				AddParameter(cmd, "TestingCertificates_ID", DBNull.Value);
			else
				AddParameter(cmd, "TestingCertificates_ID", value.TestingCertificates_ID);
			
						value.ProductPackage_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>ProductPackage</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductPackageRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(ProductPackageRow value)
	{	
		string LOCATION = "Update(ProductPackageRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductPackage_Update", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Zone_ID
			if (value.IsZone_IDNull)
				AddParameter(cmd, "Zone_ID", DBNull.Value);
			else
				AddParameter(cmd, "Zone_ID", value.Zone_ID);
			
				// Area_ID
			if (value.IsArea_IDNull)
				AddParameter(cmd, "Area_ID", DBNull.Value);
			else
				AddParameter(cmd, "Area_ID", value.Area_ID);
			
				// Workshop_ID
			if (value.IsWorkshop_IDNull)
				AddParameter(cmd, "Workshop_ID", DBNull.Value);
			else
				AddParameter(cmd, "Workshop_ID", value.Workshop_ID);
			
				// Farm_ID
			if (value.IsFarm_IDNull)
				AddParameter(cmd, "Farm_ID", DBNull.Value);
			else
				AddParameter(cmd, "Farm_ID", value.Farm_ID);
			
				// ProductPackageStatus_ID
			if (value.IsProductPackageStatus_IDNull)
				AddParameter(cmd, "ProductPackageStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageStatus_ID", value.ProductPackageStatus_ID);
			
				// ProductPackageOrder_ID
			if (value.IsProductPackageOrder_IDNull)
				AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);
			
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
				// ProductName
			if (value.IsProductNameNull)
				AddParameter(cmd, "ProductName", DBNull.Value);
			else
				AddParameter(cmd, "ProductName", value.ProductName);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// Cultivar
			if (value.IsCultivarNull)
				AddParameter(cmd, "Cultivar", DBNull.Value);
			else
				AddParameter(cmd, "Cultivar", value.Cultivar);
				// CameraURL
			if (value.IsCameraURLNull)
				AddParameter(cmd, "CameraURL", DBNull.Value);
			else
				AddParameter(cmd, "CameraURL", value.CameraURL);
				// Location
			if (value.IsLocationNull)
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
				// Secretary
			if (value.IsSecretaryNull)
				AddParameter(cmd, "Secretary", DBNull.Value);
			else
				AddParameter(cmd, "Secretary", value.Secretary);
				// StartDate
			if (value.IsStartDateNull)
				AddParameter(cmd, "StartDate", DBNull.Value);
			else
				AddParameter(cmd, "StartDate", value.StartDate);
			
				// CropDate
			if (value.IsCropDateNull)
				AddParameter(cmd, "CropDate", DBNull.Value);
			else
				AddParameter(cmd, "CropDate", value.CropDate);
			
				// EndDate
			if (value.IsEndDateNull)
				AddParameter(cmd, "EndDate", DBNull.Value);
			else
				AddParameter(cmd, "EndDate", value.EndDate);
			
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
			
				// TechnicalBy
			if (value.IsTechnicalByNull)
				AddParameter(cmd, "TechnicalBy", DBNull.Value);
			else
				AddParameter(cmd, "TechnicalBy", value.TechnicalBy);
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull)
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
				// ItemCount
			if (value.IsItemCountNull)
				AddParameter(cmd, "ItemCount", DBNull.Value);
			else
				AddParameter(cmd, "ItemCount", value.ItemCount);
			
				// Acreage
			if (value.IsAcreageNull)
				AddParameter(cmd, "Acreage", DBNull.Value);
			else
				AddParameter(cmd, "Acreage", value.Acreage);
			
				// GrowthByDate
			if (value.IsGrowthByDateNull)
				AddParameter(cmd, "GrowthByDate", DBNull.Value);
			else
				AddParameter(cmd, "GrowthByDate", value.GrowthByDate);
			
				// ExpectedHarvestDate
			if (value.IsExpectedHarvestDateNull)
				AddParameter(cmd, "ExpectedHarvestDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpectedHarvestDate", value.ExpectedHarvestDate);
			
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
			
				// Customer_ID
			if (value.IsCustomer_IDNull)
				AddParameter(cmd, "Customer_ID", DBNull.Value);
			else
				AddParameter(cmd, "Customer_ID", value.Customer_ID);
				// SGTIN
			if (value.IsSGTINNull)
				AddParameter(cmd, "SGTIN", DBNull.Value);
			else
				AddParameter(cmd, "SGTIN", value.SGTIN);
				// SGTIN_History
			if (value.IsSGTIN_HistoryNull)
				AddParameter(cmd, "SGTIN_History", DBNull.Value);
			else
				AddParameter(cmd, "SGTIN_History", value.SGTIN_History);
				// Supplier_ID
			if (value.IsSupplier_IDNull)
				AddParameter(cmd, "Supplier_ID", DBNull.Value);
			else
				AddParameter(cmd, "Supplier_ID", value.Supplier_ID);
				// StorageTemperatures
			if (value.IsStorageTemperaturesNull)
				AddParameter(cmd, "StorageTemperatures", DBNull.Value);
			else
				AddParameter(cmd, "StorageTemperatures", value.StorageTemperatures);
				// Secretary_UserID
			if (value.IsSecretary_UserIDNull)
				AddParameter(cmd, "Secretary_UserID", DBNull.Value);
			else
				AddParameter(cmd, "Secretary_UserID", value.Secretary_UserID);
			
				// TestingCertificates_ID
			if (value.IsTestingCertificates_IDNull)
				AddParameter(cmd, "TestingCertificates_ID", DBNull.Value);
			else
				AddParameter(cmd, "TestingCertificates_ID", value.TestingCertificates_ID);
					AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
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
		/// Inserts or Updates a record in the <c>ProductPackage</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="ProductPackageRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(ProductPackageRow value)
		{
			string LOCATION = "Save(ProductPackageRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("ProductPackage_Save",CommandType.StoredProcedure);
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
				
					// Zone_ID
				if (value.IsZone_IDNull)
					AddParameter(cmd, "Zone_ID", DBNull.Value);
				else
					AddParameter(cmd, "Zone_ID", (object)(value.Zone_ID));
				
					// Area_ID
				if (value.IsArea_IDNull)
					AddParameter(cmd, "Area_ID", DBNull.Value);
				else
					AddParameter(cmd, "Area_ID", (object)(value.Area_ID));
				
					// Workshop_ID
				if (value.IsWorkshop_IDNull)
					AddParameter(cmd, "Workshop_ID", DBNull.Value);
				else
					AddParameter(cmd, "Workshop_ID", (object)(value.Workshop_ID));
				
					// Farm_ID
				if (value.IsFarm_IDNull)
					AddParameter(cmd, "Farm_ID", DBNull.Value);
				else
					AddParameter(cmd, "Farm_ID", (object)(value.Farm_ID));
				
					// ProductPackageStatus_ID
				if (value.IsProductPackageStatus_IDNull)
					AddParameter(cmd, "ProductPackageStatus_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackageStatus_ID", (object)(value.ProductPackageStatus_ID));
				
					// ProductPackageOrder_ID
				if (value.IsProductPackageOrder_IDNull)
					AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackageOrder_ID", (object)(value.ProductPackageOrder_ID));
				
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
				
					// ProductName
				if (value.IsProductNameNull)
					AddParameter(cmd, "ProductName", DBNull.Value);
				else
					AddParameter(cmd, "ProductName", (object)(value.ProductName));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// Cultivar
				if (value.IsCultivarNull)
					AddParameter(cmd, "Cultivar", DBNull.Value);
				else
					AddParameter(cmd, "Cultivar", (object)(value.Cultivar));
				
					// CameraURL
				if (value.IsCameraURLNull)
					AddParameter(cmd, "CameraURL", DBNull.Value);
				else
					AddParameter(cmd, "CameraURL", (object)(value.CameraURL));
				
					// Location
				if (value.IsLocationNull)
					AddParameter(cmd, "Location", DBNull.Value);
				else
					AddParameter(cmd, "Location", (object)(value.Location));
				
					// Secretary
				if (value.IsSecretaryNull)
					AddParameter(cmd, "Secretary", DBNull.Value);
				else
					AddParameter(cmd, "Secretary", (object)(value.Secretary));
				
					// StartDate
				if (value.IsStartDateNull)
					AddParameter(cmd, "StartDate", DBNull.Value);
				else
					AddParameter(cmd, "StartDate", (object)(value.StartDate));
				
					// CropDate
				if (value.IsCropDateNull)
					AddParameter(cmd, "CropDate", DBNull.Value);
				else
					AddParameter(cmd, "CropDate", (object)(value.CropDate));
				
					// EndDate
				if (value.IsEndDateNull)
					AddParameter(cmd, "EndDate", DBNull.Value);
				else
					AddParameter(cmd, "EndDate", (object)(value.EndDate));
				
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
				
					// TechnicalBy
				if (value.IsTechnicalByNull)
					AddParameter(cmd, "TechnicalBy", DBNull.Value);
				else
					AddParameter(cmd, "TechnicalBy", (object)(value.TechnicalBy));
				
					// QRCodePublicContent
				if (value.IsQRCodePublicContentNull)
					AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePublicContent", (object)(value.QRCodePublicContent));
				
					// ItemCount
				if (value.IsItemCountNull)
					AddParameter(cmd, "ItemCount", DBNull.Value);
				else
					AddParameter(cmd, "ItemCount", (object)(value.ItemCount));
				
					// Acreage
				if (value.IsAcreageNull)
					AddParameter(cmd, "Acreage", DBNull.Value);
				else
					AddParameter(cmd, "Acreage", (object)(value.Acreage));
				
					// GrowthByDate
				if (value.IsGrowthByDateNull)
					AddParameter(cmd, "GrowthByDate", DBNull.Value);
				else
					AddParameter(cmd, "GrowthByDate", (object)(value.GrowthByDate));
				
					// ExpectedHarvestDate
				if (value.IsExpectedHarvestDateNull)
					AddParameter(cmd, "ExpectedHarvestDate", DBNull.Value);
				else
					AddParameter(cmd, "ExpectedHarvestDate", (object)(value.ExpectedHarvestDate));
				
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
				
					// Customer_ID
				if (value.IsCustomer_IDNull)
					AddParameter(cmd, "Customer_ID", DBNull.Value);
				else
					AddParameter(cmd, "Customer_ID", (object)(value.Customer_ID));
				
					// SGTIN
				if (value.IsSGTINNull)
					AddParameter(cmd, "SGTIN", DBNull.Value);
				else
					AddParameter(cmd, "SGTIN", (object)(value.SGTIN));
				
					// SGTIN_History
				if (value.IsSGTIN_HistoryNull)
					AddParameter(cmd, "SGTIN_History", DBNull.Value);
				else
					AddParameter(cmd, "SGTIN_History", (object)(value.SGTIN_History));
				
					// Supplier_ID
				if (value.IsSupplier_IDNull)
					AddParameter(cmd, "Supplier_ID", DBNull.Value);
				else
					AddParameter(cmd, "Supplier_ID", (object)(value.Supplier_ID));
				
					// StorageTemperatures
				if (value.IsStorageTemperaturesNull)
					AddParameter(cmd, "StorageTemperatures", DBNull.Value);
				else
					AddParameter(cmd, "StorageTemperatures", (object)(value.StorageTemperatures));
				
					// Secretary_UserID
				if (value.IsSecretary_UserIDNull)
					AddParameter(cmd, "Secretary_UserID", DBNull.Value);
				else
					AddParameter(cmd, "Secretary_UserID", (object)(value.Secretary_UserID));
				
					// TestingCertificates_ID
				if (value.IsTestingCertificates_IDNull)
					AddParameter(cmd, "TestingCertificates_ID", DBNull.Value);
				else
					AddParameter(cmd, "TestingCertificates_ID", (object)(value.TestingCertificates_ID));
				
						AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
						value.ProductPackage_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["ProductPackage_ID"]);
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
	/// Deletes the specified object from the <c>ProductPackage</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductPackageRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(ProductPackageRow value)
	{
		return DeleteByPrimaryKey(value.ProductPackage_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>ProductPackage</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="productPackage_ID">The <c>ProductPackage_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int productPackage_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackage_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductPackage_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "ProductPackage_ID", productPackage_ID);
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
	/// Deletes <c>ProductPackage</c> records that match the specified criteria.
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
	/// to delete <c>ProductPackage</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductPackage_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>ProductPackage</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("ProductPackage_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="ProductPackageRow"/> objects.</returns>
	protected ProductPackageRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="ProductPackageRow"/> objects.</returns>
	protected ProductPackageRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="ProductPackageRow"/> objects.</returns>
	protected virtual ProductPackageRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// Zone_ID
		int zone_IDColumnIndex = reader.GetOrdinal("Zone_ID");
		// Area_ID
		int area_IDColumnIndex = reader.GetOrdinal("Area_ID");
		// Workshop_ID
		int workshop_IDColumnIndex = reader.GetOrdinal("Workshop_ID");
		// Farm_ID
		int farm_IDColumnIndex = reader.GetOrdinal("Farm_ID");
		// ProductPackageStatus_ID
		int productPackageStatus_IDColumnIndex = reader.GetOrdinal("ProductPackageStatus_ID");
		// ProductPackageOrder_ID
		int productPackageOrder_IDColumnIndex = reader.GetOrdinal("ProductPackageOrder_ID");
		// Code
		int codeColumnIndex = reader.GetOrdinal("Code");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// ProductName
		int productNameColumnIndex = reader.GetOrdinal("ProductName");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Cultivar
		int cultivarColumnIndex = reader.GetOrdinal("Cultivar");
		// CameraURL
		int cameraURLColumnIndex = reader.GetOrdinal("CameraURL");
		// Location
		int locationColumnIndex = reader.GetOrdinal("Location");
		// Secretary
		int secretaryColumnIndex = reader.GetOrdinal("Secretary");
		// StartDate
		int startDateColumnIndex = reader.GetOrdinal("StartDate");
		// CropDate
		int cropDateColumnIndex = reader.GetOrdinal("CropDate");
		// EndDate
		int endDateColumnIndex = reader.GetOrdinal("EndDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// TechnicalBy
		int technicalByColumnIndex = reader.GetOrdinal("TechnicalBy");
		// QRCodePublicContent
		int qRCodePublicContentColumnIndex = reader.GetOrdinal("QRCodePublicContent");
		// ItemCount
		int itemCountColumnIndex = reader.GetOrdinal("ItemCount");
		// Acreage
		int acreageColumnIndex = reader.GetOrdinal("Acreage");
		// GrowthByDate
		int growthByDateColumnIndex = reader.GetOrdinal("GrowthByDate");
		// ExpectedHarvestDate
		int expectedHarvestDateColumnIndex = reader.GetOrdinal("ExpectedHarvestDate");
		// ExpectedProductivity
		int expectedProductivityColumnIndex = reader.GetOrdinal("ExpectedProductivity");
		// ExpectedOutput
		int expectedOutputColumnIndex = reader.GetOrdinal("ExpectedOutput");
		// Customer_ID
		int customer_IDColumnIndex = reader.GetOrdinal("Customer_ID");
		// SGTIN
		int sgtinColumnIndex = reader.GetOrdinal("SGTIN");
		// SGTIN_History
		int sGTIN_HistoryColumnIndex = reader.GetOrdinal("SGTIN_History");
		// Supplier_ID
		int supplier_IDColumnIndex = reader.GetOrdinal("Supplier_ID");
		// StorageTemperatures
		int storageTemperaturesColumnIndex = reader.GetOrdinal("StorageTemperatures");
		// Secretary_UserID
		int secretary_UserIDColumnIndex = reader.GetOrdinal("Secretary_UserID");
		// TestingCertificates_ID
		int testingCertificates_IDColumnIndex = reader.GetOrdinal("TestingCertificates_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				ProductPackageRow record = new ProductPackageRow();
				recordList.Add(record);

					record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(zone_IDColumnIndex))
						record.Zone_ID = Convert.ToInt32(reader.GetValue(zone_IDColumnIndex));
					if(!reader.IsDBNull(area_IDColumnIndex))
						record.Area_ID = Convert.ToInt32(reader.GetValue(area_IDColumnIndex));
					if(!reader.IsDBNull(workshop_IDColumnIndex))
						record.Workshop_ID = Convert.ToInt32(reader.GetValue(workshop_IDColumnIndex));
					if(!reader.IsDBNull(farm_IDColumnIndex))
						record.Farm_ID = Convert.ToInt32(reader.GetValue(farm_IDColumnIndex));
					if(!reader.IsDBNull(productPackageStatus_IDColumnIndex))
						record.ProductPackageStatus_ID = Convert.ToInt32(reader.GetValue(productPackageStatus_IDColumnIndex));
					if(!reader.IsDBNull(productPackageOrder_IDColumnIndex))
						record.ProductPackageOrder_ID = Convert.ToInt32(reader.GetValue(productPackageOrder_IDColumnIndex));
					if(!reader.IsDBNull(codeColumnIndex))
						record.Code = Convert.ToString(reader.GetValue(codeColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(productNameColumnIndex))
						record.ProductName = Convert.ToString(reader.GetValue(productNameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(cultivarColumnIndex))
						record.Cultivar = Convert.ToString(reader.GetValue(cultivarColumnIndex));
					if(!reader.IsDBNull(cameraURLColumnIndex))
						record.CameraURL = Convert.ToString(reader.GetValue(cameraURLColumnIndex));
					if(!reader.IsDBNull(locationColumnIndex))
						record.Location = Convert.ToString(reader.GetValue(locationColumnIndex));
					if(!reader.IsDBNull(secretaryColumnIndex))
						record.Secretary = Convert.ToString(reader.GetValue(secretaryColumnIndex));
					if(!reader.IsDBNull(startDateColumnIndex))
						record.StartDate = Convert.ToDateTime(reader.GetValue(startDateColumnIndex));
					if(!reader.IsDBNull(cropDateColumnIndex))
						record.CropDate = Convert.ToDateTime(reader.GetValue(cropDateColumnIndex));
					if(!reader.IsDBNull(endDateColumnIndex))
						record.EndDate = Convert.ToDateTime(reader.GetValue(endDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(technicalByColumnIndex))
						record.TechnicalBy = reader.GetGuid(technicalByColumnIndex);
					if(!reader.IsDBNull(qRCodePublicContentColumnIndex))
						record.QRCodePublicContent = Convert.ToString(reader.GetValue(qRCodePublicContentColumnIndex));
					if(!reader.IsDBNull(itemCountColumnIndex))
						record.ItemCount = Convert.ToInt32(reader.GetValue(itemCountColumnIndex));
					if(!reader.IsDBNull(acreageColumnIndex))
						record.Acreage = Convert.ToInt32(reader.GetValue(acreageColumnIndex));
					if(!reader.IsDBNull(growthByDateColumnIndex))
						record.GrowthByDate = Convert.ToInt32(reader.GetValue(growthByDateColumnIndex));
					if(!reader.IsDBNull(expectedHarvestDateColumnIndex))
						record.ExpectedHarvestDate = Convert.ToInt32(reader.GetValue(expectedHarvestDateColumnIndex));
					if(!reader.IsDBNull(expectedProductivityColumnIndex))
						record.ExpectedProductivity = Convert.ToInt32(reader.GetValue(expectedProductivityColumnIndex));
					if(!reader.IsDBNull(expectedOutputColumnIndex))
						record.ExpectedOutput = Convert.ToInt32(reader.GetValue(expectedOutputColumnIndex));
					if(!reader.IsDBNull(customer_IDColumnIndex))
						record.Customer_ID = Convert.ToString(reader.GetValue(customer_IDColumnIndex));
					if(!reader.IsDBNull(sgtinColumnIndex))
						record.SGTIN = Convert.ToString(reader.GetValue(sgtinColumnIndex));
					if(!reader.IsDBNull(sGTIN_HistoryColumnIndex))
						record.SGTIN_History = Convert.ToString(reader.GetValue(sGTIN_HistoryColumnIndex));
					if(!reader.IsDBNull(supplier_IDColumnIndex))
						record.Supplier_ID = Convert.ToString(reader.GetValue(supplier_IDColumnIndex));
					if(!reader.IsDBNull(storageTemperaturesColumnIndex))
						record.StorageTemperatures = Convert.ToString(reader.GetValue(storageTemperaturesColumnIndex));
					if(!reader.IsDBNull(secretary_UserIDColumnIndex))
						record.Secretary_UserID = reader.GetGuid(secretary_UserIDColumnIndex);
					if(!reader.IsDBNull(testingCertificates_IDColumnIndex))
						record.TestingCertificates_ID = Convert.ToString(reader.GetValue(testingCertificates_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (ProductPackageRow[])(recordList.ToArray(typeof(ProductPackageRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductPackageRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductPackageRow"/> object.</returns>
	protected virtual ProductPackageRow MapRow(DataRow row)
	{
		string LOCATION = "ProductPackageRow MapRow(DataRow row)";
		ProductPackageRow mappedObject = new ProductPackageRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "Zone_ID"
		dataColumn = dataTable.Columns["Zone_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Zone_ID = (int)(row[dataColumn]);
		// Column "Area_ID"
		dataColumn = dataTable.Columns["Area_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Area_ID = (int)(row[dataColumn]);
		// Column "Workshop_ID"
		dataColumn = dataTable.Columns["Workshop_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Workshop_ID = (int)(row[dataColumn]);
		// Column "Farm_ID"
		dataColumn = dataTable.Columns["Farm_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Farm_ID = (int)(row[dataColumn]);
		// Column "ProductPackageStatus_ID"
		dataColumn = dataTable.Columns["ProductPackageStatus_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackageStatus_ID = (int)(row[dataColumn]);
		// Column "ProductPackageOrder_ID"
		dataColumn = dataTable.Columns["ProductPackageOrder_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackageOrder_ID = (int)(row[dataColumn]);
		// Column "Code"
		dataColumn = dataTable.Columns["Code"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Code = (string)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "ProductName"
		dataColumn = dataTable.Columns["ProductName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductName = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Cultivar"
		dataColumn = dataTable.Columns["Cultivar"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Cultivar = (string)(row[dataColumn]);
		// Column "CameraURL"
		dataColumn = dataTable.Columns["CameraURL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CameraURL = (string)(row[dataColumn]);
		// Column "Location"
		dataColumn = dataTable.Columns["Location"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location = (string)(row[dataColumn]);
		// Column "Secretary"
		dataColumn = dataTable.Columns["Secretary"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Secretary = (string)(row[dataColumn]);
		// Column "StartDate"
		dataColumn = dataTable.Columns["StartDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StartDate = (System.DateTime)(row[dataColumn]);
		// Column "CropDate"
		dataColumn = dataTable.Columns["CropDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CropDate = (System.DateTime)(row[dataColumn]);
		// Column "EndDate"
		dataColumn = dataTable.Columns["EndDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EndDate = (System.DateTime)(row[dataColumn]);
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
		// Column "TechnicalBy"
		dataColumn = dataTable.Columns["TechnicalBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TechnicalBy = (System.Guid)(row[dataColumn]);
		// Column "QRCodePublicContent"
		dataColumn = dataTable.Columns["QRCodePublicContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePublicContent = (string)(row[dataColumn]);
		// Column "ItemCount"
		dataColumn = dataTable.Columns["ItemCount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ItemCount = (int)(row[dataColumn]);
		// Column "Acreage"
		dataColumn = dataTable.Columns["Acreage"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Acreage = (int)(row[dataColumn]);
		// Column "GrowthByDate"
		dataColumn = dataTable.Columns["GrowthByDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GrowthByDate = (int)(row[dataColumn]);
		// Column "ExpectedHarvestDate"
		dataColumn = dataTable.Columns["ExpectedHarvestDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedHarvestDate = (int)(row[dataColumn]);
		// Column "ExpectedProductivity"
		dataColumn = dataTable.Columns["ExpectedProductivity"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedProductivity = (int)(row[dataColumn]);
		// Column "ExpectedOutput"
		dataColumn = dataTable.Columns["ExpectedOutput"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpectedOutput = (int)(row[dataColumn]);
		// Column "Customer_ID"
		dataColumn = dataTable.Columns["Customer_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Customer_ID = (string)(row[dataColumn]);
		// Column "SGTIN"
		dataColumn = dataTable.Columns["SGTIN"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SGTIN = (string)(row[dataColumn]);
		// Column "SGTIN_History"
		dataColumn = dataTable.Columns["SGTIN_History"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SGTIN_History = (string)(row[dataColumn]);
		// Column "Supplier_ID"
		dataColumn = dataTable.Columns["Supplier_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Supplier_ID = (string)(row[dataColumn]);
		// Column "StorageTemperatures"
		dataColumn = dataTable.Columns["StorageTemperatures"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StorageTemperatures = (string)(row[dataColumn]);
		// Column "Secretary_UserID"
		dataColumn = dataTable.Columns["Secretary_UserID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Secretary_UserID = (System.Guid)(row[dataColumn]);
		// Column "TestingCertificates_ID"
		dataColumn = dataTable.Columns["TestingCertificates_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TestingCertificates_ID = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>ProductPackage</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "ProductPackage";
		DataColumn dataColumn;
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "Zone_ID" column
		dataColumn = dataTable.Columns.Add("Zone_ID", typeof(int));
		// Create the "Area_ID" column
		dataColumn = dataTable.Columns.Add("Area_ID", typeof(int));
		// Create the "Workshop_ID" column
		dataColumn = dataTable.Columns.Add("Workshop_ID", typeof(int));
		// Create the "Farm_ID" column
		dataColumn = dataTable.Columns.Add("Farm_ID", typeof(int));
		// Create the "ProductPackageStatus_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackageStatus_ID", typeof(int));
		// Create the "ProductPackageOrder_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackageOrder_ID", typeof(int));
		// Create the "Code" column
		dataColumn = dataTable.Columns.Add("Code", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductName" column
		dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Cultivar" column
		dataColumn = dataTable.Columns.Add("Cultivar", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CameraURL" column
		dataColumn = dataTable.Columns.Add("CameraURL", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Location" column
		dataColumn = dataTable.Columns.Add("Location", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Secretary" column
		dataColumn = dataTable.Columns.Add("Secretary", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "StartDate" column
		dataColumn = dataTable.Columns.Add("StartDate", typeof(System.DateTime));
		// Create the "CropDate" column
		dataColumn = dataTable.Columns.Add("CropDate", typeof(System.DateTime));
		// Create the "EndDate" column
		dataColumn = dataTable.Columns.Add("EndDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "TechnicalBy" column
		dataColumn = dataTable.Columns.Add("TechnicalBy", typeof(System.Guid));
		// Create the "QRCodePublicContent" column
		dataColumn = dataTable.Columns.Add("QRCodePublicContent", typeof(string));
		dataColumn.MaxLength = 64;
		// Create the "ItemCount" column
		dataColumn = dataTable.Columns.Add("ItemCount", typeof(int));
		// Create the "Acreage" column
		dataColumn = dataTable.Columns.Add("Acreage", typeof(int));
		// Create the "GrowthByDate" column
		dataColumn = dataTable.Columns.Add("GrowthByDate", typeof(int));
		// Create the "ExpectedHarvestDate" column
		dataColumn = dataTable.Columns.Add("ExpectedHarvestDate", typeof(int));
		// Create the "ExpectedProductivity" column
		dataColumn = dataTable.Columns.Add("ExpectedProductivity", typeof(int));
		// Create the "ExpectedOutput" column
		dataColumn = dataTable.Columns.Add("ExpectedOutput", typeof(int));
		// Create the "Customer_ID" column
		dataColumn = dataTable.Columns.Add("Customer_ID", typeof(string));
		// Create the "SGTIN" column
		dataColumn = dataTable.Columns.Add("SGTIN", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "SGTIN_History" column
		dataColumn = dataTable.Columns.Add("SGTIN_History", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "Supplier_ID" column
		dataColumn = dataTable.Columns.Add("Supplier_ID", typeof(string));
		// Create the "StorageTemperatures" column
		dataColumn = dataTable.Columns.Add("StorageTemperatures", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Secretary_UserID" column
		dataColumn = dataTable.Columns.Add("Secretary_UserID", typeof(System.Guid));
		// Create the "TestingCertificates_ID" column
		dataColumn = dataTable.Columns.Add("TestingCertificates_ID", typeof(string));
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
			case "ProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Zone_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Area_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Workshop_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Farm_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackageStatus_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackageOrder_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Code":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Cultivar":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CameraURL":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Secretary":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StartDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CropDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "EndDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
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

			case "TechnicalBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "QRCodePublicContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ItemCount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Acreage":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "GrowthByDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ExpectedHarvestDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ExpectedProductivity":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ExpectedOutput":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Customer_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "SGTIN":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SGTIN_History":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Supplier_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "StorageTemperatures":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Secretary_UserID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "TestingCertificates_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="ProductPackageRow"/> by the primary key.
	/// </summary>
	/// <param name="productPackage_ID">The <c>ProductPackage_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductPackageRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int productPackage_ID)
	{
		string LOCATION = "Exist(int productPackage_ID)";
		IDbCommand cmd = _db.CreateCommand("ProductPackage_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "ProductPackage_ID", productPackage_ID);
		ProductPackageRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




