
// <fileinfo name="Base\BNN_DocumentRowBase.cs">
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
/// The base class for <see cref="BNN_DocumentRow"/> that 
/// represents a record in the <c>BNN_Document</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="BNN_DocumentRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class BNN_DocumentRowBase
{
	/// _document_ID
	private int _document_ID;
	private bool _document_IDNull = true;
	/// _documentCategory_ID
	private int _documentCategory_ID;
	private bool _documentCategory_IDNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _summary
	private string _summary;
	private bool _summaryNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _tag
	private string _tag;
	private bool _tagNull = true;
	/// _view
	private int _view;
	private bool _viewNull = true;
	/// _isHot
	private int _isHot;
	private bool _isHotNull = true;
	/// _isHome
	private int _isHome;
	private bool _isHomeNull = true;
	/// _author
	private string _author;
	private bool _authorNull = true;
	/// _source
	private string _source;
	private bool _sourceNull = true;
	/// _active
	private int _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;
	/// _seoTitle
	private string _seoTitle;
	private bool _seoTitleNull = true;
	/// _seoKeyword
	private string _seoKeyword;
	private bool _seoKeywordNull = true;
	/// _seoDescription
	private string _seoDescription;
	private bool _seoDescriptionNull = true;
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
	/// Initializes a new instance of the <see cref="BNN_DocumentRowBase"/> class.
	/// </summary>
	public BNN_DocumentRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Document_ID</c> column value.
		/// </summary>
		/// <value>The <c>Document_ID</c> column value.</value>
	public int Document_ID
	{
		get
		{
			if(IsDocument_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _document_ID;
		}
		set
		{
			_document_IDNull = false;
			_document_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Document_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDocument_IDNull
	{
		get
		{
			return _document_IDNull;
		}
		set
		{
			_document_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>DocumentCategory_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DocumentCategory_ID</c> column value.</value>
	public int DocumentCategory_ID
	{
		get
		{
			if (IsDocumentCategory_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _documentCategory_ID;
		}
		set
		{
			_documentCategory_IDNull = false;
			_documentCategory_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="DocumentCategory_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDocumentCategory_IDNull
	{
		get
		{
			return _documentCategory_IDNull;
		}
		set
		{
			_documentCategory_IDNull = value;
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
		/// Gets or sets the <c>Summary</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Summary</c> column value.</value>
	public string Summary
	{
		get
		{
			if(IsSummaryNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _summary;
		}
		set
		{
			_summaryNull = false;
			_summary = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Summary"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSummaryNull
	{
		get
		{
			return _summaryNull;
		}
		set
		{
			_summaryNull = value;
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
		/// Gets or sets the <c>Image</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Image</c> column value.</value>
	public string Image
	{
		get
		{
			if(IsImageNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _image;
		}
		set
		{
			_imageNull = false;
			_image = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Image"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImageNull
	{
		get
		{
			return _imageNull;
		}
		set
		{
			_imageNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Tag</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Tag</c> column value.</value>
	public string Tag
	{
		get
		{
			if(IsTagNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _tag;
		}
		set
		{
			_tagNull = false;
			_tag = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Tag"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTagNull
	{
		get
		{
			return _tagNull;
		}
		set
		{
			_tagNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>View</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>View</c> column value.</value>
	public int View
	{
		get
		{
			if (IsViewNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _view;
		}
		set
		{
			_viewNull = false;
			_view = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="View"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsViewNull
	{
		get
		{
			return _viewNull;
		}
		set
		{
			_viewNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IsHot</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsHot</c> column value.</value>
	public int IsHot
	{
		get
		{
			if (IsIsHotNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isHot;
		}
		set
		{
			_isHotNull = false;
			_isHot = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsHot"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsHotNull
	{
		get
		{
			return _isHotNull;
		}
		set
		{
			_isHotNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>IsHome</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsHome</c> column value.</value>
	public int IsHome
	{
		get
		{
			if (IsIsHomeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _isHome;
		}
		set
		{
			_isHomeNull = false;
			_isHome = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="IsHome"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIsHomeNull
	{
		get
		{
			return _isHomeNull;
		}
		set
		{
			_isHomeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Author</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Author</c> column value.</value>
	public string Author
	{
		get
		{
			if(IsAuthorNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _author;
		}
		set
		{
			_authorNull = false;
			_author = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Author"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAuthorNull
	{
		get
		{
			return _authorNull;
		}
		set
		{
			_authorNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Source</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Source</c> column value.</value>
	public string Source
	{
		get
		{
			if(IsSourceNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _source;
		}
		set
		{
			_sourceNull = false;
			_source = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Source"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSourceNull
	{
		get
		{
			return _sourceNull;
		}
		set
		{
			_sourceNull = value;
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
		/// Gets or sets the <c>SeoTitle</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SeoTitle</c> column value.</value>
	public string SeoTitle
	{
		get
		{
			if(IsSeoTitleNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _seoTitle;
		}
		set
		{
			_seoTitleNull = false;
			_seoTitle = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SeoTitle"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSeoTitleNull
	{
		get
		{
			return _seoTitleNull;
		}
		set
		{
			_seoTitleNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SeoKeyword</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SeoKeyword</c> column value.</value>
	public string SeoKeyword
	{
		get
		{
			if(IsSeoKeywordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _seoKeyword;
		}
		set
		{
			_seoKeywordNull = false;
			_seoKeyword = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SeoKeyword"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSeoKeywordNull
	{
		get
		{
			return _seoKeywordNull;
		}
		set
		{
			_seoKeywordNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SeoDescription</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SeoDescription</c> column value.</value>
	public string SeoDescription
	{
		get
		{
			if(IsSeoDescriptionNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _seoDescription;
		}
		set
		{
			_seoDescriptionNull = false;
			_seoDescription = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SeoDescription"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSeoDescriptionNull
	{
		get
		{
			return _seoDescriptionNull;
		}
		set
		{
			_seoDescriptionNull = value;
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
		// Document_ID
		dynStr.Append("  Document_ID=");
		if( IsDocument_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Document_ID);
		

		// DocumentCategory_ID
		dynStr.Append("  DocumentCategory_ID=");
		if( IsDocumentCategory_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.DocumentCategory_ID);
		// Title
		dynStr.Append("  Title=");
		if( IsTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Title);
		

		// Summary
		dynStr.Append("  Summary=");
		if( IsSummaryNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Summary);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// Tag
		dynStr.Append("  Tag=");
		if( IsTagNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Tag);
		

		// View
		dynStr.Append("  View=");
		if( IsViewNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.View);
		// IsHot
		dynStr.Append("  IsHot=");
		if( IsIsHotNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsHot);
		// IsHome
		dynStr.Append("  IsHome=");
		if( IsIsHomeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.IsHome);
		// Author
		dynStr.Append("  Author=");
		if( IsAuthorNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Author);
		

		// Source
		dynStr.Append("  Source=");
		if( IsSourceNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Source);
		

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
		// SeoTitle
		dynStr.Append("  SeoTitle=");
		if( IsSeoTitleNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SeoTitle);
		

		// SeoKeyword
		dynStr.Append("  SeoKeyword=");
		if( IsSeoKeywordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SeoKeyword);
		

		// SeoDescription
		dynStr.Append("  SeoDescription=");
		if( IsSeoDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SeoDescription);
		

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




