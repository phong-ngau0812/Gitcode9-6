
// <fileinfo name="Base\FarmCollectionBase.cs">
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
/// The base class for <see cref="FarmCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="FarmCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FarmCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Farm_IDColumnName  = "Farm_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Zone_IDColumnName  = "Zone_ID";
	public const string Area_IDColumnName  = "Area_ID";
	public const string Workshop_IDColumnName  = "Workshop_ID";
	public const string FarmStatus_IDColumnName  = "FarmStatus_ID";
	public const string NameColumnName  = "Name";
	public const string DescriptionColumnName  = "Description";
	public const string HistoryFarmColumnName  = "HistoryFarm";
	public const string Location_IDColumnName  = "Location_ID";
	public const string AboutUsColumnName  = "AboutUs";
	public const string AddressColumnName  = "Address";
	public const string AcreageColumnName  = "Acreage";
	public const string MapColumnName  = "Map";
	public const string PhoneColumnName  = "Phone";
	public const string FaxColumnName  = "Fax";
	public const string EmailColumnName  = "Email";
	public const string ContactColumnName  = "Contact";
	public const string URLColumnName  = "URL";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string QRCodePublicContentColumnName  = "QRCodePublicContent";
	public const string IsolationDayColumnName  = "IsolationDay";
	public const string GLNColumnName  = "GLN";
	public const string District_IDColumnName  = "District_ID";
	public const string Ward_IDColumnName  = "Ward_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public FarmCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Farm";
	}

	public FarmCollectionBase() : base()
	{
		this.TABLENAME = "Farm";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Farm</c> table.
	/// </summary>
	/// <returns>An array of <see cref="FarmRow"/> objects.</returns>
	public virtual FarmRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Farm</c> table.
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
	/// to retrieve all records from the <c>Farm</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Farm_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="FarmRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="FarmRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public FarmRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			FarmRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="FarmRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="FarmRow"/> objects.</returns>
	public FarmRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="FarmRow"/> objects that 
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
	/// <returns>An array of <see cref="FarmRow"/> objects.</returns>
	public virtual FarmRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			FarmRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Farm_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Farm_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="FarmRow"/> by the primary key.
	/// </summary>
	/// <param name="farm_ID">The <c>Farm_ID</c> column value.</param>
	/// <returns>An instance of <see cref="FarmRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual FarmRow GetByPrimaryKey(int farm_ID)
	{
		string LOCATION = "GetByPrimaryKey(int farm_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Farm_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Farm_ID", farm_ID);
			FarmRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Farm</c> table.
	/// </summary>
	/// <param name="value">The <see cref="FarmRow"/> object to be inserted.</param>
	public virtual void Insert(FarmRow value)
	{
		string LOCATION = "Insert(FarmRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Farm_Insert", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
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
			
				// FarmStatus_ID
			if (value.IsFarmStatus_IDNull)
				AddParameter(cmd, "FarmStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmStatus_ID", value.FarmStatus_ID);
			
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
			
				// HistoryFarm
			if (value.IsHistoryFarmNull )
				AddParameter(cmd, "HistoryFarm", DBNull.Value);
			else
				AddParameter(cmd, "HistoryFarm", value.HistoryFarm);
			
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
			
				// Contact
			if (value.IsContactNull )
				AddParameter(cmd, "Contact", DBNull.Value);
			else
				AddParameter(cmd, "Contact", value.Contact);
			
				// URL
			if (value.IsURLNull )
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
			
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
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull )
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
			
				// IsolationDay
			if (value.IsIsolationDayNull)
				AddParameter(cmd, "IsolationDay", DBNull.Value);
			else
				AddParameter(cmd, "IsolationDay", value.IsolationDay);
			
				// GLN
			if (value.IsGLNNull )
				AddParameter(cmd, "GLN", DBNull.Value);
			else
				AddParameter(cmd, "GLN", value.GLN);
			
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
			
						value.Farm_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>Farm</c> table.
	/// </summary>
	/// <param name="value">The <see cref="FarmRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(FarmRow value)
	{	
		string LOCATION = "Update(FarmRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Farm_Update", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
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
			
				// FarmStatus_ID
			if (value.IsFarmStatus_IDNull)
				AddParameter(cmd, "FarmStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmStatus_ID", value.FarmStatus_ID);
			
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
				// HistoryFarm
			if (value.IsHistoryFarmNull)
				AddParameter(cmd, "HistoryFarm", DBNull.Value);
			else
				AddParameter(cmd, "HistoryFarm", value.HistoryFarm);
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
				// Contact
			if (value.IsContactNull)
				AddParameter(cmd, "Contact", DBNull.Value);
			else
				AddParameter(cmd, "Contact", value.Contact);
				// URL
			if (value.IsURLNull)
				AddParameter(cmd, "URL", DBNull.Value);
			else
				AddParameter(cmd, "URL", value.URL);
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
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull)
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
				// IsolationDay
			if (value.IsIsolationDayNull)
				AddParameter(cmd, "IsolationDay", DBNull.Value);
			else
				AddParameter(cmd, "IsolationDay", value.IsolationDay);
			
				// GLN
			if (value.IsGLNNull)
				AddParameter(cmd, "GLN", DBNull.Value);
			else
				AddParameter(cmd, "GLN", value.GLN);
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
			
					AddParameter(cmd, "Farm_ID", value.Farm_ID);
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
		/// Inserts or Updates a record in the <c>Farm</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="FarmRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(FarmRow value)
		{
			string LOCATION = "Save(FarmRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Farm_Save",CommandType.StoredProcedure);
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
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
				
					// FarmStatus_ID
				if (value.IsFarmStatus_IDNull)
					AddParameter(cmd, "FarmStatus_ID", DBNull.Value);
				else
					AddParameter(cmd, "FarmStatus_ID", (object)(value.FarmStatus_ID));
				
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
				
					// HistoryFarm
				if (value.IsHistoryFarmNull)
					AddParameter(cmd, "HistoryFarm", DBNull.Value);
				else
					AddParameter(cmd, "HistoryFarm", (object)(value.HistoryFarm));
				
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
				
					// Contact
				if (value.IsContactNull)
					AddParameter(cmd, "Contact", DBNull.Value);
				else
					AddParameter(cmd, "Contact", (object)(value.Contact));
				
					// URL
				if (value.IsURLNull)
					AddParameter(cmd, "URL", DBNull.Value);
				else
					AddParameter(cmd, "URL", (object)(value.URL));
				
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
				
					// QRCodePublicContent
				if (value.IsQRCodePublicContentNull)
					AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePublicContent", (object)(value.QRCodePublicContent));
				
					// IsolationDay
				if (value.IsIsolationDayNull)
					AddParameter(cmd, "IsolationDay", DBNull.Value);
				else
					AddParameter(cmd, "IsolationDay", (object)(value.IsolationDay));
				
					// GLN
				if (value.IsGLNNull)
					AddParameter(cmd, "GLN", DBNull.Value);
				else
					AddParameter(cmd, "GLN", (object)(value.GLN));
				
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
				
						AddParameter(cmd, "Farm_ID", value.Farm_ID);
						value.Farm_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Farm_ID"]);
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
	/// Deletes the specified object from the <c>Farm</c> table.
	/// </summary>
	/// <param name="value">The <see cref="FarmRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(FarmRow value)
	{
		return DeleteByPrimaryKey(value.Farm_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Farm</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="farm_ID">The <c>Farm_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int farm_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int farm_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Farm_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Farm_ID", farm_ID);
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
	/// Deletes <c>Farm</c> records that match the specified criteria.
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
	/// to delete <c>Farm</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Farm_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Farm</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Farm_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="FarmRow"/> objects.</returns>
	protected FarmRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="FarmRow"/> objects.</returns>
	protected FarmRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="FarmRow"/> objects.</returns>
	protected virtual FarmRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Farm_ID
		int farm_IDColumnIndex = reader.GetOrdinal("Farm_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Zone_ID
		int zone_IDColumnIndex = reader.GetOrdinal("Zone_ID");
		// Area_ID
		int area_IDColumnIndex = reader.GetOrdinal("Area_ID");
		// Workshop_ID
		int workshop_IDColumnIndex = reader.GetOrdinal("Workshop_ID");
		// FarmStatus_ID
		int farmStatus_IDColumnIndex = reader.GetOrdinal("FarmStatus_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// HistoryFarm
		int historyFarmColumnIndex = reader.GetOrdinal("HistoryFarm");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// AboutUs
		int aboutUsColumnIndex = reader.GetOrdinal("AboutUs");
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
		// Contact
		int contactColumnIndex = reader.GetOrdinal("Contact");
		// URL
		int urlColumnIndex = reader.GetOrdinal("URL");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// QRCodePublicContent
		int qRCodePublicContentColumnIndex = reader.GetOrdinal("QRCodePublicContent");
		// IsolationDay
		int isolationDayColumnIndex = reader.GetOrdinal("IsolationDay");
		// GLN
		int glnColumnIndex = reader.GetOrdinal("GLN");
		// District_ID
		int district_IDColumnIndex = reader.GetOrdinal("District_ID");
		// Ward_ID
		int ward_IDColumnIndex = reader.GetOrdinal("Ward_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				FarmRow record = new FarmRow();
				recordList.Add(record);

					record.Farm_ID = Convert.ToInt32(reader.GetValue(farm_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(zone_IDColumnIndex))
						record.Zone_ID = Convert.ToInt32(reader.GetValue(zone_IDColumnIndex));
					if(!reader.IsDBNull(area_IDColumnIndex))
						record.Area_ID = Convert.ToInt32(reader.GetValue(area_IDColumnIndex));
					if(!reader.IsDBNull(workshop_IDColumnIndex))
						record.Workshop_ID = Convert.ToInt32(reader.GetValue(workshop_IDColumnIndex));
					if(!reader.IsDBNull(farmStatus_IDColumnIndex))
						record.FarmStatus_ID = Convert.ToInt32(reader.GetValue(farmStatus_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(historyFarmColumnIndex))
						record.HistoryFarm = Convert.ToString(reader.GetValue(historyFarmColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(aboutUsColumnIndex))
						record.AboutUs = Convert.ToString(reader.GetValue(aboutUsColumnIndex));
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
					if(!reader.IsDBNull(contactColumnIndex))
						record.Contact = Convert.ToString(reader.GetValue(contactColumnIndex));
					if(!reader.IsDBNull(urlColumnIndex))
						record.URL = Convert.ToString(reader.GetValue(urlColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(qRCodePublicContentColumnIndex))
						record.QRCodePublicContent = Convert.ToString(reader.GetValue(qRCodePublicContentColumnIndex));
					if(!reader.IsDBNull(isolationDayColumnIndex))
						record.IsolationDay = Convert.ToInt32(reader.GetValue(isolationDayColumnIndex));
					if(!reader.IsDBNull(glnColumnIndex))
						record.GLN = Convert.ToString(reader.GetValue(glnColumnIndex));
					if(!reader.IsDBNull(district_IDColumnIndex))
						record.District_ID = Convert.ToInt32(reader.GetValue(district_IDColumnIndex));
					if(!reader.IsDBNull(ward_IDColumnIndex))
						record.Ward_ID = Convert.ToInt32(reader.GetValue(ward_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (FarmRow[])(recordList.ToArray(typeof(FarmRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="FarmRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="FarmRow"/> object.</returns>
	protected virtual FarmRow MapRow(DataRow row)
	{
		string LOCATION = "FarmRow MapRow(DataRow row)";
		FarmRow mappedObject = new FarmRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Farm_ID"
		dataColumn = dataTable.Columns["Farm_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Farm_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
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
		// Column "FarmStatus_ID"
		dataColumn = dataTable.Columns["FarmStatus_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmStatus_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "HistoryFarm"
		dataColumn = dataTable.Columns["HistoryFarm"];
		if (! row.IsNull(dataColumn) )
			mappedObject.HistoryFarm = (string)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "AboutUs"
		dataColumn = dataTable.Columns["AboutUs"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AboutUs = (string)(row[dataColumn]);
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
		// Column "Contact"
		dataColumn = dataTable.Columns["Contact"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Contact = (string)(row[dataColumn]);
		// Column "URL"
		dataColumn = dataTable.Columns["URL"];
		if (! row.IsNull(dataColumn) )
			mappedObject.URL = (string)(row[dataColumn]);
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
		// Column "QRCodePublicContent"
		dataColumn = dataTable.Columns["QRCodePublicContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePublicContent = (string)(row[dataColumn]);
		// Column "IsolationDay"
		dataColumn = dataTable.Columns["IsolationDay"];
		if (! row.IsNull(dataColumn) )
			mappedObject.IsolationDay = (int)(row[dataColumn]);
		// Column "GLN"
		dataColumn = dataTable.Columns["GLN"];
		if (! row.IsNull(dataColumn) )
			mappedObject.GLN = (string)(row[dataColumn]);
		// Column "District_ID"
		dataColumn = dataTable.Columns["District_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.District_ID = (int)(row[dataColumn]);
		// Column "Ward_ID"
		dataColumn = dataTable.Columns["Ward_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Ward_ID = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Farm</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Farm";
		DataColumn dataColumn;
		// Create the "Farm_ID" column
		dataColumn = dataTable.Columns.Add("Farm_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Zone_ID" column
		dataColumn = dataTable.Columns.Add("Zone_ID", typeof(int));
		// Create the "Area_ID" column
		dataColumn = dataTable.Columns.Add("Area_ID", typeof(int));
		// Create the "Workshop_ID" column
		dataColumn = dataTable.Columns.Add("Workshop_ID", typeof(int));
		// Create the "FarmStatus_ID" column
		dataColumn = dataTable.Columns.Add("FarmStatus_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "HistoryFarm" column
		dataColumn = dataTable.Columns.Add("HistoryFarm", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "AboutUs" column
		dataColumn = dataTable.Columns.Add("AboutUs", typeof(string));
		dataColumn.MaxLength = 1073741823;
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
		// Create the "Contact" column
		dataColumn = dataTable.Columns.Add("Contact", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "URL" column
		dataColumn = dataTable.Columns.Add("URL", typeof(string));
		dataColumn.MaxLength = 1000;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "QRCodePublicContent" column
		dataColumn = dataTable.Columns.Add("QRCodePublicContent", typeof(string));
		dataColumn.MaxLength = 64;
		// Create the "IsolationDay" column
		dataColumn = dataTable.Columns.Add("IsolationDay", typeof(int));
		// Create the "GLN" column
		dataColumn = dataTable.Columns.Add("GLN", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "District_ID" column
		dataColumn = dataTable.Columns.Add("District_ID", typeof(int));
		// Create the "Ward_ID" column
		dataColumn = dataTable.Columns.Add("Ward_ID", typeof(int));
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
			case "Farm_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
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

			case "FarmStatus_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "HistoryFarm":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "AboutUs":
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

			case "Contact":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "URL":
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

			case "QRCodePublicContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "IsolationDay":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "GLN":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "District_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Ward_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="FarmRow"/> by the primary key.
	/// </summary>
	/// <param name="farm_ID">The <c>Farm_ID</c> column value.</param>
	/// <returns>An instance of <see cref="FarmRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int farm_ID)
	{
		string LOCATION = "Exist(int farm_ID)";
		IDbCommand cmd = _db.CreateCommand("Farm_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Farm_ID", farm_ID);
		FarmRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




