// <fileinfo name="MaterialPriceBO.cs">
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
/// The base class for <see cref="MaterialPriceCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="MaterialPriceCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class MaterialPriceBO
	: BusinessRulesBase
{



	public MaterialPriceRow GetByPrimaryKey(int materialPrice_ID)
	{
		string LOCATION = "GetByPrimaryKey(int materialPrice_ID)";
		try
		{
			return DataAccessLocator.GetMaterialPriceCollection().GetByPrimaryKey(materialPrice_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int materialPrice_ID)
	{
		string LOCATION = "Exist(int materialPrice_ID)";
		try
		{
			return DataAccessLocator.GetMaterialPriceCollection().Exist(materialPrice_ID);
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
			DataAccessLocator.GetMaterialPriceCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(MaterialPriceRow value)
	{
		string LOCATION = "Update(MaterialPriceRow value)";
		try
		{
			return DataAccessLocator.GetMaterialPriceCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(MaterialPriceRow value)
	{
		string LOCATION = "Insert(MaterialPriceRow value)";
		try
		{
			DataAccessLocator.GetMaterialPriceCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int materialPrice_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int materialPrice_ID)";
		try
		{
			return DataAccessLocator.GetMaterialPriceCollection().DeleteByPrimaryKey(materialPrice_ID);
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
			return DataAccessLocator.GetMaterialPriceCollection().Delete(whereSql);
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
			return DataAccessLocator.GetMaterialPriceCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetMaterialPriceCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetMaterialPriceCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

