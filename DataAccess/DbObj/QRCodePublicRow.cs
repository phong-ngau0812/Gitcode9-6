
// <fileinfo name="DbObj\QRCodePublicRow.cs">
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
    /// Represents a record in the <c>QRCodePublic</c> table.
    /// </summary>
    public class QRCodePublicRow
            : Base.QRCodePublicRowBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QRCodePublicRow"/> class.
        /// </summary>
        public QRCodePublicRow() : base()
        {
            // EMPTY
        }
        public string productName { get; set; }
    }
}
