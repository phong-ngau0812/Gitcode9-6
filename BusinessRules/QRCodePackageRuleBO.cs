// <fileinfo name="QRCodePackageRuleBO.cs">
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
/// The base class for <see cref="QRCodePackageRuleCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodePackageRuleCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodePackageRuleBO
	: BusinessRulesBase
{



	public QRCodePackageRuleRow GetByPrimaryKey(int qRCodePackageRule_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodePackageRule_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRuleCollection().GetByPrimaryKey(qRCodePackageRule_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodePackageRule_ID)
	{
		string LOCATION = "Exist(int qRCodePackageRule_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRuleCollection().Exist(qRCodePackageRule_ID);
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
			DataAccessLocator.GetQRCodePackageRuleCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(QRCodePackageRuleRow value)
	{
		string LOCATION = "Update(QRCodePackageRuleRow value)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRuleCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(QRCodePackageRuleRow value)
	{
		string LOCATION = "Insert(QRCodePackageRuleRow value)";
		try
		{
			DataAccessLocator.GetQRCodePackageRuleCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodePackageRule_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodePackageRule_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageRuleCollection().DeleteByPrimaryKey(qRCodePackageRule_ID);
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
			return DataAccessLocator.GetQRCodePackageRuleCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodePackageRuleCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodePackageRuleCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodePackageRuleCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

