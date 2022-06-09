
// <fileinfo name="Base\QRCodePackageVsProductPakageRowBase.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" >Smc SaleFrame1.0</generator>
// </fileinfo>

using System;

namespace Base
{

/// <summary>
/// The base class for <see cref="QRCodePackageVsProductPakageRow"/> that 
/// represents a record in the <c>QRCodePackageVsProductPakage</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="QRCodePackageVsProductPakageRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class QRCodePackageVsProductPakageRowBase
{
	/// _qRCodePackage_ID
	private int _qRCodePackage_ID;
	private bool _qRCodePackage_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="QRCodePackageVsProductPakageRowBase"/> class.
	/// </summary>
	public QRCodePackageVsProductPakageRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePackage_ID</c> column value.
		/// </summary>
		/// <value>The <c>QRCodePackage_ID</c> column value.</value>
	public int QRCodePackage_ID
	{
		get
		{
			if(IsQRCodePackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePackage_ID;
		}
		set
		{
			_qRCodePackage_IDNull = false;
			_qRCodePackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePackage_IDNull
	{
		get
		{
			return _qRCodePackage_IDNull;
		}
		set
		{
			_qRCodePackage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if(IsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackage_ID;
		}
		set
		{
			_productPackage_IDNull = false;
			_productPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackage_IDNull
	{
		get
		{
			return _productPackage_IDNull;
		}
		set
		{
			_productPackage_IDNull = value;
		}	
	}

	/// <summary>
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// QRCodePackage_ID
		dynStr.Append("  QRCodePackage_ID=");
		if( IsQRCodePackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePackage_ID);
		

		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackage_ID);
		

		return dynStr.ToString();
	}
}
}




