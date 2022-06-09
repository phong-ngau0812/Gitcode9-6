// <fileinfo name="WH_DeliveryNoteVsMaterialBO.cs">
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
/// The base class for <see cref="WH_DeliveryNoteVsMaterialCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WH_DeliveryNoteVsMaterialCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WH_DeliveryNoteVsMaterialBO
	: BusinessRulesBase
{



	public WH_DeliveryNoteVsMaterialRow GetByPrimaryKey(int wH_DeliveryNoteVsMaterial_ID)
	{
		string LOCATION = "GetByPrimaryKey(int wH_DeliveryNoteVsMaterial_ID)";
		try
		{
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().GetByPrimaryKey(wH_DeliveryNoteVsMaterial_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int wH_DeliveryNoteVsMaterial_ID)
	{
		string LOCATION = "Exist(int wH_DeliveryNoteVsMaterial_ID)";
		try
		{
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().Exist(wH_DeliveryNoteVsMaterial_ID);
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
			DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WH_DeliveryNoteVsMaterialRow value)
	{
		string LOCATION = "Update(WH_DeliveryNoteVsMaterialRow value)";
		try
		{
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WH_DeliveryNoteVsMaterialRow value)
	{
		string LOCATION = "Insert(WH_DeliveryNoteVsMaterialRow value)";
		try
		{
			DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int wH_DeliveryNoteVsMaterial_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int wH_DeliveryNoteVsMaterial_ID)";
		try
		{
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().DeleteByPrimaryKey(wH_DeliveryNoteVsMaterial_ID);
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
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWH_DeliveryNoteVsMaterialCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

