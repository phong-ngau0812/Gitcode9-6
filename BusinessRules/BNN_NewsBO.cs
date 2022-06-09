// <fileinfo name="BNN_NewsBO.cs">
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
/// The base class for <see cref="BNN_NewsCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_NewsCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_NewsBO
	: BusinessRulesBase
{



	public BNN_NewsRow GetByPrimaryKey(int news_ID)
	{
		string LOCATION = "GetByPrimaryKey(int news_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCollection().GetByPrimaryKey(news_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public BNN_NewsRow GetNewsCategory(int newsCategory_ID)
	{
		string LOCATION = "GetNewsCategory(int newsCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCollection().GetNewsCategory(newsCategory_ID);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Exist(int news_ID)
	{
		string LOCATION = "Exist(int news_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCollection().Exist(news_ID);
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
			DataAccessLocator.GetBNN_NewsCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_NewsRow value)
	{
		string LOCATION = "Update(BNN_NewsRow value)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_NewsRow value)
	{
		string LOCATION = "Insert(BNN_NewsRow value)";
		try
		{
			DataAccessLocator.GetBNN_NewsCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int news_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int news_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCollection().DeleteByPrimaryKey(news_ID);
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
			return DataAccessLocator.GetBNN_NewsCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_NewsCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_NewsCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_NewsCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

