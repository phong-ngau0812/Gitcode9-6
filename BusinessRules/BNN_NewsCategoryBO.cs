// <fileinfo name="BNN_NewsCategoryBO.cs">
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
/// The base class for <see cref="BNN_NewsCategoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_NewsCategoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_NewsCategoryBO
	: BusinessRulesBase
{



	public BNN_NewsCategoryRow GetByPrimaryKey(int newsCategory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int newsCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCategoryCollection().GetByPrimaryKey(newsCategory_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int newsCategory_ID)
	{
		string LOCATION = "Exist(int newsCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCategoryCollection().Exist(newsCategory_ID);
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
			DataAccessLocator.GetBNN_NewsCategoryCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_NewsCategoryRow value)
	{
		string LOCATION = "Update(BNN_NewsCategoryRow value)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCategoryCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_NewsCategoryRow value)
	{
		string LOCATION = "Insert(BNN_NewsCategoryRow value)";
		try
		{
			DataAccessLocator.GetBNN_NewsCategoryCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int newsCategory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int newsCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_NewsCategoryCollection().DeleteByPrimaryKey(newsCategory_ID);
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
			return DataAccessLocator.GetBNN_NewsCategoryCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_NewsCategoryCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_NewsCategoryCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_NewsCategoryCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

