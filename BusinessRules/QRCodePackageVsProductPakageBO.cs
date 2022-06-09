// <fileinfo name="QRCodePackageVsProductPakageBO.cs">
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
/// The base class for <see cref="QRCodePackageVsProductPakageCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="QRCodePackageVsProductPakageCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class QRCodePackageVsProductPakageBO
	: BusinessRulesBase
{



	public QRCodePackageVsProductPakageRow GetByPrimaryKey(int qRCodePackage_ID, int productPackage_ID)
	{
		string LOCATION = "GetByPrimaryKey(int qRCodePackage_ID, int productPackage_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().GetByPrimaryKey(qRCodePackage_ID, productPackage_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int qRCodePackage_ID, int productPackage_ID)
	{
		string LOCATION = "Exist(int qRCodePackage_ID, int productPackage_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().Exist(qRCodePackage_ID, productPackage_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}




	public void Insert(QRCodePackageVsProductPakageRow value)
	{
		string LOCATION = "Insert(QRCodePackageVsProductPakageRow value)";
		try
		{
			DataAccessLocator.GetQRCodePackageVsProductPakageCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int qRCodePackage_ID, int productPackage_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int qRCodePackage_ID, int productPackage_ID)";
		try
		{
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().DeleteByPrimaryKey(qRCodePackage_ID, productPackage_ID);
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
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().Delete(whereSql);
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
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetQRCodePackageVsProductPakageCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

