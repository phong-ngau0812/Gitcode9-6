
// <fileinfo name="Base\SalesInformationVsProductRowBase.cs">
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
/// The base class for <see cref="SalesInformationVsProductRow"/> that 
/// represents a record in the <c>SalesInformationVsProduct</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SalesInformationVsProductRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SalesInformationVsProductRowBase
{
	/// _salesInformation_ID
	private int _salesInformation_ID;
	private bool _salesInformation_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _unit
	private string _unit;
	private bool _unitNull = true;
	/// _quantity
	private int _quantity;
	private bool _quantityNull = true;
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


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SalesInformationVsProductRowBase"/> class.
	/// </summary>
	public SalesInformationVsProductRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>SalesInformation_ID</c> column value.
		/// </summary>
		/// <value>The <c>SalesInformation_ID</c> column value.</value>
	public int SalesInformation_ID
	{
		get
		{
			if(IsSalesInformation_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _salesInformation_ID;
		}
		set
		{
			_salesInformation_IDNull = false;
			_salesInformation_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SalesInformation_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSalesInformation_IDNull
	{
		get
		{
			return _salesInformation_IDNull;
		}
		set
		{
			_salesInformation_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Product_ID</c> column value.
		/// </summary>
		/// <value>The <c>Product_ID</c> column value.</value>
	public int Product_ID
	{
		get
		{
			if(IsProduct_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _product_ID;
		}
		set
		{
			_product_IDNull = false;
			_product_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Product_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduct_IDNull
	{
		get
		{
			return _product_IDNull;
		}
		set
		{
			_product_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Unit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Unit</c> column value.</value>
	public string Unit
	{
		get
		{
			if(IsUnitNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _unit;
		}
		set
		{
			_unitNull = false;
			_unit = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Unit"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUnitNull
	{
		get
		{
			return _unitNull;
		}
		set
		{
			_unitNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Quantity</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Quantity</c> column value.</value>
	public int Quantity
	{
		get
		{
			if (IsQuantityNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _quantity;
		}
		set
		{
			_quantityNull = false;
			_quantity = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Quantity"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQuantityNull
	{
		get
		{
			return _quantityNull;
		}
		set
		{
			_quantityNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// SalesInformation_ID
		dynStr.Append("  SalesInformation_ID=");
		if( IsSalesInformation_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SalesInformation_ID);
		

		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Product_ID);
		

		// Unit
		dynStr.Append("  Unit=");
		if( IsUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Unit);
		

		// Quantity
		dynStr.Append("  Quantity=");
		if( IsQuantityNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Quantity);
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
		return dynStr.ToString();
	}
}
}




