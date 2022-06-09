// <fileinfo name="CountryBO.cs">
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
/// The base class for <see cref="CountryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="CountryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class CountryBO
	: BusinessRulesBase
{



	public CountryRow GetByPrimaryKey(int country_ID)
	{
		string LOCATION = "GetByPrimaryKey(int country_ID)";
		try
		{
			return DataAccessLocator.GetCountryCollection().GetByPrimaryKey(country_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int country_ID)
	{
		string LOCATION = "Exist(int country_ID)";
		try
		{
			return DataAccessLocator.GetCountryCollection().Exist(country_ID);
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
			DataAccessLocator.GetCountryCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(CountryRow value)
	{
		string LOCATION = "Update(CountryRow value)";
		try
		{
			return DataAccessLocator.GetCountryCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(CountryRow value)
	{
		string LOCATION = "Insert(CountryRow value)";
		try
		{
			DataAccessLocator.GetCountryCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int country_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int country_ID)";
		try
		{
			return DataAccessLocator.GetCountryCollection().DeleteByPrimaryKey(country_ID);
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
			return DataAccessLocator.GetCountryCollection().Delete(whereSql);
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
			return DataAccessLocator.GetCountryCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetCountryCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetCountryCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

