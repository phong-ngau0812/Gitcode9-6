// <fileinfo name="WarehouseTempProBO.cs">
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
/// The base class for <see cref="WarehouseTempProCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseTempProCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseTempProBO
	: BusinessRulesBase
{



	public WarehouseTempProRow GetByPrimaryKey(int warehouseTempPro_ID)
	{
		string LOCATION = "GetByPrimaryKey(int warehouseTempPro_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseTempProCollection().GetByPrimaryKey(warehouseTempPro_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int warehouseTempPro_ID)
	{
		string LOCATION = "Exist(int warehouseTempPro_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseTempProCollection().Exist(warehouseTempPro_ID);
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
			DataAccessLocator.GetWarehouseTempProCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseTempProRow value)
	{
		string LOCATION = "Update(WarehouseTempProRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseTempProCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public void Save(WarehouseTempProRow value)
	{
		string LOCATION = "Update(WarehouseTempProRow value)";
		try
		{
			DataAccessLocator.GetWarehouseTempProCollection().Save(value);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseTempProRow value)
	{
		string LOCATION = "Insert(WarehouseTempProRow value)";
		try
		{
			DataAccessLocator.GetWarehouseTempProCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int warehouseTempPro_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int warehouseTempPro_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseTempProCollection().DeleteByPrimaryKey(warehouseTempPro_ID);
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
			return DataAccessLocator.GetWarehouseTempProCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWarehouseTempProCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWarehouseTempProCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWarehouseTempProCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

