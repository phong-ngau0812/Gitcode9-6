
// <fileinfo name="Base\WarehouseRackRowBase.cs">
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
/// The base class for <see cref="WarehouseRackRow"/> that 
/// represents a record in the <c>WarehouseRack</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WarehouseRackRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WarehouseRackRowBase
{
	/// _rack_ID
	private int _rack_ID;
	private bool _rack_IDNull = true;
	/// _wareHouse_ID
	private int _wareHouse_ID;
	private bool _wareHouse_IDNull = true;
	/// _rackName
	private string _rackName;
	private bool _rackNameNull = true;
	/// _lineName
	private string _lineName;
	private bool _lineNameNull = true;
	/// _code
	private string _code;
	private bool _codeNull = true;
	/// _gln
	private string _gln;
	private bool _glnNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _type
	private int _type;
	private bool _typeNull = true;
	/// _priority
	private int _priority;
	private bool _priorityNull = true;
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
	/// _note
	private string _note;
	private bool _noteNull = true;

		// Instance fields

		/// <summary>
		/// Initializes a new instance of the <see cref="WarehouseRackRowBase"/> class.
		/// </summary>
		public WarehouseRackRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Rack_ID</c> column value.
		/// </summary>
		/// <value>The <c>Rack_ID</c> column value.</value>
	public int Rack_ID
	{
		get
		{
			if(IsRack_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _rack_ID;
		}
		set
		{
			_rack_IDNull = false;
			_rack_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Rack_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRack_IDNull
	{
		get
		{
			return _rack_IDNull;
		}
		set
		{
			_rack_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WareHouse_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WareHouse_ID</c> column value.</value>
	public int WareHouse_ID
	{
		get
		{
			if (IsWareHouse_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wareHouse_ID;
		}
		set
		{
			_wareHouse_IDNull = false;
			_wareHouse_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WareHouse_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWareHouse_IDNull
	{
		get
		{
			return _wareHouse_IDNull;
		}
		set
		{
			_wareHouse_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>RackName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>RackName</c> column value.</value>
	public string RackName
	{
		get
		{
			if(IsRackNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _rackName;
		}
		set
		{
			_rackNameNull = false;
			_rackName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="RackName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRackNameNull
	{
		get
		{
			return _rackNameNull;
		}
		set
		{
			_rackNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LineName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LineName</c> column value.</value>
	public string LineName
	{
		get
		{
			if(IsLineNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lineName;
		}
		set
		{
			_lineNameNull = false;
			_lineName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LineName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLineNameNull
	{
		get
		{
			return _lineNameNull;
		}
		set
		{
			_lineNameNull = value;
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
		/// Gets or sets the <c>GLN</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GLN</c> column value.</value>
	public string GLN
	{
		get
		{
			if(IsGLNNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _gln;
		}
		set
		{
			_glnNull = false;
			_gln = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="GLN"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsGLNNull
	{
		get
		{
			return _glnNull;
		}
		set
		{
			_glnNull = value;
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
		/// Gets or sets the <c>priority</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>priority</c> column value.</value>
	public int Priority
	{
		get
		{
			if (IsPriorityNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _priority;
		}
		set
		{
			_priorityNull = false;
			_priority = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Priority"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPriorityNull
	{
		get
		{
			return _priorityNull;
		}
		set
		{
			_priorityNull = value;
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
		public string Note
		{
			get
			{
				if (IsNoteNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _note;
			}
			set
			{
				_noteNull = false;
				_note = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Note"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsNoteNull
		{
			get
			{
				return _noteNull;
			}
			set
			{
				_noteNull = value;
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
		// Rack_ID
		dynStr.Append("  Rack_ID=");
		if( IsRack_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Rack_ID);
		

		// WareHouse_ID
		dynStr.Append("  WareHouse_ID=");
		if( IsWareHouse_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WareHouse_ID);
		// RackName
		dynStr.Append("  RackName=");
		if( IsRackNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.RackName);
		

		// LineName
		dynStr.Append("  LineName=");
		if( IsLineNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.LineName);

			
			// Code
			dynStr.Append("  Code=");
		if( IsCodeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Code);
		

		// GLN
		dynStr.Append("  GLN=");
		if( IsGLNNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.GLN);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Type
		dynStr.Append("  Type=");
		if( IsTypeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Type);
		// Priority
		dynStr.Append("  Priority=");
		if( IsPriorityNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Priority);
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
			// Note
			dynStr.Append("  Note=");
			if (IsNoteNull)
			{
				dynStr.Append("<NULL>");
			}
			else
				dynStr.Append(this.Note);

			return dynStr.ToString();
	}
}
}




