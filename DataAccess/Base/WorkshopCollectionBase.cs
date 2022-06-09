
// <fileinfo name="Base\WorkshopCollectionBase.cs">
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
/// The base class for <see cref="WorkshopCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WorkshopCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WorkshopCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Workshop_IDColumnName  = "Workshop_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string FarmGroup_IDColumnName  = "FarmGroup_ID";
	public const string FarmGroupInter_IDColumnName  = "FarmGroupInter_ID";
	public const string NameColumnName  = "Name";
	public const string DescriptionColumnName  = "Description";
	public const string Location_IDColumnName  = "Location_ID";
	public const string AboutUsColumnName  = "AboutUs";
	public const string KeywordColumnName  = "Keyword";
	public const string LogoColumnName  = "Logo";
	public const string AddressColumnName  = "Address";
	public const string AcreageColumnName  = "Acreage";
	public const string MapColumnName  = "Map";
	public const string PhoneColumnName  = "Phone";
	public const string FaxColumnName  = "Fax";
	public const string EmailColumnName  = "Email";
	public const string YMColumnName  = "YM";
	public const string SkypeColumnName  = "Skype";
	public const string WebsiteColumnName  = "Website";
	public const string ContactColumnName  = "Contact";
	public const string RankColumnName  = "Rank";
	public const string CounterColumnName  = "Counter";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string URLColumnName  = "URL";
	public const string TagColumnName  = "Tag";
	public const string QRCodePublicContentColumnName  = "QRCodePublicContent";
	public const string StaffType_IDColumnName  = "StaffType_ID";
	public const string ActiveColumnName  = "Active";
	public const string Area_IDColumnName  = "Area_ID";
	public const string Zone_IDColumnName  = "Zone_ID";
	public const string BirthDateColumnName  = "BirthDate";
	public const string GenderColumnName  = "Gender";
	public const string Farm_IDColumnName  = "Farm_ID";
	public const string Department_IDColumnName  = "Department_ID";
	public const string TypeColumnName  = "Type";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WorkshopCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Workshop";
	}

	public WorkshopCollectionBase() : base()
	{
		this.TABLENAME = "Workshop";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Workshop</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WorkshopRow"/> objects.</returns>
	public virtual WorkshopRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Workshop</c> table.
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
	/// to retrieve all records from the <c>Workshop</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Workshop_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WorkshopRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WorkshopRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WorkshopRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WorkshopRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WorkshopRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WorkshopRow"/> objects.</returns>
	public WorkshopRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WorkshopRow"/> objects that 
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
	/// <returns>An array of <see cref="WorkshopRow"/> objects.</returns>
	public virtual WorkshopRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WorkshopRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Workshop_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Workshop_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WorkshopRow"/> by the primary key.
	/// </summary>
	/// <param name="workshop_ID">The <c>Workshop_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WorkshopRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WorkshopRow GetByPrimaryKey(int workshop_ID)
	{
		string LOCATION = "GetByPrimaryKey(int workshop_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Workshop_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Workshop_ID", workshop_ID);
			WorkshopRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Workshop</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WorkshopRow"/> object to be inserted.</param>
	public virtual void Insert(WorkshopRow value)
	{
		string LOCATION = "Insert(WorkshopRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Workshop_Insert", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// FarmGroup_ID
			if (value.IsFarmGroup_IDNull)
				AddParameter(cmd, "FarmGroup_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroup_ID", value.FarmGroup_ID);
			
				// FarmGroupInter_ID
			if (value.IsFarmGroupInter_IDNull)
				AddParameter(cmd, "FarmGroupInter_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupInter_ID", value.FarmGroupInter_ID);
			
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
			
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// AboutUs
			if (value.IsAboutUsNull )
				AddParameter(cmd, "AboutUs", DBNull.Value);
			else
				AddParameter(cmd, "AboutUs", value.AboutUs);
			
				// Keyword
			if (value.IsKeywordNull )
				AddParameter(cmd, "Keyword", DBNull.Value);
			else
				AddParameter(cmd, "Keyword", value.Keyword);
			
				// Logo
			if (value.IsLogoNull )
				AddParameter(cmd, "Logo", DBNull.Value);
			else
				AddParameter(cmd, "Logo", value.Logo);
			
				// Address
			if (value.IsAddressNull )
				AddParameter(cmd, "Address", DBNull.Value);
			else
				AddParameter(cmd, "Address", value.Address);
			
				// Acreage
			if (value.IsAcreageNull)
				AddParameter(cmd, "Acreage", DBNull.Value);
			else
				AddParameter(cmd, "Acreage", value.Acreage);
			
				// Map
			if (value.IsMapNull )
				AddParameter(cmd, "Map", DBNull.Value);
			else
				AddParameter(cmd, "Map", value.Map);
			
				// Phone
			if (value.IsPhoneNull )
				AddParameter(cmd, "Phone", DBNull.Value);
			else
				AddParameter(cmd, "Phone", value.Phone);
			
				// Fax
			if (value.IsFaxNull )
				AddParameter(cmd, "Fax", DBNull.Value);
			else
				AddParameter(cmd, "Fax", value.Fax);
			
				// Email
			if (value.IsEmailNull )
				AddParameter(cmd, "Email", DBNull.Value);
			else
				AddParameter(cmd, "Email", value.Email);
			
				// YM
			if (value.IsYMNull )
				AddParameter(cmd, "YM", DBNull.Value);
			else
				AddParameter(cmd, "YM", value.YM);
			
				// Skype
			if (value.IsSkypeNull )
				AddParameter(cmd, "Skype", DBNull.Value);
			else
				AddParameter(cmd, "Skype", value.Skype);
			
				// Website
			if (value.IsWebsiteNull )
				AddParameter(cmd, "Website", DBNull.Value);
			else
				AddParameter(cmd, "Website", value.Website);
			
				// Contact
			if (value.IsContactNull )
				AddParameter(cmd, "Contact", DBNull.Value);
			else
				AddParameter(cmd, "Contact", value.Contact);
			
				// Rank
			if (value.IsRankNull)
				AddParameter(cmd, "Rank", DBNull.Value);
			else
				AddParameter(cmd, "Rank", value.Rank);
			
				// Counter
			if (value.IsCounterNull)
				AddParameter(cmd, "Counter", DBNull.Value);
			else
				AddParameter(cmd, "Counter", value.Counter);
			
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
			
				// URL
			if (value.IsURLNull )
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
			
				// Tag
			if (value.IsTagNull )
				AddParameter(cmd, "Tag", DBNull.Value);
			else
				AddParameter(cmd, "Tag", value.Tag);
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull )
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
			
				// StaffType_ID
			if (value.IsStaffType_IDNull)
				AddParameter(cmd, "StaffType_ID", DBNull.Value);
			else
				AddParameter(cmd, "StaffType_ID", value.StaffType_ID);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// Area_ID
			if (value.IsArea_IDNull)
				AddParameter(cmd, "Area_ID", DBNull.Value);
			else
				AddParameter(cmd, "Area_ID", value.Area_ID);
			
				// Zone_ID
			if (value.IsZone_IDNull)
				AddParameter(cmd, "Zone_ID", DBNull.Value);
			else
				AddParameter(cmd, "Zone_ID", value.Zone_ID);
			
				// BirthDate
			if (value.IsBirthDateNull)
				AddParameter(cmd, "BirthDate", DBNull.Value);
			else
				AddParameter(cmd, "BirthDate", value.BirthDate);
			
				// Gender
			if (value.IsGenderNull)
				AddParameter(cmd, "Gender", DBNull.Value);
			else
				AddParameter(cmd, "Gender", value.Gender);
			
				// Farm_ID
			if (value.IsFarm_IDNull)
				AddParameter(cmd, "Farm_ID", DBNull.Value);
			else
				AddParameter(cmd, "Farm_ID", value.Farm_ID);
			
				// Department_ID
			if (value.IsDepartment_IDNull)
				AddParameter(cmd, "Department_ID", DBNull.Value);
			else
				AddParameter(cmd, "Department_ID", value.Department_ID);
			
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
						value.Workshop_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>Workshop</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WorkshopRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WorkshopRow value)
	{	
		string LOCATION = "Update(WorkshopRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Workshop_Update", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// FarmGroup_ID
			if (value.IsFarmGroup_IDNull)
				AddParameter(cmd, "FarmGroup_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroup_ID", value.FarmGroup_ID);
			
				// FarmGroupInter_ID
			if (value.IsFarmGroupInter_IDNull)
				AddParameter(cmd, "FarmGroupInter_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupInter_ID", value.FarmGroupInter_ID);
			
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
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// AboutUs
			if (value.IsAboutUsNull)
				AddParameter(cmd, "AboutUs", DBNull.Value);
			else
				AddParameter(cmd, "AboutUs", value.AboutUs);
				// Keyword
			if (value.IsKeywordNull)
				AddParameter(cmd, "Keyword", DBNull.Value);
			else
				AddParameter(cmd, "Keyword", value.Keyword);
				// Logo
			if (value.IsLogoNull)
				AddParameter(cmd, "Logo", DBNull.Value);
			else
				AddParameter(cmd, "Logo", value.Logo);
				// Address
			if (value.IsAddressNull)
				AddParameter(cmd, "Address", DBNull.Value);
			else
				AddParameter(cmd, "Address", value.Address);
				// Acreage
			if (value.IsAcreageNull)
				AddParameter(cmd, "Acreage", DBNull.Value);
			else
				AddParameter(cmd, "Acreage", value.Acreage);
			
				// Map
			if (value.IsMapNull)
				AddParameter(cmd, "Map", DBNull.Value);
			else
				AddParameter(cmd, "Map", value.Map);
				// Phone
			if (value.IsPhoneNull)
				AddParameter(cmd, "Phone", DBNull.Value);
			else
				AddParameter(cmd, "Phone", value.Phone);
				// Fax
			if (value.IsFaxNull)
				AddParameter(cmd, "Fax", DBNull.Value);
			else
				AddParameter(cmd, "Fax", value.Fax);
				// Email
			if (value.IsEmailNull)
				AddParameter(cmd, "Email", DBNull.Value);
			else
				AddParameter(cmd, "Email", value.Email);
				// YM
			if (value.IsYMNull)
				AddParameter(cmd, "YM", DBNull.Value);
			else
				AddParameter(cmd, "YM", value.YM);
				// Skype
			if (value.IsSkypeNull)
				AddParameter(cmd, "Skype", DBNull.Value);
			else
				AddParameter(cmd, "Skype", value.Skype);
				// Website
			if (value.IsWebsiteNull)
				AddParameter(cmd, "Website", DBNull.Value);
			else
				AddParameter(cmd, "Website", value.Website);
				// Contact
			if (value.IsContactNull)
				AddParameter(cmd, "Contact", DBNull.Value);
			else
				AddParameter(cmd, "Contact", value.Contact);
				// Rank
			if (value.IsRankNull)
				AddParameter(cmd, "Rank", DBNull.Value);
			else
				AddParameter(cmd, "Rank", value.Rank);
			
				// Counter
			if (value.IsCounterNull)
				AddParameter(cmd, "Counter", DBNull.Value);
			else
				AddParameter(cmd, "Counter", value.Counter);
			
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
			
				// URL
			if (value.IsURLNull)
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
				// Tag
			if (value.IsTagNull)
				AddParameter(cmd, "Tag", DBNull.Value);
			else
				AddParameter(cmd, "Tag", value.Tag);
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull)
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
				// StaffType_ID
			if (value.IsStaffType_IDNull)
				AddParameter(cmd, "StaffType_ID", DBNull.Value);
			else
				AddParameter(cmd, "StaffType_ID", value.StaffType_ID);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// Area_ID
			if (value.IsArea_IDNull)
				AddParameter(cmd, "Area_ID", DBNull.Value);
			else
				AddParameter(cmd, "Area_ID", value.Area_ID);
			
				// Zone_ID
			if (value.IsZone_IDNull)
				AddParameter(cmd, "Zone_ID", DBNull.Value);
			else
				AddParameter(cmd, "Zone_ID", value.Zone_ID);
			
				// BirthDate
			if (value.IsBirthDateNull)
				AddParameter(cmd, "BirthDate", DBNull.Value);
			else
				AddParameter(cmd, "BirthDate", value.BirthDate);
			
				// Gender
			if (value.IsGenderNull)
				AddParameter(cmd, "Gender", DBNull.Value);
			else
				AddParameter(cmd, "Gender", value.Gender);
			
				// Farm_ID
			if (value.IsFarm_IDNull)
				AddParameter(cmd, "Farm_ID", DBNull.Value);
			else
				AddParameter(cmd, "Farm_ID", value.Farm_ID);
			
				// Department_ID
			if (value.IsDepartment_IDNull)
				AddParameter(cmd, "Department_ID", DBNull.Value);
			else
				AddParameter(cmd, "Department_ID", value.Department_ID);
			
				// Type
			if (value.IsTypeNull)
				AddParameter(cmd, "Type", DBNull.Value);
			else
				AddParameter(cmd, "Type", value.Type);
			
					AddParameter(cmd, "Workshop_ID", value.Workshop_ID);
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
		/// Inserts or Updates a record in the <c>Workshop</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WorkshopRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WorkshopRow value)
		{
			string LOCATION = "Save(WorkshopRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Workshop_Save",CommandType.StoredProcedure);
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// FarmGroup_ID
				if (value.IsFarmGroup_IDNull)
					AddParameter(cmd, "FarmGroup_ID", DBNull.Value);
				else
					AddParameter(cmd, "FarmGroup_ID", (object)(value.FarmGroup_ID));
				
					// FarmGroupInter_ID
				if (value.IsFarmGroupInter_IDNull)
					AddParameter(cmd, "FarmGroupInter_ID", DBNull.Value);
				else
					AddParameter(cmd, "FarmGroupInter_ID", (object)(value.FarmGroupInter_ID));
				
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
				
					// Location_ID
				if (value.IsLocation_IDNull)
					AddParameter(cmd, "Location_ID", DBNull.Value);
				else
					AddParameter(cmd, "Location_ID", (object)(value.Location_ID));
				
					// AboutUs
				if (value.IsAboutUsNull)
					AddParameter(cmd, "AboutUs", DBNull.Value);
				else
					AddParameter(cmd, "AboutUs", (object)(value.AboutUs));
				
					// Keyword
				if (value.IsKeywordNull)
					AddParameter(cmd, "Keyword", DBNull.Value);
				else
					AddParameter(cmd, "Keyword", (object)(value.Keyword));
				
					// Logo
				if (value.IsLogoNull)
					AddParameter(cmd, "Logo", DBNull.Value);
				else
					AddParameter(cmd, "Logo", (object)(value.Logo));
				
					// Address
				if (value.IsAddressNull)
					AddParameter(cmd, "Address", DBNull.Value);
				else
					AddParameter(cmd, "Address", (object)(value.Address));
				
					// Acreage
				if (value.IsAcreageNull)
					AddParameter(cmd, "Acreage", DBNull.Value);
				else
					AddParameter(cmd, "Acreage", (object)(value.Acreage));
				
					// Map
				if (value.IsMapNull)
					AddParameter(cmd, "Map", DBNull.Value);
				else
					AddParameter(cmd, "Map", (object)(value.Map));
				
					// Phone
				if (value.IsPhoneNull)
					AddParameter(cmd, "Phone", DBNull.Value);
				else
					AddParameter(cmd, "Phone", (object)(value.Phone));
				
					// Fax
				if (value.IsFaxNull)
					AddParameter(cmd, "Fax", DBNull.Value);
				else
					AddParameter(cmd, "Fax", (object)(value.Fax));
				
					// Email
				if (value.IsEmailNull)
					AddParameter(cmd, "Email", DBNull.Value);
				else
					AddParameter(cmd, "Email", (object)(value.Email));
				
					// YM
				if (value.IsYMNull)
					AddParameter(cmd, "YM", DBNull.Value);
				else
					AddParameter(cmd, "YM", (object)(value.YM));
				
					// Skype
				if (value.IsSkypeNull)
					AddParameter(cmd, "Skype", DBNull.Value);
				else
					AddParameter(cmd, "Skype", (object)(value.Skype));
				
					// Website
				if (value.IsWebsiteNull)
					AddParameter(cmd, "Website", DBNull.Value);
				else
					AddParameter(cmd, "Website", (object)(value.Website));
				
					// Contact
				if (value.IsContactNull)
					AddParameter(cmd, "Contact", DBNull.Value);
				else
					AddParameter(cmd, "Contact", (object)(value.Contact));
				
					// Rank
				if (value.IsRankNull)
					AddParameter(cmd, "Rank", DBNull.Value);
				else
					AddParameter(cmd, "Rank", (object)(value.Rank));
				
					// Counter
				if (value.IsCounterNull)
					AddParameter(cmd, "Counter", DBNull.Value);
				else
					AddParameter(cmd, "Counter", (object)(value.Counter));
				
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
				
					// URL
				if (value.IsURLNull)
					AddParameter(cmd, "URL", DBNull.Value);
				else
					AddParameter(cmd, "URL", (object)(value.URL));
				
					// Tag
				if (value.IsTagNull)
					AddParameter(cmd, "Tag", DBNull.Value);
				else
					AddParameter(cmd, "Tag", (object)(value.Tag));
				
					// QRCodePublicContent
				if (value.IsQRCodePublicContentNull)
					AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePublicContent", (object)(value.QRCodePublicContent));
				
					// StaffType_ID
				if (value.IsStaffType_IDNull)
					AddParameter(cmd, "StaffType_ID", DBNull.Value);
				else
					AddParameter(cmd, "StaffType_ID", (object)(value.StaffType_ID));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// Area_ID
				if (value.IsArea_IDNull)
					AddParameter(cmd, "Area_ID", DBNull.Value);
				else
					AddParameter(cmd, "Area_ID", (object)(value.Area_ID));
				
					// Zone_ID
				if (value.IsZone_IDNull)
					AddParameter(cmd, "Zone_ID", DBNull.Value);
				else
					AddParameter(cmd, "Zone_ID", (object)(value.Zone_ID));
				
					// BirthDate
				if (value.IsBirthDateNull)
					AddParameter(cmd, "BirthDate", DBNull.Value);
				else
					AddParameter(cmd, "BirthDate", (object)(value.BirthDate));
				
					// Gender
				if (value.IsGenderNull)
					AddParameter(cmd, "Gender", DBNull.Value);
				else
					AddParameter(cmd, "Gender", (object)(value.Gender));
				
					// Farm_ID
				if (value.IsFarm_IDNull)
					AddParameter(cmd, "Farm_ID", DBNull.Value);
				else
					AddParameter(cmd, "Farm_ID", (object)(value.Farm_ID));
				
					// Department_ID
				if (value.IsDepartment_IDNull)
					AddParameter(cmd, "Department_ID", DBNull.Value);
				else
					AddParameter(cmd, "Department_ID", (object)(value.Department_ID));
				
					// Type
				if (value.IsTypeNull)
					AddParameter(cmd, "Type", DBNull.Value);
				else
					AddParameter(cmd, "Type", (object)(value.Type));
				
						AddParameter(cmd, "Workshop_ID", value.Workshop_ID);
						value.Workshop_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Workshop_ID"]);
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
	/// Deletes the specified object from the <c>Workshop</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WorkshopRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WorkshopRow value)
	{
		return DeleteByPrimaryKey(value.Workshop_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Workshop</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="workshop_ID">The <c>Workshop_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int workshop_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int workshop_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Workshop_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Workshop_ID", workshop_ID);
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
	/// Deletes <c>Workshop</c> records that match the specified criteria.
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
	/// to delete <c>Workshop</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Workshop_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Workshop</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Workshop_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WorkshopRow"/> objects.</returns>
	protected WorkshopRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WorkshopRow"/> objects.</returns>
	protected WorkshopRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WorkshopRow"/> objects.</returns>
	protected virtual WorkshopRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Workshop_ID
		int workshop_IDColumnIndex = reader.GetOrdinal("Workshop_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// FarmGroup_ID
		int farmGroup_IDColumnIndex = reader.GetOrdinal("FarmGroup_ID");
		// FarmGroupInter_ID
		int farmGroupInter_IDColumnIndex = reader.GetOrdinal("FarmGroupInter_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// AboutUs
		int aboutUsColumnIndex = reader.GetOrdinal("AboutUs");
		// Keyword
		int keywordColumnIndex = reader.GetOrdinal("Keyword");
		// Logo
		int logoColumnIndex = reader.GetOrdinal("Logo");
		// Address
		int addressColumnIndex = reader.GetOrdinal("Address");
		// Acreage
		int acreageColumnIndex = reader.GetOrdinal("Acreage");
		// Map
		int mapColumnIndex = reader.GetOrdinal("Map");
		// Phone
		int phoneColumnIndex = reader.GetOrdinal("Phone");
		// Fax
		int faxColumnIndex = reader.GetOrdinal("Fax");
		// Email
		int emailColumnIndex = reader.GetOrdinal("Email");
		// YM
		int ymColumnIndex = reader.GetOrdinal("YM");
		// Skype
		int skypeColumnIndex = reader.GetOrdinal("Skype");
		// Website
		int websiteColumnIndex = reader.GetOrdinal("Website");
		// Contact
		int contactColumnIndex = reader.GetOrdinal("Contact");
		// Rank
		int rankColumnIndex = reader.GetOrdinal("Rank");
		// Counter
		int counterColumnIndex = reader.GetOrdinal("Counter");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// URL
		int urlColumnIndex = reader.GetOrdinal("URL");
		// Tag
		int tagColumnIndex = reader.GetOrdinal("Tag");
		// QRCodePublicContent
		int qRCodePublicContentColumnIndex = reader.GetOrdinal("QRCodePublicContent");
		// StaffType_ID
		int staffType_IDColumnIndex = reader.GetOrdinal("StaffType_ID");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// Area_ID
		int area_IDColumnIndex = reader.GetOrdinal("Area_ID");
		// Zone_ID
		int zone_IDColumnIndex = reader.GetOrdinal("Zone_ID");
		// BirthDate
		int birthDateColumnIndex = reader.GetOrdinal("BirthDate");
		// Gender
		int genderColumnIndex = reader.GetOrdinal("Gender");
		// Farm_ID
		int farm_IDColumnIndex = reader.GetOrdinal("Farm_ID");
		// Department_ID
		int department_IDColumnIndex = reader.GetOrdinal("Department_ID");
		// Type
		int typeColumnIndex = reader.GetOrdinal("Type");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WorkshopRow record = new WorkshopRow();
				recordList.Add(record);

					record.Workshop_ID = Convert.ToInt32(reader.GetValue(workshop_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(farmGroup_IDColumnIndex))
						record.FarmGroup_ID = Convert.ToInt32(reader.GetValue(farmGroup_IDColumnIndex));
					if(!reader.IsDBNull(farmGroupInter_IDColumnIndex))
						record.FarmGroupInter_ID = Convert.ToInt32(reader.GetValue(farmGroupInter_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(aboutUsColumnIndex))
						record.AboutUs = Convert.ToString(reader.GetValue(aboutUsColumnIndex));
					if(!reader.IsDBNull(keywordColumnIndex))
						record.Keyword = Convert.ToString(reader.GetValue(keywordColumnIndex));
					if(!reader.IsDBNull(logoColumnIndex))
						record.Logo = Convert.ToString(reader.GetValue(logoColumnIndex));
					if(!reader.IsDBNull(addressColumnIndex))
						record.Address = Convert.ToString(reader.GetValue(addressColumnIndex));
					if(!reader.IsDBNull(acreageColumnIndex))
						record.Acreage = Convert.ToInt32(reader.GetValue(acreageColumnIndex));
					if(!reader.IsDBNull(mapColumnIndex))
						record.Map = Convert.ToString(reader.GetValue(mapColumnIndex));
					if(!reader.IsDBNull(phoneColumnIndex))
						record.Phone = Convert.ToString(reader.GetValue(phoneColumnIndex));
					if(!reader.IsDBNull(faxColumnIndex))
						record.Fax = Convert.ToString(reader.GetValue(faxColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					if(!reader.IsDBNull(ymColumnIndex))
						record.YM = Convert.ToString(reader.GetValue(ymColumnIndex));
					if(!reader.IsDBNull(skypeColumnIndex))
						record.Skype = Convert.ToString(reader.GetValue(skypeColumnIndex));
					if(!reader.IsDBNull(websiteColumnIndex))
						record.Website = Convert.ToString(reader.GetValue(websiteColumnIndex));
					if(!reader.IsDBNull(contactColumnIndex))
						record.Contact = Convert.ToString(reader.GetValue(contactColumnIndex));
					if(!reader.IsDBNull(rankColumnIndex))
						record.Rank = Convert.ToInt32(reader.GetValue(rankColumnIndex));
					if(!reader.IsDBNull(counterColumnIndex))
						record.Counter = Convert.ToInt32(reader.GetValue(counterColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(urlColumnIndex))
						record.URL = Convert.ToString(reader.GetValue(urlColumnIndex));
					if(!reader.IsDBNull(tagColumnIndex))
						record.Tag = Convert.ToString(reader.GetValue(tagColumnIndex));
					if(!reader.IsDBNull(qRCodePublicContentColumnIndex))
						record.QRCodePublicContent = Convert.ToString(reader.GetValue(qRCodePublicContentColumnIndex));
					if(!reader.IsDBNull(staffType_IDColumnIndex))
						record.StaffType_ID = Convert.ToInt32(reader.GetValue(staffType_IDColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(area_IDColumnIndex))
						record.Area_ID = Convert.ToInt32(reader.GetValue(area_IDColumnIndex));
					if(!reader.IsDBNull(zone_IDColumnIndex))
						record.Zone_ID = Convert.ToInt32(reader.GetValue(zone_IDColumnIndex));
					if(!reader.IsDBNull(birthDateColumnIndex))
						record.BirthDate = Convert.ToDateTime(reader.GetValue(birthDateColumnIndex));
					if(!reader.IsDBNull(genderColumnIndex))
						record.Gender = Convert.ToInt32(reader.GetValue(genderColumnIndex));
					if(!reader.IsDBNull(farm_IDColumnIndex))
						record.Farm_ID = Convert.ToInt32(reader.GetValue(farm_IDColumnIndex));
					if(!reader.IsDBNull(department_IDColumnIndex))
						record.Department_ID = Convert.ToInt32(reader.GetValue(department_IDColumnIndex));
					if(!reader.IsDBNull(typeColumnIndex))
						record.Type = Convert.ToInt32(reader.GetValue(typeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (WorkshopRow[])(recordList.ToArray(typeof(WorkshopRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WorkshopRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WorkshopRow"/> object.</returns>
	protected virtual WorkshopRow MapRow(DataRow row)
	{
		string LOCATION = "WorkshopRow MapRow(DataRow row)";
		WorkshopRow mappedObject = new WorkshopRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Workshop_ID"
		dataColumn = dataTable.Columns["Workshop_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Workshop_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "FarmGroup_ID"
		dataColumn = dataTable.Columns["FarmGroup_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmGroup_ID = (int)(row[dataColumn]);
		// Column "FarmGroupInter_ID"
		dataColumn = dataTable.Columns["FarmGroupInter_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmGroupInter_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "AboutUs"
		dataColumn = dataTable.Columns["AboutUs"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AboutUs = (string)(row[dataColumn]);
		// Column "Keyword"
		dataColumn = dataTable.Columns["Keyword"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Keyword = (string)(row[dataColumn]);
		// Column "Logo"
		dataColumn = dataTable.Columns["Logo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Logo = (string)(row[dataColumn]);
		// Column "Address"
		dataColumn = dataTable.Columns["Address"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Address = (string)(row[dataColumn]);
		// Column "Acreage"
		dataColumn = dataTable.Columns["Acreage"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Acreage = (int)(row[dataColumn]);
		// Column "Map"
		dataColumn = dataTable.Columns["Map"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Map = (string)(row[dataColumn]);
		// Column "Phone"
		dataColumn = dataTable.Columns["Phone"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Phone = (string)(row[dataColumn]);
		// Column "Fax"
		dataColumn = dataTable.Columns["Fax"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Fax = (string)(row[dataColumn]);
		// Column "Email"
		dataColumn = dataTable.Columns["Email"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Email = (string)(row[dataColumn]);
		// Column "YM"
		dataColumn = dataTable.Columns["YM"];
		if (! row.IsNull(dataColumn) )
			mappedObject.YM = (string)(row[dataColumn]);
		// Column "Skype"
		dataColumn = dataTable.Columns["Skype"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Skype = (string)(row[dataColumn]);
		// Column "Website"
		dataColumn = dataTable.Columns["Website"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Website = (string)(row[dataColumn]);
		// Column "Contact"
		dataColumn = dataTable.Columns["Contact"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Contact = (string)(row[dataColumn]);
		// Column "Rank"
		dataColumn = dataTable.Columns["Rank"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Rank = (int)(row[dataColumn]);
		// Column "Counter"
		dataColumn = dataTable.Columns["Counter"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Counter = (int)(row[dataColumn]);
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
		// Column "URL"
		dataColumn = dataTable.Columns["URL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.URL = (string)(row[dataColumn]);
		// Column "Tag"
		dataColumn = dataTable.Columns["Tag"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Tag = (string)(row[dataColumn]);
		// Column "QRCodePublicContent"
		dataColumn = dataTable.Columns["QRCodePublicContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePublicContent = (string)(row[dataColumn]);
		// Column "StaffType_ID"
		dataColumn = dataTable.Columns["StaffType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StaffType_ID = (int)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (int)(row[dataColumn]);
		// Column "Area_ID"
		dataColumn = dataTable.Columns["Area_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Area_ID = (int)(row[dataColumn]);
		// Column "Zone_ID"
		dataColumn = dataTable.Columns["Zone_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Zone_ID = (int)(row[dataColumn]);
		// Column "BirthDate"
		dataColumn = dataTable.Columns["BirthDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BirthDate = (System.DateTime)(row[dataColumn]);
		// Column "Gender"
		dataColumn = dataTable.Columns["Gender"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Gender = (int)(row[dataColumn]);
		// Column "Farm_ID"
		dataColumn = dataTable.Columns["Farm_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Farm_ID = (int)(row[dataColumn]);
		// Column "Department_ID"
		dataColumn = dataTable.Columns["Department_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Department_ID = (int)(row[dataColumn]);
		// Column "Type"
		dataColumn = dataTable.Columns["Type"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Type = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Workshop</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Workshop";
		DataColumn dataColumn;
		// Create the "Workshop_ID" column
		dataColumn = dataTable.Columns.Add("Workshop_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "FarmGroup_ID" column
		dataColumn = dataTable.Columns.Add("FarmGroup_ID", typeof(int));
		// Create the "FarmGroupInter_ID" column
		dataColumn = dataTable.Columns.Add("FarmGroupInter_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "AboutUs" column
		dataColumn = dataTable.Columns.Add("AboutUs", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Keyword" column
		dataColumn = dataTable.Columns.Add("Keyword", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Logo" column
		dataColumn = dataTable.Columns.Add("Logo", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Address" column
		dataColumn = dataTable.Columns.Add("Address", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Acreage" column
		dataColumn = dataTable.Columns.Add("Acreage", typeof(int));
		// Create the "Map" column
		dataColumn = dataTable.Columns.Add("Map", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Phone" column
		dataColumn = dataTable.Columns.Add("Phone", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Fax" column
		dataColumn = dataTable.Columns.Add("Fax", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Email" column
		dataColumn = dataTable.Columns.Add("Email", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "YM" column
		dataColumn = dataTable.Columns.Add("YM", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Skype" column
		dataColumn = dataTable.Columns.Add("Skype", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Website" column
		dataColumn = dataTable.Columns.Add("Website", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Contact" column
		dataColumn = dataTable.Columns.Add("Contact", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Rank" column
		dataColumn = dataTable.Columns.Add("Rank", typeof(int));
		// Create the "Counter" column
		dataColumn = dataTable.Columns.Add("Counter", typeof(int));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "URL" column
		dataColumn = dataTable.Columns.Add("URL", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "Tag" column
		dataColumn = dataTable.Columns.Add("Tag", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "QRCodePublicContent" column
		dataColumn = dataTable.Columns.Add("QRCodePublicContent", typeof(string));
		dataColumn.MaxLength = 64;
		// Create the "StaffType_ID" column
		dataColumn = dataTable.Columns.Add("StaffType_ID", typeof(int));
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(int));
		// Create the "Area_ID" column
		dataColumn = dataTable.Columns.Add("Area_ID", typeof(int));
		// Create the "Zone_ID" column
		dataColumn = dataTable.Columns.Add("Zone_ID", typeof(int));
		// Create the "BirthDate" column
		dataColumn = dataTable.Columns.Add("BirthDate", typeof(System.DateTime));
		// Create the "Gender" column
		dataColumn = dataTable.Columns.Add("Gender", typeof(int));
		// Create the "Farm_ID" column
		dataColumn = dataTable.Columns.Add("Farm_ID", typeof(int));
		// Create the "Department_ID" column
		dataColumn = dataTable.Columns.Add("Department_ID", typeof(int));
		// Create the "Type" column
		dataColumn = dataTable.Columns.Add("Type", typeof(int));
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
			case "Workshop_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FarmGroup_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FarmGroupInter_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AboutUs":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Keyword":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Logo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Address":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Acreage":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Map":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Phone":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Fax":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Email":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "YM":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Skype":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Website":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Contact":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Rank":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Counter":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
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

			case "URL":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Tag":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodePublicContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StaffType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Area_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Zone_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "BirthDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Gender":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Farm_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Department_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Type":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WorkshopRow"/> by the primary key.
	/// </summary>
	/// <param name="workshop_ID">The <c>Workshop_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WorkshopRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int workshop_ID)
	{
		string LOCATION = "Exist(int workshop_ID)";
		IDbCommand cmd = _db.CreateCommand("Workshop_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Workshop_ID", workshop_ID);
		WorkshopRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




