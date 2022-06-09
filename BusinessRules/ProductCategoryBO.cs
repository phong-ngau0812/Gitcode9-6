// <fileinfo name="ProductCategoryBO.cs">
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
/// The base class for <see cref="ProductCategoryCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="ProductCategoryCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class ProductCategoryBO
	: BusinessRulesBase
{



	public ProductCategoryRow GetByPrimaryKey(int productCategory_ID)
	{
		string LOCATION = "GetByPrimaryKey(int productCategory_ID)";
		try
		{
			return DataAccessLocator.GetProductCategoryCollection().GetByPrimaryKey(productCategory_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int productCategory_ID)
	{
		string LOCATION = "Exist(int productCategory_ID)";
		try
		{
			return DataAccessLocator.GetProductCategoryCollection().Exist(productCategory_ID);
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
			DataAccessLocator.GetProductCategoryCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(ProductCategoryRow value)
	{
		string LOCATION = "Update(ProductCategoryRow value)";
		try
		{
			return DataAccessLocator.GetProductCategoryCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(ProductCategoryRow value)
	{
		string LOCATION = "Insert(ProductCategoryRow value)";
		try
		{
			DataAccessLocator.GetProductCategoryCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int productCategory_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int productCategory_ID)";
		try
		{
			return DataAccessLocator.GetProductCategoryCollection().DeleteByPrimaryKey(productCategory_ID);
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
			return DataAccessLocator.GetProductCategoryCollection().Delete(whereSql);
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
			return DataAccessLocator.GetProductCategoryCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetProductCategoryCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetProductCategoryCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}


	
	public ProductCategoryRow[] GetByLanguage_ID(int language_ID)
	{
		string LOCATION = "GetByLanguage_ID(int language_ID)";
		try
		{
			return DataAccessLocator.GetProductCategoryCollection().GetByLanguage_ID(language_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	
	public DataTable GetByLanguage_IDAsDataTable(int language_ID)
	{
		string LOCATION = "GetByLanguage_ID(int language_ID)";
		try
		{
			return DataAccessLocator.GetProductCategoryCollection().GetByLanguage_IDAsDataTable(language_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	


}

