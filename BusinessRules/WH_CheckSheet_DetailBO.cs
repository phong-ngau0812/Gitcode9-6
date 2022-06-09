// <fileinfo name="WH_CheckSheet_DetailBO.cs">
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
/// The base class for <see cref="WH_CheckSheet_DetailCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_CheckSheet_DetailCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WH_CheckSheet_DetailBO
	: BusinessRulesBase
{



	public WH_CheckSheet_DetailRow GetByPrimaryKey(int wH_CheckSheet_Detail_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_CheckSheet_Detail_ID)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().GetByPrimaryKey(wH_CheckSheet_Detail_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int wH_CheckSheet_Detail_ID)
	{
		string LOCATION = "Exist(int wH_CheckSheet_Detail_ID)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().Exist(wH_CheckSheet_Detail_ID);
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
			DataAccessLocator.GetWH_CheckSheet_DetailCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WH_CheckSheet_DetailRow value)
	{
		string LOCATION = "Update(WH_CheckSheet_DetailRow value)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WH_CheckSheet_DetailRow value)
	{
		string LOCATION = "Insert(WH_CheckSheet_DetailRow value)";
		try
		{
			DataAccessLocator.GetWH_CheckSheet_DetailCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int wH_CheckSheet_Detail_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_CheckSheet_Detail_ID)";
		try
		{
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().DeleteByPrimaryKey(wH_CheckSheet_Detail_ID);
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
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWH_CheckSheet_DetailCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

