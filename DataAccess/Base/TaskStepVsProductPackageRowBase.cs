
// <fileinfo name="Base\TaskStepVsProductPackageRowBase.cs">
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
/// The base class for <see cref="TaskStepVsProductPackageRow"/> that 
/// represents a record in the <c>TaskStepVsProductPackage</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TaskStepVsProductPackageRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TaskStepVsProductPackageRowBase
{
	/// _taskStepVsProductPackage_ID
	private int _taskStepVsProductPackage_ID;
	private bool _taskStepVsProductPackage_IDNull = true;
	/// _taskStep_ID
	private int _taskStep_ID;
	private bool _taskStep_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _startTime
	private System.DateTime _startTime;
	private bool _startTimeNull = true;
	/// _endTime
	private System.DateTime _endTime;
	private bool _endTimeNull = true;
	/// _note
	private string _note;
	private bool _noteNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditedBy
	private System.Guid _lastEditedBy;
	private bool _lastEditedByNull = true;
	/// _lastEditedDate
	private System.DateTime _lastEditedDate;
	private bool _lastEditedDateNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TaskStepVsProductPackageRowBase"/> class.
	/// </summary>
	public TaskStepVsProductPackageRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>TaskStepVsProductPackage_ID</c> column value.
		/// </summary>
		/// <value>The <c>TaskStepVsProductPackage_ID</c> column value.</value>
	public int TaskStepVsProductPackage_ID
	{
		get
		{
			if(IsTaskStepVsProductPackage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taskStepVsProductPackage_ID;
		}
		set
		{
			_taskStepVsProductPackage_IDNull = false;
			_taskStepVsProductPackage_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaskStepVsProductPackage_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaskStepVsProductPackage_IDNull
	{
		get
		{
			return _taskStepVsProductPackage_IDNull;
		}
		set
		{
			_taskStepVsProductPackage_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TaskStep_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TaskStep_ID</c> column value.</value>
	public int TaskStep_ID
	{
		get
		{
			if (IsTaskStep_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taskStep_ID;
		}
		set
		{
			_taskStep_IDNull = false;
			_taskStep_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaskStep_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaskStep_IDNull
	{
		get
		{
			return _taskStep_IDNull;
		}
		set
		{
			_taskStep_IDNull = value;
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
		/// Gets or sets the <c>StartTime</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StartTime</c> column value.</value>
	public System.DateTime StartTime
	{
		get
		{
			if (IsStartTimeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _startTime;
		}
		set
		{
			_startTimeNull = false;
			_startTime = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StartTime"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStartTimeNull
	{
		get
		{
			return _startTimeNull;
		}
		set
		{
			_startTimeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EndTime</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EndTime</c> column value.</value>
	public System.DateTime EndTime
	{
		get
		{
			if (IsEndTimeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _endTime;
		}
		set
		{
			_endTimeNull = false;
			_endTime = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EndTime"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEndTimeNull
	{
		get
		{
			return _endTimeNull;
		}
		set
		{
			_endTimeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Note</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Note</c> column value.</value>
	public string Note
	{
		get
		{
			if(IsNoteNull)
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
		/// Gets or sets the <c>LastEditedBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedBy</c> column value.</value>
	public System.Guid LastEditedBy
	{
		get
		{
			if (IsLastEditedByNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedBy;
		}
		set
		{
			_lastEditedByNull = false;
			_lastEditedBy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedBy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedByNull
	{
		get
		{
			return _lastEditedByNull;
		}
		set
		{
			_lastEditedByNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>LastEditedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastEditedDate</c> column value.</value>
	public System.DateTime LastEditedDate
	{
		get
		{
			if (IsLastEditedDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _lastEditedDate;
		}
		set
		{
			_lastEditedDateNull = false;
			_lastEditedDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="LastEditedDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLastEditedDateNull
	{
		get
		{
			return _lastEditedDateNull;
		}
		set
		{
			_lastEditedDateNull = value;
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
		// TaskStepVsProductPackage_ID
		dynStr.Append("  TaskStepVsProductPackage_ID=");
		if( IsTaskStepVsProductPackage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TaskStepVsProductPackage_ID);
		

		// TaskStep_ID
		dynStr.Append("  TaskStep_ID=");
		if( IsTaskStep_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TaskStep_ID);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		// StartTime
		dynStr.Append("  StartTime=");
		if( IsStartTimeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.StartTime);
		// EndTime
		dynStr.Append("  EndTime=");
		if( IsEndTimeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.EndTime);
		// Note
		dynStr.Append("  Note=");
		if( IsNoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Note);
		

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
		// LastEditedBy
		dynStr.Append("  LastEditedBy=");
		if( IsLastEditedByNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedBy);
		// LastEditedDate
		dynStr.Append("  LastEditedDate=");
		if( IsLastEditedDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.LastEditedDate);
		return dynStr.ToString();
	}
}
}




