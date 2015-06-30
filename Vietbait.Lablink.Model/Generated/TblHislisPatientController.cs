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
    /// Controller class for tbl_HISLIS_Patients
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblHislisPatientController
    {
        // Preload our schema..
        TblHislisPatient thisSchemaLoad = new TblHislisPatient();
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
        public TblHislisPatientCollection FetchAll()
        {
            TblHislisPatientCollection coll = new TblHislisPatientCollection();
            Query qry = new Query(TblHislisPatient.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblHislisPatientCollection FetchByID(object Id)
        {
            TblHislisPatientCollection coll = new TblHislisPatientCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblHislisPatientCollection FetchByQuery(Query qry)
        {
            TblHislisPatientCollection coll = new TblHislisPatientCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TblHislisPatient.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TblHislisPatient.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string MaBN,string HoTen,string Tuoi,string GioiTinh,string SoPhong,string SoGiuong,string NgayTraKetQua,string BacSyChuyenKhoa,string Khoa,string DoiTuong,string ChanDoan,string LoaiChiDinh,string SoPhieuChiDinh,string TenPhieuXetNghiem,string NgayChiDinh,string BacSiChiDinh,string DaTra,string NhanXet,string IDKhoa,string IDBacSi,DateTime? NgayNhan)
	    {
		    TblHislisPatient item = new TblHislisPatient();
		    
            item.MaBN = MaBN;
            
            item.HoTen = HoTen;
            
            item.Tuoi = Tuoi;
            
            item.GioiTinh = GioiTinh;
            
            item.SoPhong = SoPhong;
            
            item.SoGiuong = SoGiuong;
            
            item.NgayTraKetQua = NgayTraKetQua;
            
            item.BacSyChuyenKhoa = BacSyChuyenKhoa;
            
            item.Khoa = Khoa;
            
            item.DoiTuong = DoiTuong;
            
            item.ChanDoan = ChanDoan;
            
            item.LoaiChiDinh = LoaiChiDinh;
            
            item.SoPhieuChiDinh = SoPhieuChiDinh;
            
            item.TenPhieuXetNghiem = TenPhieuXetNghiem;
            
            item.NgayChiDinh = NgayChiDinh;
            
            item.BacSiChiDinh = BacSiChiDinh;
            
            item.DaTra = DaTra;
            
            item.NhanXet = NhanXet;
            
            item.IDKhoa = IDKhoa;
            
            item.IDBacSi = IDBacSi;
            
            item.NgayNhan = NgayNhan;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string MaBN,string HoTen,string Tuoi,string GioiTinh,string SoPhong,string SoGiuong,string NgayTraKetQua,string BacSyChuyenKhoa,string Khoa,string DoiTuong,string ChanDoan,string LoaiChiDinh,string SoPhieuChiDinh,string TenPhieuXetNghiem,string NgayChiDinh,string BacSiChiDinh,string DaTra,string NhanXet,string IDKhoa,string IDBacSi,DateTime? NgayNhan)
	    {
		    TblHislisPatient item = new TblHislisPatient();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.MaBN = MaBN;
				
			item.HoTen = HoTen;
				
			item.Tuoi = Tuoi;
				
			item.GioiTinh = GioiTinh;
				
			item.SoPhong = SoPhong;
				
			item.SoGiuong = SoGiuong;
				
			item.NgayTraKetQua = NgayTraKetQua;
				
			item.BacSyChuyenKhoa = BacSyChuyenKhoa;
				
			item.Khoa = Khoa;
				
			item.DoiTuong = DoiTuong;
				
			item.ChanDoan = ChanDoan;
				
			item.LoaiChiDinh = LoaiChiDinh;
				
			item.SoPhieuChiDinh = SoPhieuChiDinh;
				
			item.TenPhieuXetNghiem = TenPhieuXetNghiem;
				
			item.NgayChiDinh = NgayChiDinh;
				
			item.BacSiChiDinh = BacSiChiDinh;
				
			item.DaTra = DaTra;
				
			item.NhanXet = NhanXet;
				
			item.IDKhoa = IDKhoa;
				
			item.IDBacSi = IDBacSi;
				
			item.NgayNhan = NgayNhan;
				
	        item.Save(UserName);
	    }
    }
}
