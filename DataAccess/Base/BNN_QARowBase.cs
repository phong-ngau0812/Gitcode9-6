
// <fileinfo name="Base\BNN_QARowBase.cs">
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
/// The base class for <see cref="BNN_QARow"/> that 
/// represents a record in the <c>BNN_QA</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_QARow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_QARowBase
{
	/// _qa_id
	private int _qa_id;
	private bool _qa_idNull = true;
	/// _question
	private string _question;
	private bool _questionNull = true;
	/// _answer
	private string _answer;
	private bool _answerNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _district_ID
	private int _district_ID;
	private bool _district_IDNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_QARowBase"/> class.
	/// </summary>
	public BNN_QARowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>QA_ID</c> column value.
		/// </summary>
		/// <value>The <c>QA_ID</c> column value.</value>
	public int QA_ID
	{
		get
		{
			if(IsQA_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _qa_id;
		}
		set
		{
			_qa_idNull = false;
			_qa_id = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="QA_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQA_IDNull
	{
		get
		{
			return _qa_idNull;
		}
		set
		{
			_qa_idNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Question</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Question</c> column value.</value>
	public string Question
	{
		get
		{
			if(IsQuestionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _question;
		}
		set
		{
			_questionNull = false;
			_question = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Question"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQuestionNull
	{
		get
		{
			return _questionNull;
		}
		set
		{
			_questionNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Answer</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Answer</c> column value.</value>
	public string Answer
	{
		get
		{
			if(IsAnswerNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _answer;
		}
		set
		{
			_answerNull = false;
			_answer = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Answer"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAnswerNull
	{
		get
		{
			return _answerNull;
		}
		set
		{
			_answerNull = value;
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
		/// Gets or sets the <c>Sort</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sort</c> column value.</value>
	public int Sort
	{
		get
		{
			if (IsSortNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sort;
		}
		set
		{
			_sortNull = false;
			_sort = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Sort"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSortNull
	{
		get
		{
			return _sortNull;
		}
		set
		{
			_sortNull = value;
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
		/// Gets or sets the <c>Location_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location_ID</c> column value.</value>
	public int Location_ID
	{
		get
		{
			if (IsLocation_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location_ID;
		}
		set
		{
			_location_IDNull = false;
			_location_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocation_IDNull
	{
		get
		{
			return _location_IDNull;
		}
		set
		{
			_location_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>District_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>District_ID</c> column value.</value>
	public int District_ID
	{
		get
		{
			if (IsDistrict_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _district_ID;
		}
		set
		{
			_district_IDNull = false;
			_district_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="District_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDistrict_IDNull
	{
		get
		{
			return _district_IDNull;
		}
		set
		{
			_district_IDNull = value;
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
		// QA_ID
		dynStr.Append("  QA_ID=");
		if( IsQA_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.QA_ID);
		

		// Question
		dynStr.Append("  Question=");
		if( IsQuestionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Question);
		

		// Answer
		dynStr.Append("  Answer=");
		if( IsAnswerNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Answer);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
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
		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// District_ID
		dynStr.Append("  District_ID=");
		if( IsDistrict_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.District_ID);
		return dynStr.ToString();
	}
}
}




