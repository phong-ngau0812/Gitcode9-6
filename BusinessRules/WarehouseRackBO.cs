// <fileinfo name="WarehouseRackBO.cs">
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
/// The base class for <see cref="WarehouseRackCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseRackCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseRackBO
	: BusinessRulesBase
{



	public WarehouseRackRow GetByPrimaryKey(int rack_ID)
	{
		string LOCATION = "GetByPrimaryKey(int rack_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseRackCollection().GetByPrimaryKey(rack_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int rack_ID)
	{
		string LOCATION = "Exist(int rack_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseRackCollection().Exist(rack_ID);
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
			DataAccessLocator.GetWarehouseRackCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseRackRow value)
	{
		string LOCATION = "Update(WarehouseRackRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseRackCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseRackRow value)
	{
		string LOCATION = "Insert(WarehouseRackRow value)";
		try
		{
			DataAccessLocator.GetWarehouseRackCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int rack_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int rack_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseRackCollection().DeleteByPrimaryKey(rack_ID);
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
			return DataAccessLocator.GetWarehouseRackCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWarehouseRackCollection().GetAllAsDataTable();
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public DataTable GetAllLineAsDataTable()
	{
		string LOCATION = "GetAllLineAsDataTable()";
		try
		{
			return DataAccessLocator.GetWarehouseRackCollection().GetAllLineAsDataTable();
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public DataTable GetAsDataTable(string whereSql, string orderBySql)
	{
		string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
		try
		{
			return DataAccessLocator.GetWarehouseRackCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWarehouseRackCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

