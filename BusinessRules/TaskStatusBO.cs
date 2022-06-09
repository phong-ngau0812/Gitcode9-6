// <fileinfo name="TaskStatusBO.cs">
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
/// The base class for <see cref="TaskStatusCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TaskStatusCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class TaskStatusBO
	: BusinessRulesBase
{



	public TaskStatusRow GetByPrimaryKey(int taskStatus_ID)
	{
		string LOCATION = "GetByPrimaryKey(int taskStatus_ID)";
		try
		{
			return DataAccessLocator.GetTaskStatusCollection().GetByPrimaryKey(taskStatus_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int taskStatus_ID)
	{
		string LOCATION = "Exist(int taskStatus_ID)";
		try
		{
			return DataAccessLocator.GetTaskStatusCollection().Exist(taskStatus_ID);
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
			DataAccessLocator.GetTaskStatusCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(TaskStatusRow value)
	{
		string LOCATION = "Update(TaskStatusRow value)";
		try
		{
			return DataAccessLocator.GetTaskStatusCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(TaskStatusRow value)
	{
		string LOCATION = "Insert(TaskStatusRow value)";
		try
		{
			DataAccessLocator.GetTaskStatusCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int taskStatus_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int taskStatus_ID)";
		try
		{
			return DataAccessLocator.GetTaskStatusCollection().DeleteByPrimaryKey(taskStatus_ID);
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
			return DataAccessLocator.GetTaskStatusCollection().Delete(whereSql);
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
			return DataAccessLocator.GetTaskStatusCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetTaskStatusCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetTaskStatusCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

