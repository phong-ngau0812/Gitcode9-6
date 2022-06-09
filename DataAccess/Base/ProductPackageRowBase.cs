
// <fileinfo name="Base\ProductPackageRowBase.cs">
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
/// The base class for <see cref="ProductPackageRow"/> that 
/// represents a record in the <c>ProductPackage</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="ProductPackageRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class ProductPackageRowBase
{
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
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
	/// _productPackageStatus_ID
	private int _productPackageStatus_ID;
	private bool _productPackageStatus_IDNull = true;
	/// _productPackageOrder_ID
	private int _productPackageOrder_ID;
	private bool _productPackageOrder_IDNull = true;
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
	/// _cameraURL
	private string _cameraURL;
	private bool _cameraURLNull = true;
	/// _location
	private string _location;
	private bool _locationNull = true;
	/// _secretary
	private string _secretary;
	private bool _secretaryNull = true;
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
	/// _technicalBy
	private System.Guid _technicalBy;
	private bool _technicalByNull = true;
	/// _qRCodePublicContent
	private string _qRCodePublicContent;
	private bool _qRCodePublicContentNull = true;
	/// _itemCount
	private int _itemCount;
	private bool _itemCountNull = true;
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
	/// _customer_ID
	private string _customer_ID;
	private bool _customer_IDNull = true;
	/// _sgtin
	private string _sgtin;
	private bool _sgtinNull = true;
	/// _sGTIN_History
	private string _sGTIN_History;
	private bool _sGTIN_HistoryNull = true;
	/// _supplier_ID
	private string _supplier_ID;
	private bool _supplier_IDNull = true;
	/// _storageTemperatures
	private string _storageTemperatures;
	private bool _storageTemperaturesNull = true;
	/// _secretary_UserID
	private System.Guid _secretary_UserID;
	private bool _secretary_UserIDNull = true;
	/// _testingCertificates_ID
	private string _testingCertificates_ID;
	private bool _testingCertificates_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="ProductPackageRowBase"/> class.
	/// </summary>
	public ProductPackageRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if(IsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackage_ID;
		}
		set
		{
			_productPackage_IDNull = false;
			_productPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackage_IDNull
	{
		get
		{
			return _productPackage_IDNull;
		}
		set
		{
			_productPackage_IDNull = value;
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
		/// Gets or sets the <c>ProductPackageStatus_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackageStatus_ID</c> column value.</value>
	public int ProductPackageStatus_ID
	{
		get
		{
			if (IsProductPackageStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageStatus_ID;
		}
		set
		{
			_productPackageStatus_IDNull = false;
			_productPackageStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageStatus_IDNull
	{
		get
		{
			return _productPackageStatus_IDNull;
		}
		set
		{
			_productPackageStatus_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageOrder_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackageOrder_ID</c> column value.</value>
	public int ProductPackageOrder_ID
	{
		get
		{
			if (IsProductPackageOrder_IDNull)
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
		/// Gets or sets the <c>CameraURL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CameraURL</c> column value.</value>
	public string CameraURL
	{
		get
		{
			if(IsCameraURLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _cameraURL;
		}
		set
		{
			_cameraURLNull = false;
			_cameraURL = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CameraURL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCameraURLNull
	{
		get
		{
			return _cameraURLNull;
		}
		set
		{
			_cameraURLNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location</c> column value.</value>
	public string Location
	{
		get
		{
			if(IsLocationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location;
		}
		set
		{
			_locationNull = false;
			_location = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationNull
	{
		get
		{
			return _locationNull;
		}
		set
		{
			_locationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Secretary</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Secretary</c> column value.</value>
	public string Secretary
	{
		get
		{
			if(IsSecretaryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _secretary;
		}
		set
		{
			_secretaryNull = false;
			_secretary = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Secretary"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSecretaryNull
	{
		get
		{
			return _secretaryNull;
		}
		set
		{
			_secretaryNull = value;
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
		/// Gets or sets the <c>Customer_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Customer_ID</c> column value.</value>
	public string Customer_ID
	{
		get
		{
			if(IsCustomer_IDNull)
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
		/// Gets or sets the <c>SGTIN_History</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SGTIN_History</c> column value.</value>
	public string SGTIN_History
	{
		get
		{
			if(IsSGTIN_HistoryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sGTIN_History;
		}
		set
		{
			_sGTIN_HistoryNull = false;
			_sGTIN_History = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SGTIN_History"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSGTIN_HistoryNull
	{
		get
		{
			return _sGTIN_HistoryNull;
		}
		set
		{
			_sGTIN_HistoryNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Supplier_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Supplier_ID</c> column value.</value>
	public string Supplier_ID
	{
		get
		{
			if(IsSupplier_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _supplier_ID;
		}
		set
		{
			_supplier_IDNull = false;
			_supplier_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Supplier_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSupplier_IDNull
	{
		get
		{
			return _supplier_IDNull;
		}
		set
		{
			_supplier_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StorageTemperatures</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StorageTemperatures</c> column value.</value>
	public string StorageTemperatures
	{
		get
		{
			if(IsStorageTemperaturesNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _storageTemperatures;
		}
		set
		{
			_storageTemperaturesNull = false;
			_storageTemperatures = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StorageTemperatures"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStorageTemperaturesNull
	{
		get
		{
			return _storageTemperaturesNull;
		}
		set
		{
			_storageTemperaturesNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Secretary_UserID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Secretary_UserID</c> column value.</value>
	public System.Guid Secretary_UserID
	{
		get
		{
			if (IsSecretary_UserIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _secretary_UserID;
		}
		set
		{
			_secretary_UserIDNull = false;
			_secretary_UserID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Secretary_UserID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSecretary_UserIDNull
	{
		get
		{
			return _secretary_UserIDNull;
		}
		set
		{
			_secretary_UserIDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TestingCertificates_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TestingCertificates_ID</c> column value.</value>
	public string TestingCertificates_ID
	{
		get
		{
			if(IsTestingCertificates_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _testingCertificates_ID;
		}
		set
		{
			_testingCertificates_IDNull = false;
			_testingCertificates_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TestingCertificates_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTestingCertificates_IDNull
	{
		get
		{
			return _testingCertificates_IDNull;
		}
		set
		{
			_testingCertificates_IDNull = value;
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
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackage_ID);
		

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
		// ProductPackageStatus_ID
		dynStr.Append("  ProductPackageStatus_ID=");
		if( IsProductPackageStatus_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackageStatus_ID);
		// ProductPackageOrder_ID
		dynStr.Append("  ProductPackageOrder_ID=");
		if( IsProductPackageOrder_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackageOrder_ID);
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
		

		// CameraURL
		dynStr.Append("  CameraURL=");
		if( IsCameraURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CameraURL);
		

		// Location
		dynStr.Append("  Location=");
		if( IsLocationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Location);
		

		// Secretary
		dynStr.Append("  Secretary=");
		if( IsSecretaryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Secretary);
		

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
		// Customer_ID
		dynStr.Append("  Customer_ID=");
		if( IsCustomer_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Customer_ID);
		

		// SGTIN
		dynStr.Append("  SGTIN=");
		if( IsSGTINNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SGTIN);
		

		// SGTIN_History
		dynStr.Append("  SGTIN_History=");
		if( IsSGTIN_HistoryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SGTIN_History);
		

		// Supplier_ID
		dynStr.Append("  Supplier_ID=");
		if( IsSupplier_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Supplier_ID);
		

		// StorageTemperatures
		dynStr.Append("  StorageTemperatures=");
		if( IsStorageTemperaturesNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StorageTemperatures);
		

		// Secretary_UserID
		dynStr.Append("  Secretary_UserID=");
		if( IsSecretary_UserIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Secretary_UserID);
		// TestingCertificates_ID
		dynStr.Append("  TestingCertificates_ID=");
		if( IsTestingCertificates_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TestingCertificates_ID);
		

		return dynStr.ToString();
	}
}
}




