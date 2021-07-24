using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OPS_Module.Controllers
{
    public class MiscController : Controller
    {
        public class locationdetail
        {
            public string city { get; set; }
            public string state { get; set; }
        }
        [Route("state")]
        public JsonResult getstate(string pincode)
        {
            locationdetail ven = new locationdetail();
            string url = "https://maps.googleapis.com/maps/api/geocode/xml?address=" + pincode + "&region=India&key=AIzaSyDiRYxYLdTMgzVgM_eAX_p2WntX9avdCq4";
            var result = new System.Net.WebClient().DownloadString(url);
            var xmlElm = XElement.Parse(result);
            var status = (from elm in xmlElm.Descendants()
                          where
                              elm.Name == "status"
                          select elm).FirstOrDefault();
            if (status.Value.ToLower() == "ok")
            {
                
                //get the address_component element  
                var addressResult = (from elm in xmlElm.Descendants()
                                     where
                                         elm.Name == "address_component"
                                     select elm);
                foreach (XElement element in addressResult)
                {
                    string type = element.Elements().Where(e => e.Name.LocalName == "type").FirstOrDefault().Value;

                    if (type.ToLower().Trim() == "locality") //if type is locality the get the locality  
                    {
                        ven.city = element.Elements().Where(e => e.Name.LocalName == "long_name").Single().Value;
                    }
                    else
                    {
                        if (type.ToLower().Trim() == "administrative_area_level_2" && string.IsNullOrEmpty(ven.city))
                        {
                            ven.city = element.Elements().Where(e => e.Name.LocalName == "long_name").Single().Value;
                        }
                    }
                    if (type.ToLower().Trim() == "administrative_area_level_1") //if type is locality the get the locality  
                    {
                        ven.state = element.Elements().Where(e => e.Name.LocalName == "long_name").Single().Value;
                    }
                }
            }
            return new JsonResult(ven);
        }
    }
}
