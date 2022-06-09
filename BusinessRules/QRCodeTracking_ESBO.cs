// <fileinfo name="QRCodeTracking_ESBO.cs">
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
/// The base class for <see cref="QRCodeTracking_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeTracking_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeTracking_ESBO
	: BusinessRulesBase
{



	public QRCodeTracking_ESRow GetByPrimaryKey(decimal qRCodeTracking_ID)
	{
		string LOCATION = "GetByPrimaryKey(decimal qRCodeTracking_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeTracking_ESCollection().GetByPrimaryKey(qRCodeTracking_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(decimal qRCodeTracking_ID)
	{
		string LOCATION = "Exist(decimal qRCodeTracking_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeTracking_ESCollection().Exist(qRCodeTracking_ID);
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
			DataAccessLocator.GetQRCodeTracking_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeTracking_ESRow value)
	{
		string LOCATION = "Update(QRCodeTracking_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeTracking_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeTracking_ESRow value)
	{
		string LOCATION = "Insert(QRCodeTracking_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodeTracking_ESCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(decimal qRCodeTracking_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(decimal qRCodeTracking_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeTracking_ESCollection().DeleteByPrimaryKey(qRCodeTracking_ID);
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
			return DataAccessLocator.GetQRCodeTracking_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeTracking_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeTracking_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeTracking_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

