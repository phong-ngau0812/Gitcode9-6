
// <fileinfo name="Base\QRCodeWarehouseCollectionBase.cs">
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
/// The base class for <see cref="QRCodeWarehouseCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWarehouseCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodeWarehouseCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string QRCodeWarehouse_IDColumnName  = "QRCodeWarehouse_ID";
	public const string QRCodeWarehouseType_IDColumnName  = "QRCodeWarehouseType_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Store_IDColumnName  = "Store_ID";
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string Factory_IDColumnName  = "Factory_ID";
	public const string Supplier_IDColumnName  = "Supplier_ID";
	public const string NameColumnName  = "Name";
	public const string ProductNameColumnName  = "ProductName";
	public const string DescriptionColumnName  = "Description";
	public const string ProfileQRCodeColumnName  = "ProfileQRCode";
	public const string SoundEnableColumnName  = "SoundEnable";
	public const string SMSColumnName  = "SMS";
	public const string PrefixColumnName  = "Prefix";
	public const string ActiveColumnName  = "Active";
	public const string QRCodeStatus_IDColumnName  = "QRCodeStatus_ID";
	public const string ViewCountColumnName  = "ViewCount";
	public const string SellCountColumnName  = "SellCount";
	public const string QRCodeNumberColumnName  = "QRCodeNumber";
	public const string QRCodeUsedColumnName  = "QRCodeUsed";
	public const string QRCodeAvailableColumnName  = "QRCodeAvailable";
	public const string SerialNumberStartColumnName  = "SerialNumberStart";
	public const string SerialNumberEndColumnName  = "SerialNumberEnd";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string AgencyAssignColumnName  = "AgencyAssign";
	public const string ManufactureDateColumnName  = "ManufactureDate";
	public const string ExpiryDateColumnName  = "ExpiryDate";
	public const string WarrantySerialColumnName  = "WarrantySerial";
	public const string WarrantyMonthColumnName  = "WarrantyMonth";
	public const string WarrantyStartDateColumnName  = "WarrantyStartDate";
	public const string WarrantyEndDateColumnName  = "WarrantyEndDate";
	public const string UsedNameColumnName  = "UsedName";
	public const string UsedAddressColumnName  = "UsedAddress";
	public const string UsedPhoneColumnName  = "UsedPhone";
	public const string ActiveDateColumnName  = "ActiveDate";
	public const string PendingActiveColumnName  = "PendingActive";
	public const string PendingActiveDateColumnName  = "PendingActiveDate";
	public const string ProduceInfoStaffColumnName  = "ProduceInfoStaff";
	public const string ProduceInfoColumnName  = "ProduceInfo";
	public const string ProduceInfoDisplayColumnName  = "ProduceInfoDisplay";
	public const string ProduceInfoEditDateColumnName  = "ProduceInfoEditDate";
	public const string QualityInfoColumnName  = "QualityInfo";
	public const string QualityInfoDisplayColumnName  = "QualityInfoDisplay";
	public const string QualityInfoEditDateColumnName  = "QualityInfoEditDate";
	public const string DeliveryInfoColumnName  = "DeliveryInfo";
	public const string DeliveryInfoEditDateColumnName  = "DeliveryInfoEditDate";
	public const string StoreInfoColumnName  = "StoreInfo";
	public const string StoreInfoDisplayColumnName  = "StoreInfoDisplay";
	public const string StoreInfoEditDateColumnName  = "StoreInfoEditDate";
	public const string Warehouse_IDColumnName  = "Warehouse_ID";
	public const string CustomerInfoColumnName  = "CustomerInfo";
	public const string VerifyApproveByColumnName  = "VerifyApproveBy";
	public const string VerifyApproveDateColumnName  = "VerifyApproveDate";
	public const string CheckApproveByColumnName  = "CheckApproveBy";
	public const string CheckApproveDateColumnName  = "CheckApproveDate";
	public const string AdminApproveByColumnName  = "AdminApproveBy";
	public const string AdminApproveDateColumnName  = "AdminApproveDate";
	public const string StampDateColumnName  = "StampDate";
	public const string ShippingDateColumnName  = "ShippingDate";
	public const string ShippingNoteColumnName  = "ShippingNote";
	public const string ProductName_EnColumnName  = "ProductName_En";
	public const string Description_EnColumnName  = "Description_En";
	public const string ProfileQRCode_EnColumnName  = "ProfileQRCode_En";
	public const string ProduceInfo_EnColumnName  = "ProduceInfo_En";
	public const string QualityInfo_EnColumnName  = "QualityInfo_En";
	public const string DeliveryInfo_EnColumnName  = "DeliveryInfo_En";
	public const string StoreInfo_EnColumnName  = "StoreInfo_En";
	public const string CustomerInfo_EnColumnName  = "CustomerInfo_En";
	public const string ShippingNote_EnColumnName  = "ShippingNote_En";
	public const string ProductName_CnColumnName  = "ProductName_Cn";
	public const string Description_CnColumnName  = "Description_Cn";
	public const string ProfileQRCode_CnColumnName  = "ProfileQRCode_Cn";
	public const string ProduceInfo_CnColumnName  = "ProduceInfo_Cn";
	public const string QualityInfo_CnColumnName  = "QualityInfo_Cn";
	public const string DeliveryInfo_CnColumnName  = "DeliveryInfo_Cn";
	public const string StoreInfo_CnColumnName  = "StoreInfo_Cn";
	public const string CustomerInfo_CnColumnName  = "CustomerInfo_Cn";
	public const string ShippingNote_CnColumnName  = "ShippingNote_Cn";
	public const string AmountColumnName  = "Amount";
	public const string AmountUnitColumnName  = "AmountUnit";
	public const string AmountSumColumnName  = "AmountSum";
	public const string HarvestDateColumnName  = "HarvestDate";
	public const string ExpiryByDateColumnName  = "ExpiryByDate";
	public const string FarmCreateByColumnName  = "FarmCreateBy";
	public const string FarmWorkshop_IDColumnName  = "FarmWorkshop_ID";
	public const string FarmWorkshopNameColumnName  = "FarmWorkshopName";
	public const string FarmProducerNameColumnName  = "FarmProducerName";
	public const string FarmGroupInter_IDColumnName  = "FarmGroupInter_ID";
	public const string FarmGroupInterNameColumnName  = "FarmGroupInterName";
	public const string FarmGroup_IDColumnName  = "FarmGroup_ID";
	public const string FarmGroupNameColumnName  = "FarmGroupName";
	public const string WEB_UserID_CreateColumnName  = "WEB_UserID_Create";
	public const string WEB_UserID_EditColumnName  = "WEB_UserID_Edit";
	public const string NgaySXColumnName  = "NgaySX";
	public const string NguoiDanColumnName  = "NguoiDan";
	public const string PhanXuongSXColumnName  = "PhanXuongSX";
	public const string Department_IDColumnName  = "Department_ID";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public QRCodeWarehouseCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "QRCodeWarehouse";
	}

	public QRCodeWarehouseCollectionBase() : base()
	{
		this.TABLENAME = "QRCodeWarehouse";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <returns>An array of <see cref="QRCodeWarehouseRow"/> objects.</returns>
	public virtual QRCodeWarehouseRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>QRCodeWarehouse</c> table.
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
	/// to retrieve all records from the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("QRCodeWarehouse_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="QRCodeWarehouseRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="QRCodeWarehouseRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public QRCodeWarehouseRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			QRCodeWarehouseRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="QRCodeWarehouseRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="QRCodeWarehouseRow"/> objects.</returns>
	public QRCodeWarehouseRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="QRCodeWarehouseRow"/> objects that 
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
	/// <returns>An array of <see cref="QRCodeWarehouseRow"/> objects.</returns>
	public virtual QRCodeWarehouseRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			QRCodeWarehouseRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="QRCodeWarehouseRow"/> by the primary key.
	/// </summary>
	/// <param name="QRCodeWarehouse_ID">The <c>QRCodeWarehouse_ID</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodeWarehouseRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual QRCodeWarehouseRow GetByPrimaryKey(int QRCodeWarehouse_ID)
	{
		string LOCATION = "GetByPrimaryKey(int QRCodeWarehouse_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "QRCodeWarehouse_ID", QRCodeWarehouse_ID);
			QRCodeWarehouseRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeWarehouseRow"/> object to be inserted.</param>
	public virtual void Insert(QRCodeWarehouseRow value)
	{
		string LOCATION = "Insert(QRCodeWarehouseRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_Insert", CommandType.StoredProcedure);
					// QRCodeWarehouseType_ID
			if (value.IsQRCodeWarehouseType_IDNull)
				AddParameter(cmd, "QRCodeWarehouseType_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeWarehouseType_ID", value.QRCodeWarehouseType_ID);
			
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
			
				// Store_ID
			if (value.IsStore_IDNull)
				AddParameter(cmd, "Store_ID", DBNull.Value);
			else
				AddParameter(cmd, "Store_ID", value.Store_ID);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// Factory_ID
			if (value.IsFactory_IDNull)
				AddParameter(cmd, "Factory_ID", DBNull.Value);
			else
				AddParameter(cmd, "Factory_ID", value.Factory_ID);
			
				// Supplier_ID
			if (value.IsSupplier_IDNull)
				AddParameter(cmd, "Supplier_ID", DBNull.Value);
			else
				AddParameter(cmd, "Supplier_ID", value.Supplier_ID);
			
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
			
				// ProfileQRCode
			if (value.IsProfileQRCodeNull )
				AddParameter(cmd, "ProfileQRCode", DBNull.Value);
			else
				AddParameter(cmd, "ProfileQRCode", value.ProfileQRCode);
			
				// SoundEnable
			if (value.IsSoundEnableNull)
				AddParameter(cmd, "SoundEnable", DBNull.Value);
			else
				AddParameter(cmd, "SoundEnable", value.SoundEnable);
			
				// SMS
			if (value.IsSMSNull)
				AddParameter(cmd, "SMS", DBNull.Value);
			else
				AddParameter(cmd, "SMS", value.SMS);
			
				// Prefix
			if (value.IsPrefixNull )
				AddParameter(cmd, "Prefix", DBNull.Value);
			else
				AddParameter(cmd, "Prefix", value.Prefix);
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// QRCodeStatus_ID
			if (value.IsQRCodeStatus_IDNull)
				AddParameter(cmd, "QRCodeStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeStatus_ID", value.QRCodeStatus_ID);
			
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
			
				// QRCodeNumber
			if (value.IsQRCodeNumberNull)
				AddParameter(cmd, "QRCodeNumber", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeNumber", value.QRCodeNumber);
			
				// QRCodeUsed
			if (value.IsQRCodeUsedNull)
				AddParameter(cmd, "QRCodeUsed", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeUsed", value.QRCodeUsed);
			
				// QRCodeAvailable
			if (value.IsQRCodeAvailableNull)
				AddParameter(cmd, "QRCodeAvailable", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeAvailable", value.QRCodeAvailable);
			
				// SerialNumberStart
			if (value.IsSerialNumberStartNull )
				AddParameter(cmd, "SerialNumberStart", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
			
				// SerialNumberEnd
			if (value.IsSerialNumberEndNull )
				AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
			
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
			
				// AgencyAssign
			if (value.IsAgencyAssignNull)
				AddParameter(cmd, "AgencyAssign", DBNull.Value);
			else
				AddParameter(cmd, "AgencyAssign", value.AgencyAssign);
			
				// ManufactureDate
			if (value.IsManufactureDateNull)
				AddParameter(cmd, "ManufactureDate", DBNull.Value);
			else
				AddParameter(cmd, "ManufactureDate", value.ManufactureDate);
			
				// ExpiryDate
			if (value.IsExpiryDateNull)
				AddParameter(cmd, "ExpiryDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpiryDate", value.ExpiryDate);
			
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
			
				// ActiveDate
			if (value.IsActiveDateNull)
				AddParameter(cmd, "ActiveDate", DBNull.Value);
			else
				AddParameter(cmd, "ActiveDate", value.ActiveDate);
			
				// PendingActive
			if (value.IsPendingActiveNull)
				AddParameter(cmd, "PendingActive", DBNull.Value);
			else
				AddParameter(cmd, "PendingActive", value.PendingActive);
			
				// PendingActiveDate
			if (value.IsPendingActiveDateNull)
				AddParameter(cmd, "PendingActiveDate", DBNull.Value);
			else
				AddParameter(cmd, "PendingActiveDate", value.PendingActiveDate);
			
				// ProduceInfoStaff
			if (value.IsProduceInfoStaffNull )
				AddParameter(cmd, "ProduceInfoStaff", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfoStaff", value.ProduceInfoStaff);
			
				// ProduceInfo
			if (value.IsProduceInfoNull )
				AddParameter(cmd, "ProduceInfo", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfo", value.ProduceInfo);
			
				// ProduceInfoDisplay
			if (value.IsProduceInfoDisplayNull)
				AddParameter(cmd, "ProduceInfoDisplay", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfoDisplay", value.ProduceInfoDisplay);
			
				// ProduceInfoEditDate
			if (value.IsProduceInfoEditDateNull)
				AddParameter(cmd, "ProduceInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfoEditDate", value.ProduceInfoEditDate);
			
				// QualityInfo
			if (value.IsQualityInfoNull )
				AddParameter(cmd, "QualityInfo", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfo", value.QualityInfo);
			
				// QualityInfoDisplay
			if (value.IsQualityInfoDisplayNull)
				AddParameter(cmd, "QualityInfoDisplay", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfoDisplay", value.QualityInfoDisplay);
			
				// QualityInfoEditDate
			if (value.IsQualityInfoEditDateNull)
				AddParameter(cmd, "QualityInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfoEditDate", value.QualityInfoEditDate);
			
				// DeliveryInfo
			if (value.IsDeliveryInfoNull )
				AddParameter(cmd, "DeliveryInfo", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfo", value.DeliveryInfo);
			
				// DeliveryInfoEditDate
			if (value.IsDeliveryInfoEditDateNull)
				AddParameter(cmd, "DeliveryInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfoEditDate", value.DeliveryInfoEditDate);
			
				// StoreInfo
			if (value.IsStoreInfoNull )
				AddParameter(cmd, "StoreInfo", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfo", value.StoreInfo);
			
				// StoreInfoDisplay
			if (value.IsStoreInfoDisplayNull)
				AddParameter(cmd, "StoreInfoDisplay", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfoDisplay", value.StoreInfoDisplay);
			
				// StoreInfoEditDate
			if (value.IsStoreInfoEditDateNull)
				AddParameter(cmd, "StoreInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfoEditDate", value.StoreInfoEditDate);
			
				// Warehouse_ID
			if (value.IsWarehouse_IDNull)
				AddParameter(cmd, "Warehouse_ID", DBNull.Value);
			else
				AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
			
				// CustomerInfo
			if (value.IsCustomerInfoNull )
				AddParameter(cmd, "CustomerInfo", DBNull.Value);
			else
				AddParameter(cmd, "CustomerInfo", value.CustomerInfo);
			
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
			
				// StampDate
			if (value.IsStampDateNull)
				AddParameter(cmd, "StampDate", DBNull.Value);
			else
				AddParameter(cmd, "StampDate", value.StampDate);
			
				// ShippingDate
			if (value.IsShippingDateNull)
				AddParameter(cmd, "ShippingDate", DBNull.Value);
			else
				AddParameter(cmd, "ShippingDate", value.ShippingDate);
			
				// ShippingNote
			if (value.IsShippingNoteNull )
				AddParameter(cmd, "ShippingNote", DBNull.Value);
			else
				AddParameter(cmd, "ShippingNote", value.ShippingNote);
			
				// ProductName_En
			if (value.IsProductName_EnNull )
				AddParameter(cmd, "ProductName_En", DBNull.Value);
			else
				AddParameter(cmd, "ProductName_En", value.ProductName_En);
			
				// Description_En
			if (value.IsDescription_EnNull )
				AddParameter(cmd, "Description_En", DBNull.Value);
			else
				AddParameter(cmd, "Description_En", value.Description_En);
			
				// ProfileQRCode_En
			if (value.IsProfileQRCode_EnNull )
				AddParameter(cmd, "ProfileQRCode_En", DBNull.Value);
			else
				AddParameter(cmd, "ProfileQRCode_En", value.ProfileQRCode_En);
			
				// ProduceInfo_En
			if (value.IsProduceInfo_EnNull )
				AddParameter(cmd, "ProduceInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfo_En", value.ProduceInfo_En);
			
				// QualityInfo_En
			if (value.IsQualityInfo_EnNull )
				AddParameter(cmd, "QualityInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfo_En", value.QualityInfo_En);
			
				// DeliveryInfo_En
			if (value.IsDeliveryInfo_EnNull )
				AddParameter(cmd, "DeliveryInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfo_En", value.DeliveryInfo_En);
			
				// StoreInfo_En
			if (value.IsStoreInfo_EnNull )
				AddParameter(cmd, "StoreInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfo_En", value.StoreInfo_En);
			
				// CustomerInfo_En
			if (value.IsCustomerInfo_EnNull )
				AddParameter(cmd, "CustomerInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "CustomerInfo_En", value.CustomerInfo_En);
			
				// ShippingNote_En
			if (value.IsShippingNote_EnNull )
				AddParameter(cmd, "ShippingNote_En", DBNull.Value);
			else
				AddParameter(cmd, "ShippingNote_En", value.ShippingNote_En);
			
				// ProductName_Cn
			if (value.IsProductName_CnNull )
				AddParameter(cmd, "ProductName_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ProductName_Cn", value.ProductName_Cn);
			
				// Description_Cn
			if (value.IsDescription_CnNull )
				AddParameter(cmd, "Description_Cn", DBNull.Value);
			else
				AddParameter(cmd, "Description_Cn", value.Description_Cn);
			
				// ProfileQRCode_Cn
			if (value.IsProfileQRCode_CnNull )
				AddParameter(cmd, "ProfileQRCode_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ProfileQRCode_Cn", value.ProfileQRCode_Cn);
			
				// ProduceInfo_Cn
			if (value.IsProduceInfo_CnNull )
				AddParameter(cmd, "ProduceInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfo_Cn", value.ProduceInfo_Cn);
			
				// QualityInfo_Cn
			if (value.IsQualityInfo_CnNull )
				AddParameter(cmd, "QualityInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfo_Cn", value.QualityInfo_Cn);
			
				// DeliveryInfo_Cn
			if (value.IsDeliveryInfo_CnNull )
				AddParameter(cmd, "DeliveryInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfo_Cn", value.DeliveryInfo_Cn);
			
				// StoreInfo_Cn
			if (value.IsStoreInfo_CnNull )
				AddParameter(cmd, "StoreInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfo_Cn", value.StoreInfo_Cn);
			
				// CustomerInfo_Cn
			if (value.IsCustomerInfo_CnNull )
				AddParameter(cmd, "CustomerInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "CustomerInfo_Cn", value.CustomerInfo_Cn);
			
				// ShippingNote_Cn
			if (value.IsShippingNote_CnNull )
				AddParameter(cmd, "ShippingNote_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ShippingNote_Cn", value.ShippingNote_Cn);
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// AmountUnit
			if (value.IsAmountUnitNull )
				AddParameter(cmd, "AmountUnit", DBNull.Value);
			else
				AddParameter(cmd, "AmountUnit", value.AmountUnit);
			
				// AmountSum
			if (value.IsAmountSumNull)
				AddParameter(cmd, "AmountSum", DBNull.Value);
			else
				AddParameter(cmd, "AmountSum", value.AmountSum);
			
				// HarvestDate
			if (value.IsHarvestDateNull)
				AddParameter(cmd, "HarvestDate", DBNull.Value);
			else
				AddParameter(cmd, "HarvestDate", value.HarvestDate);
			
				// ExpiryByDate
			if (value.IsExpiryByDateNull)
				AddParameter(cmd, "ExpiryByDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpiryByDate", value.ExpiryByDate);
			
				// FarmCreateBy
			if (value.IsFarmCreateByNull)
				AddParameter(cmd, "FarmCreateBy", DBNull.Value);
			else
				AddParameter(cmd, "FarmCreateBy", value.FarmCreateBy);
			
				// FarmWorkshop_ID
			if (value.IsFarmWorkshop_IDNull)
				AddParameter(cmd, "FarmWorkshop_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmWorkshop_ID", value.FarmWorkshop_ID);
			
				// FarmWorkshopName
			if (value.IsFarmWorkshopNameNull )
				AddParameter(cmd, "FarmWorkshopName", DBNull.Value);
			else
				AddParameter(cmd, "FarmWorkshopName", value.FarmWorkshopName);
			
				// FarmProducerName
			if (value.IsFarmProducerNameNull )
				AddParameter(cmd, "FarmProducerName", DBNull.Value);
			else
				AddParameter(cmd, "FarmProducerName", value.FarmProducerName);
			
				// FarmGroupInter_ID
			if (value.IsFarmGroupInter_IDNull)
				AddParameter(cmd, "FarmGroupInter_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupInter_ID", value.FarmGroupInter_ID);
			
				// FarmGroupInterName
			if (value.IsFarmGroupInterNameNull )
				AddParameter(cmd, "FarmGroupInterName", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupInterName", value.FarmGroupInterName);
			
				// FarmGroup_ID
			if (value.IsFarmGroup_IDNull)
				AddParameter(cmd, "FarmGroup_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroup_ID", value.FarmGroup_ID);
			
				// FarmGroupName
			if (value.IsFarmGroupNameNull )
				AddParameter(cmd, "FarmGroupName", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupName", value.FarmGroupName);
			
				// WEB_UserID_Create
			if (value.IsWEB_UserID_CreateNull)
				AddParameter(cmd, "WEB_UserID_Create", DBNull.Value);
			else
				AddParameter(cmd, "WEB_UserID_Create", value.WEB_UserID_Create);
			
				// WEB_UserID_Edit
			if (value.IsWEB_UserID_EditNull)
				AddParameter(cmd, "WEB_UserID_Edit", DBNull.Value);
			else
				AddParameter(cmd, "WEB_UserID_Edit", value.WEB_UserID_Edit);
			
				// NgaySX
			if (value.IsNgaySXNull)
				AddParameter(cmd, "NgaySX", DBNull.Value);
			else
				AddParameter(cmd, "NgaySX", value.NgaySX);
			
				// NguoiDan
			if (value.IsNguoiDanNull )
				AddParameter(cmd, "NguoiDan", DBNull.Value);
			else
				AddParameter(cmd, "NguoiDan", value.NguoiDan);
			
				// PhanXuongSX
			if (value.IsPhanXuongSXNull )
				AddParameter(cmd, "PhanXuongSX", DBNull.Value);
			else
				AddParameter(cmd, "PhanXuongSX", value.PhanXuongSX);
			
				// Department_ID
			if (value.IsDepartment_IDNull)
				AddParameter(cmd, "Department_ID", DBNull.Value);
			else
				AddParameter(cmd, "Department_ID", value.Department_ID);
			
						value.QRCodeWarehouse_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeWarehouseRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(QRCodeWarehouseRow value)
	{	
		string LOCATION = "Update(QRCodeWarehouseRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_Update", CommandType.StoredProcedure);
					// QRCodeWarehouseType_ID
			if (value.IsQRCodeWarehouseType_IDNull)
				AddParameter(cmd, "QRCodeWarehouseType_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeWarehouseType_ID", value.QRCodeWarehouseType_ID);
			
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
			
				// Store_ID
			if (value.IsStore_IDNull)
				AddParameter(cmd, "Store_ID", DBNull.Value);
			else
				AddParameter(cmd, "Store_ID", value.Store_ID);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
				// Factory_ID
			if (value.IsFactory_IDNull)
				AddParameter(cmd, "Factory_ID", DBNull.Value);
			else
				AddParameter(cmd, "Factory_ID", value.Factory_ID);
			
				// Supplier_ID
			if (value.IsSupplier_IDNull)
				AddParameter(cmd, "Supplier_ID", DBNull.Value);
			else
				AddParameter(cmd, "Supplier_ID", value.Supplier_ID);
			
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
				// ProfileQRCode
			if (value.IsProfileQRCodeNull)
				AddParameter(cmd, "ProfileQRCode", DBNull.Value);
			else
				AddParameter(cmd, "ProfileQRCode", value.ProfileQRCode);
				// SoundEnable
			if (value.IsSoundEnableNull)
				AddParameter(cmd, "SoundEnable", DBNull.Value);
			else
				AddParameter(cmd, "SoundEnable", value.SoundEnable);
			
				// SMS
			if (value.IsSMSNull)
				AddParameter(cmd, "SMS", DBNull.Value);
			else
				AddParameter(cmd, "SMS", value.SMS);
			
				// Prefix
			if (value.IsPrefixNull)
				AddParameter(cmd, "Prefix", DBNull.Value);
			else
				AddParameter(cmd, "Prefix", value.Prefix);
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
				// QRCodeStatus_ID
			if (value.IsQRCodeStatus_IDNull)
				AddParameter(cmd, "QRCodeStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeStatus_ID", value.QRCodeStatus_ID);
			
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
			
				// QRCodeNumber
			if (value.IsQRCodeNumberNull)
				AddParameter(cmd, "QRCodeNumber", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeNumber", value.QRCodeNumber);
			
				// QRCodeUsed
			if (value.IsQRCodeUsedNull)
				AddParameter(cmd, "QRCodeUsed", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeUsed", value.QRCodeUsed);
			
				// QRCodeAvailable
			if (value.IsQRCodeAvailableNull)
				AddParameter(cmd, "QRCodeAvailable", DBNull.Value);
			else
				AddParameter(cmd, "QRCodeAvailable", value.QRCodeAvailable);
			
				// SerialNumberStart
			if (value.IsSerialNumberStartNull)
				AddParameter(cmd, "SerialNumberStart", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberStart", value.SerialNumberStart);
				// SerialNumberEnd
			if (value.IsSerialNumberEndNull)
				AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
			else
				AddParameter(cmd, "SerialNumberEnd", value.SerialNumberEnd);
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
			
				// AgencyAssign
			if (value.IsAgencyAssignNull)
				AddParameter(cmd, "AgencyAssign", DBNull.Value);
			else
				AddParameter(cmd, "AgencyAssign", value.AgencyAssign);
			
				// ManufactureDate
			if (value.IsManufactureDateNull)
				AddParameter(cmd, "ManufactureDate", DBNull.Value);
			else
				AddParameter(cmd, "ManufactureDate", value.ManufactureDate);
			
				// ExpiryDate
			if (value.IsExpiryDateNull)
				AddParameter(cmd, "ExpiryDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpiryDate", value.ExpiryDate);
			
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
				// ActiveDate
			if (value.IsActiveDateNull)
				AddParameter(cmd, "ActiveDate", DBNull.Value);
			else
				AddParameter(cmd, "ActiveDate", value.ActiveDate);
			
				// PendingActive
			if (value.IsPendingActiveNull)
				AddParameter(cmd, "PendingActive", DBNull.Value);
			else
				AddParameter(cmd, "PendingActive", value.PendingActive);
			
				// PendingActiveDate
			if (value.IsPendingActiveDateNull)
				AddParameter(cmd, "PendingActiveDate", DBNull.Value);
			else
				AddParameter(cmd, "PendingActiveDate", value.PendingActiveDate);
			
				// ProduceInfoStaff
			if (value.IsProduceInfoStaffNull)
				AddParameter(cmd, "ProduceInfoStaff", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfoStaff", value.ProduceInfoStaff);
				// ProduceInfo
			if (value.IsProduceInfoNull)
				AddParameter(cmd, "ProduceInfo", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfo", value.ProduceInfo);
				// ProduceInfoDisplay
			if (value.IsProduceInfoDisplayNull)
				AddParameter(cmd, "ProduceInfoDisplay", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfoDisplay", value.ProduceInfoDisplay);
			
				// ProduceInfoEditDate
			if (value.IsProduceInfoEditDateNull)
				AddParameter(cmd, "ProduceInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfoEditDate", value.ProduceInfoEditDate);
			
				// QualityInfo
			if (value.IsQualityInfoNull)
				AddParameter(cmd, "QualityInfo", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfo", value.QualityInfo);
				// QualityInfoDisplay
			if (value.IsQualityInfoDisplayNull)
				AddParameter(cmd, "QualityInfoDisplay", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfoDisplay", value.QualityInfoDisplay);
			
				// QualityInfoEditDate
			if (value.IsQualityInfoEditDateNull)
				AddParameter(cmd, "QualityInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfoEditDate", value.QualityInfoEditDate);
			
				// DeliveryInfo
			if (value.IsDeliveryInfoNull)
				AddParameter(cmd, "DeliveryInfo", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfo", value.DeliveryInfo);
				// DeliveryInfoEditDate
			if (value.IsDeliveryInfoEditDateNull)
				AddParameter(cmd, "DeliveryInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfoEditDate", value.DeliveryInfoEditDate);
			
				// StoreInfo
			if (value.IsStoreInfoNull)
				AddParameter(cmd, "StoreInfo", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfo", value.StoreInfo);
				// StoreInfoDisplay
			if (value.IsStoreInfoDisplayNull)
				AddParameter(cmd, "StoreInfoDisplay", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfoDisplay", value.StoreInfoDisplay);
			
				// StoreInfoEditDate
			if (value.IsStoreInfoEditDateNull)
				AddParameter(cmd, "StoreInfoEditDate", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfoEditDate", value.StoreInfoEditDate);
			
				// Warehouse_ID
			if (value.IsWarehouse_IDNull)
				AddParameter(cmd, "Warehouse_ID", DBNull.Value);
			else
				AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
			
				// CustomerInfo
			if (value.IsCustomerInfoNull)
				AddParameter(cmd, "CustomerInfo", DBNull.Value);
			else
				AddParameter(cmd, "CustomerInfo", value.CustomerInfo);
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
			
				// StampDate
			if (value.IsStampDateNull)
				AddParameter(cmd, "StampDate", DBNull.Value);
			else
				AddParameter(cmd, "StampDate", value.StampDate);
			
				// ShippingDate
			if (value.IsShippingDateNull)
				AddParameter(cmd, "ShippingDate", DBNull.Value);
			else
				AddParameter(cmd, "ShippingDate", value.ShippingDate);
			
				// ShippingNote
			if (value.IsShippingNoteNull)
				AddParameter(cmd, "ShippingNote", DBNull.Value);
			else
				AddParameter(cmd, "ShippingNote", value.ShippingNote);
				// ProductName_En
			if (value.IsProductName_EnNull)
				AddParameter(cmd, "ProductName_En", DBNull.Value);
			else
				AddParameter(cmd, "ProductName_En", value.ProductName_En);
				// Description_En
			if (value.IsDescription_EnNull)
				AddParameter(cmd, "Description_En", DBNull.Value);
			else
				AddParameter(cmd, "Description_En", value.Description_En);
				// ProfileQRCode_En
			if (value.IsProfileQRCode_EnNull)
				AddParameter(cmd, "ProfileQRCode_En", DBNull.Value);
			else
				AddParameter(cmd, "ProfileQRCode_En", value.ProfileQRCode_En);
				// ProduceInfo_En
			if (value.IsProduceInfo_EnNull)
				AddParameter(cmd, "ProduceInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfo_En", value.ProduceInfo_En);
				// QualityInfo_En
			if (value.IsQualityInfo_EnNull)
				AddParameter(cmd, "QualityInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfo_En", value.QualityInfo_En);
				// DeliveryInfo_En
			if (value.IsDeliveryInfo_EnNull)
				AddParameter(cmd, "DeliveryInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfo_En", value.DeliveryInfo_En);
				// StoreInfo_En
			if (value.IsStoreInfo_EnNull)
				AddParameter(cmd, "StoreInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfo_En", value.StoreInfo_En);
				// CustomerInfo_En
			if (value.IsCustomerInfo_EnNull)
				AddParameter(cmd, "CustomerInfo_En", DBNull.Value);
			else
				AddParameter(cmd, "CustomerInfo_En", value.CustomerInfo_En);
				// ShippingNote_En
			if (value.IsShippingNote_EnNull)
				AddParameter(cmd, "ShippingNote_En", DBNull.Value);
			else
				AddParameter(cmd, "ShippingNote_En", value.ShippingNote_En);
				// ProductName_Cn
			if (value.IsProductName_CnNull)
				AddParameter(cmd, "ProductName_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ProductName_Cn", value.ProductName_Cn);
				// Description_Cn
			if (value.IsDescription_CnNull)
				AddParameter(cmd, "Description_Cn", DBNull.Value);
			else
				AddParameter(cmd, "Description_Cn", value.Description_Cn);
				// ProfileQRCode_Cn
			if (value.IsProfileQRCode_CnNull)
				AddParameter(cmd, "ProfileQRCode_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ProfileQRCode_Cn", value.ProfileQRCode_Cn);
				// ProduceInfo_Cn
			if (value.IsProduceInfo_CnNull)
				AddParameter(cmd, "ProduceInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ProduceInfo_Cn", value.ProduceInfo_Cn);
				// QualityInfo_Cn
			if (value.IsQualityInfo_CnNull)
				AddParameter(cmd, "QualityInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "QualityInfo_Cn", value.QualityInfo_Cn);
				// DeliveryInfo_Cn
			if (value.IsDeliveryInfo_CnNull)
				AddParameter(cmd, "DeliveryInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "DeliveryInfo_Cn", value.DeliveryInfo_Cn);
				// StoreInfo_Cn
			if (value.IsStoreInfo_CnNull)
				AddParameter(cmd, "StoreInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "StoreInfo_Cn", value.StoreInfo_Cn);
				// CustomerInfo_Cn
			if (value.IsCustomerInfo_CnNull)
				AddParameter(cmd, "CustomerInfo_Cn", DBNull.Value);
			else
				AddParameter(cmd, "CustomerInfo_Cn", value.CustomerInfo_Cn);
				// ShippingNote_Cn
			if (value.IsShippingNote_CnNull)
				AddParameter(cmd, "ShippingNote_Cn", DBNull.Value);
			else
				AddParameter(cmd, "ShippingNote_Cn", value.ShippingNote_Cn);
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// AmountUnit
			if (value.IsAmountUnitNull)
				AddParameter(cmd, "AmountUnit", DBNull.Value);
			else
				AddParameter(cmd, "AmountUnit", value.AmountUnit);
				// AmountSum
			if (value.IsAmountSumNull)
				AddParameter(cmd, "AmountSum", DBNull.Value);
			else
				AddParameter(cmd, "AmountSum", value.AmountSum);
			
				// HarvestDate
			if (value.IsHarvestDateNull)
				AddParameter(cmd, "HarvestDate", DBNull.Value);
			else
				AddParameter(cmd, "HarvestDate", value.HarvestDate);
			
				// ExpiryByDate
			if (value.IsExpiryByDateNull)
				AddParameter(cmd, "ExpiryByDate", DBNull.Value);
			else
				AddParameter(cmd, "ExpiryByDate", value.ExpiryByDate);
			
				// FarmCreateBy
			if (value.IsFarmCreateByNull)
				AddParameter(cmd, "FarmCreateBy", DBNull.Value);
			else
				AddParameter(cmd, "FarmCreateBy", value.FarmCreateBy);
			
				// FarmWorkshop_ID
			if (value.IsFarmWorkshop_IDNull)
				AddParameter(cmd, "FarmWorkshop_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmWorkshop_ID", value.FarmWorkshop_ID);
			
				// FarmWorkshopName
			if (value.IsFarmWorkshopNameNull)
				AddParameter(cmd, "FarmWorkshopName", DBNull.Value);
			else
				AddParameter(cmd, "FarmWorkshopName", value.FarmWorkshopName);
				// FarmProducerName
			if (value.IsFarmProducerNameNull)
				AddParameter(cmd, "FarmProducerName", DBNull.Value);
			else
				AddParameter(cmd, "FarmProducerName", value.FarmProducerName);
				// FarmGroupInter_ID
			if (value.IsFarmGroupInter_IDNull)
				AddParameter(cmd, "FarmGroupInter_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupInter_ID", value.FarmGroupInter_ID);
			
				// FarmGroupInterName
			if (value.IsFarmGroupInterNameNull)
				AddParameter(cmd, "FarmGroupInterName", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupInterName", value.FarmGroupInterName);
				// FarmGroup_ID
			if (value.IsFarmGroup_IDNull)
				AddParameter(cmd, "FarmGroup_ID", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroup_ID", value.FarmGroup_ID);
			
				// FarmGroupName
			if (value.IsFarmGroupNameNull)
				AddParameter(cmd, "FarmGroupName", DBNull.Value);
			else
				AddParameter(cmd, "FarmGroupName", value.FarmGroupName);
				// WEB_UserID_Create
			if (value.IsWEB_UserID_CreateNull)
				AddParameter(cmd, "WEB_UserID_Create", DBNull.Value);
			else
				AddParameter(cmd, "WEB_UserID_Create", value.WEB_UserID_Create);
			
				// WEB_UserID_Edit
			if (value.IsWEB_UserID_EditNull)
				AddParameter(cmd, "WEB_UserID_Edit", DBNull.Value);
			else
				AddParameter(cmd, "WEB_UserID_Edit", value.WEB_UserID_Edit);
			
				// NgaySX
			if (value.IsNgaySXNull)
				AddParameter(cmd, "NgaySX", DBNull.Value);
			else
				AddParameter(cmd, "NgaySX", value.NgaySX);
			
				// NguoiDan
			if (value.IsNguoiDanNull)
				AddParameter(cmd, "NguoiDan", DBNull.Value);
			else
				AddParameter(cmd, "NguoiDan", value.NguoiDan);
				// PhanXuongSX
			if (value.IsPhanXuongSXNull)
				AddParameter(cmd, "PhanXuongSX", DBNull.Value);
			else
				AddParameter(cmd, "PhanXuongSX", value.PhanXuongSX);
				// Department_ID
			if (value.IsDepartment_IDNull)
				AddParameter(cmd, "Department_ID", DBNull.Value);
			else
				AddParameter(cmd, "Department_ID", value.Department_ID);
			
					AddParameter(cmd, "QRCodeWarehouse_ID", value.QRCodeWarehouse_ID);
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
		/// Inserts or Updates a record in the <c>QRCodeWarehouse</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="QRCodeWarehouseRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(QRCodeWarehouseRow value)
		{
			string LOCATION = "Save(QRCodeWarehouseRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("QRCodeWarehouse_Save",CommandType.StoredProcedure);
					// QRCodeWarehouseType_ID
				if (value.IsQRCodeWarehouseType_IDNull)
					AddParameter(cmd, "QRCodeWarehouseType_ID", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeWarehouseType_ID", (object)(value.QRCodeWarehouseType_ID));
				
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
				
					// Store_ID
				if (value.IsStore_IDNull)
					AddParameter(cmd, "Store_ID", DBNull.Value);
				else
					AddParameter(cmd, "Store_ID", (object)(value.Store_ID));
				
					// ProductPackage_ID
				if (value.IsProductPackage_IDNull)
					AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));
				
					// Factory_ID
				if (value.IsFactory_IDNull)
					AddParameter(cmd, "Factory_ID", DBNull.Value);
				else
					AddParameter(cmd, "Factory_ID", (object)(value.Factory_ID));
				
					// Supplier_ID
				if (value.IsSupplier_IDNull)
					AddParameter(cmd, "Supplier_ID", DBNull.Value);
				else
					AddParameter(cmd, "Supplier_ID", (object)(value.Supplier_ID));
				
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
				
					// ProfileQRCode
				if (value.IsProfileQRCodeNull)
					AddParameter(cmd, "ProfileQRCode", DBNull.Value);
				else
					AddParameter(cmd, "ProfileQRCode", (object)(value.ProfileQRCode));
				
					// SoundEnable
				if (value.IsSoundEnableNull)
					AddParameter(cmd, "SoundEnable", DBNull.Value);
				else
					AddParameter(cmd, "SoundEnable", (object)(value.SoundEnable));
				
					// SMS
				if (value.IsSMSNull)
					AddParameter(cmd, "SMS", DBNull.Value);
				else
					AddParameter(cmd, "SMS", (object)(value.SMS));
				
					// Prefix
				if (value.IsPrefixNull)
					AddParameter(cmd, "Prefix", DBNull.Value);
				else
					AddParameter(cmd, "Prefix", (object)(value.Prefix));
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
					// QRCodeStatus_ID
				if (value.IsQRCodeStatus_IDNull)
					AddParameter(cmd, "QRCodeStatus_ID", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeStatus_ID", (object)(value.QRCodeStatus_ID));
				
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
				
					// QRCodeNumber
				if (value.IsQRCodeNumberNull)
					AddParameter(cmd, "QRCodeNumber", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeNumber", (object)(value.QRCodeNumber));
				
					// QRCodeUsed
				if (value.IsQRCodeUsedNull)
					AddParameter(cmd, "QRCodeUsed", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeUsed", (object)(value.QRCodeUsed));
				
					// QRCodeAvailable
				if (value.IsQRCodeAvailableNull)
					AddParameter(cmd, "QRCodeAvailable", DBNull.Value);
				else
					AddParameter(cmd, "QRCodeAvailable", (object)(value.QRCodeAvailable));
				
					// SerialNumberStart
				if (value.IsSerialNumberStartNull)
					AddParameter(cmd, "SerialNumberStart", DBNull.Value);
				else
					AddParameter(cmd, "SerialNumberStart", (object)(value.SerialNumberStart));
				
					// SerialNumberEnd
				if (value.IsSerialNumberEndNull)
					AddParameter(cmd, "SerialNumberEnd", DBNull.Value);
				else
					AddParameter(cmd, "SerialNumberEnd", (object)(value.SerialNumberEnd));
				
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
				
					// AgencyAssign
				if (value.IsAgencyAssignNull)
					AddParameter(cmd, "AgencyAssign", DBNull.Value);
				else
					AddParameter(cmd, "AgencyAssign", (object)(value.AgencyAssign));
				
					// ManufactureDate
				if (value.IsManufactureDateNull)
					AddParameter(cmd, "ManufactureDate", DBNull.Value);
				else
					AddParameter(cmd, "ManufactureDate", (object)(value.ManufactureDate));
				
					// ExpiryDate
				if (value.IsExpiryDateNull)
					AddParameter(cmd, "ExpiryDate", DBNull.Value);
				else
					AddParameter(cmd, "ExpiryDate", (object)(value.ExpiryDate));
				
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
				
					// ActiveDate
				if (value.IsActiveDateNull)
					AddParameter(cmd, "ActiveDate", DBNull.Value);
				else
					AddParameter(cmd, "ActiveDate", (object)(value.ActiveDate));
				
					// PendingActive
				if (value.IsPendingActiveNull)
					AddParameter(cmd, "PendingActive", DBNull.Value);
				else
					AddParameter(cmd, "PendingActive", (object)(value.PendingActive));
				
					// PendingActiveDate
				if (value.IsPendingActiveDateNull)
					AddParameter(cmd, "PendingActiveDate", DBNull.Value);
				else
					AddParameter(cmd, "PendingActiveDate", (object)(value.PendingActiveDate));
				
					// ProduceInfoStaff
				if (value.IsProduceInfoStaffNull)
					AddParameter(cmd, "ProduceInfoStaff", DBNull.Value);
				else
					AddParameter(cmd, "ProduceInfoStaff", (object)(value.ProduceInfoStaff));
				
					// ProduceInfo
				if (value.IsProduceInfoNull)
					AddParameter(cmd, "ProduceInfo", DBNull.Value);
				else
					AddParameter(cmd, "ProduceInfo", (object)(value.ProduceInfo));
				
					// ProduceInfoDisplay
				if (value.IsProduceInfoDisplayNull)
					AddParameter(cmd, "ProduceInfoDisplay", DBNull.Value);
				else
					AddParameter(cmd, "ProduceInfoDisplay", (object)(value.ProduceInfoDisplay));
				
					// ProduceInfoEditDate
				if (value.IsProduceInfoEditDateNull)
					AddParameter(cmd, "ProduceInfoEditDate", DBNull.Value);
				else
					AddParameter(cmd, "ProduceInfoEditDate", (object)(value.ProduceInfoEditDate));
				
					// QualityInfo
				if (value.IsQualityInfoNull)
					AddParameter(cmd, "QualityInfo", DBNull.Value);
				else
					AddParameter(cmd, "QualityInfo", (object)(value.QualityInfo));
				
					// QualityInfoDisplay
				if (value.IsQualityInfoDisplayNull)
					AddParameter(cmd, "QualityInfoDisplay", DBNull.Value);
				else
					AddParameter(cmd, "QualityInfoDisplay", (object)(value.QualityInfoDisplay));
				
					// QualityInfoEditDate
				if (value.IsQualityInfoEditDateNull)
					AddParameter(cmd, "QualityInfoEditDate", DBNull.Value);
				else
					AddParameter(cmd, "QualityInfoEditDate", (object)(value.QualityInfoEditDate));
				
					// DeliveryInfo
				if (value.IsDeliveryInfoNull)
					AddParameter(cmd, "DeliveryInfo", DBNull.Value);
				else
					AddParameter(cmd, "DeliveryInfo", (object)(value.DeliveryInfo));
				
					// DeliveryInfoEditDate
				if (value.IsDeliveryInfoEditDateNull)
					AddParameter(cmd, "DeliveryInfoEditDate", DBNull.Value);
				else
					AddParameter(cmd, "DeliveryInfoEditDate", (object)(value.DeliveryInfoEditDate));
				
					// StoreInfo
				if (value.IsStoreInfoNull)
					AddParameter(cmd, "StoreInfo", DBNull.Value);
				else
					AddParameter(cmd, "StoreInfo", (object)(value.StoreInfo));
				
					// StoreInfoDisplay
				if (value.IsStoreInfoDisplayNull)
					AddParameter(cmd, "StoreInfoDisplay", DBNull.Value);
				else
					AddParameter(cmd, "StoreInfoDisplay", (object)(value.StoreInfoDisplay));
				
					// StoreInfoEditDate
				if (value.IsStoreInfoEditDateNull)
					AddParameter(cmd, "StoreInfoEditDate", DBNull.Value);
				else
					AddParameter(cmd, "StoreInfoEditDate", (object)(value.StoreInfoEditDate));
				
					// Warehouse_ID
				if (value.IsWarehouse_IDNull)
					AddParameter(cmd, "Warehouse_ID", DBNull.Value);
				else
					AddParameter(cmd, "Warehouse_ID", (object)(value.Warehouse_ID));
				
					// CustomerInfo
				if (value.IsCustomerInfoNull)
					AddParameter(cmd, "CustomerInfo", DBNull.Value);
				else
					AddParameter(cmd, "CustomerInfo", (object)(value.CustomerInfo));
				
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
				
					// StampDate
				if (value.IsStampDateNull)
					AddParameter(cmd, "StampDate", DBNull.Value);
				else
					AddParameter(cmd, "StampDate", (object)(value.StampDate));
				
					// ShippingDate
				if (value.IsShippingDateNull)
					AddParameter(cmd, "ShippingDate", DBNull.Value);
				else
					AddParameter(cmd, "ShippingDate", (object)(value.ShippingDate));
				
					// ShippingNote
				if (value.IsShippingNoteNull)
					AddParameter(cmd, "ShippingNote", DBNull.Value);
				else
					AddParameter(cmd, "ShippingNote", (object)(value.ShippingNote));
				
					// ProductName_En
				if (value.IsProductName_EnNull)
					AddParameter(cmd, "ProductName_En", DBNull.Value);
				else
					AddParameter(cmd, "ProductName_En", (object)(value.ProductName_En));
				
					// Description_En
				if (value.IsDescription_EnNull)
					AddParameter(cmd, "Description_En", DBNull.Value);
				else
					AddParameter(cmd, "Description_En", (object)(value.Description_En));
				
					// ProfileQRCode_En
				if (value.IsProfileQRCode_EnNull)
					AddParameter(cmd, "ProfileQRCode_En", DBNull.Value);
				else
					AddParameter(cmd, "ProfileQRCode_En", (object)(value.ProfileQRCode_En));
				
					// ProduceInfo_En
				if (value.IsProduceInfo_EnNull)
					AddParameter(cmd, "ProduceInfo_En", DBNull.Value);
				else
					AddParameter(cmd, "ProduceInfo_En", (object)(value.ProduceInfo_En));
				
					// QualityInfo_En
				if (value.IsQualityInfo_EnNull)
					AddParameter(cmd, "QualityInfo_En", DBNull.Value);
				else
					AddParameter(cmd, "QualityInfo_En", (object)(value.QualityInfo_En));
				
					// DeliveryInfo_En
				if (value.IsDeliveryInfo_EnNull)
					AddParameter(cmd, "DeliveryInfo_En", DBNull.Value);
				else
					AddParameter(cmd, "DeliveryInfo_En", (object)(value.DeliveryInfo_En));
				
					// StoreInfo_En
				if (value.IsStoreInfo_EnNull)
					AddParameter(cmd, "StoreInfo_En", DBNull.Value);
				else
					AddParameter(cmd, "StoreInfo_En", (object)(value.StoreInfo_En));
				
					// CustomerInfo_En
				if (value.IsCustomerInfo_EnNull)
					AddParameter(cmd, "CustomerInfo_En", DBNull.Value);
				else
					AddParameter(cmd, "CustomerInfo_En", (object)(value.CustomerInfo_En));
				
					// ShippingNote_En
				if (value.IsShippingNote_EnNull)
					AddParameter(cmd, "ShippingNote_En", DBNull.Value);
				else
					AddParameter(cmd, "ShippingNote_En", (object)(value.ShippingNote_En));
				
					// ProductName_Cn
				if (value.IsProductName_CnNull)
					AddParameter(cmd, "ProductName_Cn", DBNull.Value);
				else
					AddParameter(cmd, "ProductName_Cn", (object)(value.ProductName_Cn));
				
					// Description_Cn
				if (value.IsDescription_CnNull)
					AddParameter(cmd, "Description_Cn", DBNull.Value);
				else
					AddParameter(cmd, "Description_Cn", (object)(value.Description_Cn));
				
					// ProfileQRCode_Cn
				if (value.IsProfileQRCode_CnNull)
					AddParameter(cmd, "ProfileQRCode_Cn", DBNull.Value);
				else
					AddParameter(cmd, "ProfileQRCode_Cn", (object)(value.ProfileQRCode_Cn));
				
					// ProduceInfo_Cn
				if (value.IsProduceInfo_CnNull)
					AddParameter(cmd, "ProduceInfo_Cn", DBNull.Value);
				else
					AddParameter(cmd, "ProduceInfo_Cn", (object)(value.ProduceInfo_Cn));
				
					// QualityInfo_Cn
				if (value.IsQualityInfo_CnNull)
					AddParameter(cmd, "QualityInfo_Cn", DBNull.Value);
				else
					AddParameter(cmd, "QualityInfo_Cn", (object)(value.QualityInfo_Cn));
				
					// DeliveryInfo_Cn
				if (value.IsDeliveryInfo_CnNull)
					AddParameter(cmd, "DeliveryInfo_Cn", DBNull.Value);
				else
					AddParameter(cmd, "DeliveryInfo_Cn", (object)(value.DeliveryInfo_Cn));
				
					// StoreInfo_Cn
				if (value.IsStoreInfo_CnNull)
					AddParameter(cmd, "StoreInfo_Cn", DBNull.Value);
				else
					AddParameter(cmd, "StoreInfo_Cn", (object)(value.StoreInfo_Cn));
				
					// CustomerInfo_Cn
				if (value.IsCustomerInfo_CnNull)
					AddParameter(cmd, "CustomerInfo_Cn", DBNull.Value);
				else
					AddParameter(cmd, "CustomerInfo_Cn", (object)(value.CustomerInfo_Cn));
				
					// ShippingNote_Cn
				if (value.IsShippingNote_CnNull)
					AddParameter(cmd, "ShippingNote_Cn", DBNull.Value);
				else
					AddParameter(cmd, "ShippingNote_Cn", (object)(value.ShippingNote_Cn));
				
					// Amount
				if (value.IsAmountNull)
					AddParameter(cmd, "Amount", DBNull.Value);
				else
					AddParameter(cmd, "Amount", (object)(value.Amount));
				
					// AmountUnit
				if (value.IsAmountUnitNull)
					AddParameter(cmd, "AmountUnit", DBNull.Value);
				else
					AddParameter(cmd, "AmountUnit", (object)(value.AmountUnit));
				
					// AmountSum
				if (value.IsAmountSumNull)
					AddParameter(cmd, "AmountSum", DBNull.Value);
				else
					AddParameter(cmd, "AmountSum", (object)(value.AmountSum));
				
					// HarvestDate
				if (value.IsHarvestDateNull)
					AddParameter(cmd, "HarvestDate", DBNull.Value);
				else
					AddParameter(cmd, "HarvestDate", (object)(value.HarvestDate));
				
					// ExpiryByDate
				if (value.IsExpiryByDateNull)
					AddParameter(cmd, "ExpiryByDate", DBNull.Value);
				else
					AddParameter(cmd, "ExpiryByDate", (object)(value.ExpiryByDate));
				
					// FarmCreateBy
				if (value.IsFarmCreateByNull)
					AddParameter(cmd, "FarmCreateBy", DBNull.Value);
				else
					AddParameter(cmd, "FarmCreateBy", (object)(value.FarmCreateBy));
				
					// FarmWorkshop_ID
				if (value.IsFarmWorkshop_IDNull)
					AddParameter(cmd, "FarmWorkshop_ID", DBNull.Value);
				else
					AddParameter(cmd, "FarmWorkshop_ID", (object)(value.FarmWorkshop_ID));
				
					// FarmWorkshopName
				if (value.IsFarmWorkshopNameNull)
					AddParameter(cmd, "FarmWorkshopName", DBNull.Value);
				else
					AddParameter(cmd, "FarmWorkshopName", (object)(value.FarmWorkshopName));
				
					// FarmProducerName
				if (value.IsFarmProducerNameNull)
					AddParameter(cmd, "FarmProducerName", DBNull.Value);
				else
					AddParameter(cmd, "FarmProducerName", (object)(value.FarmProducerName));
				
					// FarmGroupInter_ID
				if (value.IsFarmGroupInter_IDNull)
					AddParameter(cmd, "FarmGroupInter_ID", DBNull.Value);
				else
					AddParameter(cmd, "FarmGroupInter_ID", (object)(value.FarmGroupInter_ID));
				
					// FarmGroupInterName
				if (value.IsFarmGroupInterNameNull)
					AddParameter(cmd, "FarmGroupInterName", DBNull.Value);
				else
					AddParameter(cmd, "FarmGroupInterName", (object)(value.FarmGroupInterName));
				
					// FarmGroup_ID
				if (value.IsFarmGroup_IDNull)
					AddParameter(cmd, "FarmGroup_ID", DBNull.Value);
				else
					AddParameter(cmd, "FarmGroup_ID", (object)(value.FarmGroup_ID));
				
					// FarmGroupName
				if (value.IsFarmGroupNameNull)
					AddParameter(cmd, "FarmGroupName", DBNull.Value);
				else
					AddParameter(cmd, "FarmGroupName", (object)(value.FarmGroupName));
				
					// WEB_UserID_Create
				if (value.IsWEB_UserID_CreateNull)
					AddParameter(cmd, "WEB_UserID_Create", DBNull.Value);
				else
					AddParameter(cmd, "WEB_UserID_Create", (object)(value.WEB_UserID_Create));
				
					// WEB_UserID_Edit
				if (value.IsWEB_UserID_EditNull)
					AddParameter(cmd, "WEB_UserID_Edit", DBNull.Value);
				else
					AddParameter(cmd, "WEB_UserID_Edit", (object)(value.WEB_UserID_Edit));
				
					// NgaySX
				if (value.IsNgaySXNull)
					AddParameter(cmd, "NgaySX", DBNull.Value);
				else
					AddParameter(cmd, "NgaySX", (object)(value.NgaySX));
				
					// NguoiDan
				if (value.IsNguoiDanNull)
					AddParameter(cmd, "NguoiDan", DBNull.Value);
				else
					AddParameter(cmd, "NguoiDan", (object)(value.NguoiDan));
				
					// PhanXuongSX
				if (value.IsPhanXuongSXNull)
					AddParameter(cmd, "PhanXuongSX", DBNull.Value);
				else
					AddParameter(cmd, "PhanXuongSX", (object)(value.PhanXuongSX));
				
					// Department_ID
				if (value.IsDepartment_IDNull)
					AddParameter(cmd, "Department_ID", DBNull.Value);
				else
					AddParameter(cmd, "Department_ID", (object)(value.Department_ID));
				
						AddParameter(cmd, "QRCodeWarehouse_ID", value.QRCodeWarehouse_ID);
						value.QRCodeWarehouse_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["QRCodeWarehouse_ID"]);
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
	/// Deletes the specified object from the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <param name="value">The <see cref="QRCodeWarehouseRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(QRCodeWarehouseRow value)
	{
		return DeleteByPrimaryKey(value.QRCodeWarehouse_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>QRCodeWarehouse</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="QRCodeWarehouse_ID">The <c>QRCodeWarehouse_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int QRCodeWarehouse_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int QRCodeWarehouse_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "QRCodeWarehouse_ID", QRCodeWarehouse_ID);
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
	/// Deletes <c>QRCodeWarehouse</c> records that match the specified criteria.
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
	/// to delete <c>QRCodeWarehouse</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("QRCodeWarehouse_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="QRCodeWarehouseRow"/> objects.</returns>
	protected QRCodeWarehouseRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="QRCodeWarehouseRow"/> objects.</returns>
	protected QRCodeWarehouseRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="QRCodeWarehouseRow"/> objects.</returns>
	protected virtual QRCodeWarehouseRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// QRCodeWarehouse_ID
		int QRCodeWarehouse_IDColumnIndex = reader.GetOrdinal("QRCodeWarehouse_ID");
		// QRCodeWarehouseType_ID
		int QRCodeWarehouseType_IDColumnIndex = reader.GetOrdinal("QRCodeWarehouseType_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Store_ID
		int store_IDColumnIndex = reader.GetOrdinal("Store_ID");
		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// Factory_ID
		int factory_IDColumnIndex = reader.GetOrdinal("Factory_ID");
		// Supplier_ID
		int supplier_IDColumnIndex = reader.GetOrdinal("Supplier_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// ProductName
		int productNameColumnIndex = reader.GetOrdinal("ProductName");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// ProfileQRCode
		int profileQRCodeColumnIndex = reader.GetOrdinal("ProfileQRCode");
		// SoundEnable
		int soundEnableColumnIndex = reader.GetOrdinal("SoundEnable");
		// SMS
		int smsColumnIndex = reader.GetOrdinal("SMS");
		// Prefix
		int prefixColumnIndex = reader.GetOrdinal("Prefix");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");
		// QRCodeStatus_ID
		int qRCodeStatus_IDColumnIndex = reader.GetOrdinal("QRCodeStatus_ID");
		// ViewCount
		int viewCountColumnIndex = reader.GetOrdinal("ViewCount");
		// SellCount
		int sellCountColumnIndex = reader.GetOrdinal("SellCount");
		// QRCodeNumber
		int qRCodeNumberColumnIndex = reader.GetOrdinal("QRCodeNumber");
		// QRCodeUsed
		int qRCodeUsedColumnIndex = reader.GetOrdinal("QRCodeUsed");
		// QRCodeAvailable
		int qRCodeAvailableColumnIndex = reader.GetOrdinal("QRCodeAvailable");
		// SerialNumberStart
		int serialNumberStartColumnIndex = reader.GetOrdinal("SerialNumberStart");
		// SerialNumberEnd
		int serialNumberEndColumnIndex = reader.GetOrdinal("SerialNumberEnd");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// AgencyAssign
		int agencyAssignColumnIndex = reader.GetOrdinal("AgencyAssign");
		// ManufactureDate
		int manufactureDateColumnIndex = reader.GetOrdinal("ManufactureDate");
		// ExpiryDate
		int expiryDateColumnIndex = reader.GetOrdinal("ExpiryDate");
		// WarrantySerial
		int warrantySerialColumnIndex = reader.GetOrdinal("WarrantySerial");
		// WarrantyMonth
		int warrantyMonthColumnIndex = reader.GetOrdinal("WarrantyMonth");
		// WarrantyStartDate
		int warrantyStartDateColumnIndex = reader.GetOrdinal("WarrantyStartDate");
		// WarrantyEndDate
		int warrantyEndDateColumnIndex = reader.GetOrdinal("WarrantyEndDate");
		// UsedName
		int usedNameColumnIndex = reader.GetOrdinal("UsedName");
		// UsedAddress
		int usedAddressColumnIndex = reader.GetOrdinal("UsedAddress");
		// UsedPhone
		int usedPhoneColumnIndex = reader.GetOrdinal("UsedPhone");
		// ActiveDate
		int activeDateColumnIndex = reader.GetOrdinal("ActiveDate");
		// PendingActive
		int pendingActiveColumnIndex = reader.GetOrdinal("PendingActive");
		// PendingActiveDate
		int pendingActiveDateColumnIndex = reader.GetOrdinal("PendingActiveDate");
		// ProduceInfoStaff
		int produceInfoStaffColumnIndex = reader.GetOrdinal("ProduceInfoStaff");
		// ProduceInfo
		int produceInfoColumnIndex = reader.GetOrdinal("ProduceInfo");
		// ProduceInfoDisplay
		int produceInfoDisplayColumnIndex = reader.GetOrdinal("ProduceInfoDisplay");
		// ProduceInfoEditDate
		int produceInfoEditDateColumnIndex = reader.GetOrdinal("ProduceInfoEditDate");
		// QualityInfo
		int qualityInfoColumnIndex = reader.GetOrdinal("QualityInfo");
		// QualityInfoDisplay
		int qualityInfoDisplayColumnIndex = reader.GetOrdinal("QualityInfoDisplay");
		// QualityInfoEditDate
		int qualityInfoEditDateColumnIndex = reader.GetOrdinal("QualityInfoEditDate");
		// DeliveryInfo
		int deliveryInfoColumnIndex = reader.GetOrdinal("DeliveryInfo");
		// DeliveryInfoEditDate
		int deliveryInfoEditDateColumnIndex = reader.GetOrdinal("DeliveryInfoEditDate");
		// StoreInfo
		int storeInfoColumnIndex = reader.GetOrdinal("StoreInfo");
		// StoreInfoDisplay
		int storeInfoDisplayColumnIndex = reader.GetOrdinal("StoreInfoDisplay");
		// StoreInfoEditDate
		int storeInfoEditDateColumnIndex = reader.GetOrdinal("StoreInfoEditDate");
		// Warehouse_ID
		int warehouse_IDColumnIndex = reader.GetOrdinal("Warehouse_ID");
		// CustomerInfo
		int customerInfoColumnIndex = reader.GetOrdinal("CustomerInfo");
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
		// StampDate
		int stampDateColumnIndex = reader.GetOrdinal("StampDate");
		// ShippingDate
		int shippingDateColumnIndex = reader.GetOrdinal("ShippingDate");
		// ShippingNote
		int shippingNoteColumnIndex = reader.GetOrdinal("ShippingNote");
		// ProductName_En
		int productName_EnColumnIndex = reader.GetOrdinal("ProductName_En");
		// Description_En
		int description_EnColumnIndex = reader.GetOrdinal("Description_En");
		// ProfileQRCode_En
		int profileQRCode_EnColumnIndex = reader.GetOrdinal("ProfileQRCode_En");
		// ProduceInfo_En
		int produceInfo_EnColumnIndex = reader.GetOrdinal("ProduceInfo_En");
		// QualityInfo_En
		int qualityInfo_EnColumnIndex = reader.GetOrdinal("QualityInfo_En");
		// DeliveryInfo_En
		int deliveryInfo_EnColumnIndex = reader.GetOrdinal("DeliveryInfo_En");
		// StoreInfo_En
		int storeInfo_EnColumnIndex = reader.GetOrdinal("StoreInfo_En");
		// CustomerInfo_En
		int customerInfo_EnColumnIndex = reader.GetOrdinal("CustomerInfo_En");
		// ShippingNote_En
		int shippingNote_EnColumnIndex = reader.GetOrdinal("ShippingNote_En");
		// ProductName_Cn
		int productName_CnColumnIndex = reader.GetOrdinal("ProductName_Cn");
		// Description_Cn
		int description_CnColumnIndex = reader.GetOrdinal("Description_Cn");
		// ProfileQRCode_Cn
		int profileQRCode_CnColumnIndex = reader.GetOrdinal("ProfileQRCode_Cn");
		// ProduceInfo_Cn
		int produceInfo_CnColumnIndex = reader.GetOrdinal("ProduceInfo_Cn");
		// QualityInfo_Cn
		int qualityInfo_CnColumnIndex = reader.GetOrdinal("QualityInfo_Cn");
		// DeliveryInfo_Cn
		int deliveryInfo_CnColumnIndex = reader.GetOrdinal("DeliveryInfo_Cn");
		// StoreInfo_Cn
		int storeInfo_CnColumnIndex = reader.GetOrdinal("StoreInfo_Cn");
		// CustomerInfo_Cn
		int customerInfo_CnColumnIndex = reader.GetOrdinal("CustomerInfo_Cn");
		// ShippingNote_Cn
		int shippingNote_CnColumnIndex = reader.GetOrdinal("ShippingNote_Cn");
		// Amount
		int amountColumnIndex = reader.GetOrdinal("Amount");
		// AmountUnit
		int amountUnitColumnIndex = reader.GetOrdinal("AmountUnit");
		// AmountSum
		int amountSumColumnIndex = reader.GetOrdinal("AmountSum");
		// HarvestDate
		int harvestDateColumnIndex = reader.GetOrdinal("HarvestDate");
		// ExpiryByDate
		int expiryByDateColumnIndex = reader.GetOrdinal("ExpiryByDate");
		// FarmCreateBy
		int farmCreateByColumnIndex = reader.GetOrdinal("FarmCreateBy");
		// FarmWorkshop_ID
		int farmWorkshop_IDColumnIndex = reader.GetOrdinal("FarmWorkshop_ID");
		// FarmWorkshopName
		int farmWorkshopNameColumnIndex = reader.GetOrdinal("FarmWorkshopName");
		// FarmProducerName
		int farmProducerNameColumnIndex = reader.GetOrdinal("FarmProducerName");
		// FarmGroupInter_ID
		int farmGroupInter_IDColumnIndex = reader.GetOrdinal("FarmGroupInter_ID");
		// FarmGroupInterName
		int farmGroupInterNameColumnIndex = reader.GetOrdinal("FarmGroupInterName");
		// FarmGroup_ID
		int farmGroup_IDColumnIndex = reader.GetOrdinal("FarmGroup_ID");
		// FarmGroupName
		int farmGroupNameColumnIndex = reader.GetOrdinal("FarmGroupName");
		// WEB_UserID_Create
		int wEB_UserID_CreateColumnIndex = reader.GetOrdinal("WEB_UserID_Create");
		// WEB_UserID_Edit
		int wEB_UserID_EditColumnIndex = reader.GetOrdinal("WEB_UserID_Edit");
		// NgaySX
		int ngaySXColumnIndex = reader.GetOrdinal("NgaySX");
		// NguoiDan
		int nguoiDanColumnIndex = reader.GetOrdinal("NguoiDan");
		// PhanXuongSX
		int phanXuongSXColumnIndex = reader.GetOrdinal("PhanXuongSX");
		// Department_ID
		int department_IDColumnIndex = reader.GetOrdinal("Department_ID");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				QRCodeWarehouseRow record = new QRCodeWarehouseRow();
				recordList.Add(record);

					record.QRCodeWarehouse_ID = Convert.ToInt32(reader.GetValue(QRCodeWarehouse_IDColumnIndex));
					if(!reader.IsDBNull(QRCodeWarehouseType_IDColumnIndex))
						record.QRCodeWarehouseType_ID = Convert.ToInt32(reader.GetValue(QRCodeWarehouseType_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(store_IDColumnIndex))
						record.Store_ID = Convert.ToInt32(reader.GetValue(store_IDColumnIndex));
					if(!reader.IsDBNull(productPackage_IDColumnIndex))
						record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(factory_IDColumnIndex))
						record.Factory_ID = Convert.ToInt32(reader.GetValue(factory_IDColumnIndex));
					if(!reader.IsDBNull(supplier_IDColumnIndex))
						record.Supplier_ID = Convert.ToInt32(reader.GetValue(supplier_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(productNameColumnIndex))
						record.ProductName = Convert.ToString(reader.GetValue(productNameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(profileQRCodeColumnIndex))
						record.ProfileQRCode = Convert.ToString(reader.GetValue(profileQRCodeColumnIndex));
					if(!reader.IsDBNull(soundEnableColumnIndex))
						record.SoundEnable = Convert.ToBoolean(reader.GetValue(soundEnableColumnIndex));
					if(!reader.IsDBNull(smsColumnIndex))
						record.SMS = Convert.ToBoolean(reader.GetValue(smsColumnIndex));
					if(!reader.IsDBNull(prefixColumnIndex))
						record.Prefix = Convert.ToString(reader.GetValue(prefixColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));
					if(!reader.IsDBNull(qRCodeStatus_IDColumnIndex))
						record.QRCodeStatus_ID = Convert.ToInt32(reader.GetValue(qRCodeStatus_IDColumnIndex));
					if(!reader.IsDBNull(viewCountColumnIndex))
						record.ViewCount = Convert.ToInt32(reader.GetValue(viewCountColumnIndex));
					if(!reader.IsDBNull(sellCountColumnIndex))
						record.SellCount = Convert.ToInt32(reader.GetValue(sellCountColumnIndex));
					if(!reader.IsDBNull(qRCodeNumberColumnIndex))
						record.QRCodeNumber = Convert.ToInt32(reader.GetValue(qRCodeNumberColumnIndex));
					if(!reader.IsDBNull(qRCodeUsedColumnIndex))
						record.QRCodeUsed = Convert.ToInt32(reader.GetValue(qRCodeUsedColumnIndex));
					if(!reader.IsDBNull(qRCodeAvailableColumnIndex))
						record.QRCodeAvailable = Convert.ToInt32(reader.GetValue(qRCodeAvailableColumnIndex));
					if(!reader.IsDBNull(serialNumberStartColumnIndex))
						record.SerialNumberStart = Convert.ToString(reader.GetValue(serialNumberStartColumnIndex));
					if(!reader.IsDBNull(serialNumberEndColumnIndex))
						record.SerialNumberEnd = Convert.ToString(reader.GetValue(serialNumberEndColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(agencyAssignColumnIndex))
						record.AgencyAssign = reader.GetGuid(agencyAssignColumnIndex);
					if(!reader.IsDBNull(manufactureDateColumnIndex))
						record.ManufactureDate = Convert.ToDateTime(reader.GetValue(manufactureDateColumnIndex));
					if(!reader.IsDBNull(expiryDateColumnIndex))
						record.ExpiryDate = Convert.ToDateTime(reader.GetValue(expiryDateColumnIndex));
					if(!reader.IsDBNull(warrantySerialColumnIndex))
						record.WarrantySerial = Convert.ToString(reader.GetValue(warrantySerialColumnIndex));
					if(!reader.IsDBNull(warrantyMonthColumnIndex))
						record.WarrantyMonth = Convert.ToInt32(reader.GetValue(warrantyMonthColumnIndex));
					if(!reader.IsDBNull(warrantyStartDateColumnIndex))
						record.WarrantyStartDate = Convert.ToDateTime(reader.GetValue(warrantyStartDateColumnIndex));
					if(!reader.IsDBNull(warrantyEndDateColumnIndex))
						record.WarrantyEndDate = Convert.ToDateTime(reader.GetValue(warrantyEndDateColumnIndex));
					if(!reader.IsDBNull(usedNameColumnIndex))
						record.UsedName = Convert.ToString(reader.GetValue(usedNameColumnIndex));
					if(!reader.IsDBNull(usedAddressColumnIndex))
						record.UsedAddress = Convert.ToString(reader.GetValue(usedAddressColumnIndex));
					if(!reader.IsDBNull(usedPhoneColumnIndex))
						record.UsedPhone = Convert.ToString(reader.GetValue(usedPhoneColumnIndex));
					if(!reader.IsDBNull(activeDateColumnIndex))
						record.ActiveDate = Convert.ToDateTime(reader.GetValue(activeDateColumnIndex));
					if(!reader.IsDBNull(pendingActiveColumnIndex))
						record.PendingActive = Convert.ToBoolean(reader.GetValue(pendingActiveColumnIndex));
					if(!reader.IsDBNull(pendingActiveDateColumnIndex))
						record.PendingActiveDate = Convert.ToDateTime(reader.GetValue(pendingActiveDateColumnIndex));
					if(!reader.IsDBNull(produceInfoStaffColumnIndex))
						record.ProduceInfoStaff = Convert.ToString(reader.GetValue(produceInfoStaffColumnIndex));
					if(!reader.IsDBNull(produceInfoColumnIndex))
						record.ProduceInfo = Convert.ToString(reader.GetValue(produceInfoColumnIndex));
					if(!reader.IsDBNull(produceInfoDisplayColumnIndex))
						record.ProduceInfoDisplay = Convert.ToBoolean(reader.GetValue(produceInfoDisplayColumnIndex));
					if(!reader.IsDBNull(produceInfoEditDateColumnIndex))
						record.ProduceInfoEditDate = Convert.ToDateTime(reader.GetValue(produceInfoEditDateColumnIndex));
					if(!reader.IsDBNull(qualityInfoColumnIndex))
						record.QualityInfo = Convert.ToString(reader.GetValue(qualityInfoColumnIndex));
					if(!reader.IsDBNull(qualityInfoDisplayColumnIndex))
						record.QualityInfoDisplay = Convert.ToBoolean(reader.GetValue(qualityInfoDisplayColumnIndex));
					if(!reader.IsDBNull(qualityInfoEditDateColumnIndex))
						record.QualityInfoEditDate = Convert.ToDateTime(reader.GetValue(qualityInfoEditDateColumnIndex));
					if(!reader.IsDBNull(deliveryInfoColumnIndex))
						record.DeliveryInfo = Convert.ToString(reader.GetValue(deliveryInfoColumnIndex));
					if(!reader.IsDBNull(deliveryInfoEditDateColumnIndex))
						record.DeliveryInfoEditDate = Convert.ToDateTime(reader.GetValue(deliveryInfoEditDateColumnIndex));
					if(!reader.IsDBNull(storeInfoColumnIndex))
						record.StoreInfo = Convert.ToString(reader.GetValue(storeInfoColumnIndex));
					if(!reader.IsDBNull(storeInfoDisplayColumnIndex))
						record.StoreInfoDisplay = Convert.ToBoolean(reader.GetValue(storeInfoDisplayColumnIndex));
					if(!reader.IsDBNull(storeInfoEditDateColumnIndex))
						record.StoreInfoEditDate = Convert.ToDateTime(reader.GetValue(storeInfoEditDateColumnIndex));
					if(!reader.IsDBNull(warehouse_IDColumnIndex))
						record.Warehouse_ID = Convert.ToInt32(reader.GetValue(warehouse_IDColumnIndex));
					if(!reader.IsDBNull(customerInfoColumnIndex))
						record.CustomerInfo = Convert.ToString(reader.GetValue(customerInfoColumnIndex));
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
					if(!reader.IsDBNull(stampDateColumnIndex))
						record.StampDate = Convert.ToDateTime(reader.GetValue(stampDateColumnIndex));
					if(!reader.IsDBNull(shippingDateColumnIndex))
						record.ShippingDate = Convert.ToDateTime(reader.GetValue(shippingDateColumnIndex));
					if(!reader.IsDBNull(shippingNoteColumnIndex))
						record.ShippingNote = Convert.ToString(reader.GetValue(shippingNoteColumnIndex));
					if(!reader.IsDBNull(productName_EnColumnIndex))
						record.ProductName_En = Convert.ToString(reader.GetValue(productName_EnColumnIndex));
					if(!reader.IsDBNull(description_EnColumnIndex))
						record.Description_En = Convert.ToString(reader.GetValue(description_EnColumnIndex));
					if(!reader.IsDBNull(profileQRCode_EnColumnIndex))
						record.ProfileQRCode_En = Convert.ToString(reader.GetValue(profileQRCode_EnColumnIndex));
					if(!reader.IsDBNull(produceInfo_EnColumnIndex))
						record.ProduceInfo_En = Convert.ToString(reader.GetValue(produceInfo_EnColumnIndex));
					if(!reader.IsDBNull(qualityInfo_EnColumnIndex))
						record.QualityInfo_En = Convert.ToString(reader.GetValue(qualityInfo_EnColumnIndex));
					if(!reader.IsDBNull(deliveryInfo_EnColumnIndex))
						record.DeliveryInfo_En = Convert.ToString(reader.GetValue(deliveryInfo_EnColumnIndex));
					if(!reader.IsDBNull(storeInfo_EnColumnIndex))
						record.StoreInfo_En = Convert.ToString(reader.GetValue(storeInfo_EnColumnIndex));
					if(!reader.IsDBNull(customerInfo_EnColumnIndex))
						record.CustomerInfo_En = Convert.ToString(reader.GetValue(customerInfo_EnColumnIndex));
					if(!reader.IsDBNull(shippingNote_EnColumnIndex))
						record.ShippingNote_En = Convert.ToString(reader.GetValue(shippingNote_EnColumnIndex));
					if(!reader.IsDBNull(productName_CnColumnIndex))
						record.ProductName_Cn = Convert.ToString(reader.GetValue(productName_CnColumnIndex));
					if(!reader.IsDBNull(description_CnColumnIndex))
						record.Description_Cn = Convert.ToString(reader.GetValue(description_CnColumnIndex));
					if(!reader.IsDBNull(profileQRCode_CnColumnIndex))
						record.ProfileQRCode_Cn = Convert.ToString(reader.GetValue(profileQRCode_CnColumnIndex));
					if(!reader.IsDBNull(produceInfo_CnColumnIndex))
						record.ProduceInfo_Cn = Convert.ToString(reader.GetValue(produceInfo_CnColumnIndex));
					if(!reader.IsDBNull(qualityInfo_CnColumnIndex))
						record.QualityInfo_Cn = Convert.ToString(reader.GetValue(qualityInfo_CnColumnIndex));
					if(!reader.IsDBNull(deliveryInfo_CnColumnIndex))
						record.DeliveryInfo_Cn = Convert.ToString(reader.GetValue(deliveryInfo_CnColumnIndex));
					if(!reader.IsDBNull(storeInfo_CnColumnIndex))
						record.StoreInfo_Cn = Convert.ToString(reader.GetValue(storeInfo_CnColumnIndex));
					if(!reader.IsDBNull(customerInfo_CnColumnIndex))
						record.CustomerInfo_Cn = Convert.ToString(reader.GetValue(customerInfo_CnColumnIndex));
					if(!reader.IsDBNull(shippingNote_CnColumnIndex))
						record.ShippingNote_Cn = Convert.ToString(reader.GetValue(shippingNote_CnColumnIndex));
					if(!reader.IsDBNull(amountColumnIndex))
						record.Amount = Convert.ToInt64(reader.GetValue(amountColumnIndex));
					if(!reader.IsDBNull(amountUnitColumnIndex))
						record.AmountUnit = Convert.ToString(reader.GetValue(amountUnitColumnIndex));
					if(!reader.IsDBNull(amountSumColumnIndex))
						record.AmountSum = Convert.ToInt64(reader.GetValue(amountSumColumnIndex));
					if(!reader.IsDBNull(harvestDateColumnIndex))
						record.HarvestDate = Convert.ToDateTime(reader.GetValue(harvestDateColumnIndex));
					if(!reader.IsDBNull(expiryByDateColumnIndex))
						record.ExpiryByDate = Convert.ToInt32(reader.GetValue(expiryByDateColumnIndex));
					if(!reader.IsDBNull(farmCreateByColumnIndex))
						record.FarmCreateBy = reader.GetGuid(farmCreateByColumnIndex);
					if(!reader.IsDBNull(farmWorkshop_IDColumnIndex))
						record.FarmWorkshop_ID = Convert.ToInt32(reader.GetValue(farmWorkshop_IDColumnIndex));
					if(!reader.IsDBNull(farmWorkshopNameColumnIndex))
						record.FarmWorkshopName = Convert.ToString(reader.GetValue(farmWorkshopNameColumnIndex));
					if(!reader.IsDBNull(farmProducerNameColumnIndex))
						record.FarmProducerName = Convert.ToString(reader.GetValue(farmProducerNameColumnIndex));
					if(!reader.IsDBNull(farmGroupInter_IDColumnIndex))
						record.FarmGroupInter_ID = Convert.ToInt32(reader.GetValue(farmGroupInter_IDColumnIndex));
					if(!reader.IsDBNull(farmGroupInterNameColumnIndex))
						record.FarmGroupInterName = Convert.ToString(reader.GetValue(farmGroupInterNameColumnIndex));
					if(!reader.IsDBNull(farmGroup_IDColumnIndex))
						record.FarmGroup_ID = Convert.ToInt32(reader.GetValue(farmGroup_IDColumnIndex));
					if(!reader.IsDBNull(farmGroupNameColumnIndex))
						record.FarmGroupName = Convert.ToString(reader.GetValue(farmGroupNameColumnIndex));
					if(!reader.IsDBNull(wEB_UserID_CreateColumnIndex))
						record.WEB_UserID_Create = Convert.ToInt32(reader.GetValue(wEB_UserID_CreateColumnIndex));
					if(!reader.IsDBNull(wEB_UserID_EditColumnIndex))
						record.WEB_UserID_Edit = Convert.ToInt32(reader.GetValue(wEB_UserID_EditColumnIndex));
					if(!reader.IsDBNull(ngaySXColumnIndex))
						record.NgaySX = Convert.ToDateTime(reader.GetValue(ngaySXColumnIndex));
					if(!reader.IsDBNull(nguoiDanColumnIndex))
						record.NguoiDan = Convert.ToString(reader.GetValue(nguoiDanColumnIndex));
					if(!reader.IsDBNull(phanXuongSXColumnIndex))
						record.PhanXuongSX = Convert.ToString(reader.GetValue(phanXuongSXColumnIndex));
					if(!reader.IsDBNull(department_IDColumnIndex))
						record.Department_ID = Convert.ToInt32(reader.GetValue(department_IDColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (QRCodeWarehouseRow[])(recordList.ToArray(typeof(QRCodeWarehouseRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="QRCodeWarehouseRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="QRCodeWarehouseRow"/> object.</returns>
	protected virtual QRCodeWarehouseRow MapRow(DataRow row)
	{
		string LOCATION = "QRCodeWarehouseRow MapRow(DataRow row)";
		QRCodeWarehouseRow mappedObject = new QRCodeWarehouseRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "QRCodeWarehouse_ID"
		dataColumn = dataTable.Columns["QRCodeWarehouse_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeWarehouse_ID = (int)(row[dataColumn]);
		// Column "QRCodeWarehouseType_ID"
		dataColumn = dataTable.Columns["QRCodeWarehouseType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeWarehouseType_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Store_ID"
		dataColumn = dataTable.Columns["Store_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Store_ID = (int)(row[dataColumn]);
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
		// Column "Factory_ID"
		dataColumn = dataTable.Columns["Factory_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Factory_ID = (int)(row[dataColumn]);
		// Column "Supplier_ID"
		dataColumn = dataTable.Columns["Supplier_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Supplier_ID = (int)(row[dataColumn]);
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
		// Column "ProfileQRCode"
		dataColumn = dataTable.Columns["ProfileQRCode"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProfileQRCode = (string)(row[dataColumn]);
		// Column "SoundEnable"
		dataColumn = dataTable.Columns["SoundEnable"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SoundEnable = (bool)(row[dataColumn]);
		// Column "SMS"
		dataColumn = dataTable.Columns["SMS"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SMS = (bool)(row[dataColumn]);
		// Column "Prefix"
		dataColumn = dataTable.Columns["Prefix"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Prefix = (string)(row[dataColumn]);
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (bool)(row[dataColumn]);
		// Column "QRCodeStatus_ID"
		dataColumn = dataTable.Columns["QRCodeStatus_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeStatus_ID = (int)(row[dataColumn]);
		// Column "ViewCount"
		dataColumn = dataTable.Columns["ViewCount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ViewCount = (int)(row[dataColumn]);
		// Column "SellCount"
		dataColumn = dataTable.Columns["SellCount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SellCount = (int)(row[dataColumn]);
		// Column "QRCodeNumber"
		dataColumn = dataTable.Columns["QRCodeNumber"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeNumber = (int)(row[dataColumn]);
		// Column "QRCodeUsed"
		dataColumn = dataTable.Columns["QRCodeUsed"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeUsed = (int)(row[dataColumn]);
		// Column "QRCodeAvailable"
		dataColumn = dataTable.Columns["QRCodeAvailable"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QRCodeAvailable = (int)(row[dataColumn]);
		// Column "SerialNumberStart"
		dataColumn = dataTable.Columns["SerialNumberStart"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SerialNumberStart = (string)(row[dataColumn]);
		// Column "SerialNumberEnd"
		dataColumn = dataTable.Columns["SerialNumberEnd"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SerialNumberEnd = (string)(row[dataColumn]);
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
		// Column "AgencyAssign"
		dataColumn = dataTable.Columns["AgencyAssign"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AgencyAssign = (System.Guid)(row[dataColumn]);
		// Column "ManufactureDate"
		dataColumn = dataTable.Columns["ManufactureDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ManufactureDate = (System.DateTime)(row[dataColumn]);
		// Column "ExpiryDate"
		dataColumn = dataTable.Columns["ExpiryDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpiryDate = (System.DateTime)(row[dataColumn]);
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
		// Column "ActiveDate"
		dataColumn = dataTable.Columns["ActiveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ActiveDate = (System.DateTime)(row[dataColumn]);
		// Column "PendingActive"
		dataColumn = dataTable.Columns["PendingActive"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PendingActive = (bool)(row[dataColumn]);
		// Column "PendingActiveDate"
		dataColumn = dataTable.Columns["PendingActiveDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PendingActiveDate = (System.DateTime)(row[dataColumn]);
		// Column "ProduceInfoStaff"
		dataColumn = dataTable.Columns["ProduceInfoStaff"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProduceInfoStaff = (string)(row[dataColumn]);
		// Column "ProduceInfo"
		dataColumn = dataTable.Columns["ProduceInfo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProduceInfo = (string)(row[dataColumn]);
		// Column "ProduceInfoDisplay"
		dataColumn = dataTable.Columns["ProduceInfoDisplay"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProduceInfoDisplay = (bool)(row[dataColumn]);
		// Column "ProduceInfoEditDate"
		dataColumn = dataTable.Columns["ProduceInfoEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProduceInfoEditDate = (System.DateTime)(row[dataColumn]);
		// Column "QualityInfo"
		dataColumn = dataTable.Columns["QualityInfo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityInfo = (string)(row[dataColumn]);
		// Column "QualityInfoDisplay"
		dataColumn = dataTable.Columns["QualityInfoDisplay"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityInfoDisplay = (bool)(row[dataColumn]);
		// Column "QualityInfoEditDate"
		dataColumn = dataTable.Columns["QualityInfoEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityInfoEditDate = (System.DateTime)(row[dataColumn]);
		// Column "DeliveryInfo"
		dataColumn = dataTable.Columns["DeliveryInfo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DeliveryInfo = (string)(row[dataColumn]);
		// Column "DeliveryInfoEditDate"
		dataColumn = dataTable.Columns["DeliveryInfoEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DeliveryInfoEditDate = (System.DateTime)(row[dataColumn]);
		// Column "StoreInfo"
		dataColumn = dataTable.Columns["StoreInfo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreInfo = (string)(row[dataColumn]);
		// Column "StoreInfoDisplay"
		dataColumn = dataTable.Columns["StoreInfoDisplay"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreInfoDisplay = (bool)(row[dataColumn]);
		// Column "StoreInfoEditDate"
		dataColumn = dataTable.Columns["StoreInfoEditDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreInfoEditDate = (System.DateTime)(row[dataColumn]);
		// Column "Warehouse_ID"
		dataColumn = dataTable.Columns["Warehouse_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Warehouse_ID = (int)(row[dataColumn]);
		// Column "CustomerInfo"
		dataColumn = dataTable.Columns["CustomerInfo"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CustomerInfo = (string)(row[dataColumn]);
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
		// Column "StampDate"
		dataColumn = dataTable.Columns["StampDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StampDate = (System.DateTime)(row[dataColumn]);
		// Column "ShippingDate"
		dataColumn = dataTable.Columns["ShippingDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ShippingDate = (System.DateTime)(row[dataColumn]);
		// Column "ShippingNote"
		dataColumn = dataTable.Columns["ShippingNote"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ShippingNote = (string)(row[dataColumn]);
		// Column "ProductName_En"
		dataColumn = dataTable.Columns["ProductName_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductName_En = (string)(row[dataColumn]);
		// Column "Description_En"
		dataColumn = dataTable.Columns["Description_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description_En = (string)(row[dataColumn]);
		// Column "ProfileQRCode_En"
		dataColumn = dataTable.Columns["ProfileQRCode_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProfileQRCode_En = (string)(row[dataColumn]);
		// Column "ProduceInfo_En"
		dataColumn = dataTable.Columns["ProduceInfo_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProduceInfo_En = (string)(row[dataColumn]);
		// Column "QualityInfo_En"
		dataColumn = dataTable.Columns["QualityInfo_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityInfo_En = (string)(row[dataColumn]);
		// Column "DeliveryInfo_En"
		dataColumn = dataTable.Columns["DeliveryInfo_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DeliveryInfo_En = (string)(row[dataColumn]);
		// Column "StoreInfo_En"
		dataColumn = dataTable.Columns["StoreInfo_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreInfo_En = (string)(row[dataColumn]);
		// Column "CustomerInfo_En"
		dataColumn = dataTable.Columns["CustomerInfo_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CustomerInfo_En = (string)(row[dataColumn]);
		// Column "ShippingNote_En"
		dataColumn = dataTable.Columns["ShippingNote_En"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ShippingNote_En = (string)(row[dataColumn]);
		// Column "ProductName_Cn"
		dataColumn = dataTable.Columns["ProductName_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductName_Cn = (string)(row[dataColumn]);
		// Column "Description_Cn"
		dataColumn = dataTable.Columns["Description_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description_Cn = (string)(row[dataColumn]);
		// Column "ProfileQRCode_Cn"
		dataColumn = dataTable.Columns["ProfileQRCode_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProfileQRCode_Cn = (string)(row[dataColumn]);
		// Column "ProduceInfo_Cn"
		dataColumn = dataTable.Columns["ProduceInfo_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProduceInfo_Cn = (string)(row[dataColumn]);
		// Column "QualityInfo_Cn"
		dataColumn = dataTable.Columns["QualityInfo_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.QualityInfo_Cn = (string)(row[dataColumn]);
		// Column "DeliveryInfo_Cn"
		dataColumn = dataTable.Columns["DeliveryInfo_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.DeliveryInfo_Cn = (string)(row[dataColumn]);
		// Column "StoreInfo_Cn"
		dataColumn = dataTable.Columns["StoreInfo_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StoreInfo_Cn = (string)(row[dataColumn]);
		// Column "CustomerInfo_Cn"
		dataColumn = dataTable.Columns["CustomerInfo_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CustomerInfo_Cn = (string)(row[dataColumn]);
		// Column "ShippingNote_Cn"
		dataColumn = dataTable.Columns["ShippingNote_Cn"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ShippingNote_Cn = (string)(row[dataColumn]);
		// Column "Amount"
		dataColumn = dataTable.Columns["Amount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Amount = (long)(row[dataColumn]);
		// Column "AmountUnit"
		dataColumn = dataTable.Columns["AmountUnit"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AmountUnit = (string)(row[dataColumn]);
		// Column "AmountSum"
		dataColumn = dataTable.Columns["AmountSum"];
		if (! row.IsNull(dataColumn) )
			mappedObject.AmountSum = (long)(row[dataColumn]);
		// Column "HarvestDate"
		dataColumn = dataTable.Columns["HarvestDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.HarvestDate = (System.DateTime)(row[dataColumn]);
		// Column "ExpiryByDate"
		dataColumn = dataTable.Columns["ExpiryByDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ExpiryByDate = (int)(row[dataColumn]);
		// Column "FarmCreateBy"
		dataColumn = dataTable.Columns["FarmCreateBy"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmCreateBy = (System.Guid)(row[dataColumn]);
		// Column "FarmWorkshop_ID"
		dataColumn = dataTable.Columns["FarmWorkshop_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmWorkshop_ID = (int)(row[dataColumn]);
		// Column "FarmWorkshopName"
		dataColumn = dataTable.Columns["FarmWorkshopName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmWorkshopName = (string)(row[dataColumn]);
		// Column "FarmProducerName"
		dataColumn = dataTable.Columns["FarmProducerName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmProducerName = (string)(row[dataColumn]);
		// Column "FarmGroupInter_ID"
		dataColumn = dataTable.Columns["FarmGroupInter_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmGroupInter_ID = (int)(row[dataColumn]);
		// Column "FarmGroupInterName"
		dataColumn = dataTable.Columns["FarmGroupInterName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmGroupInterName = (string)(row[dataColumn]);
		// Column "FarmGroup_ID"
		dataColumn = dataTable.Columns["FarmGroup_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmGroup_ID = (int)(row[dataColumn]);
		// Column "FarmGroupName"
		dataColumn = dataTable.Columns["FarmGroupName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.FarmGroupName = (string)(row[dataColumn]);
		// Column "WEB_UserID_Create"
		dataColumn = dataTable.Columns["WEB_UserID_Create"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WEB_UserID_Create = (int)(row[dataColumn]);
		// Column "WEB_UserID_Edit"
		dataColumn = dataTable.Columns["WEB_UserID_Edit"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WEB_UserID_Edit = (int)(row[dataColumn]);
		// Column "NgaySX"
		dataColumn = dataTable.Columns["NgaySX"];
		if (! row.IsNull(dataColumn) )
			mappedObject.NgaySX = (System.DateTime)(row[dataColumn]);
		// Column "NguoiDan"
		dataColumn = dataTable.Columns["NguoiDan"];
		if (! row.IsNull(dataColumn) )
			mappedObject.NguoiDan = (string)(row[dataColumn]);
		// Column "PhanXuongSX"
		dataColumn = dataTable.Columns["PhanXuongSX"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PhanXuongSX = (string)(row[dataColumn]);
		// Column "Department_ID"
		dataColumn = dataTable.Columns["Department_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Department_ID = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>QRCodeWarehouse</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "QRCodeWarehouse";
		DataColumn dataColumn;
		// Create the "QRCodeWarehouse_ID" column
		dataColumn = dataTable.Columns.Add("QRCodeWarehouse_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "QRCodeWarehouseType_ID" column
		dataColumn = dataTable.Columns.Add("QRCodeWarehouseType_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Store_ID" column
		dataColumn = dataTable.Columns.Add("Store_ID", typeof(int));
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
		// Create the "Factory_ID" column
		dataColumn = dataTable.Columns.Add("Factory_ID", typeof(int));
		// Create the "Supplier_ID" column
		dataColumn = dataTable.Columns.Add("Supplier_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductName" column
		dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProfileQRCode" column
		dataColumn = dataTable.Columns.Add("ProfileQRCode", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "SoundEnable" column
		dataColumn = dataTable.Columns.Add("SoundEnable", typeof(bool));
		// Create the "SMS" column
		dataColumn = dataTable.Columns.Add("SMS", typeof(bool));
		// Create the "Prefix" column
		dataColumn = dataTable.Columns.Add("Prefix", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(bool));
		// Create the "QRCodeStatus_ID" column
		dataColumn = dataTable.Columns.Add("QRCodeStatus_ID", typeof(int));
		// Create the "ViewCount" column
		dataColumn = dataTable.Columns.Add("ViewCount", typeof(int));
		// Create the "SellCount" column
		dataColumn = dataTable.Columns.Add("SellCount", typeof(int));
		// Create the "QRCodeNumber" column
		dataColumn = dataTable.Columns.Add("QRCodeNumber", typeof(int));
		// Create the "QRCodeUsed" column
		dataColumn = dataTable.Columns.Add("QRCodeUsed", typeof(int));
		// Create the "QRCodeAvailable" column
		dataColumn = dataTable.Columns.Add("QRCodeAvailable", typeof(int));
		// Create the "SerialNumberStart" column
		dataColumn = dataTable.Columns.Add("SerialNumberStart", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "SerialNumberEnd" column
		dataColumn = dataTable.Columns.Add("SerialNumberEnd", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "AgencyAssign" column
		dataColumn = dataTable.Columns.Add("AgencyAssign", typeof(System.Guid));
		// Create the "ManufactureDate" column
		dataColumn = dataTable.Columns.Add("ManufactureDate", typeof(System.DateTime));
		// Create the "ExpiryDate" column
		dataColumn = dataTable.Columns.Add("ExpiryDate", typeof(System.DateTime));
		// Create the "WarrantySerial" column
		dataColumn = dataTable.Columns.Add("WarrantySerial", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "WarrantyMonth" column
		dataColumn = dataTable.Columns.Add("WarrantyMonth", typeof(int));
		// Create the "WarrantyStartDate" column
		dataColumn = dataTable.Columns.Add("WarrantyStartDate", typeof(System.DateTime));
		// Create the "WarrantyEndDate" column
		dataColumn = dataTable.Columns.Add("WarrantyEndDate", typeof(System.DateTime));
		// Create the "UsedName" column
		dataColumn = dataTable.Columns.Add("UsedName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "UsedAddress" column
		dataColumn = dataTable.Columns.Add("UsedAddress", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "UsedPhone" column
		dataColumn = dataTable.Columns.Add("UsedPhone", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "ActiveDate" column
		dataColumn = dataTable.Columns.Add("ActiveDate", typeof(System.DateTime));
		// Create the "PendingActive" column
		dataColumn = dataTable.Columns.Add("PendingActive", typeof(bool));
		// Create the "PendingActiveDate" column
		dataColumn = dataTable.Columns.Add("PendingActiveDate", typeof(System.DateTime));
		// Create the "ProduceInfoStaff" column
		dataColumn = dataTable.Columns.Add("ProduceInfoStaff", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProduceInfo" column
		dataColumn = dataTable.Columns.Add("ProduceInfo", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProduceInfoDisplay" column
		dataColumn = dataTable.Columns.Add("ProduceInfoDisplay", typeof(bool));
		// Create the "ProduceInfoEditDate" column
		dataColumn = dataTable.Columns.Add("ProduceInfoEditDate", typeof(System.DateTime));
		// Create the "QualityInfo" column
		dataColumn = dataTable.Columns.Add("QualityInfo", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "QualityInfoDisplay" column
		dataColumn = dataTable.Columns.Add("QualityInfoDisplay", typeof(bool));
		// Create the "QualityInfoEditDate" column
		dataColumn = dataTable.Columns.Add("QualityInfoEditDate", typeof(System.DateTime));
		// Create the "DeliveryInfo" column
		dataColumn = dataTable.Columns.Add("DeliveryInfo", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "DeliveryInfoEditDate" column
		dataColumn = dataTable.Columns.Add("DeliveryInfoEditDate", typeof(System.DateTime));
		// Create the "StoreInfo" column
		dataColumn = dataTable.Columns.Add("StoreInfo", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "StoreInfoDisplay" column
		dataColumn = dataTable.Columns.Add("StoreInfoDisplay", typeof(bool));
		// Create the "StoreInfoEditDate" column
		dataColumn = dataTable.Columns.Add("StoreInfoEditDate", typeof(System.DateTime));
		// Create the "Warehouse_ID" column
		dataColumn = dataTable.Columns.Add("Warehouse_ID", typeof(int));
		// Create the "CustomerInfo" column
		dataColumn = dataTable.Columns.Add("CustomerInfo", typeof(string));
		dataColumn.MaxLength = 1073741823;
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
		// Create the "StampDate" column
		dataColumn = dataTable.Columns.Add("StampDate", typeof(System.DateTime));
		// Create the "ShippingDate" column
		dataColumn = dataTable.Columns.Add("ShippingDate", typeof(System.DateTime));
		// Create the "ShippingNote" column
		dataColumn = dataTable.Columns.Add("ShippingNote", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "ProductName_En" column
		dataColumn = dataTable.Columns.Add("ProductName_En", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description_En" column
		dataColumn = dataTable.Columns.Add("Description_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProfileQRCode_En" column
		dataColumn = dataTable.Columns.Add("ProfileQRCode_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProduceInfo_En" column
		dataColumn = dataTable.Columns.Add("ProduceInfo_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "QualityInfo_En" column
		dataColumn = dataTable.Columns.Add("QualityInfo_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "DeliveryInfo_En" column
		dataColumn = dataTable.Columns.Add("DeliveryInfo_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "StoreInfo_En" column
		dataColumn = dataTable.Columns.Add("StoreInfo_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "CustomerInfo_En" column
		dataColumn = dataTable.Columns.Add("CustomerInfo_En", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ShippingNote_En" column
		dataColumn = dataTable.Columns.Add("ShippingNote_En", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "ProductName_Cn" column
		dataColumn = dataTable.Columns.Add("ProductName_Cn", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description_Cn" column
		dataColumn = dataTable.Columns.Add("Description_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProfileQRCode_Cn" column
		dataColumn = dataTable.Columns.Add("ProfileQRCode_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ProduceInfo_Cn" column
		dataColumn = dataTable.Columns.Add("ProduceInfo_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "QualityInfo_Cn" column
		dataColumn = dataTable.Columns.Add("QualityInfo_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "DeliveryInfo_Cn" column
		dataColumn = dataTable.Columns.Add("DeliveryInfo_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "StoreInfo_Cn" column
		dataColumn = dataTable.Columns.Add("StoreInfo_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "CustomerInfo_Cn" column
		dataColumn = dataTable.Columns.Add("CustomerInfo_Cn", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "ShippingNote_Cn" column
		dataColumn = dataTable.Columns.Add("ShippingNote_Cn", typeof(string));
		dataColumn.MaxLength = 4000;
		// Create the "Amount" column
		dataColumn = dataTable.Columns.Add("Amount", typeof(long));
		// Create the "AmountUnit" column
		dataColumn = dataTable.Columns.Add("AmountUnit", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "AmountSum" column
		dataColumn = dataTable.Columns.Add("AmountSum", typeof(long));
		// Create the "HarvestDate" column
		dataColumn = dataTable.Columns.Add("HarvestDate", typeof(System.DateTime));
		// Create the "ExpiryByDate" column
		dataColumn = dataTable.Columns.Add("ExpiryByDate", typeof(int));
		// Create the "FarmCreateBy" column
		dataColumn = dataTable.Columns.Add("FarmCreateBy", typeof(System.Guid));
		// Create the "FarmWorkshop_ID" column
		dataColumn = dataTable.Columns.Add("FarmWorkshop_ID", typeof(int));
		// Create the "FarmWorkshopName" column
		dataColumn = dataTable.Columns.Add("FarmWorkshopName", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "FarmProducerName" column
		dataColumn = dataTable.Columns.Add("FarmProducerName", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "FarmGroupInter_ID" column
		dataColumn = dataTable.Columns.Add("FarmGroupInter_ID", typeof(int));
		// Create the "FarmGroupInterName" column
		dataColumn = dataTable.Columns.Add("FarmGroupInterName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "FarmGroup_ID" column
		dataColumn = dataTable.Columns.Add("FarmGroup_ID", typeof(int));
		// Create the "FarmGroupName" column
		dataColumn = dataTable.Columns.Add("FarmGroupName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "WEB_UserID_Create" column
		dataColumn = dataTable.Columns.Add("WEB_UserID_Create", typeof(int));
		// Create the "WEB_UserID_Edit" column
		dataColumn = dataTable.Columns.Add("WEB_UserID_Edit", typeof(int));
		// Create the "NgaySX" column
		dataColumn = dataTable.Columns.Add("NgaySX", typeof(System.DateTime));
		// Create the "NguoiDan" column
		dataColumn = dataTable.Columns.Add("NguoiDan", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "PhanXuongSX" column
		dataColumn = dataTable.Columns.Add("PhanXuongSX", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Department_ID" column
		dataColumn = dataTable.Columns.Add("Department_ID", typeof(int));
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
			case "QRCodeWarehouse_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "QRCodeWarehouseType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Store_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Factory_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Supplier_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
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

			case "ProfileQRCode":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SoundEnable":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "SMS":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "Prefix":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "QRCodeStatus_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ViewCount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SellCount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "QRCodeNumber":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "QRCodeUsed":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "QRCodeAvailable":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "SerialNumberStart":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SerialNumberEnd":
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

			case "AgencyAssign":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "ManufactureDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ExpiryDate":
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

			case "UsedName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UsedPhone":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ActiveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "PendingActive":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "PendingActiveDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ProduceInfoStaff":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProduceInfo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProduceInfoDisplay":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "ProduceInfoEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "QualityInfo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityInfoDisplay":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "QualityInfoEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "DeliveryInfo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DeliveryInfoEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "StoreInfo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StoreInfoDisplay":
				parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
				break;

			case "StoreInfoEditDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "Warehouse_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "CustomerInfo":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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

			case "StampDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ShippingDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ShippingNote":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductName_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProfileQRCode_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProduceInfo_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityInfo_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DeliveryInfo_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StoreInfo_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CustomerInfo_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ShippingNote_En":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductName_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProfileQRCode_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProduceInfo_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "QualityInfo_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "DeliveryInfo_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StoreInfo_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CustomerInfo_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ShippingNote_Cn":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Amount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
				break;

			case "AmountUnit":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "AmountSum":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
				break;

			case "HarvestDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "ExpiryByDate":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FarmCreateBy":
				parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
				break;

			case "FarmWorkshop_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FarmWorkshopName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "FarmProducerName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "FarmGroupInter_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FarmGroupInterName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "FarmGroup_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "FarmGroupName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "WEB_UserID_Create":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WEB_UserID_Edit":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "NgaySX":
				parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
				break;

			case "NguoiDan":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PhanXuongSX":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Department_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="QRCodeWarehouseRow"/> by the primary key.
	/// </summary>
	/// <param name="QRCodeWarehouse_ID">The <c>QRCodeWarehouse_ID</c> column value.</param>
	/// <returns>An instance of <see cref="QRCodeWarehouseRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int QRCodeWarehouse_ID)
	{
		string LOCATION = "Exist(int QRCodeWarehouse_ID)";
		IDbCommand cmd = _db.CreateCommand("QRCodeWarehouse_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "QRCodeWarehouse_ID", QRCodeWarehouse_ID);
		QRCodeWarehouseRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




