
// <fileinfo name="Base\WarehouseImportRowBase.cs">
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
/// The base class for <see cref="WarehouseImportRow"/> that 
/// represents a record in the <c>WarehouseImport</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WarehouseImportRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseImportRowBase
{
	/// _warehouseImport_ID
	private int _warehouseImport_ID;
	private bool _warehouseImport_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _warehouse_ID
	private int _warehouse_ID;
	private bool _warehouse_IDNull = true;
	/// _warehouseImportType_ID
	private int _warehouseImportType_ID;
	private bool _warehouseImportType_IDNull = true;
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _amount
	private decimal _amount;
	private bool _amountNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
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
	/// Initializes a new instance of the <see cref="WarehouseImportRowBase"/> class.
	/// </summary>
	public WarehouseImportRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseImport_ID</c> column value.
		/// </summary>
		/// <value>The <c>WarehouseImport_ID</c> column value.</value>
	public int WarehouseImport_ID
	{
		get
		{
			if(IsWarehouseImport_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouseImport_ID;
		}
		set
		{
			_warehouseImport_IDNull = false;
			_warehouseImport_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseImport_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseImport_IDNull
	{
		get
		{
			return _warehouseImport_IDNull;
		}
		set
		{
			_warehouseImport_IDNull = value;
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
		/// Gets or sets the <c>WarehouseImportType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarehouseImportType_ID</c> column value.</value>
	public int WarehouseImportType_ID
	{
		get
		{
			if (IsWarehouseImportType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouseImportType_ID;
		}
		set
		{
			_warehouseImportType_IDNull = false;
			_warehouseImportType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseImportType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseImportType_IDNull
	{
		get
		{
			return _warehouseImportType_IDNull;
		}
		set
		{
			_warehouseImportType_IDNull = value;
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
		// WarehouseImport_ID
		dynStr.Append("  WarehouseImport_ID=");
		if( IsWarehouseImport_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WarehouseImport_ID);
		

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
		// WarehouseImportType_ID
		dynStr.Append("  WarehouseImportType_ID=");
		if( IsWarehouseImportType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarehouseImportType_ID);
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




