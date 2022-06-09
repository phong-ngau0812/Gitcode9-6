
// <fileinfo name="Base\ProductPackageOrderRowBase.cs">
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
/// The base class for <see cref="ProductPackageOrderRow"/> that 
/// represents a record in the <c>ProductPackageOrder</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductPackageOrderRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageOrderRowBase
{
	/// _productPackageOrder_ID
	private int _productPackageOrder_ID;
	private bool _productPackageOrder_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _zone_ID
	private int _zone_ID;
	private bool _zone_IDNull = true;
	/// _area_ID
	private int _area_ID;
	private bool _area_IDNull = true;
	/// _workshop_ID
	private int _workshop_ID;
	private bool _workshop_IDNull = true;
	/// _farm_ID
	private int _farm_ID;
	private bool _farm_IDNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _productName
	private string _productName;
	private bool _productNameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _cultivar
	private string _cultivar;
	private bool _cultivarNull = true;
	/// _startDate
	private System.DateTime _startDate;
	private bool _startDateNull = true;
	/// _cropDate
	private System.DateTime _cropDate;
	private bool _cropDateNull = true;
	/// _endDate
	private System.DateTime _endDate;
	private bool _endDateNull = true;
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
	/// _productPackageOrderStatus_ID
	private int _productPackageOrderStatus_ID;
	private bool _productPackageOrderStatus_IDNull = true;
	/// _technicalBy
	private System.Guid _technicalBy;
	private bool _technicalByNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _itemCount
	private int _itemCount;
	private bool _itemCountNull = true;
	/// _adminApproveBy
	private System.Guid _adminApproveBy;
	private bool _adminApproveByNull = true;
	/// _adminApproveDate
	private System.DateTime _adminApproveDate;
	private bool _adminApproveDateNull = true;
	/// _acreage
	private int _acreage;
	private bool _acreageNull = true;
	/// _growthByDate
	private int _growthByDate;
	private bool _growthByDateNull = true;
	/// _expectedHarvestDate
	private int _expectedHarvestDate;
	private bool _expectedHarvestDateNull = true;
	/// _expectedProductivity
	private int _expectedProductivity;
	private bool _expectedProductivityNull = true;
	/// _expectedOutput
	private int _expectedOutput;
	private bool _expectedOutputNull = true;
	/// _productPackageOrderCategory_ID
	private int _productPackageOrderCategory_ID;
	private bool _productPackageOrderCategory_IDNull = true;
	/// _staff_ID
	private string _staff_ID;
	private bool _staff_IDNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _approve
	private int _approve;
	private bool _approveNull = true;
	/// _images
	private string _images;
	private bool _imagesNull = true;
	/// _sgtin_list
	private string _sgtin_list;
	private bool _sgtin_listNull = true;
	/// _sgtin_text
	private string _sgtin_text;
	private bool _sgtin_textNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductPackageOrderRowBase"/> class.
	/// </summary>
	public ProductPackageOrderRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageOrder_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackageOrder_ID</c> column value.</value>
	public int ProductPackageOrder_ID
	{
		get
		{
			if(IsProductPackageOrder_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageOrder_ID;
		}
		set
		{
			_productPackageOrder_IDNull = false;
			_productPackageOrder_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageOrder_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageOrder_IDNull
	{
		get
		{
			return _productPackageOrder_IDNull;
		}
		set
		{
			_productPackageOrder_IDNull = value;
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
		/// Gets or sets the <c>Zone_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Zone_ID</c> column value.</value>
	public int Zone_ID
	{
		get
		{
			if (IsZone_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _zone_ID;
		}
		set
		{
			_zone_IDNull = false;
			_zone_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Zone_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsZone_IDNull
	{
		get
		{
			return _zone_IDNull;
		}
		set
		{
			_zone_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Area_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Area_ID</c> column value.</value>
	public int Area_ID
	{
		get
		{
			if (IsArea_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _area_ID;
		}
		set
		{
			_area_IDNull = false;
			_area_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Area_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsArea_IDNull
	{
		get
		{
			return _area_IDNull;
		}
		set
		{
			_area_IDNull = value;
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
		/// Gets or sets the <c>Farm_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Farm_ID</c> column value.</value>
	public int Farm_ID
	{
		get
		{
			if (IsFarm_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farm_ID;
		}
		set
		{
			_farm_IDNull = false;
			_farm_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Farm_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarm_IDNull
	{
		get
		{
			return _farm_IDNull;
		}
		set
		{
			_farm_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Code</c> column value.</value>
	public string Code
	{
		get
		{
			if(IsCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _code;
		}
		set
		{
			_codeNull = false;
			_code = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Code"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCodeNull
	{
		get
		{
			return _codeNull;
		}
		set
		{
			_codeNull = value;
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
		/// Gets or sets the <c>ProductName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductName</c> column value.</value>
	public string ProductName
	{
		get
		{
			if(IsProductNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productName;
		}
		set
		{
			_productNameNull = false;
			_productName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductNameNull
	{
		get
		{
			return _productNameNull;
		}
		set
		{
			_productNameNull = value;
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
		/// Gets or sets the <c>Cultivar</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Cultivar</c> column value.</value>
	public string Cultivar
	{
		get
		{
			if(IsCultivarNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _cultivar;
		}
		set
		{
			_cultivarNull = false;
			_cultivar = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Cultivar"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCultivarNull
	{
		get
		{
			return _cultivarNull;
		}
		set
		{
			_cultivarNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StartDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StartDate</c> column value.</value>
	public System.DateTime StartDate
	{
		get
		{
			if (IsStartDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _startDate;
		}
		set
		{
			_startDateNull = false;
			_startDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StartDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStartDateNull
	{
		get
		{
			return _startDateNull;
		}
		set
		{
			_startDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CropDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CropDate</c> column value.</value>
	public System.DateTime CropDate
	{
		get
		{
			if (IsCropDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _cropDate;
		}
		set
		{
			_cropDateNull = false;
			_cropDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CropDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCropDateNull
	{
		get
		{
			return _cropDateNull;
		}
		set
		{
			_cropDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EndDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EndDate</c> column value.</value>
	public System.DateTime EndDate
	{
		get
		{
			if (IsEndDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _endDate;
		}
		set
		{
			_endDateNull = false;
			_endDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EndDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEndDateNull
	{
		get
		{
			return _endDateNull;
		}
		set
		{
			_endDateNull = value;
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
		/// Gets or sets the <c>ProductPackageOrderStatus_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackageOrderStatus_ID</c> column value.</value>
	public int ProductPackageOrderStatus_ID
	{
		get
		{
			if (IsProductPackageOrderStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageOrderStatus_ID;
		}
		set
		{
			_productPackageOrderStatus_IDNull = false;
			_productPackageOrderStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageOrderStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageOrderStatus_IDNull
	{
		get
		{
			return _productPackageOrderStatus_IDNull;
		}
		set
		{
			_productPackageOrderStatus_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TechnicalBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TechnicalBy</c> column value.</value>
	public System.Guid TechnicalBy
	{
		get
		{
			if (IsTechnicalByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _technicalBy;
		}
		set
		{
			_technicalByNull = false;
			_technicalBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TechnicalBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTechnicalByNull
	{
		get
		{
			return _technicalByNull;
		}
		set
		{
			_technicalByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePublicContent</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodePublicContent</c> column value.</value>
	public string QRCodePublicContent
	{
		get
		{
			if(IsQRCodePublicContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qRCodePublicContent;
		}
		set
		{
			_qRCodePublicContentNull = false;
			_qRCodePublicContent = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePublicContent"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePublicContentNull
	{
		get
		{
			return _qRCodePublicContentNull;
		}
		set
		{
			_qRCodePublicContentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ItemCount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ItemCount</c> column value.</value>
	public int ItemCount
	{
		get
		{
			if (IsItemCountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _itemCount;
		}
		set
		{
			_itemCountNull = false;
			_itemCount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ItemCount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsItemCountNull
	{
		get
		{
			return _itemCountNull;
		}
		set
		{
			_itemCountNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminApproveBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminApproveBy</c> column value.</value>
	public System.Guid AdminApproveBy
	{
		get
		{
			if (IsAdminApproveByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminApproveBy;
		}
		set
		{
			_adminApproveByNull = false;
			_adminApproveBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminApproveBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminApproveByNull
	{
		get
		{
			return _adminApproveByNull;
		}
		set
		{
			_adminApproveByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AdminApproveDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AdminApproveDate</c> column value.</value>
	public System.DateTime AdminApproveDate
	{
		get
		{
			if (IsAdminApproveDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _adminApproveDate;
		}
		set
		{
			_adminApproveDateNull = false;
			_adminApproveDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AdminApproveDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAdminApproveDateNull
	{
		get
		{
			return _adminApproveDateNull;
		}
		set
		{
			_adminApproveDateNull = value;
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
		/// Gets or sets the <c>GrowthByDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GrowthByDate</c> column value.</value>
	public int GrowthByDate
	{
		get
		{
			if (IsGrowthByDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _growthByDate;
		}
		set
		{
			_growthByDateNull = false;
			_growthByDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GrowthByDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGrowthByDateNull
	{
		get
		{
			return _growthByDateNull;
		}
		set
		{
			_growthByDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ExpectedHarvestDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExpectedHarvestDate</c> column value.</value>
	public int ExpectedHarvestDate
	{
		get
		{
			if (IsExpectedHarvestDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _expectedHarvestDate;
		}
		set
		{
			_expectedHarvestDateNull = false;
			_expectedHarvestDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ExpectedHarvestDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExpectedHarvestDateNull
	{
		get
		{
			return _expectedHarvestDateNull;
		}
		set
		{
			_expectedHarvestDateNull = value;
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
		/// Gets or sets the <c>ProductPackageOrderCategory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackageOrderCategory_ID</c> column value.</value>
	public int ProductPackageOrderCategory_ID
	{
		get
		{
			if (IsProductPackageOrderCategory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageOrderCategory_ID;
		}
		set
		{
			_productPackageOrderCategory_IDNull = false;
			_productPackageOrderCategory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageOrderCategory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageOrderCategory_IDNull
	{
		get
		{
			return _productPackageOrderCategory_IDNull;
		}
		set
		{
			_productPackageOrderCategory_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Staff_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Staff_ID</c> column value.</value>
	public string Staff_ID
	{
		get
		{
			if(IsStaff_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _staff_ID;
		}
		set
		{
			_staff_IDNull = false;
			_staff_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Staff_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStaff_IDNull
	{
		get
		{
			return _staff_IDNull;
		}
		set
		{
			_staff_IDNull = value;
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
		/// Gets or sets the <c>Approve</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Approve</c> column value.</value>
	public int Approve
	{
		get
		{
			if (IsApproveNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _approve;
		}
		set
		{
			_approveNull = false;
			_approve = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Approve"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsApproveNull
	{
		get
		{
			return _approveNull;
		}
		set
		{
			_approveNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Images</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Images</c> column value.</value>
	public string Images
	{
		get
		{
			if(IsImagesNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _images;
		}
		set
		{
			_imagesNull = false;
			_images = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Images"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImagesNull
	{
		get
		{
			return _imagesNull;
		}
		set
		{
			_imagesNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SGTIN_LIST</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SGTIN_LIST</c> column value.</value>
	public string SGTIN_LIST
	{
		get
		{
			if(IsSGTIN_LISTNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sgtin_list;
		}
		set
		{
			_sgtin_listNull = false;
			_sgtin_list = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SGTIN_LIST"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSGTIN_LISTNull
	{
		get
		{
			return _sgtin_listNull;
		}
		set
		{
			_sgtin_listNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SGTIN_TEXT</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SGTIN_TEXT</c> column value.</value>
	public string SGTIN_TEXT
	{
		get
		{
			if(IsSGTIN_TEXTNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sgtin_text;
		}
		set
		{
			_sgtin_textNull = false;
			_sgtin_text = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SGTIN_TEXT"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSGTIN_TEXTNull
	{
		get
		{
			return _sgtin_textNull;
		}
		set
		{
			_sgtin_textNull = value;
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
		// ProductPackageOrder_ID
		dynStr.Append("  ProductPackageOrder_ID=");
		if( IsProductPackageOrder_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackageOrder_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// Zone_ID
		dynStr.Append("  Zone_ID=");
		if( IsZone_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Zone_ID);
		// Area_ID
		dynStr.Append("  Area_ID=");
		if( IsArea_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Area_ID);
		// Workshop_ID
		dynStr.Append("  Workshop_ID=");
		if( IsWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Workshop_ID);
		// Farm_ID
		dynStr.Append("  Farm_ID=");
		if( IsFarm_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Farm_ID);
		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// ProductName
		dynStr.Append("  ProductName=");
		if( IsProductNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Cultivar
		dynStr.Append("  Cultivar=");
		if( IsCultivarNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Cultivar);
		

		// StartDate
		dynStr.Append("  StartDate=");
		if( IsStartDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.StartDate);
		// CropDate
		dynStr.Append("  CropDate=");
		if( IsCropDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CropDate);
		// EndDate
		dynStr.Append("  EndDate=");
		if( IsEndDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.EndDate);
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
		// ProductPackageOrderStatus_ID
		dynStr.Append("  ProductPackageOrderStatus_ID=");
		if( IsProductPackageOrderStatus_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackageOrderStatus_ID);
		// TechnicalBy
		dynStr.Append("  TechnicalBy=");
		if( IsTechnicalByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TechnicalBy);
		// QRCodePublicContent
		dynStr.Append("  QRCodePublicContent=");
		if( IsQRCodePublicContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePublicContent);
		

		// ItemCount
		dynStr.Append("  ItemCount=");
		if( IsItemCountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ItemCount);
		// AdminApproveBy
		dynStr.Append("  AdminApproveBy=");
		if( IsAdminApproveByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AdminApproveBy);
		// AdminApproveDate
		dynStr.Append("  AdminApproveDate=");
		if( IsAdminApproveDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AdminApproveDate);
		// Acreage
		dynStr.Append("  Acreage=");
		if( IsAcreageNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Acreage);
		// GrowthByDate
		dynStr.Append("  GrowthByDate=");
		if( IsGrowthByDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.GrowthByDate);
		// ExpectedHarvestDate
		dynStr.Append("  ExpectedHarvestDate=");
		if( IsExpectedHarvestDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ExpectedHarvestDate);
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
		// ProductPackageOrderCategory_ID
		dynStr.Append("  ProductPackageOrderCategory_ID=");
		if( IsProductPackageOrderCategory_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackageOrderCategory_ID);
		// Staff_ID
		dynStr.Append("  Staff_ID=");
		if( IsStaff_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Staff_ID);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Approve
		dynStr.Append("  Approve=");
		if( IsApproveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Approve);
		// Images
		dynStr.Append("  Images=");
		if( IsImagesNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Images);
		

		// SGTIN_LIST
		dynStr.Append("  SGTIN_LIST=");
		if( IsSGTIN_LISTNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SGTIN_LIST);
		

		// SGTIN_TEXT
		dynStr.Append("  SGTIN_TEXT=");
		if( IsSGTIN_TEXTNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SGTIN_TEXT);
		

		return dynStr.ToString();
	}
}
}




