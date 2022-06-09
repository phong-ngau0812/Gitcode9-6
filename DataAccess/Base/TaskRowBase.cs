
// <fileinfo name="Base\TaskRowBase.cs">
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
/// The base class for <see cref="TaskRow"/> that 
/// represents a record in the <c>Task</c> table.
/// </summary>
/// <remarks>
/// Do not change this source code manually. Update the <see cref="TaskRow"/>
/// class if you need to add or change some functionality.
/// </remarks>
public abstract class TaskRowBase
{
	/// _task_ID
	private int _task_ID;
	private bool _task_IDNull = true;
	/// _productBrand_ID
	private int _productBrand_ID;
	private bool _productBrand_IDNull = true;
	/// _product_ID
	private int _product_ID;
	private bool _product_IDNull = true;
	/// _productPackage_ID
	private int _productPackage_ID;
	private bool _productPackage_IDNull = true;
	/// _workshop_ID
	private int _workshop_ID;
	private bool _workshop_IDNull = true;
	/// _farm_ID
	private int _farm_ID;
	private bool _farm_IDNull = true;
	/// _customer_ID
	private int _customer_ID;
	private bool _customer_IDNull = true;
	/// _taskType_ID
	private int _taskType_ID;
	private bool _taskType_IDNull = true;
	/// _taskStep_ID
	private int _taskStep_ID;
	private bool _taskStep_IDNull = true;
	/// _taskStatus_ID
	private int _taskStatus_ID;
	private bool _taskStatus_IDNull = true;
	/// _name
	private string _name;
	private bool _nameNull = true;
	/// _productName
	private string _productName;
	private bool _productNameNull = true;
	/// _productPackageName
	private string _productPackageName;
	private bool _productPackageNameNull = true;
	/// _customerName
	private string _customerName;
	private bool _customerNameNull = true;
	/// _description
	private string _description;
	private bool _descriptionNull = true;
	/// _personStaff
	private string _personStaff;
	private bool _personStaffNull = true;
	/// _startDate
	private System.DateTime _startDate;
	private bool _startDateNull = true;
	/// _endDate
	private System.DateTime _endDate;
	private bool _endDateNull = true;
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
	/// _workEvaluating
	private string _workEvaluating;
	private bool _workEvaluatingNull = true;
	/// _location
	private string _location;
	private bool _locationNull = true;
	/// _buyerName
	private string _buyerName;
	private bool _buyerNameNull = true;
	/// _userName
	private string _userName;
	private bool _userNameNull = true;
	/// _quantity
	private decimal _quantity;
	private bool _quantityNull = true;
	/// _price
	private decimal _price;
	private bool _priceNull = true;
	/// _sumMoney
	private decimal _sumMoney;
	private bool _sumMoneyNull = true;
	/// _shopName
	private string _shopName;
	private bool _shopNameNull = true;
	/// _shopAddress
	private string _shopAddress;
	private bool _shopAddressNull = true;
	/// _amount
	private decimal _amount;
	private bool _amountNull = true;
	/// _harvestDayRemain
	private int _harvestDayRemain;
	private bool _harvestDayRemainNull = true;
	/// _harvestVolume
	private decimal _harvestVolume;
	private bool _harvestVolumeNull = true;
	/// _note
	private string _note;
	private bool _noteNull = true;
	/// _risk
	private string _risk;
	private bool _riskNull = true;
	/// _image
	private string _image;
	private bool _imageNull = true;
	/// _staff_ID
	private string _staff_ID;
	private bool _staff_IDNull = true;
	/// _material_ID
	private int _material_ID;
	private bool _material_IDNull = true;
	/// _startingPoint
	private string _startingPoint;
	private bool _startingPointNull = true;
	/// _destination
	private string _destination;
	private bool _destinationNull = true;
	/// _transporter_ID
	private int _transporter_ID;
	private bool _transporter_IDNull = true;
	/// _productItem_ID_List
	private string _productItem_ID_List;
	private bool _productItem_ID_ListNull = true;
	/// _warehouse_ID
	private int _warehouse_ID;
	private bool _warehouse_IDNull = true;
	/// _weather
	private string _weather;
	private bool _weatherNull = true;
	/// _comment
	private string _comment;
	private bool _commentNull = true;
	/// _unit
	private string _unit;
	private bool _unitNull = true;
	/// _taskStepAnswer_ID_List
	private string _taskStepAnswer_ID_List;
	private bool _taskStepAnswer_ID_ListNull = true;


// Instance fields
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TaskRowBase"/> class.
	/// </summary>
	public TaskRowBase():base()
	{
		// EMPTY
	}

