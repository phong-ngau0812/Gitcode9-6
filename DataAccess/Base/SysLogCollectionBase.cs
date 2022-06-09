
// <fileinfo name="Base\SysLogCollectionBase.cs">
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
/// The base class for <see cref="SysLogCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SysLogCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SysLogCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string SysLog_IDColumnName  = "SysLog_ID";
	public const string SysLogType_IDColumnName  = "SysLogType_ID";
	public const string ContentColumnName  = "Content";
	public const string QRCodeSecretContentColumnName  = "QRCodeSecretContent";
	public const string QRCodePublicContentColumnName  = "QRCodePublicContent";
	public const string SerialNumberColumnName  = "SerialNumber";
	public const string Product_IDColumnName  = "Product_ID";
	public const string Location_IDColumnName  = "Location_ID";
	public const string DepartmentMan_IDColumnName  = "DepartmentMan_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string ProductNameColumnName  = "ProductName";
	public const string ProductBrandNameColumnName  = "ProductBrandName";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string UsedDateColumnName  = "UsedDate";
	public const string UsedApplicationColumnName  = "UsedApplication";
	public const string UsedLocationColumnName  = "UsedLocation";
	public const string UsedNameColumnName  = "UsedName";
	public const string UsedAddressColumnName  = "UsedAddress";
	public const string UsedPhoneColumnName  = "UsedPhone";
	public const string UsedIdentityCardColumnName  = "UsedIdentityCard";
	public const string StoreNameColumnName  = "StoreName";
	public const string StoreAddressColumnName  = "StoreAddress";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public SysLogCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "SysLog";
	}

	public SysLogCollectionBase() : base()
	{
		this.TABLENAME = "SysLog";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>SysLog</c> table.
	/// </summary>
	/// <returns>An array of <see cref="SysLogRow"/> objects.</returns>
	public virtual SysLogRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>SysLog</c> table.
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
	/// to retrieve all records from the <c>SysLog</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("SysLog_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="SysLogRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="SysLogRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public SysLogRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			SysLogRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="SysLogRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="SysLogRow"/> objects.</returns>
	public SysLogRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="SysLogRow"/> objects that 
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
	/// <returns>An array of <see cref="SysLogRow"/> objects.</returns>
	public virtual SysLogRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			SysLogRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("SysLog_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("SysLog_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="SysLogRow"/> by the primary key.
	/// </summary>
	/// <param name="sysLog_ID">The <c>SysLog_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SysLogRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual SysLogRow GetByPrimaryKey(System.Guid sysLog_ID)
	{
		string LOCATION = "GetByPrimaryKey(System.Guid sysLog_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("SysLog_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "SysLog_ID", sysLog_ID);
			SysLogRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>SysLog</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SysLogRow"/> object to be inserted.</param>
	public virtual void Insert(SysLogRow value)
	{
		string LOCATION = "Insert(SysLogRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SysLog_Insert", CommandType.StoredProcedure);
					// SysLog_ID
			if (value.IsSysLog_IDNull )
				AddParameter(cmd, "SysLog_ID", DBNull.Value);
			else
				AddParameter(cmd, "SysLog_ID", value.SysLog_ID);
			
				// SysLogType_ID
			if (value.IsSysLogType_IDNull)
				AddParameter(cmd, "SysLogType_ID", DBNull.Value);
			else
				AddParameter(cmd, "SysLogType_ID", value.SysLogType_ID);
			
				// Content
			if (value.IsContentNull )
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
			
				// QRCodeSecretContent
			if (value.IsQRCodeSecretContentNull )
				AddParameter(cmd, "QRCodeSecretContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeSecretContent", value.QRCodeSecretContent);
			
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull )
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
			
				// SerialNumber
			if (value.IsSerialNumberNull )
				AddParameter(cmd, "SerialNumber", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumber", value.SerialNumber);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// DepartmentMan_ID
			if (value.IsDepartmentMan_IDNull)
				AddParameter(cmd, "DepartmentMan_ID", DBNull.Value);
			else
				AddParameter(cmd, "DepartmentMan_ID", value.DepartmentMan_ID);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// ProductName
			if (value.IsProductNameNull )
				AddParameter(cmd, "ProductName", DBNull.Value);
			else
				AddParameter(cmd, "ProductName", value.ProductName);
			
				// ProductBrandName
			if (value.IsProductBrandNameNull )
				AddParameter(cmd, "ProductBrandName", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandName", value.ProductBrandName);
			
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
			
				// UsedDate
			if (value.IsUsedDateNull)
				AddParameter(cmd, "UsedDate", DBNull.Value);
			else
				AddParameter(cmd, "UsedDate", value.UsedDate);
			
				// UsedApplication
			if (value.IsUsedApplicationNull )
				AddParameter(cmd, "UsedApplication", DBNull.Value);
			else
				AddParameter(cmd, "UsedApplication", value.UsedApplication);
			
				// UsedLocation
			if (value.IsUsedLocationNull )
				AddParameter(cmd, "UsedLocation", DBNull.Value);
			else
				AddParameter(cmd, "UsedLocation", value.UsedLocation);
			
				// UsedName
			if (value.IsUsedNameNull )
				AddParameter(cmd, "UsedName", DBNull.Value);
			else
				AddParameter(cmd, "UsedName", value.UsedName);
			
				// UsedAddress
			if (value.IsUsedAddressNull )
				AddParameter(cmd, "UsedAddress", DBNull.Value);
			else
				AddParameter(cmd, "UsedAddress", value.UsedAddress);
			
				// UsedPhone
			if (value.IsUsedPhoneNull )
				AddParameter(cmd, "UsedPhone", DBNull.Value);
			else
				AddParameter(cmd, "UsedPhone", value.UsedPhone);
			
				// UsedIdentityCard
			if (value.IsUsedIdentityCardNull )
				AddParameter(cmd, "UsedIdentityCard", DBNull.Value);
			else
				AddParameter(cmd, "UsedIdentityCard", value.UsedIdentityCard);
			
				// StoreName
			if (value.IsStoreNameNull )
				AddParameter(cmd, "StoreName", DBNull.Value);
			else
				AddParameter(cmd, "StoreName", value.StoreName);
			
				// StoreAddress
			if (value.IsStoreAddressNull )
				AddParameter(cmd, "StoreAddress", DBNull.Value);
			else
				AddParameter(cmd, "StoreAddress", value.StoreAddress);
			
					cmd.ExecuteNonQuery();
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
	/// Updates a record in the <c>SysLog</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SysLogRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(SysLogRow value)
	{	
		string LOCATION = "Update(SysLogRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SysLog_Update", CommandType.StoredProcedure);
					// SysLogType_ID
			if (value.IsSysLogType_IDNull)
				AddParameter(cmd, "SysLogType_ID", DBNull.Value);
			else
				AddParameter(cmd, "SysLogType_ID", value.SysLogType_ID);
			
				// Content
			if (value.IsContentNull)
				AddParameter(cmd, "Content", DBNull.Value);
			else
				AddParameter(cmd, "Content", value.Content);
				// QRCodeSecretContent
			if (value.IsQRCodeSecretContentNull)
				AddParameter(cmd, "QRCodeSecretContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeSecretContent", value.QRCodeSecretContent);
				// QRCodePublicContent
			if (value.IsQRCodePublicContentNull)
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
				// SerialNumber
			if (value.IsSerialNumberNull)
				AddParameter(cmd, "SerialNumber", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumber", value.SerialNumber);
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// Location_ID
			if (value.IsLocation_IDNull)
				AddParameter(cmd, "Location_ID", DBNull.Value);
			else
				AddParameter(cmd, "Location_ID", value.Location_ID);
			
				// DepartmentMan_ID
			if (value.IsDepartmentMan_IDNull)
				AddParameter(cmd, "DepartmentMan_ID", DBNull.Value);
			else
				AddParameter(cmd, "DepartmentMan_ID", value.DepartmentMan_ID);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// ProductName
			if (value.IsProductNameNull)
				AddParameter(cmd, "ProductName", DBNull.Value);
			else
				AddParameter(cmd, "ProductName", value.ProductName);
				// ProductBrandName
			if (value.IsProductBrandNameNull)
				AddParameter(cmd, "ProductBrandName", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrandName", value.ProductBrandName);
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
			
				// UsedDate
			if (value.IsUsedDateNull)
				AddParameter(cmd, "UsedDate", DBNull.Value);
			else
				AddParameter(cmd, "UsedDate", value.UsedDate);
			
				// UsedApplication
			if (value.IsUsedApplicationNull)
				AddParameter(cmd, "UsedApplication", DBNull.Value);
			else
				AddParameter(cmd, "UsedApplication", value.UsedApplication);
				// UsedLocation
			if (value.IsUsedLocationNull)
				AddParameter(cmd, "UsedLocation", DBNull.Value);
			else
				AddParameter(cmd, "UsedLocation", value.UsedLocation);
				// UsedName
			if (value.IsUsedNameNull)
				AddParameter(cmd, "UsedName", DBNull.Value);
			else
				AddParameter(cmd, "UsedName", value.UsedName);
				// UsedAddress
			if (value.IsUsedAddressNull)
				AddParameter(cmd, "UsedAddress", DBNull.Value);
			else
				AddParameter(cmd, "UsedAddress", value.UsedAddress);
				// UsedPhone
			if (value.IsUsedPhoneNull)
				AddParameter(cmd, "UsedPhone", DBNull.Value);
			else
				AddParameter(cmd, "UsedPhone", value.UsedPhone);
				// UsedIdentityCard
			if (value.IsUsedIdentityCardNull)
				AddParameter(cmd, "UsedIdentityCard", DBNull.Value);
			else
				AddParameter(cmd, "UsedIdentityCard", value.UsedIdentityCard);
				// StoreName
			if (value.IsStoreNameNull)
				AddParameter(cmd, "StoreName", DBNull.Value);
			else
				AddParameter(cmd, "StoreName", value.StoreName);
				// StoreAddress
			if (value.IsStoreAddressNull)
				AddParameter(cmd, "StoreAddress", DBNull.Value);
			else
				AddParameter(cmd, "StoreAddress", value.StoreAddress);
					AddParameter(cmd, "SysLog_ID", value.SysLog_ID);
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
		/// Inserts or Updates a record in the <c>SysLog</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="SysLogRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(SysLogRow value)
		{
			string LOCATION = "Save(SysLogRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("SysLog_Save",CommandType.StoredProcedure);
					// SysLogType_ID
				if (value.IsSysLogType_IDNull)
					AddParameter(cmd, "SysLogType_ID", DBNull.Value);
				else
					AddParameter(cmd, "SysLogType_ID", (object)(value.SysLogType_ID));
				
					// Content
				if (value.IsContentNull)
					AddParameter(cmd, "Content", DBNull.Value);
				else
					AddParameter(cmd, "Content", (object)(value.Content));
				
					// QRCodeSecretContent
				if (value.IsQRCodeSecretContentNull)
					AddParameter(cmd, "QRCodeSecretContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeSecretContent", (object)(value.QRCodeSecretContent));
				
					// QRCodePublicContent
				if (value.IsQRCodePublicContentNull)
					AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePublicContent", (object)(value.QRCodePublicContent));
				
					// SerialNumber
				if (value.IsSerialNumberNull)
					AddParameter(cmd, "SerialNumber", DBNull.Value);
				else
					AddParameter(cmd, "SerialNumber", (object)(value.SerialNumber));
				
					// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
				
					// Location_ID
				if (value.IsLocation_IDNull)
					AddParameter(cmd, "Location_ID", DBNull.Value);
				else
					AddParameter(cmd, "Location_ID", (object)(value.Location_ID));
				
					// DepartmentMan_ID
				if (value.IsDepartmentMan_IDNull)
					AddParameter(cmd, "DepartmentMan_ID", DBNull.Value);
				else
					AddParameter(cmd, "DepartmentMan_ID", (object)(value.DepartmentMan_ID));
				
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// ProductName
				if (value.IsProductNameNull)
					AddParameter(cmd, "ProductName", DBNull.Value);
				else
					AddParameter(cmd, "ProductName", (object)(value.ProductName));
				
					// ProductBrandName
				if (value.IsProductBrandNameNull)
					AddParameter(cmd, "ProductBrandName", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrandName", (object)(value.ProductBrandName));
				
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
				
					// UsedDate
				if (value.IsUsedDateNull)
					AddParameter(cmd, "UsedDate", DBNull.Value);
				else
					AddParameter(cmd, "UsedDate", (object)(value.UsedDate));
				
					// UsedApplication
				if (value.IsUsedApplicationNull)
					AddParameter(cmd, "UsedApplication", DBNull.Value);
				else
					AddParameter(cmd, "UsedApplication", (object)(value.UsedApplication));
				
					// UsedLocation
				if (value.IsUsedLocationNull)
					AddParameter(cmd, "UsedLocation", DBNull.Value);
				else
					AddParameter(cmd, "UsedLocation", (object)(value.UsedLocation));
				
					// UsedName
				if (value.IsUsedNameNull)
					AddParameter(cmd, "UsedName", DBNull.Value);
				else
					AddParameter(cmd, "UsedName", (object)(value.UsedName));
				
					// UsedAddress
				if (value.IsUsedAddressNull)
					AddParameter(cmd, "UsedAddress", DBNull.Value);
				else
					AddParameter(cmd, "UsedAddress", (object)(value.UsedAddress));
				
					// UsedPhone
				if (value.IsUsedPhoneNull)
					AddParameter(cmd, "UsedPhone", DBNull.Value);
				else
					AddParameter(cmd, "UsedPhone", (object)(value.UsedPhone));
				
					// UsedIdentityCard
				if (value.IsUsedIdentityCardNull)
					AddParameter(cmd, "UsedIdentityCard", DBNull.Value);
				else
					AddParameter(cmd, "UsedIdentityCard", (object)(value.UsedIdentityCard));
				
					// StoreName
				if (value.IsStoreNameNull)
					AddParameter(cmd, "StoreName", DBNull.Value);
				else
					AddParameter(cmd, "StoreName", (object)(value.StoreName));
				
					// StoreAddress
				if (value.IsStoreAddressNull)
					AddParameter(cmd, "StoreAddress", DBNull.Value);
				else
					AddParameter(cmd, "StoreAddress", (object)(value.StoreAddress));
				
						AddParameter(cmd, "SysLog_ID", value.SysLog_ID);
						cmd.ExecuteNonQuery();
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
							DeleteByPrimaryKey((System.Guid)row["SysLog_ID"]);
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
	/// Deletes the specified object from the <c>SysLog</c> table.
	/// </summary>
	/// <param name="value">The <see cref="SysLogRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(SysLogRow value)
	{
		return DeleteByPrimaryKey(value.SysLog_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>SysLog</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="sysLog_ID">The <c>SysLog_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(System.Guid sysLog_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(System.Guid sysLog_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("SysLog_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "SysLog_ID", sysLog_ID);
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
	/// Deletes <c>SysLog</c> records that match the specified criteria.
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
	/// to delete <c>SysLog</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("SysLog_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>SysLog</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("SysLog_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="SysLogRow"/> objects.</returns>
	protected SysLogRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="SysLogRow"/> objects.</returns>
	protected SysLogRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="SysLogRow"/> objects.</returns>
	protected virtual SysLogRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// SysLog_ID
		int sysLog_IDColumnIndex = reader.GetOrdinal("SysLog_ID");
		// SysLogType_ID
		int sysLogType_IDColumnIndex = reader.GetOrdinal("SysLogType_ID");
		// Content
		int contentColumnIndex = reader.GetOrdinal("Content");
		// QRCodeSecretContent
		int qRCodeSecretContentColumnIndex = reader.GetOrdinal("QRCodeSecretContent");
		// QRCodePublicContent
		int qRCodePublicContentColumnIndex = reader.GetOrdinal("QRCodePublicContent");
		// SerialNumber
		int serialNumberColumnIndex = reader.GetOrdinal("SerialNumber");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// Location_ID
		int location_IDColumnIndex = reader.GetOrdinal("Location_ID");
		// DepartmentMan_ID
		int departmentMan_IDColumnIndex = reader.GetOrdinal("DepartmentMan_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// ProductName
		int productNameColumnIndex = reader.GetOrdinal("ProductName");
		// ProductBrandName
		int productBrandNameColumnIndex = reader.GetOrdinal("ProductBrandName");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// UsedDate
		int usedDateColumnIndex = reader.GetOrdinal("UsedDate");
		// UsedApplication
		int usedApplicationColumnIndex = reader.GetOrdinal("UsedApplication");
		// UsedLocation
		int usedLocationColumnIndex = reader.GetOrdinal("UsedLocation");
		// UsedName
		int usedNameColumnIndex = reader.GetOrdinal("UsedName");
		// UsedAddress
		int usedAddressColumnIndex = reader.GetOrdinal("UsedAddress");
		// UsedPhone
		int usedPhoneColumnIndex = reader.GetOrdinal("UsedPhone");
		// UsedIdentityCard
		int usedIdentityCardColumnIndex = reader.GetOrdinal("UsedIdentityCard");
		// StoreName
		int storeNameColumnIndex = reader.GetOrdinal("StoreName");
		// StoreAddress
		int storeAddressColumnIndex = reader.GetOrdinal("StoreAddress");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				SysLogRow record = new SysLogRow();
				recordList.Add(record);

					record.SysLog_ID = reader.GetGuid(sysLog_IDColumnIndex);
					if(!reader.IsDBNull(sysLogType_IDColumnIndex))
						record.SysLogType_ID = Convert.ToInt32(reader.GetValue(sysLogType_IDColumnIndex));
					if(!reader.IsDBNull(contentColumnIndex))
						record.Content = Convert.ToString(reader.GetValue(contentColumnIndex));
					if(!reader.IsDBNull(qRCodeSecretContentColumnIndex))
						record.QRCodeSecretContent = Convert.ToString(reader.GetValue(qRCodeSecretContentColumnIndex));
					if(!reader.IsDBNull(qRCodePublicContentColumnIndex))
						record.QRCodePublicContent = Convert.ToString(reader.GetValue(qRCodePublicContentColumnIndex));
					if(!reader.IsDBNull(serialNumberColumnIndex))
						record.SerialNumber = Convert.ToString(reader.GetValue(serialNumberColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(location_IDColumnIndex))
						record.Location_ID = Convert.ToInt32(reader.GetValue(location_IDColumnIndex));
					if(!reader.IsDBNull(departmentMan_IDColumnIndex))
						record.DepartmentMan_ID = Convert.ToInt32(reader.GetValue(departmentMan_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(productNameColumnIndex))
						record.ProductName = Convert.ToString(reader.GetValue(productNameColumnIndex));
					if(!reader.IsDBNull(productBrandNameColumnIndex))
						record.ProductBrandName = Convert.ToString(reader.GetValue(productBrandNameColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(usedDateColumnIndex))
						record.UsedDate = Convert.ToDateTime(reader.GetValue(usedDateColumnIndex));
					if(!reader.IsDBNull(usedApplicationColumnIndex))
						record.UsedApplication = Convert.ToString(reader.GetValue(usedApplicationColumnIndex));
					if(!reader.IsDBNull(usedLocationColumnIndex))
						record.UsedLocation = Convert.ToString(reader.GetValue(usedLocationColumnIndex));
					if(!reader.IsDBNull(usedNameColumnIndex))
						record.UsedName = Convert.ToString(reader.GetValue(usedNameColumnIndex));
					if(!reader.IsDBNull(usedAddressColumnIndex))
						record.UsedAddress = Convert.ToString(reader.GetValue(usedAddressColumnIndex));
					if(!reader.IsDBNull(usedPhoneColumnIndex))
						record.UsedPhone = Convert.ToString(reader.GetValue(usedPhoneColumnIndex));
					if(!reader.IsDBNull(usedIdentityCardColumnIndex))
						record.UsedIdentityCard = Convert.ToString(reader.GetValue(usedIdentityCardColumnIndex));
					if(!reader.IsDBNull(storeNameColumnIndex))
						record.StoreName = Convert.ToString(reader.GetValue(storeNameColumnIndex));
					if(!reader.IsDBNull(storeAddressColumnIndex))
						record.StoreAddress = Convert.ToString(reader.GetValue(storeAddressColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (SysLogRow[])(recordList.ToArray(typeof(SysLogRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="SysLogRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="SysLogRow"/> object.</returns>
	protected virtual SysLogRow MapRow(DataRow row)
	{
		string LOCATION = "SysLogRow MapRow(DataRow row)";
		SysLogRow mappedObject = new SysLogRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "SysLog_ID"
		dataColumn = dataTable.Columns["SysLog_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SysLog_ID = (System.Guid)(row[dataColumn]);
		// Column "SysLogType_ID"
		dataColumn = dataTable.Columns["SysLogType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SysLogType_ID = (int)(row[dataColumn]);
		// Column "Content"
		dataColumn = dataTable.Columns["Content"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Content = (string)(row[dataColumn]);
		// Column "QRCodeSecretContent"
		dataColumn = dataTable.Columns["QRCodeSecretContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeSecretContent = (string)(row[dataColumn]);
		// Column "QRCodePublicContent"
		dataColumn = dataTable.Columns["QRCodePublicContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePublicContent = (string)(row[dataColumn]);
		// Column "SerialNumber"
		dataColumn = dataTable.Columns["SerialNumber"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SerialNumber = (string)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "Location_ID"
		dataColumn = dataTable.Columns["Location_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location_ID = (int)(row[dataColumn]);
		// Column "DepartmentMan_ID"
		dataColumn = dataTable.Columns["DepartmentMan_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DepartmentMan_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "ProductName"
		dataColumn = dataTable.Columns["ProductName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductName = (string)(row[dataColumn]);
		// Column "ProductBrandName"
		dataColumn = dataTable.Columns["ProductBrandName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrandName = (string)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "UsedDate"
		dataColumn = dataTable.Columns["UsedDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedDate = (System.DateTime)(row[dataColumn]);
		// Column "UsedApplication"
		dataColumn = dataTable.Columns["UsedApplication"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedApplication = (string)(row[dataColumn]);
		// Column "UsedLocation"
		dataColumn = dataTable.Columns["UsedLocation"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedLocation = (string)(row[dataColumn]);
		// Column "UsedName"
		dataColumn = dataTable.Columns["UsedName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedName = (string)(row[dataColumn]);
		// Column "UsedAddress"
		dataColumn = dataTable.Columns["UsedAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedAddress = (string)(row[dataColumn]);
		// Column "UsedPhone"
		dataColumn = dataTable.Columns["UsedPhone"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedPhone = (string)(row[dataColumn]);
		// Column "UsedIdentityCard"
		dataColumn = dataTable.Columns["UsedIdentityCard"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UsedIdentityCard = (string)(row[dataColumn]);
		// Column "StoreName"
		dataColumn = dataTable.Columns["StoreName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreName = (string)(row[dataColumn]);
		// Column "StoreAddress"
		dataColumn = dataTable.Columns["StoreAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreAddress = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>SysLog</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "SysLog";
		DataColumn dataColumn;
		// Create the "SysLog_ID" column
		dataColumn = dataTable.Columns.Add("SysLog_ID", typeof(System.Guid));
		dataColumn.AllowDBNull = false;
		// Create the "SysLogType_ID" column
		dataColumn = dataTable.Columns.Add("SysLogType_ID", typeof(int));
		// Create the "Content" column
		dataColumn = dataTable.Columns.Add("Content", typeof(string));
		dataColumn.MaxLength = 2000;
		// Create the "QRCodeSecretContent" column
		dataColumn = dataTable.Columns.Add("QRCodeSecretContent", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "QRCodePublicContent" column
		dataColumn = dataTable.Columns.Add("QRCodePublicContent", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "SerialNumber" column
		dataColumn = dataTable.Columns.Add("SerialNumber", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "Location_ID" column
		dataColumn = dataTable.Columns.Add("Location_ID", typeof(int));
		// Create the "DepartmentMan_ID" column
		dataColumn = dataTable.Columns.Add("DepartmentMan_ID", typeof(int));
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "ProductName" column
		dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductBrandName" column
		dataColumn = dataTable.Columns.Add("ProductBrandName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "UsedDate" column
		dataColumn = dataTable.Columns.Add("UsedDate", typeof(System.DateTime));
		// Create the "UsedApplication" column
		dataColumn = dataTable.Columns.Add("UsedApplication", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "UsedLocation" column
		dataColumn = dataTable.Columns.Add("UsedLocation", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "UsedName" column
		dataColumn = dataTable.Columns.Add("UsedName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "UsedAddress" column
		dataColumn = dataTable.Columns.Add("UsedAddress", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "UsedPhone" column
		dataColumn = dataTable.Columns.Add("UsedPhone", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "UsedIdentityCard" column
		dataColumn = dataTable.Columns.Add("UsedIdentityCard", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "StoreName" column
		dataColumn = dataTable.Columns.Add("StoreName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "StoreAddress" column
		dataColumn = dataTable.Columns.Add("StoreAddress", typeof(string));
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
			case "SysLog_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "SysLogType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Content":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodeSecretContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodePublicContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SerialNumber":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Location_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "DepartmentMan_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductBrandName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "UsedDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "UsedApplication":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedLocation":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedPhone":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedIdentityCard":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StoreName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StoreAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="SysLogRow"/> by the primary key.
	/// </summary>
	/// <param name="sysLog_ID">The <c>SysLog_ID</c> column value.</param>
	/// <returns>An instance of <see cref="SysLogRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(System.Guid sysLog_ID)
	{
		string LOCATION = "Exist(System.Guid sysLog_ID)";
		IDbCommand cmd = _db.CreateCommand("SysLog_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "SysLog_ID", sysLog_ID);
		SysLogRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




