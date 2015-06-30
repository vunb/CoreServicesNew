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
    ///     Strongly-typed collection for the LPatientInfoDeleted class.
    /// </summary>
    [Serializable]
    public class LPatientInfoDeletedCollection : ActiveList<LPatientInfoDeleted, LPatientInfoDeletedCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>LPatientInfoDeletedCollection</returns>
        public LPatientInfoDeletedCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                LPatientInfoDeleted o = this[i];
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
    ///     This is an ActiveRecord class which wraps the L_PATIENT_INFO_DELETED table.
    /// </summary>
    [Serializable]
    public class LPatientInfoDeleted : ActiveRecord<LPatientInfoDeleted>, IActiveRecord
    {
        #region .ctors and Default Settings

        public LPatientInfoDeleted()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public LPatientInfoDeleted(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public LPatientInfoDeleted(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public LPatientInfoDeleted(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("L_PATIENT_INFO_DELETED", TableType.Table,
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

                var colvarAge = new TableSchema.TableColumn(schema);
                colvarAge.ColumnName = "Age";
                colvarAge.DataType = DbType.Int16;
                colvarAge.MaxLength = 0;
                colvarAge.AutoIncrement = false;
                colvarAge.IsNullable = true;
                colvarAge.IsPrimaryKey = false;
                colvarAge.IsForeignKey = false;
                colvarAge.IsReadOnly = false;
                colvarAge.DefaultSetting = @"";
                colvarAge.ForeignKeyTableName = "";
                schema.Columns.Add(colvarAge);

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
                colvarSex.DataType = DbType.Byte;
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
                colvarObjectType.DataType = DbType.Int16;
                colvarObjectType.MaxLength = 0;
                colvarObjectType.AutoIncrement = false;
                colvarObjectType.IsNullable = true;
                colvarObjectType.IsPrimaryKey = false;
                colvarObjectType.IsForeignKey = false;
                colvarObjectType.IsReadOnly = false;
                colvarObjectType.DefaultSetting = @"";
                colvarObjectType.ForeignKeyTableName = "";
                schema.Columns.Add(colvarObjectType);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("L_PATIENT_INFO_DELETED", schema);
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

        [XmlAttribute("PatientId")]
        [Bindable(true)]
        public decimal? PatientId
        {
            get { return GetColumnValue<decimal?>(Columns.PatientId); }
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

        [XmlAttribute("Age")]
        [Bindable(true)]
        public short? Age
        {
            get { return GetColumnValue<short?>(Columns.Age); }
            set { SetColumnValue(Columns.Age, value); }
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
        public byte? Sex
        {
            get { return GetColumnValue<byte?>(Columns.Sex); }
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
        public short? ObjectType
        {
            get { return GetColumnValue<short?>(Columns.ObjectType); }
            set { SetColumnValue(Columns.ObjectType, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(decimal? varPatientId, string varPid, string varPatientName, string varAddress,
            short? varAge, int? varYearBirth, byte? varSex, string varInsuranceNum, DateTime? varDateupdate,
            string varDiagnostic, string varIdentifyNum, short? varDepartmentID, string varRoom, string varBed,
            short? varObjectType)
        {
            var item = new LPatientInfoDeleted();

            item.PatientId = varPatientId;

            item.Pid = varPid;

            item.PatientName = varPatientName;

            item.Address = varAddress;

            item.Age = varAge;

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


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(decimal varId, decimal? varPatientId, string varPid, string varPatientName,
            string varAddress, short? varAge, int? varYearBirth, byte? varSex, string varInsuranceNum,
            DateTime? varDateupdate, string varDiagnostic, string varIdentifyNum, short? varDepartmentID, string varRoom,
            string varBed, short? varObjectType)
        {
            var item = new LPatientInfoDeleted();

            item.Id = varId;

            item.PatientId = varPatientId;

            item.Pid = varPid;

            item.PatientName = varPatientName;

            item.Address = varAddress;

            item.Age = varAge;

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


        public static TableSchema.TableColumn PatientIdColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn PidColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn PatientNameColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn AddressColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn AgeColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn YearBirthColumn
        {
            get { return Schema.Columns[6]; }
        }


        public static TableSchema.TableColumn SexColumn
        {
            get { return Schema.Columns[7]; }
        }


        public static TableSchema.TableColumn InsuranceNumColumn
        {
            get { return Schema.Columns[8]; }
        }


        public static TableSchema.TableColumn DateupdateColumn
        {
            get { return Schema.Columns[9]; }
        }


        public static TableSchema.TableColumn DiagnosticColumn
        {
            get { return Schema.Columns[10]; }
        }


        public static TableSchema.TableColumn IdentifyNumColumn
        {
            get { return Schema.Columns[11]; }
        }


        public static TableSchema.TableColumn DepartmentIDColumn
        {
            get { return Schema.Columns[12]; }
        }


        public static TableSchema.TableColumn RoomColumn
        {
            get { return Schema.Columns[13]; }
        }


        public static TableSchema.TableColumn BedColumn
        {
            get { return Schema.Columns[14]; }
        }


        public static TableSchema.TableColumn ObjectTypeColumn
        {
            get { return Schema.Columns[15]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string Id = @"Id";
            public static string PatientId = @"Patient_ID";
            public static string Pid = @"PID";
            public static string PatientName = @"Patient_Name";
            public static string Address = @"Address";
            public static string Age = @"Age";
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