// <fileinfo name="FarmGroupInterBO.cs">
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
/// The base class for <see cref="FarmGroupInterCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="FarmGroupInterCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class FarmGroupInterBO
	: BusinessRulesBase
{



	public FarmGroupInterRow GetByPrimaryKey(int farmGroupInter_ID)
	{
		string LOCATION = "GetByPrimaryKey(int farmGroupInter_ID)";
		try
		{
			return DataAccessLocator.GetFarmGroupInterCollection().GetByPrimaryKey(farmGroupInter_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int farmGroupInter_ID)
	{
		string LOCATION = "Exist(int farmGroupInter_ID)";
		try
		{
			return DataAccessLocator.GetFarmGroupInterCollection().Exist(farmGroupInter_ID);
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
			DataAccessLocator.GetFarmGroupInterCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(FarmGroupInterRow value)
	{
		string LOCATION = "Update(FarmGroupInterRow value)";
		try
		{
			return DataAccessLocator.GetFarmGroupInterCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(FarmGroupInterRow value)
	{
		string LOCATION = "Insert(FarmGroupInterRow value)";
		try
		{
			DataAccessLocator.GetFarmGroupInterCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int farmGroupInter_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int farmGroupInter_ID)";
		try
		{
			return DataAccessLocator.GetFarmGroupInterCollection().DeleteByPrimaryKey(farmGroupInter_ID);
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
			return DataAccessLocator.GetFarmGroupInterCollection().Delete(whereSql);
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
			return DataAccessLocator.GetFarmGroupInterCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetFarmGroupInterCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetFarmGroupInterCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

