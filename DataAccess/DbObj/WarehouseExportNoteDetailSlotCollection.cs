
// <fileinfo name="DbObj\WarehouseSlotInforCollection.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			You can update this source code manually. If the file
//			already exists it will not be rewritten by the generator.
//		</remarks>
//		<generator rewritefile="False" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>


using System;
using System.Data;

namespace DbObj
{

/// <summary>
/// Represents the <c>WarehouseSlotInfor</c> table.
/// </summary>
	public class WarehouseExportNoteDetailSlotCollection
		: Base.WarehouseExportNoteDetailSlotCollectionBase
    {
        public WarehouseExportNoteDetailSlotRow[] GetByWarehouseExportNote_ID(int WarehouseExportNote_ID)
        {
            string LOCATION = "WarehouseExportNoteDetailSlot_GetByWarehouseExportNote_ID(int WarehouseExportNote_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseExportNoteDetailSlot_GetByWarehouseExportNote_ID", CommandType.StoredProcedure);
                AddParameter(cmd, "WarehouseExportNote_ID", WarehouseExportNote_ID);
                WarehouseExportNoteDetailSlotRow[] tempArray = MapRecords(cmd);
                if (0 == tempArray.Length)
                    return null;

                return tempArray;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        public int SlotInforRestore(int SlotInfor_ID,int Amount)
        {
            int result = -1;
            string LOCATION = "WarehouseSlotInfor_ExportRestore(@Amount Int, @SlotInfor_ID int out)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlotInfor_ExportRestore", CommandType.StoredProcedure);
                AddParameter(cmd, "Amount", Amount);
                AddParameter(cmd, "SlotInfor_ID", SlotInfor_ID);
                Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = -9;
            }
            return result;
        }
    }

}
