
// <fileinfo name="Base\UserNotifyRowBase.cs">
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
/// The base class for <see cref="UserNotifyRow"/> that 
/// represents a record in the <c>UserNotify</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="UserNotifyRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class UserNotifyRowBase
{
	/// _userNotify_ID
	private System.Guid _userNotify_ID;
	private bool _userNotify_IDNull = true;
	/// _userNotifyType_ID
	private int _userNotifyType_ID;
	private bool _userNotifyType_IDNull = true;
	/// _toUserID
	private System.Guid _toUserID;
	private bool _toUserIDNull = true;
	/// _subject
	private string _subject;
	private bool _subjectNull = true;
	/// _content
	private string _content;
	private bool _contentNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _readed
	private bool _readed;
	private bool _readedNull = true;
	/// _readCount
	private int _readCount;
	private bool _readCountNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="UserNotifyRowBase"/> class.
	/// </summary>
	public UserNotifyRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>UserNotify_ID</c> column value.
		/// </summary>
		/// <value>The <c>UserNotify_ID</c> column value.</value>
	public System.Guid UserNotify_ID
	{
		get
		{
			if(IsUserNotify_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userNotify_ID;
		}
		set
		{
			_userNotify_IDNull = false;
			_userNotify_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserNotify_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserNotify_IDNull
	{
		get
		{
			return _userNotify_IDNull;
		}
		set
		{
			_userNotify_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserNotifyType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserNotifyType_ID</c> column value.</value>
	public int UserNotifyType_ID
	{
		get
		{
			if (IsUserNotifyType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userNotifyType_ID;
		}
		set
		{
			_userNotifyType_IDNull = false;
			_userNotifyType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserNotifyType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserNotifyType_IDNull
	{
		get
		{
			return _userNotifyType_IDNull;
		}
		set
		{
			_userNotifyType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ToUserID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ToUserID</c> column value.</value>
	public System.Guid ToUserID
	{
		get
		{
			if (IsToUserIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _toUserID;
		}
		set
		{
			_toUserIDNull = false;
			_toUserID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ToUserID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsToUserIDNull
	{
		get
		{
			return _toUserIDNull;
		}
		set
		{
			_toUserIDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Subject</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Subject</c> column value.</value>
	public string Subject
	{
		get
		{
			if(IsSubjectNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _subject;
		}
		set
		{
			_subjectNull = false;
			_subject = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Subject"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSubjectNull
	{
		get
		{
			return _subjectNull;
		}
		set
		{
			_subjectNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Content</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Content</c> column value.</value>
	public string Content
	{
		get
		{
			if(IsContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _content;
		}
		set
		{
			_contentNull = false;
			_content = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Content"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContentNull
	{
		get
		{
			return _contentNull;
		}
		set
		{
			_contentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>URL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>URL</c> column value.</value>
	public string URL
	{
		get
		{
			if(IsURLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _url;
		}
		set
		{
			_urlNull = false;
			_url = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="URL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsURLNull
	{
		get
		{
			return _urlNull;
		}
		set
		{
			_urlNull = value;
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
		/// Gets or sets the <c>Readed</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Readed</c> column value.</value>
	public bool Readed
	{
		get
		{
			if (IsReadedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _readed;
		}
		set
		{
			_readedNull = false;
			_readed = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Readed"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsReadedNull
	{
		get
		{
			return _readedNull;
		}
		set
		{
			_readedNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ReadCount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ReadCount</c> column value.</value>
	public int ReadCount
	{
		get
		{
			if (IsReadCountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _readCount;
		}
		set
		{
			_readCountNull = false;
			_readCount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ReadCount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsReadCountNull
	{
		get
		{
			return _readCountNull;
		}
		set
		{
			_readCountNull = value;
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
		// UserNotify_ID
		dynStr.Append("  UserNotify_ID=");
		if( IsUserNotify_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserNotify_ID);
		

		// UserNotifyType_ID
		dynStr.Append("  UserNotifyType_ID=");
		if( IsUserNotifyType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.UserNotifyType_ID);
		// ToUserID
		dynStr.Append("  ToUserID=");
		if( IsToUserIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ToUserID);
		// Subject
		dynStr.Append("  Subject=");
		if( IsSubjectNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Subject);
		

		// Content
		dynStr.Append("  Content=");
		if( IsContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Content);
		

		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// Readed
		dynStr.Append("  Readed=");
		if( IsReadedNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Readed);
		// ReadCount
		dynStr.Append("  ReadCount=");
		if( IsReadCountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ReadCount);
		return dynStr.ToString();
	}
}
}




