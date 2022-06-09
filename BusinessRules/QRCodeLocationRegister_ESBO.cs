// <fileinfo name="QRCodeLocationRegister_ESBO.cs">
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
/// The base class for <see cref="QRCodeLocationRegister_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeLocationRegister_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeLocationRegister_ESBO
	: BusinessRulesBase
{



	public QRCodeLocationRegister_ESRow GetByPrimaryKey(int qRCodeLocationRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeLocationRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().GetByPrimaryKey(qRCodeLocationRegister_ID);		
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
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().Exist(qRCodeLocationRegister_ID);
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
			DataAccessLocator.GetQRCodeLocationRegister_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeLocationRegister_ESRow value)
	{
		string LOCATION = "Update(QRCodeLocationRegister_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeLocationRegister_ESRow value)
	{
		string LOCATION = "Insert(QRCodeLocationRegister_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodeLocationRegister_ESCollection().Insert(value);
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
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().DeleteByPrimaryKey(qRCodeLocationRegister_ID);
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
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeLocationRegister_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

