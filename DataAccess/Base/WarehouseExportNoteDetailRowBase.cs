
// <fileinfo name="Base\WarehouseExportNoteDetailRowBase.cs">
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
    /// The base class for <see cref="WarehouseExportNoteDetailRow"/> that 
    /// represents a record in the <c>WarehouseExportNoteDetail</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseExportNoteDetailRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseExportNoteDetailRowBase
    {
        /// _WarehouseExportNoteDetailID
        private int _WarehouseExportNoteDetailID;
        private bool _WarehouseExportNoteDetailIDNull = true;
        /// _WarehouseExportNoteID
        private int _WarehouseExportNoteID;
        private bool _WarehouseExportNoteIDNull = true;
        /// _productName
        private string _productName;
        private bool _productName_IDNull = true;
        /// _productSku
        private string _productSku;
        private bool _productSkuNull = true;
        /// _productSkuEffect
        private string _productSkuEffect;
        private bool _isProductSkuEffectNull = true;
        /// _productNumber
        private int _productNumber;
        private bool _productNumberNull = true;
        /// _productNumberReal
        private int _productNumberReal;
        private bool _productNumberRealNull = true;
        /// _ProductPriority
        private int _ProductPriority;
        private bool _ProductPriorityNull = true;
        /// _unit
        private string _unit;
        private bool _unitNull = true;
        /// _weight
        private string _weight;
        private bool _weightNull = true;
        /// _weightReal
        private string _weightReal;
        private bool _weightRealNull = true;
        /// _createDate
        private System.DateTime _createdDate;
        private bool _createdDateNull = true;
        /// _Other1
        private string _Other1;
        private bool _Other1Null = true;
        /// _Other2
        private string _Other2;
        private bool _Other2Null = true;
        /// _Other3
        private string _Other3;
        private bool _Other3Null = true;


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseExportNoteDetailRowBase"/> class.
        /// </summary>
        public WarehouseExportNoteDetailRowBase() : base()
        {
            // EMPTY
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

        public int WarehouseExportNoteDetailID
        {
            get
            {
                if (IsWarehouseExportNoteDetailIDNull)
                    return 0;
                return _WarehouseExportNoteDetailID;
            }
            set
            {
                _WarehouseExportNoteDetailIDNull = false;
                _WarehouseExportNoteDetailID = value;
            }
        }
        public bool IsWarehouseExportNoteDetailIDNull { get => _WarehouseExportNoteDetailIDNull; set => _WarehouseExportNoteDetailIDNull = value; }
        public int WarehouseExportNoteID
        {
            get
            {
                if (IsWarehouseExportNoteIDNull)
                    return 0;
                return _WarehouseExportNoteID;
            }
            set
            {
                _WarehouseExportNoteIDNull = false;
                _WarehouseExportNoteID = value;
            }
        }
        public bool IsWarehouseExportNoteIDNull { get => _WarehouseExportNoteIDNull; set => _WarehouseExportNoteIDNull = value; }
        
        public string ProductName
        {
            get
            {
                if (IsProductName_IDNull)
                    return null;
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
                    return null;
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
                    return 0;
                return _productNumber;
            }
            set
            {
                _productNumberNull = false;
                _productNumber = value;
            }
        }
        public bool IsProductNumberNull { get => _productNumberNull; set => _productNumberNull = value; }
        public int ProductNumberReal
        {
            get
            {
                if (IsProductNumberRealNull)
                    return 0;
                return _productNumberReal;
            }
            set
            {
                _productNumberRealNull = false;
                _productNumberReal = value;
            }
        }
        public bool IsProductNumberRealNull { get => _productNumberRealNull; set => _productNumberRealNull = value; }
        public int ProductPriority
        {
            get
            {
                if (IsProductPriorityNull)
                    return 0;
                return _ProductPriority;
            }
            set
            {
                _ProductPriorityNull = false;
                _ProductPriority = value;
            }
        }
        public bool IsProductPriorityNull { get => _ProductPriorityNull; set => _ProductPriorityNull = value; }
        public string Unit
        {
            get
            {
                if (IsUnitNull)
                    return null;
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
                    return null;
                return _weight;
            }
            set
            {
                _weightNull = false;
                _weight = value;
            }
        }
        public bool IsWeightNull { get => _weightNull; set => _weightNull = value; }
        public string WeightReal
        {
            get
            {
                if (IsWeightRealNull)
                    return null;
                return _weightReal;
            }
            set
            {
                _weightRealNull = false;
                _weightReal = value;
            }
        }
        public bool IsWeightRealNull { get => _weightRealNull; set => _weightRealNull = value; }
        public string ProductSkuEffect
        {
            get
            {
                if (IsProductSkuEffectNull)
                    return null;
                return _productSkuEffect;
            }
            set
            {
                _isProductSkuEffectNull = false;
                _productSkuEffect = value;
            }
        }
        public bool IsProductSkuEffectNull { get => _isProductSkuEffectNull; set => _isProductSkuEffectNull = value; }
        public string Other1
        {
            get
            {
                if (IsOther1Null)
                    return null;
                return _Other1;
            }
            set
            {
                _Other1Null = false;
                _Other1 = value;
            }
        }
        public bool IsOther1Null { get => _Other1Null; set => _Other1Null = value; }
        public string Other2
        {
            get
            {
                if (IsOther2Null)
                    return null;
                return _Other2;
            }
            set
            {
                _Other2Null = false;
                _Other2 = value;
            }
        }
        public bool IsOther2Null { get => _Other2Null; set => _Other2Null = value; }
        public string Other3
        {
            get
            {
                if (IsOther3Null)
                    return null;
                return _Other3;
            }
            set
            {
                _Other3Null = false;
                _Other3 = value;
            }
        }
        public bool IsOther3Null { get => _Other3Null; set => _Other3Null = value; }



        /// <summary>
        /// Returns the string representation of this instance.
        /// </summary>
        /// <returns>The string representation of this instance.</returns>
        public override string ToString()
        {
            System.Text.StringBuilder dynStr = new System.Text.StringBuilder(this.GetType().Name);
            dynStr.Append(":");
            // WarehouseExportNoteDetailID
            dynStr.Append("  WarehouseExportNoteDetailID=");
            if (IsWarehouseExportNoteDetailIDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.WarehouseExportNoteDetailID);


            // WarehouseExportNoteID
            dynStr.Append("  WarehouseExportNoteID=");
            if (IsWarehouseExportNoteIDNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.WarehouseExportNoteID);
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
            // ProductNumberReal
            dynStr.Append("  ProductNumberReal=");
            if (IsProductNumberRealNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.ProductNumberReal);
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
            // WeightReal
            dynStr.Append("  WeightReal=");
            if (IsWeightRealNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.WeightReal);
            // CreatedDate
            dynStr.Append("  CreatedDate=");
            if (IsCreatedDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CreatedDate);
            return dynStr.ToString();
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
        }
    }
}




