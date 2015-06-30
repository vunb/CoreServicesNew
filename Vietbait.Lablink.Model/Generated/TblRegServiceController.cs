using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for tbl_RegService
    /// </summary>
    [DataObject]
    public class TblRegServiceController
    {
        // Preload our schema..
        private TblRegService thisSchemaLoad = new TblRegService();
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
        public TblRegServiceCollection FetchAll()
        {
            var coll = new TblRegServiceCollection();
            var qry = new Query(TblRegService.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblRegServiceCollection FetchByID(object RegID)
        {
            TblRegServiceCollection coll = new TblRegServiceCollection().Where("RegID", RegID).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblRegServiceCollection FetchByQuery(Query qry)
        {
            var coll = new TblRegServiceCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object RegID)
        {
            return (TblRegService.Delete(RegID) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object RegID)
        {
            return (TblRegService.Destroy(RegID) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(long PatientID, DateTime TestDate, string RegNo, short ServiceType, short RegType,
            short? NTime, decimal? TotalMoney, string SDesc)
        {
            var item = new TblRegService();

            item.PatientID = PatientID;

            item.TestDate = TestDate;

            item.RegNo = RegNo;

            item.ServiceType = ServiceType;

            item.RegType = RegType;

            item.NTime = NTime;

            item.TotalMoney = TotalMoney;

            item.SDesc = SDesc;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(long RegID, long PatientID, DateTime TestDate, string RegNo, short ServiceType, short RegType,
            short? NTime, decimal? TotalMoney, string SDesc)
        {
            var item = new TblRegService();
            item.MarkOld();
            item.IsLoaded = true;

            item.RegID = RegID;

            item.PatientID = PatientID;

            item.TestDate = TestDate;

            item.RegNo = RegNo;

            item.ServiceType = ServiceType;

            item.RegType = RegType;

            item.NTime = NTime;

            item.TotalMoney = TotalMoney;

            item.SDesc = SDesc;

            item.Save(UserName);
        }
    }
}