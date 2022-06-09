
// <fileinfo name="DbObj\WarehouseExportNoteDetailRow.cs">
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
    /// Represents a record in the <c>WarehouseExportNoteDetail</c> table.
    /// </summary>
    public class WarehouseExportNoteDetailRow
            : Base.WarehouseExportNoteDetailRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseExportNoteDetailRow"/> class.
        /// </summary>
        public WarehouseExportNoteDetailRow() : base()
        {
            // EMPTY
        }
        private int stt;

        public int STT { get => stt; set => stt = value; }
        public string Position { set; get; }
        public int ID { set; get; }
    }
}
