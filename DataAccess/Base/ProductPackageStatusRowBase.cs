
// <fileinfo name="Base\ProductPackageStatusRowBase.cs">
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
/// The base class for <see cref="ProductPackageStatusRow"/> that 
/// represents a record in the <c>ProductPackageStatus</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductPackageStatusRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageStatusRowBase
{
	/// _productPackageStatus_ID
	private int _productPackageStatus_ID;
	private bool _productPackageStatus_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductPackageStatusRowBase"/> class.
	/// </summary>
	public ProductPackageStatusRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageStatus_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackageStatus_ID</c> column value.</value>
	public int ProductPackageStatus_ID
	{
		get
		{
			if(IsProductPackageStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageStatus_ID;
		}
		set
		{
			_productPackageStatus_IDNull = false;
			_productPackageStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageStatus_IDNull
	{
		get
		{
			return _productPackageStatus_IDNull;
		}
		set
		{
			_productPackageStatus_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Name</c> column value.</value>
	public string Name
	{
		get
		{
			if(IsNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _name;
		}
		set
		{
			_nameNull = false;
			_name = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Name"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNameNull
	{
		get
		{
			return _nameNull;
		}
		set
		{
			_nameNull = value;
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
		// ProductPackageStatus_ID
		dynStr.Append("  ProductPackageStatus_ID=");
		if( IsProductPackageStatus_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackageStatus_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		return dynStr.ToString();
	}
}
}




