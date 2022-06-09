
// <fileinfo name="Base\WarehouseExportCollectionBase.cs">
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
/// The base class for <see cref="WarehouseExportCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseExportCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseExportCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string WarehouseExport_IDColumnName  = "WarehouseExport_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Warehouse_IDColumnName  = "Warehouse_ID";
	public const string WarehouseExportType_IDColumnName  = "WarehouseExportType_ID";
	public const string Material_IDColumnName  = "Material_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string ProductPackageOrder_IDColumnName  = "ProductPackageOrder_ID";
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string Zone_IDColumnName  = "Zone_ID";
	public const string Area_IDColumnName  = "Area_ID";
	public const string Workshop_IDColumnName  = "Workshop_ID";
	public const string Farm_IDColumnName  = "Farm_ID";
	public const string AmountColumnName  = "Amount";
	public const string DescriptionColumnName  = "Description";
	public const string NameColumnName  = "Name";
	public const string SKUColumnName  = "SKU";
	public const string ExporterColumnName  = "Exporter";
	public const string ImporterColumnName  = "Importer";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string ActiveColumnName  = "Active";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public WarehouseExportCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "WarehouseExport";
	}

	public WarehouseExportCollectionBase() : base()
	{
		this.TABLENAME = "WarehouseExport";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>WarehouseExport</c> table.
	/// </summary>
	/// <returns>An array of <see cref="WarehouseExportRow"/> objects.</returns>
	public virtual WarehouseExportRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>WarehouseExport</c> table.
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
	/// to retrieve all records from the <c>WarehouseExport</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("WarehouseExport_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="WarehouseExportRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="WarehouseExportRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public WarehouseExportRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			WarehouseExportRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="WarehouseExportRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="WarehouseExportRow"/> objects.</returns>
	public WarehouseExportRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="WarehouseExportRow"/> objects that 
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
	/// <returns>An array of <see cref="WarehouseExportRow"/> objects.</returns>
	public virtual WarehouseExportRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			WarehouseExportRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("WarehouseExport_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("WarehouseExport_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="WarehouseExportRow"/> by the primary key.
	/// </summary>
	/// <param name="warehouseExport_ID">The <c>WarehouseExport_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WarehouseExportRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual WarehouseExportRow GetByPrimaryKey(int warehouseExport_ID)
	{
		string LOCATION = "GetByPrimaryKey(int warehouseExport_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("WarehouseExport_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "WarehouseExport_ID", warehouseExport_ID);
			WarehouseExportRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>WarehouseExport</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WarehouseExportRow"/> object to be inserted.</param>
	public virtual void Insert(WarehouseExportRow value)
	{
		string LOCATION = "Insert(WarehouseExportRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WarehouseExport_Insert", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Warehouse_ID
			if (value.IsWarehouse_IDNull)
				AddParameter(cmd, "Warehouse_ID", DBNull.Value);
			else
				AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
			
				// WarehouseExportType_ID
			if (value.IsWarehouseExportType_IDNull)
				AddParameter(cmd, "WarehouseExportType_ID", DBNull.Value);
			else
				AddParameter(cmd, "WarehouseExportType_ID", value.WarehouseExportType_ID);
			
				// Material_ID
			if (value.IsMaterial_IDNull)
				AddParameter(cmd, "Material_ID", DBNull.Value);
			else
				AddParameter(cmd, "Material_ID", value.Material_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// ProductPackageOrder_ID
			if (value.IsProductPackageOrder_IDNull)
				AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
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
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// Name
			if (value.IsNameNull )
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
			
				// SKU
			if (value.IsSKUNull )
				AddParameter(cmd, "SKU", DBNull.Value);
			else
				AddParameter(cmd, "SKU", value.SKU);
			
				// Exporter
			if (value.IsExporterNull )
				AddParameter(cmd, "Exporter", DBNull.Value);
			else
				AddParameter(cmd, "Exporter", value.Exporter);
			
				// Importer
			if (value.IsImporterNull )
				AddParameter(cmd, "Importer", DBNull.Value);
			else
				AddParameter(cmd, "Importer", value.Importer);
			
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
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
						value.WarehouseExport_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>WarehouseExport</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WarehouseExportRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(WarehouseExportRow value)
	{	
		string LOCATION = "Update(WarehouseExportRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WarehouseExport_Update", CommandType.StoredProcedure);
					// ProductBrand_ID
			if (value.IsProductBrand_IDNull)
				AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductBrand_ID", value.ProductBrand_ID);
			
				// Warehouse_ID
			if (value.IsWarehouse_IDNull)
				AddParameter(cmd, "Warehouse_ID", DBNull.Value);
			else
				AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
			
				// WarehouseExportType_ID
			if (value.IsWarehouseExportType_IDNull)
				AddParameter(cmd, "WarehouseExportType_ID", DBNull.Value);
			else
				AddParameter(cmd, "WarehouseExportType_ID", value.WarehouseExportType_ID);
			
				// Material_ID
			if (value.IsMaterial_IDNull)
				AddParameter(cmd, "Material_ID", DBNull.Value);
			else
				AddParameter(cmd, "Material_ID", value.Material_ID);
			
				// Product_ID
			if (value.IsProduct_IDNull)
				AddParameter(cmd, "Product_ID", DBNull.Value);
			else
				AddParameter(cmd, "Product_ID", value.Product_ID);
			
				// ProductPackageOrder_ID
			if (value.IsProductPackageOrder_IDNull)
				AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageOrder_ID", value.ProductPackageOrder_ID);
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
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
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// Name
			if (value.IsNameNull)
				AddParameter(cmd, "Name", DBNull.Value);
			else
				AddParameter(cmd, "Name", value.Name);
				// SKU
			if (value.IsSKUNull)
				AddParameter(cmd, "SKU", DBNull.Value);
			else
				AddParameter(cmd, "SKU", value.SKU);
				// Exporter
			if (value.IsExporterNull)
				AddParameter(cmd, "Exporter", DBNull.Value);
			else
				AddParameter(cmd, "Exporter", value.Exporter);
				// Importer
			if (value.IsImporterNull)
				AddParameter(cmd, "Importer", DBNull.Value);
			else
				AddParameter(cmd, "Importer", value.Importer);
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
			
				// Active
			if (value.IsActiveNull)
				AddParameter(cmd, "Active", DBNull.Value);
			else
				AddParameter(cmd, "Active", value.Active);
			
					AddParameter(cmd, "WarehouseExport_ID", value.WarehouseExport_ID);
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
		/// Inserts or Updates a record in the <c>WarehouseExport</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="WarehouseExportRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(WarehouseExportRow value)
		{
			string LOCATION = "Save(WarehouseExportRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("WarehouseExport_Save",CommandType.StoredProcedure);
					// ProductBrand_ID
				if (value.IsProductBrand_IDNull)
					AddParameter(cmd, "ProductBrand_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductBrand_ID", (object)(value.ProductBrand_ID));
				
					// Warehouse_ID
				if (value.IsWarehouse_IDNull)
					AddParameter(cmd, "Warehouse_ID", DBNull.Value);
				else
					AddParameter(cmd, "Warehouse_ID", (object)(value.Warehouse_ID));
				
					// WarehouseExportType_ID
				if (value.IsWarehouseExportType_IDNull)
					AddParameter(cmd, "WarehouseExportType_ID", DBNull.Value);
				else
					AddParameter(cmd, "WarehouseExportType_ID", (object)(value.WarehouseExportType_ID));
				
					// Material_ID
				if (value.IsMaterial_IDNull)
					AddParameter(cmd, "Material_ID", DBNull.Value);
				else
					AddParameter(cmd, "Material_ID", (object)(value.Material_ID));
				
					// Product_ID
				if (value.IsProduct_IDNull)
					AddParameter(cmd, "Product_ID", DBNull.Value);
				else
					AddParameter(cmd, "Product_ID", (object)(value.Product_ID));
				
					// ProductPackageOrder_ID
				if (value.IsProductPackageOrder_IDNull)
					AddParameter(cmd, "ProductPackageOrder_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackageOrder_ID", (object)(value.ProductPackageOrder_ID));
				
					// ProductPackage_ID
				if (value.IsProductPackage_IDNull)
					AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));
				
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
				
					// Amount
				if (value.IsAmountNull)
					AddParameter(cmd, "Amount", DBNull.Value);
				else
					AddParameter(cmd, "Amount", (object)(value.Amount));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// Name
				if (value.IsNameNull)
					AddParameter(cmd, "Name", DBNull.Value);
				else
					AddParameter(cmd, "Name", (object)(value.Name));
				
					// SKU
				if (value.IsSKUNull)
					AddParameter(cmd, "SKU", DBNull.Value);
				else
					AddParameter(cmd, "SKU", (object)(value.SKU));
				
					// Exporter
				if (value.IsExporterNull)
					AddParameter(cmd, "Exporter", DBNull.Value);
				else
					AddParameter(cmd, "Exporter", (object)(value.Exporter));
				
					// Importer
				if (value.IsImporterNull)
					AddParameter(cmd, "Importer", DBNull.Value);
				else
					AddParameter(cmd, "Importer", (object)(value.Importer));
				
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
				
					// Active
				if (value.IsActiveNull)
					AddParameter(cmd, "Active", DBNull.Value);
				else
					AddParameter(cmd, "Active", (object)(value.Active));
				
						AddParameter(cmd, "WarehouseExport_ID", value.WarehouseExport_ID);
						value.WarehouseExport_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["WarehouseExport_ID"]);
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
	/// Deletes the specified object from the <c>WarehouseExport</c> table.
	/// </summary>
	/// <param name="value">The <see cref="WarehouseExportRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(WarehouseExportRow value)
	{
		return DeleteByPrimaryKey(value.WarehouseExport_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>WarehouseExport</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="warehouseExport_ID">The <c>WarehouseExport_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int warehouseExport_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int warehouseExport_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("WarehouseExport_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "WarehouseExport_ID", warehouseExport_ID);
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
	/// Deletes <c>WarehouseExport</c> records that match the specified criteria.
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
	/// to delete <c>WarehouseExport</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("WarehouseExport_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>WarehouseExport</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("WarehouseExport_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="WarehouseExportRow"/> objects.</returns>
	protected WarehouseExportRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="WarehouseExportRow"/> objects.</returns>
	protected WarehouseExportRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="WarehouseExportRow"/> objects.</returns>
	protected virtual WarehouseExportRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// WarehouseExport_ID
		int warehouseExport_IDColumnIndex = reader.GetOrdinal("WarehouseExport_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Warehouse_ID
		int warehouse_IDColumnIndex = reader.GetOrdinal("Warehouse_ID");
		// WarehouseExportType_ID
		int warehouseExportType_IDColumnIndex = reader.GetOrdinal("WarehouseExportType_ID");
		// Material_ID
		int material_IDColumnIndex = reader.GetOrdinal("Material_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// ProductPackageOrder_ID
		int productPackageOrder_IDColumnIndex = reader.GetOrdinal("ProductPackageOrder_ID");
		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// Zone_ID
		int zone_IDColumnIndex = reader.GetOrdinal("Zone_ID");
		// Area_ID
		int area_IDColumnIndex = reader.GetOrdinal("Area_ID");
		// Workshop_ID
		int workshop_IDColumnIndex = reader.GetOrdinal("Workshop_ID");
		// Farm_ID
		int farm_IDColumnIndex = reader.GetOrdinal("Farm_ID");
		// Amount
		int amountColumnIndex = reader.GetOrdinal("Amount");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// SKU
		int skuColumnIndex = reader.GetOrdinal("SKU");
		// Exporter
		int exporterColumnIndex = reader.GetOrdinal("Exporter");
		// Importer
		int importerColumnIndex = reader.GetOrdinal("Importer");
		// CreateBy
		int createByColumnIndex = reader.GetOrdinal("CreateBy");
		// CreateDate
		int createDateColumnIndex = reader.GetOrdinal("CreateDate");
		// LastEditBy
		int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
		// LastEditDate
		int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");
		// Active
		int activeColumnIndex = reader.GetOrdinal("Active");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				WarehouseExportRow record = new WarehouseExportRow();
				recordList.Add(record);

					record.WarehouseExport_ID = Convert.ToInt32(reader.GetValue(warehouseExport_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(warehouse_IDColumnIndex))
						record.Warehouse_ID = Convert.ToInt32(reader.GetValue(warehouse_IDColumnIndex));
					if(!reader.IsDBNull(warehouseExportType_IDColumnIndex))
						record.WarehouseExportType_ID = Convert.ToInt32(reader.GetValue(warehouseExportType_IDColumnIndex));
					if(!reader.IsDBNull(material_IDColumnIndex))
						record.Material_ID = Convert.ToInt32(reader.GetValue(material_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(productPackageOrder_IDColumnIndex))
						record.ProductPackageOrder_ID = Convert.ToInt32(reader.GetValue(productPackageOrder_IDColumnIndex));
					if(!reader.IsDBNull(productPackage_IDColumnIndex))
						record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(zone_IDColumnIndex))
						record.Zone_ID = Convert.ToInt32(reader.GetValue(zone_IDColumnIndex));
					if(!reader.IsDBNull(area_IDColumnIndex))
						record.Area_ID = Convert.ToInt32(reader.GetValue(area_IDColumnIndex));
					if(!reader.IsDBNull(workshop_IDColumnIndex))
						record.Workshop_ID = Convert.ToInt32(reader.GetValue(workshop_IDColumnIndex));
					if(!reader.IsDBNull(farm_IDColumnIndex))
						record.Farm_ID = Convert.ToInt32(reader.GetValue(farm_IDColumnIndex));
					if(!reader.IsDBNull(amountColumnIndex))
						record.Amount = Convert.ToDecimal(reader.GetValue(amountColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(skuColumnIndex))
						record.SKU = Convert.ToString(reader.GetValue(skuColumnIndex));
					if(!reader.IsDBNull(exporterColumnIndex))
						record.Exporter = Convert.ToString(reader.GetValue(exporterColumnIndex));
					if(!reader.IsDBNull(importerColumnIndex))
						record.Importer = Convert.ToString(reader.GetValue(importerColumnIndex));
					if(!reader.IsDBNull(createByColumnIndex))
						record.CreateBy = reader.GetGuid(createByColumnIndex);
					if(!reader.IsDBNull(createDateColumnIndex))
						record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					if(!reader.IsDBNull(lastEditByColumnIndex))
						record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
					if(!reader.IsDBNull(lastEditDateColumnIndex))
						record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (WarehouseExportRow[])(recordList.ToArray(typeof(WarehouseExportRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseExportRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="WarehouseExportRow"/> object.</returns>
	protected virtual WarehouseExportRow MapRow(DataRow row)
	{
		string LOCATION = "WarehouseExportRow MapRow(DataRow row)";
		WarehouseExportRow mappedObject = new WarehouseExportRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "WarehouseExport_ID"
		dataColumn = dataTable.Columns["WarehouseExport_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarehouseExport_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Warehouse_ID"
		dataColumn = dataTable.Columns["Warehouse_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Warehouse_ID = (int)(row[dataColumn]);
		// Column "WarehouseExportType_ID"
		dataColumn = dataTable.Columns["WarehouseExportType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WarehouseExportType_ID = (int)(row[dataColumn]);
		// Column "Material_ID"
		dataColumn = dataTable.Columns["Material_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Material_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "ProductPackageOrder_ID"
		dataColumn = dataTable.Columns["ProductPackageOrder_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackageOrder_ID = (int)(row[dataColumn]);
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
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
		// Column "Amount"
		dataColumn = dataTable.Columns["Amount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Amount = (decimal)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "SKU"
		dataColumn = dataTable.Columns["SKU"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SKU = (string)(row[dataColumn]);
		// Column "Exporter"
		dataColumn = dataTable.Columns["Exporter"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Exporter = (string)(row[dataColumn]);
		// Column "Importer"
		dataColumn = dataTable.Columns["Importer"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Importer = (string)(row[dataColumn]);
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
		// Column "Active"
		dataColumn = dataTable.Columns["Active"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Active = (int)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>WarehouseExport</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "WarehouseExport";
		DataColumn dataColumn;
		// Create the "WarehouseExport_ID" column
		dataColumn = dataTable.Columns.Add("WarehouseExport_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Warehouse_ID" column
		dataColumn = dataTable.Columns.Add("Warehouse_ID", typeof(int));
		// Create the "WarehouseExportType_ID" column
		dataColumn = dataTable.Columns.Add("WarehouseExportType_ID", typeof(int));
		// Create the "Material_ID" column
		dataColumn = dataTable.Columns.Add("Material_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "ProductPackageOrder_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackageOrder_ID", typeof(int));
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
		// Create the "Zone_ID" column
		dataColumn = dataTable.Columns.Add("Zone_ID", typeof(int));
		// Create the "Area_ID" column
		dataColumn = dataTable.Columns.Add("Area_ID", typeof(int));
		// Create the "Workshop_ID" column
		dataColumn = dataTable.Columns.Add("Workshop_ID", typeof(int));
		// Create the "Farm_ID" column
		dataColumn = dataTable.Columns.Add("Farm_ID", typeof(int));
		// Create the "Amount" column
		dataColumn = dataTable.Columns.Add("Amount", typeof(decimal));
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "SKU" column
		dataColumn = dataTable.Columns.Add("SKU", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Exporter" column
		dataColumn = dataTable.Columns.Add("Exporter", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Importer" column
		dataColumn = dataTable.Columns.Add("Importer", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CreateBy" column
		dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
		// Create the "CreateDate" column
		dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
		// Create the "LastEditBy" column
		dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
		// Create the "LastEditDate" column
		dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
		// Create the "Active" column
		dataColumn = dataTable.Columns.Add("Active", typeof(int));
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
			case "WarehouseExport_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Warehouse_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "WarehouseExportType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Material_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackageOrder_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackage_ID":
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

			case "Amount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "SKU":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Exporter":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Importer":
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

			case "Active":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="WarehouseExportRow"/> by the primary key.
	/// </summary>
	/// <param name="warehouseExport_ID">The <c>WarehouseExport_ID</c> column value.</param>
	/// <returns>An instance of <see cref="WarehouseExportRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int warehouseExport_ID)
	{
		string LOCATION = "Exist(int warehouseExport_ID)";
		IDbCommand cmd = _db.CreateCommand("WarehouseExport_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "WarehouseExport_ID", warehouseExport_ID);
		WarehouseExportRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




