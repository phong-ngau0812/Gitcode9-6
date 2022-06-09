// <fileinfo name="WH_OrderVsProductBO.cs">
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
/// The base class for <see cref="WH_OrderVsProductCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_OrderVsProductCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WH_OrderVsProductBO
	: BusinessRulesBase
{



	public WH_OrderVsProductRow GetByPrimaryKey(int orderVsProduct_ID)
	{
		string LOCATION = "GetByPrimaryKey(int orderVsProduct_ID)";
		try
		{
			return DataAccessLocator.GetWH_OrderVsProductCollection().GetByPrimaryKey(orderVsProduct_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int orderVsProduct_ID)
	{
		string LOCATION = "Exist(int orderVsProduct_ID)";
		try
		{
			return DataAccessLocator.GetWH_OrderVsProductCollection().Exist(orderVsProduct_ID);
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
			DataAccessLocator.GetWH_OrderVsProductCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WH_OrderVsProductRow value)
	{
		string LOCATION = "Update(WH_OrderVsProductRow value)";
		try
		{
			return DataAccessLocator.GetWH_OrderVsProductCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WH_OrderVsProductRow value)
	{
		string LOCATION = "Insert(WH_OrderVsProductRow value)";
		try
		{
			DataAccessLocator.GetWH_OrderVsProductCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int orderVsProduct_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int orderVsProduct_ID)";
		try
		{
			return DataAccessLocator.GetWH_OrderVsProductCollection().DeleteByPrimaryKey(orderVsProduct_ID);
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
			return DataAccessLocator.GetWH_OrderVsProductCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWH_OrderVsProductCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWH_OrderVsProductCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWH_OrderVsProductCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

