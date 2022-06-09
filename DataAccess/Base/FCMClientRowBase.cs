
// <fileinfo name="Base\FCMClientRowBase.cs">
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
/// The base class for <see cref="FCMClientRow"/> that 
/// represents a record in the <c>FCMClient</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FCMClientRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FCMClientRowBase
{
	/// _fCMClient_ID
	private System.Guid _fCMClient_ID;
	private bool _fCMClient_IDNull = true;
	/// _device_ID
	private string _device_ID;
	private bool _device_IDNull = true;
	/// _os
	private string _os;
	private bool _osNull = true;
	/// _firebaseToken
	private string _firebaseToken;
	private bool _firebaseTokenNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _userName
	private string _userName;
	private bool _userNameNull = true;
	/// _userID
	private System.Guid _userID;
	private bool _userIDNull = true;
	/// _topic
	private string _topic;
	private bool _topicNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FCMClientRowBase"/> class.
	/// </summary>
	public FCMClientRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>FCMClient_ID</c> column value.
		/// </summary>
		/// <value>The <c>FCMClient_ID</c> column value.</value>
	public System.Guid FCMClient_ID
	{
		get
		{
			if(IsFCMClient_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fCMClient_ID;
		}
		set
		{
			_fCMClient_IDNull = false;
			_fCMClient_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FCMClient_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFCMClient_IDNull
	{
		get
		{
			return _fCMClient_IDNull;
		}
		set
		{
			_fCMClient_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Device_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Device_ID</c> column value.</value>
	public string Device_ID
	{
		get
		{
			if(IsDevice_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _device_ID;
		}
		set
		{
			_device_IDNull = false;
			_device_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Device_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDevice_IDNull
	{
		get
		{
			return _device_IDNull;
		}
		set
		{
			_device_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>OS</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>OS</c> column value.</value>
	public string OS
	{
		get
		{
			if(IsOSNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _os;
		}
		set
		{
			_osNull = false;
			_os = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="OS"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOSNull
	{
		get
		{
			return _osNull;
		}
		set
		{
			_osNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FirebaseToken</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FirebaseToken</c> column value.</value>
	public string FirebaseToken
	{
		get
		{
			if(IsFirebaseTokenNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _firebaseToken;
		}
		set
		{
			_firebaseTokenNull = false;
			_firebaseToken = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FirebaseToken"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFirebaseTokenNull
	{
		get
		{
			return _firebaseTokenNull;
		}
		set
		{
			_firebaseTokenNull = value;
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
		/// Gets or sets the <c>Topic</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Topic</c> column value.</value>
	public string Topic
	{
		get
		{
			if(IsTopicNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _topic;
		}
		set
		{
			_topicNull = false;
			_topic = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Topic"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTopicNull
	{
		get
		{
			return _topicNull;
		}
		set
		{
			_topicNull = value;
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
		// FCMClient_ID
		dynStr.Append("  FCMClient_ID=");
		if( IsFCMClient_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FCMClient_ID);
		

		// Device_ID
		dynStr.Append("  Device_ID=");
		if( IsDevice_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Device_ID);
		

		// OS
		dynStr.Append("  OS=");
		if( IsOSNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.OS);
		

		// FirebaseToken
		dynStr.Append("  FirebaseToken=");
		if( IsFirebaseTokenNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FirebaseToken);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// UserName
		dynStr.Append("  UserName=");
		if( IsUserNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserName);
		

		// UserID
		dynStr.Append("  UserID=");
		if( IsUserIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserID);
		// Topic
		dynStr.Append("  Topic=");
		if( IsTopicNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Topic);
		

		return dynStr.ToString();
	}
}
}




