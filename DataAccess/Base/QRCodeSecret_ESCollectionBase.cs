
// <fileinfo name="Base\QRCodeSecret_ESCollectionBase.cs">
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
/// The base class for <see cref="QRCodeSecret_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeSecret_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeSecret_ESCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string QRCodeSecretContentColumnName  = "QRCodeSecretContent";
	public const string QRCodePublicContentColumnName  = "QRCodePublicContent";
	public const string SMSContentColumnName  = "SMSContent";
	public const string SerialNumberColumnName  = "SerialNumber";
	public const string QRCodePackage_IDColumnName  = "QRCodePackage_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string SoundEnableColumnName  = "SoundEnable";
	public const string QRCodeStatus_IDColumnName  = "QRCodeStatus_ID";
	public const string LocationRegisterColumnName  = "LocationRegister";
	public const string LocationFailedWarningColumnName  = "LocationFailedWarning";
	public const string LocationFailedColumnName  = "LocationFailed";
	public const string CreateDateColumnName  = "CreateDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string ActiveDateColumnName  = "ActiveDate";
	public const string WarrantySerialColumnName  = "WarrantySerial";
	public const string WarrantyMonthColumnName  = "WarrantyMonth";
	public const string WarrantyStartDateColumnName  = "WarrantyStartDate";
	public const string WarrantyEndDateColumnName  = "WarrantyEndDate";
	public const string UsedDateColumnName  = "UsedDate";
	public const string UsedApplicationColumnName  = "UsedApplication";
	public const string UsedLocationColumnName  = "UsedLocation";
	public const string UsedNameColumnName  = "UsedName";
	public const string UsedAddressColumnName  = "UsedAddress";
	public const string UsedPhoneColumnName  = "UsedPhone";
	public const string UsedIdentityCardColumnName  = "UsedIdentityCard";
	public const string StoreNameColumnName  = "StoreName";
	public const string StoreAddressColumnName  = "StoreAddress";
	public const string Workshop_IDColumnName  = "Workshop_ID";
	public const string ProductItemNumberColumnName  = "ProductItemNumber";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public QRCodeSecret_ESCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "QRCodeSecret_ES";
	}

	public QRCodeSecret_ESCollectionBase() : base()
	{
		this.TABLENAME = "QRCodeSecret_ES";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <returns>An array of <see cref="QRCodeSecret_ESRow"/> objects.</returns>
	public virtual QRCodeSecret_ESRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>QRCodeSecret_ES</c> table.
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
	/// to retrieve all records from the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("QRCodeSecret_ES_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="QRCodeSecret_ESRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="QRCodeSecret_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public QRCodeSecret_ESRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			QRCodeSecret_ESRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="QRCodeSecret_ESRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="QRCodeSecret_ESRow"/> objects.</returns>
	public QRCodeSecret_ESRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="QRCodeSecret_ESRow"/> objects that 
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
	/// <returns>An array of <see cref="QRCodeSecret_ESRow"/> objects.</returns>
	public virtual QRCodeSecret_ESRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			QRCodeSecret_ESRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="QRCodeSecret_ESRow"/> by the primary key.
	/// </summary>
	/// <param name="qRCodeSecretContent">The <c>QRCodeSecretContent</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodeSecret_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual QRCodeSecret_ESRow GetByPrimaryKey(string qRCodeSecretContent)
	{
		string LOCATION = "GetByPrimaryKey(string qRCodeSecretContent)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "QRCodeSecretContent", qRCodeSecretContent);
			QRCodeSecret_ESRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeSecret_ESRow"/> object to be inserted.</param>
	public virtual void Insert(QRCodeSecret_ESRow value)
	{
		string LOCATION = "Insert(QRCodeSecret_ESRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_Insert", CommandType.StoredProcedure);
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
			
				// SMSContent
			if (value.IsSMSContentNull )
				AddParameter(cmd, "SMSContent", DBNull.Value);
			else
				AddParameter(cmd, "SMSContent", value.SMSContent);
			
				// SerialNumber
			if (value.IsSerialNumberNull )
				AddParameter(cmd, "SerialNumber", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumber", value.SerialNumber);
			
				// QRCodePackage_ID
			if (value.IsQRCodePackage_IDNull)
				AddParameter(cmd, "QRCodePackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePackage_ID", value.QRCodePackage_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// SoundEnable
			if (value.IsSoundEnableNull)
				AddParameter(cmd, "SoundEnable", DBNull.Value);
			else
				AddParameter(cmd, "SoundEnable", value.SoundEnable);
			
				// QRCodeStatus_ID
			if (value.IsQRCodeStatus_IDNull)
				AddParameter(cmd, "QRCodeStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeStatus_ID", value.QRCodeStatus_ID);
			
				// LocationRegister
			if (value.IsLocationRegisterNull )
				AddParameter(cmd, "LocationRegister", DBNull.Value);
			else
				AddParameter(cmd, "LocationRegister", value.LocationRegister);
			
				// LocationFailedWarning
			if (value.IsLocationFailedWarningNull)
				AddParameter(cmd, "LocationFailedWarning", DBNull.Value);
			else
				AddParameter(cmd, "LocationFailedWarning", value.LocationFailedWarning);
			
				// LocationFailed
			if (value.IsLocationFailedNull)
				AddParameter(cmd, "LocationFailed", DBNull.Value);
			else
				AddParameter(cmd, "LocationFailed", value.LocationFailed);
			
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
			
				// ActiveDate
			if (value.IsActiveDateNull)
				AddParameter(cmd, "ActiveDate", DBNull.Value);
			else
				AddParameter(cmd, "ActiveDate", value.ActiveDate);
			
				// WarrantySerial
			if (value.IsWarrantySerialNull )
				AddParameter(cmd, "WarrantySerial", DBNull.Value);
			else
				AddParameter(cmd, "WarrantySerial", value.WarrantySerial);
			
				// WarrantyMonth
			if (value.IsWarrantyMonthNull)
				AddParameter(cmd, "WarrantyMonth", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyMonth", value.WarrantyMonth);
			
				// WarrantyStartDate
			if (value.IsWarrantyStartDateNull)
				AddParameter(cmd, "WarrantyStartDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyStartDate", value.WarrantyStartDate);
			
				// WarrantyEndDate
			if (value.IsWarrantyEndDateNull)
				AddParameter(cmd, "WarrantyEndDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyEndDate", value.WarrantyEndDate);
			
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
			
				// Workshop_ID
			if (value.IsWorkshop_IDNull)
				AddParameter(cmd, "Workshop_ID", DBNull.Value);
			else
				AddParameter(cmd, "Workshop_ID", value.Workshop_ID);
			
				// ProductItemNumber
			if (value.IsProductItemNumberNull)
				AddParameter(cmd, "ProductItemNumber", DBNull.Value);
			else
				AddParameter(cmd, "ProductItemNumber", value.ProductItemNumber);
			
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
	/// Updates a record in the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeSecret_ESRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(QRCodeSecret_ESRow value)
	{	
		string LOCATION = "Update(QRCodeSecret_ESRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_Update", CommandType.StoredProcedure);
					// QRCodePublicContent
			if (value.IsQRCodePublicContentNull)
				AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePublicContent", value.QRCodePublicContent);
				// SMSContent
			if (value.IsSMSContentNull)
				AddParameter(cmd, "SMSContent", DBNull.Value);
			else
				AddParameter(cmd, "SMSContent", value.SMSContent);
				// SerialNumber
			if (value.IsSerialNumberNull)
				AddParameter(cmd, "SerialNumber", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumber", value.SerialNumber);
				// QRCodePackage_ID
			if (value.IsQRCodePackage_IDNull)
				AddParameter(cmd, "QRCodePackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodePackage_ID", value.QRCodePackage_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// SoundEnable
			if (value.IsSoundEnableNull)
				AddParameter(cmd, "SoundEnable", DBNull.Value);
			else
				AddParameter(cmd, "SoundEnable", value.SoundEnable);
			
				// QRCodeStatus_ID
			if (value.IsQRCodeStatus_IDNull)
				AddParameter(cmd, "QRCodeStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeStatus_ID", value.QRCodeStatus_ID);
			
				// LocationRegister
			if (value.IsLocationRegisterNull)
				AddParameter(cmd, "LocationRegister", DBNull.Value);
			else
				AddParameter(cmd, "LocationRegister", value.LocationRegister);
				// LocationFailedWarning
			if (value.IsLocationFailedWarningNull)
				AddParameter(cmd, "LocationFailedWarning", DBNull.Value);
			else
				AddParameter(cmd, "LocationFailedWarning", value.LocationFailedWarning);
			
				// LocationFailed
			if (value.IsLocationFailedNull)
				AddParameter(cmd, "LocationFailed", DBNull.Value);
			else
				AddParameter(cmd, "LocationFailed", value.LocationFailed);
			
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
			
				// ActiveDate
			if (value.IsActiveDateNull)
				AddParameter(cmd, "ActiveDate", DBNull.Value);
			else
				AddParameter(cmd, "ActiveDate", value.ActiveDate);
			
				// WarrantySerial
			if (value.IsWarrantySerialNull)
				AddParameter(cmd, "WarrantySerial", DBNull.Value);
			else
				AddParameter(cmd, "WarrantySerial", value.WarrantySerial);
				// WarrantyMonth
			if (value.IsWarrantyMonthNull)
				AddParameter(cmd, "WarrantyMonth", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyMonth", value.WarrantyMonth);
			
				// WarrantyStartDate
			if (value.IsWarrantyStartDateNull)
				AddParameter(cmd, "WarrantyStartDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyStartDate", value.WarrantyStartDate);
			
				// WarrantyEndDate
			if (value.IsWarrantyEndDateNull)
				AddParameter(cmd, "WarrantyEndDate", DBNull.Value);
			else
				AddParameter(cmd, "WarrantyEndDate", value.WarrantyEndDate);
			
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
				// Workshop_ID
			if (value.IsWorkshop_IDNull)
				AddParameter(cmd, "Workshop_ID", DBNull.Value);
			else
				AddParameter(cmd, "Workshop_ID", value.Workshop_ID);
			
				// ProductItemNumber
			if (value.IsProductItemNumberNull)
				AddParameter(cmd, "ProductItemNumber", DBNull.Value);
			else
				AddParameter(cmd, "ProductItemNumber", value.ProductItemNumber);
			
					AddParameter(cmd, "QRCodeSecretContent", value.QRCodeSecretContent);
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
		/// Inserts or Updates a record in the <c>QRCodeSecret_ES</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="QRCodeSecret_ESRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(QRCodeSecret_ESRow value)
		{
			string LOCATION = "Save(QRCodeSecret_ESRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("QRCodeSecret_ES_Save",CommandType.StoredProcedure);
					// QRCodePublicContent
				if (value.IsQRCodePublicContentNull)
					AddParameter(cmd, "QRCodePublicContent", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePublicContent", (object)(value.QRCodePublicContent));
				
					// SMSContent
				if (value.IsSMSContentNull)
					AddParameter(cmd, "SMSContent", DBNull.Value);
				else
					AddParameter(cmd, "SMSContent", (object)(value.SMSContent));
				
					// SerialNumber
				if (value.IsSerialNumberNull)
					AddParameter(cmd, "SerialNumber", DBNull.Value);
				else
					AddParameter(cmd, "SerialNumber", (object)(value.SerialNumber));
				
					// QRCodePackage_ID
				if (value.IsQRCodePackage_IDNull)
					AddParameter(cmd, "QRCodePackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "QRCodePackage_ID", (object)(value.QRCodePackage_ID));
				
					// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
				
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// SoundEnable
				if (value.IsSoundEnableNull)
					AddParameter(cmd, "SoundEnable", DBNull.Value);
				else
					AddParameter(cmd, "SoundEnable", (object)(value.SoundEnable));
				
					// QRCodeStatus_ID
				if (value.IsQRCodeStatus_IDNull)
					AddParameter(cmd, "QRCodeStatus_ID", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeStatus_ID", (object)(value.QRCodeStatus_ID));
				
					// LocationRegister
				if (value.IsLocationRegisterNull)
					AddParameter(cmd, "LocationRegister", DBNull.Value);
				else
					AddParameter(cmd, "LocationRegister", (object)(value.LocationRegister));
				
					// LocationFailedWarning
				if (value.IsLocationFailedWarningNull)
					AddParameter(cmd, "LocationFailedWarning", DBNull.Value);
				else
					AddParameter(cmd, "LocationFailedWarning", (object)(value.LocationFailedWarning));
				
					// LocationFailed
				if (value.IsLocationFailedNull)
					AddParameter(cmd, "LocationFailed", DBNull.Value);
				else
					AddParameter(cmd, "LocationFailed", (object)(value.LocationFailed));
				
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
				
					// ActiveDate
				if (value.IsActiveDateNull)
					AddParameter(cmd, "ActiveDate", DBNull.Value);
				else
					AddParameter(cmd, "ActiveDate", (object)(value.ActiveDate));
				
					// WarrantySerial
				if (value.IsWarrantySerialNull)
					AddParameter(cmd, "WarrantySerial", DBNull.Value);
				else
					AddParameter(cmd, "WarrantySerial", (object)(value.WarrantySerial));
				
					// WarrantyMonth
				if (value.IsWarrantyMonthNull)
					AddParameter(cmd, "WarrantyMonth", DBNull.Value);
				else
					AddParameter(cmd, "WarrantyMonth", (object)(value.WarrantyMonth));
				
					// WarrantyStartDate
				if (value.IsWarrantyStartDateNull)
					AddParameter(cmd, "WarrantyStartDate", DBNull.Value);
				else
					AddParameter(cmd, "WarrantyStartDate", (object)(value.WarrantyStartDate));
				
					// WarrantyEndDate
				if (value.IsWarrantyEndDateNull)
					AddParameter(cmd, "WarrantyEndDate", DBNull.Value);
				else
					AddParameter(cmd, "WarrantyEndDate", (object)(value.WarrantyEndDate));
				
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
				
					// Workshop_ID
				if (value.IsWorkshop_IDNull)
					AddParameter(cmd, "Workshop_ID", DBNull.Value);
				else
					AddParameter(cmd, "Workshop_ID", (object)(value.Workshop_ID));
				
					// ProductItemNumber
				if (value.IsProductItemNumberNull)
					AddParameter(cmd, "ProductItemNumber", DBNull.Value);
				else
					AddParameter(cmd, "ProductItemNumber", (object)(value.ProductItemNumber));
				
						AddParameter(cmd, "QRCodeSecretContent", value.QRCodeSecretContent);
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
							DeleteByPrimaryKey((string)row["QRCodeSecretContent"]);
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
	/// Deletes the specified object from the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeSecret_ESRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(QRCodeSecret_ESRow value)
	{
		return DeleteByPrimaryKey(value.QRCodeSecretContent);
	}

	/// <summary>
	/// Deletes a record from the <c>QRCodeSecret_ES</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="qRCodeSecretContent">The <c>QRCodeSecretContent</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(string qRCodeSecretContent)
	{
		string LOCATION = "DeleteByPrimaryKey(string qRCodeSecretContent)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "QRCodeSecretContent", qRCodeSecretContent);
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
	/// Deletes <c>QRCodeSecret_ES</c> records that match the specified criteria.
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
	/// to delete <c>QRCodeSecret_ES</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("QRCodeSecret_ES_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="QRCodeSecret_ESRow"/> objects.</returns>
	protected QRCodeSecret_ESRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="QRCodeSecret_ESRow"/> objects.</returns>
	protected QRCodeSecret_ESRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="QRCodeSecret_ESRow"/> objects.</returns>
	protected virtual QRCodeSecret_ESRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// QRCodeSecretContent
		int qRCodeSecretContentColumnIndex = reader.GetOrdinal("QRCodeSecretContent");
		// QRCodePublicContent
		int qRCodePublicContentColumnIndex = reader.GetOrdinal("QRCodePublicContent");
		// SMSContent
		int sMSContentColumnIndex = reader.GetOrdinal("SMSContent");
		// SerialNumber
		int serialNumberColumnIndex = reader.GetOrdinal("SerialNumber");
		// QRCodePackage_ID
		int qRCodePackage_IDColumnIndex = reader.GetOrdinal("QRCodePackage_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// SoundEnable
		int soundEnableColumnIndex = reader.GetOrdinal("SoundEnable");
		// QRCodeStatus_ID
		int qRCodeStatus_IDColumnIndex = reader.GetOrdinal("QRCodeStatus_ID");
		// LocationRegister
		int locationRegisterColumnIndex = reader.GetOrdinal("LocationRegister");
		// LocationFailedWarning
		int locationFailedWarningColumnIndex = reader.GetOrdinal("LocationFailedWarning");
		// LocationFailed
		int locationFailedColumnIndex = reader.GetOrdinal("LocationFailed");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// ActiveDate
		int activeDateColumnIndex = reader.GetOrdinal("ActiveDate");
		// WarrantySerial
		int warrantySerialColumnIndex = reader.GetOrdinal("WarrantySerial");
		// WarrantyMonth
		int warrantyMonthColumnIndex = reader.GetOrdinal("WarrantyMonth");
		// WarrantyStartDate
		int warrantyStartDateColumnIndex = reader.GetOrdinal("WarrantyStartDate");
		// WarrantyEndDate
		int warrantyEndDateColumnIndex = reader.GetOrdinal("WarrantyEndDate");
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
		// Workshop_ID
		int workshop_IDColumnIndex = reader.GetOrdinal("Workshop_ID");
		// ProductItemNumber
		int productItemNumberColumnIndex = reader.GetOrdinal("ProductItemNumber");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				QRCodeSecret_ESRow record = new QRCodeSecret_ESRow();
				recordList.Add(record);

					record.QRCodeSecretContent = Convert.ToString(reader.GetValue(qRCodeSecretContentColumnIndex));
					if(!reader.IsDBNull(qRCodePublicContentColumnIndex))
						record.QRCodePublicContent = Convert.ToString(reader.GetValue(qRCodePublicContentColumnIndex));
					if(!reader.IsDBNull(sMSContentColumnIndex))
						record.SMSContent = Convert.ToString(reader.GetValue(sMSContentColumnIndex));
					if(!reader.IsDBNull(serialNumberColumnIndex))
						record.SerialNumber = Convert.ToString(reader.GetValue(serialNumberColumnIndex));
					if(!reader.IsDBNull(qRCodePackage_IDColumnIndex))
						record.QRCodePackage_ID = Convert.ToInt32(reader.GetValue(qRCodePackage_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(soundEnableColumnIndex))
						record.SoundEnable = Convert.ToBoolean(reader.GetValue(soundEnableColumnIndex));
					if(!reader.IsDBNull(qRCodeStatus_IDColumnIndex))
						record.QRCodeStatus_ID = Convert.ToInt32(reader.GetValue(qRCodeStatus_IDColumnIndex));
					if(!reader.IsDBNull(locationRegisterColumnIndex))
						record.LocationRegister = Convert.ToString(reader.GetValue(locationRegisterColumnIndex));
					if(!reader.IsDBNull(locationFailedWarningColumnIndex))
						record.LocationFailedWarning = Convert.ToBoolean(reader.GetValue(locationFailedWarningColumnIndex));
					if(!reader.IsDBNull(locationFailedColumnIndex))
						record.LocationFailed = Convert.ToBoolean(reader.GetValue(locationFailedColumnIndex));
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(activeDateColumnIndex))
						record.ActiveDate = Convert.ToDateTime(reader.GetValue(activeDateColumnIndex));
					if(!reader.IsDBNull(warrantySerialColumnIndex))
						record.WarrantySerial = Convert.ToString(reader.GetValue(warrantySerialColumnIndex));
					if(!reader.IsDBNull(warrantyMonthColumnIndex))
						record.WarrantyMonth = Convert.ToInt32(reader.GetValue(warrantyMonthColumnIndex));
					if(!reader.IsDBNull(warrantyStartDateColumnIndex))
						record.WarrantyStartDate = Convert.ToDateTime(reader.GetValue(warrantyStartDateColumnIndex));
					if(!reader.IsDBNull(warrantyEndDateColumnIndex))
						record.WarrantyEndDate = Convert.ToDateTime(reader.GetValue(warrantyEndDateColumnIndex));
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
					if(!reader.IsDBNull(workshop_IDColumnIndex))
						record.Workshop_ID = Convert.ToInt32(reader.GetValue(workshop_IDColumnIndex));
					if(!reader.IsDBNull(productItemNumberColumnIndex))
						record.ProductItemNumber = Convert.ToInt32(reader.GetValue(productItemNumberColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (QRCodeSecret_ESRow[])(recordList.ToArray(typeof(QRCodeSecret_ESRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="QRCodeSecret_ESRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="QRCodeSecret_ESRow"/> object.</returns>
	protected virtual QRCodeSecret_ESRow MapRow(DataRow row)
	{
		string LOCATION = "QRCodeSecret_ESRow MapRow(DataRow row)";
		QRCodeSecret_ESRow mappedObject = new QRCodeSecret_ESRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "QRCodeSecretContent"
		dataColumn = dataTable.Columns["QRCodeSecretContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeSecretContent = (string)(row[dataColumn]);
		// Column "QRCodePublicContent"
		dataColumn = dataTable.Columns["QRCodePublicContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePublicContent = (string)(row[dataColumn]);
		// Column "SMSContent"
		dataColumn = dataTable.Columns["SMSContent"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SMSContent = (string)(row[dataColumn]);
		// Column "SerialNumber"
		dataColumn = dataTable.Columns["SerialNumber"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SerialNumber = (string)(row[dataColumn]);
		// Column "QRCodePackage_ID"
		dataColumn = dataTable.Columns["QRCodePackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodePackage_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "SoundEnable"
		dataColumn = dataTable.Columns["SoundEnable"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SoundEnable = (bool)(row[dataColumn]);
		// Column "QRCodeStatus_ID"
		dataColumn = dataTable.Columns["QRCodeStatus_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeStatus_ID = (int)(row[dataColumn]);
		// Column "LocationRegister"
		dataColumn = dataTable.Columns["LocationRegister"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LocationRegister = (string)(row[dataColumn]);
		// Column "LocationFailedWarning"
		dataColumn = dataTable.Columns["LocationFailedWarning"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LocationFailedWarning = (bool)(row[dataColumn]);
		// Column "LocationFailed"
		dataColumn = dataTable.Columns["LocationFailed"];
		if (! row.IsNull(dataColumn) )
			mappedObject.LocationFailed = (bool)(row[dataColumn]);
		// Column "CreateDate"
		dataColumn = dataTable.Columns["CreateDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
		// Column "CreateBy"
		dataColumn = dataTable.Columns["CreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
		// Column "ActiveDate"
		dataColumn = dataTable.Columns["ActiveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ActiveDate = (System.DateTime)(row[dataColumn]);
		// Column "WarrantySerial"
		dataColumn = dataTable.Columns["WarrantySerial"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantySerial = (string)(row[dataColumn]);
		// Column "WarrantyMonth"
		dataColumn = dataTable.Columns["WarrantyMonth"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantyMonth = (int)(row[dataColumn]);
		// Column "WarrantyStartDate"
		dataColumn = dataTable.Columns["WarrantyStartDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantyStartDate = (System.DateTime)(row[dataColumn]);
		// Column "WarrantyEndDate"
		dataColumn = dataTable.Columns["WarrantyEndDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarrantyEndDate = (System.DateTime)(row[dataColumn]);
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
		// Column "Workshop_ID"
		dataColumn = dataTable.Columns["Workshop_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Workshop_ID = (int)(row[dataColumn]);
		// Column "ProductItemNumber"
		dataColumn = dataTable.Columns["ProductItemNumber"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductItemNumber = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>QRCodeSecret_ES</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "QRCodeSecret_ES";
		DataColumn dataColumn;
		// Create the "QRCodeSecretContent" column
		dataColumn = dataTable.Columns.Add("QRCodeSecretContent", typeof(string));
		dataColumn.MaxLength = 100;
		dataColumn.AllowDBNull = false;
		// Create the "QRCodePublicContent" column
		dataColumn = dataTable.Columns.Add("QRCodePublicContent", typeof(string));
		dataColumn.MaxLength = 100;
		// Create the "SMSContent" column
		dataColumn = dataTable.Columns.Add("SMSContent", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SerialNumber" column
		dataColumn = dataTable.Columns.Add("SerialNumber", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "QRCodePackage_ID" column
		dataColumn = dataTable.Columns.Add("QRCodePackage_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "SoundEnable" column
		dataColumn = dataTable.Columns.Add("SoundEnable", typeof(bool));
		// Create the "QRCodeStatus_ID" column
		dataColumn = dataTable.Columns.Add("QRCodeStatus_ID", typeof(int));
		// Create the "LocationRegister" column
		dataColumn = dataTable.Columns.Add("LocationRegister", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "LocationFailedWarning" column
		dataColumn = dataTable.Columns.Add("LocationFailedWarning", typeof(bool));
		// Create the "LocationFailed" column
		dataColumn = dataTable.Columns.Add("LocationFailed", typeof(bool));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "ActiveDate" column
		dataColumn = dataTable.Columns.Add("ActiveDate", typeof(System.DateTime));
		// Create the "WarrantySerial" column
		dataColumn = dataTable.Columns.Add("WarrantySerial", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "WarrantyMonth" column
		dataColumn = dataTable.Columns.Add("WarrantyMonth", typeof(int));
		// Create the "WarrantyStartDate" column
		dataColumn = dataTable.Columns.Add("WarrantyStartDate", typeof(System.DateTime));
		// Create the "WarrantyEndDate" column
		dataColumn = dataTable.Columns.Add("WarrantyEndDate", typeof(System.DateTime));
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
		// Create the "Workshop_ID" column
		dataColumn = dataTable.Columns.Add("Workshop_ID", typeof(int));
		// Create the "ProductItemNumber" column
		dataColumn = dataTable.Columns.Add("ProductItemNumber", typeof(int));
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
			case "QRCodeSecretContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodePublicContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SMSContent":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SerialNumber":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QRCodePackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SoundEnable":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "QRCodeStatus_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "LocationRegister":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "LocationFailedWarning":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "LocationFailed":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "CreateDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "CreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "ActiveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "WarrantySerial":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "WarrantyMonth":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WarrantyStartDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "WarrantyEndDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
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

			case "Workshop_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductItemNumber":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="QRCodeSecret_ESRow"/> by the primary key.
	/// </summary>
	/// <param name="qRCodeSecretContent">The <c>QRCodeSecretContent</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodeSecret_ESRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(string qRCodeSecretContent)
	{
		string LOCATION = "Exist(string qRCodeSecretContent)";
		IDbCommand cmd = _db.CreateCommand("QRCodeSecret_ES_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "QRCodeSecretContent", qRCodeSecretContent);
		QRCodeSecret_ESRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




