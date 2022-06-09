
// <fileinfo name="Base\WarehouseTempProRowBase.cs">
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
/// The base class for <see cref="WarehouseTempProRow"/> that 
/// represents a record in the <c>WarehouseTempPro</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WarehouseTempProRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseTempProRowBase
{
	/// _warehouseTempPro_ID
	private int _warehouseTempPro_ID;
	private bool _warehouseTempPro_IDNull = true;
	/// _productName
	private string _productName;
	private bool _productNameNull = true;
	/// _productSkuEffect
	private string _productSkuEffect;
	private bool _productSkuEffectNull = true;
	/// _productSku
	private string _productSku;
	private bool _productSkuNull = true;
	/// _productNumber
	private int _productNumber;
	private bool _productNumberNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _serialNumberStart
	private string _serialNumberStart;
	private bool _serialNumberStartNull = true;
	/// _serialNumberEnd
	private string _serialNumberEnd;
	private bool _serialNumberEndNull = true;
	/// _qRCode
	private string _qRCode;
	private bool _qRCodeNull = true;
	/// _qRCodePublic
	private string _qRCodePublic;
	private bool _qRCodePublicNull = true;
	/// _color
	private string _color;
	private bool _colorNull = true;
	/// _productImportType
	private string _productImportType;
	private bool _productImportTypeNull = true;
	/// _unit
	private string _unit;
	private bool _unitNull = true;
	/// _weight
	private string _weight;
	private bool _weightNull = true;
	/// _positionID
	private int _positionID;
	private bool _positionIDNull = true;
	/// _supplier
	private string _supplier;
	private bool _supplierNull = true;
	/// _madeIn
	private string _madeIn;
	private bool _madeInNull = true;
	/// _pallet_ID
	private string _pallet_ID;
	private bool _pallet_IDNull = true;
	/// _createdDate
	private System.DateTime _createdDate;
	private bool _createdDateNull = true;
	/// _other1
	private string _other1;
	private bool _other1Null = true;
	/// _other2
	private string _other2;
	private bool _other2Null = true;
	/// _other3
	private string _other3;
	private bool _other3Null = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WarehouseTempProRowBase"/> class.
	/// </summary>
	public WarehouseTempProRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseTempPro_ID</c> column value.
		/// </summary>
		/// <value>The <c>WarehouseTempPro_ID</c> column value.</value>
	public int WarehouseTempPro_ID
	{
		get
		{
				if (IsWarehouseTempPro_IDNull)
					_warehouseTempPro_ID = 0;
			return _warehouseTempPro_ID;
		}
		set
		{
			_warehouseTempPro_IDNull = false;
			_warehouseTempPro_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseTempPro_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseTempPro_IDNull
	{
		get
		{
			return _warehouseTempPro_IDNull;
		}
		set
		{
			_warehouseTempPro_IDNull = value;
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
				if (IsProductNameNull)
					return null;
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
		/// Gets or sets the <c>ProductSkuEffect</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductSkuEffect</c> column value.</value>
	public string ProductSkuEffect
	{
		get
		{
			if(IsProductSkuEffectNull)
				return null;
			return _productSkuEffect;
		}
		set
		{
			_productSkuEffectNull = false;
			_productSkuEffect = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductSkuEffect"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductSkuEffectNull
	{
		get
		{
			return _productSkuEffectNull;
		}
		set
		{
			_productSkuEffectNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductSku</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductSku</c> column value.</value>
	public string ProductSku
	{
		get
		{
			if(IsProductSkuNull)
				return null;
			return _productSku;
		}
		set
		{
			_productSkuNull = false;
			_productSku = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductSku"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductSkuNull
	{
		get
		{
			return _productSkuNull;
		}
		set
		{
			_productSkuNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductNumber</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductNumber</c> column value.</value>
	public int ProductNumber
	{
		get
		{
			if (IsProductNumberNull)
				return 0;
			return _productNumber;
		}
		set
		{
			_productNumberNull = false;
			_productNumber = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductNumber"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductNumberNull
	{
		get
		{
			return _productNumberNull;
		}
		set
		{
			_productNumberNull = value;
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
				return 0;
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
		/// Gets or sets the <c>SerialNumberStart</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberStart</c> column value.</value>
	public string SerialNumberStart
	{
		get
		{
			if(IsSerialNumberStartNull)
				return null;
			return _serialNumberStart;
		}
		set
		{
			_serialNumberStartNull = false;
			_serialNumberStart = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberStart"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberStartNull
	{
		get
		{
			return _serialNumberStartNull;
		}
		set
		{
			_serialNumberStartNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SerialNumberEnd</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SerialNumberEnd</c> column value.</value>
	public string SerialNumberEnd
	{
		get
		{
			if(IsSerialNumberEndNull)
				return null;
			return _serialNumberEnd;
		}
		set
		{
			_serialNumberEndNull = false;
			_serialNumberEnd = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SerialNumberEnd"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNumberEndNull
	{
		get
		{
			return _serialNumberEndNull;
		}
		set
		{
			_serialNumberEndNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCode</c> column value.</value>
	public string QRCode
	{
		get
		{
			if(IsQRCodeNull)
				return null;
			return _qRCode;
		}
		set
		{
			_qRCodeNull = false;
			_qRCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodeNull
	{
		get
		{
			return _qRCodeNull;
		}
		set
		{
			_qRCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>QRCodePublic</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>QRCodePublic</c> column value.</value>
	public string QRCodePublic
	{
		get
		{
			if(IsQRCodePublicNull)
				return null;
			return _qRCodePublic;
		}
		set
		{
			_qRCodePublicNull = false;
			_qRCodePublic = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QRCodePublic"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQRCodePublicNull
	{
		get
		{
			return _qRCodePublicNull;
		}
		set
		{
			_qRCodePublicNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Color</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Color</c> column value.</value>
	public string Color
	{
		get
		{
			if(IsColorNull)
				return null;
			return _color;
		}
		set
		{
			_colorNull = false;
			_color = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Color"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsColorNull
	{
		get
		{
			return _colorNull;
		}
		set
		{
			_colorNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductImportType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductImportType</c> column value.</value>
	public string ProductImportType
	{
		get
		{
			if(IsProductImportTypeNull)
				return null;
			return _productImportType;
		}
		set
		{
			_productImportTypeNull = false;
			_productImportType = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductImportType"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductImportTypeNull
	{
		get
		{
			return _productImportTypeNull;
		}
		set
		{
			_productImportTypeNull = value;
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
				return null;
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
		/// Gets or sets the <c>weight</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>weight</c> column value.</value>
	public string Weight
	{
		get
		{
			if(IsWeightNull)
				return null;
			return _weight;
		}
		set
		{
			_weightNull = false;
			_weight = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Weight"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWeightNull
	{
		get
		{
			return _weightNull;
		}
		set
		{
			_weightNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PositionID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PositionID</c> column value.</value>
	public int PositionID
	{
		get
		{
			if (IsPositionIDNull)
				return 0;
			return _positionID;
		}
		set
		{
			_positionIDNull = false;
			_positionID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PositionID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPositionIDNull
	{
		get
		{
			return _positionIDNull;
		}
		set
		{
			_positionIDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>supplier</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>supplier</c> column value.</value>
	public string Supplier
	{
		get
		{
			if(IsSupplierNull)
				return null;
			return _supplier;
		}
		set
		{
			_supplierNull = false;
			_supplier = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Supplier"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSupplierNull
	{
		get
		{
			return _supplierNull;
		}
		set
		{
			_supplierNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>MadeIn</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MadeIn</c> column value.</value>
	public string MadeIn
	{
		get
		{
			if(IsMadeInNull)
				return null;
			return _madeIn;
		}
		set
		{
			_madeInNull = false;
			_madeIn = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="MadeIn"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMadeInNull
	{
		get
		{
			return _madeInNull;
		}
		set
		{
			_madeInNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Pallet_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Pallet_ID</c> column value.</value>
	public string Pallet_ID
	{
		get
		{
			if(IsPallet_IDNull)
				return null;
			return _pallet_ID;
		}
		set
		{
			_pallet_IDNull = false;
			_pallet_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Pallet_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPallet_IDNull
	{
		get
		{
			return _pallet_IDNull;
		}
		set
		{
			_pallet_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CreatedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreatedDate</c> column value.</value>
	public System.DateTime CreatedDate
	{
		get
		{
			if (IsCreatedDateNull)
				return DateTime.Now;
			return _createdDate;
		}
		set
		{
			_createdDateNull = false;
			_createdDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CreatedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCreatedDateNull
	{
		get
		{
			return _createdDateNull;
		}
		set
		{
			_createdDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Other1</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Other1</c> column value.</value>
	public string Other1
	{
		get
		{
			if(IsOther1Null)
				return null;
			return _other1;
		}
		set
		{
			_other1Null = false;
			_other1 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Other1"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOther1Null
	{
		get
		{
			return _other1Null;
		}
		set
		{
			_other1Null = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Other2</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Other2</c> column value.</value>
	public string Other2
	{
		get
		{
			if(IsOther2Null)
				return null;
			return _other2;
		}
		set
		{
			_other2Null = false;
			_other2 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Other2"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOther2Null
	{
		get
		{
			return _other2Null;
		}
		set
		{
			_other2Null = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Other3</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Other3</c> column value.</value>
	public string Other3
	{
		get
		{
			if(IsOther3Null)
				return null;
			return _other3;
		}
		set
		{
			_other3Null = false;
			_other3 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Other3"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsOther3Null
	{
		get
		{
			return _other3Null;
		}
		set
		{
			_other3Null = value;
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
		// WarehouseTempPro_ID
		dynStr.Append("  WarehouseTempPro_ID=");
		if( IsWarehouseTempPro_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WarehouseTempPro_ID);
		

		// ProductName
		dynStr.Append("  ProductName=");
		if( IsProductNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName);
		

		// ProductSkuEffect
		dynStr.Append("  ProductSkuEffect=");
		if( IsProductSkuEffectNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductSkuEffect);
		

		// ProductSku
		dynStr.Append("  ProductSku=");
		if( IsProductSkuNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductSku);
		

		// ProductNumber
		dynStr.Append("  ProductNumber=");
		if( IsProductNumberNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductNumber);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		// SerialNumberStart
		dynStr.Append("  SerialNumberStart=");
		if( IsSerialNumberStartNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberStart);
		

		// SerialNumberEnd
		dynStr.Append("  SerialNumberEnd=");
		if( IsSerialNumberEndNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SerialNumberEnd);
		

		// QRCode
		dynStr.Append("  QRCode=");
		if( IsQRCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCode);
		

		// QRCodePublic
		dynStr.Append("  QRCodePublic=");
		if( IsQRCodePublicNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QRCodePublic);
		

		// Color
		dynStr.Append("  Color=");
		if( IsColorNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Color);
		

		// ProductImportType
		dynStr.Append("  ProductImportType=");
		if( IsProductImportTypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductImportType);
		

		// Unit
		dynStr.Append("  Unit=");
		if( IsUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Unit);
		

		// Weight
		dynStr.Append("  Weight=");
		if( IsWeightNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Weight);
		

		// PositionID
		dynStr.Append("  PositionID=");
		if( IsPositionIDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.PositionID);
		// Supplier
		dynStr.Append("  Supplier=");
		if( IsSupplierNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Supplier);
		

		// MadeIn
		dynStr.Append("  MadeIn=");
		if( IsMadeInNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.MadeIn);
		

		// Pallet_ID
		dynStr.Append("  Pallet_ID=");
		if( IsPallet_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Pallet_ID);
		

		// CreatedDate
		dynStr.Append("  CreatedDate=");
		if( IsCreatedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreatedDate);
		// Other1
		dynStr.Append("  Other1=");
		if( IsOther1Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Other1);
		

		// Other2
		dynStr.Append("  Other2=");
		if( IsOther2Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Other2);
		

		// Other3
		dynStr.Append("  Other3=");
		if( IsOther3Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Other3);
		

		return dynStr.ToString();
	}
}
}




