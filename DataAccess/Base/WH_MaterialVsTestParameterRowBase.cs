
// <fileinfo name="Base\WH_MaterialVsTestParameterRowBase.cs">
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
/// The base class for <see cref="WH_MaterialVsTestParameterRow"/> that 
/// represents a record in the <c>WH_MaterialVsTestParameter</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_MaterialVsTestParameterRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_MaterialVsTestParameterRowBase
{
	/// _wH_MaterialVsTestParameter_ID
	private int _wH_MaterialVsTestParameter_ID;
	private bool _wH_MaterialVsTestParameter_IDNull = true;
	/// _wH_Material_ID
	private int _wH_Material_ID;
	private bool _wH_Material_IDNull = true;
	/// _testParameter_ID
	private int _testParameter_ID;
	private bool _testParameter_IDNull = true;
	/// _size
	private double _size;
	private bool _sizeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_MaterialVsTestParameterRowBase"/> class.
	/// </summary>
	public WH_MaterialVsTestParameterRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_MaterialVsTestParameter_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_MaterialVsTestParameter_ID</c> column value.</value>
	public int WH_MaterialVsTestParameter_ID
	{
		get
		{
			if(IsWH_MaterialVsTestParameter_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_MaterialVsTestParameter_ID;
		}
		set
		{
			_wH_MaterialVsTestParameter_IDNull = false;
			_wH_MaterialVsTestParameter_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_MaterialVsTestParameter_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_MaterialVsTestParameter_IDNull
	{
		get
		{
			return _wH_MaterialVsTestParameter_IDNull;
		}
		set
		{
			_wH_MaterialVsTestParameter_IDNull = value;
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
		/// Gets or sets the <c>TestParameter_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TestParameter_ID</c> column value.</value>
	public int TestParameter_ID
	{
		get
		{
			if (IsTestParameter_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _testParameter_ID;
		}
		set
		{
			_testParameter_IDNull = false;
			_testParameter_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TestParameter_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTestParameter_IDNull
	{
		get
		{
			return _testParameter_IDNull;
		}
		set
		{
			_testParameter_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Size</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Size</c> column value.</value>
	public double Size
	{
		get
		{
			if (IsSizeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _size;
		}
		set
		{
			_sizeNull = false;
			_size = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Size"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSizeNull
	{
		get
		{
			return _sizeNull;
		}
		set
		{
			_sizeNull = value;
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
		// WH_MaterialVsTestParameter_ID
		dynStr.Append("  WH_MaterialVsTestParameter_ID=");
		if( IsWH_MaterialVsTestParameter_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_MaterialVsTestParameter_ID);
		

		// WH_Material_ID
		dynStr.Append("  WH_Material_ID=");
		if( IsWH_Material_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_Material_ID);
		// TestParameter_ID
		dynStr.Append("  TestParameter_ID=");
		if( IsTestParameter_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TestParameter_ID);
		// Size
		dynStr.Append("  Size=");
		if( IsSizeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Size);
		return dynStr.ToString();
	}
}
}




