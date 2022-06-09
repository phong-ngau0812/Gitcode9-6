
// <fileinfo name="Base\WarehouseSlotCollectionBase.cs">
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
using System.Data;
using DbObj;


namespace Base
{

    /// <summary>
    /// The base class for <see cref="WarehouseSlotCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseSlotCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseSlotCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string Slot_IDColumnName = "Slot_ID";
        public const string Rack_IDColumnName = "Rack_ID";
        public const string Warehouse_IDColumnName = "Warehouse_ID";
        public const string CodeColumnName = "Code";
        public const string FloorNameColumnName = "FloorName";
        public const string SlotNameColumnName = "SlotName";
        public const string GLNColumnName = "GLN";
        public const string TypeColumnName = "Type";
        public const string PriorityColumnName = "priority";
        public const string ActiveColumnName = "Active";
        public const string CreateByColumnName = "CreateBy";
        public const string CreateDateColumnName = "CreateDate";
        public const string LastEditByColumnName = "LastEditBy";
        public const string LastEditDateColumnName = "LastEditDate";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseSlotCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseSlot";
        }

        public WarehouseSlotCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseSlot";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseSlotRow"/> objects.</returns>
        public virtual WarehouseSlotRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }
        public virtual WarehouseSlotRow[] GetReadySlot()
        {
            return MapRecords(CreateGetReadSlotCommand());
        }

        protected virtual IDbCommand CreateGetReadSlotCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseSlot_GetReadSlot", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public virtual DataTable GetAllAsDataTable()
        {
            string LOCATION = "GetAllAsDataTable()";
            try
            {
                return MapRecordsToDataTable(CreateGetAllCommand());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        public virtual DataTable GetAllReadyAsDataTable()
        {
            string LOCATION = "GetAllReadyAsDataTable()";
            try
            {
                return MapRecordsToDataTable(CreateGetAllReadyCommand());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        protected virtual IDbCommand CreateGetAllReadyCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseSlot_GetReadySlot", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
        /// to retrieve all records from the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseSlot_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// Gets the first <see cref="WarehouseSlotRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseSlotRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseSlotRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseSlotRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
                if (0 == rows.Length)
                    return null;
                return rows[0];
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Gets an array of <see cref="WarehouseSlotRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseSlotRow"/> objects.</returns>
        public WarehouseSlotRow[] GetAsArray(string whereSql, string orderBySql)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql)";
            IDataReader reader = null;
            try
            {
                reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
                return MapRecords(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Gets an array of <see cref="WarehouseSlotRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example:
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <param name="startIndex">The index of the first record to return.</param>
        /// <param name="length">The number of records to return.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>An array of <see cref="WarehouseSlotRow"/> objects.</returns>
        public virtual WarehouseSlotRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseSlotRow[] rows = MapRecords(reader);
                reader.Close();
                System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
                totalRecordCount = (int)p.Value;
                return rows;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                cmd.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public DataTable GetAsDataTable(string whereSql, string orderBySql)
        {
            string LOCATION = "GetAsDataTable(string whereSql, string orderBySql)";
            IDataReader reader = null;
            try
            {
                reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql));
                return MapRecordsToDataTable(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                _db.Dispose();
            }

        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <param name="startIndex">The index of the first record to return.</param>
        /// <param name="length">The number of records to return.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public virtual DataTable GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsDataTable(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                DataTable table = MapRecordsToDataTable(reader);
                reader.Close();
                System.Data.SqlClient.SqlParameter p = (System.Data.SqlClient.SqlParameter)(cmd.Parameters["@rows"]);
                totalRecordCount = (int)p.Value;
                return table;
            }
            catch (Exception ex)
            {

                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                cmd.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
        {
            string LOCATION = "CreateGetCommand(string whereSql, string orderBySql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_GetAdHoc", CommandType.StoredProcedure);
                _db.AddParameter(cmd, "where", DbType.String, whereSql);
                _db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
        /// <param name="startIndex">The index of the first record to return.</param>
        /// <param name="length">The number of records to return.</param>		
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)
        {
            string LOCATION = "CreateGetCommand(string whereSql, string orderBySql, int startIndex, int length)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_GetPageAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.String, whereSql);
                _db.AddParameter(cmd, "orderby", DbType.String, orderBySql);
                _db.AddParameter(cmd, "startIndex", DbType.Int32, startIndex + 1);
                _db.AddParameter(cmd, "length", DbType.Int32, length);

                IDbDataParameter parameter = _db.AddParameter(cmd, "rows", DbType.Int32, -1);
                parameter.Direction = ParameterDirection.InputOutput;

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }


        /// <summary>
        /// Gets <see cref="WarehouseSlotRow"/> by the primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseSlotRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseSlotRow GetByPrimaryKey(int slot_ID)
        {
            string LOCATION = "GetByPrimaryKey(int slot_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "Slot_ID", slot_ID);
                WarehouseSlotRow[] tempArray = MapRecords(cmd);
                if (0 == tempArray.Length)
                    return null;

                return tempArray[0];
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }



        /// <summary>
        /// Adds a new record into the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseSlotRow value)
        {
            string LOCATION = "Insert(WarehouseSlotRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_Insert", CommandType.StoredProcedure);
                // Rack_ID
                if (value.IsRack_IDNull)
                    AddParameter(cmd, "Rack_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Rack_ID", value.Rack_ID);

                // Warehouse_ID
                if (value.IsWarehouse_IDNull)
                    AddParameter(cmd, "Warehouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);

                // Code
                if (value.IsCodeNull)
                    AddParameter(cmd, "Code", DBNull.Value);
                else
                    AddParameter(cmd, "Code", value.Code);

                // FloorName
                if (value.IsFloorNameNull)
                    AddParameter(cmd, "FloorName", DBNull.Value);
                else
                    AddParameter(cmd, "FloorName", value.FloorName);

                // SlotName
                if (value.IsSlotNameNull)
                    AddParameter(cmd, "SlotName", DBNull.Value);
                else
                    AddParameter(cmd, "SlotName", value.SlotName);

                // GLN
                if (value.IsGLNNull)
                    AddParameter(cmd, "GLN", DBNull.Value);
                else
                    AddParameter(cmd, "GLN", value.GLN);

                // Type
                if (value.IsTypeNull)
                    AddParameter(cmd, "Type", DBNull.Value);
                else
                    AddParameter(cmd, "Type", value.Type);

                // Priority
                if (value.IsPriorityNull)
                    AddParameter(cmd, "Priority", DBNull.Value);
                else
                    AddParameter(cmd, "Priority", value.Priority);

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", value.Active);

                // CreateBy
                if (value.IsCreateByNull)
                    AddParameter(cmd, "CreateBy", DBNull.Value);
                else
                    AddParameter(cmd, "CreateBy", value.CreateBy);

                // CreateDate
                if (value.IsCreateDateNull)
                    AddParameter(cmd, "CreateDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreateDate", value.CreateDate);

                // LastEditBy
                if (value.IsLastEditByNull)
                    AddParameter(cmd, "LastEditBy", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditBy", value.LastEditBy);

                // LastEditDate
                if (value.IsLastEditDateNull)
                    AddParameter(cmd, "LastEditDate", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditDate", value.LastEditDate);

                value.Slot_ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Updates a record in the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(WarehouseSlotRow value)
        {
            string LOCATION = "Update(WarehouseSlotRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_Update", CommandType.StoredProcedure);
                // Rack_ID
                if (value.IsRack_IDNull)
                    AddParameter(cmd, "Rack_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Rack_ID", value.Rack_ID);
                // Warehouse_ID
                if (value.IsWarehouse_IDNull)
                    AddParameter(cmd, "Warehouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouse_ID", value.Warehouse_ID);
                // Code
                if (value.IsCodeNull)
                    AddParameter(cmd, "Code", DBNull.Value);
                else
                    AddParameter(cmd, "Code", value.Code);
                // FloorName
                if (value.IsFloorNameNull)
                    AddParameter(cmd, "FloorName", DBNull.Value);
                else
                    AddParameter(cmd, "FloorName", value.FloorName);
                // SlotName
                if (value.IsSlotNameNull)
                    AddParameter(cmd, "SlotName", DBNull.Value);
                else
                    AddParameter(cmd, "SlotName", value.SlotName);
                // GLN
                if (value.IsGLNNull)
                    AddParameter(cmd, "GLN", DBNull.Value);
                else
                    AddParameter(cmd, "GLN", value.GLN);
                // Type
                if (value.IsTypeNull)
                    AddParameter(cmd, "Type", DBNull.Value);
                else
                    AddParameter(cmd, "Type", value.Type);

                // Priority
                if (value.IsPriorityNull)
                    AddParameter(cmd, "Priority", DBNull.Value);
                else
                    AddParameter(cmd, "Priority", value.Priority);

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", value.Active);

                // CreateBy
                if (value.IsCreateByNull)
                    AddParameter(cmd, "CreateBy", DBNull.Value);
                else
                    AddParameter(cmd, "CreateBy", value.CreateBy);

                // CreateDate
                if (value.IsCreateDateNull)
                    AddParameter(cmd, "CreateDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreateDate", value.CreateDate);

                // LastEditBy
                if (value.IsLastEditByNull)
                    AddParameter(cmd, "LastEditBy", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditBy", value.LastEditBy);

                // LastEditDate
                if (value.IsLastEditDateNull)
                    AddParameter(cmd, "LastEditDate", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditDate", value.LastEditDate);

                AddParameter(cmd, "Slot_ID", value.Slot_ID);
                return 0 != cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Inserts or Updates a record in the <c>WarehouseSlot</c> table.
        /// If a row with the specified primary key exists then it is updated
        /// otehrwise, a new row is added.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotRow"/>
        /// object used to save the table record.</param>
        public virtual void Save(WarehouseSlotRow value)
        {
            string LOCATION = "Save(WarehouseSlotRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_Save", CommandType.StoredProcedure);
                // Rack_ID
                if (value.IsRack_IDNull)
                    AddParameter(cmd, "Rack_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Rack_ID", (object)(value.Rack_ID));

                // Warehouse_ID
                if (value.IsWarehouse_IDNull)
                    AddParameter(cmd, "Warehouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "Warehouse_ID", (object)(value.Warehouse_ID));

                // Code
                if (value.IsCodeNull)
                    AddParameter(cmd, "Code", DBNull.Value);
                else
                    AddParameter(cmd, "Code", (object)(value.Code));

                // FloorName
                if (value.IsFloorNameNull)
                    AddParameter(cmd, "FloorName", DBNull.Value);
                else
                    AddParameter(cmd, "FloorName", (object)(value.FloorName));

                // SlotName
                if (value.IsSlotNameNull)
                    AddParameter(cmd, "SlotName", DBNull.Value);
                else
                    AddParameter(cmd, "SlotName", (object)(value.SlotName));

                // GLN
                if (value.IsGLNNull)
                    AddParameter(cmd, "GLN", DBNull.Value);
                else
                    AddParameter(cmd, "GLN", (object)(value.GLN));

                // Type
                if (value.IsTypeNull)
                    AddParameter(cmd, "Type", DBNull.Value);
                else
                    AddParameter(cmd, "Type", (object)(value.Type));

                // Priority
                if (value.IsPriorityNull)
                    AddParameter(cmd, "Priority", DBNull.Value);
                else
                    AddParameter(cmd, "Priority", (object)(value.Priority));

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", (object)(value.Active));

                // CreateBy
                if (value.IsCreateByNull)
                    AddParameter(cmd, "CreateBy", DBNull.Value);
                else
                    AddParameter(cmd, "CreateBy", (object)(value.CreateBy));

                // CreateDate
                if (value.IsCreateDateNull)
                    AddParameter(cmd, "CreateDate", DBNull.Value);
                else
                    AddParameter(cmd, "CreateDate", (object)(value.CreateDate));

                // LastEditBy
                if (value.IsLastEditByNull)
                    AddParameter(cmd, "LastEditBy", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditBy", (object)(value.LastEditBy));

                // LastEditDate
                if (value.IsLastEditDateNull)
                    AddParameter(cmd, "LastEditDate", DBNull.Value);
                else
                    AddParameter(cmd, "LastEditDate", (object)(value.LastEditDate));

                AddParameter(cmd, "Slot_ID", value.Slot_ID);
                value.Slot_ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }


        public virtual void Update(DataTable table, bool acceptChanges)
        {
            string LOCATION = "Update(DataTable table, bool acceptChanges)";
            try
            {
                DataRowCollection rows = table.Rows;
                for (int i = rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = rows[i];
                    switch (row.RowState)
                    {
                        case DataRowState.Added:
                            Insert(MapRow(row));
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;

                        case DataRowState.Deleted:
                            // Temporary reject changes to be able to access to the PK column(s)
                            row.RejectChanges();
                            try
                            {
                                DeleteByPrimaryKey((int)row["Slot_ID"]);
                            }
                            finally
                            {
                                row.Delete();
                            }
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;

                        case DataRowState.Modified:
                            Update(MapRow(row));
                            if (acceptChanges)
                                row.AcceptChanges();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes the specified object from the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseSlotRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseSlotRow value)
        {
            return DeleteByPrimaryKey(value.Slot_ID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseSlot</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int slot_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int slot_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "Slot_ID", slot_ID);
                return (0 < cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Deletes <c>WarehouseSlot</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>The number of deleted records.</returns>
        public int Delete(string whereSql)
        {
            string LOCATION = "Delete(string whereSql)";
            try
            {
                return CreateDeleteCommand(whereSql).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
        /// to delete <c>WarehouseSlot</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseSlot_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseSlot_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Dispose();
            }
        }

        /// <summary>
        /// Reads data using the specified command and returns 
        /// an array of mapped objects.
        /// </summary>
        /// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
        /// <returns>An array of <see cref="WarehouseSlotRow"/> objects.</returns>
        protected WarehouseSlotRow[] MapRecords(IDbCommand command)
        {
            string LOCATION = "MapRecords(IDbCommand command)";
            IDataReader reader = _db.ExecuteReader(command);
            try
            {
                return MapRecords(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                _db.Dispose();

            }
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// an array of mapped objects.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <returns>An array of <see cref="WarehouseSlotRow"/> objects.</returns>
        protected WarehouseSlotRow[] MapRecords(IDataReader reader)
        {
            int totalRecordCount = -1;
            return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// an array of mapped objects.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <param name="startIndex">The index of the first record to map.</param>
        /// <param name="length">The number of records to map.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>An array of <see cref="WarehouseSlotRow"/> objects.</returns>
        protected virtual WarehouseSlotRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // Slot_ID
            int slot_IDColumnIndex = reader.GetOrdinal("Slot_ID");
            // Rack_ID
            int rack_IDColumnIndex = reader.GetOrdinal("Rack_ID");
            // Warehouse_ID
            int warehouse_IDColumnIndex = reader.GetOrdinal("Warehouse_ID");
            // Code
            int codeColumnIndex = reader.GetOrdinal("Code");
            // FloorName
            int floorNameColumnIndex = reader.GetOrdinal("FloorName");
            // SlotName
            int slotNameColumnIndex = reader.GetOrdinal("SlotName");
            // GLN
            int glnColumnIndex = reader.GetOrdinal("GLN");
            // Type
            int typeColumnIndex = reader.GetOrdinal("Type");
            // Priority
            int priorityColumnIndex = reader.GetOrdinal("priority");
            // Active
            int activeColumnIndex = reader.GetOrdinal("Active");
            // CreateBy
            int createByColumnIndex = reader.GetOrdinal("CreateBy");
            // CreateDate
            int createDateColumnIndex = reader.GetOrdinal("CreateDate");
            // LastEditBy
            int lastEditByColumnIndex = reader.GetOrdinal("LastEditBy");
            // LastEditDate
            int lastEditDateColumnIndex = reader.GetOrdinal("LastEditDate");

            System.Collections.ArrayList recordList = new System.Collections.ArrayList();
            int ri = -startIndex;
            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    WarehouseSlotRow record = new WarehouseSlotRow();
                    recordList.Add(record);

                    record.Slot_ID = Convert.ToInt32(reader.GetValue(slot_IDColumnIndex));
                    record.Rack_ID = Convert.ToInt32(reader.GetValue(rack_IDColumnIndex));
                    record.Warehouse_ID = Convert.ToInt32(reader.GetValue(warehouse_IDColumnIndex));
                    if (!reader.IsDBNull(codeColumnIndex))
                        record.Code = Convert.ToString(reader.GetValue(codeColumnIndex));
                    if (!reader.IsDBNull(floorNameColumnIndex))
                        record.FloorName = Convert.ToString(reader.GetValue(floorNameColumnIndex));
                    if (!reader.IsDBNull(slotNameColumnIndex))
                        record.SlotName = Convert.ToString(reader.GetValue(slotNameColumnIndex));
                    if (!reader.IsDBNull(glnColumnIndex))
                        record.GLN = Convert.ToString(reader.GetValue(glnColumnIndex));
                    if (!reader.IsDBNull(typeColumnIndex))
                        record.Type = Convert.ToInt32(reader.GetValue(typeColumnIndex));
                    if (!reader.IsDBNull(priorityColumnIndex))
                        record.Priority = Convert.ToInt32(reader.GetValue(priorityColumnIndex));
                    if (!reader.IsDBNull(activeColumnIndex))
                        record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
                    if (!reader.IsDBNull(createByColumnIndex))
                        record.CreateBy = reader.GetGuid(createByColumnIndex);
                    if (!reader.IsDBNull(createDateColumnIndex))
                        record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
                    if (!reader.IsDBNull(lastEditByColumnIndex))
                        record.LastEditBy = reader.GetGuid(lastEditByColumnIndex);
                    if (!reader.IsDBNull(lastEditDateColumnIndex))
                        record.LastEditDate = Convert.ToDateTime(reader.GetValue(lastEditDateColumnIndex));

                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return (WarehouseSlotRow[])(recordList.ToArray(typeof(WarehouseSlotRow)));
        }

        /// <summary>
        /// Reads data using the specified command and returns 
        /// a filled <see cref="System.Data.DataTable"/> object.
        /// </summary>
        /// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected DataTable MapRecordsToDataTable(IDbCommand command)
        {
            string LOCATION = "MapRecordsToDataTable(IDbCommand command)";
            IDataReader reader = _db.ExecuteReader(command);
            try
            {
                return MapRecordsToDataTable(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                reader.Dispose();
                _db.Dispose();
            }
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// a filled <see cref="System.Data.DataTable"/> object.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected DataTable MapRecordsToDataTable(IDataReader reader)
        {
            int totalRecordCount = 0;
            return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
        }

        /// <summary>
        /// Reads data from the provided data reader and returns 
        /// a filled <see cref="System.Data.DataTable"/> object.
        /// </summary>
        /// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
        /// <param name="startIndex">The index of the first record to read.</param>
        /// <param name="length">The number of records to read.</param>
        /// <param name="totalRecordCount">A reference parameter that returns the total number 
        /// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable MapRecordsToDataTable(IDataReader reader,
                                            int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "MapRecordsToDataTable(reader,startIndex,length,ref totalRecordCount)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");
            int columnCount = reader.FieldCount;
            int ri = -startIndex;

            DataTable dataTable = CreateDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                ri++;
                if (ri > 0 && ri <= length)
                {
                    reader.GetValues(values);
                    dataTable.LoadDataRow(values, true);
                    if (ri == length && 0 != totalRecordCount)
                        break;
                }
            }
            dataTable.EndLoadData();

            if (0 == totalRecordCount)
                totalRecordCount = ri + startIndex;
            else
                totalRecordCount = -1;

            return dataTable;
        }

        /// <summary>
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseSlotRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseSlotRow"/> object.</returns>
        protected virtual WarehouseSlotRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseSlotRow MapRow(DataRow row)";
            WarehouseSlotRow mappedObject = new WarehouseSlotRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "Slot_ID"
            dataColumn = dataTable.Columns["Slot_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Slot_ID = (int)(row[dataColumn]);
            // Column "Rack_ID"
            dataColumn = dataTable.Columns["Rack_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Rack_ID = (int)(row[dataColumn]);
            // Column "Warehouse_ID"
            dataColumn = dataTable.Columns["Warehouse_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Warehouse_ID = (int)(row[dataColumn]);
            // Column "Code"
            dataColumn = dataTable.Columns["Code"];
            if (!row.IsNull(dataColumn))
                mappedObject.Code = (string)(row[dataColumn]);
            // Column "FloorName"
            dataColumn = dataTable.Columns["FloorName"];
            if (!row.IsNull(dataColumn))
                mappedObject.FloorName = (string)(row[dataColumn]);
            // Column "SlotName"
            dataColumn = dataTable.Columns["SlotName"];
            if (!row.IsNull(dataColumn))
                mappedObject.SlotName = (string)(row[dataColumn]);
            // Column "GLN"
            dataColumn = dataTable.Columns["GLN"];
            if (!row.IsNull(dataColumn))
                mappedObject.GLN = (string)(row[dataColumn]);
            // Column "Type"
            dataColumn = dataTable.Columns["Type"];
            if (!row.IsNull(dataColumn))
                mappedObject.Type = (int)(row[dataColumn]);
            // Column "Priority"
            dataColumn = dataTable.Columns["Priority"];
            if (!row.IsNull(dataColumn))
                mappedObject.Priority = (int)(row[dataColumn]);
            // Column "Active"
            dataColumn = dataTable.Columns["Active"];
            if (!row.IsNull(dataColumn))
                mappedObject.Active = (int)(row[dataColumn]);
            // Column "CreateBy"
            dataColumn = dataTable.Columns["CreateBy"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreateBy = (System.Guid)(row[dataColumn]);
            // Column "CreateDate"
            dataColumn = dataTable.Columns["CreateDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.CreateDate = (System.DateTime)(row[dataColumn]);
            // Column "LastEditBy"
            dataColumn = dataTable.Columns["LastEditBy"];
            if (!row.IsNull(dataColumn))
                mappedObject.LastEditBy = (System.Guid)(row[dataColumn]);
            // Column "LastEditDate"
            dataColumn = dataTable.Columns["LastEditDate"];
            if (!row.IsNull(dataColumn))
                mappedObject.LastEditDate = (System.DateTime)(row[dataColumn]);
            return mappedObject;
        }

        /// <summary>
        /// Creates a <see cref="System.Data.DataTable"/> object for 
        /// the <c>WarehouseSlot</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseSlot";
            DataColumn dataColumn;
            // Create the "Slot_ID" column
            dataColumn = dataTable.Columns.Add("Slot_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "Rack_ID" column
            dataColumn = dataTable.Columns.Add("Rack_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            // Create the "Warehouse_ID" column
            dataColumn = dataTable.Columns.Add("Warehouse_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            // Create the "Code" column
            dataColumn = dataTable.Columns.Add("Code", typeof(string));
            dataColumn.MaxLength = 1000;
            // Create the "FloorName" column
            dataColumn = dataTable.Columns.Add("FloorName", typeof(string));
            dataColumn.MaxLength = 10;
            // Create the "SlotName" column
            dataColumn = dataTable.Columns.Add("SlotName", typeof(string));
            dataColumn.MaxLength = 50;
            // Create the "GLN" column
            dataColumn = dataTable.Columns.Add("GLN", typeof(string));
            dataColumn.MaxLength = 200;
            // Create the "Type" column
            dataColumn = dataTable.Columns.Add("Type", typeof(int));
            // Create the "Priority" column
            dataColumn = dataTable.Columns.Add("Priority", typeof(int));
            dataColumn.Caption = "priority";
            // Create the "Active" column
            dataColumn = dataTable.Columns.Add("Active", typeof(int));
            // Create the "CreateBy" column
            dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
            // Create the "CreateDate" column
            dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
            // Create the "LastEditBy" column
            dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
            // Create the "LastEditDate" column
            dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
            return dataTable;
        }

        /// <summary>
        /// Adds a new parameter to the specified command.
        /// </summary>
        /// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>A reference to the added parameter.</returns>
        protected virtual IDbDataParameter AddParameter(IDbCommand cmd, String paramName, object value)
        {
            string LOCATION = "AddParameter(IDbCommand cmd, String paramName, object value)";
            IDbDataParameter parameter;
            switch (paramName)
            {
                case "Slot_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Rack_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Warehouse_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Code":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "FloorName":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
                    break;

                case "SlotName":
                    parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
                    break;

                case "GLN":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Type":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Priority":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Active":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "CreateBy":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
                    break;

                case "CreateDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;

                case "LastEditBy":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
                    break;

                case "LastEditDate":
                    parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
                    break;

                default:
                    throw new ArgumentException("Unknown parameter name (" + paramName + ").");
            }
            return parameter;
        }

        /// <summary>
        /// Exist <see cref="WarehouseSlotRow"/> by the primary key.
        /// </summary>
        /// <param name="slot_ID">The <c>Slot_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseSlotRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int slot_ID)
        {
            string LOCATION = "Exist(int slot_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseSlot_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "Slot_ID", slot_ID);
            WarehouseSlotRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




