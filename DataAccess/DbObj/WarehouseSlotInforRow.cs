
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


namespace DbObj
{

    /// <summary>
    /// Represents a record in the <c>WarehouseSlotInfor</c> table.
    /// </summary>
    public class WarehouseSlotInforRow
            : Base.WarehouseSlotInforRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseSlotInforRow"/> class.
        /// </summary>
        public WarehouseSlotInforRow() : base()
        {
            // EMPTY
        }
        public string Position { set; get; }
        public int Stt { set; get; }
        public int ID { set; get; }
    }
}
