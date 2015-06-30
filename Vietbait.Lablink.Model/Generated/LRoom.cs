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
    ///     Strongly-typed collection for the LRoom class.
    /// </summary>
    [Serializable]
    public class LRoomCollection : ActiveList<LRoom, LRoomCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>LRoomCollection</returns>
        public LRoomCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                LRoom o = this[i];
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
    ///     This is an ActiveRecord class which wraps the L_Room table.
    /// </summary>
    [Serializable]
    public class LRoom : ActiveRecord<LRoom>, IActiveRecord
    {
        #region .ctors and Default Settings

        public LRoom()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public LRoom(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public LRoom(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public LRoom(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("L_Room", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int16;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = true;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = true;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                colvarId.DefaultSetting = @"";
                colvarId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarId);

                var colvarSName = new TableSchema.TableColumn(schema);
                colvarSName.ColumnName = "sName";
                colvarSName.DataType = DbType.String;
                colvarSName.MaxLength = 50;
                colvarSName.AutoIncrement = false;
                colvarSName.IsNullable = true;
                colvarSName.IsPrimaryKey = false;
                colvarSName.IsForeignKey = false;
                colvarSName.IsReadOnly = false;
                colvarSName.DefaultSetting = @"";
                colvarSName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarSName);

                var colvarSDesc = new TableSchema.TableColumn(schema);
                colvarSDesc.ColumnName = "sDesc";
                colvarSDesc.DataType = DbType.String;
                colvarSDesc.MaxLength = 150;
                colvarSDesc.AutoIncrement = false;
                colvarSDesc.IsNullable = true;
                colvarSDesc.IsPrimaryKey = false;
                colvarSDesc.IsForeignKey = false;
                colvarSDesc.IsReadOnly = false;
                colvarSDesc.DefaultSetting = @"";
                colvarSDesc.ForeignKeyTableName = "";
                schema.Columns.Add(colvarSDesc);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("L_Room", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("Id")]
        [Bindable(true)]
        public short Id
        {
            get { return GetColumnValue<short>(Columns.Id); }
            set { SetColumnValue(Columns.Id, value); }
        }

        [XmlAttribute("SName")]
        [Bindable(true)]
        public string SName
        {
            get { return GetColumnValue<string>(Columns.SName); }
            set { SetColumnValue(Columns.SName, value); }
        }

        [XmlAttribute("SDesc")]
        [Bindable(true)]
        public string SDesc
        {
            get { return GetColumnValue<string>(Columns.SDesc); }
            set { SetColumnValue(Columns.SDesc, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varSName, string varSDesc)
        {
            var item = new LRoom();

            item.SName = varSName;

            item.SDesc = varSDesc;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(short varId, string varSName, string varSDesc)
        {
            var item = new LRoom();

            item.Id = varId;

            item.SName = varSName;

            item.SDesc = varSDesc;

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


        public static TableSchema.TableColumn SNameColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn SDescColumn
        {
            get { return Schema.Columns[2]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string Id = @"ID";
            public static string SName = @"sName";
            public static string SDesc = @"sDesc";
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