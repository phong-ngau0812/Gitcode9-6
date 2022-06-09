
// <fileinfo name="Base\UserVsPageFunctionRowBase.cs">
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
/// The base class for <see cref="UserVsPageFunctionRow"/> that 
/// represents a record in the <c>UserVsPageFunction</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="UserVsPageFunctionRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class UserVsPageFunctionRowBase
{
	/// _userId
	private System.Guid _userId;
	private bool _userIdNull = true;
	/// _pageFunction_ID
	private int _pageFunction_ID;
	private bool _pageFunction_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="UserVsPageFunctionRowBase"/> class.
	/// </summary>
	public UserVsPageFunctionRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>UserId</c> column value.
		/// </summary>
		/// <value>The <c>UserId</c> column value.</value>
	public System.Guid UserId
	{
		get
		{
			if(IsUserIdNull)
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
		/// Gets or sets the <c>PageFunction_ID</c> column value.
		/// </summary>
		/// <value>The <c>PageFunction_ID</c> column value.</value>
	public int PageFunction_ID
	{
		get
		{
			if(IsPageFunction_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _pageFunction_ID;
		}
		set
		{
			_pageFunction_IDNull = false;
			_pageFunction_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PageFunction_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPageFunction_IDNull
	{
		get
		{
			return _pageFunction_IDNull;
		}
		set
		{
			_pageFunction_IDNull = value;
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
		// UserId
		dynStr.Append("  UserId=");
		if( IsUserIdNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserId);
		

		// PageFunction_ID
		dynStr.Append("  PageFunction_ID=");
		if( IsPageFunction_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PageFunction_ID);
		

		return dynStr.ToString();
	}
}
}




