
// <fileinfo name="Base\WH_CheckSheetVsMaterialRowBase.cs">
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
/// The base class for <see cref="WH_CheckSheetVsMaterialRow"/> that 
/// represents a record in the <c>WH_CheckSheetVsMaterial</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_CheckSheetVsMaterialRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_CheckSheetVsMaterialRowBase
{
	/// _wH_CheckSheetVsMaterial_ID
	private int _wH_CheckSheetVsMaterial_ID;
	private bool _wH_CheckSheetVsMaterial_IDNull = true;
	/// _wH_CheckSheet_ID
	private int _wH_CheckSheet_ID;
	private bool _wH_CheckSheet_IDNull = true;
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _amount
	private int _amount;
	private bool _amountNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_CheckSheetVsMaterialRowBase"/> class.
	/// </summary>
	public WH_CheckSheetVsMaterialRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_CheckSheetVsMaterial_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_CheckSheetVsMaterial_ID</c> column value.</value>
	public int WH_CheckSheetVsMaterial_ID
	{
		get
		{
			if(IsWH_CheckSheetVsMaterial_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_CheckSheetVsMaterial_ID;
		}
		set
		{
			_wH_CheckSheetVsMaterial_IDNull = false;
			_wH_CheckSheetVsMaterial_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_CheckSheetVsMaterial_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_CheckSheetVsMaterial_IDNull
	{
		get
		{
			return _wH_CheckSheetVsMaterial_IDNull;
		}
		set
		{
			_wH_CheckSheetVsMaterial_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WH_CheckSheet_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_CheckSheet_ID</c> column value.</value>
	public int WH_CheckSheet_ID
	{
		get
		{
			if (IsWH_CheckSheet_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_CheckSheet_ID;
		}
		set
		{
			_wH_CheckSheet_IDNull = false;
			_wH_CheckSheet_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_CheckSheet_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_CheckSheet_IDNull
	{
		get
		{
			return _wH_CheckSheet_IDNull;
		}
		set
		{
			_wH_CheckSheet_IDNull = value;
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
		// WH_CheckSheetVsMaterial_ID
		dynStr.Append("  WH_CheckSheetVsMaterial_ID=");
		if( IsWH_CheckSheetVsMaterial_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_CheckSheetVsMaterial_ID);
		

		// WH_CheckSheet_ID
		dynStr.Append("  WH_CheckSheet_ID=");
		if( IsWH_CheckSheet_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_CheckSheet_ID);
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




