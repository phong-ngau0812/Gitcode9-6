// <fileinfo name="ProductPackageOrderMaterialRuleBO.cs">
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
/// The base class for <see cref="ProductPackageOrderMaterialRuleCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageOrderMaterialRuleCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductPackageOrderMaterialRuleBO
	: BusinessRulesBase
{



	public ProductPackageOrderMaterialRuleRow GetByPrimaryKey(int productPackageOrderMaterialRule_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackageOrderMaterialRule_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().GetByPrimaryKey(productPackageOrderMaterialRule_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productPackageOrderMaterialRule_ID)
	{
		string LOCATION = "Exist(int productPackageOrderMaterialRule_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().Exist(productPackageOrderMaterialRule_ID);
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
			DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductPackageOrderMaterialRuleRow value)
	{
		string LOCATION = "Update(ProductPackageOrderMaterialRuleRow value)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductPackageOrderMaterialRuleRow value)
	{
		string LOCATION = "Insert(ProductPackageOrderMaterialRuleRow value)";
		try
		{
			DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productPackageOrderMaterialRule_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackageOrderMaterialRule_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().DeleteByPrimaryKey(productPackageOrderMaterialRule_ID);
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
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductPackageOrderMaterialRuleCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

