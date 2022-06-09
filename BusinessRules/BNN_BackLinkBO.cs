// <fileinfo name="BNN_BackLinkBO.cs">
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
/// The base class for <see cref="BNN_BackLinkCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_BackLinkCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_BackLinkBO
	: BusinessRulesBase
{



	public BNN_BackLinkRow GetByPrimaryKey(int backLink_ID)
	{
		string LOCATION = "GetByPrimaryKey(int backLink_ID)";
		try
		{
			return DataAccessLocator.GetBNN_BackLinkCollection().GetByPrimaryKey(backLink_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int backLink_ID)
	{
		string LOCATION = "Exist(int backLink_ID)";
		try
		{
			return DataAccessLocator.GetBNN_BackLinkCollection().Exist(backLink_ID);
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
			DataAccessLocator.GetBNN_BackLinkCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_BackLinkRow value)
	{
		string LOCATION = "Update(BNN_BackLinkRow value)";
		try
		{
			return DataAccessLocator.GetBNN_BackLinkCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_BackLinkRow value)
	{
		string LOCATION = "Insert(BNN_BackLinkRow value)";
		try
		{
			DataAccessLocator.GetBNN_BackLinkCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int backLink_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int backLink_ID)";
		try
		{
			return DataAccessLocator.GetBNN_BackLinkCollection().DeleteByPrimaryKey(backLink_ID);
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
			return DataAccessLocator.GetBNN_BackLinkCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_BackLinkCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_BackLinkCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_BackLinkCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

