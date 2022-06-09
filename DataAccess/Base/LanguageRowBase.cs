
// <fileinfo name="Base\LanguageRowBase.cs">
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
/// The base class for <see cref="LanguageRow"/> that 
/// represents a record in the <c>Language</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="LanguageRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class LanguageRowBase
{
	/// _language_ID
	private int _language_ID;
	private bool _language_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _skin_ID
	private int _skin_ID;
	private bool _skin_IDNull = true;
	/// _charset
	private string _charset;
	private bool _charsetNull = true;
	/// _culture
	private string _culture;
	private bool _cultureNull = true;
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _article_Top
	private int _article_Top;
	private bool _article_TopNull = true;
	/// _websiteName
	private string _websiteName;
	private bool _websiteNameNull = true;
	/// _keyword
	private string _keyword;
	private bool _keywordNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _sort
	private int _sort;
	private bool _sortNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="LanguageRowBase"/> class.
	/// </summary>
	public LanguageRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Language_ID</c> column value.
		/// </summary>
		/// <value>The <c>Language_ID</c> column value.</value>
	public int Language_ID
	{
		get
		{
			if(IsLanguage_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _language_ID;
		}
		set
		{
			_language_IDNull = false;
			_language_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Language_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLanguage_IDNull
	{
		get
		{
			return _language_IDNull;
		}
		set
		{
			_language_IDNull = value;
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
		/// Gets or sets the <c>Skin_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Skin_ID</c> column value.</value>
	public int Skin_ID
	{
		get
		{
			if (IsSkin_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _skin_ID;
		}
		set
		{
			_skin_IDNull = false;
			_skin_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Skin_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSkin_IDNull
	{
		get
		{
			return _skin_IDNull;
		}
		set
		{
			_skin_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Charset</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Charset</c> column value.</value>
	public string Charset
	{
		get
		{
			if(IsCharsetNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _charset;
		}
		set
		{
			_charsetNull = false;
			_charset = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Charset"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCharsetNull
	{
		get
		{
			return _charsetNull;
		}
		set
		{
			_charsetNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Culture</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Culture</c> column value.</value>
	public string Culture
	{
		get
		{
			if(IsCultureNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _culture;
		}
		set
		{
			_cultureNull = false;
			_culture = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Culture"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCultureNull
	{
		get
		{
			return _cultureNull;
		}
		set
		{
			_cultureNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>URL</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>URL</c> column value.</value>
	public string URL
	{
		get
		{
			if(IsURLNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _url;
		}
		set
		{
			_urlNull = false;
			_url = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="URL"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsURLNull
	{
		get
		{
			return _urlNull;
		}
		set
		{
			_urlNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Article_Top</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Article_Top</c> column value.</value>
	public int Article_Top
	{
		get
		{
			if (IsArticle_TopNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _article_Top;
		}
		set
		{
			_article_TopNull = false;
			_article_Top = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Article_Top"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsArticle_TopNull
	{
		get
		{
			return _article_TopNull;
		}
		set
		{
			_article_TopNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>WebsiteName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WebsiteName</c> column value.</value>
	public string WebsiteName
	{
		get
		{
			if(IsWebsiteNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _websiteName;
		}
		set
		{
			_websiteNameNull = false;
			_websiteName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WebsiteName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWebsiteNameNull
	{
		get
		{
			return _websiteNameNull;
		}
		set
		{
			_websiteNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Keyword</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Keyword</c> column value.</value>
	public string Keyword
	{
		get
		{
			if(IsKeywordNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _keyword;
		}
		set
		{
			_keywordNull = false;
			_keyword = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Keyword"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsKeywordNull
	{
		get
		{
			return _keywordNull;
		}
		set
		{
			_keywordNull = value;
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
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
	public bool Active
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// Language_ID
		dynStr.Append("  Language_ID=");
		if( IsLanguage_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Language_ID);
		

		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Skin_ID
		dynStr.Append("  Skin_ID=");
		if( IsSkin_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Skin_ID);
		// Charset
		dynStr.Append("  Charset=");
		if( IsCharsetNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Charset);
		

		// Culture
		dynStr.Append("  Culture=");
		if( IsCultureNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Culture);
		

		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// Article_Top
		dynStr.Append("  Article_Top=");
		if( IsArticle_TopNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Article_Top);
		// WebsiteName
		dynStr.Append("  WebsiteName=");
		if( IsWebsiteNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WebsiteName);
		

		// Keyword
		dynStr.Append("  Keyword=");
		if( IsKeywordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Keyword);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

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
		return dynStr.ToString();
	}
}
}




