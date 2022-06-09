
// <fileinfo name="Base\WarehouseRackCollectionBase.cs">
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
    /// The base class for <see cref="WarehouseRackCollection"/>. Provides methods 
    /// for common database table operations. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Update the <see cref="WarehouseRackCollection"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public abstract class WarehouseRackCollectionBase
        : Base.ConllectionBase

    {
        // Constants
        public const string Rack_IDColumnName = "Rack_ID";
        public const string WareHouse_IDColumnName = "WareHouse_ID";
        public const string RackNameColumnName = "RackName";
        public const string LineNameColumnName = "LineName";
        public const string CodeColumnName = "Code";
        public const string GLNColumnName = "GLN";
        public const string ActiveColumnName = "Active";
        public const string TypeColumnName = "Type";
        public const string PriorityColumnName = "priority";
        public const string CreateByColumnName = "CreateBy";
        public const string CreateDateColumnName = "CreateDate";
        public const string LastEditByColumnName = "LastEditBy";
        public const string LastEditDateColumnName = "LastEditDate";


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesCollection_Base"/> 
        /// class with the specified <see cref="Database"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> object.</param>
        public WarehouseRackCollectionBase(Database db) : base(db)
        {
            this.TABLENAME = "WarehouseRack";
        }

        public WarehouseRackCollectionBase() : base()
        {
            this.TABLENAME = "WarehouseRack";
        }



        /// <summary>
        /// Gets an array of all records from the <c>WarehouseRack</c> table.
        /// </summary>
        /// <returns>An array of <see cref="WarehouseRackRow"/> objects.</returns>
        public virtual WarehouseRackRow[] GetAll()
        {
            return MapRecords(CreateGetAllCommand());
        }

        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseRack</c> table.
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
        /// <summary>
        /// Gets a <see cref="System.Data.DataTable"/> object that 
        /// includes all records from the <c>WarehouseRack</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        public virtual DataTable GetAllLineAsDataTable()
        {
            string LOCATION = "GetAllLineAsDataTable()";
            try
            {
                return MapRecordsToDataTable(CreateGetAllLineCommand());
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
        /// to retrieve all records from the <c>WarehouseRack</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseRack_GetAll", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }
        /// <summary>
        /// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
        /// to retrieve all records from the <c>WarehouseRack</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateGetAllLineCommand()
        {
            string LOCATION = "";
            try
            {
                return _db.CreateCommand("WarehouseRack_GetAllLine", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Gets the first <see cref="WarehouseRackRow"/> objects that 
        /// match the search condition.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>An instance of <see cref="WarehouseRackRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public WarehouseRackRow GetRow(string whereSql)
        {
            string LOCATION = "GetRow(string whereSql)";
            try
            {
                int totalRecordCount = -1;
                WarehouseRackRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
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
        /// Gets an array of <see cref="WarehouseRackRow"/> objects that 
        /// match the search condition, in the the specified sort order.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. For example: 
        /// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
        /// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
        /// <returns>An array of <see cref="WarehouseRackRow"/> objects.</returns>
        public WarehouseRackRow[] GetAsArray(string whereSql, string orderBySql)
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
        /// Gets an array of <see cref="WarehouseRackRow"/> objects that 
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
        /// <returns>An array of <see cref="WarehouseRackRow"/> objects.</returns>
        public virtual WarehouseRackRow[] GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = "GetAsArray(string whereSql, string orderBySql, int startIndex, int length, ref int totalRecordCount)";
            IDataReader reader = null;
            IDbCommand cmd = null;
            try
            {
                cmd = CreateGetCommand(whereSql, orderBySql, startIndex, length);
                reader = _db.ExecuteReader(cmd);
                WarehouseRackRow[] rows = MapRecords(reader);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_GetAdHoc", CommandType.StoredProcedure);
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
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_GetPageAdHoc", CommandType.StoredProcedure);

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
        /// Gets <see cref="WarehouseRackRow"/> by the primary key.
        /// </summary>
        /// <param name="rack_ID">The <c>Rack_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseRackRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual WarehouseRackRow GetByPrimaryKey(int rack_ID)
        {
            string LOCATION = "GetByPrimaryKey(int rack_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_GetByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "Rack_ID", rack_ID);
                WarehouseRackRow[] tempArray = MapRecords(cmd);
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
        /// Adds a new record into the <c>WarehouseRack</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseRackRow"/> object to be inserted.</param>
        public virtual void Insert(WarehouseRackRow value)
        {
            string LOCATION = "Insert(WarehouseRackRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_Insert", CommandType.StoredProcedure);
                // WareHouse_ID
                if (value.IsWareHouse_IDNull)
                    AddParameter(cmd, "WareHouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "WareHouse_ID", value.WareHouse_ID);

                // RackName
                if (value.IsRackNameNull)
                    AddParameter(cmd, "RackName", DBNull.Value);
                else
                    AddParameter(cmd, "RackName", value.RackName);

                // LineName
                if (value.IsLineNameNull)
                    AddParameter(cmd, "LineName", DBNull.Value);
                else
                    AddParameter(cmd, "LineName", value.LineName);
               
                // Code
                if (value.IsCodeNull)
                    AddParameter(cmd, "Code", DBNull.Value);
                else
                    AddParameter(cmd, "Code", value.Code);

                // GLN
                if (value.IsGLNNull)
                    AddParameter(cmd, "GLN", DBNull.Value);
                else
                    AddParameter(cmd, "GLN", value.GLN);

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", value.Active);

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
                // Note
                if (value.IsNoteNull)
                    AddParameter(cmd, "Note", DBNull.Value);
                else
                    AddParameter(cmd, "Note", value.Note);
                value.Rack_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        /// Updates a record in the <c>WarehouseRack</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseRackRow"/>
        /// object used to update the table record.</param>
        /// <returns>true if the record was updated; otherwise, false.</returns>
        public virtual bool Update(WarehouseRackRow value)
        {
            string LOCATION = "Update(WarehouseRackRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_Update", CommandType.StoredProcedure);
                // WareHouse_ID
                if (value.IsWareHouse_IDNull)
                    AddParameter(cmd, "WareHouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "WareHouse_ID", value.WareHouse_ID);

                // RackName
                if (value.IsRackNameNull)
                    AddParameter(cmd, "RackName", DBNull.Value);
                else
                    AddParameter(cmd, "RackName", value.RackName);
                // LineName
                if (value.IsLineNameNull)
                    AddParameter(cmd, "LineName", DBNull.Value);
                else
                    AddParameter(cmd, "LineName", value.LineName);
              
                // Code
                if (value.IsCodeNull)
                    AddParameter(cmd, "Code", DBNull.Value);
                else
                    AddParameter(cmd, "Code", value.Code);
                // GLN
                if (value.IsGLNNull)
                    AddParameter(cmd, "GLN", DBNull.Value);
                else
                    AddParameter(cmd, "GLN", value.GLN);
                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", value.Active);

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
                // Note
                if (value.IsNoteNull)
                    AddParameter(cmd, "Note", DBNull.Value);
                else
                    AddParameter(cmd, "Note", value.Note);
                AddParameter(cmd, "Rack_ID", value.Rack_ID);

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
        /// Inserts or Updates a record in the <c>WarehouseRack</c> table.
        /// If a row with the specified primary key exists then it is updated
        /// otehrwise, a new row is added.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseRackRow"/>
        /// object used to save the table record.</param>
        public virtual void Save(WarehouseRackRow value)
        {
            string LOCATION = "Save(WarehouseRackRow value)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_Save", CommandType.StoredProcedure);
                // WareHouse_ID
                if (value.IsWareHouse_IDNull)
                    AddParameter(cmd, "WareHouse_ID", DBNull.Value);
                else
                    AddParameter(cmd, "WareHouse_ID", (object)(value.WareHouse_ID));

                // RackName
                if (value.IsRackNameNull)
                    AddParameter(cmd, "RackName", DBNull.Value);
                else
                    AddParameter(cmd, "RackName", (object)(value.RackName));
                // LineName
                if (value.IsLineNameNull)
                    AddParameter(cmd, "LineName", DBNull.Value);
                else
                    AddParameter(cmd, "LineName", (object)(value.LineName));
               
                // Code
                if (value.IsCodeNull)
                    AddParameter(cmd, "Code", DBNull.Value);
                else
                    AddParameter(cmd, "Code", (object)(value.Code));

                // GLN
                if (value.IsGLNNull)
                    AddParameter(cmd, "GLN", DBNull.Value);
                else
                    AddParameter(cmd, "GLN", (object)(value.GLN));

                // Active
                if (value.IsActiveNull)
                    AddParameter(cmd, "Active", DBNull.Value);
                else
                    AddParameter(cmd, "Active", (object)(value.Active));

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
                // Note
                if (value.IsNoteNull)
                    AddParameter(cmd, "Note", DBNull.Value);
                else
                    AddParameter(cmd, "Note", (object)(value.Note));
                AddParameter(cmd, "Rack_ID", value.Rack_ID);
                value.Rack_ID = Convert.ToInt32(cmd.ExecuteScalar());
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
                                DeleteByPrimaryKey((int)row["Rack_ID"]);
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
        /// Deletes the specified object from the <c>WarehouseRack</c> table.
        /// </summary>
        /// <param name="value">The <see cref="WarehouseRackRow"/> object to delete.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public bool Delete(WarehouseRackRow value)
        {
            return DeleteByPrimaryKey(value.Rack_ID);
        }

        /// <summary>
        /// Deletes a record from the <c>WarehouseRack</c> table using
        /// the specified primary key.
        /// </summary>
        /// <param name="rack_ID">The <c>Rack_ID</c> column value.</param>
        /// <returns>true if the record was deleted; otherwise, false.</returns>
        public virtual bool DeleteByPrimaryKey(int rack_ID)
        {
            string LOCATION = "DeleteByPrimaryKey(int rack_ID)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_DeleteByPrimaryKey", CommandType.StoredProcedure);
                AddParameter(cmd, "Rack_ID", rack_ID);
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
        /// Deletes <c>WarehouseRack</c> records that match the specified criteria.
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
        /// to delete <c>WarehouseRack</c> records that match the specified criteria.
        /// </summary>
        /// <param name="whereSql">The SQL search condition. 
        /// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
        /// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
        protected virtual IDbCommand CreateDeleteCommand(string whereSql)
        {
            string LOCATION = "CreateDeleteCommand(String whereSql)";
            try
            {
                IDbCommand cmd = _db.CreateCommand("WarehouseRack_DeleteAdHoc", CommandType.StoredProcedure);

                _db.AddParameter(cmd, "where", DbType.AnsiString, whereSql);

                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
        }

        /// <summary>
        /// Deletes all records from the <c>WarehouseRack</c> table.
        /// </summary>
        /// <returns>The number of deleted records.</returns>
        public int DeleteAll()
        {
            string LOCATION = "DeleteAll()";
            try
            {
                return _db.CreateCommand("WarehouseRack_DeleteAll", CommandType.StoredProcedure).ExecuteNonQuery();
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
        /// <returns>An array of <see cref="WarehouseRackRow"/> objects.</returns>
        protected WarehouseRackRow[] MapRecords(IDbCommand command)
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
        /// <returns>An array of <see cref="WarehouseRackRow"/> objects.</returns>
        protected WarehouseRackRow[] MapRecords(IDataReader reader)
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
        /// <returns>An array of <see cref="WarehouseRackRow"/> objects.</returns>
        protected virtual WarehouseRackRow[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
        {
            string LOCATION = " MapRecords(...)";
            if (0 > startIndex)
                throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
            if (0 > length)
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

            // Rack_ID
            int rack_IDColumnIndex = reader.GetOrdinal("Rack_ID");
            // WareHouse_ID
            int wareHouse_IDColumnIndex = reader.GetOrdinal("WareHouse_ID");
            // RackName
            int rackNameColumnIndex = reader.GetOrdinal("RackName");
            // Note
            int noteColumnIndex = reader.GetOrdinal("Note");
            // LineName
            int lineNameColumnIndex = reader.GetOrdinal("LineName");
            // Code
            int codeColumnIndex = reader.GetOrdinal("Code");
            // GLN
            int glnColumnIndex = reader.GetOrdinal("GLN");
            // Active
            int activeColumnIndex = reader.GetOrdinal("Active");
            // Type
            int typeColumnIndex = reader.GetOrdinal("Type");
            // Priority
            int priorityColumnIndex = reader.GetOrdinal("priority");
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
                    WarehouseRackRow record = new WarehouseRackRow();
                    recordList.Add(record);

                    record.Rack_ID = Convert.ToInt32(reader.GetValue(rack_IDColumnIndex));
                    if (!reader.IsDBNull(wareHouse_IDColumnIndex))
                        record.WareHouse_ID = Convert.ToInt32(reader.GetValue(wareHouse_IDColumnIndex));
                    if (!reader.IsDBNull(rackNameColumnIndex))
                        record.RackName = Convert.ToString(reader.GetValue(rackNameColumnIndex));
                    if (!reader.IsDBNull(lineNameColumnIndex))
                        record.LineName = Convert.ToString(reader.GetValue(lineNameColumnIndex));
                    if (!reader.IsDBNull(noteColumnIndex))
                        record.Note = Convert.ToString(reader.GetValue(noteColumnIndex));
                    if (!reader.IsDBNull(codeColumnIndex))
                        record.Code = Convert.ToString(reader.GetValue(codeColumnIndex));
                    if (!reader.IsDBNull(glnColumnIndex))
                        record.GLN = Convert.ToString(reader.GetValue(glnColumnIndex));
                    if (!reader.IsDBNull(activeColumnIndex))
                        record.Active = Convert.ToInt32(reader.GetValue(activeColumnIndex));
                    if (!reader.IsDBNull(typeColumnIndex))
                        record.Type = Convert.ToInt32(reader.GetValue(typeColumnIndex));
                    if (!reader.IsDBNull(priorityColumnIndex))
                        record.Priority = Convert.ToInt32(reader.GetValue(priorityColumnIndex));
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

            return (WarehouseRackRow[])(recordList.ToArray(typeof(WarehouseRackRow)));
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
        /// Converts <see cref="System.Data.DataRow"/> to <see cref="WarehouseRackRow"/>.
        /// </summary>
        /// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
        /// <returns>A reference to the <see cref="WarehouseRackRow"/> object.</returns>
        protected virtual WarehouseRackRow MapRow(DataRow row)
        {
            string LOCATION = "WarehouseRackRow MapRow(DataRow row)";
            WarehouseRackRow mappedObject = new WarehouseRackRow();
            DataTable dataTable = row.Table;
            DataColumn dataColumn;
            // Column "Rack_ID"
            dataColumn = dataTable.Columns["Rack_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.Rack_ID = (int)(row[dataColumn]);
            // Column "WareHouse_ID"
            dataColumn = dataTable.Columns["WareHouse_ID"];
            if (!row.IsNull(dataColumn))
                mappedObject.WareHouse_ID = (int)(row[dataColumn]);
            // Column "RackName"
            dataColumn = dataTable.Columns["RackName"];
            if (!row.IsNull(dataColumn))
                mappedObject.RackName = (string)(row[dataColumn]);
            // Column "LineName"
            dataColumn = dataTable.Columns["LineName"];
            if (!row.IsNull(dataColumn))
                mappedObject.LineName = (string)(row[dataColumn]);
          
            // Column "Code"
            dataColumn = dataTable.Columns["Code"];
            if (!row.IsNull(dataColumn))
                mappedObject.Code = (string)(row[dataColumn]);
            // Column "GLN"
            dataColumn = dataTable.Columns["GLN"];
            if (!row.IsNull(dataColumn))
                mappedObject.GLN = (string)(row[dataColumn]);
            // Column "Active"
            dataColumn = dataTable.Columns["Active"];
            if (!row.IsNull(dataColumn))
                mappedObject.Active = (int)(row[dataColumn]);
            // Column "Type"
            dataColumn = dataTable.Columns["Type"];
            if (!row.IsNull(dataColumn))
                mappedObject.Type = (int)(row[dataColumn]);
            // Column "Priority"
            dataColumn = dataTable.Columns["Priority"];
            if (!row.IsNull(dataColumn))
                mappedObject.Priority = (int)(row[dataColumn]);
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
            // Column "Note"
            dataColumn = dataTable.Columns["Note"];
            if (!row.IsNull(dataColumn))
                mappedObject.Note = (string)(row[dataColumn]);
            return mappedObject;
        }

        /// <summary>
        /// Creates a <see cref="System.Data.DataTable"/> object for 
        /// the <c>WarehouseRack</c> table.
        /// </summary>
        /// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
        protected virtual DataTable CreateDataTable()
        {
            string LOCATION = "CreateDataTable()";
            DataTable dataTable = new DataTable();
            dataTable.TableName = "WarehouseRack";
            DataColumn dataColumn;
            // Create the "Rack_ID" column
            dataColumn = dataTable.Columns.Add("Rack_ID", typeof(int));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            // Create the "WareHouse_ID" column
            dataColumn = dataTable.Columns.Add("WareHouse_ID", typeof(int));
            // Create the "RackName" column
            dataColumn = dataTable.Columns.Add("RackName", typeof(string));
            dataColumn.MaxLength = 100;
            // Create the "LineName" column
            dataColumn = dataTable.Columns.Add("LineName", typeof(string));
            dataColumn.MaxLength = 100;           
            // Create the "Code" column
            dataColumn = dataTable.Columns.Add("Code", typeof(string));
            dataColumn.MaxLength = 1000;
            // Create the "GLN" column
            dataColumn = dataTable.Columns.Add("GLN", typeof(string));
            dataColumn.MaxLength = 200;
            // Create the "Active" column
            dataColumn = dataTable.Columns.Add("Active", typeof(int));
            // Create the "Type" column
            dataColumn = dataTable.Columns.Add("Type", typeof(int));
            // Create the "Priority" column
            dataColumn = dataTable.Columns.Add("Priority", typeof(int));
            dataColumn.Caption = "priority";
            // Create the "CreateBy" column
            dataColumn = dataTable.Columns.Add("CreateBy", typeof(System.Guid));
            // Create the "CreateDate" column
            dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
            // Create the "LastEditBy" column
            dataColumn = dataTable.Columns.Add("LastEditBy", typeof(System.Guid));
            // Create the "LastEditDate" column
            dataColumn = dataTable.Columns.Add("LastEditDate", typeof(System.DateTime));
            // Create the "Note" column
            dataColumn = dataTable.Columns.Add("Note", typeof(string));
            dataColumn.MaxLength = 500;
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
                case "Rack_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "WareHouse_ID":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "RackName":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "LineName":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "Note":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;
                case "Code":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "GLN":
                    parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
                    break;

                case "Active":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Type":
                    parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
                    break;

                case "Priority":
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
        /// Exist <see cref="WarehouseRackRow"/> by the primary key.
        /// </summary>
        /// <param name="rack_ID">The <c>Rack_ID</c> column value.</param>
        /// <returns>An instance of <see cref="WarehouseRackRow"/> or null reference 
        /// (Nothing in Visual Basic) if the object was not found.</returns>
        public virtual bool Exist(int rack_ID)
        {
            string LOCATION = "Exist(int rack_ID)";
            IDbCommand cmd = _db.CreateCommand("WarehouseRack_GetByPrimaryKey", CommandType.StoredProcedure);
            AddParameter(cmd, "Rack_ID", rack_ID);
            WarehouseRackRow[] tempArray = MapRecords(cmd);
            if (0 == tempArray.Length)
                return false;
            return true;
        }

    }
}




