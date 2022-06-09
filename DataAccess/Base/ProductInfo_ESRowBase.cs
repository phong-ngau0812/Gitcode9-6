
// <fileinfo name="Base\ProductInfo_ESRowBase.cs">
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
/// The base class for <see cref="ProductInfo_ESRow"/> that 
/// represents a record in the <c>ProductInfo_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductInfo_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductInfo_ESRowBase
{
	/// _productInfo_ID
	private int _productInfo_ID;
	private bool _productInfo_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;
	/// _discount
	private int _discount;
	private bool _discountNull = true;
	/// _ocop
	private int _ocop;
	private bool _ocopNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _uses
	private string _uses;
	private bool _usesNull = true;
	/// _videoYoutube
	private string _videoYoutube;
	private bool _videoYoutubeNull = true;
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
	/// Initializes a new instance of the <see cref="ProductInfo_ESRowBase"/> class.
	/// </summary>
	public ProductInfo_ESRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductInfo_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductInfo_ID</c> column value.</value>
	public int ProductInfo_ID
	{
		get
		{
			if(IsProductInfo_IDNull)
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
		/// Gets or sets the <c>OCOP</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>OCOP</c> column value.</value>
	public int OCOP
	{
		get
		{
			if (IsOCOPNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ocop;
		}
		set
		{
			_ocopNull = false;
			_ocop = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="OCOP"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOCOPNull
	{
		get
		{
			return _ocopNull;
		}
		set
		{
			_ocopNull = value;
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
		/// Gets or sets the <c>Uses</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Uses</c> column value.</value>
	public string Uses
	{
		get
		{
			if(IsUsesNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _uses;
		}
		set
		{
			_usesNull = false;
			_uses = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Uses"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUsesNull
	{
		get
		{
			return _usesNull;
		}
		set
		{
			_usesNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>VideoYoutube</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>VideoYoutube</c> column value.</value>
	public string VideoYoutube
	{
		get
		{
			if(IsVideoYoutubeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _videoYoutube;
		}
		set
		{
			_videoYoutubeNull = false;
			_videoYoutube = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="VideoYoutube"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsVideoYoutubeNull
	{
		get
		{
			return _videoYoutubeNull;
		}
		set
		{
			_videoYoutubeNull = value;
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
		// ProductInfo_ID
		dynStr.Append("  ProductInfo_ID=");
		if( IsProductInfo_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductInfo_ID);
		

		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Product_ID);
		

		// Price
		dynStr.Append("  Price=");
		if( IsPriceNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Price);
		// Discount
		dynStr.Append("  Discount=");
		if( IsDiscountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Discount);
		// OCOP
		dynStr.Append("  OCOP=");
		if( IsOCOPNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.OCOP);
		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Uses
		dynStr.Append("  Uses=");
		if( IsUsesNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Uses);
		

		// VideoYoutube
		dynStr.Append("  VideoYoutube=");
		if( IsVideoYoutubeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.VideoYoutube);
		

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




