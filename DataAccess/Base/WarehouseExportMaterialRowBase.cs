
// <fileinfo name="Base\WarehouseExportMaterialRowBase.cs">
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
/// The base class for <see cref="WarehouseExportMaterialRow"/> that 
/// represents a record in the <c>WarehouseExportMaterial</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WarehouseExportMaterialRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseExportMaterialRowBase
{
	/// _warehouseExportMaterial_ID
	private int _warehouseExportMaterial_ID;
	private bool _warehouseExportMaterial_IDNull = true;
	/// _warehouseExport_ID
	private int _warehouseExport_ID;
	private bool _warehouseExport_IDNull = true;
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _amount
	private int _amount;
	private bool _amountNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WarehouseExportMaterialRowBase"/> class.
	/// </summary>
	public WarehouseExportMaterialRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseExportMaterial_ID</c> column value.
		/// </summary>
		/// <value>The <c>WarehouseExportMaterial_ID</c> column value.</value>
	public int WarehouseExportMaterial_ID
	{
		get
		{
			if(IsWarehouseExportMaterial_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouseExportMaterial_ID;
		}
		set
		{
			_warehouseExportMaterial_IDNull = false;
			_warehouseExportMaterial_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseExportMaterial_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseExportMaterial_IDNull
	{
		get
		{
			return _warehouseExportMaterial_IDNull;
		}
		set
		{
			_warehouseExportMaterial_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseExport_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WarehouseExport_ID</c> column value.</value>
	public int WarehouseExport_ID
	{
		get
		{
			if (IsWarehouseExport_IDNull)
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
		/// Gets or sets the <c>Amount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Amount</c> column value.</value>
	public int Amount
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// WarehouseExportMaterial_ID
		dynStr.Append("  WarehouseExportMaterial_ID=");
		if( IsWarehouseExportMaterial_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WarehouseExportMaterial_ID);
		

		// WarehouseExport_ID
		dynStr.Append("  WarehouseExport_ID=");
		if( IsWarehouseExport_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WarehouseExport_ID);
		// Material_ID
		dynStr.Append("  Material_ID=");
		if( IsMaterial_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Material_ID);
		// Amount
		dynStr.Append("  Amount=");
		if( IsAmountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Amount);
		return dynStr.ToString();
	}
}
}




