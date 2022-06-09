
// <fileinfo name="Base\ProductBrandChangeCollectionBase.cs">
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
/// The base class for <see cref="ProductBrandChangeCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductBrandChangeCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductBrandChangeCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string ProductBrandChange_IDColumnName  = "ProductBrandChange_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Language_IDColumnName  = "Language_ID";
	public const string Location_IDColumnName  = "Location_ID";
	public const string District_IDColumnName  = "District_ID";
	public const string Ward_IDColumnName  = "Ward_ID";
	public const string DepartmentMan_IDColumnName  = "DepartmentMan_ID";
	public const string ProductBrandType_IDColumnName  = "ProductBrandType_ID";
	public const string CodeColumnName  = "Code";
	public const string NameColumnName  = "Name";
	public const string TradingNameColumnName  = "TradingName";
	public const string BrandNameColumnName  = "BrandName";
	public const string TaxCodeColumnName  = "TaxCode";
	public const string RegistrationNumberColumnName  = "RegistrationNumber";
	public const string IssuedDateColumnName  = "IssuedDate";
	public const string BusinessAreaColumnName  = "BusinessArea";
	public const string AddressColumnName  = "Address";
	public const string TelephoneColumnName  = "Telephone";
	public const string FaxColumnName  = "Fax";
	public const string MobileColumnName  = "Mobile";
	public const string EmailColumnName  = "Email";
	public const string WebsiteColumnName  = "Website";
	public const string FacebookColumnName  = "Facebook";
	public const string ZaloColumnName  = "Zalo";
	public const string HotlineColumnName  = "Hotline";
	public const string SkypeColumnName  = "Skype";
	public const string PRInfoColumnName  = "PRInfo";
	public const string AgencyColumnName  = "Agency";
	public const string DescriptionColumnName  = "Description";
	public const string ImageColumnName  = "Image";
	public const string PersonNameColumnName  = "PersonName";
	public const string PersonAddressColumnName  = "PersonAddress";
	public const string PersonMobileColumnName  = "PersonMobile";
	public const string PersonEmailColumnName  = "PersonEmail";
	public const string SortColumnName  = "Sort";
	public const string URLColumnName  = "URL";
	public const string ActiveColumnName  = "Active";
	public const string HasQRCodeColumnName  = "HasQRCode";
	public const string ViewCountColumnName  = "ViewCount";
	public const string SellCountColumnName  = "SellCount";
	public const string AccountUserNameColumnName  = "AccountUserName";
	public const string AccountEmailColumnName  = "AccountEmail";
	public const string DirectorNameColumnName  = "DirectorName";
	public const string DirectorBirthdayColumnName  = "DirectorBirthday";
	public const string DirectorAddressColumnName  = "DirectorAddress";
	public const string DirectorMobileColumnName  = "DirectorMobile";
	public const string DirectorEmailColumnName  = "DirectorEmail";
	public const string DirectorPositionColumnName  = "DirectorPosition";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string VerifyApproveByColumnName  = "VerifyApproveBy";
	public const string VerifyApproveDateColumnName  = "VerifyApproveDate";
	public const string CheckApproveByColumnName  = "CheckApproveBy";
	public const string CheckApproveDateColumnName  = "CheckApproveDate";
	public const string AdminApproveByColumnName  = "AdminApproveBy";
	public const string AdminApproveDateColumnName  = "AdminApproveDate";
	public const string QRCodePublicContentColumnName  = "QRCodePublicContent";
	public const string CheckDomainColumnName  = "CheckDomain";
	public const string CheckServer_IDColumnName  = "CheckServer_ID";
	public const string GCPColumnName  = "GCP";
	public const string GLNColumnName  = "GLN";
	public const string ProductBrandType_ID_ListColumnName  = "ProductBrandType_ID_List";
	public const string Branch_IDColumnName  = "Branch_ID";
	public const string ProductionUnitCodeColumnName  = "ProductionUnitCode";
	public const string CheckProductBrand_IDColumnName  = "CheckProductBrand_ID";
	public const string ChainLink_IDColumnName  = "ChainLink_ID";
	public const string StoryColumnName  = "Story";
	public const string FunctionGroup_IDColumnName  = "FunctionGroup_ID";
	public const string BusinessType_IDColumnName  = "BusinessType_ID";
	public const string ProductBrandChange_NoteColumnName  = "ProductBrandChange_Note";
	public const string ProductBrandChange_ByColumnName  = "ProductBrandChange_By";
	public const string ProductBrandChange_ApprovedColumnName  = "ProductBrandChange_Approved";
	public const string ProductBrandChange_DateColumnName  = "ProductBrandChange_Date";
	public const string ProductBrandChange_DateApprovedColumnName  = "ProductBrandChange_DateApproved";
	public const string ProductBrandChange_StatusColumnName  = "ProductBrandChange_Status";
	public const string ProductBrandChange_ApprovedNoteColumnName  = "ProductBrandChange_ApprovedNote";
	public const string YouTubeColumnName  = "YouTube";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public ProductBrandChangeCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "ProductBrandChange";
	}

	public ProductBrandChangeCollectionBase() : base()
	{
		this.TABLENAME = "ProductBrandChange";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <returns>An array of <see cref="ProductBrandChangeRow"/> objects.</returns>
	public virtual ProductBrandChangeRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>ProductBrandChange</c> table.
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
	/// to retrieve all records from the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("ProductBrandChange_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="ProductBrandChangeRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="ProductBrandChangeRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public ProductBrandChangeRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			ProductBrandChangeRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="ProductBrandChangeRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="ProductBrandChangeRow"/> objects.</returns>
	public ProductBrandChangeRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="ProductBrandChangeRow"/> objects that 
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
	/// <returns>An array of <see cref="ProductBrandChangeRow"/> objects.</returns>
	public virtual ProductBrandChangeRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			ProductBrandChangeRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("ProductBrandChange_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("ProductBrandChange_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="ProductBrandChangeRow"/> by the primary key.
	/// </summary>
	/// <param name="productBrandChange_ID">The <c>ProductBrandChange_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductBrandChangeRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual ProductBrandChangeRow GetByPrimaryKey(int productBrandChange_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productBrandChange_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("ProductBrandChange_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "ProductBrandChange_ID", productBrandChange_ID);
			ProductBrandChangeRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductBrandChangeRow"/> object to be inserted.</param>
	public virtual void Insert(ProductBrandChangeRow value)
	{
		string LOCATION = "Insert(ProductBrandChangeRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductBrandChange_Insert", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull )
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Language_ID
			if (value.IsLanguage_IDNull)
				AddParameter(cmd, "Language_ID", DBNull.Value);
			else
				AddParameter(cmd, "Language_ID", value.Language_ID);
			
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
			
				// Ward_ID
			if (value.IsWard_IDNull)
				AddParameter(cmd, "Ward_ID", DBNull.Value);
			else
				AddParameter(cmd, "Ward_ID", value.Ward_ID);
			
				// DepartmentMan_ID
			if (value.IsDepartmentMan_IDNull)
				AddParameter(cmd, "DepartmentMan_ID", DBNull.Value);
			else
				AddParameter(cmd, "DepartmentMan_ID", value.DepartmentMan_ID);
			
				// ProductBrandType_ID
			if (value.IsProductBrandType_IDNull)
				AddParameter(cmd, "ProductBrandType_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandType_ID", value.ProductBrandType_ID);
			
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
			
				// TradingName
			if (value.IsTradingNameNull )
				AddParameter(cmd, "TradingName", DBNull.Value);
			else
				AddParameter(cmd, "TradingName", value.TradingName);
			
				// BrandName
			if (value.IsBrandNameNull )
				AddParameter(cmd, "BrandName", DBNull.Value);
			else
				AddParameter(cmd, "BrandName", value.BrandName);
			
				// TaxCode
			if (value.IsTaxCodeNull )
				AddParameter(cmd, "TaxCode", DBNull.Value);
			else
				AddParameter(cmd, "TaxCode", value.TaxCode);
			
				// RegistrationNumber
			if (value.IsRegistrationNumberNull )
				AddParameter(cmd, "RegistrationNumber", DBNull.Value);
			else
				AddParameter(cmd, "RegistrationNumber", value.RegistrationNumber);
			
				// IssuedDate
			if (value.IsIssuedDateNull)
				AddParameter(cmd, "IssuedDate", DBNull.Value);
			else
				AddParameter(cmd, "IssuedDate", value.IssuedDate);
			
				// BusinessArea
			if (value.IsBusinessAreaNull )
				AddParameter(cmd, "BusinessArea", DBNull.Value);
			else
				AddParameter(cmd, "BusinessArea", value.BusinessArea);
			
				// Address
			if (value.IsAddressNull )
				AddParameter(cmd, "Address", DBNull.Value);
			else
				AddParameter(cmd, "Address", value.Address);
			
				// Telephone
			if (value.IsTelephoneNull )
				AddParameter(cmd, "Telephone", DBNull.Value);
			else
				AddParameter(cmd, "Telephone", value.Telephone);
			
				// Fax
			if (value.IsFaxNull )
				AddParameter(cmd, "Fax", DBNull.Value);
			else
				AddParameter(cmd, "Fax", value.Fax);
			
				// Mobile
			if (value.IsMobileNull )
				AddParameter(cmd, "Mobile", DBNull.Value);
			else
				AddParameter(cmd, "Mobile", value.Mobile);
			
				// Email
			if (value.IsEmailNull )
				AddParameter(cmd, "Email", DBNull.Value);
			else
				AddParameter(cmd, "Email", value.Email);
			
				// Website
			if (value.IsWebsiteNull )
				AddParameter(cmd, "Website", DBNull.Value);
			else
				AddParameter(cmd, "Website", value.Website);
			
				// Facebook
			if (value.IsFacebookNull )
				AddParameter(cmd, "Facebook", DBNull.Value);
			else
				AddParameter(cmd, "Facebook", value.Facebook);
			
				// Zalo
			if (value.IsZaloNull )
				AddParameter(cmd, "Zalo", DBNull.Value);
			else
				AddParameter(cmd, "Zalo", value.Zalo);
			
				// Hotline
			if (value.IsHotlineNull )
				AddParameter(cmd, "Hotline", DBNull.Value);
			else
				AddParameter(cmd, "Hotline", value.Hotline);
			
				// Skype
			if (value.IsSkypeNull )
				AddParameter(cmd, "Skype", DBNull.Value);
			else
				AddParameter(cmd, "Skype", value.Skype);
			
				// PRInfo
			if (value.IsPRInfoNull )
				AddParameter(cmd, "PRInfo", DBNull.Value);
			else
				AddParameter(cmd, "PRInfo", value.PRInfo);
			
				// Agency
			if (value.IsAgencyNull )
				AddParameter(cmd, "Agency", DBNull.Value);
			else
				AddParameter(cmd, "Agency", value.Agency);
			
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
			
				// PersonName
			if (value.IsPersonNameNull )
				AddParameter(cmd, "PersonName", DBNull.Value);
			else
				AddParameter(cmd, "PersonName", value.PersonName);
			
				// PersonAddress
			if (value.IsPersonAddressNull )
				AddParameter(cmd, "PersonAddress", DBNull.Value);
			else
				AddParameter(cmd, "PersonAddress", value.PersonAddress);
			
				// PersonMobile
			if (value.IsPersonMobileNull )
				AddParameter(cmd, "PersonMobile", DBNull.Value);
			else
				AddParameter(cmd, "PersonMobile", value.PersonMobile);
			
				// PersonEmail
			if (value.IsPersonEmailNull )
				AddParameter(cmd, "PersonEmail", DBNull.Value);
			else
				AddParameter(cmd, "PersonEmail", value.PersonEmail);
			
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
				// URL
			if (value.IsURLNull )
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// HasQRCode
			if (value.IsHasQRCodeNull)
				AddParameter(cmd, "HasQRCode", DBNull.Value);
			else
				AddParameter(cmd, "HasQRCode", value.HasQRCode);
			
				// ViewCount
			if (value.IsViewCountNull)
				AddParameter(cmd, "ViewCount", DBNull.Value);
			else
				AddParameter(cmd, "ViewCount", value.ViewCount);
			
				// SellCount
			if (value.IsSellCountNull)
				AddParameter(cmd, "SellCount", DBNull.Value);
			else
				AddParameter(cmd, "SellCount", value.SellCount);
			
				// AccountUserName
			if (value.IsAccountUserNameNull )
				AddParameter(cmd, "AccountUserName", DBNull.Value);
			else
				AddParameter(cmd, "AccountUserName", value.AccountUserName);
			
				// AccountEmail
			if (value.IsAccountEmailNull )
				AddParameter(cmd, "AccountEmail", DBNull.Value);
			else
				AddParameter(cmd, "AccountEmail", value.AccountEmail);
			
				// DirectorName
			if (value.IsDirectorNameNull )
				AddParameter(cmd, "DirectorName", DBNull.Value);
			else
				AddParameter(cmd, "DirectorName", value.DirectorName);
			
				// DirectorBirthday
			if (value.IsDirectorBirthdayNull)
				AddParameter(cmd, "DirectorBirthday", DBNull.Value);
			else
				AddParameter(cmd, "DirectorBirthday", value.DirectorBirthday);
			
				// DirectorAddress
			if (value.IsDirectorAddressNull )
				AddParameter(cmd, "DirectorAddress", DBNull.Value);
			else
				AddParameter(cmd, "DirectorAddress", value.DirectorAddress);
			
				// DirectorMobile
			if (value.IsDirectorMobileNull )
				AddParameter(cmd, "DirectorMobile", DBNull.Value);
			else
				AddParameter(cmd, "DirectorMobile", value.DirectorMobile);
			
				// DirectorEmail
			if (value.IsDirectorEmailNull )
				AddParameter(cmd, "DirectorEmail", DBNull.Value);
			else
				AddParameter(cmd, "DirectorEmail", value.DirectorEmail);
			
				// DirectorPosition
			if (value.IsDirectorPositionNull )
				AddParameter(cmd, "DirectorPosition", DBNull.Value);
			else
				AddParameter(cmd, "DirectorPosition", value.DirectorPosition);
			
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
			
				// VerifyApproveBy
			if (value.IsVerifyApproveByNull)
				AddParameter(cmd, "VerifyApproveBy", DBNull.Value);
			else
				AddParameter(cmd, "VerifyApproveBy", value.VerifyApproveBy);
			
				// VerifyApproveDate
			if (value.IsVerifyApproveDateNull)
				AddParameter(cmd, "VerifyApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "VerifyApproveDate", value.VerifyApproveDate);
			
				// CheckApproveBy
			if (value.IsCheckApproveByNull)
				AddParameter(cmd, "CheckApproveBy", DBNull.Value);
			else
				AddParameter(cmd, "CheckApproveBy", value.CheckApproveBy);
			
				// CheckApproveDate
			if (value.IsCheckApproveDateNull)
				AddParameter(cmd, "CheckApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "CheckApproveDate", value.CheckApproveDate);
			
				// AdminApproveBy
			if (value.IsAdminApproveByNull)
				AddParameter(cmd, "AdminApproveBy", DBNull.Value);
			else
				AddParameter(cmd, "AdminApproveBy", value.AdminApproveBy);
			
				// AdminApproveDate
			if (value.IsAdminApproveDateNull)
				AddParameter(cmd, "AdminApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "AdminApproveDate", value.AdminApproveDate);
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull )
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
			
				// CheckDomain
			if (value.IsCheckDomainNull )
				AddParameter(cmd, "CheckDomain", DBNull.Value);
			else
				AddParameter(cmd, "CheckDomain", value.CheckDomain);
			
				// CheckServer_ID
			if (value.IsCheckServer_IDNull)
				AddParameter(cmd, "CheckServer_ID", DBNull.Value);
			else
				AddParameter(cmd, "CheckServer_ID", value.CheckServer_ID);
			
				// GCP
			if (value.IsGCPNull )
				AddParameter(cmd, "GCP", DBNull.Value);
			else
				AddParameter(cmd, "GCP", value.GCP);
			
				// GLN
			if (value.IsGLNNull )
				AddParameter(cmd, "GLN", DBNull.Value);
			else
				AddParameter(cmd, "GLN", value.GLN);
			
				// ProductBrandType_ID_List
			if (value.IsProductBrandType_ID_ListNull )
				AddParameter(cmd, "ProductBrandType_ID_List", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandType_ID_List", value.ProductBrandType_ID_List);
			
				// Branch_ID
			if (value.IsBranch_IDNull)
				AddParameter(cmd, "Branch_ID", DBNull.Value);
			else
				AddParameter(cmd, "Branch_ID", value.Branch_ID);
			
				// ProductionUnitCode
			if (value.IsProductionUnitCodeNull )
				AddParameter(cmd, "ProductionUnitCode", DBNull.Value);
			else
				AddParameter(cmd, "ProductionUnitCode", value.ProductionUnitCode);
			
				// CheckProductBrand_ID
			if (value.IsCheckProductBrand_IDNull)
				AddParameter(cmd, "CheckProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "CheckProductBrand_ID", value.CheckProductBrand_ID);
			
				// ChainLink_ID
			if (value.IsChainLink_IDNull)
				AddParameter(cmd, "ChainLink_ID", DBNull.Value);
			else
				AddParameter(cmd, "ChainLink_ID", value.ChainLink_ID);
			
				// Story
			if (value.IsStoryNull )
				AddParameter(cmd, "Story", DBNull.Value);
			else
				AddParameter(cmd, "Story", value.Story);
			
				// FunctionGroup_ID
			if (value.IsFunctionGroup_IDNull)
				AddParameter(cmd, "FunctionGroup_ID", DBNull.Value);
			else
				AddParameter(cmd, "FunctionGroup_ID", value.FunctionGroup_ID);
			
				// BusinessType_ID
			if (value.IsBusinessType_IDNull)
				AddParameter(cmd, "BusinessType_ID", DBNull.Value);
			else
				AddParameter(cmd, "BusinessType_ID", value.BusinessType_ID);
			
				// ProductBrandChange_Note
			if (value.IsProductBrandChange_NoteNull )
				AddParameter(cmd, "ProductBrandChange_Note", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Note", value.ProductBrandChange_Note);
			
				// ProductBrandChange_By
			if (value.IsProductBrandChange_ByNull)
				AddParameter(cmd, "ProductBrandChange_By", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_By", value.ProductBrandChange_By);
			
				// ProductBrandChange_Approved
			if (value.IsProductBrandChange_ApprovedNull)
				AddParameter(cmd, "ProductBrandChange_Approved", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Approved", value.ProductBrandChange_Approved);
			
				// ProductBrandChange_Date
			if (value.IsProductBrandChange_DateNull)
				AddParameter(cmd, "ProductBrandChange_Date", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Date", value.ProductBrandChange_Date);
			
				// ProductBrandChange_DateApproved
			if (value.IsProductBrandChange_DateApprovedNull)
				AddParameter(cmd, "ProductBrandChange_DateApproved", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_DateApproved", value.ProductBrandChange_DateApproved);
			
				// ProductBrandChange_Status
			if (value.IsProductBrandChange_StatusNull)
				AddParameter(cmd, "ProductBrandChange_Status", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Status", value.ProductBrandChange_Status);
			
				// ProductBrandChange_ApprovedNote
			if (value.IsProductBrandChange_ApprovedNoteNull )
				AddParameter(cmd, "ProductBrandChange_ApprovedNote", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_ApprovedNote", value.ProductBrandChange_ApprovedNote);
			
				// YouTube
			if (value.IsYouTubeNull )
				AddParameter(cmd, "YouTube", DBNull.Value);
			else
				AddParameter(cmd, "YouTube", value.YouTube);
			
						value.ProductBrandChange_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductBrandChangeRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(ProductBrandChangeRow value)
	{	
		string LOCATION = "Update(ProductBrandChangeRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductBrandChange_Update", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
				// Language_ID
			if (value.IsLanguage_IDNull)
				AddParameter(cmd, "Language_ID", DBNull.Value);
			else
				AddParameter(cmd, "Language_ID", value.Language_ID);
			
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
			
				// Ward_ID
			if (value.IsWard_IDNull)
				AddParameter(cmd, "Ward_ID", DBNull.Value);
			else
				AddParameter(cmd, "Ward_ID", value.Ward_ID);
			
				// DepartmentMan_ID
			if (value.IsDepartmentMan_IDNull)
				AddParameter(cmd, "DepartmentMan_ID", DBNull.Value);
			else
				AddParameter(cmd, "DepartmentMan_ID", value.DepartmentMan_ID);
			
				// ProductBrandType_ID
			if (value.IsProductBrandType_IDNull)
				AddParameter(cmd, "ProductBrandType_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandType_ID", value.ProductBrandType_ID);
			
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
				// TradingName
			if (value.IsTradingNameNull)
				AddParameter(cmd, "TradingName", DBNull.Value);
			else
				AddParameter(cmd, "TradingName", value.TradingName);
				// BrandName
			if (value.IsBrandNameNull)
				AddParameter(cmd, "BrandName", DBNull.Value);
			else
				AddParameter(cmd, "BrandName", value.BrandName);
				// TaxCode
			if (value.IsTaxCodeNull)
				AddParameter(cmd, "TaxCode", DBNull.Value);
			else
				AddParameter(cmd, "TaxCode", value.TaxCode);
				// RegistrationNumber
			if (value.IsRegistrationNumberNull)
				AddParameter(cmd, "RegistrationNumber", DBNull.Value);
			else
				AddParameter(cmd, "RegistrationNumber", value.RegistrationNumber);
				// IssuedDate
			if (value.IsIssuedDateNull)
				AddParameter(cmd, "IssuedDate", DBNull.Value);
			else
				AddParameter(cmd, "IssuedDate", value.IssuedDate);
			
				// BusinessArea
			if (value.IsBusinessAreaNull)
				AddParameter(cmd, "BusinessArea", DBNull.Value);
			else
				AddParameter(cmd, "BusinessArea", value.BusinessArea);
				// Address
			if (value.IsAddressNull)
				AddParameter(cmd, "Address", DBNull.Value);
			else
				AddParameter(cmd, "Address", value.Address);
				// Telephone
			if (value.IsTelephoneNull)
				AddParameter(cmd, "Telephone", DBNull.Value);
			else
				AddParameter(cmd, "Telephone", value.Telephone);
				// Fax
			if (value.IsFaxNull)
				AddParameter(cmd, "Fax", DBNull.Value);
			else
				AddParameter(cmd, "Fax", value.Fax);
				// Mobile
			if (value.IsMobileNull)
				AddParameter(cmd, "Mobile", DBNull.Value);
			else
				AddParameter(cmd, "Mobile", value.Mobile);
				// Email
			if (value.IsEmailNull)
				AddParameter(cmd, "Email", DBNull.Value);
			else
				AddParameter(cmd, "Email", value.Email);
				// Website
			if (value.IsWebsiteNull)
				AddParameter(cmd, "Website", DBNull.Value);
			else
				AddParameter(cmd, "Website", value.Website);
				// Facebook
			if (value.IsFacebookNull)
				AddParameter(cmd, "Facebook", DBNull.Value);
			else
				AddParameter(cmd, "Facebook", value.Facebook);
				// Zalo
			if (value.IsZaloNull)
				AddParameter(cmd, "Zalo", DBNull.Value);
			else
				AddParameter(cmd, "Zalo", value.Zalo);
				// Hotline
			if (value.IsHotlineNull)
				AddParameter(cmd, "Hotline", DBNull.Value);
			else
				AddParameter(cmd, "Hotline", value.Hotline);
				// Skype
			if (value.IsSkypeNull)
				AddParameter(cmd, "Skype", DBNull.Value);
			else
				AddParameter(cmd, "Skype", value.Skype);
				// PRInfo
			if (value.IsPRInfoNull)
				AddParameter(cmd, "PRInfo", DBNull.Value);
			else
				AddParameter(cmd, "PRInfo", value.PRInfo);
				// Agency
			if (value.IsAgencyNull)
				AddParameter(cmd, "Agency", DBNull.Value);
			else
				AddParameter(cmd, "Agency", value.Agency);
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
				// PersonName
			if (value.IsPersonNameNull)
				AddParameter(cmd, "PersonName", DBNull.Value);
			else
				AddParameter(cmd, "PersonName", value.PersonName);
				// PersonAddress
			if (value.IsPersonAddressNull)
				AddParameter(cmd, "PersonAddress", DBNull.Value);
			else
				AddParameter(cmd, "PersonAddress", value.PersonAddress);
				// PersonMobile
			if (value.IsPersonMobileNull)
				AddParameter(cmd, "PersonMobile", DBNull.Value);
			else
				AddParameter(cmd, "PersonMobile", value.PersonMobile);
				// PersonEmail
			if (value.IsPersonEmailNull)
				AddParameter(cmd, "PersonEmail", DBNull.Value);
			else
				AddParameter(cmd, "PersonEmail", value.PersonEmail);
				// Sort
			if (value.IsSortNull)
				AddParameter(cmd, "Sort", DBNull.Value);
			else
				AddParameter(cmd, "Sort", value.Sort);
			
				// URL
			if (value.IsURLNull)
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// HasQRCode
			if (value.IsHasQRCodeNull)
				AddParameter(cmd, "HasQRCode", DBNull.Value);
			else
				AddParameter(cmd, "HasQRCode", value.HasQRCode);
			
				// ViewCount
			if (value.IsViewCountNull)
				AddParameter(cmd, "ViewCount", DBNull.Value);
			else
				AddParameter(cmd, "ViewCount", value.ViewCount);
			
				// SellCount
			if (value.IsSellCountNull)
				AddParameter(cmd, "SellCount", DBNull.Value);
			else
				AddParameter(cmd, "SellCount", value.SellCount);
			
				// AccountUserName
			if (value.IsAccountUserNameNull)
				AddParameter(cmd, "AccountUserName", DBNull.Value);
			else
				AddParameter(cmd, "AccountUserName", value.AccountUserName);
				// AccountEmail
			if (value.IsAccountEmailNull)
				AddParameter(cmd, "AccountEmail", DBNull.Value);
			else
				AddParameter(cmd, "AccountEmail", value.AccountEmail);
				// DirectorName
			if (value.IsDirectorNameNull)
				AddParameter(cmd, "DirectorName", DBNull.Value);
			else
				AddParameter(cmd, "DirectorName", value.DirectorName);
				// DirectorBirthday
			if (value.IsDirectorBirthdayNull)
				AddParameter(cmd, "DirectorBirthday", DBNull.Value);
			else
				AddParameter(cmd, "DirectorBirthday", value.DirectorBirthday);
			
				// DirectorAddress
			if (value.IsDirectorAddressNull)
				AddParameter(cmd, "DirectorAddress", DBNull.Value);
			else
				AddParameter(cmd, "DirectorAddress", value.DirectorAddress);
				// DirectorMobile
			if (value.IsDirectorMobileNull)
				AddParameter(cmd, "DirectorMobile", DBNull.Value);
			else
				AddParameter(cmd, "DirectorMobile", value.DirectorMobile);
				// DirectorEmail
			if (value.IsDirectorEmailNull)
				AddParameter(cmd, "DirectorEmail", DBNull.Value);
			else
				AddParameter(cmd, "DirectorEmail", value.DirectorEmail);
				// DirectorPosition
			if (value.IsDirectorPositionNull)
				AddParameter(cmd, "DirectorPosition", DBNull.Value);
			else
				AddParameter(cmd, "DirectorPosition", value.DirectorPosition);
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
			
				// VerifyApproveBy
			if (value.IsVerifyApproveByNull)
				AddParameter(cmd, "VerifyApproveBy", DBNull.Value);
			else
				AddParameter(cmd, "VerifyApproveBy", value.VerifyApproveBy);
			
				// VerifyApproveDate
			if (value.IsVerifyApproveDateNull)
				AddParameter(cmd, "VerifyApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "VerifyApproveDate", value.VerifyApproveDate);
			
				// CheckApproveBy
			if (value.IsCheckApproveByNull)
				AddParameter(cmd, "CheckApproveBy", DBNull.Value);
			else
				AddParameter(cmd, "CheckApproveBy", value.CheckApproveBy);
			
				// CheckApproveDate
			if (value.IsCheckApproveDateNull)
				AddParameter(cmd, "CheckApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "CheckApproveDate", value.CheckApproveDate);
			
				// AdminApproveBy
			if (value.IsAdminApproveByNull)
				AddParameter(cmd, "AdminApproveBy", DBNull.Value);
			else
				AddParameter(cmd, "AdminApproveBy", value.AdminApproveBy);
			
				// AdminApproveDate
			if (value.IsAdminApproveDateNull)
				AddParameter(cmd, "AdminApproveDate", DBNull.Value);
			else
				AddParameter(cmd, "AdminApproveDate", value.AdminApproveDate);
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull)
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
				// CheckDomain
			if (value.IsCheckDomainNull)
				AddParameter(cmd, "CheckDomain", DBNull.Value);
			else
				AddParameter(cmd, "CheckDomain", value.CheckDomain);
				// CheckServer_ID
			if (value.IsCheckServer_IDNull)
				AddParameter(cmd, "CheckServer_ID", DBNull.Value);
			else
				AddParameter(cmd, "CheckServer_ID", value.CheckServer_ID);
			
				// GCP
			if (value.IsGCPNull)
				AddParameter(cmd, "GCP", DBNull.Value);
			else
				AddParameter(cmd, "GCP", value.GCP);
				// GLN
			if (value.IsGLNNull)
				AddParameter(cmd, "GLN", DBNull.Value);
			else
				AddParameter(cmd, "GLN", value.GLN);
				// ProductBrandType_ID_List
			if (value.IsProductBrandType_ID_ListNull)
				AddParameter(cmd, "ProductBrandType_ID_List", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandType_ID_List", value.ProductBrandType_ID_List);
				// Branch_ID
			if (value.IsBranch_IDNull)
				AddParameter(cmd, "Branch_ID", DBNull.Value);
			else
				AddParameter(cmd, "Branch_ID", value.Branch_ID);
			
				// ProductionUnitCode
			if (value.IsProductionUnitCodeNull)
				AddParameter(cmd, "ProductionUnitCode", DBNull.Value);
			else
				AddParameter(cmd, "ProductionUnitCode", value.ProductionUnitCode);
				// CheckProductBrand_ID
			if (value.IsCheckProductBrand_IDNull)
				AddParameter(cmd, "CheckProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "CheckProductBrand_ID", value.CheckProductBrand_ID);
			
				// ChainLink_ID
			if (value.IsChainLink_IDNull)
				AddParameter(cmd, "ChainLink_ID", DBNull.Value);
			else
				AddParameter(cmd, "ChainLink_ID", value.ChainLink_ID);
			
				// Story
			if (value.IsStoryNull)
				AddParameter(cmd, "Story", DBNull.Value);
			else
				AddParameter(cmd, "Story", value.Story);
				// FunctionGroup_ID
			if (value.IsFunctionGroup_IDNull)
				AddParameter(cmd, "FunctionGroup_ID", DBNull.Value);
			else
				AddParameter(cmd, "FunctionGroup_ID", value.FunctionGroup_ID);
			
				// BusinessType_ID
			if (value.IsBusinessType_IDNull)
				AddParameter(cmd, "BusinessType_ID", DBNull.Value);
			else
				AddParameter(cmd, "BusinessType_ID", value.BusinessType_ID);
			
				// ProductBrandChange_Note
			if (value.IsProductBrandChange_NoteNull)
				AddParameter(cmd, "ProductBrandChange_Note", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Note", value.ProductBrandChange_Note);
				// ProductBrandChange_By
			if (value.IsProductBrandChange_ByNull)
				AddParameter(cmd, "ProductBrandChange_By", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_By", value.ProductBrandChange_By);
			
				// ProductBrandChange_Approved
			if (value.IsProductBrandChange_ApprovedNull)
				AddParameter(cmd, "ProductBrandChange_Approved", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Approved", value.ProductBrandChange_Approved);
			
				// ProductBrandChange_Date
			if (value.IsProductBrandChange_DateNull)
				AddParameter(cmd, "ProductBrandChange_Date", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Date", value.ProductBrandChange_Date);
			
				// ProductBrandChange_DateApproved
			if (value.IsProductBrandChange_DateApprovedNull)
				AddParameter(cmd, "ProductBrandChange_DateApproved", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_DateApproved", value.ProductBrandChange_DateApproved);
			
				// ProductBrandChange_Status
			if (value.IsProductBrandChange_StatusNull)
				AddParameter(cmd, "ProductBrandChange_Status", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_Status", value.ProductBrandChange_Status);
			
				// ProductBrandChange_ApprovedNote
			if (value.IsProductBrandChange_ApprovedNoteNull)
				AddParameter(cmd, "ProductBrandChange_ApprovedNote", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandChange_ApprovedNote", value.ProductBrandChange_ApprovedNote);
				// YouTube
			if (value.IsYouTubeNull)
				AddParameter(cmd, "YouTube", DBNull.Value);
			else
				AddParameter(cmd, "YouTube", value.YouTube);
					AddParameter(cmd, "ProductBrandChange_ID", value.ProductBrandChange_ID);
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
		/// Inserts or Updates a record in the <c>ProductBrandChange</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="ProductBrandChangeRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(ProductBrandChangeRow value)
		{
			string LOCATION = "Save(ProductBrandChangeRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("ProductBrandChange_Save",CommandType.StoredProcedure);
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// Language_ID
				if (value.IsLanguage_IDNull)
					AddParameter(cmd, "Language_ID", DBNull.Value);
				else
					AddParameter(cmd, "Language_ID", (object)(value.Language_ID));
				
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
				
					// Ward_ID
				if (value.IsWard_IDNull)
					AddParameter(cmd, "Ward_ID", DBNull.Value);
				else
					AddParameter(cmd, "Ward_ID", (object)(value.Ward_ID));
				
					// DepartmentMan_ID
				if (value.IsDepartmentMan_IDNull)
					AddParameter(cmd, "DepartmentMan_ID", DBNull.Value);
				else
					AddParameter(cmd, "DepartmentMan_ID", (object)(value.DepartmentMan_ID));
				
					// ProductBrandType_ID
				if (value.IsProductBrandType_IDNull)
					AddParameter(cmd, "ProductBrandType_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandType_ID", (object)(value.ProductBrandType_ID));
				
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
				
					// TradingName
				if (value.IsTradingNameNull)
					AddParameter(cmd, "TradingName", DBNull.Value);
				else
					AddParameter(cmd, "TradingName", (object)(value.TradingName));
				
					// BrandName
				if (value.IsBrandNameNull)
					AddParameter(cmd, "BrandName", DBNull.Value);
				else
					AddParameter(cmd, "BrandName", (object)(value.BrandName));
				
					// TaxCode
				if (value.IsTaxCodeNull)
					AddParameter(cmd, "TaxCode", DBNull.Value);
				else
					AddParameter(cmd, "TaxCode", (object)(value.TaxCode));
				
					// RegistrationNumber
				if (value.IsRegistrationNumberNull)
					AddParameter(cmd, "RegistrationNumber", DBNull.Value);
				else
					AddParameter(cmd, "RegistrationNumber", (object)(value.RegistrationNumber));
				
					// IssuedDate
				if (value.IsIssuedDateNull)
					AddParameter(cmd, "IssuedDate", DBNull.Value);
				else
					AddParameter(cmd, "IssuedDate", (object)(value.IssuedDate));
				
					// BusinessArea
				if (value.IsBusinessAreaNull)
					AddParameter(cmd, "BusinessArea", DBNull.Value);
				else
					AddParameter(cmd, "BusinessArea", (object)(value.BusinessArea));
				
					// Address
				if (value.IsAddressNull)
					AddParameter(cmd, "Address", DBNull.Value);
				else
					AddParameter(cmd, "Address", (object)(value.Address));
				
					// Telephone
				if (value.IsTelephoneNull)
					AddParameter(cmd, "Telephone", DBNull.Value);
				else
					AddParameter(cmd, "Telephone", (object)(value.Telephone));
				
					// Fax
				if (value.IsFaxNull)
					AddParameter(cmd, "Fax", DBNull.Value);
				else
					AddParameter(cmd, "Fax", (object)(value.Fax));
				
					// Mobile
				if (value.IsMobileNull)
					AddParameter(cmd, "Mobile", DBNull.Value);
				else
					AddParameter(cmd, "Mobile", (object)(value.Mobile));
				
					// Email
				if (value.IsEmailNull)
					AddParameter(cmd, "Email", DBNull.Value);
				else
					AddParameter(cmd, "Email", (object)(value.Email));
				
					// Website
				if (value.IsWebsiteNull)
					AddParameter(cmd, "Website", DBNull.Value);
				else
					AddParameter(cmd, "Website", (object)(value.Website));
				
					// Facebook
				if (value.IsFacebookNull)
					AddParameter(cmd, "Facebook", DBNull.Value);
				else
					AddParameter(cmd, "Facebook", (object)(value.Facebook));
				
					// Zalo
				if (value.IsZaloNull)
					AddParameter(cmd, "Zalo", DBNull.Value);
				else
					AddParameter(cmd, "Zalo", (object)(value.Zalo));
				
					// Hotline
				if (value.IsHotlineNull)
					AddParameter(cmd, "Hotline", DBNull.Value);
				else
					AddParameter(cmd, "Hotline", (object)(value.Hotline));
				
					// Skype
				if (value.IsSkypeNull)
					AddParameter(cmd, "Skype", DBNull.Value);
				else
					AddParameter(cmd, "Skype", (object)(value.Skype));
				
					// PRInfo
				if (value.IsPRInfoNull)
					AddParameter(cmd, "PRInfo", DBNull.Value);
				else
					AddParameter(cmd, "PRInfo", (object)(value.PRInfo));
				
					// Agency
				if (value.IsAgencyNull)
					AddParameter(cmd, "Agency", DBNull.Value);
				else
					AddParameter(cmd, "Agency", (object)(value.Agency));
				
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
				
					// PersonName
				if (value.IsPersonNameNull)
					AddParameter(cmd, "PersonName", DBNull.Value);
				else
					AddParameter(cmd, "PersonName", (object)(value.PersonName));
				
					// PersonAddress
				if (value.IsPersonAddressNull)
					AddParameter(cmd, "PersonAddress", DBNull.Value);
				else
					AddParameter(cmd, "PersonAddress", (object)(value.PersonAddress));
				
					// PersonMobile
				if (value.IsPersonMobileNull)
					AddParameter(cmd, "PersonMobile", DBNull.Value);
				else
					AddParameter(cmd, "PersonMobile", (object)(value.PersonMobile));
				
					// PersonEmail
				if (value.IsPersonEmailNull)
					AddParameter(cmd, "PersonEmail", DBNull.Value);
				else
					AddParameter(cmd, "PersonEmail", (object)(value.PersonEmail));
				
					// Sort
				if (value.IsSortNull)
					AddParameter(cmd, "Sort", DBNull.Value);
				else
					AddParameter(cmd, "Sort", (object)(value.Sort));
				
					// URL
				if (value.IsURLNull)
					AddParameter(cmd, "URL", DBNull.Value);
				else
					AddParameter(cmd, "URL", (object)(value.URL));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// HasQRCode
				if (value.IsHasQRCodeNull)
					AddParameter(cmd, "HasQRCode", DBNull.Value);
				else
					AddParameter(cmd, "HasQRCode", (object)(value.HasQRCode));
				
					// ViewCount
				if (value.IsViewCountNull)
					AddParameter(cmd, "ViewCount", DBNull.Value);
				else
					AddParameter(cmd, "ViewCount", (object)(value.ViewCount));
				
					// SellCount
				if (value.IsSellCountNull)
					AddParameter(cmd, "SellCount", DBNull.Value);
				else
					AddParameter(cmd, "SellCount", (object)(value.SellCount));
				
					// AccountUserName
				if (value.IsAccountUserNameNull)
					AddParameter(cmd, "AccountUserName", DBNull.Value);
				else
					AddParameter(cmd, "AccountUserName", (object)(value.AccountUserName));
				
					// AccountEmail
				if (value.IsAccountEmailNull)
					AddParameter(cmd, "AccountEmail", DBNull.Value);
				else
					AddParameter(cmd, "AccountEmail", (object)(value.AccountEmail));
				
					// DirectorName
				if (value.IsDirectorNameNull)
					AddParameter(cmd, "DirectorName", DBNull.Value);
				else
					AddParameter(cmd, "DirectorName", (object)(value.DirectorName));
				
					// DirectorBirthday
				if (value.IsDirectorBirthdayNull)
					AddParameter(cmd, "DirectorBirthday", DBNull.Value);
				else
					AddParameter(cmd, "DirectorBirthday", (object)(value.DirectorBirthday));
				
					// DirectorAddress
				if (value.IsDirectorAddressNull)
					AddParameter(cmd, "DirectorAddress", DBNull.Value);
				else
					AddParameter(cmd, "DirectorAddress", (object)(value.DirectorAddress));
				
					// DirectorMobile
				if (value.IsDirectorMobileNull)
					AddParameter(cmd, "DirectorMobile", DBNull.Value);
				else
					AddParameter(cmd, "DirectorMobile", (object)(value.DirectorMobile));
				
					// DirectorEmail
				if (value.IsDirectorEmailNull)
					AddParameter(cmd, "DirectorEmail", DBNull.Value);
				else
					AddParameter(cmd, "DirectorEmail", (object)(value.DirectorEmail));
				
					// DirectorPosition
				if (value.IsDirectorPositionNull)
					AddParameter(cmd, "DirectorPosition", DBNull.Value);
				else
					AddParameter(cmd, "DirectorPosition", (object)(value.DirectorPosition));
				
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
				
					// VerifyApproveBy
				if (value.IsVerifyApproveByNull)
					AddParameter(cmd, "VerifyApproveBy", DBNull.Value);
				else
					AddParameter(cmd, "VerifyApproveBy", (object)(value.VerifyApproveBy));
				
					// VerifyApproveDate
				if (value.IsVerifyApproveDateNull)
					AddParameter(cmd, "VerifyApproveDate", DBNull.Value);
				else
					AddParameter(cmd, "VerifyApproveDate", (object)(value.VerifyApproveDate));
				
					// CheckApproveBy
				if (value.IsCheckApproveByNull)
					AddParameter(cmd, "CheckApproveBy", DBNull.Value);
				else
					AddParameter(cmd, "CheckApproveBy", (object)(value.CheckApproveBy));
				
					// CheckApproveDate
				if (value.IsCheckApproveDateNull)
					AddParameter(cmd, "CheckApproveDate", DBNull.Value);
				else
					AddParameter(cmd, "CheckApproveDate", (object)(value.CheckApproveDate));
				
					// AdminApproveBy
				if (value.IsAdminApproveByNull)
					AddParameter(cmd, "AdminApproveBy", DBNull.Value);
				else
					AddParameter(cmd, "AdminApproveBy", (object)(value.AdminApproveBy));
				
					// AdminApproveDate
				if (value.IsAdminApproveDateNull)
					AddParameter(cmd, "AdminApproveDate", DBNull.Value);
				else
					AddParameter(cmd, "AdminApproveDate", (object)(value.AdminApproveDate));
				
					// QRCodePublicContent
				if (value.IsQRCodePublicContentNull)
					AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePublicContent", (object)(value.QRCodePublicContent));
				
					// CheckDomain
				if (value.IsCheckDomainNull)
					AddParameter(cmd, "CheckDomain", DBNull.Value);
				else
					AddParameter(cmd, "CheckDomain", (object)(value.CheckDomain));
				
					// CheckServer_ID
				if (value.IsCheckServer_IDNull)
					AddParameter(cmd, "CheckServer_ID", DBNull.Value);
				else
					AddParameter(cmd, "CheckServer_ID", (object)(value.CheckServer_ID));
				
					// GCP
				if (value.IsGCPNull)
					AddParameter(cmd, "GCP", DBNull.Value);
				else
					AddParameter(cmd, "GCP", (object)(value.GCP));
				
					// GLN
				if (value.IsGLNNull)
					AddParameter(cmd, "GLN", DBNull.Value);
				else
					AddParameter(cmd, "GLN", (object)(value.GLN));
				
					// ProductBrandType_ID_List
				if (value.IsProductBrandType_ID_ListNull)
					AddParameter(cmd, "ProductBrandType_ID_List", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandType_ID_List", (object)(value.ProductBrandType_ID_List));
				
					// Branch_ID
				if (value.IsBranch_IDNull)
					AddParameter(cmd, "Branch_ID", DBNull.Value);
				else
					AddParameter(cmd, "Branch_ID", (object)(value.Branch_ID));
				
					// ProductionUnitCode
				if (value.IsProductionUnitCodeNull)
					AddParameter(cmd, "ProductionUnitCode", DBNull.Value);
				else
					AddParameter(cmd, "ProductionUnitCode", (object)(value.ProductionUnitCode));
				
					// CheckProductBrand_ID
				if (value.IsCheckProductBrand_IDNull)
					AddParameter(cmd, "CheckProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "CheckProductBrand_ID", (object)(value.CheckProductBrand_ID));
				
					// ChainLink_ID
				if (value.IsChainLink_IDNull)
					AddParameter(cmd, "ChainLink_ID", DBNull.Value);
				else
					AddParameter(cmd, "ChainLink_ID", (object)(value.ChainLink_ID));
				
					// Story
				if (value.IsStoryNull)
					AddParameter(cmd, "Story", DBNull.Value);
				else
					AddParameter(cmd, "Story", (object)(value.Story));
				
					// FunctionGroup_ID
				if (value.IsFunctionGroup_IDNull)
					AddParameter(cmd, "FunctionGroup_ID", DBNull.Value);
				else
					AddParameter(cmd, "FunctionGroup_ID", (object)(value.FunctionGroup_ID));
				
					// BusinessType_ID
				if (value.IsBusinessType_IDNull)
					AddParameter(cmd, "BusinessType_ID", DBNull.Value);
				else
					AddParameter(cmd, "BusinessType_ID", (object)(value.BusinessType_ID));
				
					// ProductBrandChange_Note
				if (value.IsProductBrandChange_NoteNull)
					AddParameter(cmd, "ProductBrandChange_Note", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_Note", (object)(value.ProductBrandChange_Note));
				
					// ProductBrandChange_By
				if (value.IsProductBrandChange_ByNull)
					AddParameter(cmd, "ProductBrandChange_By", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_By", (object)(value.ProductBrandChange_By));
				
					// ProductBrandChange_Approved
				if (value.IsProductBrandChange_ApprovedNull)
					AddParameter(cmd, "ProductBrandChange_Approved", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_Approved", (object)(value.ProductBrandChange_Approved));
				
					// ProductBrandChange_Date
				if (value.IsProductBrandChange_DateNull)
					AddParameter(cmd, "ProductBrandChange_Date", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_Date", (object)(value.ProductBrandChange_Date));
				
					// ProductBrandChange_DateApproved
				if (value.IsProductBrandChange_DateApprovedNull)
					AddParameter(cmd, "ProductBrandChange_DateApproved", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_DateApproved", (object)(value.ProductBrandChange_DateApproved));
				
					// ProductBrandChange_Status
				if (value.IsProductBrandChange_StatusNull)
					AddParameter(cmd, "ProductBrandChange_Status", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_Status", (object)(value.ProductBrandChange_Status));
				
					// ProductBrandChange_ApprovedNote
				if (value.IsProductBrandChange_ApprovedNoteNull)
					AddParameter(cmd, "ProductBrandChange_ApprovedNote", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandChange_ApprovedNote", (object)(value.ProductBrandChange_ApprovedNote));
				
					// YouTube
				if (value.IsYouTubeNull)
					AddParameter(cmd, "YouTube", DBNull.Value);
				else
					AddParameter(cmd, "YouTube", (object)(value.YouTube));
				
						AddParameter(cmd, "ProductBrandChange_ID", value.ProductBrandChange_ID);
						value.ProductBrandChange_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["ProductBrandChange_ID"]);
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
	/// Deletes the specified object from the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <param name="value">The <see cref="ProductBrandChangeRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(ProductBrandChangeRow value)
	{
		return DeleteByPrimaryKey(value.ProductBrandChange_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>ProductBrandChange</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="productBrandChange_ID">The <c>ProductBrandChange_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int productBrandChange_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productBrandChange_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("ProductBrandChange_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "ProductBrandChange_ID", productBrandChange_ID);
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
	/// Deletes <c>ProductBrandChange</c> records that match the specified criteria.
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
	/// to delete <c>ProductBrandChange</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("ProductBrandChange_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("ProductBrandChange_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="ProductBrandChangeRow"/> objects.</returns>
	protected ProductBrandChangeRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="ProductBrandChangeRow"/> objects.</returns>
	protected ProductBrandChangeRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="ProductBrandChangeRow"/> objects.</returns>
	protected virtual ProductBrandChangeRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// ProductBrandChange_ID
		int productBrandChange_IDColumnIndex = reader.GetOrdinal("ProductBrandChange_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Language_ID
		int language_IDColumnIndex = reader.GetOrdinal("Language_ID");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// District_ID
		int district_IDColumnIndex = reader.GetOrdinal("District_ID");
		// Ward_ID
		int ward_IDColumnIndex = reader.GetOrdinal("Ward_ID");
		// DepartmentMan_ID
		int departmentMan_IDColumnIndex = reader.GetOrdinal("DepartmentMan_ID");
		// ProductBrandType_ID
		int productBrandType_IDColumnIndex = reader.GetOrdinal("ProductBrandType_ID");
		// Code
		int codeColumnIndex = reader.GetOrdinal("Code");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// TradingName
		int tradingNameColumnIndex = reader.GetOrdinal("TradingName");
		// BrandName
		int brandNameColumnIndex = reader.GetOrdinal("BrandName");
		// TaxCode
		int taxCodeColumnIndex = reader.GetOrdinal("TaxCode");
		// RegistrationNumber
		int registrationNumberColumnIndex = reader.GetOrdinal("RegistrationNumber");
		// IssuedDate
		int issuedDateColumnIndex = reader.GetOrdinal("IssuedDate");
		// BusinessArea
		int businessAreaColumnIndex = reader.GetOrdinal("BusinessArea");
		// Address
		int addressColumnIndex = reader.GetOrdinal("Address");
		// Telephone
		int telephoneColumnIndex = reader.GetOrdinal("Telephone");
		// Fax
		int faxColumnIndex = reader.GetOrdinal("Fax");
		// Mobile
		int mobileColumnIndex = reader.GetOrdinal("Mobile");
		// Email
		int emailColumnIndex = reader.GetOrdinal("Email");
		// Website
		int websiteColumnIndex = reader.GetOrdinal("Website");
		// Facebook
		int facebookColumnIndex = reader.GetOrdinal("Facebook");
		// Zalo
		int zaloColumnIndex = reader.GetOrdinal("Zalo");
		// Hotline
		int hotlineColumnIndex = reader.GetOrdinal("Hotline");
		// Skype
		int skypeColumnIndex = reader.GetOrdinal("Skype");
		// PRInfo
		int pRInfoColumnIndex = reader.GetOrdinal("PRInfo");
		// Agency
		int agencyColumnIndex = reader.GetOrdinal("Agency");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Image
		int imageColumnIndex = reader.GetOrdinal("Image");
		// PersonName
		int personNameColumnIndex = reader.GetOrdinal("PersonName");
		// PersonAddress
		int personAddressColumnIndex = reader.GetOrdinal("PersonAddress");
		// PersonMobile
		int personMobileColumnIndex = reader.GetOrdinal("PersonMobile");
		// PersonEmail
		int personEmailColumnIndex = reader.GetOrdinal("PersonEmail");
		// Sort
		int sortColumnIndex = reader.GetOrdinal("Sort");
		// URL
		int urlColumnIndex = reader.GetOrdinal("URL");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// HasQRCode
		int hasQRCodeColumnIndex = reader.GetOrdinal("HasQRCode");
		// ViewCount
		int viewCountColumnIndex = reader.GetOrdinal("ViewCount");
		// SellCount
		int sellCountColumnIndex = reader.GetOrdinal("SellCount");
		// AccountUserName
		int accountUserNameColumnIndex = reader.GetOrdinal("AccountUserName");
		// AccountEmail
		int accountEmailColumnIndex = reader.GetOrdinal("AccountEmail");
		// DirectorName
		int directorNameColumnIndex = reader.GetOrdinal("DirectorName");
		// DirectorBirthday
		int directorBirthdayColumnIndex = reader.GetOrdinal("DirectorBirthday");
		// DirectorAddress
		int directorAddressColumnIndex = reader.GetOrdinal("DirectorAddress");
		// DirectorMobile
		int directorMobileColumnIndex = reader.GetOrdinal("DirectorMobile");
		// DirectorEmail
		int directorEmailColumnIndex = reader.GetOrdinal("DirectorEmail");
		// DirectorPosition
		int directorPositionColumnIndex = reader.GetOrdinal("DirectorPosition");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// VerifyApproveBy
		int verifyApproveByColumnIndex = reader.GetOrdinal("VerifyApproveBy");
		// VerifyApproveDate
		int verifyApproveDateColumnIndex = reader.GetOrdinal("VerifyApproveDate");
		// CheckApproveBy
		int checkApproveByColumnIndex = reader.GetOrdinal("CheckApproveBy");
		// CheckApproveDate
		int checkApproveDateColumnIndex = reader.GetOrdinal("CheckApproveDate");
		// AdminApproveBy
		int adminApproveByColumnIndex = reader.GetOrdinal("AdminApproveBy");
		// AdminApproveDate
		int adminApproveDateColumnIndex = reader.GetOrdinal("AdminApproveDate");
		// QRCodePublicContent
		int qRCodePublicContentColumnIndex = reader.GetOrdinal("QRCodePublicContent");
		// CheckDomain
		int checkDomainColumnIndex = reader.GetOrdinal("CheckDomain");
		// CheckServer_ID
		int checkServer_IDColumnIndex = reader.GetOrdinal("CheckServer_ID");
		// GCP
		int gcpColumnIndex = reader.GetOrdinal("GCP");
		// GLN
		int glnColumnIndex = reader.GetOrdinal("GLN");
		// ProductBrandType_ID_List
		int productBrandType_ID_ListColumnIndex = reader.GetOrdinal("ProductBrandType_ID_List");
		// Branch_ID
		int branch_IDColumnIndex = reader.GetOrdinal("Branch_ID");
		// ProductionUnitCode
		int productionUnitCodeColumnIndex = reader.GetOrdinal("ProductionUnitCode");
		// CheckProductBrand_ID
		int checkProductBrand_IDColumnIndex = reader.GetOrdinal("CheckProductBrand_ID");
		// ChainLink_ID
		int chainLink_IDColumnIndex = reader.GetOrdinal("ChainLink_ID");
		// Story
		int storyColumnIndex = reader.GetOrdinal("Story");
		// FunctionGroup_ID
		int functionGroup_IDColumnIndex = reader.GetOrdinal("FunctionGroup_ID");
		// BusinessType_ID
		int businessType_IDColumnIndex = reader.GetOrdinal("BusinessType_ID");
		// ProductBrandChange_Note
		int productBrandChange_NoteColumnIndex = reader.GetOrdinal("ProductBrandChange_Note");
		// ProductBrandChange_By
		int productBrandChange_ByColumnIndex = reader.GetOrdinal("ProductBrandChange_By");
		// ProductBrandChange_Approved
		int productBrandChange_ApprovedColumnIndex = reader.GetOrdinal("ProductBrandChange_Approved");
		// ProductBrandChange_Date
		int productBrandChange_DateColumnIndex = reader.GetOrdinal("ProductBrandChange_Date");
		// ProductBrandChange_DateApproved
		int productBrandChange_DateApprovedColumnIndex = reader.GetOrdinal("ProductBrandChange_DateApproved");
		// ProductBrandChange_Status
		int productBrandChange_StatusColumnIndex = reader.GetOrdinal("ProductBrandChange_Status");
		// ProductBrandChange_ApprovedNote
		int productBrandChange_ApprovedNoteColumnIndex = reader.GetOrdinal("ProductBrandChange_ApprovedNote");
		// YouTube
		int youTubeColumnIndex = reader.GetOrdinal("YouTube");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				ProductBrandChangeRow record = new ProductBrandChangeRow();
				recordList.Add(record);

					record.ProductBrandChange_ID = Convert.ToInt32(reader.GetValue(productBrandChange_IDColumnIndex));
					record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(language_IDColumnIndex))
						record.Language_ID = Convert.ToInt32(reader.GetValue(language_IDColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(district_IDColumnIndex))
						record.District_ID = Convert.ToInt32(reader.GetValue(district_IDColumnIndex));
					if(!reader.IsDBNull(ward_IDColumnIndex))
						record.Ward_ID = Convert.ToInt32(reader.GetValue(ward_IDColumnIndex));
					if(!reader.IsDBNull(departmentMan_IDColumnIndex))
						record.DepartmentMan_ID = Convert.ToInt32(reader.GetValue(departmentMan_IDColumnIndex));
					if(!reader.IsDBNull(productBrandType_IDColumnIndex))
						record.ProductBrandType_ID = Convert.ToInt32(reader.GetValue(productBrandType_IDColumnIndex));
					if(!reader.IsDBNull(codeColumnIndex))
						record.Code = Convert.ToString(reader.GetValue(codeColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(tradingNameColumnIndex))
						record.TradingName = Convert.ToString(reader.GetValue(tradingNameColumnIndex));
					if(!reader.IsDBNull(brandNameColumnIndex))
						record.BrandName = Convert.ToString(reader.GetValue(brandNameColumnIndex));
					if(!reader.IsDBNull(taxCodeColumnIndex))
						record.TaxCode = Convert.ToString(reader.GetValue(taxCodeColumnIndex));
					if(!reader.IsDBNull(registrationNumberColumnIndex))
						record.RegistrationNumber = Convert.ToString(reader.GetValue(registrationNumberColumnIndex));
					if(!reader.IsDBNull(issuedDateColumnIndex))
						record.IssuedDate = Convert.ToDateTime(reader.GetValue(issuedDateColumnIndex));
					if(!reader.IsDBNull(businessAreaColumnIndex))
						record.BusinessArea = Convert.ToString(reader.GetValue(businessAreaColumnIndex));
					if(!reader.IsDBNull(addressColumnIndex))
						record.Address = Convert.ToString(reader.GetValue(addressColumnIndex));
					if(!reader.IsDBNull(telephoneColumnIndex))
						record.Telephone = Convert.ToString(reader.GetValue(telephoneColumnIndex));
					if(!reader.IsDBNull(faxColumnIndex))
						record.Fax = Convert.ToString(reader.GetValue(faxColumnIndex));
					if(!reader.IsDBNull(mobileColumnIndex))
						record.Mobile = Convert.ToString(reader.GetValue(mobileColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					if(!reader.IsDBNull(websiteColumnIndex))
						record.Website = Convert.ToString(reader.GetValue(websiteColumnIndex));
					if(!reader.IsDBNull(facebookColumnIndex))
						record.Facebook = Convert.ToString(reader.GetValue(facebookColumnIndex));
					if(!reader.IsDBNull(zaloColumnIndex))
						record.Zalo = Convert.ToString(reader.GetValue(zaloColumnIndex));
					if(!reader.IsDBNull(hotlineColumnIndex))
						record.Hotline = Convert.ToString(reader.GetValue(hotlineColumnIndex));
					if(!reader.IsDBNull(skypeColumnIndex))
						record.Skype = Convert.ToString(reader.GetValue(skypeColumnIndex));
					if(!reader.IsDBNull(pRInfoColumnIndex))
						record.PRInfo = Convert.ToString(reader.GetValue(pRInfoColumnIndex));
					if(!reader.IsDBNull(agencyColumnIndex))
						record.Agency = Convert.ToString(reader.GetValue(agencyColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(imageColumnIndex))
						record.Image = Convert.ToString(reader.GetValue(imageColumnIndex));
					if(!reader.IsDBNull(personNameColumnIndex))
						record.PersonName = Convert.ToString(reader.GetValue(personNameColumnIndex));
					if(!reader.IsDBNull(personAddressColumnIndex))
						record.PersonAddress = Convert.ToString(reader.GetValue(personAddressColumnIndex));
					if(!reader.IsDBNull(personMobileColumnIndex))
						record.PersonMobile = Convert.ToString(reader.GetValue(personMobileColumnIndex));
					if(!reader.IsDBNull(personEmailColumnIndex))
						record.PersonEmail = Convert.ToString(reader.GetValue(personEmailColumnIndex));
					if(!reader.IsDBNull(sortColumnIndex))
						record.Sort = Convert.ToInt32(reader.GetValue(sortColumnIndex));
					if(!reader.IsDBNull(urlColumnIndex))
						record.URL = Convert.ToString(reader.GetValue(urlColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(hasQRCodeColumnIndex))
						record.HasQRCode = Convert.ToBoolean(reader.GetValue(hasQRCodeColumnIndex));
					if(!reader.IsDBNull(viewCountColumnIndex))
						record.ViewCount = Convert.ToInt32(reader.GetValue(viewCountColumnIndex));
					if(!reader.IsDBNull(sellCountColumnIndex))
						record.SellCount = Convert.ToInt32(reader.GetValue(sellCountColumnIndex));
					if(!reader.IsDBNull(accountUserNameColumnIndex))
						record.AccountUserName = Convert.ToString(reader.GetValue(accountUserNameColumnIndex));
					if(!reader.IsDBNull(accountEmailColumnIndex))
						record.AccountEmail = Convert.ToString(reader.GetValue(accountEmailColumnIndex));
					if(!reader.IsDBNull(directorNameColumnIndex))
						record.DirectorName = Convert.ToString(reader.GetValue(directorNameColumnIndex));
					if(!reader.IsDBNull(directorBirthdayColumnIndex))
						record.DirectorBirthday = Convert.ToDateTime(reader.GetValue(directorBirthdayColumnIndex));
					if(!reader.IsDBNull(directorAddressColumnIndex))
						record.DirectorAddress = Convert.ToString(reader.GetValue(directorAddressColumnIndex));
					if(!reader.IsDBNull(directorMobileColumnIndex))
						record.DirectorMobile = Convert.ToString(reader.GetValue(directorMobileColumnIndex));
					if(!reader.IsDBNull(directorEmailColumnIndex))
						record.DirectorEmail = Convert.ToString(reader.GetValue(directorEmailColumnIndex));
					if(!reader.IsDBNull(directorPositionColumnIndex))
						record.DirectorPosition = Convert.ToString(reader.GetValue(directorPositionColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(verifyApproveByColumnIndex))
						record.VerifyApproveBy = reader.GetGuid(verifyApproveByColumnIndex);
					if(!reader.IsDBNull(verifyApproveDateColumnIndex))
						record.VerifyApproveDate = Convert.ToDateTime(reader.GetValue(verifyApproveDateColumnIndex));
					if(!reader.IsDBNull(checkApproveByColumnIndex))
						record.CheckApproveBy = reader.GetGuid(checkApproveByColumnIndex);
					if(!reader.IsDBNull(checkApproveDateColumnIndex))
						record.CheckApproveDate = Convert.ToDateTime(reader.GetValue(checkApproveDateColumnIndex));
					if(!reader.IsDBNull(adminApproveByColumnIndex))
						record.AdminApproveBy = reader.GetGuid(adminApproveByColumnIndex);
					if(!reader.IsDBNull(adminApproveDateColumnIndex))
						record.AdminApproveDate = Convert.ToDateTime(reader.GetValue(adminApproveDateColumnIndex));
					if(!reader.IsDBNull(qRCodePublicContentColumnIndex))
						record.QRCodePublicContent = Convert.ToString(reader.GetValue(qRCodePublicContentColumnIndex));
					if(!reader.IsDBNull(checkDomainColumnIndex))
						record.CheckDomain = Convert.ToString(reader.GetValue(checkDomainColumnIndex));
					if(!reader.IsDBNull(checkServer_IDColumnIndex))
						record.CheckServer_ID = Convert.ToInt32(reader.GetValue(checkServer_IDColumnIndex));
					if(!reader.IsDBNull(gcpColumnIndex))
						record.GCP = Convert.ToString(reader.GetValue(gcpColumnIndex));
					if(!reader.IsDBNull(glnColumnIndex))
						record.GLN = Convert.ToString(reader.GetValue(glnColumnIndex));
					if(!reader.IsDBNull(productBrandType_ID_ListColumnIndex))
						record.ProductBrandType_ID_List = Convert.ToString(reader.GetValue(productBrandType_ID_ListColumnIndex));
					if(!reader.IsDBNull(branch_IDColumnIndex))
						record.Branch_ID = Convert.ToInt32(reader.GetValue(branch_IDColumnIndex));
					if(!reader.IsDBNull(productionUnitCodeColumnIndex))
						record.ProductionUnitCode = Convert.ToString(reader.GetValue(productionUnitCodeColumnIndex));
					if(!reader.IsDBNull(checkProductBrand_IDColumnIndex))
						record.CheckProductBrand_ID = Convert.ToInt32(reader.GetValue(checkProductBrand_IDColumnIndex));
					if(!reader.IsDBNull(chainLink_IDColumnIndex))
						record.ChainLink_ID = Convert.ToInt32(reader.GetValue(chainLink_IDColumnIndex));
					if(!reader.IsDBNull(storyColumnIndex))
						record.Story = Convert.ToString(reader.GetValue(storyColumnIndex));
					if(!reader.IsDBNull(functionGroup_IDColumnIndex))
						record.FunctionGroup_ID = Convert.ToInt32(reader.GetValue(functionGroup_IDColumnIndex));
					if(!reader.IsDBNull(businessType_IDColumnIndex))
						record.BusinessType_ID = Convert.ToInt32(reader.GetValue(businessType_IDColumnIndex));
					if(!reader.IsDBNull(productBrandChange_NoteColumnIndex))
						record.ProductBrandChange_Note = Convert.ToString(reader.GetValue(productBrandChange_NoteColumnIndex));
					if(!reader.IsDBNull(productBrandChange_ByColumnIndex))
						record.ProductBrandChange_By = reader.GetGuid(productBrandChange_ByColumnIndex);
					if(!reader.IsDBNull(productBrandChange_ApprovedColumnIndex))
						record.ProductBrandChange_Approved = reader.GetGuid(productBrandChange_ApprovedColumnIndex);
					if(!reader.IsDBNull(productBrandChange_DateColumnIndex))
						record.ProductBrandChange_Date = Convert.ToDateTime(reader.GetValue(productBrandChange_DateColumnIndex));
					if(!reader.IsDBNull(productBrandChange_DateApprovedColumnIndex))
						record.ProductBrandChange_DateApproved = Convert.ToDateTime(reader.GetValue(productBrandChange_DateApprovedColumnIndex));
					if(!reader.IsDBNull(productBrandChange_StatusColumnIndex))
						record.ProductBrandChange_Status = Convert.ToInt32(reader.GetValue(productBrandChange_StatusColumnIndex));
					if(!reader.IsDBNull(productBrandChange_ApprovedNoteColumnIndex))
						record.ProductBrandChange_ApprovedNote = Convert.ToString(reader.GetValue(productBrandChange_ApprovedNoteColumnIndex));
					if(!reader.IsDBNull(youTubeColumnIndex))
						record.YouTube = Convert.ToString(reader.GetValue(youTubeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (ProductBrandChangeRow[])(recordList.ToArray(typeof(ProductBrandChangeRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="ProductBrandChangeRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="ProductBrandChangeRow"/> object.</returns>
	protected virtual ProductBrandChangeRow MapRow(DataRow row)
	{
		string LOCATION = "ProductBrandChangeRow MapRow(DataRow row)";
		ProductBrandChangeRow mappedObject = new ProductBrandChangeRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "ProductBrandChange_ID"
		dataColumn = dataTable.Columns["ProductBrandChange_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Language_ID"
		dataColumn = dataTable.Columns["Language_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Language_ID = (int)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "District_ID"
		dataColumn = dataTable.Columns["District_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.District_ID = (int)(row[dataColumn]);
		// Column "Ward_ID"
		dataColumn = dataTable.Columns["Ward_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Ward_ID = (int)(row[dataColumn]);
		// Column "DepartmentMan_ID"
		dataColumn = dataTable.Columns["DepartmentMan_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DepartmentMan_ID = (int)(row[dataColumn]);
		// Column "ProductBrandType_ID"
		dataColumn = dataTable.Columns["ProductBrandType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandType_ID = (int)(row[dataColumn]);
		// Column "Code"
		dataColumn = dataTable.Columns["Code"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Code = (string)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "TradingName"
		dataColumn = dataTable.Columns["TradingName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TradingName = (string)(row[dataColumn]);
		// Column "BrandName"
		dataColumn = dataTable.Columns["BrandName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BrandName = (string)(row[dataColumn]);
		// Column "TaxCode"
		dataColumn = dataTable.Columns["TaxCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaxCode = (string)(row[dataColumn]);
		// Column "RegistrationNumber"
		dataColumn = dataTable.Columns["RegistrationNumber"];
		if (! row.IsNull(dataColumn) )
			mappedObject.RegistrationNumber = (string)(row[dataColumn]);
		// Column "IssuedDate"
		dataColumn = dataTable.Columns["IssuedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IssuedDate = (System.DateTime)(row[dataColumn]);
		// Column "BusinessArea"
		dataColumn = dataTable.Columns["BusinessArea"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BusinessArea = (string)(row[dataColumn]);
		// Column "Address"
		dataColumn = dataTable.Columns["Address"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Address = (string)(row[dataColumn]);
		// Column "Telephone"
		dataColumn = dataTable.Columns["Telephone"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Telephone = (string)(row[dataColumn]);
		// Column "Fax"
		dataColumn = dataTable.Columns["Fax"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Fax = (string)(row[dataColumn]);
		// Column "Mobile"
		dataColumn = dataTable.Columns["Mobile"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Mobile = (string)(row[dataColumn]);
		// Column "Email"
		dataColumn = dataTable.Columns["Email"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Email = (string)(row[dataColumn]);
		// Column "Website"
		dataColumn = dataTable.Columns["Website"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Website = (string)(row[dataColumn]);
		// Column "Facebook"
		dataColumn = dataTable.Columns["Facebook"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Facebook = (string)(row[dataColumn]);
		// Column "Zalo"
		dataColumn = dataTable.Columns["Zalo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Zalo = (string)(row[dataColumn]);
		// Column "Hotline"
		dataColumn = dataTable.Columns["Hotline"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Hotline = (string)(row[dataColumn]);
		// Column "Skype"
		dataColumn = dataTable.Columns["Skype"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Skype = (string)(row[dataColumn]);
		// Column "PRInfo"
		dataColumn = dataTable.Columns["PRInfo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PRInfo = (string)(row[dataColumn]);
		// Column "Agency"
		dataColumn = dataTable.Columns["Agency"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Agency = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Image"
		dataColumn = dataTable.Columns["Image"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Image = (string)(row[dataColumn]);
		// Column "PersonName"
		dataColumn = dataTable.Columns["PersonName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PersonName = (string)(row[dataColumn]);
		// Column "PersonAddress"
		dataColumn = dataTable.Columns["PersonAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PersonAddress = (string)(row[dataColumn]);
		// Column "PersonMobile"
		dataColumn = dataTable.Columns["PersonMobile"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PersonMobile = (string)(row[dataColumn]);
		// Column "PersonEmail"
		dataColumn = dataTable.Columns["PersonEmail"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PersonEmail = (string)(row[dataColumn]);
		// Column "Sort"
		dataColumn = dataTable.Columns["Sort"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Sort = (int)(row[dataColumn]);
		// Column "URL"
		dataColumn = dataTable.Columns["URL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.URL = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
		// Column "HasQRCode"
		dataColumn = dataTable.Columns["HasQRCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.HasQRCode = (bool)(row[dataColumn]);
		// Column "ViewCount"
		dataColumn = dataTable.Columns["ViewCount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ViewCount = (int)(row[dataColumn]);
		// Column "SellCount"
		dataColumn = dataTable.Columns["SellCount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SellCount = (int)(row[dataColumn]);
		// Column "AccountUserName"
		dataColumn = dataTable.Columns["AccountUserName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AccountUserName = (string)(row[dataColumn]);
		// Column "AccountEmail"
		dataColumn = dataTable.Columns["AccountEmail"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AccountEmail = (string)(row[dataColumn]);
		// Column "DirectorName"
		dataColumn = dataTable.Columns["DirectorName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DirectorName = (string)(row[dataColumn]);
		// Column "DirectorBirthday"
		dataColumn = dataTable.Columns["DirectorBirthday"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DirectorBirthday = (System.DateTime)(row[dataColumn]);
		// Column "DirectorAddress"
		dataColumn = dataTable.Columns["DirectorAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DirectorAddress = (string)(row[dataColumn]);
		// Column "DirectorMobile"
		dataColumn = dataTable.Columns["DirectorMobile"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DirectorMobile = (string)(row[dataColumn]);
		// Column "DirectorEmail"
		dataColumn = dataTable.Columns["DirectorEmail"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DirectorEmail = (string)(row[dataColumn]);
		// Column "DirectorPosition"
		dataColumn = dataTable.Columns["DirectorPosition"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DirectorPosition = (string)(row[dataColumn]);
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
		// Column "VerifyApproveBy"
		dataColumn = dataTable.Columns["VerifyApproveBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.VerifyApproveBy = (System.Guid)(row[dataColumn]);
		// Column "VerifyApproveDate"
		dataColumn = dataTable.Columns["VerifyApproveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.VerifyApproveDate = (System.DateTime)(row[dataColumn]);
		// Column "CheckApproveBy"
		dataColumn = dataTable.Columns["CheckApproveBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckApproveBy = (System.Guid)(row[dataColumn]);
		// Column "CheckApproveDate"
		dataColumn = dataTable.Columns["CheckApproveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckApproveDate = (System.DateTime)(row[dataColumn]);
		// Column "AdminApproveBy"
		dataColumn = dataTable.Columns["AdminApproveBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AdminApproveBy = (System.Guid)(row[dataColumn]);
		// Column "AdminApproveDate"
		dataColumn = dataTable.Columns["AdminApproveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AdminApproveDate = (System.DateTime)(row[dataColumn]);
		// Column "QRCodePublicContent"
		dataColumn = dataTable.Columns["QRCodePublicContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePublicContent = (string)(row[dataColumn]);
		// Column "CheckDomain"
		dataColumn = dataTable.Columns["CheckDomain"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckDomain = (string)(row[dataColumn]);
		// Column "CheckServer_ID"
		dataColumn = dataTable.Columns["CheckServer_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckServer_ID = (int)(row[dataColumn]);
		// Column "GCP"
		dataColumn = dataTable.Columns["GCP"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GCP = (string)(row[dataColumn]);
		// Column "GLN"
		dataColumn = dataTable.Columns["GLN"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GLN = (string)(row[dataColumn]);
		// Column "ProductBrandType_ID_List"
		dataColumn = dataTable.Columns["ProductBrandType_ID_List"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandType_ID_List = (string)(row[dataColumn]);
		// Column "Branch_ID"
		dataColumn = dataTable.Columns["Branch_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Branch_ID = (int)(row[dataColumn]);
		// Column "ProductionUnitCode"
		dataColumn = dataTable.Columns["ProductionUnitCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductionUnitCode = (string)(row[dataColumn]);
		// Column "CheckProductBrand_ID"
		dataColumn = dataTable.Columns["CheckProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CheckProductBrand_ID = (int)(row[dataColumn]);
		// Column "ChainLink_ID"
		dataColumn = dataTable.Columns["ChainLink_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ChainLink_ID = (int)(row[dataColumn]);
		// Column "Story"
		dataColumn = dataTable.Columns["Story"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Story = (string)(row[dataColumn]);
		// Column "FunctionGroup_ID"
		dataColumn = dataTable.Columns["FunctionGroup_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FunctionGroup_ID = (int)(row[dataColumn]);
		// Column "BusinessType_ID"
		dataColumn = dataTable.Columns["BusinessType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BusinessType_ID = (int)(row[dataColumn]);
		// Column "ProductBrandChange_Note"
		dataColumn = dataTable.Columns["ProductBrandChange_Note"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_Note = (string)(row[dataColumn]);
		// Column "ProductBrandChange_By"
		dataColumn = dataTable.Columns["ProductBrandChange_By"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_By = (System.Guid)(row[dataColumn]);
		// Column "ProductBrandChange_Approved"
		dataColumn = dataTable.Columns["ProductBrandChange_Approved"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_Approved = (System.Guid)(row[dataColumn]);
		// Column "ProductBrandChange_Date"
		dataColumn = dataTable.Columns["ProductBrandChange_Date"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_Date = (System.DateTime)(row[dataColumn]);
		// Column "ProductBrandChange_DateApproved"
		dataColumn = dataTable.Columns["ProductBrandChange_DateApproved"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_DateApproved = (System.DateTime)(row[dataColumn]);
		// Column "ProductBrandChange_Status"
		dataColumn = dataTable.Columns["ProductBrandChange_Status"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_Status = (int)(row[dataColumn]);
		// Column "ProductBrandChange_ApprovedNote"
		dataColumn = dataTable.Columns["ProductBrandChange_ApprovedNote"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandChange_ApprovedNote = (string)(row[dataColumn]);
		// Column "YouTube"
		dataColumn = dataTable.Columns["YouTube"];
		if (! row.IsNull(dataColumn) )
			mappedObject.YouTube = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>ProductBrandChange</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "ProductBrandChange";
		DataColumn dataColumn;
		// Create the "ProductBrandChange_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		// Create the "Language_ID" column
		dataColumn = dataTable.Columns.Add("Language_ID", typeof(int));
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "District_ID" column
		dataColumn = dataTable.Columns.Add("District_ID", typeof(int));
		// Create the "Ward_ID" column
		dataColumn = dataTable.Columns.Add("Ward_ID", typeof(int));
		// Create the "DepartmentMan_ID" column
		dataColumn = dataTable.Columns.Add("DepartmentMan_ID", typeof(int));
		// Create the "ProductBrandType_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrandType_ID", typeof(int));
		// Create the "Code" column
		dataColumn = dataTable.Columns.Add("Code", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "TradingName" column
		dataColumn = dataTable.Columns.Add("TradingName", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "BrandName" column
		dataColumn = dataTable.Columns.Add("BrandName", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "TaxCode" column
		dataColumn = dataTable.Columns.Add("TaxCode", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "RegistrationNumber" column
		dataColumn = dataTable.Columns.Add("RegistrationNumber", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "IssuedDate" column
		dataColumn = dataTable.Columns.Add("IssuedDate", typeof(System.DateTime));
		// Create the "BusinessArea" column
		dataColumn = dataTable.Columns.Add("BusinessArea", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Address" column
		dataColumn = dataTable.Columns.Add("Address", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Telephone" column
		dataColumn = dataTable.Columns.Add("Telephone", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Fax" column
		dataColumn = dataTable.Columns.Add("Fax", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "Mobile" column
		dataColumn = dataTable.Columns.Add("Mobile", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "Email" column
		dataColumn = dataTable.Columns.Add("Email", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Website" column
		dataColumn = dataTable.Columns.Add("Website", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "Facebook" column
		dataColumn = dataTable.Columns.Add("Facebook", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Zalo" column
		dataColumn = dataTable.Columns.Add("Zalo", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Hotline" column
		dataColumn = dataTable.Columns.Add("Hotline", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Skype" column
		dataColumn = dataTable.Columns.Add("Skype", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "PRInfo" column
		dataColumn = dataTable.Columns.Add("PRInfo", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Agency" column
		dataColumn = dataTable.Columns.Add("Agency", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Image" column
		dataColumn = dataTable.Columns.Add("Image", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "PersonName" column
		dataColumn = dataTable.Columns.Add("PersonName", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "PersonAddress" column
		dataColumn = dataTable.Columns.Add("PersonAddress", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "PersonMobile" column
		dataColumn = dataTable.Columns.Add("PersonMobile", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "PersonEmail" column
		dataColumn = dataTable.Columns.Add("PersonEmail", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "Sort" column
		dataColumn = dataTable.Columns.Add("Sort", typeof(int));
		// Create the "URL" column
		dataColumn = dataTable.Columns.Add("URL", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "HasQRCode" column
		dataColumn = dataTable.Columns.Add("HasQRCode", typeof(bool));
		// Create the "ViewCount" column
		dataColumn = dataTable.Columns.Add("ViewCount", typeof(int));
		// Create the "SellCount" column
		dataColumn = dataTable.Columns.Add("SellCount", typeof(int));
		// Create the "AccountUserName" column
		dataColumn = dataTable.Columns.Add("AccountUserName", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "AccountEmail" column
		dataColumn = dataTable.Columns.Add("AccountEmail", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "DirectorName" column
		dataColumn = dataTable.Columns.Add("DirectorName", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "DirectorBirthday" column
		dataColumn = dataTable.Columns.Add("DirectorBirthday", typeof(System.DateTime));
		// Create the "DirectorAddress" column
		dataColumn = dataTable.Columns.Add("DirectorAddress", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "DirectorMobile" column
		dataColumn = dataTable.Columns.Add("DirectorMobile", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "DirectorEmail" column
		dataColumn = dataTable.Columns.Add("DirectorEmail", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "DirectorPosition" column
		dataColumn = dataTable.Columns.Add("DirectorPosition", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "VerifyApproveBy" column
		dataColumn = dataTable.Columns.Add("VerifyApproveBy", typeof(System.Guid));
		// Create the "VerifyApproveDate" column
		dataColumn = dataTable.Columns.Add("VerifyApproveDate", typeof(System.DateTime));
		// Create the "CheckApproveBy" column
		dataColumn = dataTable.Columns.Add("CheckApproveBy", typeof(System.Guid));
		// Create the "CheckApproveDate" column
		dataColumn = dataTable.Columns.Add("CheckApproveDate", typeof(System.DateTime));
		// Create the "AdminApproveBy" column
		dataColumn = dataTable.Columns.Add("AdminApproveBy", typeof(System.Guid));
		// Create the "AdminApproveDate" column
		dataColumn = dataTable.Columns.Add("AdminApproveDate", typeof(System.DateTime));
		// Create the "QRCodePublicContent" column
		dataColumn = dataTable.Columns.Add("QRCodePublicContent", typeof(string));
		dataColumn.MaxLength = 64;
		// Create the "CheckDomain" column
		dataColumn = dataTable.Columns.Add("CheckDomain", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "CheckServer_ID" column
		dataColumn = dataTable.Columns.Add("CheckServer_ID", typeof(int));
		// Create the "GCP" column
		dataColumn = dataTable.Columns.Add("GCP", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "GLN" column
		dataColumn = dataTable.Columns.Add("GLN", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "ProductBrandType_ID_List" column
		dataColumn = dataTable.Columns.Add("ProductBrandType_ID_List", typeof(string));
		// Create the "Branch_ID" column
		dataColumn = dataTable.Columns.Add("Branch_ID", typeof(int));
		// Create the "ProductionUnitCode" column
		dataColumn = dataTable.Columns.Add("ProductionUnitCode", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CheckProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("CheckProductBrand_ID", typeof(int));
		// Create the "ChainLink_ID" column
		dataColumn = dataTable.Columns.Add("ChainLink_ID", typeof(int));
		// Create the "Story" column
		dataColumn = dataTable.Columns.Add("Story", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "FunctionGroup_ID" column
		dataColumn = dataTable.Columns.Add("FunctionGroup_ID", typeof(int));
		// Create the "BusinessType_ID" column
		dataColumn = dataTable.Columns.Add("BusinessType_ID", typeof(int));
		// Create the "ProductBrandChange_Note" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_Note", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "ProductBrandChange_By" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_By", typeof(System.Guid));
		// Create the "ProductBrandChange_Approved" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_Approved", typeof(System.Guid));
		// Create the "ProductBrandChange_Date" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_Date", typeof(System.DateTime));
		// Create the "ProductBrandChange_DateApproved" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_DateApproved", typeof(System.DateTime));
		// Create the "ProductBrandChange_Status" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_Status", typeof(int));
		// Create the "ProductBrandChange_ApprovedNote" column
		dataColumn = dataTable.Columns.Add("ProductBrandChange_ApprovedNote", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "YouTube" column
		dataColumn = dataTable.Columns.Add("YouTube", typeof(string));
		dataColumn.MaxLength = 200;
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
			case "ProductBrandChange_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Language_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "District_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Ward_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DepartmentMan_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrandType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Code":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TradingName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "BrandName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TaxCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "RegistrationNumber":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "IssuedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "BusinessArea":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Address":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Telephone":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Fax":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Mobile":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Email":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Website":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Facebook":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Zalo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Hotline":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Skype":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PRInfo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Agency":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Image":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PersonName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PersonAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PersonMobile":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PersonEmail":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Sort":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "URL":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "HasQRCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "ViewCount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SellCount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AccountUserName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "AccountEmail":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DirectorName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DirectorBirthday":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "DirectorAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DirectorMobile":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DirectorEmail":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DirectorPosition":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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

			case "VerifyApproveBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "VerifyApproveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CheckApproveBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "CheckApproveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "AdminApproveBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "AdminApproveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "QRCodePublicContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CheckDomain":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CheckServer_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "GCP":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "GLN":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductBrandType_ID_List":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Branch_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductionUnitCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CheckProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ChainLink_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Story":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "FunctionGroup_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "BusinessType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrandChange_Note":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductBrandChange_By":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "ProductBrandChange_Approved":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "ProductBrandChange_Date":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ProductBrandChange_DateApproved":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ProductBrandChange_Status":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrandChange_ApprovedNote":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "YouTube":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="ProductBrandChangeRow"/> by the primary key.
	/// </summary>
	/// <param name="productBrandChange_ID">The <c>ProductBrandChange_ID</c> column value.</param>
	/// <returns>An instance of <see cref="ProductBrandChangeRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int productBrandChange_ID)
	{
		string LOCATION = "Exist(int productBrandChange_ID)";
		IDbCommand cmd = _db.CreateCommand("ProductBrandChange_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "ProductBrandChange_ID", productBrandChange_ID);
		ProductBrandChangeRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




