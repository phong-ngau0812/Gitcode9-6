// <fileinfo name="V2_WarehouseProductExportBO.cs">
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
/// The base class for <see cref="V2_WarehouseProductExportCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="V2_WarehouseProductExportCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class V2_WarehouseProductExportBO
	: BusinessRulesBase
{



	public V2_WarehouseProductExportRow GetByPrimaryKey(int task_ID)
	{
		string LOCATION = "GetByPrimaryKey(int task_ID)";
		try
		{
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().GetByPrimaryKey(task_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int task_ID)
	{
		string LOCATION = "Exist(int task_ID)";
		try
		{
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().Exist(task_ID);
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
			DataAccessLocator.GetV2_WarehouseProductExportCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(V2_WarehouseProductExportRow value)
	{
		string LOCATION = "Update(V2_WarehouseProductExportRow value)";
		try
		{
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(V2_WarehouseProductExportRow value)
	{
		string LOCATION = "Insert(V2_WarehouseProductExportRow value)";
		try
		{
			DataAccessLocator.GetV2_WarehouseProductExportCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int task_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int task_ID)";
		try
		{
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().DeleteByPrimaryKey(task_ID);
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
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().Delete(whereSql);
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
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetV2_WarehouseProductExportCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

