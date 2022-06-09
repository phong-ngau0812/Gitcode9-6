// <fileinfo name="QRCodeWarehousePublicBO.cs">
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
/// The base class for <see cref="QRCodeWarehousePublicCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodeWarehousePublicCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodeWarehousePublicBO
	: BusinessRulesBase
{



	public QRCodeWarehousePublicRow GetByPrimaryKey(string QRCodeWarehousePublicContent)
	{
		string LOCATION = "GetByPrimaryKey(string QRCodeWarehousePublicContent)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().GetByPrimaryKey(QRCodeWarehousePublicContent);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(string QRCodeWarehousePublicContent)
	{
		string LOCATION = "Exist(string QRCodeWarehousePublicContent)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().Exist(QRCodeWarehousePublicContent);
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
			DataAccessLocator.GetQRCodeWarehousePublicCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodeWarehousePublicRow value)
	{
		string LOCATION = "Update(QRCodeWarehousePublicRow value)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodeWarehousePublicRow value)
	{
		string LOCATION = "Insert(QRCodeWarehousePublicRow value)";
		try
		{
			DataAccessLocator.GetQRCodeWarehousePublicCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(string QRCodeWarehousePublicContent)
	{
		string LOCATION = "DeleteByPrimaryKey(string QRCodeWarehousePublicContent)";
		try
		{
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().DeleteByPrimaryKey(QRCodeWarehousePublicContent);
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
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodeWarehousePublicCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

