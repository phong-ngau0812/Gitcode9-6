// <fileinfo name="TestingCertificatesBO.cs">
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
/// The base class for <see cref="TestingCertificatesCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="TestingCertificatesCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class TestingCertificatesBO
	: BusinessRulesBase
{



	public TestingCertificatesRow GetByPrimaryKey(int testingCertificates_ID)
	{
		string LOCATION = "GetByPrimaryKey(int testingCertificates_ID)";
		try
		{
			return DataAccessLocator.GetTestingCertificatesCollection().GetByPrimaryKey(testingCertificates_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int testingCertificates_ID)
	{
		string LOCATION = "Exist(int testingCertificates_ID)";
		try
		{
			return DataAccessLocator.GetTestingCertificatesCollection().Exist(testingCertificates_ID);
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
			DataAccessLocator.GetTestingCertificatesCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(TestingCertificatesRow value)
	{
		string LOCATION = "Update(TestingCertificatesRow value)";
		try
		{
			return DataAccessLocator.GetTestingCertificatesCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(TestingCertificatesRow value)
	{
		string LOCATION = "Insert(TestingCertificatesRow value)";
		try
		{
			DataAccessLocator.GetTestingCertificatesCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int testingCertificates_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int testingCertificates_ID)";
		try
		{
			return DataAccessLocator.GetTestingCertificatesCollection().DeleteByPrimaryKey(testingCertificates_ID);
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
			return DataAccessLocator.GetTestingCertificatesCollection().Delete(whereSql);
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
			return DataAccessLocator.GetTestingCertificatesCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetTestingCertificatesCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetTestingCertificatesCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

