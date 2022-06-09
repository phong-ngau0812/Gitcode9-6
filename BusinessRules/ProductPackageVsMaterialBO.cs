// <fileinfo name="ProductPackageVsMaterialBO.cs">
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
/// The base class for <see cref="ProductPackageVsMaterialCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageVsMaterialCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductPackageVsMaterialBO
	: BusinessRulesBase
{



	public ProductPackageVsMaterialRow GetByPrimaryKey(int productPackage_ID, int material_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackage_ID, int material_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageVsMaterialCollection().GetByPrimaryKey(productPackage_ID, material_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productPackage_ID, int material_ID)
	{
		string LOCATION = "Exist(int productPackage_ID, int material_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageVsMaterialCollection().Exist(productPackage_ID, material_ID);
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
			DataAccessLocator.GetProductPackageVsMaterialCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductPackageVsMaterialRow value)
	{
		string LOCATION = "Update(ProductPackageVsMaterialRow value)";
		try
		{
			return DataAccessLocator.GetProductPackageVsMaterialCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductPackageVsMaterialRow value)
	{
		string LOCATION = "Insert(ProductPackageVsMaterialRow value)";
		try
		{
			DataAccessLocator.GetProductPackageVsMaterialCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productPackage_ID, int material_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackage_ID, int material_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageVsMaterialCollection().DeleteByPrimaryKey(productPackage_ID, material_ID);
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
			return DataAccessLocator.GetProductPackageVsMaterialCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductPackageVsMaterialCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductPackageVsMaterialCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductPackageVsMaterialCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

