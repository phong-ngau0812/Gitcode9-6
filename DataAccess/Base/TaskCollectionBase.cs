
// <fileinfo name="Base\TaskCollectionBase.cs">
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
/// The base class for <see cref="TaskCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TaskCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TaskCollectionBase
	: Base.ConllectionBase
	
{	
	// Constants
	public const string Task_IDColumnName  = "Task_ID";
	public const string ProductBrand_IDColumnName  = "ProductBrand_ID";
	public const string Product_IDColumnName  = "Product_ID";
	public const string ProductPackage_IDColumnName  = "ProductPackage_ID";
	public const string Workshop_IDColumnName  = "Workshop_ID";
	public const string Farm_IDColumnName  = "Farm_ID";
	public const string Customer_IDColumnName  = "Customer_ID";
	public const string TaskType_IDColumnName  = "TaskType_ID";
	public const string TaskStep_IDColumnName  = "TaskStep_ID";
	public const string TaskStatus_IDColumnName  = "TaskStatus_ID";
	public const string NameColumnName  = "Name";
	public const string ProductNameColumnName  = "ProductName";
	public const string ProductPackageNameColumnName  = "ProductPackageName";
	public const string CustomerNameColumnName  = "CustomerName";
	public const string DescriptionColumnName  = "Description";
	public const string PersonStaffColumnName  = "PersonStaff";
	public const string StartDateColumnName  = "StartDate";
	public const string EndDateColumnName  = "EndDate";
	public const string CreateByColumnName  = "CreateBy";
	public const string CreateDateColumnName  = "CreateDate";
	public const string LastEditByColumnName  = "LastEditBy";
	public const string LastEditDateColumnName  = "LastEditDate";
	public const string WorkEvaluatingColumnName  = "WorkEvaluating";
	public const string LocationColumnName  = "Location";
	public const string BuyerNameColumnName  = "BuyerName";
	public const string UserNameColumnName  = "UserName";
	public const string QuantityColumnName  = "Quantity";
	public const string PriceColumnName  = "Price";
	public const string SumMoneyColumnName  = "SumMoney";
	public const string ShopNameColumnName  = "ShopName";
	public const string ShopAddressColumnName  = "ShopAddress";
	public const string AmountColumnName  = "Amount";
	public const string HarvestDayRemainColumnName  = "HarvestDayRemain";
	public const string HarvestVolumeColumnName  = "HarvestVolume";
	public const string NoteColumnName  = "Note";
	public const string RiskColumnName  = "Risk";
	public const string ImageColumnName  = "Image";
	public const string Staff_IDColumnName  = "Staff_ID";
	public const string Material_IDColumnName  = "Material_ID";
	public const string StartingPointColumnName  = "StartingPoint";
	public const string DestinationColumnName  = "Destination";
	public const string Transporter_IDColumnName  = "Transporter_ID";
	public const string ProductItem_ID_ListColumnName  = "ProductItem_ID_List";
	public const string Warehouse_IDColumnName  = "Warehouse_ID";
	public const string WeatherColumnName  = "Weather";
	public const string CommentColumnName  = "Comment";
	public const string UnitColumnName  = "Unit";
	public const string TaskStepAnswer_ID_ListColumnName  = "TaskStepAnswer_ID_List";

	
    	/// <summary>
    	/// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
    	/// class with the specified <see cref="Database"/>.
    	/// </summary>
    	/// <param name="db">The <see cref="Database"/> object.</param>
	public TaskCollectionBase(Database db) : base(db)
	{
		this.TABLENAME = "Task";
	}

	public TaskCollectionBase() : base()
	{
		this.TABLENAME = "Task";     
	}
	

	
	/// <summary>
	/// Gets an array of all records from the <c>Task</c> table.
	/// </summary>
	/// <returns>An array of <see cref="TaskRow"/> objects.</returns>
	public virtual TaskRow[] GetAll()
	{
		return MapRecords(CreateGetAllCommand());
	}

	/// <summary>
	/// Gets a <see cref="System.Data.DataTable"/> object that 
	/// includes all records from the <c>Task</c> table.
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
	/// to retrieve all records from the <c>Task</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateGetAllCommand()
	{
		string LOCATION = "";
		try
		{
			return _db.CreateCommand("Task_GetAll", CommandType.StoredProcedure);
		}
		catch (Exception ex)
        	{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
        	}
	}

	/// <summary>
	/// Gets the first <see cref="TaskRow"/> objects that 
	/// match the search condition.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>An instance of <see cref="TaskRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public TaskRow GetRow(string whereSql)
	{
		string LOCATION = "GetRow(string whereSql)";
		try
        	{
			int totalRecordCount = -1;
			TaskRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
	/// Gets an array of <see cref="TaskRow"/> objects that 
	/// match the search condition, in the the specified sort order.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. For example: 
	/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
	/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
	/// <returns>An array of <see cref="TaskRow"/> objects.</returns>
	public TaskRow[] GetAsArray(string whereSql, string orderBySql)
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
	/// Gets an array of <see cref="TaskRow"/> objects that 
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
	/// <returns>An array of <see cref="TaskRow"/> objects.</returns>
	public virtual TaskRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		IDataReader reader = null;
		IDbCommand cmd = null;
		try
		{
			cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
			reader = _db.ExecuteReader(cmd);
			TaskRow[] rows = MapRecords(reader);
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
			IDbCommand cmd = _db.CreateCommand("Task_GetAdHoc", CommandType.StoredProcedure);
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
			IDbCommand cmd = _db.CreateCommand("Task_GetPageAdHoc", CommandType.StoredProcedure);
				
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
	/// Gets <see cref="TaskRow"/> by the primary key.
	/// </summary>
	/// <param name="task_ID">The <c>Task_ID</c> column value.</param>
	/// <returns>An instance of <see cref="TaskRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual TaskRow GetByPrimaryKey(int task_ID)
	{
		string LOCATION = "GetByPrimaryKey(int task_ID)";
		try
        	{
			IDbCommand cmd = _db.CreateCommand("Task_GetByPrimaryKey", CommandType.StoredProcedure);
			AddParameter(cmd, "Task_ID", task_ID);
			TaskRow[] tempArray = MapRecords(cmd);
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
	/// Adds a new record into the <c>Task</c> table.
	/// </summary>
	/// <param name="value">The <see cref="TaskRow"/> object to be inserted.</param>
	public virtual void Insert(TaskRow value)
	{
		string LOCATION = "Insert(TaskRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Task_Insert", CommandType.StoredProcedure);
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
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
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
			
				// Customer_ID
			if (value.IsCustomer_IDNull)
				AddParameter(cmd, "Customer_ID", DBNull.Value);
			else
				AddParameter(cmd, "Customer_ID", value.Customer_ID);
			
				// TaskType_ID
			if (value.IsTaskType_IDNull)
				AddParameter(cmd, "TaskType_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskType_ID", value.TaskType_ID);
			
				// TaskStep_ID
			if (value.IsTaskStep_IDNull)
				AddParameter(cmd, "TaskStep_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskStep_ID", value.TaskStep_ID);
			
				// TaskStatus_ID
			if (value.IsTaskStatus_IDNull)
				AddParameter(cmd, "TaskStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskStatus_ID", value.TaskStatus_ID);
			
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
			
				// ProductPackageName
			if (value.IsProductPackageNameNull )
				AddParameter(cmd, "ProductPackageName", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageName", value.ProductPackageName);
			
				// CustomerName
			if (value.IsCustomerNameNull )
				AddParameter(cmd, "CustomerName", DBNull.Value);
			else
				AddParameter(cmd, "CustomerName", value.CustomerName);
			
				// Description
			if (value.IsDescriptionNull )
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
			
				// PersonStaff
			if (value.IsPersonStaffNull )
				AddParameter(cmd, "PersonStaff", DBNull.Value);
			else
				AddParameter(cmd, "PersonStaff", value.PersonStaff);
			
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
			
				// WorkEvaluating
			if (value.IsWorkEvaluatingNull )
				AddParameter(cmd, "WorkEvaluating", DBNull.Value);
			else
				AddParameter(cmd, "WorkEvaluating", value.WorkEvaluating);
			
				// Location
			if (value.IsLocationNull )
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
			
				// BuyerName
			if (value.IsBuyerNameNull )
				AddParameter(cmd, "BuyerName", DBNull.Value);
			else
				AddParameter(cmd, "BuyerName", value.BuyerName);
			
				// UserName
			if (value.IsUserNameNull )
				AddParameter(cmd, "UserName", DBNull.Value);
			else
				AddParameter(cmd, "UserName", value.UserName);
			
				// Quantity
			if (value.IsQuantityNull)
				AddParameter(cmd, "Quantity", DBNull.Value);
			else
				AddParameter(cmd, "Quantity", value.Quantity);
			
				// Price
			if (value.IsPriceNull)
				AddParameter(cmd, "Price", DBNull.Value);
			else
				AddParameter(cmd, "Price", value.Price);
			
				// SumMoney
			if (value.IsSumMoneyNull)
				AddParameter(cmd, "SumMoney", DBNull.Value);
			else
				AddParameter(cmd, "SumMoney", value.SumMoney);
			
				// ShopName
			if (value.IsShopNameNull )
				AddParameter(cmd, "ShopName", DBNull.Value);
			else
				AddParameter(cmd, "ShopName", value.ShopName);
			
				// ShopAddress
			if (value.IsShopAddressNull )
				AddParameter(cmd, "ShopAddress", DBNull.Value);
			else
				AddParameter(cmd, "ShopAddress", value.ShopAddress);
			
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// HarvestDayRemain
			if (value.IsHarvestDayRemainNull)
				AddParameter(cmd, "HarvestDayRemain", DBNull.Value);
			else
				AddParameter(cmd, "HarvestDayRemain", value.HarvestDayRemain);
			
				// HarvestVolume
			if (value.IsHarvestVolumeNull)
				AddParameter(cmd, "HarvestVolume", DBNull.Value);
			else
				AddParameter(cmd, "HarvestVolume", value.HarvestVolume);
			
				// Note
			if (value.IsNoteNull )
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
			
				// Risk
			if (value.IsRiskNull )
				AddParameter(cmd, "Risk", DBNull.Value);
			else
				AddParameter(cmd, "Risk", value.Risk);
			
				// Image
			if (value.IsImageNull )
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
			
				// Staff_ID
			if (value.IsStaff_IDNull )
				AddParameter(cmd, "Staff_ID", DBNull.Value);
			else
				AddParameter(cmd, "Staff_ID", value.Staff_ID);
			
				// Material_ID
			if (value.IsMaterial_IDNull)
				AddParameter(cmd, "Material_ID", DBNull.Value);
			else
				AddParameter(cmd, "Material_ID", value.Material_ID);
			
				// StartingPoint
			if (value.IsStartingPointNull )
				AddParameter(cmd, "StartingPoint", DBNull.Value);
			else
				AddParameter(cmd, "StartingPoint", value.StartingPoint);
			
				// Destination
			if (value.IsDestinationNull )
				AddParameter(cmd, "Destination", DBNull.Value);
			else
				AddParameter(cmd, "Destination", value.Destination);
			
				// Transporter_ID
			if (value.IsTransporter_IDNull)
				AddParameter(cmd, "Transporter_ID", DBNull.Value);
			else
				AddParameter(cmd, "Transporter_ID", value.Transporter_ID);
			
				// ProductItem_ID_List
			if (value.IsProductItem_ID_ListNull )
				AddParameter(cmd, "ProductItem_ID_List", DBNull.Value);
			else
				AddParameter(cmd, "ProductItem_ID_List", value.ProductItem_ID_List);
			
				// Warehouse_ID
			if (value.IsWarehouse_IDNull)
				AddParameter(cmd, "Warehouse_ID", DBNull.Value);
			else
				AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
			
				// Weather
			if (value.IsWeatherNull )
				AddParameter(cmd, "Weather", DBNull.Value);
			else
				AddParameter(cmd, "Weather", value.Weather);
			
				// Comment
			if (value.IsCommentNull )
				AddParameter(cmd, "Comment", DBNull.Value);
			else
				AddParameter(cmd, "Comment", value.Comment);
			
				// Unit
			if (value.IsUnitNull )
				AddParameter(cmd, "Unit", DBNull.Value);
			else
				AddParameter(cmd, "Unit", value.Unit);
			
				// TaskStepAnswer_ID_List
			if (value.IsTaskStepAnswer_ID_ListNull )
				AddParameter(cmd, "TaskStepAnswer_ID_List", DBNull.Value);
			else
				AddParameter(cmd, "TaskStepAnswer_ID_List", value.TaskStepAnswer_ID_List);
			
						value.Task_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
	/// Updates a record in the <c>Task</c> table.
	/// </summary>
	/// <param name="value">The <see cref="TaskRow"/>
	/// object used to update the table record.</param>
	/// <returns>true if the record was updated; otherwise, false.</returns>
	public virtual bool Update(TaskRow value)
	{	
		string LOCATION = "Update(TaskRow value)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Task_Update", CommandType.StoredProcedure);
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
			
				// ProductPackage_ID
			if (value.IsProductPackage_IDNull)
				AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackage_ID", value.ProductPackage_ID);
			
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
			
				// Customer_ID
			if (value.IsCustomer_IDNull)
				AddParameter(cmd, "Customer_ID", DBNull.Value);
			else
				AddParameter(cmd, "Customer_ID", value.Customer_ID);
			
				// TaskType_ID
			if (value.IsTaskType_IDNull)
				AddParameter(cmd, "TaskType_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskType_ID", value.TaskType_ID);
			
				// TaskStep_ID
			if (value.IsTaskStep_IDNull)
				AddParameter(cmd, "TaskStep_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskStep_ID", value.TaskStep_ID);
			
				// TaskStatus_ID
			if (value.IsTaskStatus_IDNull)
				AddParameter(cmd, "TaskStatus_ID", DBNull.Value);
			else
				AddParameter(cmd, "TaskStatus_ID", value.TaskStatus_ID);
			
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
				// ProductPackageName
			if (value.IsProductPackageNameNull)
				AddParameter(cmd, "ProductPackageName", DBNull.Value);
			else
				AddParameter(cmd, "ProductPackageName", value.ProductPackageName);
				// CustomerName
			if (value.IsCustomerNameNull)
				AddParameter(cmd, "CustomerName", DBNull.Value);
			else
				AddParameter(cmd, "CustomerName", value.CustomerName);
				// Description
			if (value.IsDescriptionNull)
				AddParameter(cmd, "Description", DBNull.Value);
			else
				AddParameter(cmd, "Description", value.Description);
				// PersonStaff
			if (value.IsPersonStaffNull)
				AddParameter(cmd, "PersonStaff", DBNull.Value);
			else
				AddParameter(cmd, "PersonStaff", value.PersonStaff);
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
			
				// WorkEvaluating
			if (value.IsWorkEvaluatingNull)
				AddParameter(cmd, "WorkEvaluating", DBNull.Value);
			else
				AddParameter(cmd, "WorkEvaluating", value.WorkEvaluating);
				// Location
			if (value.IsLocationNull)
				AddParameter(cmd, "Location", DBNull.Value);
			else
				AddParameter(cmd, "Location", value.Location);
				// BuyerName
			if (value.IsBuyerNameNull)
				AddParameter(cmd, "BuyerName", DBNull.Value);
			else
				AddParameter(cmd, "BuyerName", value.BuyerName);
				// UserName
			if (value.IsUserNameNull)
				AddParameter(cmd, "UserName", DBNull.Value);
			else
				AddParameter(cmd, "UserName", value.UserName);
				// Quantity
			if (value.IsQuantityNull)
				AddParameter(cmd, "Quantity", DBNull.Value);
			else
				AddParameter(cmd, "Quantity", value.Quantity);
			
				// Price
			if (value.IsPriceNull)
				AddParameter(cmd, "Price", DBNull.Value);
			else
				AddParameter(cmd, "Price", value.Price);
			
				// SumMoney
			if (value.IsSumMoneyNull)
				AddParameter(cmd, "SumMoney", DBNull.Value);
			else
				AddParameter(cmd, "SumMoney", value.SumMoney);
			
				// ShopName
			if (value.IsShopNameNull)
				AddParameter(cmd, "ShopName", DBNull.Value);
			else
				AddParameter(cmd, "ShopName", value.ShopName);
				// ShopAddress
			if (value.IsShopAddressNull)
				AddParameter(cmd, "ShopAddress", DBNull.Value);
			else
				AddParameter(cmd, "ShopAddress", value.ShopAddress);
				// Amount
			if (value.IsAmountNull)
				AddParameter(cmd, "Amount", DBNull.Value);
			else
				AddParameter(cmd, "Amount", value.Amount);
			
				// HarvestDayRemain
			if (value.IsHarvestDayRemainNull)
				AddParameter(cmd, "HarvestDayRemain", DBNull.Value);
			else
				AddParameter(cmd, "HarvestDayRemain", value.HarvestDayRemain);
			
				// HarvestVolume
			if (value.IsHarvestVolumeNull)
				AddParameter(cmd, "HarvestVolume", DBNull.Value);
			else
				AddParameter(cmd, "HarvestVolume", value.HarvestVolume);
			
				// Note
			if (value.IsNoteNull)
				AddParameter(cmd, "Note", DBNull.Value);
			else
				AddParameter(cmd, "Note", value.Note);
				// Risk
			if (value.IsRiskNull)
				AddParameter(cmd, "Risk", DBNull.Value);
			else
				AddParameter(cmd, "Risk", value.Risk);
				// Image
			if (value.IsImageNull)
				AddParameter(cmd, "Image", DBNull.Value);
			else
				AddParameter(cmd, "Image", value.Image);
				// Staff_ID
			if (value.IsStaff_IDNull)
				AddParameter(cmd, "Staff_ID", DBNull.Value);
			else
				AddParameter(cmd, "Staff_ID", value.Staff_ID);
				// Material_ID
			if (value.IsMaterial_IDNull)
				AddParameter(cmd, "Material_ID", DBNull.Value);
			else
				AddParameter(cmd, "Material_ID", value.Material_ID);
			
				// StartingPoint
			if (value.IsStartingPointNull)
				AddParameter(cmd, "StartingPoint", DBNull.Value);
			else
				AddParameter(cmd, "StartingPoint", value.StartingPoint);
				// Destination
			if (value.IsDestinationNull)
				AddParameter(cmd, "Destination", DBNull.Value);
			else
				AddParameter(cmd, "Destination", value.Destination);
				// Transporter_ID
			if (value.IsTransporter_IDNull)
				AddParameter(cmd, "Transporter_ID", DBNull.Value);
			else
				AddParameter(cmd, "Transporter_ID", value.Transporter_ID);
			
				// ProductItem_ID_List
			if (value.IsProductItem_ID_ListNull)
				AddParameter(cmd, "ProductItem_ID_List", DBNull.Value);
			else
				AddParameter(cmd, "ProductItem_ID_List", value.ProductItem_ID_List);
				// Warehouse_ID
			if (value.IsWarehouse_IDNull)
				AddParameter(cmd, "Warehouse_ID", DBNull.Value);
			else
				AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
			
				// Weather
			if (value.IsWeatherNull)
				AddParameter(cmd, "Weather", DBNull.Value);
			else
				AddParameter(cmd, "Weather", value.Weather);
				// Comment
			if (value.IsCommentNull)
				AddParameter(cmd, "Comment", DBNull.Value);
			else
				AddParameter(cmd, "Comment", value.Comment);
				// Unit
			if (value.IsUnitNull)
				AddParameter(cmd, "Unit", DBNull.Value);
			else
				AddParameter(cmd, "Unit", value.Unit);
				// TaskStepAnswer_ID_List
			if (value.IsTaskStepAnswer_ID_ListNull)
				AddParameter(cmd, "TaskStepAnswer_ID_List", DBNull.Value);
			else
				AddParameter(cmd, "TaskStepAnswer_ID_List", value.TaskStepAnswer_ID_List);
					AddParameter(cmd, "Task_ID", value.Task_ID);
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
		/// Inserts or Updates a record in the <c>Task</c> table.
		/// If a row with the specified primary key exists then it is updated
		/// otehrwise, a new row is added.
		/// </summary>
		/// <param name="value">The <see cref="TaskRow"/>
		/// object used to save the table record.</param>
		public virtual void Save(TaskRow value)
		{
			string LOCATION = "Save(TaskRow value)";
			try
			{
					IDbCommand cmd =  _db.CreateCommand("Task_Save",CommandType.StoredProcedure);
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
				
					// ProductPackage_ID
				if (value.IsProductPackage_IDNull)
					AddParameter(cmd, "ProductPackage_ID", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackage_ID", (object)(value.ProductPackage_ID));
				
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
				
					// Customer_ID
				if (value.IsCustomer_IDNull)
					AddParameter(cmd, "Customer_ID", DBNull.Value);
				else
					AddParameter(cmd, "Customer_ID", (object)(value.Customer_ID));
				
					// TaskType_ID
				if (value.IsTaskType_IDNull)
					AddParameter(cmd, "TaskType_ID", DBNull.Value);
				else
					AddParameter(cmd, "TaskType_ID", (object)(value.TaskType_ID));
				
					// TaskStep_ID
				if (value.IsTaskStep_IDNull)
					AddParameter(cmd, "TaskStep_ID", DBNull.Value);
				else
					AddParameter(cmd, "TaskStep_ID", (object)(value.TaskStep_ID));
				
					// TaskStatus_ID
				if (value.IsTaskStatus_IDNull)
					AddParameter(cmd, "TaskStatus_ID", DBNull.Value);
				else
					AddParameter(cmd, "TaskStatus_ID", (object)(value.TaskStatus_ID));
				
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
				
					// ProductPackageName
				if (value.IsProductPackageNameNull)
					AddParameter(cmd, "ProductPackageName", DBNull.Value);
				else
					AddParameter(cmd, "ProductPackageName", (object)(value.ProductPackageName));
				
					// CustomerName
				if (value.IsCustomerNameNull)
					AddParameter(cmd, "CustomerName", DBNull.Value);
				else
					AddParameter(cmd, "CustomerName", (object)(value.CustomerName));
				
					// Description
				if (value.IsDescriptionNull)
					AddParameter(cmd, "Description", DBNull.Value);
				else
					AddParameter(cmd, "Description", (object)(value.Description));
				
					// PersonStaff
				if (value.IsPersonStaffNull)
					AddParameter(cmd, "PersonStaff", DBNull.Value);
				else
					AddParameter(cmd, "PersonStaff", (object)(value.PersonStaff));
				
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
				
					// WorkEvaluating
				if (value.IsWorkEvaluatingNull)
					AddParameter(cmd, "WorkEvaluating", DBNull.Value);
				else
					AddParameter(cmd, "WorkEvaluating", (object)(value.WorkEvaluating));
				
					// Location
				if (value.IsLocationNull)
					AddParameter(cmd, "Location", DBNull.Value);
				else
					AddParameter(cmd, "Location", (object)(value.Location));
				
					// BuyerName
				if (value.IsBuyerNameNull)
					AddParameter(cmd, "BuyerName", DBNull.Value);
				else
					AddParameter(cmd, "BuyerName", (object)(value.BuyerName));
				
					// UserName
				if (value.IsUserNameNull)
					AddParameter(cmd, "UserName", DBNull.Value);
				else
					AddParameter(cmd, "UserName", (object)(value.UserName));
				
					// Quantity
				if (value.IsQuantityNull)
					AddParameter(cmd, "Quantity", DBNull.Value);
				else
					AddParameter(cmd, "Quantity", (object)(value.Quantity));
				
					// Price
				if (value.IsPriceNull)
					AddParameter(cmd, "Price", DBNull.Value);
				else
					AddParameter(cmd, "Price", (object)(value.Price));
				
					// SumMoney
				if (value.IsSumMoneyNull)
					AddParameter(cmd, "SumMoney", DBNull.Value);
				else
					AddParameter(cmd, "SumMoney", (object)(value.SumMoney));
				
					// ShopName
				if (value.IsShopNameNull)
					AddParameter(cmd, "ShopName", DBNull.Value);
				else
					AddParameter(cmd, "ShopName", (object)(value.ShopName));
				
					// ShopAddress
				if (value.IsShopAddressNull)
					AddParameter(cmd, "ShopAddress", DBNull.Value);
				else
					AddParameter(cmd, "ShopAddress", (object)(value.ShopAddress));
				
					// Amount
				if (value.IsAmountNull)
					AddParameter(cmd, "Amount", DBNull.Value);
				else
					AddParameter(cmd, "Amount", (object)(value.Amount));
				
					// HarvestDayRemain
				if (value.IsHarvestDayRemainNull)
					AddParameter(cmd, "HarvestDayRemain", DBNull.Value);
				else
					AddParameter(cmd, "HarvestDayRemain", (object)(value.HarvestDayRemain));
				
					// HarvestVolume
				if (value.IsHarvestVolumeNull)
					AddParameter(cmd, "HarvestVolume", DBNull.Value);
				else
					AddParameter(cmd, "HarvestVolume", (object)(value.HarvestVolume));
				
					// Note
				if (value.IsNoteNull)
					AddParameter(cmd, "Note", DBNull.Value);
				else
					AddParameter(cmd, "Note", (object)(value.Note));
				
					// Risk
				if (value.IsRiskNull)
					AddParameter(cmd, "Risk", DBNull.Value);
				else
					AddParameter(cmd, "Risk", (object)(value.Risk));
				
					// Image
				if (value.IsImageNull)
					AddParameter(cmd, "Image", DBNull.Value);
				else
					AddParameter(cmd, "Image", (object)(value.Image));
				
					// Staff_ID
				if (value.IsStaff_IDNull)
					AddParameter(cmd, "Staff_ID", DBNull.Value);
				else
					AddParameter(cmd, "Staff_ID", (object)(value.Staff_ID));
				
					// Material_ID
				if (value.IsMaterial_IDNull)
					AddParameter(cmd, "Material_ID", DBNull.Value);
				else
					AddParameter(cmd, "Material_ID", (object)(value.Material_ID));
				
					// StartingPoint
				if (value.IsStartingPointNull)
					AddParameter(cmd, "StartingPoint", DBNull.Value);
				else
					AddParameter(cmd, "StartingPoint", (object)(value.StartingPoint));
				
					// Destination
				if (value.IsDestinationNull)
					AddParameter(cmd, "Destination", DBNull.Value);
				else
					AddParameter(cmd, "Destination", (object)(value.Destination));
				
					// Transporter_ID
				if (value.IsTransporter_IDNull)
					AddParameter(cmd, "Transporter_ID", DBNull.Value);
				else
					AddParameter(cmd, "Transporter_ID", (object)(value.Transporter_ID));
				
					// ProductItem_ID_List
				if (value.IsProductItem_ID_ListNull)
					AddParameter(cmd, "ProductItem_ID_List", DBNull.Value);
				else
					AddParameter(cmd, "ProductItem_ID_List", (object)(value.ProductItem_ID_List));
				
					// Warehouse_ID
				if (value.IsWarehouse_IDNull)
					AddParameter(cmd, "Warehouse_ID", DBNull.Value);
				else
					AddParameter(cmd, "Warehouse_ID", (object)(value.Warehouse_ID));
				
					// Weather
				if (value.IsWeatherNull)
					AddParameter(cmd, "Weather", DBNull.Value);
				else
					AddParameter(cmd, "Weather", (object)(value.Weather));
				
					// Comment
				if (value.IsCommentNull)
					AddParameter(cmd, "Comment", DBNull.Value);
				else
					AddParameter(cmd, "Comment", (object)(value.Comment));
				
					// Unit
				if (value.IsUnitNull)
					AddParameter(cmd, "Unit", DBNull.Value);
				else
					AddParameter(cmd, "Unit", (object)(value.Unit));
				
					// TaskStepAnswer_ID_List
				if (value.IsTaskStepAnswer_ID_ListNull)
					AddParameter(cmd, "TaskStepAnswer_ID_List", DBNull.Value);
				else
					AddParameter(cmd, "TaskStepAnswer_ID_List", (object)(value.TaskStepAnswer_ID_List));
				
						AddParameter(cmd, "Task_ID", value.Task_ID);
						value.Task_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
							DeleteByPrimaryKey((int)row["Task_ID"]);
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
	/// Deletes the specified object from the <c>Task</c> table.
	/// </summary>
	/// <param name="value">The <see cref="TaskRow"/> object to delete.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public bool Delete(TaskRow value)
	{
		return DeleteByPrimaryKey(value.Task_ID);
	}

	/// <summary>
	/// Deletes a record from the <c>Task</c> table using
	/// the specified primary key.
	/// </summary>
	/// <param name="task_ID">The <c>Task_ID</c> column value.</param>
	/// <returns>true if the record was deleted; otherwise, false.</returns>
	public virtual bool DeleteByPrimaryKey(int task_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int task_ID)";
		try
		{
				IDbCommand cmd = _db.CreateCommand("Task_DeleteByPrimaryKey", CommandType.StoredProcedure);
					AddParameter(cmd, "Task_ID", task_ID);
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
	/// Deletes <c>Task</c> records that match the specified criteria.
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
	/// to delete <c>Task</c> records that match the specified criteria.
	/// </summary>
	/// <param name="whereSql">The SQL search condition. 
	/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
	/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
	protected virtual IDbCommand CreateDeleteCommand(string whereSql)
	{
		string LOCATION = "CreateDeleteCommand(String whereSql)";
		try
		{
			IDbCommand cmd = _db.CreateCommand("Task_DeleteAdHoc", CommandType.StoredProcedure);
			
			_db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

			return cmd;
		}
		catch(Exception ex)
		{
		      	throw new Exceptions.DatabaseException(LOCATION, ex);
		} 		
	}

	/// <summary>
	/// Deletes all records from the <c>Task</c> table.
	/// </summary>
	/// <returns>The number of deleted records.</returns>
	public int DeleteAll()
	{
		string LOCATION = "DeleteAll()";
		try
		{
				return _db.CreateCommand("Task_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
	/// <returns>An array of <see cref="TaskRow"/> objects.</returns>
	protected TaskRow[] MapRecords(IDbCommand command)
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
	/// <returns>An array of <see cref="TaskRow"/> objects.</returns>
	protected TaskRow[] MapRecords(IDataReader reader)
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
	/// <returns>An array of <see cref="TaskRow"/> objects.</returns>
	protected virtual TaskRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
	{ 
		string LOCATION = " MapRecords(...)";
		if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

		// Task_ID
		int task_IDColumnIndex = reader.GetOrdinal("Task_ID");
		// ProductBrand_ID
		int productBrand_IDColumnIndex = reader.GetOrdinal("ProductBrand_ID");
		// Product_ID
		int product_IDColumnIndex = reader.GetOrdinal("Product_ID");
		// ProductPackage_ID
		int productPackage_IDColumnIndex = reader.GetOrdinal("ProductPackage_ID");
		// Workshop_ID
		int workshop_IDColumnIndex = reader.GetOrdinal("Workshop_ID");
		// Farm_ID
		int farm_IDColumnIndex = reader.GetOrdinal("Farm_ID");
		// Customer_ID
		int customer_IDColumnIndex = reader.GetOrdinal("Customer_ID");
		// TaskType_ID
		int taskType_IDColumnIndex = reader.GetOrdinal("TaskType_ID");
		// TaskStep_ID
		int taskStep_IDColumnIndex = reader.GetOrdinal("TaskStep_ID");
		// TaskStatus_ID
		int taskStatus_IDColumnIndex = reader.GetOrdinal("TaskStatus_ID");
		// Name
		int nameColumnIndex = reader.GetOrdinal("Name");
		// ProductName
		int productNameColumnIndex = reader.GetOrdinal("ProductName");
		// ProductPackageName
		int productPackageNameColumnIndex = reader.GetOrdinal("ProductPackageName");
		// CustomerName
		int customerNameColumnIndex = reader.GetOrdinal("CustomerName");
		// Description
		int descriptionColumnIndex = reader.GetOrdinal("Description");
		// PersonStaff
		int personStaffColumnIndex = reader.GetOrdinal("PersonStaff");
		// StartDate
		int startDateColumnIndex = reader.GetOrdinal("StartDate");
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
		// WorkEvaluating
		int workEvaluatingColumnIndex = reader.GetOrdinal("WorkEvaluating");
		// Location
		int locationColumnIndex = reader.GetOrdinal("Location");
		// BuyerName
		int buyerNameColumnIndex = reader.GetOrdinal("BuyerName");
		// UserName
		int userNameColumnIndex = reader.GetOrdinal("UserName");
		// Quantity
		int quantityColumnIndex = reader.GetOrdinal("Quantity");
		// Price
		int priceColumnIndex = reader.GetOrdinal("Price");
		// SumMoney
		int sumMoneyColumnIndex = reader.GetOrdinal("SumMoney");
		// ShopName
		int shopNameColumnIndex = reader.GetOrdinal("ShopName");
		// ShopAddress
		int shopAddressColumnIndex = reader.GetOrdinal("ShopAddress");
		// Amount
		int amountColumnIndex = reader.GetOrdinal("Amount");
		// HarvestDayRemain
		int harvestDayRemainColumnIndex = reader.GetOrdinal("HarvestDayRemain");
		// HarvestVolume
		int harvestVolumeColumnIndex = reader.GetOrdinal("HarvestVolume");
		// Note
		int noteColumnIndex = reader.GetOrdinal("Note");
		// Risk
		int riskColumnIndex = reader.GetOrdinal("Risk");
		// Image
		int imageColumnIndex = reader.GetOrdinal("Image");
		// Staff_ID
		int staff_IDColumnIndex = reader.GetOrdinal("Staff_ID");
		// Material_ID
		int material_IDColumnIndex = reader.GetOrdinal("Material_ID");
		// StartingPoint
		int startingPointColumnIndex = reader.GetOrdinal("StartingPoint");
		// Destination
		int destinationColumnIndex = reader.GetOrdinal("Destination");
		// Transporter_ID
		int transporter_IDColumnIndex = reader.GetOrdinal("Transporter_ID");
		// ProductItem_ID_List
		int productItem_ID_ListColumnIndex = reader.GetOrdinal("ProductItem_ID_List");
		// Warehouse_ID
		int warehouse_IDColumnIndex = reader.GetOrdinal("Warehouse_ID");
		// Weather
		int weatherColumnIndex = reader.GetOrdinal("Weather");
		// Comment
		int commentColumnIndex = reader.GetOrdinal("Comment");
		// Unit
		int unitColumnIndex = reader.GetOrdinal("Unit");
		// TaskStepAnswer_ID_List
		int taskStepAnswer_ID_ListColumnIndex = reader.GetOrdinal("TaskStepAnswer_ID_List");

		System.Collections.ArrayList recordList = new System.Collections.ArrayList();
		int ri = -startIndex;
		while(reader.Read())
		{
			ri++;
			if(ri > 0 && ri <= length)
			{
				TaskRow record = new TaskRow();
				recordList.Add(record);

					record.Task_ID = Convert.ToInt32(reader.GetValue(task_IDColumnIndex));
					if(!reader.IsDBNull(productBrand_IDColumnIndex))
						record.ProductBrand_ID = Convert.ToInt32(reader.GetValue(productBrand_IDColumnIndex));
					if(!reader.IsDBNull(product_IDColumnIndex))
						record.Product_ID = Convert.ToInt32(reader.GetValue(product_IDColumnIndex));
					if(!reader.IsDBNull(productPackage_IDColumnIndex))
						record.ProductPackage_ID = Convert.ToInt32(reader.GetValue(productPackage_IDColumnIndex));
					if(!reader.IsDBNull(workshop_IDColumnIndex))
						record.Workshop_ID = Convert.ToInt32(reader.GetValue(workshop_IDColumnIndex));
					if(!reader.IsDBNull(farm_IDColumnIndex))
						record.Farm_ID = Convert.ToInt32(reader.GetValue(farm_IDColumnIndex));
					if(!reader.IsDBNull(customer_IDColumnIndex))
						record.Customer_ID = Convert.ToInt32(reader.GetValue(customer_IDColumnIndex));
					if(!reader.IsDBNull(taskType_IDColumnIndex))
						record.TaskType_ID = Convert.ToInt32(reader.GetValue(taskType_IDColumnIndex));
					if(!reader.IsDBNull(taskStep_IDColumnIndex))
						record.TaskStep_ID = Convert.ToInt32(reader.GetValue(taskStep_IDColumnIndex));
					if(!reader.IsDBNull(taskStatus_IDColumnIndex))
						record.TaskStatus_ID = Convert.ToInt32(reader.GetValue(taskStatus_IDColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(productNameColumnIndex))
						record.ProductName = Convert.ToString(reader.GetValue(productNameColumnIndex));
					if(!reader.IsDBNull(productPackageNameColumnIndex))
						record.ProductPackageName = Convert.ToString(reader.GetValue(productPackageNameColumnIndex));
					if(!reader.IsDBNull(customerNameColumnIndex))
						record.CustomerName = Convert.ToString(reader.GetValue(customerNameColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(personStaffColumnIndex))
						record.PersonStaff = Convert.ToString(reader.GetValue(personStaffColumnIndex));
					if(!reader.IsDBNull(startDateColumnIndex))
						record.StartDate = Convert.ToDateTime(reader.GetValue(startDateColumnIndex));
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
					if(!reader.IsDBNull(workEvaluatingColumnIndex))
						record.WorkEvaluating = Convert.ToString(reader.GetValue(workEvaluatingColumnIndex));
					if(!reader.IsDBNull(locationColumnIndex))
						record.Location = Convert.ToString(reader.GetValue(locationColumnIndex));
					if(!reader.IsDBNull(buyerNameColumnIndex))
						record.BuyerName = Convert.ToString(reader.GetValue(buyerNameColumnIndex));
					if(!reader.IsDBNull(userNameColumnIndex))
						record.UserName = Convert.ToString(reader.GetValue(userNameColumnIndex));
					if(!reader.IsDBNull(quantityColumnIndex))
						record.Quantity = Convert.ToDecimal(reader.GetValue(quantityColumnIndex));
					if(!reader.IsDBNull(priceColumnIndex))
						record.Price = Convert.ToDecimal(reader.GetValue(priceColumnIndex));
					if(!reader.IsDBNull(sumMoneyColumnIndex))
						record.SumMoney = Convert.ToDecimal(reader.GetValue(sumMoneyColumnIndex));
					if(!reader.IsDBNull(shopNameColumnIndex))
						record.ShopName = Convert.ToString(reader.GetValue(shopNameColumnIndex));
					if(!reader.IsDBNull(shopAddressColumnIndex))
						record.ShopAddress = Convert.ToString(reader.GetValue(shopAddressColumnIndex));
					if(!reader.IsDBNull(amountColumnIndex))
						record.Amount = Convert.ToDecimal(reader.GetValue(amountColumnIndex));
					if(!reader.IsDBNull(harvestDayRemainColumnIndex))
						record.HarvestDayRemain = Convert.ToInt32(reader.GetValue(harvestDayRemainColumnIndex));
					if(!reader.IsDBNull(harvestVolumeColumnIndex))
						record.HarvestVolume = Convert.ToDecimal(reader.GetValue(harvestVolumeColumnIndex));
					if(!reader.IsDBNull(noteColumnIndex))
						record.Note = Convert.ToString(reader.GetValue(noteColumnIndex));
					if(!reader.IsDBNull(riskColumnIndex))
						record.Risk = Convert.ToString(reader.GetValue(riskColumnIndex));
					if(!reader.IsDBNull(imageColumnIndex))
						record.Image = Convert.ToString(reader.GetValue(imageColumnIndex));
					if(!reader.IsDBNull(staff_IDColumnIndex))
						record.Staff_ID = Convert.ToString(reader.GetValue(staff_IDColumnIndex));
					if(!reader.IsDBNull(material_IDColumnIndex))
						record.Material_ID = Convert.ToInt32(reader.GetValue(material_IDColumnIndex));
					if(!reader.IsDBNull(startingPointColumnIndex))
						record.StartingPoint = Convert.ToString(reader.GetValue(startingPointColumnIndex));
					if(!reader.IsDBNull(destinationColumnIndex))
						record.Destination = Convert.ToString(reader.GetValue(destinationColumnIndex));
					if(!reader.IsDBNull(transporter_IDColumnIndex))
						record.Transporter_ID = Convert.ToInt32(reader.GetValue(transporter_IDColumnIndex));
					if(!reader.IsDBNull(productItem_ID_ListColumnIndex))
						record.ProductItem_ID_List = Convert.ToString(reader.GetValue(productItem_ID_ListColumnIndex));
					if(!reader.IsDBNull(warehouse_IDColumnIndex))
						record.Warehouse_ID = Convert.ToInt32(reader.GetValue(warehouse_IDColumnIndex));
					if(!reader.IsDBNull(weatherColumnIndex))
						record.Weather = Convert.ToString(reader.GetValue(weatherColumnIndex));
					if(!reader.IsDBNull(commentColumnIndex))
						record.Comment = Convert.ToString(reader.GetValue(commentColumnIndex));
					if(!reader.IsDBNull(unitColumnIndex))
						record.Unit = Convert.ToString(reader.GetValue(unitColumnIndex));
					if(!reader.IsDBNull(taskStepAnswer_ID_ListColumnIndex))
						record.TaskStepAnswer_ID_List = Convert.ToString(reader.GetValue(taskStepAnswer_ID_ListColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
		
		if (0 == totalRecordCount)
			totalRecordCount = ri + startIndex;
		else
			totalRecordCount = -1;

		return (TaskRow[])(recordList.ToArray(typeof(TaskRow)));
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
	/// Converts <see cref="System.Data.DataRow"/> to <see cref="TaskRow"/>.
	/// </summary>
	/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
	/// <returns>A reference to the <see cref="TaskRow"/> object.</returns>
	protected virtual TaskRow MapRow(DataRow row)
	{
		string LOCATION = "TaskRow MapRow(DataRow row)";
		TaskRow mappedObject = new TaskRow();
		DataTable dataTable = row.Table;
		DataColumn dataColumn;
		// Column "Task_ID"
		dataColumn = dataTable.Columns["Task_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Task_ID = (int)(row[dataColumn]);
		// Column "ProductBrand_ID"
		dataColumn = dataTable.Columns["ProductBrand_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductBrand_ID = (int)(row[dataColumn]);
		// Column "Product_ID"
		dataColumn = dataTable.Columns["Product_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Product_ID = (int)(row[dataColumn]);
		// Column "ProductPackage_ID"
		dataColumn = dataTable.Columns["ProductPackage_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackage_ID = (int)(row[dataColumn]);
		// Column "Workshop_ID"
		dataColumn = dataTable.Columns["Workshop_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Workshop_ID = (int)(row[dataColumn]);
		// Column "Farm_ID"
		dataColumn = dataTable.Columns["Farm_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Farm_ID = (int)(row[dataColumn]);
		// Column "Customer_ID"
		dataColumn = dataTable.Columns["Customer_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Customer_ID = (int)(row[dataColumn]);
		// Column "TaskType_ID"
		dataColumn = dataTable.Columns["TaskType_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaskType_ID = (int)(row[dataColumn]);
		// Column "TaskStep_ID"
		dataColumn = dataTable.Columns["TaskStep_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaskStep_ID = (int)(row[dataColumn]);
		// Column "TaskStatus_ID"
		dataColumn = dataTable.Columns["TaskStatus_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaskStatus_ID = (int)(row[dataColumn]);
		// Column "Name"
		dataColumn = dataTable.Columns["Name"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Name = (string)(row[dataColumn]);
		// Column "ProductName"
		dataColumn = dataTable.Columns["ProductName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductName = (string)(row[dataColumn]);
		// Column "ProductPackageName"
		dataColumn = dataTable.Columns["ProductPackageName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductPackageName = (string)(row[dataColumn]);
		// Column "CustomerName"
		dataColumn = dataTable.Columns["CustomerName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.CustomerName = (string)(row[dataColumn]);
		// Column "Description"
		dataColumn = dataTable.Columns["Description"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Description = (string)(row[dataColumn]);
		// Column "PersonStaff"
		dataColumn = dataTable.Columns["PersonStaff"];
		if (! row.IsNull(dataColumn) )
			mappedObject.PersonStaff = (string)(row[dataColumn]);
		// Column "StartDate"
		dataColumn = dataTable.Columns["StartDate"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StartDate = (System.DateTime)(row[dataColumn]);
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
		// Column "WorkEvaluating"
		dataColumn = dataTable.Columns["WorkEvaluating"];
		if (! row.IsNull(dataColumn) )
			mappedObject.WorkEvaluating = (string)(row[dataColumn]);
		// Column "Location"
		dataColumn = dataTable.Columns["Location"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Location = (string)(row[dataColumn]);
		// Column "BuyerName"
		dataColumn = dataTable.Columns["BuyerName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.BuyerName = (string)(row[dataColumn]);
		// Column "UserName"
		dataColumn = dataTable.Columns["UserName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.UserName = (string)(row[dataColumn]);
		// Column "Quantity"
		dataColumn = dataTable.Columns["Quantity"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Quantity = (decimal)(row[dataColumn]);
		// Column "Price"
		dataColumn = dataTable.Columns["Price"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Price = (decimal)(row[dataColumn]);
		// Column "SumMoney"
		dataColumn = dataTable.Columns["SumMoney"];
		if (! row.IsNull(dataColumn) )
			mappedObject.SumMoney = (decimal)(row[dataColumn]);
		// Column "ShopName"
		dataColumn = dataTable.Columns["ShopName"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ShopName = (string)(row[dataColumn]);
		// Column "ShopAddress"
		dataColumn = dataTable.Columns["ShopAddress"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ShopAddress = (string)(row[dataColumn]);
		// Column "Amount"
		dataColumn = dataTable.Columns["Amount"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Amount = (decimal)(row[dataColumn]);
		// Column "HarvestDayRemain"
		dataColumn = dataTable.Columns["HarvestDayRemain"];
		if (! row.IsNull(dataColumn) )
			mappedObject.HarvestDayRemain = (int)(row[dataColumn]);
		// Column "HarvestVolume"
		dataColumn = dataTable.Columns["HarvestVolume"];
		if (! row.IsNull(dataColumn) )
			mappedObject.HarvestVolume = (decimal)(row[dataColumn]);
		// Column "Note"
		dataColumn = dataTable.Columns["Note"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Note = (string)(row[dataColumn]);
		// Column "Risk"
		dataColumn = dataTable.Columns["Risk"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Risk = (string)(row[dataColumn]);
		// Column "Image"
		dataColumn = dataTable.Columns["Image"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Image = (string)(row[dataColumn]);
		// Column "Staff_ID"
		dataColumn = dataTable.Columns["Staff_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Staff_ID = (string)(row[dataColumn]);
		// Column "Material_ID"
		dataColumn = dataTable.Columns["Material_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Material_ID = (int)(row[dataColumn]);
		// Column "StartingPoint"
		dataColumn = dataTable.Columns["StartingPoint"];
		if (! row.IsNull(dataColumn) )
			mappedObject.StartingPoint = (string)(row[dataColumn]);
		// Column "Destination"
		dataColumn = dataTable.Columns["Destination"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Destination = (string)(row[dataColumn]);
		// Column "Transporter_ID"
		dataColumn = dataTable.Columns["Transporter_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Transporter_ID = (int)(row[dataColumn]);
		// Column "ProductItem_ID_List"
		dataColumn = dataTable.Columns["ProductItem_ID_List"];
		if (! row.IsNull(dataColumn) )
			mappedObject.ProductItem_ID_List = (string)(row[dataColumn]);
		// Column "Warehouse_ID"
		dataColumn = dataTable.Columns["Warehouse_ID"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Warehouse_ID = (int)(row[dataColumn]);
		// Column "Weather"
		dataColumn = dataTable.Columns["Weather"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Weather = (string)(row[dataColumn]);
		// Column "Comment"
		dataColumn = dataTable.Columns["Comment"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Comment = (string)(row[dataColumn]);
		// Column "Unit"
		dataColumn = dataTable.Columns["Unit"];
		if (! row.IsNull(dataColumn) )
			mappedObject.Unit = (string)(row[dataColumn]);
		// Column "TaskStepAnswer_ID_List"
		dataColumn = dataTable.Columns["TaskStepAnswer_ID_List"];
		if (! row.IsNull(dataColumn) )
			mappedObject.TaskStepAnswer_ID_List = (string)(row[dataColumn]);
		return mappedObject;
	}

	/// <summary>
	/// Creates a <see cref="System.Data.DataTable"/> object for 
	/// the <c>Task</c> table.
	/// </summary>
	/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
	protected virtual DataTable CreateDataTable()
	{
		string LOCATION = "CreateDataTable()";
		DataTable dataTable = new DataTable();
		dataTable.TableName = "Task";
		DataColumn dataColumn;
		// Create the "Task_ID" column
		dataColumn = dataTable.Columns.Add("Task_ID", typeof(int));
		dataColumn.AllowDBNull = false;
		dataColumn.ReadOnly = true;
		dataColumn.Unique = true;
		dataColumn.AutoIncrement = true;
		// Create the "ProductBrand_ID" column
		dataColumn = dataTable.Columns.Add("ProductBrand_ID", typeof(int));
		// Create the "Product_ID" column
		dataColumn = dataTable.Columns.Add("Product_ID", typeof(int));
		// Create the "ProductPackage_ID" column
		dataColumn = dataTable.Columns.Add("ProductPackage_ID", typeof(int));
		// Create the "Workshop_ID" column
		dataColumn = dataTable.Columns.Add("Workshop_ID", typeof(int));
		// Create the "Farm_ID" column
		dataColumn = dataTable.Columns.Add("Farm_ID", typeof(int));
		// Create the "Customer_ID" column
		dataColumn = dataTable.Columns.Add("Customer_ID", typeof(int));
		// Create the "TaskType_ID" column
		dataColumn = dataTable.Columns.Add("TaskType_ID", typeof(int));
		// Create the "TaskStep_ID" column
		dataColumn = dataTable.Columns.Add("TaskStep_ID", typeof(int));
		// Create the "TaskStatus_ID" column
		dataColumn = dataTable.Columns.Add("TaskStatus_ID", typeof(int));
		// Create the "Name" column
		dataColumn = dataTable.Columns.Add("Name", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductName" column
		dataColumn = dataTable.Columns.Add("ProductName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ProductPackageName" column
		dataColumn = dataTable.Columns.Add("ProductPackageName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "CustomerName" column
		dataColumn = dataTable.Columns.Add("CustomerName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Description" column
		dataColumn = dataTable.Columns.Add("Description", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "PersonStaff" column
		dataColumn = dataTable.Columns.Add("PersonStaff", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "StartDate" column
		dataColumn = dataTable.Columns.Add("StartDate", typeof(System.DateTime));
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
		// Create the "WorkEvaluating" column
		dataColumn = dataTable.Columns.Add("WorkEvaluating", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Location" column
		dataColumn = dataTable.Columns.Add("Location", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "BuyerName" column
		dataColumn = dataTable.Columns.Add("BuyerName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "UserName" column
		dataColumn = dataTable.Columns.Add("UserName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Quantity" column
		dataColumn = dataTable.Columns.Add("Quantity", typeof(decimal));
		// Create the "Price" column
		dataColumn = dataTable.Columns.Add("Price", typeof(decimal));
		// Create the "SumMoney" column
		dataColumn = dataTable.Columns.Add("SumMoney", typeof(decimal));
		// Create the "ShopName" column
		dataColumn = dataTable.Columns.Add("ShopName", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "ShopAddress" column
		dataColumn = dataTable.Columns.Add("ShopAddress", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Amount" column
		dataColumn = dataTable.Columns.Add("Amount", typeof(decimal));
		// Create the "HarvestDayRemain" column
		dataColumn = dataTable.Columns.Add("HarvestDayRemain", typeof(int));
		// Create the "HarvestVolume" column
		dataColumn = dataTable.Columns.Add("HarvestVolume", typeof(decimal));
		// Create the "Note" column
		dataColumn = dataTable.Columns.Add("Note", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Risk" column
		dataColumn = dataTable.Columns.Add("Risk", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Image" column
		dataColumn = dataTable.Columns.Add("Image", typeof(string));
		dataColumn.MaxLength = 200;
		// Create the "Staff_ID" column
		dataColumn = dataTable.Columns.Add("Staff_ID", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Material_ID" column
		dataColumn = dataTable.Columns.Add("Material_ID", typeof(int));
		// Create the "StartingPoint" column
		dataColumn = dataTable.Columns.Add("StartingPoint", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Destination" column
		dataColumn = dataTable.Columns.Add("Destination", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Transporter_ID" column
		dataColumn = dataTable.Columns.Add("Transporter_ID", typeof(int));
		// Create the "ProductItem_ID_List" column
		dataColumn = dataTable.Columns.Add("ProductItem_ID_List", typeof(string));
		// Create the "Warehouse_ID" column
		dataColumn = dataTable.Columns.Add("Warehouse_ID", typeof(int));
		// Create the "Weather" column
		dataColumn = dataTable.Columns.Add("Weather", typeof(string));
		dataColumn.MaxLength = 500;
		// Create the "Comment" column
		dataColumn = dataTable.Columns.Add("Comment", typeof(string));
		dataColumn.MaxLength = 1073741823;
		// Create the "Unit" column
		dataColumn = dataTable.Columns.Add("Unit", typeof(string));
		dataColumn.MaxLength = 50;
		// Create the "TaskStepAnswer_ID_List" column
		dataColumn = dataTable.Columns.Add("TaskStepAnswer_ID_List", typeof(string));
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
			case "Task_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductBrand_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Product_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductPackage_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Workshop_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Farm_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Customer_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "TaskType_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "TaskStep_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "TaskStatus_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Name":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ProductPackageName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "CustomerName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Description":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "PersonStaff":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "StartDate":
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

			case "WorkEvaluating":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Location":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "BuyerName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "UserName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Quantity":
				parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
				break;

			case "Price":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "SumMoney":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "ShopName":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "ShopAddress":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Amount":
				parameter = _db.AddParameter(cmd, paramName, DbType.Currency, value);
				break;

			case "HarvestDayRemain":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "HarvestVolume":
				parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
				break;

			case "Note":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Risk":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Image":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Staff_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Material_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "StartingPoint":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Destination":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Transporter_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "ProductItem_ID_List":
				parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
				break;

			case "Warehouse_ID":
				parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
				break;

			case "Weather":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Comment":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "Unit":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

			case "TaskStepAnswer_ID_List":
				parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
				break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
		}
		return parameter;
	}
	
	/// <summary>
	/// Exist <see cref="TaskRow"/> by the primary key.
	/// </summary>
	/// <param name="task_ID">The <c>Task_ID</c> column value.</param>
	/// <returns>An instance of <see cref="TaskRow"/> or null reference 
	/// (Nothing in Visual Basic) if the object was not found.</returns>
	public virtual bool Exist(int task_ID)
	{
		string LOCATION = "Exist(int task_ID)";
		IDbCommand cmd = _db.CreateCommand("Task_GetByPrimaryKey", CommandType.StoredProcedure);
		AddParameter(cmd, "Task_ID", task_ID);
		TaskRow[] tempArray = MapRecords(cmd);
		if( 0 == tempArray.Length)
			return false;
		return true;
	}
	
}
}




