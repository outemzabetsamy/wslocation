using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WSLocationVoiture
{
    /*
     INSERT INTO voiture(id, name, adresse, phoneNumber, email, image) 
     select 2, 'SamirLoc','23 city seghir Bejaia', '0540121065', 'samirelocàgmail.com',BulkColumn from openrowset
	 (bulk 'C:\Users\limitless\Desktop\MyStore-icnBlanc.png', SINGLE_BLOB) as image
    */
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<voiture> GetAgenceLocation()
        {
            VSTController1 vc = new VSTController1();
            return vc.GetAgenceLocation().ToList();
        }

        [WebMethod]
        public List<station_taxi> GetStationTaxi()
        {
            VSTController1 vc = new VSTController1();
            return vc.GetStationTaxi().ToList();
        }
    }
}
