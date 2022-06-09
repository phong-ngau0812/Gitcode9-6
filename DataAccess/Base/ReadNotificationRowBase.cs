
// <fileinfo name="Base\ReadNotificationRowBase.cs">
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
/// The base class for <see cref="ReadNotificationRow"/> that 
/// represents a record in the <c>ReadNotification</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ReadNotificationRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ReadNotificationRowBase
{
	/// _readNotification_ID
	private int _readNotification_ID;
	private bool _readNotification_IDNull = true;
	/// _notification_ID
	private int _notification_ID;
	private bool _notification_IDNull = true;
	/// _userID
	private System.Guid _userID;
	private bool _userIDNull = true;
	/// _viewDate
	private System.DateTime _viewDate;
	private bool _viewDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ReadNotificationRowBase"/> class.
	/// </summary>
	public ReadNotificationRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ReadNotification_ID</c> column value.
		/// </summary>
		/// <value>The <c>ReadNotification_ID</c> column value.</value>
	public int ReadNotification_ID
	{
		get
		{
			if(IsReadNotification_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _readNotification_ID;
		}
		set
		{
			_readNotification_IDNull = false;
			_readNotification_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ReadNotification_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsReadNotification_IDNull
	{
		get
		{
			return _readNotification_IDNull;
		}
		set
		{
			_readNotification_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Notification_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Notification_ID</c> column value.</value>
	public int Notification_ID
	{
		get
		{
			if (IsNotification_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _notification_ID;
		}
		set
		{
			_notification_IDNull = false;
			_notification_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Notification_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNotification_IDNull
	{
		get
		{
			return _notification_IDNull;
		}
		set
		{
			_notification_IDNull = value;
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
		/// Gets or sets the <c>ViewDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ViewDate</c> column value.</value>
	public System.DateTime ViewDate
	{
		get
		{
			if (IsViewDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _viewDate;
		}
		set
		{
			_viewDateNull = false;
			_viewDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ViewDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsViewDateNull
	{
		get
		{
			return _viewDateNull;
		}
		set
		{
			_viewDateNull = value;
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
		// ReadNotification_ID
		dynStr.Append("  ReadNotification_ID=");
		if( IsReadNotification_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ReadNotification_ID);
		

		// Notification_ID
		dynStr.Append("  Notification_ID=");
		if( IsNotification_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Notification_ID);
		// UserID
		dynStr.Append("  UserID=");
		if( IsUserIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserID);
		// ViewDate
		dynStr.Append("  ViewDate=");
		if( IsViewDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ViewDate);
		return dynStr.ToString();
	}
}
}




