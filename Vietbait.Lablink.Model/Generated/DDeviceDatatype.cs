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
    ///     Strongly-typed collection for the DDeviceDatatype class.
    /// </summary>
    [Serializable]
    public class DDeviceDatatypeCollection : ActiveList<DDeviceDatatype, DDeviceDatatypeCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>DDeviceDatatypeCollection</returns>
        public DDeviceDatatypeCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                DDeviceDatatype o = this[i];
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
    ///     This is an ActiveRecord class which wraps the D_DEVICE_DATATYPE table.
    /// </summary>
    [Serializable]
    public class DDeviceDatatype : ActiveRecord<DDeviceDatatype>, IActiveRecord
    {
        #region .ctors and Default Settings

        public DDeviceDatatype()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public DDeviceDatatype(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public DDeviceDatatype(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public DDeviceDatatype(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("D_DEVICE_DATATYPE", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarDataTypeId = new TableSchema.TableColumn(schema);
                colvarDataTypeId.ColumnName = "DataType_ID";
                colvarDataTypeId.DataType = DbType.Decimal;
                colvarDataTypeId.MaxLength = 0;
                colvarDataTypeId.AutoIncrement = true;
                colvarDataTypeId.IsNullable = false;
                colvarDataTypeId.IsPrimaryKey = true;
                colvarDataTypeId.IsForeignKey = false;
                colvarDataTypeId.IsReadOnly = false;
                colvarDataTypeId.DefaultSetting = @"";
                colvarDataTypeId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataTypeId);

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

                var colvarDataTypeName = new TableSchema.TableColumn(schema);
                colvarDataTypeName.ColumnName = "DataType_Name";
                colvarDataTypeName.DataType = DbType.String;
                colvarDataTypeName.MaxLength = 100;
                colvarDataTypeName.AutoIncrement = false;
                colvarDataTypeName.IsNullable = true;
                colvarDataTypeName.IsPrimaryKey = false;
                colvarDataTypeName.IsForeignKey = false;
                colvarDataTypeName.IsReadOnly = false;
                colvarDataTypeName.DefaultSetting = @"";
                colvarDataTypeName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataTypeName);

                var colvarStartChar = new TableSchema.TableColumn(schema);
                colvarStartChar.ColumnName = "Start_Char";
                colvarStartChar.DataType = DbType.String;
                colvarStartChar.MaxLength = 50;
                colvarStartChar.AutoIncrement = false;
                colvarStartChar.IsNullable = true;
                colvarStartChar.IsPrimaryKey = false;
                colvarStartChar.IsForeignKey = false;
                colvarStartChar.IsReadOnly = false;
                colvarStartChar.DefaultSetting = @"";
                colvarStartChar.ForeignKeyTableName = "";
                schema.Columns.Add(colvarStartChar);

                var colvarStopChar = new TableSchema.TableColumn(schema);
                colvarStopChar.ColumnName = "Stop_Char";
                colvarStopChar.DataType = DbType.String;
                colvarStopChar.MaxLength = 50;
                colvarStopChar.AutoIncrement = false;
                colvarStopChar.IsNullable = true;
                colvarStopChar.IsPrimaryKey = false;
                colvarStopChar.IsForeignKey = false;
                colvarStopChar.IsReadOnly = false;
                colvarStopChar.DefaultSetting = @"";
                colvarStopChar.ForeignKeyTableName = "";
                schema.Columns.Add(colvarStopChar);

                var colvarSplitChar = new TableSchema.TableColumn(schema);
                colvarSplitChar.ColumnName = "Split_Char";
                colvarSplitChar.DataType = DbType.String;
                colvarSplitChar.MaxLength = 50;
                colvarSplitChar.AutoIncrement = false;
                colvarSplitChar.IsNullable = true;
                colvarSplitChar.IsPrimaryKey = false;
                colvarSplitChar.IsForeignKey = false;
                colvarSplitChar.IsReadOnly = false;
                colvarSplitChar.DefaultSetting = @"";
                colvarSplitChar.ForeignKeyTableName = "";
                schema.Columns.Add(colvarSplitChar);

                var colvarDescriptions = new TableSchema.TableColumn(schema);
                colvarDescriptions.ColumnName = "Descriptions";
                colvarDescriptions.DataType = DbType.String;
                colvarDescriptions.MaxLength = 100;
                colvarDescriptions.AutoIncrement = false;
                colvarDescriptions.IsNullable = true;
                colvarDescriptions.IsPrimaryKey = false;
                colvarDescriptions.IsForeignKey = false;
                colvarDescriptions.IsReadOnly = false;
                colvarDescriptions.DefaultSetting = @"";
                colvarDescriptions.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescriptions);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("D_DEVICE_DATATYPE", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("DataTypeId")]
        [Bindable(true)]
        public decimal DataTypeId
        {
            get { return GetColumnValue<decimal>(Columns.DataTypeId); }
            set { SetColumnValue(Columns.DataTypeId, value); }
        }

        [XmlAttribute("DeviceId")]
        [Bindable(true)]
        public decimal DeviceId
        {
            get { return GetColumnValue<decimal>(Columns.DeviceId); }
            set { SetColumnValue(Columns.DeviceId, value); }
        }

        [XmlAttribute("DataTypeName")]
        [Bindable(true)]
        public string DataTypeName
        {
            get { return GetColumnValue<string>(Columns.DataTypeName); }
            set { SetColumnValue(Columns.DataTypeName, value); }
        }

        [XmlAttribute("StartChar")]
        [Bindable(true)]
        public string StartChar
        {
            get { return GetColumnValue<string>(Columns.StartChar); }
            set { SetColumnValue(Columns.StartChar, value); }
        }

        [XmlAttribute("StopChar")]
        [Bindable(true)]
        public string StopChar
        {
            get { return GetColumnValue<string>(Columns.StopChar); }
            set { SetColumnValue(Columns.StopChar, value); }
        }

        [XmlAttribute("SplitChar")]
        [Bindable(true)]
        public string SplitChar
        {
            get { return GetColumnValue<string>(Columns.SplitChar); }
            set { SetColumnValue(Columns.SplitChar, value); }
        }

        [XmlAttribute("Descriptions")]
        [Bindable(true)]
        public string Descriptions
        {
            get { return GetColumnValue<string>(Columns.Descriptions); }
            set { SetColumnValue(Columns.Descriptions, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(decimal varDeviceId, string varDataTypeName, string varStartChar, string varStopChar,
            string varSplitChar, string varDescriptions)
        {
            var item = new DDeviceDatatype();

            item.DeviceId = varDeviceId;

            item.DataTypeName = varDataTypeName;

            item.StartChar = varStartChar;

            item.StopChar = varStopChar;

            item.SplitChar = varSplitChar;

            item.Descriptions = varDescriptions;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(decimal varDataTypeId, decimal varDeviceId, string varDataTypeName,
            string varStartChar, string varStopChar, string varSplitChar, string varDescriptions)
        {
            var item = new DDeviceDatatype();

            item.DataTypeId = varDataTypeId;

            item.DeviceId = varDeviceId;

            item.DataTypeName = varDataTypeName;

            item.StartChar = varStartChar;

            item.StopChar = varStopChar;

            item.SplitChar = varSplitChar;

            item.Descriptions = varDescriptions;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn DataTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn DeviceIdColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn DataTypeNameColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn StartCharColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn StopCharColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn SplitCharColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn DescriptionsColumn
        {
            get { return Schema.Columns[6]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string DataTypeId = @"DataType_ID";
            public static string DeviceId = @"Device_ID";
            public static string DataTypeName = @"DataType_Name";
            public static string StartChar = @"Start_Char";
            public static string StopChar = @"Stop_Char";
            public static string SplitChar = @"Split_Char";
            public static string Descriptions = @"Descriptions";
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