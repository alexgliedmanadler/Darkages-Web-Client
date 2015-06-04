using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Data;

namespace Darkages_Web_Client.Models
{
    public class Index
    {
        private DateTime timenow;
        public DateTime TimeNow
        {
            get
            {
                return timenow;
            }
            set
            {
                this.timenow = value;
            }
        }

        public async Task<Index> GetTimeNowAsync()
        {
            return await Task.Run<Index>(() =>
            {
               this.timenow = DateTime.Now;
               return this;
            });
        }

        
    }
}