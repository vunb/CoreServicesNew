using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Vietbait.Lablink.Model
{
	/// <summary>
	/// Strongly-typed collection for the LAssemblyMapping class.
	/// </summary>
    [Serializable]
	public partial class LAssemblyMappingCollection : ActiveList<LAssemblyMapping, LAssemblyMappingCollection>
	{	   
		public LAssemblyMappingCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>LAssemblyMappingCollection</returns>
		public LAssemblyMappingCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                LAssemblyMapping o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the L_Assembly_Mapping table.
	/// </summary>
	[Serializable]
	public partial class LAssemblyMapping : ActiveRecord<LAssemblyMapping>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public LAssemblyMapping()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public LAssemblyMapping(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public LAssemblyMapping(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public LAssemblyMapping(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("L_Assembly_Mapping", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
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
				
				TableSchema.TableColumn colvarFormName = new TableSchema.TableColumn(schema);
				colvarFormName.ColumnName = "Form_Name";
				colvarFormName.DataType = DbType.AnsiString;
				colvarFormName.MaxLength = 50;
				colvarFormName.AutoIncrement = false;
				colvarFormName.IsNullable = true;
				colvarFormName.IsPrimaryKey = false;
				colvarFormName.IsForeignKey = false;
				colvarFormName.IsReadOnly = false;
				colvarFormName.DefaultSetting = @"";
				colvarFormName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFormName);
				
				TableSchema.TableColumn colvarFunctionName = new TableSchema.TableColumn(schema);
				colvarFunctionName.ColumnName = "Function_Name";
				colvarFunctionName.DataType = DbType.AnsiString;
				colvarFunctionName.MaxLength = 50;
				colvarFunctionName.AutoIncrement = false;
				colvarFunctionName.IsNullable = true;
				colvarFunctionName.IsPrimaryKey = false;
				colvarFunctionName.IsForeignKey = false;
				colvarFunctionName.IsReadOnly = false;
				colvarFunctionName.DefaultSetting = @"";
				colvarFunctionName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFunctionName);
				
				TableSchema.TableColumn colvarAssemblyName = new TableSchema.TableColumn(schema);
				colvarAssemblyName.ColumnName = "Assembly_Name";
				colvarAssemblyName.DataType = DbType.AnsiString;
				colvarAssemblyName.MaxLength = 50;
				colvarAssemblyName.AutoIncrement = false;
				colvarAssemblyName.IsNullable = true;
				colvarAssemblyName.IsPrimaryKey = false;
				colvarAssemblyName.IsForeignKey = false;
				colvarAssemblyName.IsReadOnly = false;
				colvarAssemblyName.DefaultSetting = @"";
				colvarAssemblyName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAssemblyName);
				
				TableSchema.TableColumn colvarNamespaceX = new TableSchema.TableColumn(schema);
				colvarNamespaceX.ColumnName = "Namespace";
				colvarNamespaceX.DataType = DbType.AnsiString;
				colvarNamespaceX.MaxLength = 50;
				colvarNamespaceX.AutoIncrement = false;
				colvarNamespaceX.IsNullable = true;
				colvarNamespaceX.IsPrimaryKey = false;
				colvarNamespaceX.IsForeignKey = false;
				colvarNamespaceX.IsReadOnly = false;
				colvarNamespaceX.DefaultSetting = @"";
				colvarNamespaceX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNamespaceX);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("L_Assembly_Mapping",schema);
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
		  
		[XmlAttribute("FormName")]
		[Bindable(true)]
		public string FormName 
		{
			get { return GetColumnValue<string>(Columns.FormName); }
			set { SetColumnValue(Columns.FormName, value); }
		}
		  
		[XmlAttribute("FunctionName")]
		[Bindable(true)]
		public string FunctionName 
		{
			get { return GetColumnValue<string>(Columns.FunctionName); }
			set { SetColumnValue(Columns.FunctionName, value); }
		}
		  
		[XmlAttribute("AssemblyName")]
		[Bindable(true)]
		public string AssemblyName 
		{
			get { return GetColumnValue<string>(Columns.AssemblyName); }
			set { SetColumnValue(Columns.AssemblyName, value); }
		}
		  
		[XmlAttribute("NamespaceX")]
		[Bindable(true)]
		public string NamespaceX 
		{
			get { return GetColumnValue<string>(Columns.NamespaceX); }
			set { SetColumnValue(Columns.NamespaceX, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFormName,string varFunctionName,string varAssemblyName,string varNamespaceX)
		{
			LAssemblyMapping item = new LAssemblyMapping();
			
			item.FormName = varFormName;
			
			item.FunctionName = varFunctionName;
			
			item.AssemblyName = varAssemblyName;
			
			item.NamespaceX = varNamespaceX;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varId,string varFormName,string varFunctionName,string varAssemblyName,string varNamespaceX)
		{
			LAssemblyMapping item = new LAssemblyMapping();
			
				item.Id = varId;
			
				item.FormName = varFormName;
			
				item.FunctionName = varFunctionName;
			
				item.AssemblyName = varAssemblyName;
			
				item.NamespaceX = varNamespaceX;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FormNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FunctionNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn AssemblyNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NamespaceXColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string FormName = @"Form_Name";
			 public static string FunctionName = @"Function_Name";
			 public static string AssemblyName = @"Assembly_Name";
			 public static string NamespaceX = @"Namespace";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
