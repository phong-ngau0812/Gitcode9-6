
// <fileinfo name="Base\StoreCollectionBase.cs">
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
/// The base class for <see cref="StoreCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="StoreCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class StoreCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Store_IDColumnName  = "Store_ID";
	public const string Style_IDColumnName  = "Style_ID";
	public const string NameColumnName  = "Name";
	public const string DescriptionColumnName  = "Description";
	public const string AboutUsColumnName  = "AboutUs";
	public const string KeywordColumnName  = "Keyword";
	public const string LogoColumnName  = "Logo";
	public const string BannerColumnName  = "Banner";
	public const string BannerExtColumnName  = "BannerExt";
	public const string BannerWidthColumnName  = "BannerWidth";
	public const string BannerHeightColumnName  = "BannerHeight";
	public const string PageBackgroundColumnName  = "PageBackground";
	public const string Ad_leftColumnName  = "Ad_left";
	public const string Ad_topColumnName  = "Ad_top";
	public const string AddressColumnName  = "Address";
	public const string Location_IDColumnName  = "Location_ID";
	public const string MapColumnName  = "Map";
	public const string PhoneColumnName  = "Phone";
	public const string FaxColumnName  = "Fax";
	public const string EmailColumnName  = "Email";
	public const string YMColumnName  = "YM";
	public const string YM2ColumnName  = "YM2";
	public const string SkypeColumnName  = "Skype";
	public const string WebsiteColumnName  = "Website";
	public const string ContactColumnName  = "Contact";
	public const string SupportBuyColumnName  = "SupportBuy";
	public const string RankColumnName  = "Rank";
	public const string StartDateColumnName  = "StartDate";
	public const string EndDateColumnName  = "EndDate";
	public const string ActiveColumnName  = "Active";
	public const string ArticleTopColumnName  = "ArticleTop";
	public const string ProductTopColumnName  = "ProductTop";
	public const string DomainColumnName  = "Domain";
	public const string SubDomainColumnName  = "SubDomain";
	public const string CounterColumnName  = "Counter";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string URLColumnName  = "URL";
	public const string TagColumnName  = "Tag";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public StoreCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Store";
	}

	public StoreCollectionBase() : base()
	{
		this.TABLENAME = "Store";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Store</c> table.
	/// </summary>
	/// <returns>An array of <see cref="StoreRow"/> objects.</returns>
	public virtual StoreRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Store</c> table.
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
	/// to retrieve all records from the <c>Store</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Store_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="StoreRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="StoreRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public StoreRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			StoreRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="StoreRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="StoreRow"/> objects.</returns>
	public StoreRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="StoreRow"/> objects that 
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
	/// <returns>An array of <see cref="StoreRow"/> objects.</returns>
	public virtual StoreRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			StoreRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Store_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Store_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="StoreRow"/> by the primary key.
	/// </summary>
	/// <param name="store_ID">The <c>Store_ID</c> column value.</param>
	/// <returns>An instance of <see cref="StoreRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual StoreRow GetByPrimaryKey(int store_ID)
	{
		string LOCATION = "GetByPrimaryKey(int store_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Store_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Store_ID", store_ID);
			StoreRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Store</c> table.
	/// </summary>
	/// <param name="value">The <see cref="StoreRow"/> object to be inserted.</param>
	public virtual void Insert(StoreRow value)
	{
		string LOCATION = "Insert(StoreRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Store_Insert", CommandType.StoredProcedure);
					// Style_ID
			if (value.IsStyle_IDNull)
				AddParameter(cmd, "Style_ID", DBNull.Value);
			else
				AddParameter(cmd, "Style_ID", value.Style_ID);
			
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
			
				// Banner
			if (value.IsBannerNull )
				AddParameter(cmd, "Banner", DBNull.Value);
			else
				AddParameter(cmd, "Banner", value.Banner);
			
				// BannerExt
			if (value.IsBannerExtNull )
				AddParameter(cmd, "BannerExt", DBNull.Value);
			else
				AddParameter(cmd, "BannerExt", value.BannerExt);
			
				// BannerWidth
			if (value.IsBannerWidthNull)
				AddParameter(cmd, "BannerWidth", DBNull.Value);
			else
				AddParameter(cmd, "BannerWidth", value.BannerWidth);
			
				// BannerHeight
			if (value.IsBannerHeightNull)
				AddParameter(cmd, "BannerHeight", DBNull.Value);
			else
				AddParameter(cmd, "BannerHeight", value.BannerHeight);
			
				// PageBackground
			if (value.IsPageBackgroundNull )
				AddParameter(cmd, "PageBackground", DBNull.Value);
			else
				AddParameter(cmd, "PageBackground", value.PageBackground);
			
				// Ad_left
			if (value.IsAd_leftNull )
				AddParameter(cmd, "Ad_left", DBNull.Value);
			else
				AddParameter(cmd, "Ad_left", value.Ad_left);
			
				// Ad_top
			if (value.IsAd_topNull )
				AddParameter(cmd, "Ad_top", DBNull.Value);
			else
				AddParameter(cmd, "Ad_top", value.Ad_top);
			
				// Address
			if (value.IsAddressNull )
				AddParameter(cmd, "Address", DBNull.Value);
			else
				AddParameter(cmd, "Address", value.Address);
			
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
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
			
				// YM2
			if (value.IsYM2Null )
				AddParameter(cmd, "YM2", DBNull.Value);
			else
				AddParameter(cmd, "YM2", value.YM2);
			
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
			
				// SupportBuy
			if (value.IsSupportBuyNull )
				AddParameter(cmd, "SupportBuy", DBNull.Value);
			else
				AddParameter(cmd, "SupportBuy", value.SupportBuy);
			
				// Rank
			if (value.IsRankNull)
				AddParameter(cmd, "Rank", DBNull.Value);
			else
				AddParameter(cmd, "Rank", value.Rank);
			
				// StartDate
			if (value.IsStartDateNull)
				AddParameter(cmd, "StartDate", DBNull.Value);
			else
				AddParameter(cmd, "StartDate", value.StartDate);
			
				// EndDate
			if (value.IsEndDateNull)
				AddParameter(cmd, "EndDate", DBNull.Value);
			else
				AddParameter(cmd, "EndDate", value.EndDate);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// ArticleTop
			if (value.IsArticleTopNull)
				AddParameter(cmd, "ArticleTop", DBNull.Value);
			else
				AddParameter(cmd, "ArticleTop", value.ArticleTop);
			
				// ProductTop
			if (value.IsProductTopNull)
				AddParameter(cmd, "ProductTop", DBNull.Value);
			else
				AddParameter(cmd, "ProductTop", value.ProductTop);
			
				// Domain
			if (value.IsDomainNull )
				AddParameter(cmd, "Domain", DBNull.Value);
			else
				AddParameter(cmd, "Domain", value.Domain);
			
				// SubDomain
			if (value.IsSubDomainNull )
				AddParameter(cmd, "SubDomain", DBNull.Value);
			else
				AddParameter(cmd, "SubDomain", value.SubDomain);
			
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
			
						value.Store_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>Store</c> table.
	/// </summary>
	/// <param name="value">The <see cref="StoreRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(StoreRow value)
	{	
		string LOCATION = "Update(StoreRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Store_Update", CommandType.StoredProcedure);
					// Style_ID
			if (value.IsStyle_IDNull)
				AddParameter(cmd, "Style_ID", DBNull.Value);
			else
				AddParameter(cmd, "Style_ID", value.Style_ID);
			
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
				// Banner
			if (value.IsBannerNull)
				AddParameter(cmd, "Banner", DBNull.Value);
			else
				AddParameter(cmd, "Banner", value.Banner);
				// BannerExt
			if (value.IsBannerExtNull)
				AddParameter(cmd, "BannerExt", DBNull.Value);
			else
				AddParameter(cmd, "BannerExt", value.BannerExt);
				// BannerWidth
			if (value.IsBannerWidthNull)
				AddParameter(cmd, "BannerWidth", DBNull.Value);
			else
				AddParameter(cmd, "BannerWidth", value.BannerWidth);
			
				// BannerHeight
			if (value.IsBannerHeightNull)
				AddParameter(cmd, "BannerHeight", DBNull.Value);
			else
				AddParameter(cmd, "BannerHeight", value.BannerHeight);
			
				// PageBackground
			if (value.IsPageBackgroundNull)
				AddParameter(cmd, "PageBackground", DBNull.Value);
			else
				AddParameter(cmd, "PageBackground", value.PageBackground);
				// Ad_left
			if (value.IsAd_leftNull)
				AddParameter(cmd, "Ad_left", DBNull.Value);
			else
				AddParameter(cmd, "Ad_left", value.Ad_left);
				// Ad_top
			if (value.IsAd_topNull)
				AddParameter(cmd, "Ad_top", DBNull.Value);
			else
				AddParameter(cmd, "Ad_top", value.Ad_top);
				// Address
			if (value.IsAddressNull)
				AddParameter(cmd, "Address", DBNull.Value);
			else
				AddParameter(cmd, "Address", value.Address);
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
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
				// YM2
			if (value.IsYM2Null)
				AddParameter(cmd, "YM2", DBNull.Value);
			else
				AddParameter(cmd, "YM2", value.YM2);
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
				// SupportBuy
			if (value.IsSupportBuyNull)
				AddParameter(cmd, "SupportBuy", DBNull.Value);
			else
				AddParameter(cmd, "SupportBuy", value.SupportBuy);
				// Rank
			if (value.IsRankNull)
				AddParameter(cmd, "Rank", DBNull.Value);
			else
				AddParameter(cmd, "Rank", value.Rank);
			
				// StartDate
			if (value.IsStartDateNull)
				AddParameter(cmd, "StartDate", DBNull.Value);
			else
				AddParameter(cmd, "StartDate", value.StartDate);
			
				// EndDate
			if (value.IsEndDateNull)
				AddParameter(cmd, "EndDate", DBNull.Value);
			else
				AddParameter(cmd, "EndDate", value.EndDate);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// ArticleTop
			if (value.IsArticleTopNull)
				AddParameter(cmd, "ArticleTop", DBNull.Value);
			else
				AddParameter(cmd, "ArticleTop", value.ArticleTop);
			
				// ProductTop
			if (value.IsProductTopNull)
				AddParameter(cmd, "ProductTop", DBNull.Value);
			else
				AddParameter(cmd, "ProductTop", value.ProductTop);
			
				// Domain
			if (value.IsDomainNull)
				AddParameter(cmd, "Domain", DBNull.Value);
			else
				AddParameter(cmd, "Domain", value.Domain);
				// SubDomain
			if (value.IsSubDomainNull)
				AddParameter(cmd, "SubDomain", DBNull.Value);
			else
				AddParameter(cmd, "SubDomain", value.SubDomain);
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
					AddParameter(cmd, "Store_ID", value.Store_ID);
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
		/// Inserts or Updates a record in the <c>Store</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="StoreRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(StoreRow value)
		{
			string LOCATION = "Save(StoreRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Store_Save",CommandType.StoredProcedure);
					// Style_ID
				if (value.IsStyle_IDNull)
					AddParameter(cmd, "Style_ID", DBNull.Value);
				else
					AddParameter(cmd, "Style_ID", (object)(value.Style_ID));
				
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
				
					// Banner
				if (value.IsBannerNull)
					AddParameter(cmd, "Banner", DBNull.Value);
				else
					AddParameter(cmd, "Banner", (object)(value.Banner));
				
					// BannerExt
				if (value.IsBannerExtNull)
					AddParameter(cmd, "BannerExt", DBNull.Value);
				else
					AddParameter(cmd, "BannerExt", (object)(value.BannerExt));
				
					// BannerWidth
				if (value.IsBannerWidthNull)
					AddParameter(cmd, "BannerWidth", DBNull.Value);
				else
					AddParameter(cmd, "BannerWidth", (object)(value.BannerWidth));
				
					// BannerHeight
				if (value.IsBannerHeightNull)
					AddParameter(cmd, "BannerHeight", DBNull.Value);
				else
					AddParameter(cmd, "BannerHeight", (object)(value.BannerHeight));
				
					// PageBackground
				if (value.IsPageBackgroundNull)
					AddParameter(cmd, "PageBackground", DBNull.Value);
				else
					AddParameter(cmd, "PageBackground", (object)(value.PageBackground));
				
					// Ad_left
				if (value.IsAd_leftNull)
					AddParameter(cmd, "Ad_left", DBNull.Value);
				else
					AddParameter(cmd, "Ad_left", (object)(value.Ad_left));
				
					// Ad_top
				if (value.IsAd_topNull)
					AddParameter(cmd, "Ad_top", DBNull.Value);
				else
					AddParameter(cmd, "Ad_top", (object)(value.Ad_top));
				
					// Address
				if (value.IsAddressNull)
					AddParameter(cmd, "Address", DBNull.Value);
				else
					AddParameter(cmd, "Address", (object)(value.Address));
				
					// Location_ID
				if (value.IsLocation_IDNull)
					AddParameter(cmd, "Location_ID", DBNull.Value);
				else
					AddParameter(cmd, "Location_ID", (object)(value.Location_ID));
				
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
				
					// YM2
				if (value.IsYM2Null)
					AddParameter(cmd, "YM2", DBNull.Value);
				else
					AddParameter(cmd, "YM2", (object)(value.YM2));
				
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
				
					// SupportBuy
				if (value.IsSupportBuyNull)
					AddParameter(cmd, "SupportBuy", DBNull.Value);
				else
					AddParameter(cmd, "SupportBuy", (object)(value.SupportBuy));
				
					// Rank
				if (value.IsRankNull)
					AddParameter(cmd, "Rank", DBNull.Value);
				else
					AddParameter(cmd, "Rank", (object)(value.Rank));
				
					// StartDate
				if (value.IsStartDateNull)
					AddParameter(cmd, "StartDate", DBNull.Value);
				else
					AddParameter(cmd, "StartDate", (object)(value.StartDate));
				
					// EndDate
				if (value.IsEndDateNull)
					AddParameter(cmd, "EndDate", DBNull.Value);
				else
					AddParameter(cmd, "EndDate", (object)(value.EndDate));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// ArticleTop
				if (value.IsArticleTopNull)
					AddParameter(cmd, "ArticleTop", DBNull.Value);
				else
					AddParameter(cmd, "ArticleTop", (object)(value.ArticleTop));
				
					// ProductTop
				if (value.IsProductTopNull)
					AddParameter(cmd, "ProductTop", DBNull.Value);
				else
					AddParameter(cmd, "ProductTop", (object)(value.ProductTop));
				
					// Domain
				if (value.IsDomainNull)
					AddParameter(cmd, "Domain", DBNull.Value);
				else
					AddParameter(cmd, "Domain", (object)(value.Domain));
				
					// SubDomain
				if (value.IsSubDomainNull)
					AddParameter(cmd, "SubDomain", DBNull.Value);
				else
					AddParameter(cmd, "SubDomain", (object)(value.SubDomain));
				
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
				
						AddParameter(cmd, "Store_ID", value.Store_ID);
						value.Store_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Store_ID"]);
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
	/// Deletes the specified object from the <c>Store</c> table.
	/// </summary>
	/// <param name="value">The <see cref="StoreRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(StoreRow value)
	{
		return DeleteByPrimaryKey(value.Store_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Store</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="store_ID">The <c>Store_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int store_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int store_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Store_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Store_ID", store_ID);
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
	/// Deletes <c>Store</c> records that match the specified criteria.
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
	/// to delete <c>Store</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Store_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Store</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Store_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="StoreRow"/> objects.</returns>
	protected StoreRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="StoreRow"/> objects.</returns>
	protected StoreRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="StoreRow"/> objects.</returns>
	protected virtual StoreRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Store_ID
		int store_IDColumnIndex = reader.GetOrdinal("Store_ID");
		// Style_ID
		int style_IDColumnIndex = reader.GetOrdinal("Style_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// AboutUs
		int aboutUsColumnIndex = reader.GetOrdinal("AboutUs");
		// Keyword
		int keywordColumnIndex = reader.GetOrdinal("Keyword");
		// Logo
		int logoColumnIndex = reader.GetOrdinal("Logo");
		// Banner
		int bannerColumnIndex = reader.GetOrdinal("Banner");
		// BannerExt
		int bannerExtColumnIndex = reader.GetOrdinal("BannerExt");
		// BannerWidth
		int bannerWidthColumnIndex = reader.GetOrdinal("BannerWidth");
		// BannerHeight
		int bannerHeightColumnIndex = reader.GetOrdinal("BannerHeight");
		// PageBackground
		int pageBackgroundColumnIndex = reader.GetOrdinal("PageBackground");
		// Ad_left
		int ad_leftColumnIndex = reader.GetOrdinal("Ad_left");
		// Ad_top
		int ad_topColumnIndex = reader.GetOrdinal("Ad_top");
		// Address
		int addressColumnIndex = reader.GetOrdinal("Address");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
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
		// YM2
		int ym2ColumnIndex = reader.GetOrdinal("YM2");
		// Skype
		int skypeColumnIndex = reader.GetOrdinal("Skype");
		// Website
		int websiteColumnIndex = reader.GetOrdinal("Website");
		// Contact
		int contactColumnIndex = reader.GetOrdinal("Contact");
		// SupportBuy
		int supportBuyColumnIndex = reader.GetOrdinal("SupportBuy");
		// Rank
		int rankColumnIndex = reader.GetOrdinal("Rank");
		// StartDate
		int startDateColumnIndex = reader.GetOrdinal("StartDate");
		// EndDate
		int endDateColumnIndex = reader.GetOrdinal("EndDate");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// ArticleTop
		int articleTopColumnIndex = reader.GetOrdinal("ArticleTop");
		// ProductTop
		int productTopColumnIndex = reader.GetOrdinal("ProductTop");
		// Domain
		int domainColumnIndex = reader.GetOrdinal("Domain");
		// SubDomain
		int subDomainColumnIndex = reader.GetOrdinal("SubDomain");
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

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				StoreRow record = new StoreRow();
				recordList.Add(record);

					record.Store_ID = Convert.ToInt32(reader.GetValue(store_IDColumnIndex));
					if(!reader.IsDBNull(style_IDColumnIndex))
						record.Style_ID = Convert.ToInt32(reader.GetValue(style_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(aboutUsColumnIndex))
						record.AboutUs = Convert.ToString(reader.GetValue(aboutUsColumnIndex));
					if(!reader.IsDBNull(keywordColumnIndex))
						record.Keyword = Convert.ToString(reader.GetValue(keywordColumnIndex));
					if(!reader.IsDBNull(logoColumnIndex))
						record.Logo = Convert.ToString(reader.GetValue(logoColumnIndex));
					if(!reader.IsDBNull(bannerColumnIndex))
						record.Banner = Convert.ToString(reader.GetValue(bannerColumnIndex));
					if(!reader.IsDBNull(bannerExtColumnIndex))
						record.BannerExt = Convert.ToString(reader.GetValue(bannerExtColumnIndex));
					if(!reader.IsDBNull(bannerWidthColumnIndex))
						record.BannerWidth = Convert.ToInt32(reader.GetValue(bannerWidthColumnIndex));
					if(!reader.IsDBNull(bannerHeightColumnIndex))
						record.BannerHeight = Convert.ToInt32(reader.GetValue(bannerHeightColumnIndex));
					if(!reader.IsDBNull(pageBackgroundColumnIndex))
						record.PageBackground = Convert.ToString(reader.GetValue(pageBackgroundColumnIndex));
					if(!reader.IsDBNull(ad_leftColumnIndex))
						record.Ad_left = Convert.ToString(reader.GetValue(ad_leftColumnIndex));
					if(!reader.IsDBNull(ad_topColumnIndex))
						record.Ad_top = Convert.ToString(reader.GetValue(ad_topColumnIndex));
					if(!reader.IsDBNull(addressColumnIndex))
						record.Address = Convert.ToString(reader.GetValue(addressColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
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
					if(!reader.IsDBNull(ym2ColumnIndex))
						record.YM2 = Convert.ToString(reader.GetValue(ym2ColumnIndex));
					if(!reader.IsDBNull(skypeColumnIndex))
						record.Skype = Convert.ToString(reader.GetValue(skypeColumnIndex));
					if(!reader.IsDBNull(websiteColumnIndex))
						record.Website = Convert.ToString(reader.GetValue(websiteColumnIndex));
					if(!reader.IsDBNull(contactColumnIndex))
						record.Contact = Convert.ToString(reader.GetValue(contactColumnIndex));
					if(!reader.IsDBNull(supportBuyColumnIndex))
						record.SupportBuy = Convert.ToString(reader.GetValue(supportBuyColumnIndex));
					if(!reader.IsDBNull(rankColumnIndex))
						record.Rank = Convert.ToInt32(reader.GetValue(rankColumnIndex));
					if(!reader.IsDBNull(startDateColumnIndex))
						record.StartDate = Convert.ToDateTime(reader.GetValue(startDateColumnIndex));
					if(!reader.IsDBNull(endDateColumnIndex))
						record.EndDate = Convert.ToDateTime(reader.GetValue(endDateColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(articleTopColumnIndex))
						record.ArticleTop = Convert.ToInt32(reader.GetValue(articleTopColumnIndex));
					if(!reader.IsDBNull(productTopColumnIndex))
						record.ProductTop = Convert.ToInt32(reader.GetValue(productTopColumnIndex));
					if(!reader.IsDBNull(domainColumnIndex))
						record.Domain = Convert.ToString(reader.GetValue(domainColumnIndex));
					if(!reader.IsDBNull(subDomainColumnIndex))
						record.SubDomain = Convert.ToString(reader.GetValue(subDomainColumnIndex));
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

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (StoreRow[])(recordList.ToArray(typeof(StoreRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="StoreRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="StoreRow"/> object.</returns>
	protected virtual StoreRow MapRow(DataRow row)
	{
		string LOCATION = "StoreRow MapRow(DataRow row)";
		StoreRow mappedObject = new StoreRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Store_ID"
		dataColumn = dataTable.Columns["Store_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Store_ID = (int)(row[dataColumn]);
		// Column "Style_ID"
		dataColumn = dataTable.Columns["Style_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Style_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
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
		// Column "Banner"
		dataColumn = dataTable.Columns["Banner"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Banner = (string)(row[dataColumn]);
		// Column "BannerExt"
		dataColumn = dataTable.Columns["BannerExt"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BannerExt = (string)(row[dataColumn]);
		// Column "BannerWidth"
		dataColumn = dataTable.Columns["BannerWidth"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BannerWidth = (int)(row[dataColumn]);
		// Column "BannerHeight"
		dataColumn = dataTable.Columns["BannerHeight"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BannerHeight = (int)(row[dataColumn]);
		// Column "PageBackground"
		dataColumn = dataTable.Columns["PageBackground"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PageBackground = (string)(row[dataColumn]);
		// Column "Ad_left"
		dataColumn = dataTable.Columns["Ad_left"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Ad_left = (string)(row[dataColumn]);
		// Column "Ad_top"
		dataColumn = dataTable.Columns["Ad_top"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Ad_top = (string)(row[dataColumn]);
		// Column "Address"
		dataColumn = dataTable.Columns["Address"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Address = (string)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
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
		// Column "YM2"
		dataColumn = dataTable.Columns["YM2"];
		if (! row.IsNull(dataColumn) )
			mappedObject.YM2 = (string)(row[dataColumn]);
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
		// Column "SupportBuy"
		dataColumn = dataTable.Columns["SupportBuy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SupportBuy = (string)(row[dataColumn]);
		// Column "Rank"
		dataColumn = dataTable.Columns["Rank"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Rank = (int)(row[dataColumn]);
		// Column "StartDate"
		dataColumn = dataTable.Columns["StartDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StartDate = (System.DateTime)(row[dataColumn]);
		// Column "EndDate"
		dataColumn = dataTable.Columns["EndDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.EndDate = (System.DateTime)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
		// Column "ArticleTop"
		dataColumn = dataTable.Columns["ArticleTop"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ArticleTop = (int)(row[dataColumn]);
		// Column "ProductTop"
		dataColumn = dataTable.Columns["ProductTop"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductTop = (int)(row[dataColumn]);
		// Column "Domain"
		dataColumn = dataTable.Columns["Domain"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Domain = (string)(row[dataColumn]);
		// Column "SubDomain"
		dataColumn = dataTable.Columns["SubDomain"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SubDomain = (string)(row[dataColumn]);
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
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Store</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Store";
		DataColumn dataColumn;
		// Create the "Store_ID" column
		dataColumn = dataTable.Columns.Add("Store_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "Style_ID" column
		dataColumn = dataTable.Columns.Add("Style_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "AboutUs" column
		dataColumn = dataTable.Columns.Add("AboutUs", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Keyword" column
		dataColumn = dataTable.Columns.Add("Keyword", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Logo" column
		dataColumn = dataTable.Columns.Add("Logo", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Banner" column
		dataColumn = dataTable.Columns.Add("Banner", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "BannerExt" column
		dataColumn = dataTable.Columns.Add("BannerExt", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "BannerWidth" column
		dataColumn = dataTable.Columns.Add("BannerWidth", typeof(int));
		// Create the "BannerHeight" column
		dataColumn = dataTable.Columns.Add("BannerHeight", typeof(int));
		// Create the "PageBackground" column
		dataColumn = dataTable.Columns.Add("PageBackground", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Ad_left" column
		dataColumn = dataTable.Columns.Add("Ad_left", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Ad_top" column
		dataColumn = dataTable.Columns.Add("Ad_top", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Address" column
		dataColumn = dataTable.Columns.Add("Address", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
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
		// Create the "YM2" column
		dataColumn = dataTable.Columns.Add("YM2", typeof(string));
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
		// Create the "SupportBuy" column
		dataColumn = dataTable.Columns.Add("SupportBuy", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Rank" column
		dataColumn = dataTable.Columns.Add("Rank", typeof(int));
		// Create the "StartDate" column
		dataColumn = dataTable.Columns.Add("StartDate", typeof(System.DateTime));
		// Create the "EndDate" column
		dataColumn = dataTable.Columns.Add("EndDate", typeof(System.DateTime));
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "ArticleTop" column
		dataColumn = dataTable.Columns.Add("ArticleTop", typeof(int));
		// Create the "ProductTop" column
		dataColumn = dataTable.Columns.Add("ProductTop", typeof(int));
		// Create the "Domain" column
		dataColumn = dataTable.Columns.Add("Domain", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SubDomain" column
		dataColumn = dataTable.Columns.Add("SubDomain", typeof(string));
		dataColumn.MaxLength = 50;
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
			case "Store_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Style_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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

			case "Banner":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "BannerExt":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "BannerWidth":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "BannerHeight":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "PageBackground":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Ad_left":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Ad_top":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Address":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location_ID":
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

			case "YM2":
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

			case "SupportBuy":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Rank":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "StartDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "EndDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "ArticleTop":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductTop":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Domain":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SubDomain":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="StoreRow"/> by the primary key.
	/// </summary>
	/// <param name="store_ID">The <c>Store_ID</c> column value.</param>
	/// <returns>An instance of <see cref="StoreRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int store_ID)
	{
		string LOCATION = "Exist(int store_ID)";
		IDbCommand cmd = _db.CreateCommand("Store_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Store_ID", store_ID);
		StoreRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




