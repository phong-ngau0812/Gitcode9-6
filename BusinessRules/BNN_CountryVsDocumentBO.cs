// <fileinfo name="BNN_CountryVsDocumentBO.cs">
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
/// The base class for <see cref="BNN_CountryVsDocumentCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_CountryVsDocumentCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_CountryVsDocumentBO
	: BusinessRulesBase
{



	public BNN_CountryVsDocumentRow GetByPrimaryKey(int countryVsDocument_ID)
	{
		string LOCATION = "GetByPrimaryKey(int countryVsDocument_ID)";
		try
		{
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().GetByPrimaryKey(countryVsDocument_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int countryVsDocument_ID)
	{
		string LOCATION = "Exist(int countryVsDocument_ID)";
		try
		{
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().Exist(countryVsDocument_ID);
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
			DataAccessLocator.GetBNN_CountryVsDocumentCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_CountryVsDocumentRow value)
	{
		string LOCATION = "Update(BNN_CountryVsDocumentRow value)";
		try
		{
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_CountryVsDocumentRow value)
	{
		string LOCATION = "Insert(BNN_CountryVsDocumentRow value)";
		try
		{
			DataAccessLocator.GetBNN_CountryVsDocumentCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int countryVsDocument_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int countryVsDocument_ID)";
		try
		{
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().DeleteByPrimaryKey(countryVsDocument_ID);
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
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_CountryVsDocumentCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

