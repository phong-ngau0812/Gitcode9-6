
// <fileinfo name="Base\ProductReviewRowBase.cs">
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
/// The base class for <see cref="ProductReviewRow"/> that 
/// represents a record in the <c>ProductReview</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductReviewRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductReviewRowBase
{
	/// _productReview_ID
	private int _productReview_ID;
	private bool _productReview_IDNull = true;
	/// _productInfo_ID
	private int _productInfo_ID;
	private bool _productInfo_IDNull = true;
	/// _fullName
	private string _fullName;
	private bool _fullNameNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _star
	private int _star;
	private bool _starNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;
	/// _approved
	private int _approved;
	private bool _approvedNull = true;
	/// _approvedUser
	private System.Guid _approvedUser;
	private bool _approvedUserNull = true;
	/// _approvedDate
	private System.DateTime _approvedDate;
	private bool _approvedDateNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductReviewRowBase"/> class.
	/// </summary>
	public ProductReviewRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductReview_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductReview_ID</c> column value.</value>
	public int ProductReview_ID
	{
		get
		{
			if(IsProductReview_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productReview_ID;
		}
		set
		{
			_productReview_IDNull = false;
			_productReview_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductReview_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductReview_IDNull
	{
		get
		{
			return _productReview_IDNull;
		}
		set
		{
			_productReview_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductInfo_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductInfo_ID</c> column value.</value>
	public int ProductInfo_ID
	{
		get
		{
			if (IsProductInfo_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productInfo_ID;
		}
		set
		{
			_productInfo_IDNull = false;
			_productInfo_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductInfo_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductInfo_IDNull
	{
		get
		{
			return _productInfo_IDNull;
		}
		set
		{
			_productInfo_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FullName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FullName</c> column value.</value>
	public string FullName
	{
		get
		{
			if(IsFullNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fullName;
		}
		set
		{
			_fullNameNull = false;
			_fullName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FullName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFullNameNull
	{
		get
		{
			return _fullNameNull;
		}
		set
		{
			_fullNameNull = value;
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
		/// Gets or sets the <c>Star</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Star</c> column value.</value>
	public int Star
	{
		get
		{
			if (IsStarNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _star;
		}
		set
		{
			_starNull = false;
			_star = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Star"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStarNull
	{
		get
		{
			return _starNull;
		}
		set
		{
			_starNull = value;
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
		/// Gets or sets the <c>Approved</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Approved</c> column value.</value>
	public int Approved
	{
		get
		{
			if (IsApprovedNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _approved;
		}
		set
		{
			_approvedNull = false;
			_approved = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Approved"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsApprovedNull
	{
		get
		{
			return _approvedNull;
		}
		set
		{
			_approvedNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ApprovedUser</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ApprovedUser</c> column value.</value>
	public System.Guid ApprovedUser
	{
		get
		{
			if (IsApprovedUserNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _approvedUser;
		}
		set
		{
			_approvedUserNull = false;
			_approvedUser = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ApprovedUser"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsApprovedUserNull
	{
		get
		{
			return _approvedUserNull;
		}
		set
		{
			_approvedUserNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ApprovedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ApprovedDate</c> column value.</value>
	public System.DateTime ApprovedDate
	{
		get
		{
			if (IsApprovedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _approvedDate;
		}
		set
		{
			_approvedDateNull = false;
			_approvedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ApprovedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsApprovedDateNull
	{
		get
		{
			return _approvedDateNull;
		}
		set
		{
			_approvedDateNull = value;
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
		// ProductReview_ID
		dynStr.Append("  ProductReview_ID=");
		if( IsProductReview_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductReview_ID);
		

		// ProductInfo_ID
		dynStr.Append("  ProductInfo_ID=");
		if( IsProductInfo_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductInfo_ID);
		// FullName
		dynStr.Append("  FullName=");
		if( IsFullNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.FullName);
		

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
		

		// Star
		dynStr.Append("  Star=");
		if( IsStarNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Star);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		// Approved
		dynStr.Append("  Approved=");
		if( IsApprovedNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Approved);
		// ApprovedUser
		dynStr.Append("  ApprovedUser=");
		if( IsApprovedUserNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ApprovedUser);
		// ApprovedDate
		dynStr.Append("  ApprovedDate=");
		if( IsApprovedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ApprovedDate);
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




