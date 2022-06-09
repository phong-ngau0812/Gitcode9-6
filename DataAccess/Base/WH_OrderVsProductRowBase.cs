
// <fileinfo name="Base\WH_OrderVsProductRowBase.cs">
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
/// The base class for <see cref="WH_OrderVsProductRow"/> that 
/// represents a record in the <c>WH_OrderVsProduct</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_OrderVsProductRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_OrderVsProductRowBase
{
	/// _orderVsProduct_ID
	private int _orderVsProduct_ID;
	private bool _orderVsProduct_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _order_ID
	private int _order_ID;
	private bool _order_IDNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;
	/// _quantity
	private int _quantity;
	private bool _quantityNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;
	/// _totalPrice
	private decimal _totalPrice;
	private bool _totalPriceNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_OrderVsProductRowBase"/> class.
	/// </summary>
	public WH_OrderVsProductRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>OrderVsProduct_ID</c> column value.
		/// </summary>
		/// <value>The <c>OrderVsProduct_ID</c> column value.</value>
	public int OrderVsProduct_ID
	{
		get
		{
			if(IsOrderVsProduct_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _orderVsProduct_ID;
		}
		set
		{
			_orderVsProduct_IDNull = false;
			_orderVsProduct_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="OrderVsProduct_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOrderVsProduct_IDNull
	{
		get
		{
			return _orderVsProduct_IDNull;
		}
		set
		{
			_orderVsProduct_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Product_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Product_ID</c> column value.</value>
	public int Product_ID
	{
		get
		{
			if (IsProduct_IDNull)
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
		/// Gets or sets the <c>Order_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Order_ID</c> column value.</value>
	public int Order_ID
	{
		get
		{
			if (IsOrder_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _order_ID;
		}
		set
		{
			_order_IDNull = false;
			_order_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Order_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOrder_IDNull
	{
		get
		{
			return _order_IDNull;
		}
		set
		{
			_order_IDNull = value;
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
		/// Gets or sets the <c>TotalPrice</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TotalPrice</c> column value.</value>
	public decimal TotalPrice
	{
		get
		{
			if (IsTotalPriceNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _totalPrice;
		}
		set
		{
			_totalPriceNull = false;
			_totalPrice = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TotalPrice"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTotalPriceNull
	{
		get
		{
			return _totalPriceNull;
		}
		set
		{
			_totalPriceNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public bool Active
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
		// OrderVsProduct_ID
		dynStr.Append("  OrderVsProduct_ID=");
		if( IsOrderVsProduct_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.OrderVsProduct_ID);
		

		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// Order_ID
		dynStr.Append("  Order_ID=");
		if( IsOrder_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Order_ID);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
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
		// TotalPrice
		dynStr.Append("  TotalPrice=");
		if( IsTotalPriceNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TotalPrice);
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




