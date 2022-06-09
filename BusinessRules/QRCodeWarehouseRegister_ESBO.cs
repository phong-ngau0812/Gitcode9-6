// <fileinfo name="QRCodeWarehouseRegister_ESBO.cs">
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
/// The base class for <see cref="QRCodeWarehouseRegister_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWarehouseRegister_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeWarehouseRegister_ESBO
	: BusinessRulesBase
{



	public QRCodeWarehouseRegister_ESRow GetByPrimaryKey(int qRCodeWarehouseRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeWarehouseRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().GetByPrimaryKey(qRCodeWarehouseRegister_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodeWarehouseRegister_ID)
	{
		string LOCATION = "Exist(int qRCodeWarehouseRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().Exist(qRCodeWarehouseRegister_ID);
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
			DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeWarehouseRegister_ESRow value)
	{
		string LOCATION = "Update(QRCodeWarehouseRegister_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeWarehouseRegister_ESRow value)
	{
		string LOCATION = "Insert(QRCodeWarehouseRegister_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodeWarehouseRegister_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodeWarehouseRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().DeleteByPrimaryKey(qRCodeWarehouseRegister_ID);
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
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeWarehouseRegister_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

