
// <fileinfo name="Base\tblTravelReportRowBase.cs">
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
/// The base class for <see cref="tblTravelReportRow"/> that 
/// represents a record in the <c>tblTravelReport</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="tblTravelReportRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class tblTravelReportRowBase
{
	/// _id
	private int _id;
	private bool _idNull = true;
	/// _title
	private string _title;
	private bool _titleNull = true;
	/// _summary
	private string _summary;
	private bool _summaryNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _imageFile
	private string _imageFile;
	private bool _imageFileNull = true;
	/// _bannerFile
	private string _bannerFile;
	private bool _bannerFileNull = true;
	/// _regDate
	private System.DateTime _regDate;
	private bool _regDateNull = true;
	/// _seoTitle
	private string _seoTitle;
	private bool _seoTitleNull = true;
	/// _seoKeyword
	private string _seoKeyword;
	private bool _seoKeywordNull = true;
	/// _seoDescription
	private string _seoDescription;
	private bool _seoDescriptionNull = true;
	/// _status
	private int _status;
	private bool _statusNull = true;
	/// _flgTop
	private int _flgTop;
	private bool _flgTopNull = true;
	/// _flgHome
	private int _flgHome;
	private bool _flgHomeNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="tblTravelReportRowBase"/> class.
	/// </summary>
	public tblTravelReportRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>ID</c> column value.
		/// </summary>
		/// <value>The <c>ID</c> column value.</value>
	public int ID
	{
		get
		{
			if(IsIDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _id;
		}
		set
		{
			_idNull = false;
			_id = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsIDNull
	{
		get
		{
			return _idNull;
		}
		set
		{
			_idNull = value;
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
		/// Gets or sets the <c>ImageFile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ImageFile</c> column value.</value>
	public string ImageFile
	{
		get
		{
			if(IsImageFileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _imageFile;
		}
		set
		{
			_imageFileNull = false;
			_imageFile = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ImageFile"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsImageFileNull
	{
		get
		{
			return _imageFileNull;
		}
		set
		{
			_imageFileNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BannerFile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BannerFile</c> column value.</value>
	public string BannerFile
	{
		get
		{
			if(IsBannerFileNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _bannerFile;
		}
		set
		{
			_bannerFileNull = false;
			_bannerFile = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BannerFile"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBannerFileNull
	{
		get
		{
			return _bannerFileNull;
		}
		set
		{
			_bannerFileNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>RegDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>RegDate</c> column value.</value>
	public System.DateTime RegDate
	{
		get
		{
			if (IsRegDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _regDate;
		}
		set
		{
			_regDateNull = false;
			_regDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="RegDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRegDateNull
	{
		get
		{
			return _regDateNull;
		}
		set
		{
			_regDateNull = value;
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
		/// Gets or sets the <c>FlgTop</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FlgTop</c> column value.</value>
	public int FlgTop
	{
		get
		{
			if (IsFlgTopNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _flgTop;
		}
		set
		{
			_flgTopNull = false;
			_flgTop = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FlgTop"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFlgTopNull
	{
		get
		{
			return _flgTopNull;
		}
		set
		{
			_flgTopNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>FlgHome</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FlgHome</c> column value.</value>
	public int FlgHome
	{
		get
		{
			if (IsFlgHomeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _flgHome;
		}
		set
		{
			_flgHomeNull = false;
			_flgHome = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="FlgHome"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFlgHomeNull
	{
		get
		{
			return _flgHomeNull;
		}
		set
		{
			_flgHomeNull = value;
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
		// ID
		dynStr.Append("  ID=");
		if( IsIDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ID);
		

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
		

		// ImageFile
		dynStr.Append("  ImageFile=");
		if( IsImageFileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ImageFile);
		

		// BannerFile
		dynStr.Append("  BannerFile=");
		if( IsBannerFileNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BannerFile);
		

		// RegDate
		dynStr.Append("  RegDate=");
		if( IsRegDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.RegDate);
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
		

		// Status
		dynStr.Append("  Status=");
		if( IsStatusNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Status);
		// FlgTop
		dynStr.Append("  FlgTop=");
		if( IsFlgTopNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FlgTop);
		// FlgHome
		dynStr.Append("  FlgHome=");
		if( IsFlgHomeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.FlgHome);
		return dynStr.ToString();
	}
}
}




