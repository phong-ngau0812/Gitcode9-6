
// <fileinfo name="Base\TaskTypeRowBase.cs">
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
/// The base class for <see cref="TaskTypeRow"/> that 
/// represents a record in the <c>TaskType</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TaskTypeRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TaskTypeRowBase
{
	/// _taskType_ID
	private int _taskType_ID;
	private bool _taskType_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TaskTypeRowBase"/> class.
	/// </summary>
	public TaskTypeRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>TaskType_ID</c> column value.
		/// </summary>
		/// <value>The <c>TaskType_ID</c> column value.</value>
	public int TaskType_ID
	{
		get
		{
			if(IsTaskType_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taskType_ID;
		}
		set
		{
			_taskType_IDNull = false;
			_taskType_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaskType_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaskType_IDNull
	{
		get
		{
			return _taskType_IDNull;
		}
		set
		{
			_taskType_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Name</c> column value.</value>
	public string Name
	{
		get
		{
			if(IsNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _name;
		}
		set
		{
			_nameNull = false;
			_name = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Name"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNameNull
	{
		get
		{
			return _nameNull;
		}
		set
		{
			_nameNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// TaskType_ID
		dynStr.Append("  TaskType_ID=");
		if( IsTaskType_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TaskType_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		return dynStr.ToString();
	}
}
}




