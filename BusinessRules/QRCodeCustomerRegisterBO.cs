// <fileinfo name="QRCodeCustomerRegisterBO.cs">
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
/// The base class for <see cref="QRCodeCustomerRegisterCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeCustomerRegisterCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeCustomerRegisterBO
	: BusinessRulesBase
{



	public QRCodeCustomerRegisterRow GetByPrimaryKey(int qRCodeCustomerRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeCustomerRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().GetByPrimaryKey(qRCodeCustomerRegister_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodeCustomerRegister_ID)
	{
		string LOCATION = "Exist(int qRCodeCustomerRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().Exist(qRCodeCustomerRegister_ID);
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
			DataAccessLocator.GetQRCodeCustomerRegisterCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeCustomerRegisterRow value)
	{
		string LOCATION = "Update(QRCodeCustomerRegisterRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeCustomerRegisterRow value)
	{
		string LOCATION = "Insert(QRCodeCustomerRegisterRow value)";
		try
		{
			DataAccessLocator.GetQRCodeCustomerRegisterCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodeCustomerRegister_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodeCustomerRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().DeleteByPrimaryKey(qRCodeCustomerRegister_ID);
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
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeCustomerRegisterCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

