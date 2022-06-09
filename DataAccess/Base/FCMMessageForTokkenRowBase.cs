
// <fileinfo name="Base\FCMMessageForTokkenRowBase.cs">
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
/// The base class for <see cref="FCMMessageForTokkenRow"/> that 
/// represents a record in the <c>FCMMessageForTokken</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FCMMessageForTokkenRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FCMMessageForTokkenRowBase
{
	/// _fCMMessageForTokken_ID
	private int _fCMMessageForTokken_ID;
	private bool _fCMMessageForTokken_IDNull = true;
	/// _fCMMessage_ID
	private int _fCMMessage_ID;
	private bool _fCMMessage_IDNull = true;
	/// _userID
	private System.Guid _userID;
	private bool _userIDNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FCMMessageForTokkenRowBase"/> class.
	/// </summary>
	public FCMMessageForTokkenRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>FCMMessageForTokken_ID</c> column value.
		/// </summary>
		/// <value>The <c>FCMMessageForTokken_ID</c> column value.</value>
	public int FCMMessageForTokken_ID
	{
		get
		{
			if(IsFCMMessageForTokken_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fCMMessageForTokken_ID;
		}
		set
		{
			_fCMMessageForTokken_IDNull = false;
			_fCMMessageForTokken_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FCMMessageForTokken_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFCMMessageForTokken_IDNull
	{
		get
		{
			return _fCMMessageForTokken_IDNull;
		}
		set
		{
			_fCMMessageForTokken_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FCMMessage_ID</c> column value.
		/// </summary>
		/// <value>The <c>FCMMessage_ID</c> column value.</value>
	public int FCMMessage_ID
	{
		get
		{
			if(IsFCMMessage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fCMMessage_ID;
		}
		set
		{
			_fCMMessage_IDNull = false;
			_fCMMessage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FCMMessage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFCMMessage_IDNull
	{
		get
		{
			return _fCMMessage_IDNull;
		}
		set
		{
			_fCMMessage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserID</c> column value.</value>
	public System.Guid UserID
	{
		get
		{
			if (IsUserIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userID;
		}
		set
		{
			_userIDNull = false;
			_userID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserIDNull
	{
		get
		{
			return _userIDNull;
		}
		set
		{
			_userIDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CreateBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreateBy</c> column value.</value>
	public System.Guid CreateBy
	{
		get
		{
			if (IsCreateByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _createBy;
		}
		set
		{
			_createByNull = false;
			_createBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreateBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreateByNull
	{
		get
		{
			return _createByNull;
		}
		set
		{
			_createByNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// FCMMessageForTokken_ID
		dynStr.Append("  FCMMessageForTokken_ID=");
		if( IsFCMMessageForTokken_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FCMMessageForTokken_ID);
		

		// FCMMessage_ID
		dynStr.Append("  FCMMessage_ID=");
		if( IsFCMMessage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FCMMessage_ID);
		

		// UserID
		dynStr.Append("  UserID=");
		if( IsUserIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserID);
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		return dynStr.ToString();
	}
}
}




