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
    ///     Strongly-typed collection for the LRS232 class.
    /// </summary>
    [Serializable]
    public class LRS232Collection : ActiveList<LRS232, LRS232Collection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>LRS232Collection</returns>
        public LRS232Collection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                LRS232 o = this[i];
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
    ///     This is an ActiveRecord class which wraps the L_RS232 table.
    /// </summary>
    [Serializable]
    public class LRS232 : ActiveRecord<LRS232>, IActiveRecord
    {
        #region .ctors and Default Settings

        public LRS232()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public LRS232(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public LRS232(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public LRS232(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("L_RS232", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = true;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = true;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                colvarId.DefaultSetting = @"";
                colvarId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarId);

                var colvarName = new TableSchema.TableColumn(schema);
                colvarName.ColumnName = "Name";
                colvarName.DataType = DbType.String;
                colvarName.MaxLength = 20;
                colvarName.AutoIncrement = false;
                colvarName.IsNullable = false;
                colvarName.IsPrimaryKey = false;
                colvarName.IsForeignKey = false;
                colvarName.IsReadOnly = false;
                colvarName.DefaultSetting = @"";
                colvarName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarName);

                var colvarBaudRate = new TableSchema.TableColumn(schema);
                colvarBaudRate.ColumnName = "BaudRate";
                colvarBaudRate.DataType = DbType.Int32;
                colvarBaudRate.MaxLength = 0;
                colvarBaudRate.AutoIncrement = false;
                colvarBaudRate.IsNullable = false;
                colvarBaudRate.IsPrimaryKey = false;
                colvarBaudRate.IsForeignKey = false;
                colvarBaudRate.IsReadOnly = false;
                colvarBaudRate.DefaultSetting = @"";
                colvarBaudRate.ForeignKeyTableName = "";
                schema.Columns.Add(colvarBaudRate);

                var colvarDataBits = new TableSchema.TableColumn(schema);
                colvarDataBits.ColumnName = "DataBits";
                colvarDataBits.DataType = DbType.Int32;
                colvarDataBits.MaxLength = 0;
                colvarDataBits.AutoIncrement = false;
                colvarDataBits.IsNullable = false;
                colvarDataBits.IsPrimaryKey = false;
                colvarDataBits.IsForeignKey = false;
                colvarDataBits.IsReadOnly = false;
                colvarDataBits.DefaultSetting = @"";
                colvarDataBits.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataBits);

                var colvarStopBits = new TableSchema.TableColumn(schema);
                colvarStopBits.ColumnName = "StopBits";
                colvarStopBits.DataType = DbType.Int32;
                colvarStopBits.MaxLength = 0;
                colvarStopBits.AutoIncrement = false;
                colvarStopBits.IsNullable = false;
                colvarStopBits.IsPrimaryKey = false;
                colvarStopBits.IsForeignKey = false;
                colvarStopBits.IsReadOnly = false;
                colvarStopBits.DefaultSetting = @"";
                colvarStopBits.ForeignKeyTableName = "";
                schema.Columns.Add(colvarStopBits);

                var colvarParity = new TableSchema.TableColumn(schema);
                colvarParity.ColumnName = "Parity";
                colvarParity.DataType = DbType.Int32;
                colvarParity.MaxLength = 0;
                colvarParity.AutoIncrement = false;
                colvarParity.IsNullable = false;
                colvarParity.IsPrimaryKey = false;
                colvarParity.IsForeignKey = false;
                colvarParity.IsReadOnly = false;
                colvarParity.DefaultSetting = @"";
                colvarParity.ForeignKeyTableName = "";
                schema.Columns.Add(colvarParity);

                var colvarDtr = new TableSchema.TableColumn(schema);
                colvarDtr.ColumnName = "DTR";
                colvarDtr.DataType = DbType.Int32;
                colvarDtr.MaxLength = 0;
                colvarDtr.AutoIncrement = false;
                colvarDtr.IsNullable = false;
                colvarDtr.IsPrimaryKey = false;
                colvarDtr.IsForeignKey = false;
                colvarDtr.IsReadOnly = false;

                colvarDtr.DefaultSetting = @"((0))";
                colvarDtr.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDtr);

                var colvarRts = new TableSchema.TableColumn(schema);
                colvarRts.ColumnName = "RTS";
                colvarRts.DataType = DbType.Int32;
                colvarRts.MaxLength = 0;
                colvarRts.AutoIncrement = false;
                colvarRts.IsNullable = false;
                colvarRts.IsPrimaryKey = false;
                colvarRts.IsForeignKey = false;
                colvarRts.IsReadOnly = false;

                colvarRts.DefaultSetting = @"((0))";
                colvarRts.ForeignKeyTableName = "";
                schema.Columns.Add(colvarRts);

                var colvarDescription = new TableSchema.TableColumn(schema);
                colvarDescription.ColumnName = "Description";
                colvarDescription.DataType = DbType.String;
                colvarDescription.MaxLength = 500;
                colvarDescription.AutoIncrement = false;
                colvarDescription.IsNullable = true;
                colvarDescription.IsPrimaryKey = false;
                colvarDescription.IsForeignKey = false;
                colvarDescription.IsReadOnly = false;
                colvarDescription.DefaultSetting = @"";
                colvarDescription.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescription);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("L_RS232", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id
        {
            get { return GetColumnValue<int>(Columns.Id); }
            set { SetColumnValue(Columns.Id, value); }
        }

        [XmlAttribute("Name")]
        [Bindable(true)]
        public string Name
        {
            get { return GetColumnValue<string>(Columns.Name); }
            set { SetColumnValue(Columns.Name, value); }
        }

        [XmlAttribute("BaudRate")]
        [Bindable(true)]
        public int BaudRate
        {
            get { return GetColumnValue<int>(Columns.BaudRate); }
            set { SetColumnValue(Columns.BaudRate, value); }
        }

        [XmlAttribute("DataBits")]
        [Bindable(true)]
        public int DataBits
        {
            get { return GetColumnValue<int>(Columns.DataBits); }
            set { SetColumnValue(Columns.DataBits, value); }
        }

        [XmlAttribute("StopBits")]
        [Bindable(true)]
        public int StopBits
        {
            get { return GetColumnValue<int>(Columns.StopBits); }
            set { SetColumnValue(Columns.StopBits, value); }
        }

        [XmlAttribute("Parity")]
        [Bindable(true)]
        public int Parity
        {
            get { return GetColumnValue<int>(Columns.Parity); }
            set { SetColumnValue(Columns.Parity, value); }
        }

        [XmlAttribute("Dtr")]
        [Bindable(true)]
        public int Dtr
        {
            get { return GetColumnValue<int>(Columns.Dtr); }
            set { SetColumnValue(Columns.Dtr, value); }
        }

        [XmlAttribute("Rts")]
        [Bindable(true)]
        public int Rts
        {
            get { return GetColumnValue<int>(Columns.Rts); }
            set { SetColumnValue(Columns.Rts, value); }
        }

        [XmlAttribute("Description")]
        [Bindable(true)]
        public string Description
        {
            get { return GetColumnValue<string>(Columns.Description); }
            set { SetColumnValue(Columns.Description, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varName, int varBaudRate, int varDataBits, int varStopBits, int varParity,
            int varDtr, int varRts, string varDescription)
        {
            var item = new LRS232();

            item.Name = varName;

            item.BaudRate = varBaudRate;

            item.DataBits = varDataBits;

            item.StopBits = varStopBits;

            item.Parity = varParity;

            item.Dtr = varDtr;

            item.Rts = varRts;

            item.Description = varDescription;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varId, string varName, int varBaudRate, int varDataBits, int varStopBits,
            int varParity, int varDtr, int varRts, string varDescription)
        {
            var item = new LRS232();

            item.Id = varId;

            item.Name = varName;

            item.BaudRate = varBaudRate;

            item.DataBits = varDataBits;

            item.StopBits = varStopBits;

            item.Parity = varParity;

            item.Dtr = varDtr;

            item.Rts = varRts;

            item.Description = varDescription;

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


        public static TableSchema.TableColumn NameColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn BaudRateColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn DataBitsColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn StopBitsColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn ParityColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn DtrColumn
        {
            get { return Schema.Columns[6]; }
        }


        public static TableSchema.TableColumn RtsColumn
        {
            get { return Schema.Columns[7]; }
        }


        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[8]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string Id = @"ID";
            public static string Name = @"Name";
            public static string BaudRate = @"BaudRate";
            public static string DataBits = @"DataBits";
            public static string StopBits = @"StopBits";
            public static string Parity = @"Parity";
            public static string Dtr = @"DTR";
            public static string Rts = @"RTS";
            public static string Description = @"Description";
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