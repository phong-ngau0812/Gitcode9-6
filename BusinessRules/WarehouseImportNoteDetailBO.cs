// <fileinfo name="WarehouseImportNoteDetailBO.cs">
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
/// The base class for <see cref="WarehouseImportNoteDetailCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseImportNoteDetailCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseImportNoteDetailBO
	: BusinessRulesBase
{



	public WarehouseImportNoteDetailRow GetByPrimaryKey(int WarehouseImportNoteDetail_ID)
	{
		string LOCATION = "GetByPrimaryKey(int WarehouseImportNoteDetail_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().GetByPrimaryKey(WarehouseImportNoteDetail_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public bool DeleteByWarehouseImportNoteID(int WarehouseImportNoteID)
	{
		string LOCATION = "DeleteByWarehouseImportNoteID(int WarehouseImportNoteID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().DeleteByWarehouseImportNoteID(WarehouseImportNoteID);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public DataTable GetByWarehouseImportNoteID(int WarehouseImportNoteID)
	{
		string LOCATION = "GetByWarehouseImportNoteID(int WarehouseImportNoteID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().GetByWarehouseImportNote_IDAsDataTable(WarehouseImportNoteID);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION , ex);
		}
	}



	public bool Exist(int WarehouseImportNoteDetail_ID)
	{
		string LOCATION = "Exist(int WarehouseImportNoteDetail_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().Exist(WarehouseImportNoteDetail_ID);
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
			DataAccessLocator.GetWarehouseImportNoteDetailCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseImportNoteDetailRow value)
	{
		string LOCATION = "Update(WarehouseImportNoteDetailRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().Update(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseImportNoteDetailRow value)
	{
		string LOCATION = "Insert(WarehouseImportNoteDetailRow value)";
		try
		{
			DataAccessLocator.GetWarehouseImportNoteDetailCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int WarehouseImportNoteDetail_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int WarehouseImportNoteDetail_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().DeleteByPrimaryKey(WarehouseImportNoteDetail_ID);
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
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWarehouseImportNoteDetailCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

