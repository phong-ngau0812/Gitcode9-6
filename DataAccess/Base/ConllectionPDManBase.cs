
// <fileinfo name="Base\ConllectionPDManBase.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
// </fileinfo>



using System;
using System.Data;


namespace Base
{
    /// <summary>
    /// The base class for the <see cref="test"/> class that 
    /// represents a connection to the <c>test</c> database. 
    /// </summary>
    /// <remarks>
    /// Do not change this source code. Modify the test class
    /// if you need to add or change some functionality.
    /// </remarks>


    public abstract class ConllectionPDManBase
    {

        protected Database _db;
        protected String TABLENAME;



        /// <summary>
        /// Initializes a new instance of the <see cref="ConllectionPDManBase"/> 
        /// class with the specified <see cref="ConllectionPDManBase"/>.
        /// </summary>
        /// <param name="db">The <see cref="ConllectionPDManBase"/> object.</param>
        public ConllectionPDManBase(Database db)
        {
            _db = db;
        }

        public ConllectionPDManBase()
        {
            _db = new Database("HY");
        }

        public DataTable Retrieve(System.Data.SqlClient.SqlCommand myCommand)
        {
            string LOCATION = "Retrieve(string sql)";

            try
            {
                return _db.Retrieve(myCommand);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Close();
                Dispose();
            }
        }

        public DataTable GetAllList(string sql)
        {
            string LOCATION = "GetAllList(string sql)";
            try
            {
                return this._db.Retrieve(sql);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DatabaseException(LOCATION, ex);
            }
            finally
            {
                _db.Close();
                Dispose();
            }
        }

        public void Dispose()
        {
            this._db.Dispose();
        }

    }
}
