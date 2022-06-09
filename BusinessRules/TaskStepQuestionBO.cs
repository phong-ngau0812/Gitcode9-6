// <fileinfo name="TaskStepQuestionBO.cs">
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
/// The base class for <see cref="TaskStepQuestionCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TaskStepQuestionCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class TaskStepQuestionBO
	: BusinessRulesBase
{



	public TaskStepQuestionRow GetByPrimaryKey(int taskStepQuestion_ID)
	{
		string LOCATION = "GetByPrimaryKey(int taskStepQuestion_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepQuestionCollection().GetByPrimaryKey(taskStepQuestion_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int taskStepQuestion_ID)
	{
		string LOCATION = "Exist(int taskStepQuestion_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepQuestionCollection().Exist(taskStepQuestion_ID);
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
			DataAccessLocator.GetTaskStepQuestionCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(TaskStepQuestionRow value)
	{
		string LOCATION = "Update(TaskStepQuestionRow value)";
		try
		{
			return DataAccessLocator.GetTaskStepQuestionCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(TaskStepQuestionRow value)
	{
		string LOCATION = "Insert(TaskStepQuestionRow value)";
		try
		{
			DataAccessLocator.GetTaskStepQuestionCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int taskStepQuestion_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int taskStepQuestion_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepQuestionCollection().DeleteByPrimaryKey(taskStepQuestion_ID);
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
			return DataAccessLocator.GetTaskStepQuestionCollection().Delete(whereSql);
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
			return DataAccessLocator.GetTaskStepQuestionCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetTaskStepQuestionCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetTaskStepQuestionCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

