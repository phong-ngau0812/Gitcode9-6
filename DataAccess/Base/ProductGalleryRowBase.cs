
// <fileinfo name="Base\ProductGalleryRowBase.cs">
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
/// The base class for <see cref="ProductGalleryRow"/> that 
/// represents a record in the <c>ProductGallery</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductGalleryRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductGalleryRowBase
{
	/// _productGallery_ID
	private int _productGallery_ID;
	private bool _productGallery_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _alt
	private string _alt;
	private bool _altNull = true;
	/// _type
	private int _type;
	private bool _typeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductGalleryRowBase"/> class.
	/// </summary>
	public ProductGalleryRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductGallery_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductGallery_ID</c> column value.</value>
	public int ProductGallery_ID
	{
		get
		{
			if(IsProductGallery_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productGallery_ID;
		}
		set
		{
			_productGallery_IDNull = false;
			_productGallery_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductGallery_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductGallery_IDNull
	{
		get
		{
			return _productGallery_IDNull;
		}
		set
		{
			_productGallery_IDNull = value;
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
		/// Gets or sets the <c>Image</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Image</c> column value.</value>
	public string Image
	{
		get
		{
			if(IsImageNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _image;
		}
		set
		{
			_imageNull = false;
			_image = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Image"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImageNull
	{
		get
		{
			return _imageNull;
		}
		set
		{
			_imageNull = value;
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
		/// Gets or sets the <c>Alt</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Alt</c> column value.</value>
	public string Alt
	{
		get
		{
			if(IsAltNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _alt;
		}
		set
		{
			_altNull = false;
			_alt = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Alt"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAltNull
	{
		get
		{
			return _altNull;
		}
		set
		{
			_altNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Type</c> column value.</value>
	public int Type
	{
		get
		{
			if (IsTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _type;
		}
		set
		{
			_typeNull = false;
			_type = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Type"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTypeNull
	{
		get
		{
			return _typeNull;
		}
		set
		{
			_typeNull = value;
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
		// ProductGallery_ID
		dynStr.Append("  ProductGallery_ID=");
		if( IsProductGallery_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductGallery_ID);
		

		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// Alt
		dynStr.Append("  Alt=");
		if( IsAltNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Alt);
		

		// Type
		dynStr.Append("  Type=");
		if( IsTypeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Type);
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




