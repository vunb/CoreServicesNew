using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for T_Common_Para
    /// </summary>
    [DataObject]
    public class TCommonParaController
    {
        // Preload our schema..
        private TCommonPara thisSchemaLoad = new TCommonPara();
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
        public TCommonParaCollection FetchAll()
        {
            var coll = new TCommonParaCollection();
            var qry = new Query(TCommonPara.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TCommonParaCollection FetchByID(object MaxSID)
        {
            TCommonParaCollection coll = new TCommonParaCollection().Where("MaxSID", MaxSID).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TCommonParaCollection FetchByQuery(Query qry)
        {
            var coll = new TCommonParaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object MaxSID)
        {
            return (TCommonPara.Delete(MaxSID) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object MaxSID)
        {
            return (TCommonPara.Destroy(MaxSID) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int MaxSID)
        {
            var item = new TCommonPara();

            item.MaxSID = MaxSID;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int MaxSID)
        {
            var item = new TCommonPara();
            item.MarkOld();
            item.IsLoaded = true;

            item.MaxSID = MaxSID;

            item.Save(UserName);
        }
    }
}