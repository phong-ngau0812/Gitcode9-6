// <fileinfo name="QRCodeWorkshopRegister_ESBO.cs">
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
/// The base class for <see cref="QRCodeWorkshopRegister_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWorkshopRegister_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeWorkshopRegister_ESBO
	: BusinessRulesBase
{



	public QRCodeWorkshopRegister_ESRow GetByPrimaryKey(int qRCodeWorkshopRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeWorkshopRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().GetByPrimaryKey(qRCodeWorkshopRegister_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodeWorkshopRegister_ID)
	{
		string LOCATION = "Exist(int qRCodeWorkshopRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().Exist(qRCodeWorkshopRegister_ID);
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
			DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeWorkshopRegister_ESRow value)
	{
		string LOCATION = "Update(QRCodeWorkshopRegister_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeWorkshopRegister_ESRow value)
	{
		string LOCATION = "Insert(QRCodeWorkshopRegister_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodeWorkshopRegister_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodeWorkshopRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().DeleteByPrimaryKey(qRCodeWorkshopRegister_ID);
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
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeWorkshopRegister_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

