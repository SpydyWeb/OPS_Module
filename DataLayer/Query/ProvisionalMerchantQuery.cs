using DataLayer.DBClass;
using DataLayer.TableClass;
using Microsoft.AspNetCore.Identity;
using ModelLayer.AuthenticationModel;
using ModelLayer.ProvisionalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Query
{
   public class ProvisionalMerchantQuery
    {
        private readonly DBContext _dB;
        public ProvisionalMerchantQuery(DBContext dB)
        {
            _dB = dB;
        }
        public async Task<int> addprovisionalmerchantasync(ProvisionalMerchant provisional)
        {

        }
        }
}
