
// <fileinfo name="Base\ActiveLinkRowBase.cs">
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
/// The base class for <see cref="ActiveLinkRow"/> that 
/// represents a record in the <c>ActiveLink</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ActiveLinkRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ActiveLinkRowBase
{
	/// _activeLink_ID
	private int _activeLink_ID;
	private bool _activeLink_IDNull = true;
	/// _type
	private string _type;
	private bool _typeNull = true;
	/// _userName
	private string _userName;
	private bool _userNameNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ActiveLinkRowBase"/> class.
	/// </summary>
	public ActiveLinkRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ActiveLink_ID</c> column value.
		/// </summary>
		/// <value>The <c>ActiveLink_ID</c> column value.</value>
	public int ActiveLink_ID
	{
		get
		{
			if(IsActiveLink_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _activeLink_ID;
		}
		set
		{
			_activeLink_IDNull = false;
			_activeLink_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ActiveLink_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActiveLink_IDNull
	{
		get
		{
			return _activeLink_IDNull;
		}
		set
		{
			_activeLink_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Type</c> column value.</value>
	public string Type
	{
		get
		{
			if(IsTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _type;
		}
		set
		{
			_typeNull = false;
			_type = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Type"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTypeNull
	{
		get
		{
			return _typeNull;
		}
		set
		{
			_typeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserName</c> column value.</value>
	public string UserName
	{
		get
		{
			if(IsUserNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userName;
		}
		set
		{
			_userNameNull = false;
			_userName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserNameNull
	{
		get
		{
			return _userNameNull;
		}
		set
		{
			_userNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
	public string Email
	{
		get
		{
			if(IsEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _email;
		}
		set
		{
			_emailNull = false;
			_email = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Email"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailNull
	{
		get
		{
			return _emailNull;
		}
		set
		{
			_emailNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CreateDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreateDate</c> column value.</value>
	public System.DateTime CreateDate
	{
		get
		{
			if (IsCreateDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _createDate;
		}
		set
		{
			_createDateNull = false;
			_createDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreateDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreateDateNull
	{
		get
		{
			return _createDateNull;
		}
		set
		{
			_createDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public bool Active
	{
		get
		{
			if (IsActiveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _active;
		}
		set
		{
			_activeNull = false;
			_active = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Active"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActiveNull
	{
		get
		{
			return _activeNull;
		}
		set
		{
			_activeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Code</c> column value.</value>
	public string Code
	{
		get
		{
			if(IsCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _code;
		}
		set
		{
			_codeNull = false;
			_code = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Code"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCodeNull
	{
		get
		{
			return _codeNull;
		}
		set
		{
			_codeNull = value;
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
		// ActiveLink_ID
		dynStr.Append("  ActiveLink_ID=");
		if( IsActiveLink_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ActiveLink_ID);
		

		// Type
		dynStr.Append("  Type=");
		if( IsTypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Type);
		

		// UserName
		dynStr.Append("  UserName=");
		if( IsUserNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserName);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		return dynStr.ToString();
	}
}
}




