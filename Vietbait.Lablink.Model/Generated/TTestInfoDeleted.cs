using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Xml.Serialization;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Strongly-typed collection for the TTestInfoDeleted class.
    /// </summary>
    [Serializable]
    public class TTestInfoDeletedCollection : ActiveList<TTestInfoDeleted, TTestInfoDeletedCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>TTestInfoDeletedCollection</returns>
        public TTestInfoDeletedCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                TTestInfoDeleted o = this[i];
                foreach (Where w in wheres)
                {
                    bool remove = false;
                    PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
    }

    /// <summary>
    ///     This is an ActiveRecord class which wraps the T_TEST_INFO_DELETED table.
    /// </summary>
    [Serializable]
    public class TTestInfoDeleted : ActiveRecord<TTestInfoDeleted>, IActiveRecord
    {
        #region .ctors and Default Settings

        public TTestInfoDeleted()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public TTestInfoDeleted(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public TTestInfoDeleted(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public TTestInfoDeleted(string columnName, object columnValue)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByParam(columnName, columnValue);
        }

        private void InitSetDefaults()
        {
            SetDefaults();
        }

        protected static void SetSQLProps()
        {
            GetTableSchema();
        }

        #endregion

        #region Schema and Query Accessor	

        public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                    SetSQLProps();
                return BaseSchema;
            }
        }

        public static Query CreateQuery()
        {
            return new Query(Schema);
        }

        private static void GetTableSchema()
        {
            if (!IsSchemaInitialized)
            {
                //Schema declaration
                var schema = new TableSchema.Table("T_TEST_INFO_DELETED", TableType.Table,
                    DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "Id";
                colvarId.DataType = DbType.Decimal;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = true;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = true;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                colvarId.DefaultSetting = @"";
                colvarId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarId);

                var colvarTestId = new TableSchema.TableColumn(schema);
                colvarTestId.ColumnName = "Test_ID";
                colvarTestId.DataType = DbType.Decimal;
                colvarTestId.MaxLength = 0;
                colvarTestId.AutoIncrement = false;
                colvarTestId.IsNullable = false;
                colvarTestId.IsPrimaryKey = false;
                colvarTestId.IsForeignKey = false;
                colvarTestId.IsReadOnly = false;
                colvarTestId.DefaultSetting = @"";
                colvarTestId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestId);

                var colvarTestTypeId = new TableSchema.TableColumn(schema);
                colvarTestTypeId.ColumnName = "TestType_ID";
                colvarTestTypeId.DataType = DbType.Decimal;
                colvarTestTypeId.MaxLength = 0;
                colvarTestTypeId.AutoIncrement = false;
                colvarTestTypeId.IsNullable = true;
                colvarTestTypeId.IsPrimaryKey = false;
                colvarTestTypeId.IsForeignKey = false;
                colvarTestTypeId.IsReadOnly = false;
                colvarTestTypeId.DefaultSetting = @"";
                colvarTestTypeId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestTypeId);

                var colvarBarcode = new TableSchema.TableColumn(schema);
                colvarBarcode.ColumnName = "Barcode";
                colvarBarcode.DataType = DbType.String;
                colvarBarcode.MaxLength = 50;
                colvarBarcode.AutoIncrement = false;
                colvarBarcode.IsNullable = true;
                colvarBarcode.IsPrimaryKey = false;
                colvarBarcode.IsForeignKey = false;
                colvarBarcode.IsReadOnly = false;
                colvarBarcode.DefaultSetting = @"";
                colvarBarcode.ForeignKeyTableName = "";
                schema.Columns.Add(colvarBarcode);

                var colvarTestSeq = new TableSchema.TableColumn(schema);
                colvarTestSeq.ColumnName = "Test_Seq";
                colvarTestSeq.DataType = DbType.String;
                colvarTestSeq.MaxLength = 10;
                colvarTestSeq.AutoIncrement = false;
                colvarTestSeq.IsNullable = true;
                colvarTestSeq.IsPrimaryKey = false;
                colvarTestSeq.IsForeignKey = false;
                colvarTestSeq.IsReadOnly = false;
                colvarTestSeq.DefaultSetting = @"";
                colvarTestSeq.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestSeq);

                var colvarPatientId = new TableSchema.TableColumn(schema);
                colvarPatientId.ColumnName = "Patient_ID";
                colvarPatientId.DataType = DbType.Decimal;
                colvarPatientId.MaxLength = 0;
                colvarPatientId.AutoIncrement = false;
                colvarPatientId.IsNullable = true;
                colvarPatientId.IsPrimaryKey = false;
                colvarPatientId.IsForeignKey = false;
                colvarPatientId.IsReadOnly = false;
                colvarPatientId.DefaultSetting = @"";
                colvarPatientId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarPatientId);

                var colvarTestDate = new TableSchema.TableColumn(schema);
                colvarTestDate.ColumnName = "Test_Date";
                colvarTestDate.DataType = DbType.DateTime;
                colvarTestDate.MaxLength = 0;
                colvarTestDate.AutoIncrement = false;
                colvarTestDate.IsNullable = true;
                colvarTestDate.IsPrimaryKey = false;
                colvarTestDate.IsForeignKey = false;
                colvarTestDate.IsReadOnly = false;
                colvarTestDate.DefaultSetting = @"";
                colvarTestDate.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestDate);

                var colvarRequireDate = new TableSchema.TableColumn(schema);
                colvarRequireDate.ColumnName = "Require_Date";
                colvarRequireDate.DataType = DbType.DateTime;
                colvarRequireDate.MaxLength = 0;
                colvarRequireDate.AutoIncrement = false;
                colvarRequireDate.IsNullable = true;
                colvarRequireDate.IsPrimaryKey = false;
                colvarRequireDate.IsForeignKey = false;
                colvarRequireDate.IsReadOnly = false;
                colvarRequireDate.DefaultSetting = @"";
                colvarRequireDate.ForeignKeyTableName = "";
                schema.Columns.Add(colvarRequireDate);

                var colvarAssignId = new TableSchema.TableColumn(schema);
                colvarAssignId.ColumnName = "Assign_ID";
                colvarAssignId.DataType = DbType.Decimal;
                colvarAssignId.MaxLength = 0;
                colvarAssignId.AutoIncrement = false;
                colvarAssignId.IsNullable = true;
                colvarAssignId.IsPrimaryKey = false;
                colvarAssignId.IsForeignKey = false;
                colvarAssignId.IsReadOnly = false;
                colvarAssignId.DefaultSetting = @"";
                colvarAssignId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarAssignId);

                var colvarDiagnosticianId = new TableSchema.TableColumn(schema);
                colvarDiagnosticianId.ColumnName = "Diagnostician_ID";
                colvarDiagnosticianId.DataType = DbType.Decimal;
                colvarDiagnosticianId.MaxLength = 0;
                colvarDiagnosticianId.AutoIncrement = false;
                colvarDiagnosticianId.IsNullable = true;
                colvarDiagnosticianId.IsPrimaryKey = false;
                colvarDiagnosticianId.IsForeignKey = false;
                colvarDiagnosticianId.IsReadOnly = false;
                colvarDiagnosticianId.DefaultSetting = @"";
                colvarDiagnosticianId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDiagnosticianId);

                var colvarReceiverId = new TableSchema.TableColumn(schema);
                colvarReceiverId.ColumnName = "Receiver_ID";
                colvarReceiverId.DataType = DbType.Decimal;
                colvarReceiverId.MaxLength = 0;
                colvarReceiverId.AutoIncrement = false;
                colvarReceiverId.IsNullable = true;
                colvarReceiverId.IsPrimaryKey = false;
                colvarReceiverId.IsForeignKey = false;
                colvarReceiverId.IsReadOnly = false;
                colvarReceiverId.DefaultSetting = @"";
                colvarReceiverId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarReceiverId);

                var colvarTestStatus = new TableSchema.TableColumn(schema);
                colvarTestStatus.ColumnName = "Test_Status";
                colvarTestStatus.DataType = DbType.Int16;
                colvarTestStatus.MaxLength = 0;
                colvarTestStatus.AutoIncrement = false;
                colvarTestStatus.IsNullable = true;
                colvarTestStatus.IsPrimaryKey = false;
                colvarTestStatus.IsForeignKey = false;
                colvarTestStatus.IsReadOnly = false;
                colvarTestStatus.DefaultSetting = @"";
                colvarTestStatus.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestStatus);

                var colvarDiagResult = new TableSchema.TableColumn(schema);
                colvarDiagResult.ColumnName = "Diag_Result";
                colvarDiagResult.DataType = DbType.String;
                colvarDiagResult.MaxLength = 200;
                colvarDiagResult.AutoIncrement = false;
                colvarDiagResult.IsNullable = true;
                colvarDiagResult.IsPrimaryKey = false;
                colvarDiagResult.IsForeignKey = false;
                colvarDiagResult.IsReadOnly = false;
                colvarDiagResult.DefaultSetting = @"";
                colvarDiagResult.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDiagResult);

                var colvarUpdateUser = new TableSchema.TableColumn(schema);
                colvarUpdateUser.ColumnName = "Update_User";
                colvarUpdateUser.DataType = DbType.Decimal;
                colvarUpdateUser.MaxLength = 0;
                colvarUpdateUser.AutoIncrement = false;
                colvarUpdateUser.IsNullable = true;
                colvarUpdateUser.IsPrimaryKey = false;
                colvarUpdateUser.IsForeignKey = false;
                colvarUpdateUser.IsReadOnly = false;
                colvarUpdateUser.DefaultSetting = @"";
                colvarUpdateUser.ForeignKeyTableName = "";
                schema.Columns.Add(colvarUpdateUser);

                var colvarUpdateDate = new TableSchema.TableColumn(schema);
                colvarUpdateDate.ColumnName = "Update_Date";
                colvarUpdateDate.DataType = DbType.DateTime;
                colvarUpdateDate.MaxLength = 0;
                colvarUpdateDate.AutoIncrement = false;
                colvarUpdateDate.IsNullable = true;
                colvarUpdateDate.IsPrimaryKey = false;
                colvarUpdateDate.IsForeignKey = false;
                colvarUpdateDate.IsReadOnly = false;
                colvarUpdateDate.DefaultSetting = @"";
                colvarUpdateDate.ForeignKeyTableName = "";
                schema.Columns.Add(colvarUpdateDate);

                var colvarHisAssignId = new TableSchema.TableColumn(schema);
                colvarHisAssignId.ColumnName = "His_Assign_id";
                colvarHisAssignId.DataType = DbType.Int32;
                colvarHisAssignId.MaxLength = 0;
                colvarHisAssignId.AutoIncrement = false;
                colvarHisAssignId.IsNullable = true;
                colvarHisAssignId.IsPrimaryKey = false;
                colvarHisAssignId.IsForeignKey = false;
                colvarHisAssignId.IsReadOnly = false;
                colvarHisAssignId.DefaultSetting = @"";
                colvarHisAssignId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarHisAssignId);

                var colvarDeviceId = new TableSchema.TableColumn(schema);
                colvarDeviceId.ColumnName = "Device_ID";
                colvarDeviceId.DataType = DbType.Decimal;
                colvarDeviceId.MaxLength = 0;
                colvarDeviceId.AutoIncrement = false;
                colvarDeviceId.IsNullable = true;
                colvarDeviceId.IsPrimaryKey = false;
                colvarDeviceId.IsForeignKey = false;
                colvarDeviceId.IsReadOnly = false;
                colvarDeviceId.DefaultSetting = @"";
                colvarDeviceId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDeviceId);

                var colvarParaId = new TableSchema.TableColumn(schema);
                colvarParaId.ColumnName = "Para_ID";
                colvarParaId.DataType = DbType.Int32;
                colvarParaId.MaxLength = 0;
                colvarParaId.AutoIncrement = false;
                colvarParaId.IsNullable = true;
                colvarParaId.IsPrimaryKey = false;
                colvarParaId.IsForeignKey = false;
                colvarParaId.IsReadOnly = false;
                colvarParaId.DefaultSetting = @"";
                colvarParaId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarParaId);

                var colvarPrintstatus = new TableSchema.TableColumn(schema);
                colvarPrintstatus.ColumnName = "Printstatus";
                colvarPrintstatus.DataType = DbType.Boolean;
                colvarPrintstatus.MaxLength = 0;
                colvarPrintstatus.AutoIncrement = false;
                colvarPrintstatus.IsNullable = true;
                colvarPrintstatus.IsPrimaryKey = false;
                colvarPrintstatus.IsForeignKey = false;
                colvarPrintstatus.IsReadOnly = false;
                colvarPrintstatus.DefaultSetting = @"";
                colvarPrintstatus.ForeignKeyTableName = "";
                schema.Columns.Add(colvarPrintstatus);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("T_TEST_INFO_DELETED", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("Id")]
        [Bindable(true)]
        public decimal Id
        {
            get { return GetColumnValue<decimal>(Columns.Id); }
            set { SetColumnValue(Columns.Id, value); }
        }

        [XmlAttribute("TestId")]
        [Bindable(true)]
        public decimal TestId
        {
            get { return GetColumnValue<decimal>(Columns.TestId); }
            set { SetColumnValue(Columns.TestId, value); }
        }

        [XmlAttribute("TestTypeId")]
        [Bindable(true)]
        public decimal? TestTypeId
        {
            get { return GetColumnValue<decimal?>(Columns.TestTypeId); }
            set { SetColumnValue(Columns.TestTypeId, value); }
        }

        [XmlAttribute("Barcode")]
        [Bindable(true)]
        public string Barcode
        {
            get { return GetColumnValue<string>(Columns.Barcode); }
            set { SetColumnValue(Columns.Barcode, value); }
        }

        [XmlAttribute("TestSeq")]
        [Bindable(true)]
        public string TestSeq
        {
            get { return GetColumnValue<string>(Columns.TestSeq); }
            set { SetColumnValue(Columns.TestSeq, value); }
        }

        [XmlAttribute("PatientId")]
        [Bindable(true)]
        public decimal? PatientId
        {
            get { return GetColumnValue<decimal?>(Columns.PatientId); }
            set { SetColumnValue(Columns.PatientId, value); }
        }

        [XmlAttribute("TestDate")]
        [Bindable(true)]
        public DateTime? TestDate
        {
            get { return GetColumnValue<DateTime?>(Columns.TestDate); }
            set { SetColumnValue(Columns.TestDate, value); }
        }

        [XmlAttribute("RequireDate")]
        [Bindable(true)]
        public DateTime? RequireDate
        {
            get { return GetColumnValue<DateTime?>(Columns.RequireDate); }
            set { SetColumnValue(Columns.RequireDate, value); }
        }

        [XmlAttribute("AssignId")]
        [Bindable(true)]
        public decimal? AssignId
        {
            get { return GetColumnValue<decimal?>(Columns.AssignId); }
            set { SetColumnValue(Columns.AssignId, value); }
        }

        [XmlAttribute("DiagnosticianId")]
        [Bindable(true)]
        public decimal? DiagnosticianId
        {
            get { return GetColumnValue<decimal?>(Columns.DiagnosticianId); }
            set { SetColumnValue(Columns.DiagnosticianId, value); }
        }

        [XmlAttribute("ReceiverId")]
        [Bindable(true)]
        public decimal? ReceiverId
        {
            get { return GetColumnValue<decimal?>(Columns.ReceiverId); }
            set { SetColumnValue(Columns.ReceiverId, value); }
        }

        [XmlAttribute("TestStatus")]
        [Bindable(true)]
        public short? TestStatus
        {
            get { return GetColumnValue<short?>(Columns.TestStatus); }
            set { SetColumnValue(Columns.TestStatus, value); }
        }

        [XmlAttribute("DiagResult")]
        [Bindable(true)]
        public string DiagResult
        {
            get { return GetColumnValue<string>(Columns.DiagResult); }
            set { SetColumnValue(Columns.DiagResult, value); }
        }

        [XmlAttribute("UpdateUser")]
        [Bindable(true)]
        public decimal? UpdateUser
        {
            get { return GetColumnValue<decimal?>(Columns.UpdateUser); }
            set { SetColumnValue(Columns.UpdateUser, value); }
        }

        [XmlAttribute("UpdateDate")]
        [Bindable(true)]
        public DateTime? UpdateDate
        {
            get { return GetColumnValue<DateTime?>(Columns.UpdateDate); }
            set { SetColumnValue(Columns.UpdateDate, value); }
        }

        [XmlAttribute("HisAssignId")]
        [Bindable(true)]
        public int? HisAssignId
        {
            get { return GetColumnValue<int?>(Columns.HisAssignId); }
            set { SetColumnValue(Columns.HisAssignId, value); }
        }

        [XmlAttribute("DeviceId")]
        [Bindable(true)]
        public decimal? DeviceId
        {
            get { return GetColumnValue<decimal?>(Columns.DeviceId); }
            set { SetColumnValue(Columns.DeviceId, value); }
        }

        [XmlAttribute("ParaId")]
        [Bindable(true)]
        public int? ParaId
        {
            get { return GetColumnValue<int?>(Columns.ParaId); }
            set { SetColumnValue(Columns.ParaId, value); }
        }

        [XmlAttribute("Printstatus")]
        [Bindable(true)]
        public bool? Printstatus
        {
            get { return GetColumnValue<bool?>(Columns.Printstatus); }
            set { SetColumnValue(Columns.Printstatus, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(decimal varTestId, decimal? varTestTypeId, string varBarcode, string varTestSeq,
            decimal? varPatientId, DateTime? varTestDate, DateTime? varRequireDate, decimal? varAssignId,
            decimal? varDiagnosticianId, decimal? varReceiverId, short? varTestStatus, string varDiagResult,
            decimal? varUpdateUser, DateTime? varUpdateDate, int? varHisAssignId, decimal? varDeviceId, int? varParaId,
            bool? varPrintstatus)
        {
            var item = new TTestInfoDeleted();

            item.TestId = varTestId;

            item.TestTypeId = varTestTypeId;

            item.Barcode = varBarcode;

            item.TestSeq = varTestSeq;

            item.PatientId = varPatientId;

            item.TestDate = varTestDate;

            item.RequireDate = varRequireDate;

            item.AssignId = varAssignId;

            item.DiagnosticianId = varDiagnosticianId;

            item.ReceiverId = varReceiverId;

            item.TestStatus = varTestStatus;

            item.DiagResult = varDiagResult;

            item.UpdateUser = varUpdateUser;

            item.UpdateDate = varUpdateDate;

            item.HisAssignId = varHisAssignId;

            item.DeviceId = varDeviceId;

            item.ParaId = varParaId;

            item.Printstatus = varPrintstatus;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(decimal varId, decimal varTestId, decimal? varTestTypeId, string varBarcode,
            string varTestSeq, decimal? varPatientId, DateTime? varTestDate, DateTime? varRequireDate,
            decimal? varAssignId, decimal? varDiagnosticianId, decimal? varReceiverId, short? varTestStatus,
            string varDiagResult, decimal? varUpdateUser, DateTime? varUpdateDate, int? varHisAssignId,
            decimal? varDeviceId, int? varParaId, bool? varPrintstatus)
        {
            var item = new TTestInfoDeleted();

            item.Id = varId;

            item.TestId = varTestId;

            item.TestTypeId = varTestTypeId;

            item.Barcode = varBarcode;

            item.TestSeq = varTestSeq;

            item.PatientId = varPatientId;

            item.TestDate = varTestDate;

            item.RequireDate = varRequireDate;

            item.AssignId = varAssignId;

            item.DiagnosticianId = varDiagnosticianId;

            item.ReceiverId = varReceiverId;

            item.TestStatus = varTestStatus;

            item.DiagResult = varDiagResult;

            item.UpdateUser = varUpdateUser;

            item.UpdateDate = varUpdateDate;

            item.HisAssignId = varHisAssignId;

            item.DeviceId = varDeviceId;

            item.ParaId = varParaId;

            item.Printstatus = varPrintstatus;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn TestIdColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn TestTypeIdColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn BarcodeColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn TestSeqColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn PatientIdColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn TestDateColumn
        {
            get { return Schema.Columns[6]; }
        }


        public static TableSchema.TableColumn RequireDateColumn
        {
            get { return Schema.Columns[7]; }
        }


        public static TableSchema.TableColumn AssignIdColumn
        {
            get { return Schema.Columns[8]; }
        }


        public static TableSchema.TableColumn DiagnosticianIdColumn
        {
            get { return Schema.Columns[9]; }
        }


        public static TableSchema.TableColumn ReceiverIdColumn
        {
            get { return Schema.Columns[10]; }
        }


        public static TableSchema.TableColumn TestStatusColumn
        {
            get { return Schema.Columns[11]; }
        }


        public static TableSchema.TableColumn DiagResultColumn
        {
            get { return Schema.Columns[12]; }
        }


        public static TableSchema.TableColumn UpdateUserColumn
        {
            get { return Schema.Columns[13]; }
        }


        public static TableSchema.TableColumn UpdateDateColumn
        {
            get { return Schema.Columns[14]; }
        }


        public static TableSchema.TableColumn HisAssignIdColumn
        {
            get { return Schema.Columns[15]; }
        }


        public static TableSchema.TableColumn DeviceIdColumn
        {
            get { return Schema.Columns[16]; }
        }


        public static TableSchema.TableColumn ParaIdColumn
        {
            get { return Schema.Columns[17]; }
        }


        public static TableSchema.TableColumn PrintstatusColumn
        {
            get { return Schema.Columns[18]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string Id = @"Id";
            public static string TestId = @"Test_ID";
            public static string TestTypeId = @"TestType_ID";
            public static string Barcode = @"Barcode";
            public static string TestSeq = @"Test_Seq";
            public static string PatientId = @"Patient_ID";
            public static string TestDate = @"Test_Date";
            public static string RequireDate = @"Require_Date";
            public static string AssignId = @"Assign_ID";
            public static string DiagnosticianId = @"Diagnostician_ID";
            public static string ReceiverId = @"Receiver_ID";
            public static string TestStatus = @"Test_Status";
            public static string DiagResult = @"Diag_Result";
            public static string UpdateUser = @"Update_User";
            public static string UpdateDate = @"Update_Date";
            public static string HisAssignId = @"His_Assign_id";
            public static string DeviceId = @"Device_ID";
            public static string ParaId = @"Para_ID";
            public static string Printstatus = @"Printstatus";
        }

        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion

        //no foreign key tables defined (0)


        //no ManyToMany tables defined (0)
    }
}