// <fileinfo name="TaskStepAnswerBO.cs">
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
/// The base class for <see cref="TaskStepAnswerCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TaskStepAnswerCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class TaskStepAnswerBO
	: BusinessRulesBase
{



	public TaskStepAnswerRow GetByPrimaryKey(int taskStepAnswer_ID)
	{
		string LOCATION = "GetByPrimaryKey(int taskStepAnswer_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepAnswerCollection().GetByPrimaryKey(taskStepAnswer_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int taskStepAnswer_ID)
	{
		string LOCATION = "Exist(int taskStepAnswer_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepAnswerCollection().Exist(taskStepAnswer_ID);
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
			DataAccessLocator.GetTaskStepAnswerCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(TaskStepAnswerRow value)
	{
		string LOCATION = "Update(TaskStepAnswerRow value)";
		try
		{
			return DataAccessLocator.GetTaskStepAnswerCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(TaskStepAnswerRow value)
	{
		string LOCATION = "Insert(TaskStepAnswerRow value)";
		try
		{
			DataAccessLocator.GetTaskStepAnswerCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int taskStepAnswer_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int taskStepAnswer_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepAnswerCollection().DeleteByPrimaryKey(taskStepAnswer_ID);
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
			return DataAccessLocator.GetTaskStepAnswerCollection().Delete(whereSql);
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
			return DataAccessLocator.GetTaskStepAnswerCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetTaskStepAnswerCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetTaskStepAnswerCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

