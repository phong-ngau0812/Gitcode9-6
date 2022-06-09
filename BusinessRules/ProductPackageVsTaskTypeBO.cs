// <fileinfo name="ProductPackageVsTaskTypeBO.cs">
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
/// The base class for <see cref="ProductPackageVsTaskTypeCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductPackageVsTaskTypeCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductPackageVsTaskTypeBO
	: BusinessRulesBase
{



	public ProductPackageVsTaskTypeRow GetByPrimaryKey(int productPackage_ID, int taskType_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productPackage_ID, int taskType_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().GetByPrimaryKey(productPackage_ID, taskType_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productPackage_ID, int taskType_ID)
	{
		string LOCATION = "Exist(int productPackage_ID, int taskType_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().Exist(productPackage_ID, taskType_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}




	public void Insert(ProductPackageVsTaskTypeRow value)
	{
		string LOCATION = "Insert(ProductPackageVsTaskTypeRow value)";
		try
		{
			DataAccessLocator.GetProductPackageVsTaskTypeCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productPackage_ID, int taskType_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productPackage_ID, int taskType_ID)";
		try
		{
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().DeleteByPrimaryKey(productPackage_ID, taskType_ID);
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
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductPackageVsTaskTypeCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

