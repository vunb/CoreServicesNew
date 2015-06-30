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
    ///     Strongly-typed collection for the DDeviceTypeList class.
    /// </summary>
    [Serializable]
    public class DDeviceTypeListCollection : ActiveList<DDeviceTypeList, DDeviceTypeListCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>DDeviceTypeListCollection</returns>
        public DDeviceTypeListCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                DDeviceTypeList o = this[i];
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
    ///     This is an ActiveRecord class which wraps the D_DEVICE_TYPE_LIST table.
    /// </summary>
    [Serializable]
    public class DDeviceTypeList : ActiveRecord<DDeviceTypeList>, IActiveRecord
    {
        #region .ctors and Default Settings

        public DDeviceTypeList()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public DDeviceTypeList(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public DDeviceTypeList(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public DDeviceTypeList(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("D_DEVICE_TYPE_LIST", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarDeviceTypeId = new TableSchema.TableColumn(schema);
                colvarDeviceTypeId.ColumnName = "DeviceType_ID";
                colvarDeviceTypeId.DataType = DbType.Int32;
                colvarDeviceTypeId.MaxLength = 0;
                colvarDeviceTypeId.AutoIncrement = true;
                colvarDeviceTypeId.IsNullable = false;
                colvarDeviceTypeId.IsPrimaryKey = true;
                colvarDeviceTypeId.IsForeignKey = false;
                colvarDeviceTypeId.IsReadOnly = false;
                colvarDeviceTypeId.DefaultSetting = @"";
                colvarDeviceTypeId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDeviceTypeId);

                var colvarDeviceTypeName = new TableSchema.TableColumn(schema);
                colvarDeviceTypeName.ColumnName = "DeviceType_Name";
                colvarDeviceTypeName.DataType = DbType.String;
                colvarDeviceTypeName.MaxLength = 100;
                colvarDeviceTypeName.AutoIncrement = false;
                colvarDeviceTypeName.IsNullable = true;
                colvarDeviceTypeName.IsPrimaryKey = false;
                colvarDeviceTypeName.IsForeignKey = false;
                colvarDeviceTypeName.IsReadOnly = false;
                colvarDeviceTypeName.DefaultSetting = @"";
                colvarDeviceTypeName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDeviceTypeName);

                var colvarNote = new TableSchema.TableColumn(schema);
                colvarNote.ColumnName = "Note";
                colvarNote.DataType = DbType.String;
                colvarNote.MaxLength = 100;
                colvarNote.AutoIncrement = false;
                colvarNote.IsNullable = true;
                colvarNote.IsPrimaryKey = false;
                colvarNote.IsForeignKey = false;
                colvarNote.IsReadOnly = false;
                colvarNote.DefaultSetting = @"";
                colvarNote.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNote);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("D_DEVICE_TYPE_LIST", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("DeviceTypeId")]
        [Bindable(true)]
        public int DeviceTypeId
        {
            get { return GetColumnValue<int>(Columns.DeviceTypeId); }
            set { SetColumnValue(Columns.DeviceTypeId, value); }
        }

        [XmlAttribute("DeviceTypeName")]
        [Bindable(true)]
        public string DeviceTypeName
        {
            get { return GetColumnValue<string>(Columns.DeviceTypeName); }
            set { SetColumnValue(Columns.DeviceTypeName, value); }
        }

        [XmlAttribute("Note")]
        [Bindable(true)]
        public string Note
        {
            get { return GetColumnValue<string>(Columns.Note); }
            set { SetColumnValue(Columns.Note, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varDeviceTypeName, string varNote)
        {
            var item = new DDeviceTypeList();

            item.DeviceTypeName = varDeviceTypeName;

            item.Note = varNote;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(int varDeviceTypeId, string varDeviceTypeName, string varNote)
        {
            var item = new DDeviceTypeList();

            item.DeviceTypeId = varDeviceTypeId;

            item.DeviceTypeName = varDeviceTypeName;

            item.Note = varNote;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn DeviceTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn DeviceTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn NoteColumn
        {
            get { return Schema.Columns[2]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string DeviceTypeId = @"DeviceType_ID";
            public static string DeviceTypeName = @"DeviceType_Name";
            public static string Note = @"Note";
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