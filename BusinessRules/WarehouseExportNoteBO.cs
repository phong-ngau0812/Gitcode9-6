// <fileinfo name="WarehouseExportNoteBO.cs">
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
/// The base class for <see cref="WarehouseExportNoteCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseExportNoteCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseExportNoteBO
	: BusinessRulesBase
{



	public WarehouseExportNoteRow GetByPrimaryKey(int WarehouseExportNote_ID)
	{
		string LOCATION = "GetByPrimaryKey(int WarehouseExportNote_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteCollection().GetByPrimaryKey(WarehouseExportNote_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int WarehouseExportNote_ID)
	{
		string LOCATION = "Exist(int WarehouseExportNote_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteCollection().Exist(WarehouseExportNote_ID);
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
			DataAccessLocator.GetWarehouseExportNoteCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseExportNoteRow value)
	{
		string LOCATION = "Update(WarehouseExportNoteRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseExportNoteRow value)
	{
		string LOCATION = "Insert(WarehouseExportNoteRow value)";
		try
		{
			DataAccessLocator.GetWarehouseExportNoteCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int WarehouseExportNote_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int WarehouseExportNote_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteCollection().DeleteByPrimaryKey(WarehouseExportNote_ID);
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
			return DataAccessLocator.GetWarehouseExportNoteCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWarehouseExportNoteCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWarehouseExportNoteCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWarehouseExportNoteCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

