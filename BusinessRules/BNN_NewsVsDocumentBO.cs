// <fileinfo name="BNN_NewsVsDocumentBO.cs">
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
/// The base class for <see cref="BNN_NewsVsDocumentCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_NewsVsDocumentCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_NewsVsDocumentBO
	: BusinessRulesBase
{



	public BNN_NewsVsDocumentRow GetByPrimaryKey(int newsVsDocument_ID)
	{
		string LOCATION = "GetByPrimaryKey(int newsVsDocument_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().GetByPrimaryKey(newsVsDocument_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int newsVsDocument_ID)
	{
		string LOCATION = "Exist(int newsVsDocument_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().Exist(newsVsDocument_ID);
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
			DataAccessLocator.GetBNN_NewsVsDocumentCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_NewsVsDocumentRow value)
	{
		string LOCATION = "Update(BNN_NewsVsDocumentRow value)";
		try
		{
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_NewsVsDocumentRow value)
	{
		string LOCATION = "Insert(BNN_NewsVsDocumentRow value)";
		try
		{
			DataAccessLocator.GetBNN_NewsVsDocumentCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int newsVsDocument_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int newsVsDocument_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().DeleteByPrimaryKey(newsVsDocument_ID);
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
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_NewsVsDocumentCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

