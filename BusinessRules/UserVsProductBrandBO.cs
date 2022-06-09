// <fileinfo name="UserVsProductBrandBO.cs">
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
/// The base class for <see cref="UserVsProductBrandCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="UserVsProductBrandCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class UserVsProductBrandBO
	: BusinessRulesBase
{



	public UserVsProductBrandRow GetByPrimaryKey(int userVsProductBrand_ID)
	{
		string LOCATION = "GetByPrimaryKey(int userVsProductBrand_ID)";
		try
		{
			return DataAccessLocator.GetUserVsProductBrandCollection().GetByPrimaryKey(userVsProductBrand_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int userVsProductBrand_ID)
	{
		string LOCATION = "Exist(int userVsProductBrand_ID)";
		try
		{
			return DataAccessLocator.GetUserVsProductBrandCollection().Exist(userVsProductBrand_ID);
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
			DataAccessLocator.GetUserVsProductBrandCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(UserVsProductBrandRow value)
	{
		string LOCATION = "Update(UserVsProductBrandRow value)";
		try
		{
			return DataAccessLocator.GetUserVsProductBrandCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(UserVsProductBrandRow value)
	{
		string LOCATION = "Insert(UserVsProductBrandRow value)";
		try
		{
			DataAccessLocator.GetUserVsProductBrandCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int userVsProductBrand_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int userVsProductBrand_ID)";
		try
		{
			return DataAccessLocator.GetUserVsProductBrandCollection().DeleteByPrimaryKey(userVsProductBrand_ID);
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
			return DataAccessLocator.GetUserVsProductBrandCollection().Delete(whereSql);
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
			return DataAccessLocator.GetUserVsProductBrandCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetUserVsProductBrandCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetUserVsProductBrandCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

