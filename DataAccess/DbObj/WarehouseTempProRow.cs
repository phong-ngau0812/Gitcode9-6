
// <fileinfo name="DbObj\WarehouseTempProRow.cs">
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
/// Represents a record in the <c>WarehouseTempPro</c> table.
/// </summary>
public class WarehouseTempProRow
		: Base.WarehouseTempProRowBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="WarehouseTempProRow"/> class.
	/// </summary>
	public WarehouseTempProRow():base()
	{
		// EMPTY
	}
		public string QRCodePublicContent { get; set; }
}
}
