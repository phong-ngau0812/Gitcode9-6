// <fileinfo name="SalesInformationVsProductBO.cs">
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
/// The base class for <see cref="SalesInformationVsProductCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SalesInformationVsProductCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class SalesInformationVsProductBO
	: BusinessRulesBase
{



	public SalesInformationVsProductRow GetByPrimaryKey(int salesInformation_ID, int product_ID)
	{
		string LOCATION = "GetByPrimaryKey(int salesInformation_ID, int product_ID)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductCollection().GetByPrimaryKey(salesInformation_ID, product_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int salesInformation_ID, int product_ID)
	{
		string LOCATION = "Exist(int salesInformation_ID, int product_ID)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductCollection().Exist(salesInformation_ID, product_ID);
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
			DataAccessLocator.GetSalesInformationVsProductCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(SalesInformationVsProductRow value)
	{
		string LOCATION = "Update(SalesInformationVsProductRow value)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(SalesInformationVsProductRow value)
	{
		string LOCATION = "Insert(SalesInformationVsProductRow value)";
		try
		{
			DataAccessLocator.GetSalesInformationVsProductCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int salesInformation_ID, int product_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int salesInformation_ID, int product_ID)";
		try
		{
			return DataAccessLocator.GetSalesInformationVsProductCollection().DeleteByPrimaryKey(salesInformation_ID, product_ID);
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
			return DataAccessLocator.GetSalesInformationVsProductCollection().Delete(whereSql);
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
			return DataAccessLocator.GetSalesInformationVsProductCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetSalesInformationVsProductCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetSalesInformationVsProductCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

