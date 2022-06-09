// <fileinfo name="FunctionGroupBO.cs">
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
/// The base class for <see cref="FunctionGroupCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="FunctionGroupCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class FunctionGroupBO
	: BusinessRulesBase
{



	public FunctionGroupRow GetByPrimaryKey(int functionGroup_ID)
	{
		string LOCATION = "GetByPrimaryKey(int functionGroup_ID)";
		try
		{
			return DataAccessLocator.GetFunctionGroupCollection().GetByPrimaryKey(functionGroup_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int functionGroup_ID)
	{
		string LOCATION = "Exist(int functionGroup_ID)";
		try
		{
			return DataAccessLocator.GetFunctionGroupCollection().Exist(functionGroup_ID);
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
			DataAccessLocator.GetFunctionGroupCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(FunctionGroupRow value)
	{
		string LOCATION = "Update(FunctionGroupRow value)";
		try
		{
			return DataAccessLocator.GetFunctionGroupCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(FunctionGroupRow value)
	{
		string LOCATION = "Insert(FunctionGroupRow value)";
		try
		{
			DataAccessLocator.GetFunctionGroupCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int functionGroup_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int functionGroup_ID)";
		try
		{
			return DataAccessLocator.GetFunctionGroupCollection().DeleteByPrimaryKey(functionGroup_ID);
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
			return DataAccessLocator.GetFunctionGroupCollection().Delete(whereSql);
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
			return DataAccessLocator.GetFunctionGroupCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetFunctionGroupCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetFunctionGroupCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

