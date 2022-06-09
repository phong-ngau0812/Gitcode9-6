
// <fileinfo name="Base\WarehouseSlotRowBase.cs">
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
    /// The base class for <see cref="WarehouseSlotRow"/> that 
    /// represents a record in the <c>WarehouseSlot</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="WarehouseSlotRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseSlotRowBase
    {
        /// _slot_ID
        private int _slot_ID;
        private bool _slot_IDNull = true;
        /// _rack_ID
        private int _rack_ID;
        private bool _rack_IDNull = true;
        /// _warehouse_ID
        private int _warehouse_ID;
        private bool _warehouse_IDNull = true;
        /// _code
        private string _code;
        private bool _codeNull = true;
        /// _floorName
        private string _floorName;
        private bool _floorNameNull = true;
        /// _slotName
        private string _slotName;
        private bool _slotNameNull = true;
        /// _gln
        private string _gln;
        private bool _glnNull = true;
        /// _type
        private int _type;
        private bool _typeNull = true;
        /// _priority
        private int _priority;
        private bool _priorityNull = true;
        /// _active
        private int _active;
        private bool _activeNull = true;
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


        // Instance fields

        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseSlotRowBase"/> class.
        /// </summary>
        public WarehouseSlotRowBase() : base()
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
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
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
        /// Gets or sets the <c>Rack_ID</c> column value.
        /// </summary>
        /// <value>The <c>Rack_ID</c> column value.</value>
        public int Rack_ID
        {
            get
            {
                if (IsRack_IDNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _rack_ID;
            }
            set
            {
                _rack_IDNull = false;
                _rack_ID = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Rack_ID"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsRack_IDNull
        {
            get
            {
                return _rack_IDNull;
            }
            set
            {
                _rack_IDNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>Warehouse_ID</c> column value.
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
        /// Gets or sets the <c>Code</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>Code</c> column value.</value>
        public string Code
        {
            get
            {
                if (IsCodeNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _code;
            }
            set
            {
                _codeNull = false;
                _code = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Code"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsCodeNull
        {
            get
            {
                return _codeNull;
            }
            set
            {
                _codeNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>FloorName</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>FloorName</c> column value.</value>
        public string FloorName
        {
            get
            {
                if (IsFloorNameNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _floorName;
            }
            set
            {
                _floorNameNull = false;
                _floorName = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="FloorName"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsFloorNameNull
        {
            get
            {
                return _floorNameNull;
            }
            set
            {
                _floorNameNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>SlotName</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>SlotName</c> column value.</value>
        public string SlotName
        {
            get
            {
                if (IsSlotNameNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _slotName;
            }
            set
            {
                _slotNameNull = false;
                _slotName = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="SlotName"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsSlotNameNull
        {
            get
            {
                return _slotNameNull;
            }
            set
            {
                _slotNameNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>GLN</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>GLN</c> column value.</value>
        public string GLN
        {
            get
            {
                if (IsGLNNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _gln;
            }
            set
            {
                _glnNull = false;
                _gln = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="GLN"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsGLNNull
        {
            get
            {
                return _glnNull;
            }
            set
            {
                _glnNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>Type</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>Type</c> column value.</value>
        public int Type
        {
            get
            {
                if (IsTypeNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _type;
            }
            set
            {
                _typeNull = false;
                _type = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Type"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsTypeNull
        {
            get
            {
                return _typeNull;
            }
            set
            {
                _typeNull = value;
            }
        }

        /// <summary>
        /// Gets or sets the <c>priority</c> column value.
        /// This column is nullable.
        /// </summary>
        /// <value>The <c>priority</c> column value.</value>
        public int Priority
        {
            get
            {
                if (IsPriorityNull)
                    throw new InvalidOperationException("Cannot get value because it is DBNull.");
                return _priority;
            }
            set
            {
                _priorityNull = false;
                _priority = value;
            }
        }

        /// <summary>
        /// Indicates whether the <see cref="Priority"/>
        /// property value is null.
        /// </summary>
        /// <value>true if the property value is null, otherwise false.</value>
        public bool IsPriorityNull
        {
            get
            {
                return _priorityNull;
            }
            set
            {
                _priorityNull = value;
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
        public string RackName
        {
            get; set;
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


            // Rack_ID
            dynStr.Append("  Rack_ID=");
            if (IsRack_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Rack_ID);


            // Warehouse_ID
            dynStr.Append("  Warehouse_ID=");
            if (IsWarehouse_IDNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Warehouse_ID);


            // Code
            dynStr.Append("  Code=");
            if (IsCodeNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.Code);


            // FloorName
            dynStr.Append("  FloorName=");
            if (IsFloorNameNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.FloorName);


            // SlotName
            dynStr.Append("  SlotName=");
            if (IsSlotNameNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.SlotName);


            // GLN
            dynStr.Append("  GLN=");
            if (IsGLNNull)
                dynStr.Append("<NULL>");
            else
                dynStr.Append(this.GLN);


            // Type
            dynStr.Append("  Type=");
            if (IsTypeNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Type);
            // Priority
            dynStr.Append("  Priority=");
            if (IsPriorityNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Priority);
            // Active
            dynStr.Append("  Active=");
            if (IsActiveNull)
            {
                dynStr.Append("<NULL>");
            }
            else
                dynStr.Append(this.Active);
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
            return dynStr.ToString();
        }
    }
}




