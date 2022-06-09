// <fileinfo name="SalesInformationVsProductPackageBO.cs">
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
/// The base class for <see cref="SalesInformationVsProductPackageCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SalesInformationVsProductPackageCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class SalesInformationVsProductPackageBO
	: BusinessRulesBase
{



	public SalesInformationVsProductPackageRow GetByPrimaryKey(int salesInformation_ID, int productPackage_ID)
	{
		string LOCATION = "GetByPrimaryKey(int salesInformation_ID, int productPackage_ID)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().GetByPrimaryKey(salesInformation_ID, productPackage_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int salesInformation_ID, int productPackage_ID)
	{
		string LOCATION = "Exist(int salesInformation_ID, int productPackage_ID)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().Exist(salesInformation_ID, productPackage_ID);
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
			DataAccessLocator.GetSalesInformationVsProductPackageCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(SalesInformationVsProductPackageRow value)
	{
		string LOCATION = "Update(SalesInformationVsProductPackageRow value)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(SalesInformationVsProductPackageRow value)
	{
		string LOCATION = "Insert(SalesInformationVsProductPackageRow value)";
		try
		{
			DataAccessLocator.GetSalesInformationVsProductPackageCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int salesInformation_ID, int productPackage_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int salesInformation_ID, int productPackage_ID)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().DeleteByPrimaryKey(salesInformation_ID, productPackage_ID);
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
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().Delete(whereSql);
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
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetSalesInformationVsProductPackageCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

