
// <fileinfo name="DbObj\WarehouseSlotRow.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			You can update this source code manually. If the file
//			already exists it will not be rewritten by the generator.
//		</remarks>
//		<generator rewritefile="False" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>


namespace DbObj
{

    /// <summary>
    /// Represents a record in the <c>WarehouseSlot</c> table.
    /// </summary>
    public class WarehouseSlotRow
            : Base.WarehouseSlotRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseSlotRow"/> class.
        /// </summary>
        public WarehouseSlotRow() : base()
        {
            // EMPTY
        }
        public string Position { set; get; }
    }
}
