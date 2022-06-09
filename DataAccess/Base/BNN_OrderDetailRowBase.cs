
// <fileinfo name="Base\BNN_OrderDetailRowBase.cs">
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
/// The base class for <see cref="BNN_OrderDetailRow"/> that 
/// represents a record in the <c>BNN_OrderDetail</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_OrderDetailRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_OrderDetailRowBase
{
	/// _orderDetail_ID
	private int _orderDetail_ID;
	private bool _orderDetail_IDNull = true;
	/// _order_ID
	private int _order_ID;
	private bool _order_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _quantity
	private int _quantity;
	private bool _quantityNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_OrderDetailRowBase"/> class.
	/// </summary>
	public BNN_OrderDetailRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>OrderDetail_ID</c> column value.
		/// </summary>
		/// <value>The <c>OrderDetail_ID</c> column value.</value>
	public int OrderDetail_ID
	{
		get
		{
			if(IsOrderDetail_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _orderDetail_ID;
		}
		set
		{
			_orderDetail_IDNull = false;
			_orderDetail_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="OrderDetail_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOrderDetail_IDNull
	{
		get
		{
			return _orderDetail_IDNull;
		}
		set
		{
			_orderDetail_IDNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// OrderDetail_ID
		dynStr.Append("  OrderDetail_ID=");
		if( IsOrderDetail_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.OrderDetail_ID);
		

		// Order_ID
		dynStr.Append("  Order_ID=");
		if( IsOrder_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Order_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
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
		return dynStr.ToString();
	}
}
}




