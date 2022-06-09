
// <fileinfo name="Base\WarehouseExportRowBase.cs">
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
/// The base class for <see cref="WarehouseExportRow"/> that 
/// represents a record in the <c>WarehouseExport</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WarehouseExportRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseExportRowBase
{
	/// _warehouseExport_ID
	private int _warehouseExport_ID;
	private bool _warehouseExport_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _warehouse_ID
	private int _warehouse_ID;
	private bool _warehouse_IDNull = true;
	/// _warehouseExportType_ID
	private int _warehouseExportType_ID;
	private bool _warehouseExportType_IDNull = true;
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _productPackageOrder_ID
	private int _productPackageOrder_ID;
	private bool _productPackageOrder_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
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
	/// _amount
	private decimal _amount;
	private bool _amountNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _sku
	private string _sku;
	private bool _skuNull = true;
	/// _exporter
	private string _exporter;
	private bool _exporterNull = true;
	/// _importer
	private string _importer;
	private bool _importerNull = true;
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
	/// _active
	private int _active;
	private bool _activeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WarehouseExportRowBase"/> class.
	/// </summary>
	public WarehouseExportRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseExport_ID</c> column value.
		/// </summary>
		/// <value>The <c>WarehouseExport_ID</c> column value.</value>
	public int WarehouseExport_ID
	{
		get
		{
			if(IsWarehouseExport_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouseExport_ID;
		}
		set
		{
			_warehouseExport_IDNull = false;
			_warehouseExport_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseExport_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseExport_IDNull
	{
		get
		{
			return _warehouseExport_IDNull;
		}
		set
		{
			_warehouseExport_IDNull = value;
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
		/// Gets or sets the <c>Warehouse_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Warehouse_ID</c> column value.</value>
	public int Warehouse_ID
	{
		get
		{
			if (IsWarehouse_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouse_ID;
		}
		set
		{
			_warehouse_IDNull = false;
			_warehouse_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Warehouse_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouse_IDNull
	{
		get
		{
			return _warehouse_IDNull;
		}
		set
		{
			_warehouse_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseExportType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarehouseExportType_ID</c> column value.</value>
	public int WarehouseExportType_ID
	{
		get
		{
			if (IsWarehouseExportType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouseExportType_ID;
		}
		set
		{
			_warehouseExportType_IDNull = false;
			_warehouseExportType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseExportType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseExportType_IDNull
	{
		get
		{
			return _warehouseExportType_IDNull;
		}
		set
		{
			_warehouseExportType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Material_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Material_ID</c> column value.</value>
	public int Material_ID
	{
		get
		{
			if (IsMaterial_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _material_ID;
		}
		set
		{
			_material_IDNull = false;
			_material_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Material_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMaterial_IDNull
	{
		get
		{
			return _material_IDNull;
		}
		set
		{
			_material_IDNull = value;
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
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public int ProductPackage_ID
	{
		get
		{
			if (IsProductPackage_IDNull)
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
		/// Gets or sets the <c>Amount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Amount</c> column value.</value>
	public decimal Amount
	{
		get
		{
			if (IsAmountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amount;
		}
		set
		{
			_amountNull = false;
			_amount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Amount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountNull
	{
		get
		{
			return _amountNull;
		}
		set
		{
			_amountNull = value;
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
		/// Gets or sets the <c>SKU</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SKU</c> column value.</value>
	public string SKU
	{
		get
		{
			if(IsSKUNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sku;
		}
		set
		{
			_skuNull = false;
			_sku = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SKU"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSKUNull
	{
		get
		{
			return _skuNull;
		}
		set
		{
			_skuNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Exporter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Exporter</c> column value.</value>
	public string Exporter
	{
		get
		{
			if(IsExporterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _exporter;
		}
		set
		{
			_exporterNull = false;
			_exporter = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Exporter"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsExporterNull
	{
		get
		{
			return _exporterNull;
		}
		set
		{
			_exporterNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Importer</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Importer</c> column value.</value>
	public string Importer
	{
		get
		{
			if(IsImporterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _importer;
		}
		set
		{
			_importerNull = false;
			_importer = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Importer"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImporterNull
	{
		get
		{
			return _importerNull;
		}
		set
		{
			_importerNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// WarehouseExport_ID
		dynStr.Append("  WarehouseExport_ID=");
		if( IsWarehouseExport_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WarehouseExport_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Warehouse_ID
		dynStr.Append("  Warehouse_ID=");
		if( IsWarehouse_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Warehouse_ID);
		// WarehouseExportType_ID
		dynStr.Append("  WarehouseExportType_ID=");
		if( IsWarehouseExportType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarehouseExportType_ID);
		// Material_ID
		dynStr.Append("  Material_ID=");
		if( IsMaterial_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Material_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// ProductPackageOrder_ID
		dynStr.Append("  ProductPackageOrder_ID=");
		if( IsProductPackageOrder_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackageOrder_ID);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
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
		// Amount
		dynStr.Append("  Amount=");
		if( IsAmountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Amount);
		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// SKU
		dynStr.Append("  SKU=");
		if( IsSKUNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SKU);
		

		// Exporter
		dynStr.Append("  Exporter=");
		if( IsExporterNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Exporter);
		

		// Importer
		dynStr.Append("  Importer=");
		if( IsImporterNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Importer);
		

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




