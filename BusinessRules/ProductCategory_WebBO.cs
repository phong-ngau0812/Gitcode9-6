// <fileinfo name="ProductCategory_WebBO.cs">
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
/// The base class for <see cref="ProductCategory_WebCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductCategory_WebCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductCategory_WebBO
	: BusinessRulesBase
{



	public ProductCategory_WebRow GetByPrimaryKey(int productCategory_Web_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productCategory_Web_ID)";
		try
		{
			return DataAccessLocator.GetProductCategory_WebCollection().GetByPrimaryKey(productCategory_Web_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productCategory_Web_ID)
	{
		string LOCATION = "Exist(int productCategory_Web_ID)";
		try
		{
			return DataAccessLocator.GetProductCategory_WebCollection().Exist(productCategory_Web_ID);
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
			DataAccessLocator.GetProductCategory_WebCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductCategory_WebRow value)
	{
		string LOCATION = "Update(ProductCategory_WebRow value)";
		try
		{
			return DataAccessLocator.GetProductCategory_WebCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductCategory_WebRow value)
	{
		string LOCATION = "Insert(ProductCategory_WebRow value)";
		try
		{
			DataAccessLocator.GetProductCategory_WebCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productCategory_Web_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productCategory_Web_ID)";
		try
		{
			return DataAccessLocator.GetProductCategory_WebCollection().DeleteByPrimaryKey(productCategory_Web_ID);
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
			return DataAccessLocator.GetProductCategory_WebCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductCategory_WebCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductCategory_WebCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductCategory_WebCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

