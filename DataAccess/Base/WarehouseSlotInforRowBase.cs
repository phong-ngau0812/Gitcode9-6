
// <fileinfo name="Base\WarehouseSlotInforRowBase.cs">
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
    /// The base class for <see cref="WarehouseSlotInforRow"/> that 
    /// represents a record in the <c>WarehouseSlotInfor</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseSlotInforRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseSlotInforRowBase
    {
        /// _slot_ID
        private int _slot_ID;
        private bool _slot_IDNull = true;
        /// _slotInfor_ID
        private int _slotInfor_ID;
        private bool _slotInfor_IDNull = true;
        /// _productSku
        private string _productSku;
        private bool _productSkuNull = true;
        /// _productSkuEffect
        private string _productSkuEffect;
        private bool _productSkuEffectNull = true;
        /// _amount
        private int _amount;
        private bool _amountNull = true;
        /// _createDate
        private System.DateTime _createdDate;
        private bool _createdDateNull = true;
        /// _editDate
        private System.DateTime _editDate;
        private bool _editDateNull = true;
        /// _ProductPartNumber
        private string _ProductPartNumber;
        private bool _ProductPartNumberNull = true;
        /// _ProductPartDetail
        private string _ProductPartDetail;
        private bool _ProductPartDetailNull = true;
        /// _other1
        private string _other1;
        private bool _other1Null = true;
        /// _other2
        private string _other2;
        private bool _other2Null = true;
        /// _other3
        private string _other3;
        private bool _other3Null = true;
        /// _other3
        private int _isOldProduct;
        private bool _isOldProductNull = true; 


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseSlotInforRowBase"/> class.
        /// </summary>
        public WarehouseSlotInforRowBase() : base()
        {
            // EMPTY
        }

        /// <summary>
        /// Gets or sets the <c>Slot_ID</c> column value.
        /// </summary>
        /// <value>The <c>Slot_ID</c> column value.</value>
        public int Slot_ID
        {
            get
            {
                if (IsSlot_IDNull)
                    return 0;
                return _slot_ID;
            }
            set
            {
                _slot_IDNull = false;
                _slot_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Slot_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsSlot_IDNull
        {
            get
            {
                return _slot_IDNull;
            }
            set
            {
                _slot_IDNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>SlotInfor_ID</c> column value.
        /// </summary>
        /// <value>The <c>SlotInfor_ID</c> column value.</value>
        public int SlotInfor_ID
        {
            get
            {
                if (IsSlotInfor_IDNull)
                    return 0;
                return _slotInfor_ID;
            }
            set
            {
                _slotInfor_IDNull = false;
                _slotInfor_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="SlotInfor_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsSlotInfor_IDNull
        {
            get
            {
                return _slotInfor_IDNull;
            }
            set
            {
                _slotInfor_IDNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>Amount</c> column value.
        /// </summary>
        /// <value>The <c>Amount</c> column value.</value>
        public int Amount
        {
            get
            {
                if (IsAmountNull)
                    return 0;
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
        /// Gets or sets the <c>Code</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>Code</c> column value.</value>
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

        /// <summary>
        /// Indicates whether the <see cref="ProductSku"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductSkuNull
        {
            get
            {
                return _productSkuNull;
            }
            set
            {
                _productSkuNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>FloorName</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
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
                _productSkuEffectNull = false;
                _productSkuEffect = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="ProductSkuEffect"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductSkuEffectNull
        {
            get
            {
                return _productSkuEffectNull;
            }
            set
            {
                _productSkuEffectNull = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>CreateDate</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>CreateDate</c> column value.</value>
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

        /// <summary>
        /// Gets or sets the <c>LastEditDate</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>LastEditDate</c> column value.</value>
        public System.DateTime EditDate
        {
            get
            {
                if (IsEditDateNull)
                    return DateTime.Now;
                return _editDate;
            }
            set
            {
                _editDateNull = false;
                _editDate = value;
            }
        }
        /// <summary>
        /// Indicates whether the <see cref="EditDate"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsEditDateNull
        {
            get
            {
                return _editDateNull;
            }
            set
            {
                _editDateNull = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>Other1</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
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

        /// <summary>
        /// Indicates whether the <see cref="Other1"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductPartNumberNull
        {
            get
            {
                return _ProductPartNumberNull;
            }
            set
            {
                _ProductPartNumberNull = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>Other1</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
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

        /// <summary>
        /// Indicates whether the <see cref="Other1"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductPartDetailNull
        {
            get
            {
                return _ProductPartDetailNull;
            }
            set
            {
                _ProductPartDetailNull = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>Other1</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string Other1
        {
            get
            {
                if (IsOther1Null)
                    return null;
                return _other1;
            }
            set
            {
                _other1Null = false;
                _other1 = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Other1"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsOther1Null
        {
            get
            {
                return _other1Null;
            }
            set
            {
                _other1Null = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>Other2</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string Other2
        {
            get
            {
                if (IsOther2Null)
                    return null;
                return _other2;
            }
            set
            {
                _other2Null = false;
                _other2 = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Other2"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsOther2Null
        {
            get
            {
                return _other2Null;
            }
            set
            {
                _other2Null = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>Other3</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string Other3
        {
            get
            {
                if (IsOther3Null)
                    return null;
                return _other3;
            }
            set
            {
                _other3Null = false;
                _other3 = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Other3"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsOther3Null
        {
            get
            {
                return _other3Null;
            }
            set
            {
                _other3Null = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>Other3</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public int IsOldProduct
        {
            get
            {
                if (IsOldProductNull)
                    return 0;
                return _isOldProduct;
            }
            set
            {
                _isOldProductNull = false;
                _isOldProduct = value;
            }
        }
        /// <summary>
        /// Indicates whether the <see cref="Other3"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsOldProductNull
        {
            get
            {
                return _isOldProductNull;
            }
            set
            {
                _isOldProductNull = value;
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
            // Slot_ID
            dynStr.Append("  Slot_ID=");
            if (IsSlot_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Slot_ID);


            // SlotInfor_ID
            dynStr.Append("  SlotInfor_ID=");
            if (IsSlotInfor_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.SlotInfor_ID);


            // Amount
            dynStr.Append("  Amount=");
            if (IsAmountNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Amount);


            // ProductSku
            dynStr.Append("  ProductSku=");
            if (IsProductSkuNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductSku);


            // ProductSkuEffect
            dynStr.Append("  ProductSkuEffect=");
            if (IsProductSkuEffectNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductSkuEffect);
            // CreateDate
            dynStr.Append("  CreatedDate=");
            if (IsCreatedDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.CreatedDate);
            // LastEditDate
            dynStr.Append("  EditDate=");
            if (IsEditDateNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.EditDate);
            return dynStr.ToString();
            // ProductPartNumber
            dynStr.Append("  ProductPartNumber=");
            if (IsOther1Null)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductPartNumber);
            // ProductPartDetail
            dynStr.Append("  ProductPartDetail=");
            if (IsOther1Null)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductPartDetail);
            // Other1
            dynStr.Append("  Other1=");
            if (IsOther1Null)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Other1);
            // Other2
            dynStr.Append("  Other2=");
            if (IsOther2Null)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Other2);
            // Other3
            dynStr.Append("  Other3=");
            if (IsOther3Null)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Other3);
            // IsOldProduct
            dynStr.Append("  IsOldProduct=");
            if (IsOldProductNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.IsOldProduct);
        }
    }
}




