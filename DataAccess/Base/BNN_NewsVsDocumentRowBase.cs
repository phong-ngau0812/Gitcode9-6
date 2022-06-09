
// <fileinfo name="Base\BNN_NewsVsDocumentRowBase.cs">
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
/// The base class for <see cref="BNN_NewsVsDocumentRow"/> that 
/// represents a record in the <c>BNN_NewsVsDocument</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_NewsVsDocumentRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_NewsVsDocumentRowBase
{
	/// _newsVsDocument_ID
	private int _newsVsDocument_ID;
	private bool _newsVsDocument_IDNull = true;
	/// _news_ID
	private int _news_ID;
	private bool _news_IDNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _file
	private string _file;
	private bool _fileNull = true;
	/// _note
	private string _note;
	private bool _noteNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _createDate
	private System.DateTime _createDate;
	private bool _createDateNull = true;
	/// _lastEditDate
	private System.DateTime _lastEditDate;
	private bool _lastEditDateNull = true;
	/// _createBy
	private System.Guid _createBy;
	private bool _createByNull = true;
	/// _lastEditBy
	private System.Guid _lastEditBy;
	private bool _lastEditByNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BNN_NewsVsDocumentRowBase"/> class.
	/// </summary>
	public BNN_NewsVsDocumentRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>NewsVsDocument_ID</c> column value.
		/// </summary>
		/// <value>The <c>NewsVsDocument_ID</c> column value.</value>
	public int NewsVsDocument_ID
	{
		get
		{
			if(IsNewsVsDocument_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _newsVsDocument_ID;
		}
		set
		{
			_newsVsDocument_IDNull = false;
			_newsVsDocument_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="NewsVsDocument_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNewsVsDocument_IDNull
	{
		get
		{
			return _newsVsDocument_IDNull;
		}
		set
		{
			_newsVsDocument_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>News_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>News_ID</c> column value.</value>
	public int News_ID
	{
		get
		{
			if (IsNews_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _news_ID;
		}
		set
		{
			_news_IDNull = false;
			_news_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="News_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsNews_IDNull
	{
		get
		{
			return _news_IDNull;
		}
		set
		{
			_news_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Title</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Title</c> column value.</value>
	public string Title
	{
		get
		{
			if(IsTitleNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _title;
		}
		set
		{
			_titleNull = false;
			_title = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Title"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTitleNull
	{
		get
		{
			return _titleNull;
		}
		set
		{
			_titleNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>File</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>File</c> column value.</value>
	public string File
	{
		get
		{
			if(IsFileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _file;
		}
		set
		{
			_fileNull = false;
			_file = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="File"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFileNull
	{
		get
		{
			return _fileNull;
		}
		set
		{
			_fileNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// NewsVsDocument_ID
		dynStr.Append("  NewsVsDocument_ID=");
		if( IsNewsVsDocument_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.NewsVsDocument_ID);
		

		// News_ID
		dynStr.Append("  News_ID=");
		if( IsNews_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.News_ID);
		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// File
		dynStr.Append("  File=");
		if( IsFileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.File);
		

		// Note
		dynStr.Append("  Note=");
		if( IsNoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Note);
		

		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
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
		// Sort
		dynStr.Append("  Sort=");
		if( IsSortNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Sort);
		return dynStr.ToString();
	}
}
}




