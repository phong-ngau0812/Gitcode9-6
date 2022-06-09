
// <fileinfo name="Base\WEB_PromotionRowBase.cs">
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
/// The base class for <see cref="WEB_PromotionRow"/> that 
/// represents a record in the <c>WEB_Promotion</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WEB_PromotionRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WEB_PromotionRowBase
{
	/// _promotion_ID
	private int _promotion_ID;
	private bool _promotion_IDNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _dateStart
	private System.DateTime _dateStart;
	private bool _dateStartNull = true;
	/// _dateEnd
	private System.DateTime _dateEnd;
	private bool _dateEndNull = true;
	/// _productList_ID
	private string _productList_ID;
	private bool _productList_IDNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _productCategory_ID
	private string _productCategory_ID;
	private bool _productCategory_IDNull = true;
	/// _warrantyDate
	private int _warrantyDate;
	private bool _warrantyDateNull = true;
	/// _type
	private bool _type;
	private bool _typeNull = true;
	/// _link
	private string _link;
	private bool _linkNull = true;
	/// _productCategoryChild_ID
	private string _productCategoryChild_ID;
	private bool _productCategoryChild_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WEB_PromotionRowBase"/> class.
	/// </summary>
	public WEB_PromotionRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Promotion_ID</c> column value.
		/// </summary>
		/// <value>The <c>Promotion_ID</c> column value.</value>
	public int Promotion_ID
	{
		get
		{
			if(IsPromotion_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _promotion_ID;
		}
		set
		{
			_promotion_IDNull = false;
			_promotion_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Promotion_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPromotion_IDNull
	{
		get
		{
			return _promotion_IDNull;
		}
		set
		{
			_promotion_IDNull = value;
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
		/// Gets or sets the <c>DateStart</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateStart</c> column value.</value>
	public System.DateTime DateStart
	{
		get
		{
			if (IsDateStartNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _dateStart;
		}
		set
		{
			_dateStartNull = false;
			_dateStart = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DateStart"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDateStartNull
	{
		get
		{
			return _dateStartNull;
		}
		set
		{
			_dateStartNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DateEnd</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateEnd</c> column value.</value>
	public System.DateTime DateEnd
	{
		get
		{
			if (IsDateEndNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _dateEnd;
		}
		set
		{
			_dateEndNull = false;
			_dateEnd = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DateEnd"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDateEndNull
	{
		get
		{
			return _dateEndNull;
		}
		set
		{
			_dateEndNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductList_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductList_ID</c> column value.</value>
	public string ProductList_ID
	{
		get
		{
			if(IsProductList_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productList_ID;
		}
		set
		{
			_productList_IDNull = false;
			_productList_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductList_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductList_IDNull
	{
		get
		{
			return _productList_IDNull;
		}
		set
		{
			_productList_IDNull = value;
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
		/// Gets or sets the <c>ProductCategory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductCategory_ID</c> column value.</value>
	public string ProductCategory_ID
	{
		get
		{
			if(IsProductCategory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productCategory_ID;
		}
		set
		{
			_productCategory_IDNull = false;
			_productCategory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductCategory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductCategory_IDNull
	{
		get
		{
			return _productCategory_IDNull;
		}
		set
		{
			_productCategory_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarrantyDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantyDate</c> column value.</value>
	public int WarrantyDate
	{
		get
		{
			if (IsWarrantyDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantyDate;
		}
		set
		{
			_warrantyDateNull = false;
			_warrantyDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantyDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantyDateNull
	{
		get
		{
			return _warrantyDateNull;
		}
		set
		{
			_warrantyDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Type</c> column value.</value>
	public bool Type
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
		/// Gets or sets the <c>Link</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Link</c> column value.</value>
	public string Link
	{
		get
		{
			if(IsLinkNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _link;
		}
		set
		{
			_linkNull = false;
			_link = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Link"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLinkNull
	{
		get
		{
			return _linkNull;
		}
		set
		{
			_linkNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductCategoryChild_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductCategoryChild_ID</c> column value.</value>
	public string ProductCategoryChild_ID
	{
		get
		{
			if(IsProductCategoryChild_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productCategoryChild_ID;
		}
		set
		{
			_productCategoryChild_IDNull = false;
			_productCategoryChild_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductCategoryChild_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductCategoryChild_IDNull
	{
		get
		{
			return _productCategoryChild_IDNull;
		}
		set
		{
			_productCategoryChild_IDNull = value;
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
		// Promotion_ID
		dynStr.Append("  Promotion_ID=");
		if( IsPromotion_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Promotion_ID);
		

		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// DateStart
		dynStr.Append("  DateStart=");
		if( IsDateStartNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DateStart);
		// DateEnd
		dynStr.Append("  DateEnd=");
		if( IsDateEndNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DateEnd);
		// ProductList_ID
		dynStr.Append("  ProductList_ID=");
		if( IsProductList_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductList_ID);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// CreateDate
		dynStr.Append("  CreateDate=");
		if( IsCreateDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateDate);
		// CreateBy
		dynStr.Append("  CreateBy=");
		if( IsCreateByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreateBy);
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
		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// ProductCategory_ID
		dynStr.Append("  ProductCategory_ID=");
		if( IsProductCategory_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductCategory_ID);
		

		// WarrantyDate
		dynStr.Append("  WarrantyDate=");
		if( IsWarrantyDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarrantyDate);
		// Type
		dynStr.Append("  Type=");
		if( IsTypeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Type);
		// Link
		dynStr.Append("  Link=");
		if( IsLinkNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Link);
		

		// ProductCategoryChild_ID
		dynStr.Append("  ProductCategoryChild_ID=");
		if( IsProductCategoryChild_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductCategoryChild_ID);
		

		return dynStr.ToString();
	}
}
}