		/// <summary>
		/// Gets or sets the <c>Task_ID</c> column value.
		/// </summary>
		/// <value>The <c>Task_ID</c> column value.</value>
	public int Task_ID
	{
		get
		{
			if(IsTask_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _task_ID;
		}
		set
		{
			_task_IDNull = false;
			_task_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Task_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTask_IDNull
	{
		get
		{
			return _task_IDNull;
		}
		set
		{
			_task_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductBrand_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductBrand_ID</c> column value.</value>
	public int ProductBrand_ID
	{
		get
		{
			if (IsProductBrand_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productBrand_ID;
		}
		set
		{
			_productBrand_IDNull = false;
			_productBrand_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductBrand_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductBrand_IDNull
	{
		get
		{
			return _productBrand_IDNull;
		}
		set
		{
			_productBrand_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Product_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Product_ID</c> column value.</value>
	public int Product_ID
	{
		get
		{
			if (IsProduct_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _product_ID;
		}
		set
		{
			_product_IDNull = false;
			_product_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Product_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProduct_IDNull
	{
		get
		{
			return _product_IDNull;
		}
		set
		{
			_product_IDNull = value;
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
		/// Gets or sets the <c>Workshop_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Workshop_ID</c> column value.</value>
	public int Workshop_ID
	{
		get
		{
			if (IsWorkshop_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _workshop_ID;
		}
		set
		{
			_workshop_IDNull = false;
			_workshop_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Workshop_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWorkshop_IDNull
	{
		get
		{
			return _workshop_IDNull;
		}
		set
		{
			_workshop_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Farm_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Farm_ID</c> column value.</value>
	public int Farm_ID
	{
		get
		{
			if (IsFarm_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _farm_ID;
		}
		set
		{
			_farm_IDNull = false;
			_farm_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Farm_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsFarm_IDNull
	{
		get
		{
			return _farm_IDNull;
		}
		set
		{
			_farm_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Customer_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Customer_ID</c> column value.</value>
	public int Customer_ID
	{
		get
		{
			if (IsCustomer_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customer_ID;
		}
		set
		{
			_customer_IDNull = false;
			_customer_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Customer_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomer_IDNull
	{
		get
		{
			return _customer_IDNull;
		}
		set
		{
			_customer_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TaskType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TaskType_ID</c> column value.</value>
	public int TaskType_ID
	{
		get
		{
			if (IsTaskType_IDNull)
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
		/// Gets or sets the <c>TaskStatus_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TaskStatus_ID</c> column value.</value>
	public int TaskStatus_ID
	{
		get
		{
			if (IsTaskStatus_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taskStatus_ID;
		}
		set
		{
			_taskStatus_IDNull = false;
			_taskStatus_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaskStatus_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaskStatus_IDNull
	{
		get
		{
			return _taskStatus_IDNull;
		}
		set
		{
			_taskStatus_IDNull = value;
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
		/// Gets or sets the <c>ProductName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductName</c> column value.</value>
	public string ProductName
	{
		get
		{
			if(IsProductNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productName;
		}
		set
		{
			_productNameNull = false;
			_productName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductNameNull
	{
		get
		{
			return _productNameNull;
		}
		set
		{
			_productNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductPackageName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductPackageName</c> column value.</value>
	public string ProductPackageName
	{
		get
		{
			if(IsProductPackageNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productPackageName;
		}
		set
		{
			_productPackageNameNull = false;
			_productPackageName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductPackageName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductPackageNameNull
	{
		get
		{
			return _productPackageNameNull;
		}
		set
		{
			_productPackageNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>CustomerName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>CustomerName</c> column value.</value>
	public string CustomerName
	{
		get
		{
			if(IsCustomerNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _customerName;
		}
		set
		{
			_customerNameNull = false;
			_customerName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="CustomerName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCustomerNameNull
	{
		get
		{
			return _customerNameNull;
		}
		set
		{
			_customerNameNull = value;
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
		/// Gets or sets the <c>PersonStaff</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PersonStaff</c> column value.</value>
	public string PersonStaff
	{
		get
		{
			if(IsPersonStaffNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _personStaff;
		}
		set
		{
			_personStaffNull = false;
			_personStaff = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="PersonStaff"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPersonStaffNull
	{
		get
		{
			return _personStaffNull;
		}
		set
		{
			_personStaffNull = value;
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
		/// Gets or sets the <c>WorkEvaluating</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>WorkEvaluating</c> column value.</value>
	public string WorkEvaluating
	{
		get
		{
			if(IsWorkEvaluatingNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _workEvaluating;
		}
		set
		{
			_workEvaluatingNull = false;
			_workEvaluating = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="WorkEvaluating"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWorkEvaluatingNull
	{
		get
		{
			return _workEvaluatingNull;
		}
		set
		{
			_workEvaluatingNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Location</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Location</c> column value.</value>
	public string Location
	{
		get
		{
			if(IsLocationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _location;
		}
		set
		{
			_locationNull = false;
			_location = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Location"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsLocationNull
	{
		get
		{
			return _locationNull;
		}
		set
		{
			_locationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>BuyerName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BuyerName</c> column value.</value>
	public string BuyerName
	{
		get
		{
			if(IsBuyerNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _buyerName;
		}
		set
		{
			_buyerNameNull = false;
			_buyerName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="BuyerName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsBuyerNameNull
	{
		get
		{
			return _buyerNameNull;
		}
		set
		{
			_buyerNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>UserName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserName</c> column value.</value>
	public string UserName
	{
		get
		{
			if(IsUserNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _userName;
		}
		set
		{
			_userNameNull = false;
			_userName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="UserName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUserNameNull
	{
		get
		{
			return _userNameNull;
		}
		set
		{
			_userNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Quantity</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Quantity</c> column value.</value>
	public decimal Quantity
	{
		get
		{
			if (IsQuantityNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _quantity;
		}
		set
		{
			_quantityNull = false;
			_quantity = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Quantity"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsQuantityNull
	{
		get
		{
			return _quantityNull;
		}
		set
		{
			_quantityNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Price</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Price</c> column value.</value>
	public decimal Price
	{
		get
		{
			if (IsPriceNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _price;
		}
		set
		{
			_priceNull = false;
			_price = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Price"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsPriceNull
	{
		get
		{
			return _priceNull;
		}
		set
		{
			_priceNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>SumMoney</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>SumMoney</c> column value.</value>
	public decimal SumMoney
	{
		get
		{
			if (IsSumMoneyNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _sumMoney;
		}
		set
		{
			_sumMoneyNull = false;
			_sumMoney = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="SumMoney"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsSumMoneyNull
	{
		get
		{
			return _sumMoneyNull;
		}
		set
		{
			_sumMoneyNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ShopName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ShopName</c> column value.</value>
	public string ShopName
	{
		get
		{
			if(IsShopNameNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _shopName;
		}
		set
		{
			_shopNameNull = false;
			_shopName = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ShopName"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsShopNameNull
	{
		get
		{
			return _shopNameNull;
		}
		set
		{
			_shopNameNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ShopAddress</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ShopAddress</c> column value.</value>
	public string ShopAddress
	{
		get
		{
			if(IsShopAddressNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _shopAddress;
		}
		set
		{
			_shopAddressNull = false;
			_shopAddress = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ShopAddress"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsShopAddressNull
	{
		get
		{
			return _shopAddressNull;
		}
		set
		{
			_shopAddressNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Amount</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Amount</c> column value.</value>
	public decimal Amount
	{
		get
		{
			if (IsAmountNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _amount;
		}
		set
		{
			_amountNull = false;
			_amount = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Amount"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsAmountNull
	{
		get
		{
			return _amountNull;
		}
		set
		{
			_amountNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>HarvestDayRemain</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HarvestDayRemain</c> column value.</value>
	public int HarvestDayRemain
	{
		get
		{
			if (IsHarvestDayRemainNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _harvestDayRemain;
		}
		set
		{
			_harvestDayRemainNull = false;
			_harvestDayRemain = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="HarvestDayRemain"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHarvestDayRemainNull
	{
		get
		{
			return _harvestDayRemainNull;
		}
		set
		{
			_harvestDayRemainNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>HarvestVolume</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HarvestVolume</c> column value.</value>
	public decimal HarvestVolume
	{
		get
		{
			if (IsHarvestVolumeNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _harvestVolume;
		}
		set
		{
			_harvestVolumeNull = false;
			_harvestVolume = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="HarvestVolume"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsHarvestVolumeNull
	{
		get
		{
			return _harvestVolumeNull;
		}
		set
		{
			_harvestVolumeNull = value;
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
		/// Gets or sets the <c>Risk</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Risk</c> column value.</value>
	public string Risk
	{
		get
		{
			if(IsRiskNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _risk;
		}
		set
		{
			_riskNull = false;
			_risk = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Risk"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsRiskNull
	{
		get
		{
			return _riskNull;
		}
		set
		{
			_riskNull = value;
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
		/// Gets or sets the <c>Staff_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Staff_ID</c> column value.</value>
	public string Staff_ID
	{
		get
		{
			if(IsStaff_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _staff_ID;
		}
		set
		{
			_staff_IDNull = false;
			_staff_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Staff_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStaff_IDNull
	{
		get
		{
			return _staff_IDNull;
		}
		set
		{
			_staff_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Material_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Material_ID</c> column value.</value>
	public int Material_ID
	{
		get
		{
			if (IsMaterial_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _material_ID;
		}
		set
		{
			_material_IDNull = false;
			_material_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Material_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsMaterial_IDNull
	{
		get
		{
			return _material_IDNull;
		}
		set
		{
			_material_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>StartingPoint</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StartingPoint</c> column value.</value>
	public string StartingPoint
	{
		get
		{
			if(IsStartingPointNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _startingPoint;
		}
		set
		{
			_startingPointNull = false;
			_startingPoint = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="StartingPoint"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsStartingPointNull
	{
		get
		{
			return _startingPointNull;
		}
		set
		{
			_startingPointNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Destination</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Destination</c> column value.</value>
	public string Destination
	{
		get
		{
			if(IsDestinationNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _destination;
		}
		set
		{
			_destinationNull = false;
			_destination = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Destination"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsDestinationNull
	{
		get
		{
			return _destinationNull;
		}
		set
		{
			_destinationNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Transporter_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Transporter_ID</c> column value.</value>
	public int Transporter_ID
	{
		get
		{
			if (IsTransporter_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _transporter_ID;
		}
		set
		{
			_transporter_IDNull = false;
			_transporter_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Transporter_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTransporter_IDNull
	{
		get
		{
			return _transporter_IDNull;
		}
		set
		{
			_transporter_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>ProductItem_ID_List</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ProductItem_ID_List</c> column value.</value>
	public string ProductItem_ID_List
	{
		get
		{
			if(IsProductItem_ID_ListNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _productItem_ID_List;
		}
		set
		{
			_productItem_ID_ListNull = false;
			_productItem_ID_List = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="ProductItem_ID_List"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsProductItem_ID_ListNull
	{
		get
		{
			return _productItem_ID_ListNull;
		}
		set
		{
			_productItem_ID_ListNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Warehouse_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Warehouse_ID</c> column value.</value>
	public int Warehouse_ID
	{
		get
		{
			if (IsWarehouse_IDNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _warehouse_ID;
		}
		set
		{
			_warehouse_IDNull = false;
			_warehouse_ID = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Warehouse_ID"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWarehouse_IDNull
	{
		get
		{
			return _warehouse_IDNull;
		}
		set
		{
			_warehouse_IDNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Weather</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Weather</c> column value.</value>
	public string Weather
	{
		get
		{
			if(IsWeatherNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _weather;
		}
		set
		{
			_weatherNull = false;
			_weather = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Weather"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsWeatherNull
	{
		get
		{
			return _weatherNull;
		}
		set
		{
			_weatherNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Comment</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Comment</c> column value.</value>
	public string Comment
	{
		get
		{
			if(IsCommentNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _comment;
		}
		set
		{
			_commentNull = false;
			_comment = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Comment"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsCommentNull
	{
		get
		{
			return _commentNull;
		}
		set
		{
			_commentNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>Unit</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Unit</c> column value.</value>
	public string Unit
	{
		get
		{
			if(IsUnitNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _unit;
		}
		set
		{
			_unitNull = false;
			_unit = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="Unit"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsUnitNull
	{
		get
		{
			return _unitNull;
		}
		set
		{
			_unitNull = value;
		}	
	}

		/// <summary>
		/// Gets or sets the <c>TaskStepAnswer_ID_List</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>TaskStepAnswer_ID_List</c> column value.</value>
	public string TaskStepAnswer_ID_List
	{
		get
		{
			if(IsTaskStepAnswer_ID_ListNull)
				throw new InvalidOperationException("Cannot get value because it is DBNull.");
			return _taskStepAnswer_ID_List;
		}
		set
		{
			_taskStepAnswer_ID_ListNull = false;
			_taskStepAnswer_ID_List = value;
		}
	}

	/// <summary>
	/// Indicates whether the <see cref="TaskStepAnswer_ID_List"/>
	/// property value is null.
	/// </summary>
	/// <value>true if the property value is null, otherwise false.</value>
	public bool IsTaskStepAnswer_ID_ListNull
	{
		get
		{
			return _taskStepAnswer_ID_ListNull;
		}
		set
		{
			_taskStepAnswer_ID_ListNull = value;
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
		// Task_ID
		dynStr.Append("  Task_ID=");
		if( IsTask_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Task_ID);
		

		// ProductBrand_ID
		dynStr.Append("  ProductBrand_ID=");
		if( IsProductBrand_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductBrand_ID);
		// Product_ID
		dynStr.Append("  Product_ID=");
		if( IsProduct_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Product_ID);
		// ProductPackage_ID
		dynStr.Append("  ProductPackage_ID=");
		if( IsProductPackage_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.ProductPackage_ID);
		// Workshop_ID
		dynStr.Append("  Workshop_ID=");
		if( IsWorkshop_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Workshop_ID);
		// Farm_ID
		dynStr.Append("  Farm_ID=");
		if( IsFarm_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Farm_ID);
		// Customer_ID
		dynStr.Append("  Customer_ID=");
		if( IsCustomer_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Customer_ID);
		// TaskType_ID
		dynStr.Append("  TaskType_ID=");
		if( IsTaskType_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TaskType_ID);
		// TaskStep_ID
		dynStr.Append("  TaskStep_ID=");
		if( IsTaskStep_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TaskStep_ID);
		// TaskStatus_ID
		dynStr.Append("  TaskStatus_ID=");
		if( IsTaskStatus_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.TaskStatus_ID);
		// Name
		dynStr.Append("  Name=");
		if( IsNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Name);
		

		// ProductName
		dynStr.Append("  ProductName=");
		if( IsProductNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductName);
		

		// ProductPackageName
		dynStr.Append("  ProductPackageName=");
		if( IsProductPackageNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductPackageName);
		

		// CustomerName
		dynStr.Append("  CustomerName=");
		if( IsCustomerNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.CustomerName);
		

		// Description
		dynStr.Append("  Description=");
		if( IsDescriptionNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Description);
		

		// PersonStaff
		dynStr.Append("  PersonStaff=");
		if( IsPersonStaffNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.PersonStaff);
		

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
		// WorkEvaluating
		dynStr.Append("  WorkEvaluating=");
		if( IsWorkEvaluatingNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.WorkEvaluating);
		

		// Location
		dynStr.Append("  Location=");
		if( IsLocationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Location);
		

		// BuyerName
		dynStr.Append("  BuyerName=");
		if( IsBuyerNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.BuyerName);
		

		// UserName
		dynStr.Append("  UserName=");
		if( IsUserNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.UserName);
		

		// Quantity
		dynStr.Append("  Quantity=");
		if( IsQuantityNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Quantity);
		// Price
		dynStr.Append("  Price=");
		if( IsPriceNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Price);
		// SumMoney
		dynStr.Append("  SumMoney=");
		if( IsSumMoneyNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.SumMoney);
		// ShopName
		dynStr.Append("  ShopName=");
		if( IsShopNameNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ShopName);
		

		// ShopAddress
		dynStr.Append("  ShopAddress=");
		if( IsShopAddressNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ShopAddress);
		

		// Amount
		dynStr.Append("  Amount=");
		if( IsAmountNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Amount);
		// HarvestDayRemain
		dynStr.Append("  HarvestDayRemain=");
		if( IsHarvestDayRemainNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.HarvestDayRemain);
		// HarvestVolume
		dynStr.Append("  HarvestVolume=");
		if( IsHarvestVolumeNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.HarvestVolume);
		// Note
		dynStr.Append("  Note=");
		if( IsNoteNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Note);
		

		// Risk
		dynStr.Append("  Risk=");
		if( IsRiskNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Risk);
		

		// Image
		dynStr.Append("  Image=");
		if( IsImageNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Image);
		

		// Staff_ID
		dynStr.Append("  Staff_ID=");
		if( IsStaff_IDNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Staff_ID);
		

		// Material_ID
		dynStr.Append("  Material_ID=");
		if( IsMaterial_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Material_ID);
		// StartingPoint
		dynStr.Append("  StartingPoint=");
		if( IsStartingPointNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.StartingPoint);
		

		// Destination
		dynStr.Append("  Destination=");
		if( IsDestinationNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Destination);
		

		// Transporter_ID
		dynStr.Append("  Transporter_ID=");
		if( IsTransporter_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Transporter_ID);
		// ProductItem_ID_List
		dynStr.Append("  ProductItem_ID_List=");
		if( IsProductItem_ID_ListNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.ProductItem_ID_List);
		

		// Warehouse_ID
		dynStr.Append("  Warehouse_ID=");
		if( IsWarehouse_IDNull)
		{
			dynStr.Append("<NULL>");
		}
		else
			dynStr.Append(this.Warehouse_ID);
		// Weather
		dynStr.Append("  Weather=");
		if( IsWeatherNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Weather);
		

		// Comment
		dynStr.Append("  Comment=");
		if( IsCommentNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Comment);
		

		// Unit
		dynStr.Append("  Unit=");
		if( IsUnitNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.Unit);
		

		// TaskStepAnswer_ID_List
		dynStr.Append("  TaskStepAnswer_ID_List=");
		if( IsTaskStepAnswer_ID_ListNull)
			dynStr.Append("<NULL>");
		else
			dynStr.Append(this.TaskStepAnswer_ID_List);
		

		return dynStr.ToString();
	}
}
}




