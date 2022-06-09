
// <fileinfo name="Base\WarehouseExportNoteRowBase.cs">
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
    /// The base class for <see cref="WarehouseExportNoteRow"/> that 
    /// represents a record in the <c>WarehouseExportNote</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseExportNoteRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseExportNoteRowBase
    {
        /// _WarehouseExportNote_ID
        private int _WarehouseExportNote_ID;
        private bool _WarehouseExportNote_IDNull = true;
        /// _productBrand_ID
        private int _productBrand_ID;
        private bool _productBrand_IDNull = true;
        /// _warehouse_ID
        private int _warehouse_ID;
        private bool _warehouse_IDNull = true;
        /// _productBIll_ID
        private string _productBIll_ID;
        private bool _productBIll_IDNull = true;
        /// _exportNoteCode
        private string _exportNoteCode;
        private bool _exportNoteCodeNull = true;
        /// _exportDate
        private DateTime _exportDate;
        private bool _exportDateNull = true;
        /// _CustomerName
        private string _CustomerName;
        private bool _CustomerNameNull = true;
        /// _CustomerAddress
        private string _CustomerAddress;
        private bool _CustomerAddressNull = true;
        /// _description
        private string _description;
        private bool _descriptionNull = true;
        /// _Warehouser
        private string _Warehouser;
        private bool _WarehouserNull = true;
        /// _other1
        private string _other1;
        private bool _other1Null = true;
        /// _warehouser
        private string _other2;
        private bool _other2Null = true;
        /// _warehouser
        private string _other3;
        private bool _other3Null = true;
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


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseExportNoteRowBase"/> class.
        /// </summary>
        public WarehouseExportNoteRowBase() : base()
        {
            // EMPTY
        }

        /// <summary>
        /// Gets or sets the <c>WarehouseExportNote_ID</c> column value.
        /// </summary>
        /// <value>The <c>WarehouseExportNote_ID</c> column value.</value>
        public int WarehouseExportNote_ID
        {
            get
            {
                if (IsWarehouseExportNote_IDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _WarehouseExportNote_ID;
            }
            set
            {
                _WarehouseExportNote_IDNull = false;
                _WarehouseExportNote_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="WarehouseExportNote_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsWarehouseExportNote_IDNull
        {
            get
            {
                return _WarehouseExportNote_IDNull;
            }
            set
            {
                _WarehouseExportNote_IDNull = value;
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
        public string ProductBIll_ID
        {
            get
            {
                if (IsProductBIll_IDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _productBIll_ID;
            }
            set
            {
                _productBIll_IDNull = false;
                _productBIll_ID = value;
            }
        }
        public bool IsProductBIll_IDNull { get => _productBIll_IDNull; set => _productBIll_IDNull = value; }
        public string ExportNoteCode
        {
            get
            {
                if (IsExportNoteCodeNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _exportNoteCode;
            }
            set
            {
                _exportNoteCodeNull = false;
                _exportNoteCode = value;
            }
        }
        public bool IsExportNoteCodeNull { get => _exportNoteCodeNull; set => _exportNoteCodeNull = value; }
        public DateTime ExportDate
        {
            get
            {
                if (IsExportDateNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _exportDate;
            }
            set
            {
                _exportDateNull = false;
                _exportDate = value;
            }
        }
        public bool IsExportDateNull { get => _exportDateNull; set => _exportDateNull = value; }
        public string CustomerName
        {
            get
            {
                if (IsCustomerNameNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _CustomerName;
            }
            set
            {
                _CustomerNameNull = false;
                _CustomerName = value;
            }
        }
        public bool IsCustomerNameNull { get => _CustomerNameNull; set => _CustomerNameNull = value; }
        public string CustomerAddress
        {
            get
            {
                if (IsCustomerAddressNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _CustomerAddress;
            }
            set
            {
                _CustomerAddressNull = false;
                _CustomerAddress = value;
            }
        }
        public bool IsCustomerAddressNull { get => _CustomerAddressNull; set => _CustomerAddressNull = value; }
        public string Warehouser
        {
            get
            {
                if (IsWarehouserNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _Warehouser;
            }
            set
            {
                _WarehouserNull = false;
                _Warehouser = value;
            }
        }
        public bool IsWarehouserNull { get => _WarehouserNull; set => _WarehouserNull = value; }

        /// <summary>
        /// Returns the string representation of this instance.
        /// </summary>
        /// <returns>The string representation of this instance.</returns>
        public override string ToString()
        {
            System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
            dynStr.Append(":");
            // WarehouseExportNote_ID
            dynStr.Append("  WarehouseExportNote_ID=");
            if (IsWarehouseExportNote_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.WarehouseExportNote_ID);


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
            // ProductBIll_ID
            dynStr.Append("  ProductBIll_ID=");
            if (IsProductBIll_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductBIll_ID);
            // ExportNoteCode
            dynStr.Append("  ExportNoteCode=");
            if (IsExportNoteCodeNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ExportNoteCode);
            // ExportDate
            dynStr.Append("  ExportDate=");
            if (IsExportDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ExportDate);
            // CustomerName
            dynStr.Append("  CustomerName=");
            if (IsCustomerNameNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CustomerName);
            // CustomerAddress
            dynStr.Append("  CustomerAddress=");
            if (IsCustomerAddressNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CustomerAddress);
            // Description
            dynStr.Append("  Description=");
            if (IsDescriptionNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Description);
            // Warehouser
            dynStr.Append("  Warehouser=");
            if (IsWarehouserNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Warehouser);
            
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




