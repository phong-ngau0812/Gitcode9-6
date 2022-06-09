
// <fileinfo name="Base\WH_CheckSheetRowBase.cs">
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
/// The base class for <see cref="WH_CheckSheetRow"/> that 
/// represents a record in the <c>WH_CheckSheet</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_CheckSheetRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_CheckSheetRowBase
{
	/// _wH_CheckSheet_ID
	private int _wH_CheckSheet_ID;
	private bool _wH_CheckSheet_IDNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _type
	private int _type;
	private bool _typeNull = true;
	/// _level
	private int _level;
	private bool _levelNull = true;
	/// _wH_StandardCheck_ID
	private int _wH_StandardCheck_ID;
	private bool _wH_StandardCheck_IDNull = true;
	/// _wH_DeliveryNote
	private int _wH_DeliveryNote;
	private bool _wH_DeliveryNoteNull = true;
	/// _dateCheck
	private System.DateTime _dateCheck;
	private bool _dateCheckNull = true;
	/// _location
	private string _location;
	private bool _locationNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;
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
	/// Initializes a new instance of the <see cref="WH_CheckSheetRowBase"/> class.
	/// </summary>
	public WH_CheckSheetRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_CheckSheet_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_CheckSheet_ID</c> column value.</value>
	public int WH_CheckSheet_ID
	{
		get
		{
			if(IsWH_CheckSheet_IDNull)
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
		/// Gets or sets the <c>Type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Type</c> column value.</value>
	public int Type
	{
		get
		{
			if (IsTypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _type;
		}
		set
		{
			_typeNull = false;
			_type = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Type"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTypeNull
	{
		get
		{
			return _typeNull;
		}
		set
		{
			_typeNull = value;
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
		/// Gets or sets the <c>WH_StandardCheck_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_StandardCheck_ID</c> column value.</value>
	public int WH_StandardCheck_ID
	{
		get
		{
			if (IsWH_StandardCheck_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_StandardCheck_ID;
		}
		set
		{
			_wH_StandardCheck_IDNull = false;
			_wH_StandardCheck_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_StandardCheck_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_StandardCheck_IDNull
	{
		get
		{
			return _wH_StandardCheck_IDNull;
		}
		set
		{
			_wH_StandardCheck_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WH_DeliveryNote</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_DeliveryNote</c> column value.</value>
	public int WH_DeliveryNote
	{
		get
		{
			if (IsWH_DeliveryNoteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_DeliveryNote;
		}
		set
		{
			_wH_DeliveryNoteNull = false;
			_wH_DeliveryNote = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_DeliveryNote"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_DeliveryNoteNull
	{
		get
		{
			return _wH_DeliveryNoteNull;
		}
		set
		{
			_wH_DeliveryNoteNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DateCheck</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DateCheck</c> column value.</value>
	public System.DateTime DateCheck
	{
		get
		{
			if (IsDateCheckNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _dateCheck;
		}
		set
		{
			_dateCheckNull = false;
			_dateCheck = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DateCheck"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDateCheckNull
	{
		get
		{
			return _dateCheckNull;
		}
		set
		{
			_dateCheckNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location</c> column value.</value>
	public string Location
	{
		get
		{
			if(IsLocationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location;
		}
		set
		{
			_locationNull = false;
			_location = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationNull
	{
		get
		{
			return _locationNull;
		}
		set
		{
			_locationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
	public int Status
	{
		get
		{
			if (IsStatusNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _status;
		}
		set
		{
			_statusNull = false;
			_status = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Status"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStatusNull
	{
		get
		{
			return _statusNull;
		}
		set
		{
			_statusNull = value;
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
		// WH_CheckSheet_ID
		dynStr.Append("  WH_CheckSheet_ID=");
		if( IsWH_CheckSheet_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_CheckSheet_ID);
		

		// Code
		dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// Type
		dynStr.Append("  Type=");
		if( IsTypeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Type);
		// Level
		dynStr.Append("  Level=");
		if( IsLevelNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Level);
		// WH_StandardCheck_ID
		dynStr.Append("  WH_StandardCheck_ID=");
		if( IsWH_StandardCheck_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_StandardCheck_ID);
		// WH_DeliveryNote
		dynStr.Append("  WH_DeliveryNote=");
		if( IsWH_DeliveryNoteNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_DeliveryNote);
		// DateCheck
		dynStr.Append("  DateCheck=");
		if( IsDateCheckNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DateCheck);
		// Location
		dynStr.Append("  Location=");
		if( IsLocationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Location);
		

		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
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




