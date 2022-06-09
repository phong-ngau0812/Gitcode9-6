// <fileinfo name="WarehouseExportNoteDetailSlotBO.cs">
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
/// The base class for <see cref="WarehouseExportNoteDetailSlotCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseExportNoteDetailSlotCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public  class WarehouseExportNoteDetailSlotBO
	: BusinessRulesBase
{



	public WarehouseExportNoteDetailSlotRow GetByPrimaryKey(int slotInfor_ID)
	{
		string LOCATION = "GetByPrimaryKey(int slotInfor_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().GetByPrimaryKey(slotInfor_ID);		
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public WarehouseExportNoteDetailSlotRow[] GetByWarehouseExportNoteDetail_ID(int WarehouseExportNoteDetail_ID)
	{
		string LOCATION = "GetByWarehouseExportNoteDetail_ID(int slot_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().GetByWarehouseExportNoteDetail_ID(WarehouseExportNoteDetail_ID);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



	public bool Exist(int slot_ID)
	{
		string LOCATION = "Exist(int slot_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().Exist(slot_ID);
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
			DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().Update(table, true);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool Update(WarehouseExportNoteDetailSlotRow value)
	{
		string LOCATION = "Update(WarehouseExportNoteDetailSlotRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().Save(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public bool Save(WarehouseExportNoteDetailSlotRow value)
	{
		string LOCATION = "Save(WarehouseExportNoteDetailSlotRow value)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().Save(value);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public void Insert(WarehouseExportNoteDetailSlotRow value)
	{
		string LOCATION = "Insert(WarehouseExportNoteDetailSlotRow value)";
		try
		{
			DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().Insert(value);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public bool DeleteByPrimaryKey(int slotInfor_ID)
	{
		string LOCATION = "DeleteByPrimaryKey(int slotInfor_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().DeleteByPrimaryKey(slotInfor_ID);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}
	public bool DeleteByWarehouseExportNoteDetail_ID(int WarehouseExportNoteDetail_ID)
	{
		string LOCATION = "DeleteByWarehouseExportNoteDetail_ID(int WarehouseExportNoteDetail_ID)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().DeleteByWarehouseExportNoteDetail_ID(WarehouseExportNoteDetail_ID);
		}
		catch (Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}

	public int Delete(string whereSql)
	{
		string LOCATION = "Delete(string whereSql)";
		try
		{
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().Delete(whereSql);
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
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().GetAllAsDataTable();
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
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().GetAsDataTable(whereSql, orderBySql);
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
			return DataAccessLocator.GetWarehouseExportNoteDetailSlotCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
		}
		catch(Exception ex)
		{
			throw new Exceptions.BusinessException(LOCATION, ex);
		}
	}



}

