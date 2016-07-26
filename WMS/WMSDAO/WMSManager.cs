using System;
using System.Collections.Generic;
using WMSDAO.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;


namespace WMSDAO
{
    public class WMSManager
    {
        public WMSManager()
        {
            ctx = new WMSContext();
        }
        protected WMSContext ctx;

        public string ConnectionString
        {
            get
            {
                return ctx.Database.Connection.ConnectionString;
            }
        }
    }
}
