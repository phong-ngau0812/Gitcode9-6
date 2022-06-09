
// <fileinfo name="Base\UserVsProductBrandRowBase.cs">
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
/// The base class for <see cref="UserVsProductBrandRow"/> that 
/// represents a record in the <c>UserVsProductBrand</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="UserVsProductBrandRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class UserVsProductBrandRowBase
{
	/// _userVsProductBrand_ID
	private int _userVsProductBrand_ID;
	private bool _userVsProductBrand_IDNull = true;
	/// _userId
	private System.Guid _userId;
	private bool _userIdNull = true;
	/// _productBrand_ID_List
	private string _productBrand_ID_List;
	private bool _productBrand_ID_ListNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="UserVsProductBrandRowBase"/> class.
	/// </summary>
	public UserVsProductBrandRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>UserVsProductBrand_ID</c> column value.
		/// </summary>
		/// <value>The <c>UserVsProductBrand_ID</c> column value.</value>
	public int UserVsProductBrand_ID
	{
		get
		{
			if(IsUserVsProductBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userVsProductBrand_ID;
		}
		set
		{
			_userVsProductBrand_IDNull = false;
			_userVsProductBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserVsProductBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserVsProductBrand_IDNull
	{
		get
		{
			return _userVsProductBrand_IDNull;
		}
		set
		{
			_userVsProductBrand_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserId</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserId</c> column value.</value>
	public System.Guid UserId
	{
		get
		{
			if (IsUserIdNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userId;
		}
		set
		{
			_userIdNull = false;
			_userId = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserId"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserIdNull
	{
		get
		{
			return _userIdNull;
		}
		set
		{
			_userIdNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrand_ID_List</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrand_ID_List</c> column value.</value>
	public string ProductBrand_ID_List
	{
		get
		{
			if(IsProductBrand_ID_ListNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrand_ID_List;
		}
		set
		{
			_productBrand_ID_ListNull = false;
			_productBrand_ID_List = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrand_ID_List"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrand_ID_ListNull
	{
		get
		{
			return _productBrand_ID_ListNull;
		}
		set
		{
			_productBrand_ID_ListNull = value;
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
		// UserVsProductBrand_ID
		dynStr.Append("  UserVsProductBrand_ID=");
		if( IsUserVsProductBrand_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserVsProductBrand_ID);
		

		// UserId
		dynStr.Append("  UserId=");
		if( IsUserIdNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserId);
		// ProductBrand_ID_List
		dynStr.Append("  ProductBrand_ID_List=");
		if( IsProductBrand_ID_ListNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductBrand_ID_List);
		

		return dynStr.ToString();
	}
}
}




