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
    /// Controller class for KETNOI_MAPPING_HIS_LIS
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class KetnoiMappingHisLiController
    {
        // Preload our schema..
        KetnoiMappingHisLi thisSchemaLoad = new KetnoiMappingHisLi();
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
        public KetnoiMappingHisLiCollection FetchAll()
        {
            KetnoiMappingHisLiCollection coll = new KetnoiMappingHisLiCollection();
            Query qry = new Query(KetnoiMappingHisLi.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public KetnoiMappingHisLiCollection FetchByID(object Id)
        {
            KetnoiMappingHisLiCollection coll = new KetnoiMappingHisLiCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public KetnoiMappingHisLiCollection FetchByQuery(Query qry)
        {
            KetnoiMappingHisLiCollection coll = new KetnoiMappingHisLiCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (KetnoiMappingHisLi.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (KetnoiMappingHisLi.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string HisMaDvu,string HisTenDvu,string HisMaNhom,string HisTenNhom,string LisMaVu,string LisTenDvu,string LisMaNhom,string LisTenNhom,string LisKieuMap)
	    {
		    KetnoiMappingHisLi item = new KetnoiMappingHisLi();
		    
            item.HisMaDvu = HisMaDvu;
            
            item.HisTenDvu = HisTenDvu;
            
            item.HisMaNhom = HisMaNhom;
            
            item.HisTenNhom = HisTenNhom;
            
            item.LisMaVu = LisMaVu;
            
            item.LisTenDvu = LisTenDvu;
            
            item.LisMaNhom = LisMaNhom;
            
            item.LisTenNhom = LisTenNhom;
            
            item.LisKieuMap = LisKieuMap;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string HisMaDvu,string HisTenDvu,string HisMaNhom,string HisTenNhom,string LisMaVu,string LisTenDvu,string LisMaNhom,string LisTenNhom,string LisKieuMap)
	    {
		    KetnoiMappingHisLi item = new KetnoiMappingHisLi();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.HisMaDvu = HisMaDvu;
				
			item.HisTenDvu = HisTenDvu;
				
			item.HisMaNhom = HisMaNhom;
				
			item.HisTenNhom = HisTenNhom;
				
			item.LisMaVu = LisMaVu;
				
			item.LisTenDvu = LisTenDvu;
				
			item.LisMaNhom = LisMaNhom;
				
			item.LisTenNhom = LisTenNhom;
				
			item.LisKieuMap = LisKieuMap;
				
	        item.Save(UserName);
	    }
    }
}