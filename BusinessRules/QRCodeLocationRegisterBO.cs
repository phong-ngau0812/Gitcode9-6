// <fileinfo name="QRCodeLocationRegisterBO.cs">
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
/// The base class for <see cref="QRCodeLocationRegisterCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeLocationRegisterCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeLocationRegisterBO
	: BusinessRulesBase
{



	public QRCodeLocationRegisterRow GetByPrimaryKey(int qRCodeLocationRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeLocationRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().GetByPrimaryKey(qRCodeLocationRegister_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodeLocationRegister_ID)
	{
		string LOCATION = "Exist(int qRCodeLocationRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().Exist(qRCodeLocationRegister_ID);
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
			DataAccessLocator.GetQRCodeLocationRegisterCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeLocationRegisterRow value)
	{
		string LOCATION = "Update(QRCodeLocationRegisterRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeLocationRegisterRow value)
	{
		string LOCATION = "Insert(QRCodeLocationRegisterRow value)";
		try
		{
			DataAccessLocator.GetQRCodeLocationRegisterCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodeLocationRegister_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodeLocationRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().DeleteByPrimaryKey(qRCodeLocationRegister_ID);
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
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeLocationRegisterCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

