// <fileinfo name="BNN_DocumentCategoryBO.cs">
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
/// The base class for <see cref="BNN_DocumentCategoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_DocumentCategoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_DocumentCategoryBO
	: BusinessRulesBase
{



	public BNN_DocumentCategoryRow GetByPrimaryKey(int documentCategory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int documentCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().GetByPrimaryKey(documentCategory_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int documentCategory_ID)
	{
		string LOCATION = "Exist(int documentCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().Exist(documentCategory_ID);
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
			DataAccessLocator.GetBNN_DocumentCategoryCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_DocumentCategoryRow value)
	{
		string LOCATION = "Update(BNN_DocumentCategoryRow value)";
		try
		{
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_DocumentCategoryRow value)
	{
		string LOCATION = "Insert(BNN_DocumentCategoryRow value)";
		try
		{
			DataAccessLocator.GetBNN_DocumentCategoryCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int documentCategory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int documentCategory_ID)";
		try
		{
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().DeleteByPrimaryKey(documentCategory_ID);
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
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_DocumentCategoryCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

