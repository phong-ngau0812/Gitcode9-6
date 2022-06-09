// <fileinfo name="ProductPackageOrderMaterialBO.cs">
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
/// The base class for <see cref="ProductPackageOrderMaterialCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageOrderMaterialCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductPackageOrderMaterialBO
	: BusinessRulesBase
{



	public ProductPackageOrderMaterialRow GetByPrimaryKey(int productPackageOrderMaterial_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackageOrderMaterial_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().GetByPrimaryKey(productPackageOrderMaterial_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productPackageOrderMaterial_ID)
	{
		string LOCATION = "Exist(int productPackageOrderMaterial_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().Exist(productPackageOrderMaterial_ID);
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
			DataAccessLocator.GetProductPackageOrderMaterialCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductPackageOrderMaterialRow value)
	{
		string LOCATION = "Update(ProductPackageOrderMaterialRow value)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductPackageOrderMaterialRow value)
	{
		string LOCATION = "Insert(ProductPackageOrderMaterialRow value)";
		try
		{
			DataAccessLocator.GetProductPackageOrderMaterialCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productPackageOrderMaterial_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackageOrderMaterial_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().DeleteByPrimaryKey(productPackageOrderMaterial_ID);
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
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductPackageOrderMaterialCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

