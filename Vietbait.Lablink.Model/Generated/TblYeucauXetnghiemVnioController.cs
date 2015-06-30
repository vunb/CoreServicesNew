using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for tblYeucauXetnghiem_VNIO
    /// </summary>
    [DataObject]
    public class TblYeucauXetnghiemVnioController
    {
        // Preload our schema..
        private TblYeucauXetnghiemVnio thisSchemaLoad = new TblYeucauXetnghiemVnio();
        private string userName = String.Empty;

        protected string UserName
        {
            get
            {
                if (userName.Length == 0)
                {
                    if (HttpContext.Current != null)
                    {
                        userName = HttpContext.Current.User.Identity.Name;
                    }
                    else
                    {
                        userName = Thread.CurrentPrincipal.Identity.Name;
                    }
                }
                return userName;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TblYeucauXetnghiemVnioCollection FetchAll()
        {
            var coll = new TblYeucauXetnghiemVnioCollection();
            var qry = new Query(TblYeucauXetnghiemVnio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblYeucauXetnghiemVnioCollection FetchByID(object IdXetnghiem)
        {
            TblYeucauXetnghiemVnioCollection coll =
                new TblYeucauXetnghiemVnioCollection().Where("Id_Xetnghiem", IdXetnghiem).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblYeucauXetnghiemVnioCollection FetchByQuery(Query qry)
        {
            var coll = new TblYeucauXetnghiemVnioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdXetnghiem)
        {
            return (TblYeucauXetnghiemVnio.Delete(IdXetnghiem) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdXetnghiem)
        {
            return (TblYeucauXetnghiemVnio.Destroy(IdXetnghiem) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(short? IdCanLamSangThucHien, short? ThucHienCho, short? TrangThaiThucHien,
            short? YeuCauXetNghiemId, long? Id, string MaBenhNhan, string Barcode, int? TestTypeId, string Sophieu,
            DateTime? TestDate, bool? IsTestName, bool? SendStatus)
        {
            var item = new TblYeucauXetnghiemVnio();

            item.IdCanLamSangThucHien = IdCanLamSangThucHien;

            item.ThucHienCho = ThucHienCho;

            item.TrangThaiThucHien = TrangThaiThucHien;

            item.YeuCauXetNghiemId = YeuCauXetNghiemId;

            item.Id = Id;

            item.MaBenhNhan = MaBenhNhan;

            item.Barcode = Barcode;

            item.TestTypeId = TestTypeId;

            item.Sophieu = Sophieu;

            item.TestDate = TestDate;

            item.IsTestName = IsTestName;

            item.SendStatus = SendStatus;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(long IdXetnghiem, short? IdCanLamSangThucHien, short? ThucHienCho, short? TrangThaiThucHien,
            short? YeuCauXetNghiemId, long? Id, string MaBenhNhan, string Barcode, int? TestTypeId, string Sophieu,
            DateTime? TestDate, bool? IsTestName, bool? SendStatus)
        {
            var item = new TblYeucauXetnghiemVnio();
            item.MarkOld();
            item.IsLoaded = true;

            item.IdXetnghiem = IdXetnghiem;

            item.IdCanLamSangThucHien = IdCanLamSangThucHien;

            item.ThucHienCho = ThucHienCho;

            item.TrangThaiThucHien = TrangThaiThucHien;

            item.YeuCauXetNghiemId = YeuCauXetNghiemId;

            item.Id = Id;

            item.MaBenhNhan = MaBenhNhan;

            item.Barcode = Barcode;

            item.TestTypeId = TestTypeId;

            item.Sophieu = Sophieu;

            item.TestDate = TestDate;

            item.IsTestName = IsTestName;

            item.SendStatus = SendStatus;

            item.Save(UserName);
        }
    }
}