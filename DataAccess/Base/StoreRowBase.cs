
// <fileinfo name="Base\StoreRowBase.cs">
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
/// The base class for <see cref="StoreRow"/> that 
/// represents a record in the <c>Store</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="StoreRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class StoreRowBase
{
	/// _store_ID
	private int _store_ID;
	private bool _store_IDNull = true;
	/// _style_ID
	private int _style_ID;
	private bool _style_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _aboutUs
	private string _aboutUs;
	private bool _aboutUsNull = true;
	/// _keyword
	private string _keyword;
	private bool _keywordNull = true;
	/// _logo
	private string _logo;
	private bool _logoNull = true;
	/// _banner
	private string _banner;
	private bool _bannerNull = true;
	/// _bannerExt
	private string _bannerExt;
	private bool _bannerExtNull = true;
	/// _bannerWidth
	private int _bannerWidth;
	private bool _bannerWidthNull = true;
	/// _bannerHeight
	private int _bannerHeight;
	private bool _bannerHeightNull = true;
	/// _pageBackground
	private string _pageBackground;
	private bool _pageBackgroundNull = true;
	/// _ad_left
	private string _ad_left;
	private bool _ad_leftNull = true;
	/// _ad_top
	private string _ad_top;
	private bool _ad_topNull = true;
	/// _address
	private string _address;
	private bool _addressNull = true;
	/// _location_ID
	private int _location_ID;
	private bool _location_IDNull = true;
	/// _map
	private string _map;
	private bool _mapNull = true;
	/// _phone
	private string _phone;
	private bool _phoneNull = true;
	/// _fax
	private string _fax;
	private bool _faxNull = true;
	/// _email
	private string _email;
	private bool _emailNull = true;
	/// _ym
	private string _ym;
	private bool _ymNull = true;
	/// _ym2
	private string _ym2;
	private bool _ym2Null = true;
	/// _skype
	private string _skype;
	private bool _skypeNull = true;
	/// _website
	private string _website;
	private bool _websiteNull = true;
	/// _contact
	private string _contact;
	private bool _contactNull = true;
	/// _supportBuy
	private string _supportBuy;
	private bool _supportBuyNull = true;
	/// _rank
	private int _rank;
	private bool _rankNull = true;
	/// _startDate
	private System.DateTime _startDate;
	private bool _startDateNull = true;
	/// _endDate
	private System.DateTime _endDate;
	private bool _endDateNull = true;
	/// _active
	private bool _active;
	private bool _activeNull = true;
	/// _articleTop
	private int _articleTop;
	private bool _articleTopNull = true;
	/// _productTop
	private int _productTop;
	private bool _productTopNull = true;
	/// _domain
	private string _domain;
	private bool _domainNull = true;
	/// _subDomain
	private string _subDomain;
	private bool _subDomainNull = true;
	/// _counter
	private int _counter;
	private bool _counterNull = true;
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
	/// _url
	private string _url;
	private bool _urlNull = true;
	/// _tag
	private string _tag;
	private bool _tagNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="StoreRowBase"/> class.
	/// </summary>
	public StoreRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Store_ID</c> column value.
		/// </summary>
		/// <value>The <c>Store_ID</c> column value.</value>
	public int Store_ID
	{
		get
		{
			if(IsStore_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _store_ID;
		}
		set
		{
			_store_IDNull = false;
			_store_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Store_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStore_IDNull
	{
		get
		{
			return _store_IDNull;
		}
		set
		{
			_store_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Style_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Style_ID</c> column value.</value>
	public int Style_ID
	{
		get
		{
			if (IsStyle_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _style_ID;
		}
		set
		{
			_style_IDNull = false;
			_style_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Style_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStyle_IDNull
	{
		get
		{
			return _style_IDNull;
		}
		set
		{
			_style_IDNull = value;
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
		/// Gets or sets the <c>AboutUs</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AboutUs</c> column value.</value>
	public string AboutUs
	{
		get
		{
			if(IsAboutUsNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _aboutUs;
		}
		set
		{
			_aboutUsNull = false;
			_aboutUs = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="AboutUs"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAboutUsNull
	{
		get
		{
			return _aboutUsNull;
		}
		set
		{
			_aboutUsNull = value;
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
		/// Gets or sets the <c>Logo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Logo</c> column value.</value>
	public string Logo
	{
		get
		{
			if(IsLogoNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _logo;
		}
		set
		{
			_logoNull = false;
			_logo = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Logo"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLogoNull
	{
		get
		{
			return _logoNull;
		}
		set
		{
			_logoNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Banner</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Banner</c> column value.</value>
	public string Banner
	{
		get
		{
			if(IsBannerNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _banner;
		}
		set
		{
			_bannerNull = false;
			_banner = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Banner"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBannerNull
	{
		get
		{
			return _bannerNull;
		}
		set
		{
			_bannerNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BannerExt</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BannerExt</c> column value.</value>
	public string BannerExt
	{
		get
		{
			if(IsBannerExtNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _bannerExt;
		}
		set
		{
			_bannerExtNull = false;
			_bannerExt = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BannerExt"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBannerExtNull
	{
		get
		{
			return _bannerExtNull;
		}
		set
		{
			_bannerExtNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BannerWidth</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BannerWidth</c> column value.</value>
	public int BannerWidth
	{
		get
		{
			if (IsBannerWidthNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _bannerWidth;
		}
		set
		{
			_bannerWidthNull = false;
			_bannerWidth = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BannerWidth"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBannerWidthNull
	{
		get
		{
			return _bannerWidthNull;
		}
		set
		{
			_bannerWidthNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BannerHeight</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BannerHeight</c> column value.</value>
	public int BannerHeight
	{
		get
		{
			if (IsBannerHeightNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _bannerHeight;
		}
		set
		{
			_bannerHeightNull = false;
			_bannerHeight = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BannerHeight"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBannerHeightNull
	{
		get
		{
			return _bannerHeightNull;
		}
		set
		{
			_bannerHeightNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>PageBackground</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PageBackground</c> column value.</value>
	public string PageBackground
	{
		get
		{
			if(IsPageBackgroundNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _pageBackground;
		}
		set
		{
			_pageBackgroundNull = false;
			_pageBackground = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PageBackground"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPageBackgroundNull
	{
		get
		{
			return _pageBackgroundNull;
		}
		set
		{
			_pageBackgroundNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Ad_left</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Ad_left</c> column value.</value>
	public string Ad_left
	{
		get
		{
			if(IsAd_leftNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ad_left;
		}
		set
		{
			_ad_leftNull = false;
			_ad_left = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Ad_left"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAd_leftNull
	{
		get
		{
			return _ad_leftNull;
		}
		set
		{
			_ad_leftNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Ad_top</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Ad_top</c> column value.</value>
	public string Ad_top
	{
		get
		{
			if(IsAd_topNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ad_top;
		}
		set
		{
			_ad_topNull = false;
			_ad_top = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Ad_top"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAd_topNull
	{
		get
		{
			return _ad_topNull;
		}
		set
		{
			_ad_topNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Address</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Address</c> column value.</value>
	public string Address
	{
		get
		{
			if(IsAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _address;
		}
		set
		{
			_addressNull = false;
			_address = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Address"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAddressNull
	{
		get
		{
			return _addressNull;
		}
		set
		{
			_addressNull = value;
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
		/// Gets or sets the <c>Map</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Map</c> column value.</value>
	public string Map
	{
		get
		{
			if(IsMapNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _map;
		}
		set
		{
			_mapNull = false;
			_map = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Map"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMapNull
	{
		get
		{
			return _mapNull;
		}
		set
		{
			_mapNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Phone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Phone</c> column value.</value>
	public string Phone
	{
		get
		{
			if(IsPhoneNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _phone;
		}
		set
		{
			_phoneNull = false;
			_phone = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Phone"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPhoneNull
	{
		get
		{
			return _phoneNull;
		}
		set
		{
			_phoneNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Fax</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Fax</c> column value.</value>
	public string Fax
	{
		get
		{
			if(IsFaxNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _fax;
		}
		set
		{
			_faxNull = false;
			_fax = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Fax"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFaxNull
	{
		get
		{
			return _faxNull;
		}
		set
		{
			_faxNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
	public string Email
	{
		get
		{
			if(IsEmailNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _email;
		}
		set
		{
			_emailNull = false;
			_email = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Email"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEmailNull
	{
		get
		{
			return _emailNull;
		}
		set
		{
			_emailNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>YM</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>YM</c> column value.</value>
	public string YM
	{
		get
		{
			if(IsYMNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ym;
		}
		set
		{
			_ymNull = false;
			_ym = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="YM"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsYMNull
	{
		get
		{
			return _ymNull;
		}
		set
		{
			_ymNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>YM2</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>YM2</c> column value.</value>
	public string YM2
	{
		get
		{
			if(IsYM2Null)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _ym2;
		}
		set
		{
			_ym2Null = false;
			_ym2 = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="YM2"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsYM2Null
	{
		get
		{
			return _ym2Null;
		}
		set
		{
			_ym2Null = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Skype</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Skype</c> column value.</value>
	public string Skype
	{
		get
		{
			if(IsSkypeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _skype;
		}
		set
		{
			_skypeNull = false;
			_skype = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Skype"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSkypeNull
	{
		get
		{
			return _skypeNull;
		}
		set
		{
			_skypeNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Website</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Website</c> column value.</value>
	public string Website
	{
		get
		{
			if(IsWebsiteNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _website;
		}
		set
		{
			_websiteNull = false;
			_website = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Website"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWebsiteNull
	{
		get
		{
			return _websiteNull;
		}
		set
		{
			_websiteNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Contact</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact</c> column value.</value>
	public string Contact
	{
		get
		{
			if(IsContactNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _contact;
		}
		set
		{
			_contactNull = false;
			_contact = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Contact"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsContactNull
	{
		get
		{
			return _contactNull;
		}
		set
		{
			_contactNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SupportBuy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SupportBuy</c> column value.</value>
	public string SupportBuy
	{
		get
		{
			if(IsSupportBuyNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _supportBuy;
		}
		set
		{
			_supportBuyNull = false;
			_supportBuy = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SupportBuy"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSupportBuyNull
	{
		get
		{
			return _supportBuyNull;
		}
		set
		{
			_supportBuyNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Rank</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Rank</c> column value.</value>
	public int Rank
	{
		get
		{
			if (IsRankNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _rank;
		}
		set
		{
			_rankNull = false;
			_rank = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Rank"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRankNull
	{
		get
		{
			return _rankNull;
		}
		set
		{
			_rankNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StartDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StartDate</c> column value.</value>
	public System.DateTime StartDate
	{
		get
		{
			if (IsStartDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _startDate;
		}
		set
		{
			_startDateNull = false;
			_startDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StartDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStartDateNull
	{
		get
		{
			return _startDateNull;
		}
		set
		{
			_startDateNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>EndDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EndDate</c> column value.</value>
	public System.DateTime EndDate
	{
		get
		{
			if (IsEndDateNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _endDate;
		}
		set
		{
			_endDateNull = false;
			_endDate = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="EndDate"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsEndDateNull
	{
		get
		{
			return _endDateNull;
		}
		set
		{
			_endDateNull = value;
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
		/// Gets or sets the <c>ArticleTop</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ArticleTop</c> column value.</value>
	public int ArticleTop
	{
		get
		{
			if (IsArticleTopNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _articleTop;
		}
		set
		{
			_articleTopNull = false;
			_articleTop = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ArticleTop"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsArticleTopNull
	{
		get
		{
			return _articleTopNull;
		}
		set
		{
			_articleTopNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductTop</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductTop</c> column value.</value>
	public int ProductTop
	{
		get
		{
			if (IsProductTopNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productTop;
		}
		set
		{
			_productTopNull = false;
			_productTop = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductTop"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductTopNull
	{
		get
		{
			return _productTopNull;
		}
		set
		{
			_productTopNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Domain</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Domain</c> column value.</value>
	public string Domain
	{
		get
		{
			if(IsDomainNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _domain;
		}
		set
		{
			_domainNull = false;
			_domain = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Domain"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDomainNull
	{
		get
		{
			return _domainNull;
		}
		set
		{
			_domainNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SubDomain</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SubDomain</c> column value.</value>
	public string SubDomain
	{
		get
		{
			if(IsSubDomainNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _subDomain;
		}
		set
		{
			_subDomainNull = false;
			_subDomain = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SubDomain"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSubDomainNull
	{
		get
		{
			return _subDomainNull;
		}
		set
		{
			_subDomainNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Counter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Counter</c> column value.</value>
	public int Counter
	{
		get
		{
			if (IsCounterNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _counter;
		}
		set
		{
			_counterNull = false;
			_counter = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Counter"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCounterNull
	{
		get
		{
			return _counterNull;
		}
		set
		{
			_counterNull = value;
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
	/// Returns the string representation of this instance.
	/// </summary>
	/// <returns>The string representation of this instance.</returns>
	public override string ToString()
	{
		System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
		dynStr.Append(":");
		// Store_ID
		dynStr.Append("  Store_ID=");
		if( IsStore_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Store_ID);
		

		// Style_ID
		dynStr.Append("  Style_ID=");
		if( IsStyle_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Style_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// AboutUs
		dynStr.Append("  AboutUs=");
		if( IsAboutUsNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.AboutUs);
		

		// Keyword
		dynStr.Append("  Keyword=");
		if( IsKeywordNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Keyword);
		

		// Logo
		dynStr.Append("  Logo=");
		if( IsLogoNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Logo);
		

		// Banner
		dynStr.Append("  Banner=");
		if( IsBannerNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Banner);
		

		// BannerExt
		dynStr.Append("  BannerExt=");
		if( IsBannerExtNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BannerExt);
		

		// BannerWidth
		dynStr.Append("  BannerWidth=");
		if( IsBannerWidthNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.BannerWidth);
		// BannerHeight
		dynStr.Append("  BannerHeight=");
		if( IsBannerHeightNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.BannerHeight);
		// PageBackground
		dynStr.Append("  PageBackground=");
		if( IsPageBackgroundNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PageBackground);
		

		// Ad_left
		dynStr.Append("  Ad_left=");
		if( IsAd_leftNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Ad_left);
		

		// Ad_top
		dynStr.Append("  Ad_top=");
		if( IsAd_topNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Ad_top);
		

		// Address
		dynStr.Append("  Address=");
		if( IsAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Address);
		

		// Location_ID
		dynStr.Append("  Location_ID=");
		if( IsLocation_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Location_ID);
		// Map
		dynStr.Append("  Map=");
		if( IsMapNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Map);
		

		// Phone
		dynStr.Append("  Phone=");
		if( IsPhoneNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Phone);
		

		// Fax
		dynStr.Append("  Fax=");
		if( IsFaxNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Fax);
		

		// Email
		dynStr.Append("  Email=");
		if( IsEmailNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Email);
		

		// YM
		dynStr.Append("  YM=");
		if( IsYMNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.YM);
		

		// YM2
		dynStr.Append("  YM2=");
		if( IsYM2Null)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.YM2);
		

		// Skype
		dynStr.Append("  Skype=");
		if( IsSkypeNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Skype);
		

		// Website
		dynStr.Append("  Website=");
		if( IsWebsiteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Website);
		

		// Contact
		dynStr.Append("  Contact=");
		if( IsContactNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Contact);
		

		// SupportBuy
		dynStr.Append("  SupportBuy=");
		if( IsSupportBuyNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SupportBuy);
		

		// Rank
		dynStr.Append("  Rank=");
		if( IsRankNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Rank);
		// StartDate
		dynStr.Append("  StartDate=");
		if( IsStartDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.StartDate);
		// EndDate
		dynStr.Append("  EndDate=");
		if( IsEndDateNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.EndDate);
		// Active
		dynStr.Append("  Active=");
		if( IsActiveNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Active);
		// ArticleTop
		dynStr.Append("  ArticleTop=");
		if( IsArticleTopNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ArticleTop);
		// ProductTop
		dynStr.Append("  ProductTop=");
		if( IsProductTopNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductTop);
		// Domain
		dynStr.Append("  Domain=");
		if( IsDomainNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Domain);
		

		// SubDomain
		dynStr.Append("  SubDomain=");
		if( IsSubDomainNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.SubDomain);
		

		// Counter
		dynStr.Append("  Counter=");
		if( IsCounterNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Counter);
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
		// URL
		dynStr.Append("  URL=");
		if( IsURLNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.URL);
		

		// Tag
		dynStr.Append("  Tag=");
		if( IsTagNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Tag);
		

		return dynStr.ToString();
	}
}
}




