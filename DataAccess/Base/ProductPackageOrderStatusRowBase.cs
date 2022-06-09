
// <fileinfo name="Base\ProductPackageOrderStatusRowBase.cs">
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
/// The base class for <see cref="ProductPackageOrderStatusRow"/> that 
/// represents a record in the <c>ProductPackageOrderStatus</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductPackageOrderStatusRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageOrderStatusRowBase
{
	/// _productPackageOrderStatus_ID
	private int _productPackageOrderStatus_ID;
	private bool _productPackageOrderStatus_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductPackageOrderStatusRowBase"/> class.
	/// </summary>
	public ProductPackageOrderStatusRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageOrderStatus_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackageOrderStatus_ID</c> column value.</value>
	public int ProductPackageOrderStatus_ID
	{
		get
		{
			if(IsProductPackageOrderStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageOrderStatus_ID;
		}
		set
		{
			_productPackageOrderStatus_IDNull = false;
			_productPackageOrderStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageOrderStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageOrderStatus_IDNull
	{
		get
		{
			return _productPackageOrderStatus_IDNull;
		}
		set
		{
			_productPackageOrderStatus_IDNull = value;
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
		// ProductPackageOrderStatus_ID
		dynStr.Append("  ProductPackageOrderStatus_ID=");
		if( IsProductPackageOrderStatus_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackageOrderStatus_ID);
		

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




