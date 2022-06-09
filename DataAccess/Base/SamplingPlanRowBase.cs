
// <fileinfo name="Base\SamplingPlanRowBase.cs">
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
/// The base class for <see cref="SamplingPlanRow"/> that 
/// represents a record in the <c>SamplingPlan</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="SamplingPlanRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class SamplingPlanRowBase
{
	/// _samplingPlan_ID
	private int _samplingPlan_ID;
	private bool _samplingPlan_IDNull = true;
	/// _level
	private int _level;
	private bool _levelNull = true;
	/// _amountFrom
	private int _amountFrom;
	private bool _amountFromNull = true;
	/// _amountTo
	private int _amountTo;
	private bool _amountToNull = true;
	/// _amountSamplingGet
	private int _amountSamplingGet;
	private bool _amountSamplingGetNull = true;
	/// _amountSamplingError
	private int _amountSamplingError;
	private bool _amountSamplingErrorNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="SamplingPlanRowBase"/> class.
	/// </summary>
	public SamplingPlanRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>SamplingPlan_ID</c> column value.
		/// </summary>
		/// <value>The <c>SamplingPlan_ID</c> column value.</value>
	public int SamplingPlan_ID
	{
		get
		{
			if(IsSamplingPlan_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _samplingPlan_ID;
		}
		set
		{
			_samplingPlan_IDNull = false;
			_samplingPlan_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SamplingPlan_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSamplingPlan_IDNull
	{
		get
		{
			return _samplingPlan_IDNull;
		}
		set
		{
			_samplingPlan_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Level</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Level</c> column value.</value>
	public int Level
	{
		get
		{
			if (IsLevelNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _level;
		}
		set
		{
			_levelNull = false;
			_level = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Level"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLevelNull
	{
		get
		{
			return _levelNull;
		}
		set
		{
			_levelNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AmountFrom</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountFrom</c> column value.</value>
	public int AmountFrom
	{
		get
		{
			if (IsAmountFromNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amountFrom;
		}
		set
		{
			_amountFromNull = false;
			_amountFrom = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AmountFrom"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountFromNull
	{
		get
		{
			return _amountFromNull;
		}
		set
		{
			_amountFromNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AmountTo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountTo</c> column value.</value>
	public int AmountTo
	{
		get
		{
			if (IsAmountToNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amountTo;
		}
		set
		{
			_amountToNull = false;
			_amountTo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AmountTo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountToNull
	{
		get
		{
			return _amountToNull;
		}
		set
		{
			_amountToNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AmountSamplingGet</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountSamplingGet</c> column value.</value>
	public int AmountSamplingGet
	{
		get
		{
			if (IsAmountSamplingGetNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amountSamplingGet;
		}
		set
		{
			_amountSamplingGetNull = false;
			_amountSamplingGet = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AmountSamplingGet"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountSamplingGetNull
	{
		get
		{
			return _amountSamplingGetNull;
		}
		set
		{
			_amountSamplingGetNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>AmountSamplingError</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountSamplingError</c> column value.</value>
	public int AmountSamplingError
	{
		get
		{
			if (IsAmountSamplingErrorNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amountSamplingError;
		}
		set
		{
			_amountSamplingErrorNull = false;
			_amountSamplingError = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AmountSamplingError"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountSamplingErrorNull
	{
		get
		{
			return _amountSamplingErrorNull;
		}
		set
		{
			_amountSamplingErrorNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// SamplingPlan_ID
		dynStr.Append("  SamplingPlan_ID=");
		if( IsSamplingPlan_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SamplingPlan_ID);
		

		// Level
		dynStr.Append("  Level=");
		if( IsLevelNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Level);
		// AmountFrom
		dynStr.Append("  AmountFrom=");
		if( IsAmountFromNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AmountFrom);
		// AmountTo
		dynStr.Append("  AmountTo=");
		if( IsAmountToNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AmountTo);
		// AmountSamplingGet
		dynStr.Append("  AmountSamplingGet=");
		if( IsAmountSamplingGetNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AmountSamplingGet);
		// AmountSamplingError
		dynStr.Append("  AmountSamplingError=");
		if( IsAmountSamplingErrorNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.AmountSamplingError);
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
		return dynStr.ToString();
	}
}
}




