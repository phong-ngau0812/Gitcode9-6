
// <fileinfo name="Base\WH_DeliveryNoteVsMaterialRowBase.cs">
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
/// The base class for <see cref="WH_DeliveryNoteVsMaterialRow"/> that 
/// represents a record in the <c>WH_DeliveryNoteVsMaterial</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_DeliveryNoteVsMaterialRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_DeliveryNoteVsMaterialRowBase
{
	/// _wH_DeliveryNoteVsMaterial_ID
	private int _wH_DeliveryNoteVsMaterial_ID;
	private bool _wH_DeliveryNoteVsMaterial_IDNull = true;
	/// _wH_DeliveryNote_ID
	private int _wH_DeliveryNote_ID;
	private bool _wH_DeliveryNote_IDNull = true;
	/// _wH_Material_ID
	private int _wH_Material_ID;
	private bool _wH_Material_IDNull = true;
	/// _amount
	private int _amount;
	private bool _amountNull = true;
	/// _manufacturingDate
	private System.DateTime _manufacturingDate;
	private bool _manufacturingDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_DeliveryNoteVsMaterialRowBase"/> class.
	/// </summary>
	public WH_DeliveryNoteVsMaterialRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_DeliveryNoteVsMaterial_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_DeliveryNoteVsMaterial_ID</c> column value.</value>
	public int WH_DeliveryNoteVsMaterial_ID
	{
		get
		{
			if(IsWH_DeliveryNoteVsMaterial_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_DeliveryNoteVsMaterial_ID;
		}
		set
		{
			_wH_DeliveryNoteVsMaterial_IDNull = false;
			_wH_DeliveryNoteVsMaterial_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_DeliveryNoteVsMaterial_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_DeliveryNoteVsMaterial_IDNull
	{
		get
		{
			return _wH_DeliveryNoteVsMaterial_IDNull;
		}
		set
		{
			_wH_DeliveryNoteVsMaterial_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WH_DeliveryNote_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_DeliveryNote_ID</c> column value.</value>
	public int WH_DeliveryNote_ID
	{
		get
		{
			if (IsWH_DeliveryNote_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_DeliveryNote_ID;
		}
		set
		{
			_wH_DeliveryNote_IDNull = false;
			_wH_DeliveryNote_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_DeliveryNote_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_DeliveryNote_IDNull
	{
		get
		{
			return _wH_DeliveryNote_IDNull;
		}
		set
		{
			_wH_DeliveryNote_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WH_Material_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_Material_ID</c> column value.</value>
	public int WH_Material_ID
	{
		get
		{
			if (IsWH_Material_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_Material_ID;
		}
		set
		{
			_wH_Material_IDNull = false;
			_wH_Material_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_Material_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_Material_IDNull
	{
		get
		{
			return _wH_Material_IDNull;
		}
		set
		{
			_wH_Material_IDNull = value;
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
		/// Gets or sets the <c>ManufacturingDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ManufacturingDate</c> column value.</value>
	public System.DateTime ManufacturingDate
	{
		get
		{
			if (IsManufacturingDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _manufacturingDate;
		}
		set
		{
			_manufacturingDateNull = false;
			_manufacturingDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ManufacturingDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsManufacturingDateNull
	{
		get
		{
			return _manufacturingDateNull;
		}
		set
		{
			_manufacturingDateNull = value;
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
		// WH_DeliveryNoteVsMaterial_ID
		dynStr.Append("  WH_DeliveryNoteVsMaterial_ID=");
		if( IsWH_DeliveryNoteVsMaterial_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_DeliveryNoteVsMaterial_ID);
		

		// WH_DeliveryNote_ID
		dynStr.Append("  WH_DeliveryNote_ID=");
		if( IsWH_DeliveryNote_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_DeliveryNote_ID);
		// WH_Material_ID
		dynStr.Append("  WH_Material_ID=");
		if( IsWH_Material_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_Material_ID);
		// Amount
		dynStr.Append("  Amount=");
		if( IsAmountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Amount);
		// ManufacturingDate
		dynStr.Append("  ManufacturingDate=");
		if( IsManufacturingDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ManufacturingDate);
		return dynStr.ToString();
	}
}
}




