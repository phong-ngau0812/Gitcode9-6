
// <fileinfo name="DbObj\WarehouseImportNoteDetailRow.cs">
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
    /// Represents a record in the <c>WarehouseImportNoteDetail</c> table.
    /// </summary>
    public class WarehouseImportNoteDetailRow
            : Base.WarehouseImportNoteDetailRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseImportNoteDetailRow"/> class.
        /// </summary>
        public WarehouseImportNoteDetailRow() : base()
        {
            // EMPTY
        }
        private int stt;

        public int STT { get => stt; set => stt = value; }
        public string Position { set; get; }
        public int ID { set; get; }
        public string PalletPrintContent { set; get; }
        public string QRCodePublic { set; get; }
        public string ProductDetailID { set; get; }
    }
}
