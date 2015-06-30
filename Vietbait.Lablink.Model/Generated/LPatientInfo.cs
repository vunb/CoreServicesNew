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
    ///     Strongly-typed collection for the LPatientInfo class.
    /// </summary>
    [Serializable]
    public class LPatientInfoCollection : ActiveList<LPatientInfo, LPatientInfoCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>LPatientInfoCollection</returns>
        public LPatientInfoCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                LPatientInfo o = this[i];
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
    ///     This is an ActiveRecord class which wraps the L_PATIENT_INFO table.
    /// </summary>
    [Serializable]
    public class LPatientInfo : ActiveRecord<LPatientInfo>, IActiveRecord
    {
        #region .ctors and Default Settings

        public LPatientInfo()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public LPatientInfo(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public LPatientInfo(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public LPatientInfo(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("L_PATIENT_INFO", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarPatientId = new TableSchema.TableColumn(schema);
                colvarPatientId.ColumnName = "Patient_ID";
                colvarPatientId.DataType = DbType.Decimal;
                colvarPatientId.MaxLength = 0;
                colvarPatientId.AutoIncrement = true;
                colvarPatientId.IsNullable = false;
                colvarPatientId.IsPrimaryKey = true;
                colvarPatientId.IsForeignKey = false;
                colvarPatientId.IsReadOnly = false;
                colvarPatientId.DefaultSetting = @"";
                colvarPatientId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarPatientId);

                var colvarPid = new TableSchema.TableColumn(schema);
                colvarPid.ColumnName = "PID";
                colvarPid.DataType = DbType.String;
                colvarPid.MaxLength = 50;
                colvarPid.AutoIncrement = false;
                colvarPid.IsNullable = false;
                colvarPid.IsPrimaryKey = false;
                colvarPid.IsForeignKey = false;
                colvarPid.IsReadOnly = false;
                colvarPid.DefaultSetting = @"";
                colvarPid.ForeignKeyTableName = "";
                schema.Columns.Add(colvarPid);

                var colvarPatientName = new TableSchema.TableColumn(schema);
                colvarPatientName.ColumnName = "Patient_Name";
                colvarPatientName.DataType = DbType.String;
                colvarPatientName.MaxLength = 100;
                colvarPatientName.AutoIncrement = false;
                colvarPatientName.IsNullable = true;
                colvarPatientName.IsPrimaryKey = false;
                colvarPatientName.IsForeignKey = false;
                colvarPatientName.IsReadOnly = false;
                colvarPatientName.DefaultSetting = @"";
                colvarPatientName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarPatientName);

                var colvarAddress = new TableSchema.TableColumn(schema);
                colvarAddress.ColumnName = "Address";
                colvarAddress.DataType = DbType.String;
                colvarAddress.MaxLength = 200;
                colvarAddress.AutoIncrement = false;
                colvarAddress.IsNullable = true;
                colvarAddress.IsPrimaryKey = false;
                colvarAddress.IsForeignKey = false;
                colvarAddress.IsReadOnly = false;
                colvarAddress.DefaultSetting = @"";
                colvarAddress.ForeignKeyTableName = "";
                schema.Columns.Add(colvarAddress);

                var colvarYearBirth = new TableSchema.TableColumn(schema);
                colvarYearBirth.ColumnName = "YEAR_BIRTH";
                colvarYearBirth.DataType = DbType.Int32;
                colvarYearBirth.MaxLength = 0;
                colvarYearBirth.AutoIncrement = false;
                colvarYearBirth.IsNullable = true;
                colvarYearBirth.IsPrimaryKey = false;
                colvarYearBirth.IsForeignKey = false;
                colvarYearBirth.IsReadOnly = false;
                colvarYearBirth.DefaultSetting = @"";
                colvarYearBirth.ForeignKeyTableName = "";
                schema.Columns.Add(colvarYearBirth);

                var colvarSex = new TableSchema.TableColumn(schema);
                colvarSex.ColumnName = "Sex";
                colvarSex.DataType = DbType.Boolean;
                colvarSex.MaxLength = 0;
                colvarSex.AutoIncrement = false;
                colvarSex.IsNullable = true;
                colvarSex.IsPrimaryKey = false;
                colvarSex.IsForeignKey = false;
                colvarSex.IsReadOnly = false;
                colvarSex.DefaultSetting = @"";
                colvarSex.ForeignKeyTableName = "";
                schema.Columns.Add(colvarSex);

                var colvarInsuranceNum = new TableSchema.TableColumn(schema);
                colvarInsuranceNum.ColumnName = "Insurance_Num";
                colvarInsuranceNum.DataType = DbType.AnsiString;
                colvarInsuranceNum.MaxLength = 20;
                colvarInsuranceNum.AutoIncrement = false;
                colvarInsuranceNum.IsNullable = true;
                colvarInsuranceNum.IsPrimaryKey = false;
                colvarInsuranceNum.IsForeignKey = false;
                colvarInsuranceNum.IsReadOnly = false;
                colvarInsuranceNum.DefaultSetting = @"";
                colvarInsuranceNum.ForeignKeyTableName = "";
                schema.Columns.Add(colvarInsuranceNum);

                var colvarDateupdate = new TableSchema.TableColumn(schema);
                colvarDateupdate.ColumnName = "DATEUPDATE";
                colvarDateupdate.DataType = DbType.DateTime;
                colvarDateupdate.MaxLength = 0;
                colvarDateupdate.AutoIncrement = false;
                colvarDateupdate.IsNullable = true;
                colvarDateupdate.IsPrimaryKey = false;
                colvarDateupdate.IsForeignKey = false;
                colvarDateupdate.IsReadOnly = false;
                colvarDateupdate.DefaultSetting = @"";
                colvarDateupdate.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDateupdate);

                var colvarDiagnostic = new TableSchema.TableColumn(schema);
                colvarDiagnostic.ColumnName = "Diagnostic";
                colvarDiagnostic.DataType = DbType.String;
                colvarDiagnostic.MaxLength = 100;
                colvarDiagnostic.AutoIncrement = false;
                colvarDiagnostic.IsNullable = true;
                colvarDiagnostic.IsPrimaryKey = false;
                colvarDiagnostic.IsForeignKey = false;
                colvarDiagnostic.IsReadOnly = false;
                colvarDiagnostic.DefaultSetting = @"";
                colvarDiagnostic.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDiagnostic);

                var colvarIdentifyNum = new TableSchema.TableColumn(schema);
                colvarIdentifyNum.ColumnName = "IdentifyNum";
                colvarIdentifyNum.DataType = DbType.String;
                colvarIdentifyNum.MaxLength = 20;
                colvarIdentifyNum.AutoIncrement = false;
                colvarIdentifyNum.IsNullable = true;
                colvarIdentifyNum.IsPrimaryKey = false;
                colvarIdentifyNum.IsForeignKey = false;
                colvarIdentifyNum.IsReadOnly = false;
                colvarIdentifyNum.DefaultSetting = @"";
                colvarIdentifyNum.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIdentifyNum);

                var colvarDepartmentID = new TableSchema.TableColumn(schema);
                colvarDepartmentID.ColumnName = "DepartmentID";
                colvarDepartmentID.DataType = DbType.Int16;
                colvarDepartmentID.MaxLength = 0;
                colvarDepartmentID.AutoIncrement = false;
                colvarDepartmentID.IsNullable = true;
                colvarDepartmentID.IsPrimaryKey = false;
                colvarDepartmentID.IsForeignKey = false;
                colvarDepartmentID.IsReadOnly = false;
                colvarDepartmentID.DefaultSetting = @"";
                colvarDepartmentID.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDepartmentID);

                var colvarRoom = new TableSchema.TableColumn(schema);
                colvarRoom.ColumnName = "Room";
                colvarRoom.DataType = DbType.String;
                colvarRoom.MaxLength = 50;
                colvarRoom.AutoIncrement = false;
                colvarRoom.IsNullable = true;
                colvarRoom.IsPrimaryKey = false;
                colvarRoom.IsForeignKey = false;
                colvarRoom.IsReadOnly = false;
                colvarRoom.DefaultSetting = @"";
                colvarRoom.ForeignKeyTableName = "";
                schema.Columns.Add(colvarRoom);

                var colvarBed = new TableSchema.TableColumn(schema);
                colvarBed.ColumnName = "Bed";
                colvarBed.DataType = DbType.String;
                colvarBed.MaxLength = 50;
                colvarBed.AutoIncrement = false;
                colvarBed.IsNullable = true;
                colvarBed.IsPrimaryKey = false;
                colvarBed.IsForeignKey = false;
                colvarBed.IsReadOnly = false;
                colvarBed.DefaultSetting = @"";
                colvarBed.ForeignKeyTableName = "";
                schema.Columns.Add(colvarBed);

                var colvarObjectType = new TableSchema.TableColumn(schema);
                colvarObjectType.ColumnName = "ObjectType";
                colvarObjectType.DataType = DbType.Int32;
                colvarObjectType.MaxLength = 0;
                colvarObjectType.AutoIncrement = false;
                colvarObjectType.IsNullable = true;
                colvarObjectType.IsPrimaryKey = false;
                colvarObjectType.IsForeignKey = false;
                colvarObjectType.IsReadOnly = false;
                colvarObjectType.DefaultSetting = @"";
                colvarObjectType.ForeignKeyTableName = "";
                schema.Columns.Add(colvarObjectType);

                var colvarHosStatus = new TableSchema.TableColumn(schema);
                colvarHosStatus.ColumnName = "Hos_Status";
                colvarHosStatus.DataType = DbType.Int32;
                colvarHosStatus.MaxLength = 0;
                colvarHosStatus.AutoIncrement = false;
                colvarHosStatus.IsNullable = true;
                colvarHosStatus.IsPrimaryKey = false;
                colvarHosStatus.IsForeignKey = false;
                colvarHosStatus.IsReadOnly = false;

                colvarHosStatus.DefaultSetting = @"((0))";
                colvarHosStatus.ForeignKeyTableName = "";
                schema.Columns.Add(colvarHosStatus);

                var colvarDob = new TableSchema.TableColumn(schema);
                colvarDob.ColumnName = "DOB";
                colvarDob.DataType = DbType.DateTime;
                colvarDob.MaxLength = 0;
                colvarDob.AutoIncrement = false;
                colvarDob.IsNullable = true;
                colvarDob.IsPrimaryKey = false;
                colvarDob.IsForeignKey = false;
                colvarDob.IsReadOnly = false;
                colvarDob.DefaultSetting = @"";
                colvarDob.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDob);

                var colvarLotID = new TableSchema.TableColumn(schema);
                colvarLotID.ColumnName = "LotID";
                colvarLotID.DataType = DbType.Int32;
                colvarLotID.MaxLength = 0;
                colvarLotID.AutoIncrement = false;
                colvarLotID.IsNullable = true;
                colvarLotID.IsPrimaryKey = false;
                colvarLotID.IsForeignKey = false;
                colvarLotID.IsReadOnly = false;
                colvarLotID.DefaultSetting = @"";
                colvarLotID.ForeignKeyTableName = "";
                schema.Columns.Add(colvarLotID);

                var colvarCanLamSangId = new TableSchema.TableColumn(schema);
                colvarCanLamSangId.ColumnName = "CanLamSang_ID";
                colvarCanLamSangId.DataType = DbType.String;
                colvarCanLamSangId.MaxLength = 200;
                colvarCanLamSangId.AutoIncrement = false;
                colvarCanLamSangId.IsNullable = true;
                colvarCanLamSangId.IsPrimaryKey = false;
                colvarCanLamSangId.IsForeignKey = false;
                colvarCanLamSangId.IsReadOnly = false;
                colvarCanLamSangId.DefaultSetting = @"";
                colvarCanLamSangId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarCanLamSangId);

                var colvarTestCount = new TableSchema.TableColumn(schema);
                colvarTestCount.ColumnName = "Test_Count";
                colvarTestCount.DataType = DbType.Byte;
                colvarTestCount.MaxLength = 0;
                colvarTestCount.AutoIncrement = false;
                colvarTestCount.IsNullable = true;
                colvarTestCount.IsPrimaryKey = false;
                colvarTestCount.IsForeignKey = false;
                colvarTestCount.IsReadOnly = false;
                colvarTestCount.DefaultSetting = @"";
                colvarTestCount.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestCount);

                var colvarTestHasResult = new TableSchema.TableColumn(schema);
                colvarTestHasResult.ColumnName = "Test_Has_Result";
                colvarTestHasResult.DataType = DbType.Byte;
                colvarTestHasResult.MaxLength = 0;
                colvarTestHasResult.AutoIncrement = false;
                colvarTestHasResult.IsNullable = true;
                colvarTestHasResult.IsPrimaryKey = false;
                colvarTestHasResult.IsForeignKey = false;
                colvarTestHasResult.IsReadOnly = false;
                colvarTestHasResult.DefaultSetting = @"";
                colvarTestHasResult.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestHasResult);

                var colvarPrintStatus = new TableSchema.TableColumn(schema);
                colvarPrintStatus.ColumnName = "Print_Status";
                colvarPrintStatus.DataType = DbType.Byte;
                colvarPrintStatus.MaxLength = 0;
                colvarPrintStatus.AutoIncrement = false;
                colvarPrintStatus.IsNullable = true;
                colvarPrintStatus.IsPrimaryKey = false;
                colvarPrintStatus.IsForeignKey = false;
                colvarPrintStatus.IsReadOnly = false;
                colvarPrintStatus.DefaultSetting = @"";
                colvarPrintStatus.ForeignKeyTableName = "";
                schema.Columns.Add(colvarPrintStatus);

                var colvarHasAllResult = new TableSchema.TableColumn(schema);
                colvarHasAllResult.ColumnName = "Has_All_Result";
                colvarHasAllResult.DataType = DbType.Int16;
                colvarHasAllResult.MaxLength = 0;
                colvarHasAllResult.AutoIncrement = false;
                colvarHasAllResult.IsNullable = true;
                colvarHasAllResult.IsPrimaryKey = false;
                colvarHasAllResult.IsForeignKey = false;
                colvarHasAllResult.IsReadOnly = false;
                colvarHasAllResult.DefaultSetting = @"";
                colvarHasAllResult.ForeignKeyTableName = "";
                schema.Columns.Add(colvarHasAllResult);

                var colvarIsFinal = new TableSchema.TableColumn(schema);
                colvarIsFinal.ColumnName = "IsFinal";
                colvarIsFinal.DataType = DbType.Int16;
                colvarIsFinal.MaxLength = 0;
                colvarIsFinal.AutoIncrement = false;
                colvarIsFinal.IsNullable = true;
                colvarIsFinal.IsPrimaryKey = false;
                colvarIsFinal.IsForeignKey = false;
                colvarIsFinal.IsReadOnly = false;
                colvarIsFinal.DefaultSetting = @"";
                colvarIsFinal.ForeignKeyTableName = "";
                schema.Columns.Add(colvarIsFinal);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("L_PATIENT_INFO", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("PatientId")]
        [Bindable(true)]
        public decimal PatientId
        {
            get { return GetColumnValue<decimal>(Columns.PatientId); }
            set { SetColumnValue(Columns.PatientId, value); }
        }

        [XmlAttribute("Pid")]
        [Bindable(true)]
        public string Pid
        {
            get { return GetColumnValue<string>(Columns.Pid); }
            set { SetColumnValue(Columns.Pid, value); }
        }

        [XmlAttribute("PatientName")]
        [Bindable(true)]
        public string PatientName
        {
            get { return GetColumnValue<string>(Columns.PatientName); }
            set { SetColumnValue(Columns.PatientName, value); }
        }

        [XmlAttribute("Address")]
        [Bindable(true)]
        public string Address
        {
            get { return GetColumnValue<string>(Columns.Address); }
            set { SetColumnValue(Columns.Address, value); }
        }

        [XmlAttribute("YearBirth")]
        [Bindable(true)]
        public int? YearBirth
        {
            get { return GetColumnValue<int?>(Columns.YearBirth); }
            set { SetColumnValue(Columns.YearBirth, value); }
        }

        [XmlAttribute("Sex")]
        [Bindable(true)]
        public bool? Sex
        {
            get { return GetColumnValue<bool?>(Columns.Sex); }
            set { SetColumnValue(Columns.Sex, value); }
        }

        [XmlAttribute("InsuranceNum")]
        [Bindable(true)]
        public string InsuranceNum
        {
            get { return GetColumnValue<string>(Columns.InsuranceNum); }
            set { SetColumnValue(Columns.InsuranceNum, value); }
        }

        [XmlAttribute("Dateupdate")]
        [Bindable(true)]
        public DateTime? Dateupdate
        {
            get { return GetColumnValue<DateTime?>(Columns.Dateupdate); }
            set { SetColumnValue(Columns.Dateupdate, value); }
        }

        [XmlAttribute("Diagnostic")]
        [Bindable(true)]
        public string Diagnostic
        {
            get { return GetColumnValue<string>(Columns.Diagnostic); }
            set { SetColumnValue(Columns.Diagnostic, value); }
        }

        [XmlAttribute("IdentifyNum")]
        [Bindable(true)]
        public string IdentifyNum
        {
            get { return GetColumnValue<string>(Columns.IdentifyNum); }
            set { SetColumnValue(Columns.IdentifyNum, value); }
        }

        [XmlAttribute("DepartmentID")]
        [Bindable(true)]
        public short? DepartmentID
        {
            get { return GetColumnValue<short?>(Columns.DepartmentID); }
            set { SetColumnValue(Columns.DepartmentID, value); }
        }

        [XmlAttribute("Room")]
        [Bindable(true)]
        public string Room
        {
            get { return GetColumnValue<string>(Columns.Room); }
            set { SetColumnValue(Columns.Room, value); }
        }

        [XmlAttribute("Bed")]
        [Bindable(true)]
        public string Bed
        {
            get { return GetColumnValue<string>(Columns.Bed); }
            set { SetColumnValue(Columns.Bed, value); }
        }

        [XmlAttribute("ObjectType")]
        [Bindable(true)]
        public int? ObjectType
        {
            get { return GetColumnValue<int?>(Columns.ObjectType); }
            set { SetColumnValue(Columns.ObjectType, value); }
        }

        [XmlAttribute("HosStatus")]
        [Bindable(true)]
        public int? HosStatus
        {
            get { return GetColumnValue<int?>(Columns.HosStatus); }
            set { SetColumnValue(Columns.HosStatus, value); }
        }

        [XmlAttribute("Dob")]
        [Bindable(true)]
        public DateTime? Dob
        {
            get { return GetColumnValue<DateTime?>(Columns.Dob); }
            set { SetColumnValue(Columns.Dob, value); }
        }

        [XmlAttribute("LotID")]
        [Bindable(true)]
        public int? LotID
        {
            get { return GetColumnValue<int?>(Columns.LotID); }
            set { SetColumnValue(Columns.LotID, value); }
        }

        [XmlAttribute("CanLamSangId")]
        [Bindable(true)]
        public string CanLamSangId
        {
            get { return GetColumnValue<string>(Columns.CanLamSangId); }
            set { SetColumnValue(Columns.CanLamSangId, value); }
        }

        [XmlAttribute("TestCount")]
        [Bindable(true)]
        public byte? TestCount
        {
            get { return GetColumnValue<byte?>(Columns.TestCount); }
            set { SetColumnValue(Columns.TestCount, value); }
        }

        [XmlAttribute("TestHasResult")]
        [Bindable(true)]
        public byte? TestHasResult
        {
            get { return GetColumnValue<byte?>(Columns.TestHasResult); }
            set { SetColumnValue(Columns.TestHasResult, value); }
        }

        [XmlAttribute("PrintStatus")]
        [Bindable(true)]
        public byte? PrintStatus
        {
            get { return GetColumnValue<byte?>(Columns.PrintStatus); }
            set { SetColumnValue(Columns.PrintStatus, value); }
        }

        [XmlAttribute("HasAllResult")]
        [Bindable(true)]
        public short? HasAllResult
        {
            get { return GetColumnValue<short?>(Columns.HasAllResult); }
            set { SetColumnValue(Columns.HasAllResult, value); }
        }

        [XmlAttribute("IsFinal")]
        [Bindable(true)]
        public short? IsFinal
        {
            get { return GetColumnValue<short?>(Columns.IsFinal); }
            set { SetColumnValue(Columns.IsFinal, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varPid, string varPatientName, string varAddress, int? varYearBirth,
            bool? varSex, string varInsuranceNum, DateTime? varDateupdate, string varDiagnostic, string varIdentifyNum,
            short? varDepartmentID, string varRoom, string varBed, int? varObjectType, int? varHosStatus,
            DateTime? varDob, int? varLotID, string varCanLamSangId, byte? varTestCount, byte? varTestHasResult,
            byte? varPrintStatus, short? varHasAllResult, short? varIsFinal)
        {
            var item = new LPatientInfo();

            item.Pid = varPid;

            item.PatientName = varPatientName;

            item.Address = varAddress;

            item.YearBirth = varYearBirth;

            item.Sex = varSex;

            item.InsuranceNum = varInsuranceNum;

            item.Dateupdate = varDateupdate;

            item.Diagnostic = varDiagnostic;

            item.IdentifyNum = varIdentifyNum;

            item.DepartmentID = varDepartmentID;

            item.Room = varRoom;

            item.Bed = varBed;

            item.ObjectType = varObjectType;

            item.HosStatus = varHosStatus;

            item.Dob = varDob;

            item.LotID = varLotID;

            item.CanLamSangId = varCanLamSangId;

            item.TestCount = varTestCount;

            item.TestHasResult = varTestHasResult;

            item.PrintStatus = varPrintStatus;

            item.HasAllResult = varHasAllResult;

            item.IsFinal = varIsFinal;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(decimal varPatientId, string varPid, string varPatientName, string varAddress,
            int? varYearBirth, bool? varSex, string varInsuranceNum, DateTime? varDateupdate, string varDiagnostic,
            string varIdentifyNum, short? varDepartmentID, string varRoom, string varBed, int? varObjectType,
            int? varHosStatus, DateTime? varDob, int? varLotID, string varCanLamSangId, byte? varTestCount,
            byte? varTestHasResult, byte? varPrintStatus, short? varHasAllResult, short? varIsFinal)
        {
            var item = new LPatientInfo();

            item.PatientId = varPatientId;

            item.Pid = varPid;

            item.PatientName = varPatientName;

            item.Address = varAddress;

            item.YearBirth = varYearBirth;

            item.Sex = varSex;

            item.InsuranceNum = varInsuranceNum;

            item.Dateupdate = varDateupdate;

            item.Diagnostic = varDiagnostic;

            item.IdentifyNum = varIdentifyNum;

            item.DepartmentID = varDepartmentID;

            item.Room = varRoom;

            item.Bed = varBed;

            item.ObjectType = varObjectType;

            item.HosStatus = varHosStatus;

            item.Dob = varDob;

            item.LotID = varLotID;

            item.CanLamSangId = varCanLamSangId;

            item.TestCount = varTestCount;

            item.TestHasResult = varTestHasResult;

            item.PrintStatus = varPrintStatus;

            item.HasAllResult = varHasAllResult;

            item.IsFinal = varIsFinal;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn PatientIdColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn PidColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn PatientNameColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn AddressColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn YearBirthColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn SexColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn InsuranceNumColumn
        {
            get { return Schema.Columns[6]; }
        }


        public static TableSchema.TableColumn DateupdateColumn
        {
            get { return Schema.Columns[7]; }
        }


        public static TableSchema.TableColumn DiagnosticColumn
        {
            get { return Schema.Columns[8]; }
        }


        public static TableSchema.TableColumn IdentifyNumColumn
        {
            get { return Schema.Columns[9]; }
        }


        public static TableSchema.TableColumn DepartmentIDColumn
        {
            get { return Schema.Columns[10]; }
        }


        public static TableSchema.TableColumn RoomColumn
        {
            get { return Schema.Columns[11]; }
        }


        public static TableSchema.TableColumn BedColumn
        {
            get { return Schema.Columns[12]; }
        }


        public static TableSchema.TableColumn ObjectTypeColumn
        {
            get { return Schema.Columns[13]; }
        }


        public static TableSchema.TableColumn HosStatusColumn
        {
            get { return Schema.Columns[14]; }
        }


        public static TableSchema.TableColumn DobColumn
        {
            get { return Schema.Columns[15]; }
        }


        public static TableSchema.TableColumn LotIDColumn
        {
            get { return Schema.Columns[16]; }
        }


        public static TableSchema.TableColumn CanLamSangIdColumn
        {
            get { return Schema.Columns[17]; }
        }


        public static TableSchema.TableColumn TestCountColumn
        {
            get { return Schema.Columns[18]; }
        }


        public static TableSchema.TableColumn TestHasResultColumn
        {
            get { return Schema.Columns[19]; }
        }


        public static TableSchema.TableColumn PrintStatusColumn
        {
            get { return Schema.Columns[20]; }
        }


        public static TableSchema.TableColumn HasAllResultColumn
        {
            get { return Schema.Columns[21]; }
        }


        public static TableSchema.TableColumn IsFinalColumn
        {
            get { return Schema.Columns[22]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string PatientId = @"Patient_ID";
            public static string Pid = @"PID";
            public static string PatientName = @"Patient_Name";
            public static string Address = @"Address";
            public static string YearBirth = @"YEAR_BIRTH";
            public static string Sex = @"Sex";
            public static string InsuranceNum = @"Insurance_Num";
            public static string Dateupdate = @"DATEUPDATE";
            public static string Diagnostic = @"Diagnostic";
            public static string IdentifyNum = @"IdentifyNum";
            public static string DepartmentID = @"DepartmentID";
            public static string Room = @"Room";
            public static string Bed = @"Bed";
            public static string ObjectType = @"ObjectType";
            public static string HosStatus = @"Hos_Status";
            public static string Dob = @"DOB";
            public static string LotID = @"LotID";
            public static string CanLamSangId = @"CanLamSang_ID";
            public static string TestCount = @"Test_Count";
            public static string TestHasResult = @"Test_Has_Result";
            public static string PrintStatus = @"Print_Status";
            public static string HasAllResult = @"Has_All_Result";
            public static string IsFinal = @"IsFinal";
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