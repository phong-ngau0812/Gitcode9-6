
// <fileinfo name="DbObj\WarehouseSlotInforRow.cs">
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
    /// Represents a record in the <c>WarehouseExportNoteDetailSlotRow</c> table.
    /// </summary>
    public class WarehouseExportNoteDetailSlotRow
            : Base.WarehouseExportNoteDetailSlotRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseExportNoteDetailSlotRow"/> class.
        /// </summary>
        public WarehouseExportNoteDetailSlotRow() : base()
        {
            // EMPTY
        }
        public string Position
        {
            set;get;
        }
        public int Stt { set; get; }
        public int ID { set; get; }
    }
}
