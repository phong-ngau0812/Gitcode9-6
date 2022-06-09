
// <fileinfo name="Base\WarehouseImportNoteRowBase.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" >Smc SaleFrame1.0</generator>
// </fileinfo>

using DbObj;
using System;

namespace Base
{

    /// <summary>
    /// The base class for <see cref="WarehouseImportNoteRow"/> that 
    /// represents a record in the <c>WarehouseImportNote</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseImportNoteRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseImportNoteRowBase
    {
        /// _WarehouseImportNote_ID
        private int _WarehouseImportNote_ID;
        private bool _WarehouseImportNote_IDNull = true;
        /// _productBrand_ID
        private int _productBrand_ID;
        private bool _productBrand_IDNull = true;
        /// _warehouse_ID
        private int _warehouse_ID;
        private bool _warehouse_IDNull = true;
        /// _WarehouseImportNoteType_ID
        private int _WarehouseImportNoteType_ID;
        private bool _WarehouseImportNoteType_IDNull = true;
        /// _product_ID
        private int _product_ID;
        private bool _product_IDNull = true;
        /// _productPackage_ID
        private int _productPackage_ID;
        private bool _productPackage_IDNull = true;
        /// _productPackageOrder_ID
        private int _productPackageOrder_ID;
        private bool _productPackageOrder_IDNull = true;
        /// _description
        private string _description;
        private bool _descriptionNull = true;
        /// _productType
        private int _productType;
        private bool _productTypeNull = true;
        /// _warehouser
        private string _warehouser;
        private bool _warehouserNull = true;
        /// _positionID
        private int _positionID;
        private bool _positionIDNull = true;
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
        /// _active
        private int _active;
        private bool _activeNull = true;
        /// _warehouseImportNoteCode
        private string _warehouseImportNoteCode;
        private bool _warehouseImportNoteCodeNull = true;
        /// _other1
        private string _other1;
        private bool _other1Null = true;
        /// _warehouser
        private string _other2;
        private bool _other2Null = true;
        /// _warehouser
        private string _other3;
        private bool _other3Null = true;


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseImportNoteRowBase"/> class.
        /// </summary>
        public WarehouseImportNoteRowBase() : base()
        {
            // EMPTY
        }

        /// <summary>
        /// Gets or sets the <c>WarehouseImportNote_ID</c> column value.
        /// </summary>
        /// <value>The <c>WarehouseImportNote_ID</c> column value.</value>
        public int WarehouseImportNote_ID
        {
            get
            {
                if (IsWarehouseImportNote_IDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _WarehouseImportNote_ID;
            }
            set
            {
                _WarehouseImportNote_IDNull = false;
                _WarehouseImportNote_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="WarehouseImportNote_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsWarehouseImportNote_IDNull
        {
            get
            {
                return _WarehouseImportNote_IDNull;
            }
            set
            {
                _WarehouseImportNote_IDNull = value;
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
        /// Gets or sets the <c>WarehouseImportNoteType_ID</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>WarehouseImportNoteType_ID</c> column value.</value>
        public int WarehouseImportNoteType_ID
        {
            get
            {
                if (IsWarehouseImportNoteType_IDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _WarehouseImportNoteType_ID;
            }
            set
            {
                _WarehouseImportNoteType_IDNull = false;
                _WarehouseImportNoteType_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="WarehouseImportNoteType_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsWarehouseImportNoteType_IDNull
        {
            get
            {
                return _WarehouseImportNoteType_IDNull;
            }
            set
            {
                _WarehouseImportNoteType_IDNull = value;
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
        public bool IsProductPackage_IDNull { get => _productPackage_IDNull; set => _productPackage_IDNull = value; }
        public int ProductPackageOrder_ID
        {
            get
            {
                if (IsProductPackageOrder_IDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _productPackageOrder_ID;
            }
            set
            {
                _productPackageOrder_IDNull = false;
                _productPackageOrder_ID = value;
            }
        }
        public bool IsProductPackageOrder_IDNull { get => _productPackageOrder_IDNull; set => _productPackageOrder_IDNull = value; }
        public string Description
        {
            get
            {
                if (IsDescriptionNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _description;
            }
            set
            {
                _descriptionNull = false;
                _description = value;
            }
        }
        public bool IsDescriptionNull { get => _descriptionNull; set => _descriptionNull = value; }
        public int ProductType
        {
            get
            {
                if (IsProductTypeNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _productType;
            }
            set
            {
                _productTypeNull = false;
                _productType = value;
            }
        }
        public bool IsProductTypeNull { get => _productTypeNull; set => _productTypeNull = value; }
        public string Warehouser
        {
            get
            {
                if (IsWarehouserNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _warehouser;
            }
            set
            {
                _warehouserNull = false;
                _warehouser = value;
            }
        }
        public bool IsWarehouserNull { get => _warehouserNull; set => _warehouserNull = value; }
        public int PositionID
        {
            get
            {
                if (IsPositionIDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _positionID;
            }
            set
            {
                _positionIDNull = false;
                _positionID = value;
            }
        }
        public bool IsPositionIDNull { get => _positionIDNull; set => _positionIDNull = value; }
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
                _productBrand_ID = value;
            }
        }
        public bool IsProduct_IDNull { get => _product_IDNull; set => _product_IDNull = value; }
        public string WarehouseImportNoteCode
        {
            get
            {
                if (IsWarehouseImportNoteCodeNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _warehouseImportNoteCode;
            }
            set
            {
                _warehouseImportNoteCodeNull = false;
                _warehouseImportNoteCode = value;
            }
        }
        public bool IsWarehouseImportNoteCodeNull { get => _warehouseImportNoteCodeNull; set => _warehouseImportNoteCodeNull = value; }
        public string Other1
        {
            get
            {
                if (IsOther1Null)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _other1;
            }
            set
            {
                _other1Null = false;
                _other1 = value;
            }
        }
        public bool IsOther1Null { get => _other1Null; set => _other1Null = value; }
        public string Other2
        {
            get
            {
                if (IsOther2Null)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _other2;
            }
            set
            {
                _other2Null = false;
                _other2 = value;
            }
        }
        public bool IsOther2Null { get => _other2Null; set => _other2Null = value; }
        public string Other3
        {
            get
            {
                if (IsOther3Null)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _other3;
            }
            set
            {
                _other3Null = false;
                _other3 = value;
            }
        }
        public bool IsOther3Null
        {
            get => _other3Null; set => _other3Null = value; }

        /// <summary>
        /// Returns the string representation of this instance.
        /// </summary>
        /// <returns>The string representation of this instance.</returns>
        public override string ToString()
        {
            System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
            dynStr.Append(":");
            // WarehouseImportNote_ID
            dynStr.Append("  WarehouseImportNote_ID=");
            if (IsWarehouseImportNote_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.WarehouseImportNote_ID);


            // ProductBrand_ID
            dynStr.Append("  ProductBrand_ID=");
            if (IsProductBrand_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductBrand_ID);
            // Warehouse_ID
            dynStr.Append("  Warehouse_ID=");
            if (IsWarehouse_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Warehouse_ID);
            // WarehouseImportNoteType_ID
            dynStr.Append("  WarehouseImportNoteType_ID=");
            if (IsWarehouseImportNoteType_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.WarehouseImportNoteType_ID);
            // Product_ID
            dynStr.Append("  Product_ID=");
            if (IsProduct_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Product_ID);
            // _productPackage_ID
            dynStr.Append("  ProductPackage_ID=");
            if (IsProductPackage_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductPackage_ID);
            // ProductPackageOrder_ID
            dynStr.Append("  ProductPackageOrder_ID=");
            if (IsProductPackageOrder_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductPackageOrder_ID);
            // Description
            dynStr.Append("  Description=");
            if (IsDescriptionNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Description);
            // ProductType
            dynStr.Append("  ProductType=");
            if (IsProductTypeNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductType);
            // Warehouser
            dynStr.Append("  Warehouser=");
            if (IsWarehouserNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Warehouser);
            // PositionID
            dynStr.Append("  PositionID=");
            if (IsPositionIDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.PositionID);
            // WarehouseImportNoteCode
            dynStr.Append("  WarehouseImportNoteCode=");
            if (IsWarehouseImportNoteCodeNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.WarehouseImportNoteCode);
            // Other1
            dynStr.Append("  Other1=");
            if (IsOther1Null)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Other1);
            // Other2
            dynStr.Append("  Other2=");
            if (IsOther2Null)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Other2);
            // Other3
            dynStr.Append("  Other3=");
            if (IsOther3Null)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Other3);
            // CreateBy
            dynStr.Append("  CreateBy=");
            if (IsCreateByNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CreateBy);
            // CreateDate
            dynStr.Append("  CreateDate=");
            if (IsCreateDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CreateDate);
            // LastEditBy
            dynStr.Append("  LastEditBy=");
            if (IsLastEditByNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.LastEditBy);
            // LastEditDate
            dynStr.Append("  LastEditDate=");
            if (IsLastEditDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.LastEditDate);
            // Active
            dynStr.Append("  Active=");
            if (IsActiveNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Active);
            return dynStr.ToString();
        }
    }
}




