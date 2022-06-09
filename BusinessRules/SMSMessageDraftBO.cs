// <fileinfo name="SMSMessageDraftBO.cs">
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
/// The base class for <see cref="SMSMessageDraftCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="SMSMessageDraftCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class SMSMessageDraftBO
	: BusinessRulesBase
{



	public SMSMessageDraftRow GetByPrimaryKey(int sMSMessageDraft_ID)
	{
		string LOCATION = "GetByPrimaryKey(int sMSMessageDraft_ID)";
		try
		{
			return DataAccessLocator.GetSMSMessageDraftCollection().GetByPrimaryKey(sMSMessageDraft_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int sMSMessageDraft_ID)
	{
		string LOCATION = "Exist(int sMSMessageDraft_ID)";
		try
		{
			return DataAccessLocator.GetSMSMessageDraftCollection().Exist(sMSMessageDraft_ID);
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
			DataAccessLocator.GetSMSMessageDraftCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(SMSMessageDraftRow value)
	{
		string LOCATION = "Update(SMSMessageDraftRow value)";
		try
		{
			return DataAccessLocator.GetSMSMessageDraftCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(SMSMessageDraftRow value)
	{
		string LOCATION = "Insert(SMSMessageDraftRow value)";
		try
		{
			DataAccessLocator.GetSMSMessageDraftCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int sMSMessageDraft_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int sMSMessageDraft_ID)";
		try
		{
			return DataAccessLocator.GetSMSMessageDraftCollection().DeleteByPrimaryKey(sMSMessageDraft_ID);
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
			return DataAccessLocator.GetSMSMessageDraftCollection().Delete(whereSql);
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
			return DataAccessLocator.GetSMSMessageDraftCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetSMSMessageDraftCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetSMSMessageDraftCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

