
// <fileinfo name="Base\DiscountRowBase.cs">
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
/// The base class for <see cref="DiscountRow"/> that 
/// represents a record in the <c>Discount</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="DiscountRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class DiscountRowBase
{
	/// _discount_ID
	private int _discount_ID;
	private bool _discount_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditedBy
	private System.Guid _lastEditedBy;
	private bool _lastEditedByNull = true;
	/// _lastEditedDate
	private System.DateTime _lastEditedDate;
	private bool _lastEditedDateNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _percent
	private int _percent;
	private bool _percentNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="DiscountRowBase"/> class.
	/// </summary>
	public DiscountRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Discount_ID</c> column value.
		/// </summary>
		/// <value>The <c>Discount_ID</c> column value.</value>
	public int Discount_ID
	{
		get
		{
			if(IsDiscount_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _discount_ID;
		}
		set
		{
			_discount_IDNull = false;
			_discount_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Discount_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDiscount_IDNull
	{
		get
		{
			return _discount_IDNull;
		}
		set
		{
			_discount_IDNull = value;
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
		/// Gets or sets the <c>LastEditedBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedBy</c> column value.</value>
	public System.Guid LastEditedBy
	{
		get
		{
			if (IsLastEditedByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedBy;
		}
		set
		{
			_lastEditedByNull = false;
			_lastEditedBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedByNull
	{
		get
		{
			return _lastEditedByNull;
		}
		set
		{
			_lastEditedByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedDate</c> column value.</value>
	public System.DateTime LastEditedDate
	{
		get
		{
			if (IsLastEditedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedDate;
		}
		set
		{
			_lastEditedDateNull = false;
			_lastEditedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedDateNull
	{
		get
		{
			return _lastEditedDateNull;
		}
		set
		{
			_lastEditedDateNull = value;
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
		/// Gets or sets the <c>Percent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Percent</c> column value.</value>
	public int Percent
	{
		get
		{
			if (IsPercentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _percent;
		}
		set
		{
			_percentNull = false;
			_percent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Percent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPercentNull
	{
		get
		{
			return _percentNull;
		}
		set
		{
			_percentNull = value;
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
		// Discount_ID
		dynStr.Append("  Discount_ID=");
		if( IsDiscount_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Discount_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

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
		// LastEditedBy
		dynStr.Append("  LastEditedBy=");
		if( IsLastEditedByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedBy);
		// LastEditedDate
		dynStr.Append("  LastEditedDate=");
		if( IsLastEditedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedDate);
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
		// Percent
		dynStr.Append("  Percent=");
		if( IsPercentNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Percent);
		return dynStr.ToString();
	}
}
}




