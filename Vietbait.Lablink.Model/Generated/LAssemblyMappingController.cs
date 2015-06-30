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
    /// Controller class for L_Assembly_Mapping
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class LAssemblyMappingController
    {
        // Preload our schema..
        LAssemblyMapping thisSchemaLoad = new LAssemblyMapping();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public LAssemblyMappingCollection FetchAll()
        {
            LAssemblyMappingCollection coll = new LAssemblyMappingCollection();
            Query qry = new Query(LAssemblyMapping.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LAssemblyMappingCollection FetchByID(object Id)
        {
            LAssemblyMappingCollection coll = new LAssemblyMappingCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public LAssemblyMappingCollection FetchByQuery(Query qry)
        {
            LAssemblyMappingCollection coll = new LAssemblyMappingCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (LAssemblyMapping.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (LAssemblyMapping.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string FormName,string FunctionName,string AssemblyName,string NamespaceX)
	    {
		    LAssemblyMapping item = new LAssemblyMapping();
		    
            item.FormName = FormName;
            
            item.FunctionName = FunctionName;
            
            item.AssemblyName = AssemblyName;
            
            item.NamespaceX = NamespaceX;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal Id,string FormName,string FunctionName,string AssemblyName,string NamespaceX)
	    {
		    LAssemblyMapping item = new LAssemblyMapping();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.FormName = FormName;
				
			item.FunctionName = FunctionName;
				
			item.AssemblyName = AssemblyName;
				
			item.NamespaceX = NamespaceX;
				
	        item.Save(UserName);
	    }
    }
}
