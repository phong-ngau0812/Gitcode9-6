
// <fileinfo name="Base\MaterialPriceRowBase.cs">
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
/// The base class for <see cref="MaterialPriceRow"/> that 
/// represents a record in the <c>MaterialPrice</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="MaterialPriceRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class MaterialPriceRowBase
{
	/// _materialPrice_ID
	private int _materialPrice_ID;
	private bool _materialPrice_IDNull = true;
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _fromDate
	private System.DateTime _fromDate;
	private bool _fromDateNull = true;
	/// _toDate
	private System.DateTime _toDate;
	private bool _toDateNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;
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
	/// _active
	private int _active;
	private bool _activeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="MaterialPriceRowBase"/> class.
	/// </summary>
	public MaterialPriceRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>MaterialPrice_ID</c> column value.
		/// </summary>
		/// <value>The <c>MaterialPrice_ID</c> column value.</value>
	public int MaterialPrice_ID
	{
		get
		{
			if(IsMaterialPrice_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _materialPrice_ID;
		}
		set
		{
			_materialPrice_IDNull = false;
			_materialPrice_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MaterialPrice_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMaterialPrice_IDNull
	{
		get
		{
			return _materialPrice_IDNull;
		}
		set
		{
			_materialPrice_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Material_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Material_ID</c> column value.</value>
	public int Material_ID
	{
		get
		{
			if (IsMaterial_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _material_ID;
		}
		set
		{
			_material_IDNull = false;
			_material_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Material_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMaterial_IDNull
	{
		get
		{
			return _material_IDNull;
		}
		set
		{
			_material_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FromDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FromDate</c> column value.</value>
	public System.DateTime FromDate
	{
		get
		{
			if (IsFromDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fromDate;
		}
		set
		{
			_fromDateNull = false;
			_fromDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FromDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFromDateNull
	{
		get
		{
			return _fromDateNull;
		}
		set
		{
			_fromDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ToDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ToDate</c> column value.</value>
	public System.DateTime ToDate
	{
		get
		{
			if (IsToDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _toDate;
		}
		set
		{
			_toDateNull = false;
			_toDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ToDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsToDateNull
	{
		get
		{
			return _toDateNull;
		}
		set
		{
			_toDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Price</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Price</c> column value.</value>
	public decimal Price
	{
		get
		{
			if (IsPriceNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _price;
		}
		set
		{
			_priceNull = false;
			_price = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Price"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPriceNull
	{
		get
		{
			return _priceNull;
		}
		set
		{
			_priceNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// MaterialPrice_ID
		dynStr.Append("  MaterialPrice_ID=");
		if( IsMaterialPrice_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MaterialPrice_ID);
		

		// Material_ID
		dynStr.Append("  Material_ID=");
		if( IsMaterial_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Material_ID);
		// FromDate
		dynStr.Append("  FromDate=");
		if( IsFromDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FromDate);
		// ToDate
		dynStr.Append("  ToDate=");
		if( IsToDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ToDate);
		// Price
		dynStr.Append("  Price=");
		if( IsPriceNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Price);
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
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		return dynStr.ToString();
	}
}
}




