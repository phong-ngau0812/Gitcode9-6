// <fileinfo name="QRCodePackage_ESBO.cs">
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
/// The base class for <see cref="QRCodePackage_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodePackage_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodePackage_ESBO
	: BusinessRulesBase
{



	public QRCodePackage_ESRow GetByPrimaryKey(int qRCodePackage_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodePackage_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackage_ESCollection().GetByPrimaryKey(qRCodePackage_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodePackage_ID)
	{
		string LOCATION = "Exist(int qRCodePackage_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackage_ESCollection().Exist(qRCodePackage_ID);
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
			DataAccessLocator.GetQRCodePackage_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodePackage_ESRow value)
	{
		string LOCATION = "Update(QRCodePackage_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodePackage_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodePackage_ESRow value)
	{
		string LOCATION = "Insert(QRCodePackage_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodePackage_ESCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodePackage_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodePackage_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackage_ESCollection().DeleteByPrimaryKey(qRCodePackage_ID);
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
			return DataAccessLocator.GetQRCodePackage_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodePackage_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodePackage_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodePackage_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

