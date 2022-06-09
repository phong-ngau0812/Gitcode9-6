// <fileinfo name="QRCodePackageFragment_ESBO.cs">
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
/// The base class for <see cref="QRCodePackageFragment_ESCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodePackageFragment_ESCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodePackageFragment_ESBO
	: BusinessRulesBase
{



	public QRCodePackageFragment_ESRow GetByPrimaryKey(int qRCodePackageFragment_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodePackageFragment_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().GetByPrimaryKey(qRCodePackageFragment_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodePackageFragment_ID)
	{
		string LOCATION = "Exist(int qRCodePackageFragment_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().Exist(qRCodePackageFragment_ID);
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
			DataAccessLocator.GetQRCodePackageFragment_ESCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodePackageFragment_ESRow value)
	{
		string LOCATION = "Update(QRCodePackageFragment_ESRow value)";
		try
		{
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodePackageFragment_ESRow value)
	{
		string LOCATION = "Insert(QRCodePackageFragment_ESRow value)";
		try
		{
			DataAccessLocator.GetQRCodePackageFragment_ESCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodePackageFragment_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodePackageFragment_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().DeleteByPrimaryKey(qRCodePackageFragment_ID);
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
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodePackageFragment_ESCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

