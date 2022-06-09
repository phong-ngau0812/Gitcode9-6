// <fileinfo name="WarehouseSlotActionBO.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
// </fileinfo>


using System;
using System.Data;

using DbObj;


/// <summary>
/// The base class for <see cref="WarehouseSlotActionCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseSlotActionCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseSlotActionBO
	: BusinessRulesBase
{



	public WarehouseSlotActionRow GetByPrimaryKey(int warehouseSlotAction_ID)
	{
		string LOCATION = "GetByPrimaryKey(int warehouseSlotAction_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().GetByPrimaryKey(warehouseSlotAction_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int warehouseSlotAction_ID)
	{
		string LOCATION = "Exist(int warehouseSlotAction_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().Exist(warehouseSlotAction_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}


	public void Update(DataTable table)
	{
		string LOCATION = "Update(DataTable table)";
		try
		{
			DataAccessLocator.GetWarehouseSlotActionCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseSlotActionRow value)
	{
		string LOCATION = "Update(WarehouseSlotActionRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseSlotActionRow value)
	{
		string LOCATION = "Insert(WarehouseSlotActionRow value)";
		try
		{
			DataAccessLocator.GetWarehouseSlotActionCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int warehouseSlotAction_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int warehouseSlotAction_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().DeleteByPrimaryKey(warehouseSlotAction_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public int Delete(string whereSql)
	{
		string LOCATION = "Delete(string whereSql)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().Delete(whereSql);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public DataTable GetAllAsDataTable()
	{
		string LOCATION = "GetAllAsDataTable()";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().GetAllAsDataTable();
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	
	public DataTable GetAsDataTable(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().GetAsDataTable(whereSql, orderBySql);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	
	public DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
		try
		{
			return DataAccessLocator.GetWarehouseSlotActionCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

