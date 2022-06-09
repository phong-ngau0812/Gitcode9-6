// <fileinfo name="QRCodeWarehouseSecretBO.cs">
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
/// The base class for <see cref="QRCodeWarehouseSecretCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWarehouseSecretCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeWarehouseSecretBO
	: BusinessRulesBase
{



	public QRCodeWarehouseSecretRow GetByPrimaryKey(string QRCodeWarehouseSecretContent)
	{
		string LOCATION = "GetByPrimaryKey(string QRCodeWarehouseSecretContent)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().GetByPrimaryKey(QRCodeWarehouseSecretContent);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(string QRCodeWarehouseSecretContent)
	{
		string LOCATION = "Exist(string QRCodeWarehouseSecretContent)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().Exist(QRCodeWarehouseSecretContent);
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
			DataAccessLocator.GetQRCodeWarehouseSecretCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeWarehouseSecretRow value)
	{
		string LOCATION = "Update(QRCodeWarehouseSecretRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeWarehouseSecretRow value)
	{
		string LOCATION = "Insert(QRCodeWarehouseSecretRow value)";
		try
		{
			DataAccessLocator.GetQRCodeWarehouseSecretCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(string QRCodeWarehouseSecretContent)
	{
		string LOCATION = "DeleteByPrimaryKey(string QRCodeWarehouseSecretContent)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().DeleteByPrimaryKey(QRCodeWarehouseSecretContent);
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
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeWarehouseSecretCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

