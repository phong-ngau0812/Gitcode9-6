// <fileinfo name="FCMMessageForTokkenBO.cs">
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
/// The base class for <see cref="FCMMessageForTokkenCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="FCMMessageForTokkenCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class FCMMessageForTokkenBO
	: BusinessRulesBase
{



	public FCMMessageForTokkenRow GetByPrimaryKey(int fCMMessageForTokken_ID)
	{
		string LOCATION = "GetByPrimaryKey(int fCMMessageForTokken_ID)";
		try
		{
			return DataAccessLocator.GetFCMMessageForTokkenCollection().GetByPrimaryKey(fCMMessageForTokken_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int fCMMessageForTokken_ID)
	{
		string LOCATION = "Exist(int fCMMessageForTokken_ID)";
		try
		{
			return DataAccessLocator.GetFCMMessageForTokkenCollection().Exist(fCMMessageForTokken_ID);
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
			DataAccessLocator.GetFCMMessageForTokkenCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(FCMMessageForTokkenRow value)
	{
		string LOCATION = "Update(FCMMessageForTokkenRow value)";
		try
		{
			return DataAccessLocator.GetFCMMessageForTokkenCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(FCMMessageForTokkenRow value)
	{
		string LOCATION = "Insert(FCMMessageForTokkenRow value)";
		try
		{
			DataAccessLocator.GetFCMMessageForTokkenCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int fCMMessageForTokken_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int fCMMessageForTokken_ID)";
		try
		{
			return DataAccessLocator.GetFCMMessageForTokkenCollection().DeleteByPrimaryKey(fCMMessageForTokken_ID);
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
			return DataAccessLocator.GetFCMMessageForTokkenCollection().Delete(whereSql);
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
			return DataAccessLocator.GetFCMMessageForTokkenCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetFCMMessageForTokkenCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetFCMMessageForTokkenCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

