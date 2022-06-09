// <fileinfo name="FunctionGroupMenuBO.cs">
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
/// The base class for <see cref="FunctionGroupMenuCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="FunctionGroupMenuCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class FunctionGroupMenuBO
	: BusinessRulesBase
{



	public FunctionGroupMenuRow GetByPrimaryKey(int functionGroupMenu_ID)
	{
		string LOCATION = "GetByPrimaryKey(int functionGroupMenu_ID)";
		try
		{
			return DataAccessLocator.GetFunctionGroupMenuCollection().GetByPrimaryKey(functionGroupMenu_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int functionGroupMenu_ID)
	{
		string LOCATION = "Exist(int functionGroupMenu_ID)";
		try
		{
			return DataAccessLocator.GetFunctionGroupMenuCollection().Exist(functionGroupMenu_ID);
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
			DataAccessLocator.GetFunctionGroupMenuCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(FunctionGroupMenuRow value)
	{
		string LOCATION = "Update(FunctionGroupMenuRow value)";
		try
		{
			return DataAccessLocator.GetFunctionGroupMenuCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(FunctionGroupMenuRow value)
	{
		string LOCATION = "Insert(FunctionGroupMenuRow value)";
		try
		{
			DataAccessLocator.GetFunctionGroupMenuCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int functionGroupMenu_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int functionGroupMenu_ID)";
		try
		{
			return DataAccessLocator.GetFunctionGroupMenuCollection().DeleteByPrimaryKey(functionGroupMenu_ID);
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
			return DataAccessLocator.GetFunctionGroupMenuCollection().Delete(whereSql);
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
			return DataAccessLocator.GetFunctionGroupMenuCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetFunctionGroupMenuCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetFunctionGroupMenuCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

