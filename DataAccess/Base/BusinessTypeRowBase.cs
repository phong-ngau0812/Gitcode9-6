
// <fileinfo name="Base\BusinessTypeRowBase.cs">
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
/// The base class for <see cref="BusinessTypeRow"/> that 
/// represents a record in the <c>BusinessType</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BusinessTypeRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BusinessTypeRowBase
{
	/// _businessType_ID
	private int _businessType_ID;
	private bool _businessType_IDNull = true;
	/// _branch_ID
	private int _branch_ID;
	private bool _branch_IDNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _language_ID
	private int _language_ID;
	private bool _language_IDNull = true;
	/// _parent_ID
	private int _parent_ID;
	private bool _parent_IDNull = true;
	/// _counter
	private int _counter;
	private bool _counterNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BusinessTypeRowBase"/> class.
	/// </summary>
	public BusinessTypeRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>BusinessType_ID</c> column value.
		/// </summary>
		/// <value>The <c>BusinessType_ID</c> column value.</value>
	public int BusinessType_ID
	{
		get
		{
			if(IsBusinessType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _businessType_ID;
		}
		set
		{
			_businessType_IDNull = false;
			_businessType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BusinessType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBusinessType_IDNull
	{
		get
		{
			return _businessType_IDNull;
		}
		set
		{
			_businessType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Branch_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Branch_ID</c> column value.</value>
	public int Branch_ID
	{
		get
		{
			if (IsBranch_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _branch_ID;
		}
		set
		{
			_branch_IDNull = false;
			_branch_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Branch_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBranch_IDNull
	{
		get
		{
			return _branch_IDNull;
		}
		set
		{
			_branch_IDNull = value;
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
		/// Gets or sets the <c>Description</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Description</c> column value.</value>
	public string Description
	{
		get
		{
			if(IsDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _description;
		}
		set
		{
			_descriptionNull = false;
			_description = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Description"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDescriptionNull
	{
		get
		{
			return _descriptionNull;
		}
		set
		{
			_descriptionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public int Active
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
		/// Gets or sets the <c>Sort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sort</c> column value.</value>
	public int Sort
	{
		get
		{
			if (IsSortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sort;
		}
		set
		{
			_sortNull = false;
			_sort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Sort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSortNull
	{
		get
		{
			return _sortNull;
		}
		set
		{
			_sortNull = value;
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
		/// Gets or sets the <c>Language_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Language_ID</c> column value.</value>
	public int Language_ID
	{
		get
		{
			if (IsLanguage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _language_ID;
		}
		set
		{
			_language_IDNull = false;
			_language_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Language_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLanguage_IDNull
	{
		get
		{
			return _language_IDNull;
		}
		set
		{
			_language_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Parent_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Parent_ID</c> column value.</value>
	public int Parent_ID
	{
		get
		{
			if (IsParent_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _parent_ID;
		}
		set
		{
			_parent_IDNull = false;
			_parent_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Parent_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsParent_IDNull
	{
		get
		{
			return _parent_IDNull;
		}
		set
		{
			_parent_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Counter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Counter</c> column value.</value>
	public int Counter
	{
		get
		{
			if (IsCounterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _counter;
		}
		set
		{
			_counterNull = false;
			_counter = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Counter"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCounterNull
	{
		get
		{
			return _counterNull;
		}
		set
		{
			_counterNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
	public int Status
	{
		get
		{
			if (IsStatusNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _status;
		}
		set
		{
			_statusNull = false;
			_status = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Status"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStatusNull
	{
		get
		{
			return _statusNull;
		}
		set
		{
			_statusNull = value;
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
		// BusinessType_ID
		dynStr.Append("  BusinessType_ID=");
		if( IsBusinessType_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BusinessType_ID);
		

		// Branch_ID
		dynStr.Append("  Branch_ID=");
		if( IsBranch_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Branch_ID);
		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
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
		// LastEditDate
		dynStr.Append("  LastEditDate=");
		if( IsLastEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditDate);
		// LastEditBy
		dynStr.Append("  LastEditBy=");
		if( IsLastEditByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditBy);
		// Language_ID
		dynStr.Append("  Language_ID=");
		if( IsLanguage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Language_ID);
		// Parent_ID
		dynStr.Append("  Parent_ID=");
		if( IsParent_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Parent_ID);
		// Counter
		dynStr.Append("  Counter=");
		if( IsCounterNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Counter);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		return dynStr.ToString();
	}
}
}




