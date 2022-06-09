
// <fileinfo name="Base\SMSMessageDraftRowBase.cs">
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
/// The base class for <see cref="SMSMessageDraftRow"/> that 
/// represents a record in the <c>SMSMessageDraft</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SMSMessageDraftRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SMSMessageDraftRowBase
{
	/// _sMSMessageDraft_ID
	private int _sMSMessageDraft_ID;
	private bool _sMSMessageDraft_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _actionType
	private string _actionType;
	private bool _actionTypeNull = true;
	/// _actionDescription
	private string _actionDescription;
	private bool _actionDescriptionNull = true;
	/// _sMSMessage_ID
	private int _sMSMessage_ID;
	private bool _sMSMessage_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _content
	private string _content;
	private bool _contentNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _checkApprove
	private int _checkApprove;
	private bool _checkApproveNull = true;
	/// _checkApproveDate
	private System.DateTime _checkApproveDate;
	private bool _checkApproveDateNull = true;
	/// _adminApprove
	private int _adminApprove;
	private bool _adminApproveNull = true;
	/// _adminApproveDate
	private System.DateTime _adminApproveDate;
	private bool _adminApproveDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SMSMessageDraftRowBase"/> class.
	/// </summary>
	public SMSMessageDraftRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>SMSMessageDraft_ID</c> column value.
		/// </summary>
		/// <value>The <c>SMSMessageDraft_ID</c> column value.</value>
	public int SMSMessageDraft_ID
	{
		get
		{
			if(IsSMSMessageDraft_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sMSMessageDraft_ID;
		}
		set
		{
			_sMSMessageDraft_IDNull = false;
			_sMSMessageDraft_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SMSMessageDraft_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSMSMessageDraft_IDNull
	{
		get
		{
			return _sMSMessageDraft_IDNull;
		}
		set
		{
			_sMSMessageDraft_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrand_ID</c> column value.</value>
	public int ProductBrand_ID
	{
		get
		{
			if (IsProductBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrand_ID;
		}
		set
		{
			_productBrand_IDNull = false;
			_productBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrand_IDNull
	{
		get
		{
			return _productBrand_IDNull;
		}
		set
		{
			_productBrand_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ActionType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ActionType</c> column value.</value>
	public string ActionType
	{
		get
		{
			if(IsActionTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _actionType;
		}
		set
		{
			_actionTypeNull = false;
			_actionType = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ActionType"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActionTypeNull
	{
		get
		{
			return _actionTypeNull;
		}
		set
		{
			_actionTypeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ActionDescription</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ActionDescription</c> column value.</value>
	public string ActionDescription
	{
		get
		{
			if(IsActionDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _actionDescription;
		}
		set
		{
			_actionDescriptionNull = false;
			_actionDescription = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ActionDescription"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActionDescriptionNull
	{
		get
		{
			return _actionDescriptionNull;
		}
		set
		{
			_actionDescriptionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SMSMessage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SMSMessage_ID</c> column value.</value>
	public int SMSMessage_ID
	{
		get
		{
			if (IsSMSMessage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sMSMessage_ID;
		}
		set
		{
			_sMSMessage_IDNull = false;
			_sMSMessage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SMSMessage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSMSMessage_IDNull
	{
		get
		{
			return _sMSMessage_IDNull;
		}
		set
		{
			_sMSMessage_IDNull = value;
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
		/// Gets or sets the <c>LastEditBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditBy</c> column value.</value>
	public System.Guid LastEditBy
	{
		get
		{
			if (IsLastEditByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditBy;
		}
		set
		{
			_lastEditByNull = false;
			_lastEditBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditByNull
	{
		get
		{
			return _lastEditByNull;
		}
		set
		{
			_lastEditByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditDate</c> column value.</value>
	public System.DateTime LastEditDate
	{
		get
		{
			if (IsLastEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditDate;
		}
		set
		{
			_lastEditDateNull = false;
			_lastEditDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditDateNull
	{
		get
		{
			return _lastEditDateNull;
		}
		set
		{
			_lastEditDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckApprove</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckApprove</c> column value.</value>
	public int CheckApprove
	{
		get
		{
			if (IsCheckApproveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkApprove;
		}
		set
		{
			_checkApproveNull = false;
			_checkApprove = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckApprove"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckApproveNull
	{
		get
		{
			return _checkApproveNull;
		}
		set
		{
			_checkApproveNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CheckApproveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CheckApproveDate</c> column value.</value>
	public System.DateTime CheckApproveDate
	{
		get
		{
			if (IsCheckApproveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _checkApproveDate;
		}
		set
		{
			_checkApproveDateNull = false;
			_checkApproveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CheckApproveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCheckApproveDateNull
	{
		get
		{
			return _checkApproveDateNull;
		}
		set
		{
			_checkApproveDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminApprove</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminApprove</c> column value.</value>
	public int AdminApprove
	{
		get
		{
			if (IsAdminApproveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminApprove;
		}
		set
		{
			_adminApproveNull = false;
			_adminApprove = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminApprove"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminApproveNull
	{
		get
		{
			return _adminApproveNull;
		}
		set
		{
			_adminApproveNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminApproveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminApproveDate</c> column value.</value>
	public System.DateTime AdminApproveDate
	{
		get
		{
			if (IsAdminApproveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminApproveDate;
		}
		set
		{
			_adminApproveDateNull = false;
			_adminApproveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminApproveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminApproveDateNull
	{
		get
		{
			return _adminApproveDateNull;
		}
		set
		{
			_adminApproveDateNull = value;
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
		// SMSMessageDraft_ID
		dynStr.Append("  SMSMessageDraft_ID=");
		if( IsSMSMessageDraft_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SMSMessageDraft_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// ActionType
		dynStr.Append("  ActionType=");
		if( IsActionTypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ActionType);
		

		// ActionDescription
		dynStr.Append("  ActionDescription=");
		if( IsActionDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ActionDescription);
		

		// SMSMessage_ID
		dynStr.Append("  SMSMessage_ID=");
		if( IsSMSMessage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SMSMessage_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Content
		dynStr.Append("  Content=");
		if( IsContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Content);
		

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
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// CheckApprove
		dynStr.Append("  CheckApprove=");
		if( IsCheckApproveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckApprove);
		// CheckApproveDate
		dynStr.Append("  CheckApproveDate=");
		if( IsCheckApproveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CheckApproveDate);
		// AdminApprove
		dynStr.Append("  AdminApprove=");
		if( IsAdminApproveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AdminApprove);
		// AdminApproveDate
		dynStr.Append("  AdminApproveDate=");
		if( IsAdminApproveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AdminApproveDate);
		return dynStr.ToString();
	}
}
}




