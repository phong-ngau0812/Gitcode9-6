// <fileinfo name="ProductPackageOrderStatusBO.cs">
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
/// The base class for <see cref="ProductPackageOrderStatusCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageOrderStatusCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductPackageOrderStatusBO
	: BusinessRulesBase
{



	public ProductPackageOrderStatusRow GetByPrimaryKey(int productPackageOrderStatus_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackageOrderStatus_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderStatusCollection().GetByPrimaryKey(productPackageOrderStatus_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productPackageOrderStatus_ID)
	{
		string LOCATION = "Exist(int productPackageOrderStatus_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderStatusCollection().Exist(productPackageOrderStatus_ID);
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
			DataAccessLocator.GetProductPackageOrderStatusCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductPackageOrderStatusRow value)
	{
		string LOCATION = "Update(ProductPackageOrderStatusRow value)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderStatusCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductPackageOrderStatusRow value)
	{
		string LOCATION = "Insert(ProductPackageOrderStatusRow value)";
		try
		{
			DataAccessLocator.GetProductPackageOrderStatusCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productPackageOrderStatus_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackageOrderStatus_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderStatusCollection().DeleteByPrimaryKey(productPackageOrderStatus_ID);
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
			return DataAccessLocator.GetProductPackageOrderStatusCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductPackageOrderStatusCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductPackageOrderStatusCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductPackageOrderStatusCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

