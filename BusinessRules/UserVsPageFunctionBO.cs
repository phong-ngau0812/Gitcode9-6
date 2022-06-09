// <fileinfo name="UserVsPageFunctionBO.cs">
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
/// The base class for <see cref="UserVsPageFunctionCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="UserVsPageFunctionCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class UserVsPageFunctionBO
	: BusinessRulesBase
{



	public UserVsPageFunctionRow GetByPrimaryKey(System.Guid userId, int pageFunction_ID)
	{
		string LOCATION = "GetByPrimaryKey(System.Guid userId, int pageFunction_ID)";
		try
		{
			return DataAccessLocator.GetUserVsPageFunctionCollection().GetByPrimaryKey(userId, pageFunction_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(System.Guid userId, int pageFunction_ID)
	{
		string LOCATION = "Exist(System.Guid userId, int pageFunction_ID)";
		try
		{
			return DataAccessLocator.GetUserVsPageFunctionCollection().Exist(userId, pageFunction_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}




	public void Insert(UserVsPageFunctionRow value)
	{
		string LOCATION = "Insert(UserVsPageFunctionRow value)";
		try
		{
			DataAccessLocator.GetUserVsPageFunctionCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(System.Guid userId, int pageFunction_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(System.Guid userId, int pageFunction_ID)";
		try
		{
			return DataAccessLocator.GetUserVsPageFunctionCollection().DeleteByPrimaryKey(userId, pageFunction_ID);
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
			return DataAccessLocator.GetUserVsPageFunctionCollection().Delete(whereSql);
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
			return DataAccessLocator.GetUserVsPageFunctionCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetUserVsPageFunctionCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetUserVsPageFunctionCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

