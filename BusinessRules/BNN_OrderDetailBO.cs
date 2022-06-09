// <fileinfo name="BNN_OrderDetailBO.cs">
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
/// The base class for <see cref="BNN_OrderDetailCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="BNN_OrderDetailCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class BNN_OrderDetailBO
	: BusinessRulesBase
{



	public BNN_OrderDetailRow GetByPrimaryKey(int orderDetail_ID)
	{
		string LOCATION = "GetByPrimaryKey(int orderDetail_ID)";
		try
		{
			return DataAccessLocator.GetBNN_OrderDetailCollection().GetByPrimaryKey(orderDetail_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int orderDetail_ID)
	{
		string LOCATION = "Exist(int orderDetail_ID)";
		try
		{
			return DataAccessLocator.GetBNN_OrderDetailCollection().Exist(orderDetail_ID);
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
			DataAccessLocator.GetBNN_OrderDetailCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(BNN_OrderDetailRow value)
	{
		string LOCATION = "Update(BNN_OrderDetailRow value)";
		try
		{
			return DataAccessLocator.GetBNN_OrderDetailCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(BNN_OrderDetailRow value)
	{
		string LOCATION = "Insert(BNN_OrderDetailRow value)";
		try
		{
			DataAccessLocator.GetBNN_OrderDetailCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int orderDetail_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int orderDetail_ID)";
		try
		{
			return DataAccessLocator.GetBNN_OrderDetailCollection().DeleteByPrimaryKey(orderDetail_ID);
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
			return DataAccessLocator.GetBNN_OrderDetailCollection().Delete(whereSql);
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
			return DataAccessLocator.GetBNN_OrderDetailCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetBNN_OrderDetailCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetBNN_OrderDetailCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

