
// <fileinfo name="Base\WarehouseImportNoteDetailRowBase.cs">
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
    /// The base class for <see cref="WarehouseImportNoteDetailRow"/> that 
    /// represents a record in the <c>WarehouseImportNoteDetail</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseImportNoteDetailRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseImportNoteDetailRowBase
    {
        /// _WarehouseImportNoteDetailID
        private int _WarehouseImportNoteDetailID;
        private bool _WarehouseImportNoteDetailIDNull = true;
        /// _WarehouseImportNoteID
        private int _WarehouseImportNoteID;
        private bool _WarehouseImportNoteIDNull = true;
        /// _product_ID
        private int _product_ID;
        private bool _product_IDNull = true;
        /// _productName
        private string _productName;
        private bool _productName_IDNull = true;
        /// _productSku
        private string _productSku;
        private bool _productSkuNull = true;
        /// _productNumber
        private int _productNumber;
        private bool _productNumberNull = true;
        /// _productSkuEffect
        private string _productSkuEffect;
        private bool _isProductSkuEffectNull = true;
        /// _serialNumberStart
        private string _serialNumberStart;
        private bool __serialNumberStartNull = true;
        /// _serialNumberEnd
        private string _serialNumberEnd;
        private bool __serialNumberEndNull = true;
        /// _color
        private string _color;
        private bool _colorNull = true;
        /// _productPackage_ID
        private int _productPackage_ID;
        private bool _productPackage_IDNull = true;
        /// _maDinhDanh
        private string _productImportType;
        private bool _productImportTypeIsNull = true;
        /// _unit
        private string _unit;
        private bool _unitNull = true;
        /// _weight
        private string _weight;
        private bool _weightNull = true;
        /// _positionID
        private int _positionID;
        private bool _positionIDNull = true;
        /// _supplier
        private string _supplier;
        private bool _supplierNull = true;
        /// _madeIn
        private string _madeIn;
        private bool _madeInNull = true;
        /// _other3
        private string _pallet_ID;
        private bool _pallet_IDIsNull = true;
        /// _other3
        private string _QrCodeWarehousePublic;
        private bool _QrCodeWarehousePublicIsNull = true;
        /// _other3
        private string _ProductPartNumber;
        private bool _ProductPartNumberNull = true;
        /// _other3
        private string _ProductPartDetail;
        private bool _ProductPartDetailNull = true;
        /// _createDate
        private System.DateTime _createdDate;
        private bool _createdDateNull = true;


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseImportNoteDetailRowBase"/> class.
        /// </summary>
        public WarehouseImportNoteDetailRowBase() : base()
        {
            // EMPTY
        }


        public string QrCodeWarehousePublic
        {
            get
            {
                if (IsCreatedDateNull)
                    return "";
                return _QrCodeWarehousePublic;
            }
            set
            {
                QrCodeWarehousePublicNull = false;
                _QrCodeWarehousePublic = value;
            }
        }
        public bool QrCodeWarehousePublicNull
        {
            get
            {
                return _QrCodeWarehousePublicIsNull;
            }
            set
            {
                _QrCodeWarehousePublicIsNull = value;
            }
        }
        public System.DateTime CreatedDate
        {
            get
            {
                if (IsCreatedDateNull)
                    return DateTime.Now;
                return _createdDate;
            }
            set
            {
                _createdDateNull = false;
                _createdDate = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="CreatedDate"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsCreatedDateNull
        {
            get
            {
                return _createdDateNull;
            }
            set
            {
                _createdDateNull = value;
            }
        }

        public int WarehouseImportNoteDetailID
        {
            get
            {
                if (IsWarehouseImportNoteDetailIDNull)
                    return 0;
                return _WarehouseImportNoteDetailID;
            }
            set
            {
                _WarehouseImportNoteDetailIDNull = false;
                _WarehouseImportNoteDetailID = value;
            }
        }
        public bool IsWarehouseImportNoteDetailIDNull { get => _WarehouseImportNoteDetailIDNull; set => _WarehouseImportNoteDetailIDNull = value; }
        public int WarehouseImportNoteID
        {
            get
            {
                if (IsWarehouseImportNoteIDNull)
                    return 0;
                return _WarehouseImportNoteID;
            }
            set
            {
                _WarehouseImportNoteIDNull = false;
                _WarehouseImportNoteID = value;
            }
        }
        public bool IsWarehouseImportNoteIDNull { get => _WarehouseImportNoteIDNull; set => _WarehouseImportNoteIDNull = value; }
        public int Product_ID
        {
            get
            {
                if (IsProduct_IDNull)
                    return 0;
                return _product_ID;
            }
            set
            {
                _product_IDNull = false;
                _product_ID = value;
            }
        }
        public bool IsProduct_IDNull { get => _product_IDNull; set => _product_IDNull = value; }
        public string ProductName
        {
            get
            {
                if (IsProductName_IDNull)
                    return "";
                return _productName;
            }
            set
            {
                _productName_IDNull = false;
                _productName = value;
            }
        }
        public bool IsProductName_IDNull { get => _productName_IDNull; set => _productName_IDNull = value; }
        public string ProductSku
        {
            get
            {
                if (IsProductSkuNull)
                    return "";
                return _productSku;
            }
            set
            {
                _productSkuNull = false;
                _productSku = value;
            }
        }
        public bool IsProductSkuNull { get => _productSkuNull; set => _productSkuNull = value; }
        public int ProductNumber
        {
            get
            {
                if (IsProductNumberNull)
                    return -1;
                return _productNumber;
            }
            set
            {
                _productNumberNull = false;
                _productNumber = value;
            }
        }
        public bool IsProductNumberNull { get => _productNumberNull; set => _productNumberNull = value; }
        public string ProductImportType
        {
            get
            {
                if (IsProductImportTypeNull)
                    return "";
                return _productImportType;
            }
            set
            {
                _productImportTypeIsNull = false;
                _productImportType = value;
            }
        }
        public bool IsProductImportTypeNull { get => _productImportTypeIsNull; set => _productImportTypeIsNull = value; }
        public string Unit
        {
            get
            {
                if (IsUnitNull)
                    return "";
                return _unit;
            }
            set
            {
                _unitNull = false;
                _unit = value;
            }
        }
        public bool IsUnitNull { get => _unitNull; set => _unitNull = value; }
        public string Weight
        {
            get
            {
                if (IsWeightNull)
                    return "";
                return _weight;
            }
            set
            {
                _weightNull = false;
                _weight = value;
            }
        }
        public bool IsWeightNull { get => _weightNull; set => _weightNull = value; }
        public int PositionID
        {
            get
            {
                if (IsPositionIDNull)
                    return -1;
                return _positionID;
            }
            set
            {
                _positionIDNull = false;
                _positionID = value;
            }
        }
        public bool IsPositionIDNull { get => _positionIDNull; set => _positionIDNull = value; }
        public string supplier
        {
            get
            {
                if (IssupplierNull)
                    return "";
                return _supplier;
            }
            set
            {
                _supplierNull = false;
                _supplier = value;
            }
        }
        public bool IssupplierNull { get => _supplierNull; set => _supplierNull = value; }
        public string MadeIn
        {
            get
            {
                if (IsMadeInNull)
                    return "";
                return _madeIn;
            }
            set
            {
                _madeInNull = false;
                _madeIn = value;
            }
        }
        public bool IsMadeInNull { get => _madeInNull; set => _madeInNull = value; }
        public string Pallet_ID
        {
            get
            {
                if (IsPallet_IDNull)
                    return "";
                return _pallet_ID;
            }
            set
            {
                _pallet_IDIsNull = false;
                _pallet_ID = value;
            }
        }
        public bool IsPallet_IDNull { get => _pallet_IDIsNull; set => _pallet_IDIsNull = value; }
        public string ProductSkuEffect
        {
            get
            {
                if (IsProductSkuEffectNull)
                    return "";
                return _productSkuEffect;
            }
            set
            {
                _isProductSkuEffectNull = false;
                _productSkuEffect = value;
            }
        }
        public bool IsProductSkuEffectNull { get => _isProductSkuEffectNull; set => _isProductSkuEffectNull = value; }
        public string SerialNumberStart
        {
            get
            {
                if (IsSerialNumberStartNull)
                    return "";
                return _serialNumberStart;
            }
            set
            {
                __serialNumberStartNull = false;
                _serialNumberStart = value;
            }
        }
        public bool IsSerialNumberStartNull { get => __serialNumberStartNull; set => __serialNumberStartNull = value; }
        public string SerialNumberEnd
        {
            get
            {
                if (IsSerialNumberEndNull)
                    return "";
                return _serialNumberEnd;
            }
            set
            {
                __serialNumberEndNull = false;
                _serialNumberEnd = value;
            }
        }
        public bool IsSerialNumberEndNull { get => __serialNumberEndNull; set => __serialNumberEndNull = value; }
        public string Color
        {
            get
            {
                if (IsColorNull)
                    return "";
                return _color;
            }
            set
            {
                _colorNull = false;
                _color = value;
            }
        }
        public bool IsColorNull { get => _colorNull; set => _colorNull = value; }
        public int ProductPackage_ID
        {
            get
            {
                if (IsProductPackage_IDNull)
                    return -1;
                return _productPackage_ID;
            }
            set
            {
                _productPackage_IDNull = false;
                _productPackage_ID = value;
            }
        }
        public bool IsProductPackage_IDNull { get => _productPackage_IDNull; set => _productPackage_IDNull = value; }
        public string ProductPartNumber
        {
            get
            {
                if (IsProductPartNumberNull)
                    return null;
                return _ProductPartNumber;
            }
            set
            {
                _ProductPartNumberNull = false;
                _ProductPartNumber = value;
            }
        }
        public bool IsProductPartNumberNull { get => _ProductPartNumberNull; set => _ProductPartNumberNull = value; }
        public string ProductPartDetail
        {
            get
            {
                if (IsProductPartDetailNull)
                    return null;
                return _ProductPartDetail;
            }
            set
            {
                _ProductPartDetailNull = false;
                _ProductPartDetail = value;
            }
        }
        public bool IsProductPartDetailNull { get => _ProductPartDetailNull; set => _ProductPartDetailNull = value; }


        /// <summary>
        /// Returns the string representation of this instance.
        /// </summary>
        /// <returns>The string representation of this instance.</returns>
        public override string ToString()
        {
            System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
            dynStr.Append(":");
            // WarehouseImportNoteDetailID
            dynStr.Append("  WarehouseImportNoteDetailID=");
            if (IsWarehouseImportNoteDetailIDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.WarehouseImportNoteDetailID);


            // WarehouseImportNoteID
            dynStr.Append("  WarehouseImportNoteID=");
            if (IsWarehouseImportNoteIDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.WarehouseImportNoteID);
            // ProductName
            dynStr.Append("  ProductName=");
            if (IsProductName_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductName);
            // ProductSku
            dynStr.Append("  ProductSku=");
            if (IsProductSkuNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductSku);
            // ProductNumber
            dynStr.Append("  ProductNumber=");
            if (IsProductNumberNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductNumber);
            // ProductImportType
            dynStr.Append("  ProductImportType=");
            if (IsProductImportTypeNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductImportType);
            // Unit
            dynStr.Append("  Unit=");
            if (IsUnitNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Unit);
            // Weight
            dynStr.Append("  Weight=");
            if (IsWeightNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Weight);
            // PositionID
            dynStr.Append("  PositionID=");
            if (IsPositionIDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.PositionID);
            // supplier
            dynStr.Append("  supplier=");
            if (IssupplierNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.supplier);
            // MadeIn
            dynStr.Append("  MadeIn=");
            if (IsMadeInNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.MadeIn);
            // Pallet_ID
            dynStr.Append("  Pallet_ID=");
            if (IsPallet_IDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Pallet_ID);
            // Pallet_ID
            dynStr.Append("  ProductPartNumber=");
            if (IsProductPartNumberNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductPartNumber);
            // Pallet_ID
            dynStr.Append("  ProductPartDetail=");
            if (IsProductPartDetailNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductPartDetail);
            // CreatedDate
            dynStr.Append("  CreatedDate=");
            if (IsCreatedDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CreatedDate);
            if (QrCodeWarehousePublicNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.QrCodeWarehousePublic);
            return dynStr.ToString();
        }
    }
}




