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
    ///     Strongly-typed collection for the DDataControl class.
    /// </summary>
    [Serializable]
    public class DDataControlCollection : ActiveList<DDataControl, DDataControlCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>DDataControlCollection</returns>
        public DDataControlCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                DDataControl o = this[i];
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
    ///     This is an ActiveRecord class which wraps the D_DATA_CONTROL table.
    /// </summary>
    [Serializable]
    public class DDataControl : ActiveRecord<DDataControl>, IActiveRecord
    {
        #region .ctors and Default Settings

        public DDataControl()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public DDataControl(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public DDataControl(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public DDataControl(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("D_DATA_CONTROL", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarDataControlId = new TableSchema.TableColumn(schema);
                colvarDataControlId.ColumnName = "DataControl_ID";
                colvarDataControlId.DataType = DbType.Decimal;
                colvarDataControlId.MaxLength = 0;
                colvarDataControlId.AutoIncrement = true;
                colvarDataControlId.IsNullable = false;
                colvarDataControlId.IsPrimaryKey = true;
                colvarDataControlId.IsForeignKey = false;
                colvarDataControlId.IsReadOnly = false;
                colvarDataControlId.DefaultSetting = @"";
                colvarDataControlId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataControlId);

                var colvarDeviceId = new TableSchema.TableColumn(schema);
                colvarDeviceId.ColumnName = "Device_ID";
                colvarDeviceId.DataType = DbType.Decimal;
                colvarDeviceId.MaxLength = 0;
                colvarDeviceId.AutoIncrement = false;
                colvarDeviceId.IsNullable = false;
                colvarDeviceId.IsPrimaryKey = false;
                colvarDeviceId.IsForeignKey = false;
                colvarDeviceId.IsReadOnly = false;
                colvarDeviceId.DefaultSetting = @"";
                colvarDeviceId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDeviceId);

                var colvarDataTypeId = new TableSchema.TableColumn(schema);
                colvarDataTypeId.ColumnName = "DataType_ID";
                colvarDataTypeId.DataType = DbType.Int32;
                colvarDataTypeId.MaxLength = 0;
                colvarDataTypeId.AutoIncrement = false;
                colvarDataTypeId.IsNullable = false;
                colvarDataTypeId.IsPrimaryKey = false;
                colvarDataTypeId.IsForeignKey = false;
                colvarDataTypeId.IsReadOnly = false;
                colvarDataTypeId.DefaultSetting = @"";
                colvarDataTypeId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataTypeId);

                var colvarDataSequence = new TableSchema.TableColumn(schema);
                colvarDataSequence.ColumnName = "Data_Sequence";
                colvarDataSequence.DataType = DbType.Int32;
                colvarDataSequence.MaxLength = 0;
                colvarDataSequence.AutoIncrement = false;
                colvarDataSequence.IsNullable = true;
                colvarDataSequence.IsPrimaryKey = false;
                colvarDataSequence.IsForeignKey = false;
                colvarDataSequence.IsReadOnly = false;
                colvarDataSequence.DefaultSetting = @"";
                colvarDataSequence.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataSequence);

                var colvarControlType = new TableSchema.TableColumn(schema);
                colvarControlType.ColumnName = "Control_Type";
                colvarControlType.DataType = DbType.Boolean;
                colvarControlType.MaxLength = 0;
                colvarControlType.AutoIncrement = false;
                colvarControlType.IsNullable = true;
                colvarControlType.IsPrimaryKey = false;
                colvarControlType.IsForeignKey = false;
                colvarControlType.IsReadOnly = false;
                colvarControlType.DefaultSetting = @"";
                colvarControlType.ForeignKeyTableName = "";
                schema.Columns.Add(colvarControlType);

                var colvarDataName = new TableSchema.TableColumn(schema);
                colvarDataName.ColumnName = "Data_Name";
                colvarDataName.DataType = DbType.String;
                colvarDataName.MaxLength = 50;
                colvarDataName.AutoIncrement = false;
                colvarDataName.IsNullable = false;
                colvarDataName.IsPrimaryKey = false;
                colvarDataName.IsForeignKey = false;
                colvarDataName.IsReadOnly = false;
                colvarDataName.DefaultSetting = @"";
                colvarDataName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataName);

                var colvarAliasName = new TableSchema.TableColumn(schema);
                colvarAliasName.ColumnName = "Alias_Name";
                colvarAliasName.DataType = DbType.String;
                colvarAliasName.MaxLength = 50;
                colvarAliasName.AutoIncrement = false;
                colvarAliasName.IsNullable = true;
                colvarAliasName.IsPrimaryKey = false;
                colvarAliasName.IsForeignKey = false;
                colvarAliasName.IsReadOnly = false;
                colvarAliasName.DefaultSetting = @"";
                colvarAliasName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarAliasName);

                var colvarMeasureUnit = new TableSchema.TableColumn(schema);
                colvarMeasureUnit.ColumnName = "Measure_Unit";
                colvarMeasureUnit.DataType = DbType.String;
                colvarMeasureUnit.MaxLength = 50;
                colvarMeasureUnit.AutoIncrement = false;
                colvarMeasureUnit.IsNullable = true;
                colvarMeasureUnit.IsPrimaryKey = false;
                colvarMeasureUnit.IsForeignKey = false;
                colvarMeasureUnit.IsReadOnly = false;
                colvarMeasureUnit.DefaultSetting = @"";
                colvarMeasureUnit.ForeignKeyTableName = "";
                schema.Columns.Add(colvarMeasureUnit);

                var colvarDataPoint = new TableSchema.TableColumn(schema);
                colvarDataPoint.ColumnName = "Data_Point";
                colvarDataPoint.DataType = DbType.Int16;
                colvarDataPoint.MaxLength = 0;
                colvarDataPoint.AutoIncrement = false;
                colvarDataPoint.IsNullable = false;
                colvarDataPoint.IsPrimaryKey = false;
                colvarDataPoint.IsForeignKey = false;
                colvarDataPoint.IsReadOnly = false;
                colvarDataPoint.DefaultSetting = @"";
                colvarDataPoint.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataPoint);

                var colvarNormalLevel = new TableSchema.TableColumn(schema);
                colvarNormalLevel.ColumnName = "Normal_Level";
                colvarNormalLevel.DataType = DbType.String;
                colvarNormalLevel.MaxLength = 100;
                colvarNormalLevel.AutoIncrement = false;
                colvarNormalLevel.IsNullable = true;
                colvarNormalLevel.IsPrimaryKey = false;
                colvarNormalLevel.IsForeignKey = false;
                colvarNormalLevel.IsReadOnly = false;
                colvarNormalLevel.DefaultSetting = @"";
                colvarNormalLevel.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNormalLevel);

                var colvarNormalLevelW = new TableSchema.TableColumn(schema);
                colvarNormalLevelW.ColumnName = "Normal_LevelW";
                colvarNormalLevelW.DataType = DbType.String;
                colvarNormalLevelW.MaxLength = 100;
                colvarNormalLevelW.AutoIncrement = false;
                colvarNormalLevelW.IsNullable = true;
                colvarNormalLevelW.IsPrimaryKey = false;
                colvarNormalLevelW.IsForeignKey = false;
                colvarNormalLevelW.IsReadOnly = false;
                colvarNormalLevelW.DefaultSetting = @"";
                colvarNormalLevelW.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNormalLevelW);

                var colvarDataView = new TableSchema.TableColumn(schema);
                colvarDataView.ColumnName = "Data_View";
                colvarDataView.DataType = DbType.Boolean;
                colvarDataView.MaxLength = 0;
                colvarDataView.AutoIncrement = false;
                colvarDataView.IsNullable = true;
                colvarDataView.IsPrimaryKey = false;
                colvarDataView.IsForeignKey = false;
                colvarDataView.IsReadOnly = false;
                colvarDataView.DefaultSetting = @"";
                colvarDataView.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataView);

                var colvarDataPrint = new TableSchema.TableColumn(schema);
                colvarDataPrint.ColumnName = "Data_Print";
                colvarDataPrint.DataType = DbType.Boolean;
                colvarDataPrint.MaxLength = 0;
                colvarDataPrint.AutoIncrement = false;
                colvarDataPrint.IsNullable = true;
                colvarDataPrint.IsPrimaryKey = false;
                colvarDataPrint.IsForeignKey = false;
                colvarDataPrint.IsReadOnly = false;
                colvarDataPrint.DefaultSetting = @"";
                colvarDataPrint.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataPrint);

                var colvarDataType = new TableSchema.TableColumn(schema);
                colvarDataType.ColumnName = "Data_Type";
                colvarDataType.DataType = DbType.String;
                colvarDataType.MaxLength = 50;
                colvarDataType.AutoIncrement = false;
                colvarDataType.IsNullable = true;
                colvarDataType.IsPrimaryKey = false;
                colvarDataType.IsForeignKey = false;
                colvarDataType.IsReadOnly = false;
                colvarDataType.DefaultSetting = @"";
                colvarDataType.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataType);

                var colvarDescription = new TableSchema.TableColumn(schema);
                colvarDescription.ColumnName = "Description";
                colvarDescription.DataType = DbType.String;
                colvarDescription.MaxLength = 200;
                colvarDescription.AutoIncrement = false;
                colvarDescription.IsNullable = true;
                colvarDescription.IsPrimaryKey = false;
                colvarDescription.IsForeignKey = false;
                colvarDescription.IsReadOnly = false;
                colvarDescription.DefaultSetting = @"";
                colvarDescription.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescription);

                var colvarTestDataId = new TableSchema.TableColumn(schema);
                colvarTestDataId.ColumnName = "TestData_ID";
                colvarTestDataId.DataType = DbType.String;
                colvarTestDataId.MaxLength = 100;
                colvarTestDataId.AutoIncrement = false;
                colvarTestDataId.IsNullable = true;
                colvarTestDataId.IsPrimaryKey = false;
                colvarTestDataId.IsForeignKey = false;
                colvarTestDataId.IsReadOnly = false;
                colvarTestDataId.DefaultSetting = @"";
                colvarTestDataId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestDataId);

                var colvarSCondition = new TableSchema.TableColumn(schema);
                colvarSCondition.ColumnName = "sCondition";
                colvarSCondition.DataType = DbType.String;
                colvarSCondition.MaxLength = 100;
                colvarSCondition.AutoIncrement = false;
                colvarSCondition.IsNullable = true;
                colvarSCondition.IsPrimaryKey = false;
                colvarSCondition.IsForeignKey = false;
                colvarSCondition.IsReadOnly = false;
                colvarSCondition.DefaultSetting = @"";
                colvarSCondition.ForeignKeyTableName = "";
                schema.Columns.Add(colvarSCondition);

                var colvarSFormula = new TableSchema.TableColumn(schema);
                colvarSFormula.ColumnName = "sFormula";
                colvarSFormula.DataType = DbType.String;
                colvarSFormula.MaxLength = 100;
                colvarSFormula.AutoIncrement = false;
                colvarSFormula.IsNullable = true;
                colvarSFormula.IsPrimaryKey = false;
                colvarSFormula.IsForeignKey = false;
                colvarSFormula.IsReadOnly = false;
                colvarSFormula.DefaultSetting = @"";
                colvarSFormula.ForeignKeyTableName = "";
                schema.Columns.Add(colvarSFormula);

                var colvarForceRun = new TableSchema.TableColumn(schema);
                colvarForceRun.ColumnName = "Force_Run";
                colvarForceRun.DataType = DbType.Int16;
                colvarForceRun.MaxLength = 0;
                colvarForceRun.AutoIncrement = false;
                colvarForceRun.IsNullable = true;
                colvarForceRun.IsPrimaryKey = false;
                colvarForceRun.IsForeignKey = false;
                colvarForceRun.IsReadOnly = false;
                colvarForceRun.DefaultSetting = @"";
                colvarForceRun.ForeignKeyTableName = "";
                schema.Columns.Add(colvarForceRun);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("D_DATA_CONTROL", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("DataControlId")]
        [Bindable(true)]
        public decimal DataControlId
        {
            get { return GetColumnValue<decimal>(Columns.DataControlId); }
            set { SetColumnValue(Columns.DataControlId, value); }
        }

        [XmlAttribute("DeviceId")]
        [Bindable(true)]
        public decimal DeviceId
        {
            get { return GetColumnValue<decimal>(Columns.DeviceId); }
            set { SetColumnValue(Columns.DeviceId, value); }
        }

        [XmlAttribute("DataTypeId")]
        [Bindable(true)]
        public int DataTypeId
        {
            get { return GetColumnValue<int>(Columns.DataTypeId); }
            set { SetColumnValue(Columns.DataTypeId, value); }
        }

        [XmlAttribute("DataSequence")]
        [Bindable(true)]
        public int? DataSequence
        {
            get { return GetColumnValue<int?>(Columns.DataSequence); }
            set { SetColumnValue(Columns.DataSequence, value); }
        }

        [XmlAttribute("ControlType")]
        [Bindable(true)]
        public bool? ControlType
        {
            get { return GetColumnValue<bool?>(Columns.ControlType); }
            set { SetColumnValue(Columns.ControlType, value); }
        }

        [XmlAttribute("DataName")]
        [Bindable(true)]
        public string DataName
        {
            get { return GetColumnValue<string>(Columns.DataName); }
            set { SetColumnValue(Columns.DataName, value); }
        }

        [XmlAttribute("AliasName")]
        [Bindable(true)]
        public string AliasName
        {
            get { return GetColumnValue<string>(Columns.AliasName); }
            set { SetColumnValue(Columns.AliasName, value); }
        }

        [XmlAttribute("MeasureUnit")]
        [Bindable(true)]
        public string MeasureUnit
        {
            get { return GetColumnValue<string>(Columns.MeasureUnit); }
            set { SetColumnValue(Columns.MeasureUnit, value); }
        }

        [XmlAttribute("DataPoint")]
        [Bindable(true)]
        public short DataPoint
        {
            get { return GetColumnValue<short>(Columns.DataPoint); }
            set { SetColumnValue(Columns.DataPoint, value); }
        }

        [XmlAttribute("NormalLevel")]
        [Bindable(true)]
        public string NormalLevel
        {
            get { return GetColumnValue<string>(Columns.NormalLevel); }
            set { SetColumnValue(Columns.NormalLevel, value); }
        }

        [XmlAttribute("NormalLevelW")]
        [Bindable(true)]
        public string NormalLevelW
        {
            get { return GetColumnValue<string>(Columns.NormalLevelW); }
            set { SetColumnValue(Columns.NormalLevelW, value); }
        }

        [XmlAttribute("DataView")]
        [Bindable(true)]
        public bool? DataView
        {
            get { return GetColumnValue<bool?>(Columns.DataView); }
            set { SetColumnValue(Columns.DataView, value); }
        }

        [XmlAttribute("DataPrint")]
        [Bindable(true)]
        public bool? DataPrint
        {
            get { return GetColumnValue<bool?>(Columns.DataPrint); }
            set { SetColumnValue(Columns.DataPrint, value); }
        }

        [XmlAttribute("DataType")]
        [Bindable(true)]
        public string DataType
        {
            get { return GetColumnValue<string>(Columns.DataType); }
            set { SetColumnValue(Columns.DataType, value); }
        }

        [XmlAttribute("Description")]
        [Bindable(true)]
        public string Description
        {
            get { return GetColumnValue<string>(Columns.Description); }
            set { SetColumnValue(Columns.Description, value); }
        }

        [XmlAttribute("TestDataId")]
        [Bindable(true)]
        public string TestDataId
        {
            get { return GetColumnValue<string>(Columns.TestDataId); }
            set { SetColumnValue(Columns.TestDataId, value); }
        }

        [XmlAttribute("SCondition")]
        [Bindable(true)]
        public string SCondition
        {
            get { return GetColumnValue<string>(Columns.SCondition); }
            set { SetColumnValue(Columns.SCondition, value); }
        }

        [XmlAttribute("SFormula")]
        [Bindable(true)]
        public string SFormula
        {
            get { return GetColumnValue<string>(Columns.SFormula); }
            set { SetColumnValue(Columns.SFormula, value); }
        }

        [XmlAttribute("ForceRun")]
        [Bindable(true)]
        public short? ForceRun
        {
            get { return GetColumnValue<short?>(Columns.ForceRun); }
            set { SetColumnValue(Columns.ForceRun, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(decimal varDeviceId, int varDataTypeId, int? varDataSequence, bool? varControlType,
            string varDataName, string varAliasName, string varMeasureUnit, short varDataPoint, string varNormalLevel,
            string varNormalLevelW, bool? varDataView, bool? varDataPrint, string varDataType, string varDescription,
            string varTestDataId, string varSCondition, string varSFormula, short? varForceRun)
        {
            var item = new DDataControl();

            item.DeviceId = varDeviceId;

            item.DataTypeId = varDataTypeId;

            item.DataSequence = varDataSequence;

            item.ControlType = varControlType;

            item.DataName = varDataName;

            item.AliasName = varAliasName;

            item.MeasureUnit = varMeasureUnit;

            item.DataPoint = varDataPoint;

            item.NormalLevel = varNormalLevel;

            item.NormalLevelW = varNormalLevelW;

            item.DataView = varDataView;

            item.DataPrint = varDataPrint;

            item.DataType = varDataType;

            item.Description = varDescription;

            item.TestDataId = varTestDataId;

            item.SCondition = varSCondition;

            item.SFormula = varSFormula;

            item.ForceRun = varForceRun;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(decimal varDataControlId, decimal varDeviceId, int varDataTypeId, int? varDataSequence,
            bool? varControlType, string varDataName, string varAliasName, string varMeasureUnit, short varDataPoint,
            string varNormalLevel, string varNormalLevelW, bool? varDataView, bool? varDataPrint, string varDataType,
            string varDescription, string varTestDataId, string varSCondition, string varSFormula, short? varForceRun)
        {
            var item = new DDataControl();

            item.DataControlId = varDataControlId;

            item.DeviceId = varDeviceId;

            item.DataTypeId = varDataTypeId;

            item.DataSequence = varDataSequence;

            item.ControlType = varControlType;

            item.DataName = varDataName;

            item.AliasName = varAliasName;

            item.MeasureUnit = varMeasureUnit;

            item.DataPoint = varDataPoint;

            item.NormalLevel = varNormalLevel;

            item.NormalLevelW = varNormalLevelW;

            item.DataView = varDataView;

            item.DataPrint = varDataPrint;

            item.DataType = varDataType;

            item.Description = varDescription;

            item.TestDataId = varTestDataId;

            item.SCondition = varSCondition;

            item.SFormula = varSFormula;

            item.ForceRun = varForceRun;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn DataControlIdColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn DeviceIdColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn DataTypeIdColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn DataSequenceColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn ControlTypeColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn DataNameColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn AliasNameColumn
        {
            get { return Schema.Columns[6]; }
        }


        public static TableSchema.TableColumn MeasureUnitColumn
        {
            get { return Schema.Columns[7]; }
        }


        public static TableSchema.TableColumn DataPointColumn
        {
            get { return Schema.Columns[8]; }
        }


        public static TableSchema.TableColumn NormalLevelColumn
        {
            get { return Schema.Columns[9]; }
        }


        public static TableSchema.TableColumn NormalLevelWColumn
        {
            get { return Schema.Columns[10]; }
        }


        public static TableSchema.TableColumn DataViewColumn
        {
            get { return Schema.Columns[11]; }
        }


        public static TableSchema.TableColumn DataPrintColumn
        {
            get { return Schema.Columns[12]; }
        }


        public static TableSchema.TableColumn DataTypeColumn
        {
            get { return Schema.Columns[13]; }
        }


        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[14]; }
        }


        public static TableSchema.TableColumn TestDataIdColumn
        {
            get { return Schema.Columns[15]; }
        }


        public static TableSchema.TableColumn SConditionColumn
        {
            get { return Schema.Columns[16]; }
        }


        public static TableSchema.TableColumn SFormulaColumn
        {
            get { return Schema.Columns[17]; }
        }


        public static TableSchema.TableColumn ForceRunColumn
        {
            get { return Schema.Columns[18]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string DataControlId = @"DataControl_ID";
            public static string DeviceId = @"Device_ID";
            public static string DataTypeId = @"DataType_ID";
            public static string DataSequence = @"Data_Sequence";
            public static string ControlType = @"Control_Type";
            public static string DataName = @"Data_Name";
            public static string AliasName = @"Alias_Name";
            public static string MeasureUnit = @"Measure_Unit";
            public static string DataPoint = @"Data_Point";
            public static string NormalLevel = @"Normal_Level";
            public static string NormalLevelW = @"Normal_LevelW";
            public static string DataView = @"Data_View";
            public static string DataPrint = @"Data_Print";
            public static string DataType = @"Data_Type";
            public static string Description = @"Description";
            public static string TestDataId = @"TestData_ID";
            public static string SCondition = @"sCondition";
            public static string SFormula = @"sFormula";
            public static string ForceRun = @"Force_Run";
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