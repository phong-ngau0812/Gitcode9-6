// <fileinfo name="WarehouseSlotInforBO.cs">
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
/// The base class for <see cref="WarehouseSlotInforCollection"/>. Provides methods 
/// for common database table operations. 
/// </summary>
/// <remarks>
/// Do not change this source code. Update the <see cref="WarehouseSlotInforCollection"/>
/// class if you need to add or change some functionality.
/// </remarks>
public class WarehouseSlotInforBO
    : BusinessRulesBase
{



    public WarehouseSlotInforRow GetByPrimaryKey(int slotInfor_ID)
    {
        string LOCATION = "GetByPrimaryKey(int slotInfor_ID)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().GetByPrimaryKey(slotInfor_ID);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }
    public int UpdateAmount(int Slot_ID, int Amount, string Serial)
    {
        string LOCATION = "UpdateAmount(int  Slot_ID,int Amount, string Serial)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().UpdateAmount(Slot_ID, Amount, Serial);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }
    public WarehouseSlotInforRow[] GetBySlot_ID(int slot_ID)
    {
        string LOCATION = "GetBySlot_ID(int slot_ID)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().GetBySlot_ID(slot_ID);
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
            return DataAccessLocator.GetWarehouseSlotInforCollection().Exist(slot_ID);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }


    public void Update(DataTable table)
    {
        string LOCATION = "Update(DataTable table)";
        try
        {
            DataAccessLocator.GetWarehouseSlotInforCollection().Update(table, true);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }

    public bool Update(WarehouseSlotInforRow value)
    {
        string LOCATION = "Update(WarehouseSlotInforRow value)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().Save(value);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }
    public bool Save(WarehouseSlotInforRow value)
    {
        string LOCATION = "Save(WarehouseSlotInforRow value)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().Save(value);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }

    public void Insert(WarehouseSlotInforRow value)
    {
        string LOCATION = "Insert(WarehouseSlotInforRow value)";
        try
        {
            DataAccessLocator.GetWarehouseSlotInforCollection().Insert(value);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }

    public bool DeleteByPrimaryKey(int slotInfor_ID)
    {
        string LOCATION = "DeleteByPrimaryKey(int slotInfor_ID)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().DeleteByPrimaryKey(slotInfor_ID);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }
    public bool DeleteBySlot_ID(int slot_ID)
    {
        string LOCATION = "DeleteBySlot_ID(int slot_ID)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().DeleteBySlot_ID(slot_ID);
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
            return DataAccessLocator.GetWarehouseSlotInforCollection().Delete(whereSql);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }

    public DataTable GetAllAsDataTable()
    {
        string LOCATION = "GetAllAsDataTable()";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().GetAllAsDataTable();
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }

    public DataTable GetAsDataTable(string whereSql, string orderBySql)
    {
        string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().GetAsDataTable(whereSql, orderBySql);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }

    public DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
    {
        string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
        try
        {
            return DataAccessLocator.GetWarehouseSlotInforCollection().GetAsDataTable(whereSql, orderBySql, startIndex, length, ref totalRecordCount);
        }
        catch (Exception ex)
        {
            throw new Exceptions.BusinessException(LOCATION, ex);
        }
    }



}

