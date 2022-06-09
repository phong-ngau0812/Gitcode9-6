
// <fileinfo name="Base\Product_ESRowBase.cs">
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
/// The base class for <see cref="Product_ESRow"/> that 
/// represents a record in the <c>Product_ES</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="Product_ESRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class Product_ESRowBase
{
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _store_ID
	private int _store_ID;
	private bool _store_IDNull = true;
	/// _productCategory_ID
	private int _productCategory_ID;
	private bool _productCategory_IDNull = true;
	/// _productType_ID
	private int _productType_ID;
	private bool _productType_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _quality_ID
	private int _quality_ID;
	private bool _quality_IDNull = true;
	/// _customer_ID
	private int _customer_ID;
	private bool _customer_IDNull = true;
	/// _country_ID
	private int _country_ID;
	private bool _country_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _content
	private string _content;
	private bool _contentNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _qualityImages
	private string _qualityImages;
	private bool _qualityImagesNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;
	/// _priceOld
	private decimal _priceOld;
	private bool _priceOldNull = true;
	/// _unit
	private string _unit;
	private bool _unitNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _qualityName
	private string _qualityName;
	private bool _qualityNameNull = true;
	/// _qualityOrganizationName
	private string _qualityOrganizationName;
	private bool _qualityOrganizationNameNull = true;
	/// _qualityOrganizationAddress
	private string _qualityOrganizationAddress;
	private bool _qualityOrganizationAddressNull = true;
	/// _qualityDescription
	private string _qualityDescription;
	private bool _qualityDescriptionNull = true;
	/// _growthByDay
	private int _growthByDay;
	private bool _growthByDayNull = true;
	/// _expiry
	private string _expiry;
	private bool _expiryNull = true;
	/// _expiryByDate
	private int _expiryByDate;
	private bool _expiryByDateNull = true;
	/// _warrantyMonth
	private int _warrantyMonth;
	private bool _warrantyMonthNull = true;
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
	/// _expectedProductivity
	private int _expectedProductivity;
	private bool _expectedProductivityNull = true;
	/// _expectedOutput
	private int _expectedOutput;
	private bool _expectedOutputNull = true;
	/// _expectedProductivityDescription
	private string _expectedProductivityDescription;
	private bool _expectedProductivityDescriptionNull = true;
	/// _expectedOutputDescription
	private string _expectedOutputDescription;
	private bool _expectedOutputDescriptionNull = true;
	/// _sgtin
	private string _sgtin;
	private bool _sgtinNull = true;
	/// _acreage
	private int _acreage;
	private bool _acreageNull = true;
	/// _trackingCode
	private string _trackingCode;
	private bool _trackingCodeNull = true;
	/// _product_ID_Parent
	private int _product_ID_Parent;
	private bool _product_ID_ParentNull = true;
	/// _story
	private string _story;
	private bool _storyNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="Product_ESRowBase"/> class.
	/// </summary>
	public Product_ESRowBase():base()
	{
		// EMPTY
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
		/// Gets or sets the <c>Store_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Store_ID</c> column value.</value>
	public int Store_ID
	{
		get
		{
			if (IsStore_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _store_ID;
		}
		set
		{
			_store_IDNull = false;
			_store_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Store_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStore_IDNull
	{
		get
		{
			return _store_IDNull;
		}
		set
		{
			_store_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductCategory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductCategory_ID</c> column value.</value>
	public int ProductCategory_ID
	{
		get
		{
			if (IsProductCategory_IDNull)
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
		/// Gets or sets the <c>ProductType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductType_ID</c> column value.</value>
	public int ProductType_ID
	{
		get
		{
			if (IsProductType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productType_ID;
		}
		set
		{
			_productType_IDNull = false;
			_productType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductType_IDNull
	{
		get
		{
			return _productType_IDNull;
		}
		set
		{
			_productType_IDNull = value;
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
		/// Gets or sets the <c>Quality_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Quality_ID</c> column value.</value>
	public int Quality_ID
	{
		get
		{
			if (IsQuality_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _quality_ID;
		}
		set
		{
			_quality_IDNull = false;
			_quality_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Quality_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQuality_IDNull
	{
		get
		{
			return _quality_IDNull;
		}
		set
		{
			_quality_IDNull = value;
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
		/// Gets or sets the <c>Country_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Country_ID</c> column value.</value>
	public int Country_ID
	{
		get
		{
			if (IsCountry_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _country_ID;
		}
		set
		{
			_country_IDNull = false;
			_country_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Country_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCountry_IDNull
	{
		get
		{
			return _country_IDNull;
		}
		set
		{
			_country_IDNull = value;
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
		/// Gets or sets the <c>Content</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Content</c> column value.</value>
	public string Content
	{
		get
		{
			if(IsContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _content;
		}
		set
		{
			_contentNull = false;
			_content = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Content"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContentNull
	{
		get
		{
			return _contentNull;
		}
		set
		{
			_contentNull = value;
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
		/// Gets or sets the <c>QualityImages</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityImages</c> column value.</value>
	public string QualityImages
	{
		get
		{
			if(IsQualityImagesNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityImages;
		}
		set
		{
			_qualityImagesNull = false;
			_qualityImages = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityImages"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityImagesNull
	{
		get
		{
			return _qualityImagesNull;
		}
		set
		{
			_qualityImagesNull = value;
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
		/// Gets or sets the <c>PriceOld</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PriceOld</c> column value.</value>
	public decimal PriceOld
	{
		get
		{
			if (IsPriceOldNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _priceOld;
		}
		set
		{
			_priceOldNull = false;
			_priceOld = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PriceOld"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPriceOldNull
	{
		get
		{
			return _priceOldNull;
		}
		set
		{
			_priceOldNull = value;
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
		/// Gets or sets the <c>URL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>URL</c> column value.</value>
	public string URL
	{
		get
		{
			if(IsURLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _url;
		}
		set
		{
			_urlNull = false;
			_url = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="URL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsURLNull
	{
		get
		{
			return _urlNull;
		}
		set
		{
			_urlNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityName</c> column value.</value>
	public string QualityName
	{
		get
		{
			if(IsQualityNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityName;
		}
		set
		{
			_qualityNameNull = false;
			_qualityName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityNameNull
	{
		get
		{
			return _qualityNameNull;
		}
		set
		{
			_qualityNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityOrganizationName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityOrganizationName</c> column value.</value>
	public string QualityOrganizationName
	{
		get
		{
			if(IsQualityOrganizationNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityOrganizationName;
		}
		set
		{
			_qualityOrganizationNameNull = false;
			_qualityOrganizationName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityOrganizationName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityOrganizationNameNull
	{
		get
		{
			return _qualityOrganizationNameNull;
		}
		set
		{
			_qualityOrganizationNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityOrganizationAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityOrganizationAddress</c> column value.</value>
	public string QualityOrganizationAddress
	{
		get
		{
			if(IsQualityOrganizationAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityOrganizationAddress;
		}
		set
		{
			_qualityOrganizationAddressNull = false;
			_qualityOrganizationAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityOrganizationAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityOrganizationAddressNull
	{
		get
		{
			return _qualityOrganizationAddressNull;
		}
		set
		{
			_qualityOrganizationAddressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QualityDescription</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QualityDescription</c> column value.</value>
	public string QualityDescription
	{
		get
		{
			if(IsQualityDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qualityDescription;
		}
		set
		{
			_qualityDescriptionNull = false;
			_qualityDescription = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QualityDescription"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQualityDescriptionNull
	{
		get
		{
			return _qualityDescriptionNull;
		}
		set
		{
			_qualityDescriptionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>GrowthByDay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GrowthByDay</c> column value.</value>
	public int GrowthByDay
	{
		get
		{
			if (IsGrowthByDayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _growthByDay;
		}
		set
		{
			_growthByDayNull = false;
			_growthByDay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GrowthByDay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGrowthByDayNull
	{
		get
		{
			return _growthByDayNull;
		}
		set
		{
			_growthByDayNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Expiry</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Expiry</c> column value.</value>
	public string Expiry
	{
		get
		{
			if(IsExpiryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expiry;
		}
		set
		{
			_expiryNull = false;
			_expiry = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Expiry"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpiryNull
	{
		get
		{
			return _expiryNull;
		}
		set
		{
			_expiryNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpiryByDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpiryByDate</c> column value.</value>
	public int ExpiryByDate
	{
		get
		{
			if (IsExpiryByDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expiryByDate;
		}
		set
		{
			_expiryByDateNull = false;
			_expiryByDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpiryByDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpiryByDateNull
	{
		get
		{
			return _expiryByDateNull;
		}
		set
		{
			_expiryByDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarrantyMonth</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarrantyMonth</c> column value.</value>
	public int WarrantyMonth
	{
		get
		{
			if (IsWarrantyMonthNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warrantyMonth;
		}
		set
		{
			_warrantyMonthNull = false;
			_warrantyMonth = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarrantyMonth"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarrantyMonthNull
	{
		get
		{
			return _warrantyMonthNull;
		}
		set
		{
			_warrantyMonthNull = value;
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
		/// Gets or sets the <c>ExpectedProductivity</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpectedProductivity</c> column value.</value>
	public int ExpectedProductivity
	{
		get
		{
			if (IsExpectedProductivityNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expectedProductivity;
		}
		set
		{
			_expectedProductivityNull = false;
			_expectedProductivity = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpectedProductivity"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpectedProductivityNull
	{
		get
		{
			return _expectedProductivityNull;
		}
		set
		{
			_expectedProductivityNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpectedOutput</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpectedOutput</c> column value.</value>
	public int ExpectedOutput
	{
		get
		{
			if (IsExpectedOutputNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expectedOutput;
		}
		set
		{
			_expectedOutputNull = false;
			_expectedOutput = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpectedOutput"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpectedOutputNull
	{
		get
		{
			return _expectedOutputNull;
		}
		set
		{
			_expectedOutputNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpectedProductivityDescription</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpectedProductivityDescription</c> column value.</value>
	public string ExpectedProductivityDescription
	{
		get
		{
			if(IsExpectedProductivityDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expectedProductivityDescription;
		}
		set
		{
			_expectedProductivityDescriptionNull = false;
			_expectedProductivityDescription = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpectedProductivityDescription"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpectedProductivityDescriptionNull
	{
		get
		{
			return _expectedProductivityDescriptionNull;
		}
		set
		{
			_expectedProductivityDescriptionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpectedOutputDescription</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpectedOutputDescription</c> column value.</value>
	public string ExpectedOutputDescription
	{
		get
		{
			if(IsExpectedOutputDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expectedOutputDescription;
		}
		set
		{
			_expectedOutputDescriptionNull = false;
			_expectedOutputDescription = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpectedOutputDescription"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpectedOutputDescriptionNull
	{
		get
		{
			return _expectedOutputDescriptionNull;
		}
		set
		{
			_expectedOutputDescriptionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SGTIN</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SGTIN</c> column value.</value>
	public string SGTIN
	{
		get
		{
			if(IsSGTINNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sgtin;
		}
		set
		{
			_sgtinNull = false;
			_sgtin = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SGTIN"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSGTINNull
	{
		get
		{
			return _sgtinNull;
		}
		set
		{
			_sgtinNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Acreage</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Acreage</c> column value.</value>
	public int Acreage
	{
		get
		{
			if (IsAcreageNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _acreage;
		}
		set
		{
			_acreageNull = false;
			_acreage = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Acreage"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAcreageNull
	{
		get
		{
			return _acreageNull;
		}
		set
		{
			_acreageNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TrackingCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TrackingCode</c> column value.</value>
	public string TrackingCode
	{
		get
		{
			if(IsTrackingCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _trackingCode;
		}
		set
		{
			_trackingCodeNull = false;
			_trackingCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TrackingCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTrackingCodeNull
	{
		get
		{
			return _trackingCodeNull;
		}
		set
		{
			_trackingCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Product_ID_Parent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Product_ID_Parent</c> column value.</value>
	public int Product_ID_Parent
	{
		get
		{
			if (IsProduct_ID_ParentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _product_ID_Parent;
		}
		set
		{
			_product_ID_ParentNull = false;
			_product_ID_Parent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Product_ID_Parent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduct_ID_ParentNull
	{
		get
		{
			return _product_ID_ParentNull;
		}
		set
		{
			_product_ID_ParentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Story</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Story</c> column value.</value>
	public string Story
	{
		get
		{
			if(IsStoryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _story;
		}
		set
		{
			_storyNull = false;
			_story = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Story"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStoryNull
	{
		get
		{
			return _storyNull;
		}
		set
		{
			_storyNull = value;
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
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Product_ID);
		

		// Store_ID
		dynStr.Append("  Store_ID=");
		if( IsStore_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Store_ID);
		// ProductCategory_ID
		dynStr.Append("  ProductCategory_ID=");
		if( IsProductCategory_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductCategory_ID);
		// ProductType_ID
		dynStr.Append("  ProductType_ID=");
		if( IsProductType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductType_ID);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Quality_ID
		dynStr.Append("  Quality_ID=");
		if( IsQuality_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Quality_ID);
		// Customer_ID
		dynStr.Append("  Customer_ID=");
		if( IsCustomer_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Customer_ID);
		// Country_ID
		dynStr.Append("  Country_ID=");
		if( IsCountry_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Country_ID);
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
		

		// Content
		dynStr.Append("  Content=");
		if( IsContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Content);
		

		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// QualityImages
		dynStr.Append("  QualityImages=");
		if( IsQualityImagesNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityImages);
		

		// Price
		dynStr.Append("  Price=");
		if( IsPriceNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Price);
		// PriceOld
		dynStr.Append("  PriceOld=");
		if( IsPriceOldNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.PriceOld);
		// Unit
		dynStr.Append("  Unit=");
		if( IsUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Unit);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// QualityName
		dynStr.Append("  QualityName=");
		if( IsQualityNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityName);
		

		// QualityOrganizationName
		dynStr.Append("  QualityOrganizationName=");
		if( IsQualityOrganizationNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityOrganizationName);
		

		// QualityOrganizationAddress
		dynStr.Append("  QualityOrganizationAddress=");
		if( IsQualityOrganizationAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityOrganizationAddress);
		

		// QualityDescription
		dynStr.Append("  QualityDescription=");
		if( IsQualityDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QualityDescription);
		

		// GrowthByDay
		dynStr.Append("  GrowthByDay=");
		if( IsGrowthByDayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.GrowthByDay);
		// Expiry
		dynStr.Append("  Expiry=");
		if( IsExpiryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Expiry);
		

		// ExpiryByDate
		dynStr.Append("  ExpiryByDate=");
		if( IsExpiryByDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ExpiryByDate);
		// WarrantyMonth
		dynStr.Append("  WarrantyMonth=");
		if( IsWarrantyMonthNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarrantyMonth);
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
		// ExpectedProductivity
		dynStr.Append("  ExpectedProductivity=");
		if( IsExpectedProductivityNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ExpectedProductivity);
		// ExpectedOutput
		dynStr.Append("  ExpectedOutput=");
		if( IsExpectedOutputNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ExpectedOutput);
		// ExpectedProductivityDescription
		dynStr.Append("  ExpectedProductivityDescription=");
		if( IsExpectedProductivityDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ExpectedProductivityDescription);
		

		// ExpectedOutputDescription
		dynStr.Append("  ExpectedOutputDescription=");
		if( IsExpectedOutputDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ExpectedOutputDescription);
		

		// SGTIN
		dynStr.Append("  SGTIN=");
		if( IsSGTINNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SGTIN);
		

		// Acreage
		dynStr.Append("  Acreage=");
		if( IsAcreageNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Acreage);
		// TrackingCode
		dynStr.Append("  TrackingCode=");
		if( IsTrackingCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TrackingCode);
		

		// Product_ID_Parent
		dynStr.Append("  Product_ID_Parent=");
		if( IsProduct_ID_ParentNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID_Parent);
		// Story
		dynStr.Append("  Story=");
		if( IsStoryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Story);
		

		return dynStr.ToString();
	}
}
}




