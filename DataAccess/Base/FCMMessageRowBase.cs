
// <fileinfo name="Base\FCMMessageRowBase.cs">
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
/// The base class for <see cref="FCMMessageRow"/> that 
/// represents a record in the <c>FCMMessage</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="FCMMessageRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class FCMMessageRowBase
{
	/// _fCMMessage_ID
	private int _fCMMessage_ID;
	private bool _fCMMessage_IDNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _body
	private string _body;
	private bool _bodyNull = true;
	/// _content
	private string _content;
	private bool _contentNull = true;
	/// _userName
	private string _userName;
	private bool _userNameNull = true;
	/// _userID
	private System.Guid _userID;
	private bool _userIDNull = true;
	/// _topic
	private string _topic;
	private bool _topicNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _notificationType
	private int _notificationType;
	private bool _notificationTypeNull = true;
	/// _form_ID
	private int _form_ID;
	private bool _form_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="FCMMessageRowBase"/> class.
	/// </summary>
	public FCMMessageRowBase():base()
	{
		// EMPTY
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
		/// Gets or sets the <c>Title</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Title</c> column value.</value>
	public string Title
	{
		get
		{
			if(IsTitleNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _title;
		}
		set
		{
			_titleNull = false;
			_title = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Title"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTitleNull
	{
		get
		{
			return _titleNull;
		}
		set
		{
			_titleNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Body</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Body</c> column value.</value>
	public string Body
	{
		get
		{
			if(IsBodyNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _body;
		}
		set
		{
			_bodyNull = false;
			_body = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Body"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBodyNull
	{
		get
		{
			return _bodyNull;
		}
		set
		{
			_bodyNull = value;
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
		/// Gets or sets the <c>NotificationType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>NotificationType</c> column value.</value>
	public int NotificationType
	{
		get
		{
			if (IsNotificationTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _notificationType;
		}
		set
		{
			_notificationTypeNull = false;
			_notificationType = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NotificationType"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNotificationTypeNull
	{
		get
		{
			return _notificationTypeNull;
		}
		set
		{
			_notificationTypeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Form_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Form_ID</c> column value.</value>
	public int Form_ID
	{
		get
		{
			if (IsForm_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _form_ID;
		}
		set
		{
			_form_IDNull = false;
			_form_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Form_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsForm_IDNull
	{
		get
		{
			return _form_IDNull;
		}
		set
		{
			_form_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if (IsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackage_ID;
		}
		set
		{
			_productPackage_IDNull = false;
			_productPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackage_IDNull
	{
		get
		{
			return _productPackage_IDNull;
		}
		set
		{
			_productPackage_IDNull = value;
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
		// FCMMessage_ID
		dynStr.Append("  FCMMessage_ID=");
		if( IsFCMMessage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FCMMessage_ID);
		

		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// Body
		dynStr.Append("  Body=");
		if( IsBodyNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Body);
		

		// Content
		dynStr.Append("  Content=");
		if( IsContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Content);
		

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
		// NotificationType
		dynStr.Append("  NotificationType=");
		if( IsNotificationTypeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.NotificationType);
		// Form_ID
		dynStr.Append("  Form_ID=");
		if( IsForm_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Form_ID);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		return dynStr.ToString();
	}
}
}




