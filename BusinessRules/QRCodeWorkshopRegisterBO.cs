// <fileinfo name="QRCodeWorkshopRegisterBO.cs">
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
/// The base class for <see cref="QRCodeWorkshopRegisterCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWorkshopRegisterCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeWorkshopRegisterBO
	: BusinessRulesBase
{



	public QRCodeWorkshopRegisterRow GetByPrimaryKey(int qRCodeWorkshopRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeWorkshopRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().GetByPrimaryKey(qRCodeWorkshopRegister_ID);		
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
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().Exist(qRCodeWorkshopRegister_ID);
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
			DataAccessLocator.GetQRCodeWorkshopRegisterCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeWorkshopRegisterRow value)
	{
		string LOCATION = "Update(QRCodeWorkshopRegisterRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeWorkshopRegisterRow value)
	{
		string LOCATION = "Insert(QRCodeWorkshopRegisterRow value)";
		try
		{
			DataAccessLocator.GetQRCodeWorkshopRegisterCollection().Insert(value);
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
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().DeleteByPrimaryKey(qRCodeWorkshopRegister_ID);
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
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeWorkshopRegisterCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

