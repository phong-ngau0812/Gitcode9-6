
// <fileinfo name="Base\SalesInformationRowBase.cs">
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
/// The base class for <see cref="SalesInformationRow"/> that 
/// represents a record in the <c>SalesInformation</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SalesInformationRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SalesInformationRowBase
{
	/// _salesInformation_ID
	private int _salesInformation_ID;
	private bool _salesInformation_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _barcode
	private string _barcode;
	private bool _barcodeNull = true;
	/// _total
	private decimal _total;
	private bool _totalNull = true;
	/// _customer_ID
	private int _customer_ID;
	private bool _customer_IDNull = true;
	/// _customerName
	private string _customerName;
	private bool _customerNameNull = true;
	/// _discount
	private int _discount;
	private bool _discountNull = true;
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
	/// _workshop_ID
	private int _workshop_ID;
	private bool _workshop_IDNull = true;
	/// _salesShift_ID
	private int _salesShift_ID;
	private bool _salesShift_IDNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SalesInformationRowBase"/> class.
	/// </summary>
	public SalesInformationRowBase():base()
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
		/// Gets or sets the <c>Barcode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Barcode</c> column value.</value>
	public string Barcode
	{
		get
		{
			if(IsBarcodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _barcode;
		}
		set
		{
			_barcodeNull = false;
			_barcode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Barcode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBarcodeNull
	{
		get
		{
			return _barcodeNull;
		}
		set
		{
			_barcodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Total</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Total</c> column value.</value>
	public decimal Total
	{
		get
		{
			if (IsTotalNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _total;
		}
		set
		{
			_totalNull = false;
			_total = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Total"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTotalNull
	{
		get
		{
			return _totalNull;
		}
		set
		{
			_totalNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Customer_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Customer_ID</c> column value.</value>
	public int Customer_ID
	{
		get
		{
			if (IsCustomer_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customer_ID;
		}
		set
		{
			_customer_IDNull = false;
			_customer_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Customer_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomer_IDNull
	{
		get
		{
			return _customer_IDNull;
		}
		set
		{
			_customer_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CustomerName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerName</c> column value.</value>
	public string CustomerName
	{
		get
		{
			if(IsCustomerNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerName;
		}
		set
		{
			_customerNameNull = false;
			_customerName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerNameNull
	{
		get
		{
			return _customerNameNull;
		}
		set
		{
			_customerNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Discount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Discount</c> column value.</value>
	public int Discount
	{
		get
		{
			if (IsDiscountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _discount;
		}
		set
		{
			_discountNull = false;
			_discount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Discount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDiscountNull
	{
		get
		{
			return _discountNull;
		}
		set
		{
			_discountNull = value;
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
		/// Gets or sets the <c>Workshop_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Workshop_ID</c> column value.</value>
	public int Workshop_ID
	{
		get
		{
			if (IsWorkshop_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _workshop_ID;
		}
		set
		{
			_workshop_IDNull = false;
			_workshop_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Workshop_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWorkshop_IDNull
	{
		get
		{
			return _workshop_IDNull;
		}
		set
		{
			_workshop_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SalesShift_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SalesShift_ID</c> column value.</value>
	public int SalesShift_ID
	{
		get
		{
			if (IsSalesShift_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _salesShift_ID;
		}
		set
		{
			_salesShift_IDNull = false;
			_salesShift_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SalesShift_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSalesShift_IDNull
	{
		get
		{
			return _salesShift_IDNull;
		}
		set
		{
			_salesShift_IDNull = value;
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
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Barcode
		dynStr.Append("  Barcode=");
		if( IsBarcodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Barcode);
		

		// Total
		dynStr.Append("  Total=");
		if( IsTotalNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Total);
		// Customer_ID
		dynStr.Append("  Customer_ID=");
		if( IsCustomer_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Customer_ID);
		// CustomerName
		dynStr.Append("  CustomerName=");
		if( IsCustomerNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CustomerName);
		

		// Discount
		dynStr.Append("  Discount=");
		if( IsDiscountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Discount);
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
		// Workshop_ID
		dynStr.Append("  Workshop_ID=");
		if( IsWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Workshop_ID);
		// SalesShift_ID
		dynStr.Append("  SalesShift_ID=");
		if( IsSalesShift_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SalesShift_ID);
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
		return dynStr.ToString();
	}
}
}




