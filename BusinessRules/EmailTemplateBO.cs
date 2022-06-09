// <fileinfo name="EmailTemplateBO.cs">
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
/// The base class for <see cref="EmailTemplateCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="EmailTemplateCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class EmailTemplateBO
	: BusinessRulesBase
{



	public EmailTemplateRow GetByPrimaryKey(int emailTemplate_ID)
	{
		string LOCATION = "GetByPrimaryKey(int emailTemplate_ID)";
		try
		{
			return DataAccessLocator.GetEmailTemplateCollection().GetByPrimaryKey(emailTemplate_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int emailTemplate_ID)
	{
		string LOCATION = "Exist(int emailTemplate_ID)";
		try
		{
			return DataAccessLocator.GetEmailTemplateCollection().Exist(emailTemplate_ID);
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
			DataAccessLocator.GetEmailTemplateCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(EmailTemplateRow value)
	{
		string LOCATION = "Update(EmailTemplateRow value)";
		try
		{
			return DataAccessLocator.GetEmailTemplateCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(EmailTemplateRow value)
	{
		string LOCATION = "Insert(EmailTemplateRow value)";
		try
		{
			DataAccessLocator.GetEmailTemplateCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int emailTemplate_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int emailTemplate_ID)";
		try
		{
			return DataAccessLocator.GetEmailTemplateCollection().DeleteByPrimaryKey(emailTemplate_ID);
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
			return DataAccessLocator.GetEmailTemplateCollection().Delete(whereSql);
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
			return DataAccessLocator.GetEmailTemplateCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetEmailTemplateCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetEmailTemplateCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

