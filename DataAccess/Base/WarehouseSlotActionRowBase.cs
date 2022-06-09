
// <fileinfo name="Base\WarehouseSlotActionRowBase.cs">
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
/// The base class for <see cref="WarehouseSlotActionRow"/> that 
/// represents a record in the <c>WarehouseSlotAction</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WarehouseSlotActionRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseSlotActionRowBase
{
	/// _warehouseSlotAction_ID
	private int _warehouseSlotAction_ID;
	private bool _warehouseSlotAction_IDNull = true;
	/// _actionType
	private int _actionType;
	private bool _actionTypeNull = true;
	/// _slot_ID
	private int _slot_ID;
	private bool _slot_IDNull = true;
	/// _slotInfor_ID
	private int _slotInfor_ID;
	private bool _slotInfor_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _serial
	private string _serial;
	private bool _serialNull = true;
	/// _amount
	private int _amount;
	private bool _amountNull = true;
	/// _pallet_ID
	private string _pallet_ID;
	private bool _pallet_IDNull = true;
	/// _importNoteCode
	private string _importNoteCode;
	private bool _importNoteCodeNull = true;
	/// _productPackage_ID
	private string _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _createdDate
	private System.DateTime _createdDate;
	private bool _createdDateNull = true;
	/// _editDate
	private System.DateTime _editDate;
	private bool _editDateNull = true;
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
	/// Initializes a new instance of the <see cref="WarehouseSlotActionRowBase"/> class.
	/// </summary>
	public WarehouseSlotActionRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WarehouseSlotAction_ID</c> column value.
		/// </summary>
		/// <value>The <c>WarehouseSlotAction_ID</c> column value.</value>
	public int WarehouseSlotAction_ID
	{
		get
		{
			if(IsWarehouseSlotAction_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouseSlotAction_ID;
		}
		set
		{
			_warehouseSlotAction_IDNull = false;
			_warehouseSlotAction_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WarehouseSlotAction_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouseSlotAction_IDNull
	{
		get
		{
			return _warehouseSlotAction_IDNull;
		}
		set
		{
			_warehouseSlotAction_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ActionType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ActionType</c> column value.</value>
	public int ActionType
	{
		get
		{
			if (IsActionTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _actionType;
		}
		set
		{
			_actionTypeNull = false;
			_actionType = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ActionType"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsActionTypeNull
	{
		get
		{
			return _actionTypeNull;
		}
		set
		{
			_actionTypeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Slot_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Slot_ID</c> column value.</value>
	public int Slot_ID
	{
		get
		{
			if (IsSlot_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _slot_ID;
		}
		set
		{
			_slot_IDNull = false;
			_slot_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Slot_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSlot_IDNull
	{
		get
		{
			return _slot_IDNull;
		}
		set
		{
			_slot_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SlotInfor_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SlotInfor_ID</c> column value.</value>
	public int SlotInfor_ID
	{
		get
		{
			if (IsSlotInfor_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _slotInfor_ID;
		}
		set
		{
			_slotInfor_IDNull = false;
			_slotInfor_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SlotInfor_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSlotInfor_IDNull
	{
		get
		{
			return _slotInfor_IDNull;
		}
		set
		{
			_slotInfor_IDNull = value;
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
		/// Gets or sets the <c>Serial</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Serial</c> column value.</value>
	public string Serial
	{
		get
		{
			if(IsSerialNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _serial;
		}
		set
		{
			_serialNull = false;
			_serial = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Serial"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSerialNull
	{
		get
		{
			return _serialNull;
		}
		set
		{
			_serialNull = value;
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
		/// Gets or sets the <c>Pallet_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Pallet_ID</c> column value.</value>
	public string Pallet_ID
	{
		get
		{
			if(IsPallet_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
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
		/// Gets or sets the <c>ImportNoteCode</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ImportNoteCode</c> column value.</value>
	public string ImportNoteCode
	{
		get
		{
			if(IsImportNoteCodeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _importNoteCode;
		}
		set
		{
			_importNoteCodeNull = false;
			_importNoteCode = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ImportNoteCode"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImportNoteCodeNull
	{
		get
		{
			return _importNoteCodeNull;
		}
		set
		{
			_importNoteCodeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackage_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackage_ID</c> column value.</value>
	public string ProductPackage_ID
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
		/// Gets or sets the <c>CreatedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CreatedDate</c> column value.</value>
	public System.DateTime CreatedDate
	{
		get
		{
			if (IsCreatedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
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
		/// Gets or sets the <c>EditDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EditDate</c> column value.</value>
	public System.DateTime EditDate
	{
		get
		{
			if (IsEditDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _editDate;
		}
		set
		{
			_editDateNull = false;
			_editDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EditDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEditDateNull
	{
		get
		{
			return _editDateNull;
		}
		set
		{
			_editDateNull = value;
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
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
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
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
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
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
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
		// WarehouseSlotAction_ID
		dynStr.Append("  WarehouseSlotAction_ID=");
		if( IsWarehouseSlotAction_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WarehouseSlotAction_ID);
		

		// ActionType
		dynStr.Append("  ActionType=");
		if( IsActionTypeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ActionType);
		// Slot_ID
		dynStr.Append("  Slot_ID=");
		if( IsSlot_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Slot_ID);
		// SlotInfor_ID
		dynStr.Append("  SlotInfor_ID=");
		if( IsSlotInfor_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SlotInfor_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// Serial
		dynStr.Append("  Serial=");
		if( IsSerialNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Serial);
		

		// Amount
		dynStr.Append("  Amount=");
		if( IsAmountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Amount);
		// Pallet_ID
		dynStr.Append("  Pallet_ID=");
		if( IsPallet_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Pallet_ID);
		

		// ImportNoteCode
		dynStr.Append("  ImportNoteCode=");
		if( IsImportNoteCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ImportNoteCode);
		

		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackage_ID);
		

		// CreatedDate
		dynStr.Append("  CreatedDate=");
		if( IsCreatedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.CreatedDate);
		// EditDate
		dynStr.Append("  EditDate=");
		if( IsEditDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.EditDate);
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




