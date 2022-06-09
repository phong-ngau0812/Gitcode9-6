// <fileinfo name="QRCodePackageRule_ESBO.cs">
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
/// The base class for <see cref="QRCodePackageRule_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodePackageRule_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodePackageRule_ESBO
	: BusinessRulesBase
{



	public QRCodePackageRule_ESRow GetByPrimaryKey(int qRCodePackageRule_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodePackageRule_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().GetByPrimaryKey(qRCodePackageRule_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodePackageRule_ID)
	{
		string LOCATION = "Exist(int qRCodePackageRule_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().Exist(qRCodePackageRule_ID);
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
			DataAccessLocator.GetQRCodePackageRule_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodePackageRule_ESRow value)
	{
		string LOCATION = "Update(QRCodePackageRule_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodePackageRule_ESRow value)
	{
		string LOCATION = "Insert(QRCodePackageRule_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodePackageRule_ESCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodePackageRule_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodePackageRule_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().DeleteByPrimaryKey(qRCodePackageRule_ID);
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
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodePackageRule_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

