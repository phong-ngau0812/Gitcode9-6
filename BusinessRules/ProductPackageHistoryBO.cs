// <fileinfo name="ProductPackageHistoryBO.cs">
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
/// The base class for <see cref="ProductPackageHistoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageHistoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductPackageHistoryBO
	: BusinessRulesBase
{



	public ProductPackageHistoryRow GetByPrimaryKey(int productPackageHistory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackageHistory_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageHistoryCollection().GetByPrimaryKey(productPackageHistory_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productPackageHistory_ID)
	{
		string LOCATION = "Exist(int productPackageHistory_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageHistoryCollection().Exist(productPackageHistory_ID);
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
			DataAccessLocator.GetProductPackageHistoryCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductPackageHistoryRow value)
	{
		string LOCATION = "Update(ProductPackageHistoryRow value)";
		try
		{
			return DataAccessLocator.GetProductPackageHistoryCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductPackageHistoryRow value)
	{
		string LOCATION = "Insert(ProductPackageHistoryRow value)";
		try
		{
			DataAccessLocator.GetProductPackageHistoryCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productPackageHistory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackageHistory_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageHistoryCollection().DeleteByPrimaryKey(productPackageHistory_ID);
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
			return DataAccessLocator.GetProductPackageHistoryCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductPackageHistoryCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductPackageHistoryCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductPackageHistoryCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

