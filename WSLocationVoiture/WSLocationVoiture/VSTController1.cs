using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WSLocationVoiture
{
    public class VSTController1 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<station_taxi> GetStationTaxi()
        {
            location_dbEntities entities = new location_dbEntities();
            return entities.station_taxi;
        }

        public IEnumerable<voiture> GetAgenceLocation()
        {
            location_dbEntities entities = new location_dbEntities();
            return entities.voitures;
        }
    }
}
