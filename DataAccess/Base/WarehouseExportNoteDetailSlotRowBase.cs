
// <fileinfo name="Base\WarehouseExportNoteDetailSlotRowBase.cs">
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
    /// The base class for <see cref="WarehouseExportNoteDetailSlotRow"/> that 
    /// represents a record in the <c>WarehouseExportNoteDetailSlot</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseExportNoteDetailSlotRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseExportNoteDetailSlotRowBase
    {
        /// _slot_ID
        private int _slot_ID;
        private bool _slot_IDNull = true;
        /// WarehouseExportNoteDetailSlot_ID
        private int _WarehouseExportNoteDetailSlot_ID;
        private bool _WarehouseExportNoteDetailSlot_IDNull = true;
        /// WarehouseExportNoteDetail_ID
        private int _WarehouseExportNoteDetail_ID;
        private bool _WarehouseExportNoteDetail_IDNull = true;
        /// _amount
        private int _amount;
        private bool _amountNull = true;
        /// _Serial
        private string _Serial;
        private bool _SerialNull = true;
        /// _createDate
        private System.DateTime _createdDate;
        private bool _createdDateNull = true;
        /// _editDate
        private System.DateTime _editDate;
        private bool _editDateNull = true;
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
        private string _productPartNumber;
        private bool _productPartNumberNull = true;
        /// _other3
        private string _productPartDetail_ID;
        private bool _productPartDetail_IDNull = true;
        /// _other3
        private string _slotInfor_ID;
        private bool _slotInfor_IDNull = true;
        /// _other3
        private string _productType_ID;
        private bool _productType_IDNull = true;


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseExportNoteDetailSlotRowBase"/> class.
        /// </summary>
        public WarehouseExportNoteDetailSlotRowBase() : base()
        {
            // EMPTY
        }
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
        public int WarehouseExportNoteDetailSlot_ID
        {
            get
            {
                if (IsWarehouseExportNoteDetailSlot_IDNull)
                    return 0;
                return _WarehouseExportNoteDetailSlot_ID;
            }
            set
            {
                _WarehouseExportNoteDetailSlot_IDNull = false;
                _WarehouseExportNoteDetailSlot_ID = value;
            }
        }
        public bool IsWarehouseExportNoteDetailSlot_IDNull
        {
            get
            {
                return _WarehouseExportNoteDetailSlot_IDNull;
            }
            set
            {
                _WarehouseExportNoteDetailSlot_IDNull = value;
            }
        }
        public int WarehouseExportNoteDetail_ID
        {
            get
            {
                if (IsWarehouseExportNoteDetail_IDNull)
                    return 0;
                return _WarehouseExportNoteDetail_ID;
            }
            set
            {
                _WarehouseExportNoteDetail_IDNull = false;
                _WarehouseExportNoteDetail_ID = value;
            }
        }
        public bool IsWarehouseExportNoteDetail_IDNull
        {
            get
            {
                return _WarehouseExportNoteDetail_IDNull;
            }
            set
            {
                _WarehouseExportNoteDetail_IDNull = value;
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
        public string Other1
        {
            get
            {
                if (IsOther1Null)
                    return "";
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
                    return "";
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
                    return "";
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
        /// Gets or sets the <c>ProductPartDetail_ID</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string ProductPartDetail_ID
        {
            get
            {
                if (IsProductPartDetail_IDNull)
                    return "";
                return _productPartDetail_ID;
            }
            set
            {
                _productPartDetail_IDNull = false;
                _productPartDetail_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="ProductPartDetail_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductPartDetail_IDNull
        {
            get
            {
                return _productPartDetail_IDNull;
            }
            set
            {
                _productPartDetail_IDNull = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>ProductPartNumber</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string ProductPartNumber
        {
            get
            {
                if (IsProductPartNumberNull)
                    return "";
                return _productPartNumber;
            }
            set
            {
                _productPartNumberNull = false;
                _productPartNumber = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="ProductPartNumber"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductPartNumberNull
        {
            get
            {
                return _productPartNumberNull;
            }
            set
            {
                _productPartNumberNull = value;
            }
        }
        /// <summary>
        /// Gets or sets the <c>SlotInfor_ID</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string SlotInfor_ID
        {
            get
            {
                if (IsSlotInfor_IDNull)
                    return "";
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
        /// Gets or sets the <c>ProductType_ID</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string ProductType_ID
        {
            get
            {
                if (IsProductType_IDNull)
                    return "";
                return _productType_ID;
            }
            set
            {
                _productType_IDNull = false;
                _productType_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="ProductType_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsProductType_IDNull
        {
            get
            {
                return _productType_IDNull;
            }
            set
            {
                _productType_IDNull = value;
            }
        }
        public string Serial
        {
            get
            {
                if (IsSerialNull)
                    return null;
                return _Serial;
            }
            set
            {
                _SerialNull = false;
                _Serial = value;
            }
        }
        public bool IsSerialNull
        {
            get
            {
                return _SerialNull;
            }
            set
            {
                _SerialNull = value;
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


            // WarehouseExportNoteDetailSlot_ID
            dynStr.Append("  WarehouseExportNoteDetailSlot_ID=");
            if (IsWarehouseExportNoteDetailSlot_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.WarehouseExportNoteDetailSlot_ID);


            // Amount
            dynStr.Append("  Amount=");
            if (IsAmountNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Amount);


            // WarehouseExportNoteDetail_ID
            dynStr.Append("  WarehouseExportNoteDetail_ID=");
            if (IsWarehouseExportNoteDetail_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.WarehouseExportNoteDetail_ID);
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
            // ProductType_ID
            dynStr.Append("  ProductType_ID=");
            if (IsProductType_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductType_ID);
            // ProductPartDetail_ID
            dynStr.Append("  ProductPartDetail_ID=");
            if (IsProductPartDetail_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductPartDetail_ID);
            // ProductPartNumber
            dynStr.Append("  ProductPartNumber=");
            if (IsProductPartNumberNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.ProductPartNumber);
            // SlotInfor_ID
            dynStr.Append("  SlotInfor_ID=");
            if (IsSlotInfor_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.SlotInfor_ID);
            // Serial
            dynStr.Append("  Serial=");
            if (IsSerialNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Serial);
        }
    }
}




