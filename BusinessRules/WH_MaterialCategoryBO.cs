// <fileinfo name="WH_MaterialCategoryBO.cs">
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
/// The base class for <see cref="WH_MaterialCategoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_MaterialCategoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WH_MaterialCategoryBO
	: BusinessRulesBase
{



	public WH_MaterialCategoryRow GetByPrimaryKey(int materialCategory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int materialCategory_ID)";
		try
		{
			return DataAccessLocator.GetWH_MaterialCategoryCollection().GetByPrimaryKey(materialCategory_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int materialCategory_ID)
	{
		string LOCATION = "Exist(int materialCategory_ID)";
		try
		{
			return DataAccessLocator.GetWH_MaterialCategoryCollection().Exist(materialCategory_ID);
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
			DataAccessLocator.GetWH_MaterialCategoryCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WH_MaterialCategoryRow value)
	{
		string LOCATION = "Update(WH_MaterialCategoryRow value)";
		try
		{
			return DataAccessLocator.GetWH_MaterialCategoryCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WH_MaterialCategoryRow value)
	{
		string LOCATION = "Insert(WH_MaterialCategoryRow value)";
		try
		{
			DataAccessLocator.GetWH_MaterialCategoryCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int materialCategory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int materialCategory_ID)";
		try
		{
			return DataAccessLocator.GetWH_MaterialCategoryCollection().DeleteByPrimaryKey(materialCategory_ID);
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
			return DataAccessLocator.GetWH_MaterialCategoryCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWH_MaterialCategoryCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWH_MaterialCategoryCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWH_MaterialCategoryCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

