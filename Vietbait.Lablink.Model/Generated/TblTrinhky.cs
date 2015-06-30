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
    ///     Strongly-typed collection for the TblTrinhky class.
    /// </summary>
    [Serializable]
    public class TblTrinhkyCollection : ActiveList<TblTrinhky, TblTrinhkyCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblTrinhkyCollection</returns>
        public TblTrinhkyCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                TblTrinhky o = this[i];
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
    ///     This is an ActiveRecord class which wraps the tbl_Trinhky table.
    /// </summary>
    [Serializable]
    public class TblTrinhky : ActiveRecord<TblTrinhky>, IActiveRecord
    {
        #region .ctors and Default Settings

        public TblTrinhky()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public TblTrinhky(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public TblTrinhky(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public TblTrinhky(string columnName, object columnValue)
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
                var schema = new TableSchema.Table("tbl_Trinhky", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarReportName = new TableSchema.TableColumn(schema);
                colvarReportName.ColumnName = "ReportName";
                colvarReportName.DataType = DbType.String;
                colvarReportName.MaxLength = 100;
                colvarReportName.AutoIncrement = false;
                colvarReportName.IsNullable = false;
                colvarReportName.IsPrimaryKey = true;
                colvarReportName.IsForeignKey = false;
                colvarReportName.IsReadOnly = false;
                colvarReportName.DefaultSetting = @"";
                colvarReportName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarReportName);

                var colvarObjectName = new TableSchema.TableColumn(schema);
                colvarObjectName.ColumnName = "ObjectName";
                colvarObjectName.DataType = DbType.String;
                colvarObjectName.MaxLength = 100;
                colvarObjectName.AutoIncrement = false;
                colvarObjectName.IsNullable = false;
                colvarObjectName.IsPrimaryKey = true;
                colvarObjectName.IsForeignKey = false;
                colvarObjectName.IsReadOnly = false;
                colvarObjectName.DefaultSetting = @"";
                colvarObjectName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarObjectName);

                var colvarFontName = new TableSchema.TableColumn(schema);
                colvarFontName.ColumnName = "Font_Name";
                colvarFontName.DataType = DbType.String;
                colvarFontName.MaxLength = 50;
                colvarFontName.AutoIncrement = false;
                colvarFontName.IsNullable = true;
                colvarFontName.IsPrimaryKey = false;
                colvarFontName.IsForeignKey = false;
                colvarFontName.IsReadOnly = false;
                colvarFontName.DefaultSetting = @"";
                colvarFontName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFontName);

                var colvarFontSize = new TableSchema.TableColumn(schema);
                colvarFontSize.ColumnName = "Font_Size";
                colvarFontSize.DataType = DbType.Int32;
                colvarFontSize.MaxLength = 0;
                colvarFontSize.AutoIncrement = false;
                colvarFontSize.IsNullable = true;
                colvarFontSize.IsPrimaryKey = false;
                colvarFontSize.IsForeignKey = false;
                colvarFontSize.IsReadOnly = false;
                colvarFontSize.DefaultSetting = @"";
                colvarFontSize.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFontSize);

                var colvarFontStype = new TableSchema.TableColumn(schema);
                colvarFontStype.ColumnName = "Font_Stype";
                colvarFontStype.DataType = DbType.String;
                colvarFontStype.MaxLength = 50;
                colvarFontStype.AutoIncrement = false;
                colvarFontStype.IsNullable = true;
                colvarFontStype.IsPrimaryKey = false;
                colvarFontStype.IsForeignKey = false;
                colvarFontStype.IsReadOnly = false;
                colvarFontStype.DefaultSetting = @"";
                colvarFontStype.ForeignKeyTableName = "";
                schema.Columns.Add(colvarFontStype);

                var colvarObjectContent = new TableSchema.TableColumn(schema);
                colvarObjectContent.ColumnName = "ObjectContent";
                colvarObjectContent.DataType = DbType.String;
                colvarObjectContent.MaxLength = 2000;
                colvarObjectContent.AutoIncrement = false;
                colvarObjectContent.IsNullable = true;
                colvarObjectContent.IsPrimaryKey = false;
                colvarObjectContent.IsForeignKey = false;
                colvarObjectContent.IsReadOnly = false;
                colvarObjectContent.DefaultSetting = @"";
                colvarObjectContent.ForeignKeyTableName = "";
                schema.Columns.Add(colvarObjectContent);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("tbl_Trinhky", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("ReportName")]
        [Bindable(true)]
        public string ReportName
        {
            get { return GetColumnValue<string>(Columns.ReportName); }
            set { SetColumnValue(Columns.ReportName, value); }
        }

        [XmlAttribute("ObjectName")]
        [Bindable(true)]
        public string ObjectName
        {
            get { return GetColumnValue<string>(Columns.ObjectName); }
            set { SetColumnValue(Columns.ObjectName, value); }
        }

        [XmlAttribute("FontName")]
        [Bindable(true)]
        public string FontName
        {
            get { return GetColumnValue<string>(Columns.FontName); }
            set { SetColumnValue(Columns.FontName, value); }
        }

        [XmlAttribute("FontSize")]
        [Bindable(true)]
        public int? FontSize
        {
            get { return GetColumnValue<int?>(Columns.FontSize); }
            set { SetColumnValue(Columns.FontSize, value); }
        }

        [XmlAttribute("FontStype")]
        [Bindable(true)]
        public string FontStype
        {
            get { return GetColumnValue<string>(Columns.FontStype); }
            set { SetColumnValue(Columns.FontStype, value); }
        }

        [XmlAttribute("ObjectContent")]
        [Bindable(true)]
        public string ObjectContent
        {
            get { return GetColumnValue<string>(Columns.ObjectContent); }
            set { SetColumnValue(Columns.ObjectContent, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varReportName, string varObjectName, string varFontName, int? varFontSize,
            string varFontStype, string varObjectContent)
        {
            var item = new TblTrinhky();

            item.ReportName = varReportName;

            item.ObjectName = varObjectName;

            item.FontName = varFontName;

            item.FontSize = varFontSize;

            item.FontStype = varFontStype;

            item.ObjectContent = varObjectContent;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(string varReportName, string varObjectName, string varFontName, int? varFontSize,
            string varFontStype, string varObjectContent)
        {
            var item = new TblTrinhky();

            item.ReportName = varReportName;

            item.ObjectName = varObjectName;

            item.FontName = varFontName;

            item.FontSize = varFontSize;

            item.FontStype = varFontStype;

            item.ObjectContent = varObjectContent;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn ReportNameColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn ObjectNameColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn FontNameColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn FontSizeColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn FontStypeColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn ObjectContentColumn
        {
            get { return Schema.Columns[5]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string ReportName = @"ReportName";
            public static string ObjectName = @"ObjectName";
            public static string FontName = @"Font_Name";
            public static string FontSize = @"Font_Size";
            public static string FontStype = @"Font_Stype";
            public static string ObjectContent = @"ObjectContent";
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