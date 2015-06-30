using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for T_TEST_INFO
    /// </summary>
    [DataObject]
    public class TTestInfoController
    {
        // Preload our schema..
        private TTestInfo thisSchemaLoad = new TTestInfo();
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
        public TTestInfoCollection FetchAll()
        {
            var coll = new TTestInfoCollection();
            var qry = new Query(TTestInfo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTestInfoCollection FetchByID(object TestId)
        {
            TTestInfoCollection coll = new TTestInfoCollection().Where("Test_ID", TestId).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TTestInfoCollection FetchByQuery(Query qry)
        {
            var coll = new TTestInfoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object TestId)
        {
            return (TTestInfo.Delete(TestId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object TestId)
        {
            return (TTestInfo.Destroy(TestId) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(decimal? TestTypeId, string Barcode, string TestSeq, decimal? PatientId, DateTime? TestDate,
            DateTime? RequireDate, decimal? AssignId, decimal? DiagnosticianId, string ReceiverId, short? TestStatus,
            string DiagResult, string UpdateUser, DateTime? UpdateDate, string Lam, string CanLamSangId,
            decimal? DeviceId, int? PrintStatus, int? ResultCount, int? RegCount, int? RegNoResultCount)
        {
            var item = new TTestInfo();

            item.TestTypeId = TestTypeId;

            item.Barcode = Barcode;

            item.TestSeq = TestSeq;

            item.PatientId = PatientId;

            item.TestDate = TestDate;

            item.RequireDate = RequireDate;

            item.AssignId = AssignId;

            item.DiagnosticianId = DiagnosticianId;

            item.ReceiverId = ReceiverId;

            item.TestStatus = TestStatus;

            item.DiagResult = DiagResult;

            item.UpdateUser = UpdateUser;

            item.UpdateDate = UpdateDate;

            item.Lam = Lam;

            item.CanLamSangId = CanLamSangId;

            item.DeviceId = DeviceId;

            item.PrintStatus = PrintStatus;

            item.ResultCount = ResultCount;

            item.RegCount = RegCount;

            item.RegNoResultCount = RegNoResultCount;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(decimal TestId, decimal? TestTypeId, string Barcode, string TestSeq, decimal? PatientId,
            DateTime? TestDate, DateTime? RequireDate, decimal? AssignId, decimal? DiagnosticianId, string ReceiverId,
            short? TestStatus, string DiagResult, string UpdateUser, DateTime? UpdateDate, string Lam,
            string CanLamSangId, decimal? DeviceId, int? PrintStatus, int? ResultCount, int? RegCount,
            int? RegNoResultCount)
        {
            var item = new TTestInfo();
            item.MarkOld();
            item.IsLoaded = true;

            item.TestId = TestId;

            item.TestTypeId = TestTypeId;

            item.Barcode = Barcode;

            item.TestSeq = TestSeq;

            item.PatientId = PatientId;

            item.TestDate = TestDate;

            item.RequireDate = RequireDate;

            item.AssignId = AssignId;

            item.DiagnosticianId = DiagnosticianId;

            item.ReceiverId = ReceiverId;

            item.TestStatus = TestStatus;

            item.DiagResult = DiagResult;

            item.UpdateUser = UpdateUser;

            item.UpdateDate = UpdateDate;

            item.Lam = Lam;

            item.CanLamSangId = CanLamSangId;

            item.DeviceId = DeviceId;

            item.PrintStatus = PrintStatus;

            item.ResultCount = ResultCount;

            item.RegCount = RegCount;

            item.RegNoResultCount = RegNoResultCount;

            item.Save(UserName);
        }
    }
}