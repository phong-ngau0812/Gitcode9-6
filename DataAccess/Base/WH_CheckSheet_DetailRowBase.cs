
// <fileinfo name="Base\WH_CheckSheet_DetailRowBase.cs">
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
/// The base class for <see cref="WH_CheckSheet_DetailRow"/> that 
/// represents a record in the <c>WH_CheckSheet_Detail</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="WH_CheckSheet_DetailRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class WH_CheckSheet_DetailRowBase
{
	/// _wH_CheckSheet_Detail_ID
	private int _wH_CheckSheet_Detail_ID;
	private bool _wH_CheckSheet_Detail_IDNull = true;
	/// _wH_CheckSheetVsMaterial_ID
	private int _wH_CheckSheetVsMaterial_ID;
	private bool _wH_CheckSheetVsMaterial_IDNull = true;
	/// _length
	private double _length;
	private bool _lengthNull = true;
	/// _height
	private double _height;
	private bool _heightNull = true;
	/// _width
	private double _width;
	private bool _widthNull = true;
	/// _status
	private bool _status;
	private bool _statusNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
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
	/// _content
	private string _content;
	private bool _contentNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="WH_CheckSheet_DetailRowBase"/> class.
	/// </summary>
	public WH_CheckSheet_DetailRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>WH_CheckSheet_Detail_ID</c> column value.
		/// </summary>
		/// <value>The <c>WH_CheckSheet_Detail_ID</c> column value.</value>
	public int WH_CheckSheet_Detail_ID
	{
		get
		{
			if(IsWH_CheckSheet_Detail_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _wH_CheckSheet_Detail_ID;
		}
		set
		{
			_wH_CheckSheet_Detail_IDNull = false;
			_wH_CheckSheet_Detail_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WH_CheckSheet_Detail_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWH_CheckSheet_Detail_IDNull
	{
		get
		{
			return _wH_CheckSheet_Detail_IDNull;
		}
		set
		{
			_wH_CheckSheet_Detail_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WH_CheckSheetVsMaterial_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WH_CheckSheetVsMaterial_ID</c> column value.</value>
	public int WH_CheckSheetVsMaterial_ID
	{
		get
		{
			if (IsWH_CheckSheetVsMaterial_IDNull)
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
		/// Gets or sets the <c>Length</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Length</c> column value.</value>
	public double Length
	{
		get
		{
			if (IsLengthNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _length;
		}
		set
		{
			_lengthNull = false;
			_length = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Length"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLengthNull
	{
		get
		{
			return _lengthNull;
		}
		set
		{
			_lengthNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Height</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Height</c> column value.</value>
	public double Height
	{
		get
		{
			if (IsHeightNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _height;
		}
		set
		{
			_heightNull = false;
			_height = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Height"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHeightNull
	{
		get
		{
			return _heightNull;
		}
		set
		{
			_heightNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Width</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Width</c> column value.</value>
	public double Width
	{
		get
		{
			if (IsWidthNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _width;
		}
		set
		{
			_widthNull = false;
			_width = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Width"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWidthNull
	{
		get
		{
			return _widthNull;
		}
		set
		{
			_widthNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
	public bool Status
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
		/// Gets or sets the <c>Content</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Content</c> column value.</value>
	public string Content
	{
		get
		{
			if(IsContentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _content;
		}
		set
		{
			_contentNull = false;
			_content = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Content"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContentNull
	{
		get
		{
			return _contentNull;
		}
		set
		{
			_contentNull = value;
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
		// WH_CheckSheet_Detail_ID
		dynStr.Append("  WH_CheckSheet_Detail_ID=");
		if( IsWH_CheckSheet_Detail_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WH_CheckSheet_Detail_ID);
		

		// WH_CheckSheetVsMaterial_ID
		dynStr.Append("  WH_CheckSheetVsMaterial_ID=");
		if( IsWH_CheckSheetVsMaterial_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.WH_CheckSheetVsMaterial_ID);
		// Length
		dynStr.Append("  Length=");
		if( IsLengthNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Length);
		// Height
		dynStr.Append("  Height=");
		if( IsHeightNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Height);
		// Width
		dynStr.Append("  Width=");
		if( IsWidthNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Width);
		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

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
		// Content
		dynStr.Append("  Content=");
		if( IsContentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Content);
		

		return dynStr.ToString();
	}
}
}




