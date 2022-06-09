// <fileinfo name="WarehouseImportNoteBO.cs">
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
/// The base class for <see cref="WarehouseImportNoteCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseImportNoteCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseImportNoteBO
	: BusinessRulesBase
{



	public WarehouseImportNoteRow GetByPrimaryKey(int WarehouseImportNote_ID)
	{
		string LOCATION = "GetByPrimaryKey(int WarehouseImportNote_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteCollection().GetByPrimaryKey(WarehouseImportNote_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int WarehouseImportNote_ID)
	{
		string LOCATION = "Exist(int WarehouseImportNote_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteCollection().Exist(WarehouseImportNote_ID);
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
			DataAccessLocator.GetWarehouseImportNoteCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseImportNoteRow value)
	{
		string LOCATION = "Update(WarehouseImportNoteRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseImportNoteRow value)
	{
		string LOCATION = "Insert(WarehouseImportNoteRow value)";
		try
		{
			DataAccessLocator.GetWarehouseImportNoteCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int WarehouseImportNote_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int WarehouseImportNote_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteCollection().DeleteByPrimaryKey(WarehouseImportNote_ID);
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
			return DataAccessLocator.GetWarehouseImportNoteCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWarehouseImportNoteCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWarehouseImportNoteCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWarehouseImportNoteCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

