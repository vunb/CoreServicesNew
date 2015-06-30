using System;
using System.ComponentModel;
using System.Threading;
using System.Web;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Controller class for L_RS232
    /// </summary>
    [DataObject]
    public class LRS232Controller
    {
        // Preload our schema..
        private LRS232 thisSchemaLoad = new LRS232();
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
        public LRS232Collection FetchAll()
        {
            var coll = new LRS232Collection();
            var qry = new Query(LRS232.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LRS232Collection FetchByID(object Id)
        {
            LRS232Collection coll = new LRS232Collection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LRS232Collection FetchByQuery(Query qry)
        {
            var coll = new LRS232Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (LRS232.Delete(Id) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (LRS232.Destroy(Id) == 1);
        }


        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Name, int BaudRate, int DataBits, int StopBits, int Parity, int Dtr, int Rts,
            string Description)
        {
            var item = new LRS232();

            item.Name = Name;

            item.BaudRate = BaudRate;

            item.DataBits = DataBits;

            item.StopBits = StopBits;

            item.Parity = Parity;

            item.Dtr = Dtr;

            item.Rts = Rts;

            item.Description = Description;


            item.Save(UserName);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Name, int BaudRate, int DataBits, int StopBits, int Parity, int Dtr, int Rts,
            string Description)
        {
            var item = new LRS232();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Name = Name;

            item.BaudRate = BaudRate;

            item.DataBits = DataBits;

            item.StopBits = StopBits;

            item.Parity = Parity;

            item.Dtr = Dtr;

            item.Rts = Rts;

            item.Description = Description;

            item.Save(UserName);
        }
    }
}