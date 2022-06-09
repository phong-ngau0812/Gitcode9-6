
// <fileinfo name="Base\WH_MaterialRowBase.cs">
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
/// The base class for <see cref="WH_MaterialRow"/> that 
/// represents a record in the <c>WH_Material</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_MaterialRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_MaterialRowBase
{
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _materialCategory_ID
	private int _materialCategory_ID;
	private bool _materialCategory_IDNull = true;
	/// _materialBrand_ID
	private int _materialBrand_ID;
	private bool _materialBrand_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _supplier_ID
	private string _supplier_ID;
	private bool _supplier_IDNull = true;
	/// _warehouse_ID
	private string _warehouse_ID;
	private bool _warehouse_IDNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _country
	private string _country;
	private bool _countryNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;
	/// _priceOld
	private decimal _priceOld;
	private bool _priceOldNull = true;
	/// _unit
	private string _unit;
	private bool _unitNull = true;
	/// _packingType
	private string _packingType;
	private bool _packingTypeNull = true;
	/// _activeIngredient
	private string _activeIngredient;
	private bool _activeIngredientNull = true;
	/// _isolationDay
	private int _isolationDay;
	private bool _isolationDayNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
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
	/// _giai
	private string _giai;
	private bool _giaiNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_MaterialRowBase"/> class.
	/// </summary>
	public WH_MaterialRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Material_ID</c> column value.
		/// </summary>
		/// <value>The <c>Material_ID</c> column value.</value>
	public int Material_ID
	{
		get
		{
			if(IsMaterial_IDNull)
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
		/// Gets or sets the <c>MaterialCategory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MaterialCategory_ID</c> column value.</value>
	public int MaterialCategory_ID
	{
		get
		{
			if (IsMaterialCategory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _materialCategory_ID;
		}
		set
		{
			_materialCategory_IDNull = false;
			_materialCategory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MaterialCategory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMaterialCategory_IDNull
	{
		get
		{
			return _materialCategory_IDNull;
		}
		set
		{
			_materialCategory_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MaterialBrand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MaterialBrand_ID</c> column value.</value>
	public int MaterialBrand_ID
	{
		get
		{
			if (IsMaterialBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _materialBrand_ID;
		}
		set
		{
			_materialBrand_IDNull = false;
			_materialBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MaterialBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMaterialBrand_IDNull
	{
		get
		{
			return _materialBrand_IDNull;
		}
		set
		{
			_materialBrand_IDNull = value;
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
		/// Gets or sets the <c>Warehouse_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Warehouse_ID</c> column value.</value>
	public string Warehouse_ID
	{
		get
		{
			if(IsWarehouse_IDNull)
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
		/// Gets or sets the <c>Country</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Country</c> column value.</value>
	public string Country
	{
		get
		{
			if(IsCountryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _country;
		}
		set
		{
			_countryNull = false;
			_country = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Country"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCountryNull
	{
		get
		{
			return _countryNull;
		}
		set
		{
			_countryNull = value;
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
		/// Gets or sets the <c>PackingType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PackingType</c> column value.</value>
	public string PackingType
	{
		get
		{
			if(IsPackingTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _packingType;
		}
		set
		{
			_packingTypeNull = false;
			_packingType = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PackingType"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPackingTypeNull
	{
		get
		{
			return _packingTypeNull;
		}
		set
		{
			_packingTypeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ActiveIngredient</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ActiveIngredient</c> column value.</value>
	public string ActiveIngredient
	{
		get
		{
			if(IsActiveIngredientNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _activeIngredient;
		}
		set
		{
			_activeIngredientNull = false;
			_activeIngredient = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ActiveIngredient"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActiveIngredientNull
	{
		get
		{
			return _activeIngredientNull;
		}
		set
		{
			_activeIngredientNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IsolationDay</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsolationDay</c> column value.</value>
	public int IsolationDay
	{
		get
		{
			if (IsIsolationDayNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isolationDay;
		}
		set
		{
			_isolationDayNull = false;
			_isolationDay = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsolationDay"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsolationDayNull
	{
		get
		{
			return _isolationDayNull;
		}
		set
		{
			_isolationDayNull = value;
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
		/// Gets or sets the <c>GIAI</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GIAI</c> column value.</value>
	public string GIAI
	{
		get
		{
			if(IsGIAINull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _giai;
		}
		set
		{
			_giaiNull = false;
			_giai = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GIAI"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGIAINull
	{
		get
		{
			return _giaiNull;
		}
		set
		{
			_giaiNull = value;
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
		// Material_ID
		dynStr.Append("  Material_ID=");
		if( IsMaterial_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Material_ID);
		

		// MaterialCategory_ID
		dynStr.Append("  MaterialCategory_ID=");
		if( IsMaterialCategory_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.MaterialCategory_ID);
		// MaterialBrand_ID
		dynStr.Append("  MaterialBrand_ID=");
		if( IsMaterialBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.MaterialBrand_ID);
		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Supplier_ID
		dynStr.Append("  Supplier_ID=");
		if( IsSupplier_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Supplier_ID);
		

		// Warehouse_ID
		dynStr.Append("  Warehouse_ID=");
		if( IsWarehouse_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Warehouse_ID);
		

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
		

		// Country
		dynStr.Append("  Country=");
		if( IsCountryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Country);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

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
		

		// PackingType
		dynStr.Append("  PackingType=");
		if( IsPackingTypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PackingType);
		

		// ActiveIngredient
		dynStr.Append("  ActiveIngredient=");
		if( IsActiveIngredientNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ActiveIngredient);
		

		// IsolationDay
		dynStr.Append("  IsolationDay=");
		if( IsIsolationDayNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsolationDay);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
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
		// GIAI
		dynStr.Append("  GIAI=");
		if( IsGIAINull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GIAI);
		

		return dynStr.ToString();
	}
}
}




