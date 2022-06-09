
// <fileinfo name="Base\LogHandlerRowBase.cs">
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
/// The base class for <see cref="LogHandlerRow"/> that 
/// represents a record in the <c>LogHandler</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="LogHandlerRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class LogHandlerRowBase
{
	/// _log_ID
	private int _log_ID;
	private bool _log_IDNull = true;
	/// _messageRequest
	private string _messageRequest;
	private bool _messageRequestNull = true;
	/// _timeRequest
	private string _timeRequest;
	private bool _timeRequestNull = true;
	/// _messageResponse
	private string _messageResponse;
	private bool _messageResponseNull = true;
	/// _timeResponse
	private string _timeResponse;
	private bool _timeResponseNull = true;
	/// _userRequest
	private System.Guid _userRequest;
	private bool _userRequestNull = true;
	/// _userResponse
	private System.Guid _userResponse;
	private bool _userResponseNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="LogHandlerRowBase"/> class.
	/// </summary>
	public LogHandlerRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Log_ID</c> column value.
		/// </summary>
		/// <value>The <c>Log_ID</c> column value.</value>
	public int Log_ID
	{
		get
		{
			if(IsLog_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _log_ID;
		}
		set
		{
			_log_IDNull = false;
			_log_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Log_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLog_IDNull
	{
		get
		{
			return _log_IDNull;
		}
		set
		{
			_log_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MessageRequest</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MessageRequest</c> column value.</value>
	public string MessageRequest
	{
		get
		{
			if(IsMessageRequestNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _messageRequest;
		}
		set
		{
			_messageRequestNull = false;
			_messageRequest = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MessageRequest"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMessageRequestNull
	{
		get
		{
			return _messageRequestNull;
		}
		set
		{
			_messageRequestNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TimeRequest</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TimeRequest</c> column value.</value>
	public string TimeRequest
	{
		get
		{
			if(IsTimeRequestNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _timeRequest;
		}
		set
		{
			_timeRequestNull = false;
			_timeRequest = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TimeRequest"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTimeRequestNull
	{
		get
		{
			return _timeRequestNull;
		}
		set
		{
			_timeRequestNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MessageResponse</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MessageResponse</c> column value.</value>
	public string MessageResponse
	{
		get
		{
			if(IsMessageResponseNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _messageResponse;
		}
		set
		{
			_messageResponseNull = false;
			_messageResponse = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MessageResponse"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMessageResponseNull
	{
		get
		{
			return _messageResponseNull;
		}
		set
		{
			_messageResponseNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TimeResponse</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TimeResponse</c> column value.</value>
	public string TimeResponse
	{
		get
		{
			if(IsTimeResponseNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _timeResponse;
		}
		set
		{
			_timeResponseNull = false;
			_timeResponse = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TimeResponse"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTimeResponseNull
	{
		get
		{
			return _timeResponseNull;
		}
		set
		{
			_timeResponseNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserRequest</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserRequest</c> column value.</value>
	public System.Guid UserRequest
	{
		get
		{
			if (IsUserRequestNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userRequest;
		}
		set
		{
			_userRequestNull = false;
			_userRequest = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserRequest"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserRequestNull
	{
		get
		{
			return _userRequestNull;
		}
		set
		{
			_userRequestNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserResponse</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserResponse</c> column value.</value>
	public System.Guid UserResponse
	{
		get
		{
			if (IsUserResponseNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userResponse;
		}
		set
		{
			_userResponseNull = false;
			_userResponse = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserResponse"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserResponseNull
	{
		get
		{
			return _userResponseNull;
		}
		set
		{
			_userResponseNull = value;
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
		// Log_ID
		dynStr.Append("  Log_ID=");
		if( IsLog_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Log_ID);
		

		// MessageRequest
		dynStr.Append("  MessageRequest=");
		if( IsMessageRequestNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MessageRequest);
		

		// TimeRequest
		dynStr.Append("  TimeRequest=");
		if( IsTimeRequestNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TimeRequest);
		

		// MessageResponse
		dynStr.Append("  MessageResponse=");
		if( IsMessageResponseNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MessageResponse);
		

		// TimeResponse
		dynStr.Append("  TimeResponse=");
		if( IsTimeResponseNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TimeResponse);
		

		// UserRequest
		dynStr.Append("  UserRequest=");
		if( IsUserRequestNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserRequest);
		// UserResponse
		dynStr.Append("  UserResponse=");
		if( IsUserResponseNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserResponse);
		return dynStr.ToString();
	}
}
}




