using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hittafotbollsplaner.Models
{
    public class FotbollsplanerModels
    {
        public IEnumerable<fotbollsplaner> fotbollsplaner { get; set; }
        public IEnumerable<fotbollsplaner> senasteFotbollsplaner { get; set; }
        public IEnumerable<fotbollsplaner> AllaFotbollsplaner { get; set; }
        public string currLat { get; set; }
        public string currLon { get; set; }
    }
}