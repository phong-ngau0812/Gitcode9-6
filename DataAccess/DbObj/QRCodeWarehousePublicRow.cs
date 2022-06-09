
// <fileinfo name="DbObj\QRCodeWarehousePublicRow.cs">
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
    /// Represents a record in the <c>QRCodeWarehousePublic</c> table.
    /// </summary>
    public class QRCodeWarehousePublicRow
            : Base.QRCodeWarehousePublicRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QRCodeWarehousePublicRow"/> class.
        /// </summary>
        public QRCodeWarehousePublicRow() : base()
        {
            // EMPTY
        }
        public string productName { get; set; }
    }
}
