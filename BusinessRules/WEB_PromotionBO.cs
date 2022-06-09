// <fileinfo name="WEB_PromotionBO.cs">
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
/// The base class for <see cref="WEB_PromotionCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WEB_PromotionCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WEB_PromotionBO
	: BusinessRulesBase
{



	public WEB_PromotionRow GetByPrimaryKey(int promotion_ID)
	{
		string LOCATION = "GetByPrimaryKey(int promotion_ID)";
		try
		{
			return DataAccessLocator.GetWEB_PromotionCollection().GetByPrimaryKey(promotion_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int promotion_ID)
	{
		string LOCATION = "Exist(int promotion_ID)";
		try
		{
			return DataAccessLocator.GetWEB_PromotionCollection().Exist(promotion_ID);
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
			DataAccessLocator.GetWEB_PromotionCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WEB_PromotionRow value)
	{
		string LOCATION = "Update(WEB_PromotionRow value)";
		try
		{
			return DataAccessLocator.GetWEB_PromotionCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WEB_PromotionRow value)
	{
		string LOCATION = "Insert(WEB_PromotionRow value)";
		try
		{
			DataAccessLocator.GetWEB_PromotionCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int promotion_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int promotion_ID)";
		try
		{
			return DataAccessLocator.GetWEB_PromotionCollection().DeleteByPrimaryKey(promotion_ID);
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
			return DataAccessLocator.GetWEB_PromotionCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWEB_PromotionCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWEB_PromotionCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWEB_PromotionCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

