// <fileinfo name="QRCodeWarehouseRegisterBO.cs">
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
/// The base class for <see cref="QRCodeWarehouseRegisterCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWarehouseRegisterCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeWarehouseRegisterBO
	: BusinessRulesBase
{



	public QRCodeWarehouseRegisterRow GetByPrimaryKey(int qRCodeWarehouseRegister_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodeWarehouseRegister_ID)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().GetByPrimaryKey(qRCodeWarehouseRegister_ID);		
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
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().Exist(qRCodeWarehouseRegister_ID);
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
			DataAccessLocator.GetQRCodeWarehouseRegisterCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeWarehouseRegisterRow value)
	{
		string LOCATION = "Update(QRCodeWarehouseRegisterRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeWarehouseRegisterRow value)
	{
		string LOCATION = "Insert(QRCodeWarehouseRegisterRow value)";
		try
		{
			DataAccessLocator.GetQRCodeWarehouseRegisterCollection().Insert(value);
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
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().DeleteByPrimaryKey(qRCodeWarehouseRegister_ID);
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
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeWarehouseRegisterCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

