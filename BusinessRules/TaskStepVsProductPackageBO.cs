// <fileinfo name="TaskStepVsProductPackageBO.cs">
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
/// The base class for <see cref="TaskStepVsProductPackageCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TaskStepVsProductPackageCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class TaskStepVsProductPackageBO
	: BusinessRulesBase
{



	public TaskStepVsProductPackageRow GetByPrimaryKey(int taskStepVsProductPackage_ID)
	{
		string LOCATION = "GetByPrimaryKey(int taskStepVsProductPackage_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().GetByPrimaryKey(taskStepVsProductPackage_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int taskStepVsProductPackage_ID)
	{
		string LOCATION = "Exist(int taskStepVsProductPackage_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().Exist(taskStepVsProductPackage_ID);
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
			DataAccessLocator.GetTaskStepVsProductPackageCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(TaskStepVsProductPackageRow value)
	{
		string LOCATION = "Update(TaskStepVsProductPackageRow value)";
		try
		{
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(TaskStepVsProductPackageRow value)
	{
		string LOCATION = "Insert(TaskStepVsProductPackageRow value)";
		try
		{
			DataAccessLocator.GetTaskStepVsProductPackageCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int taskStepVsProductPackage_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int taskStepVsProductPackage_ID)";
		try
		{
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().DeleteByPrimaryKey(taskStepVsProductPackage_ID);
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
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().Delete(whereSql);
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
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetTaskStepVsProductPackageCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

