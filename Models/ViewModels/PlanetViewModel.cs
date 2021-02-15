using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.ViewModels
{
    public class PlanetViewModel
    {
        public IEnumerable<PlanetVM> Planets { get; set; }

    }


    public class PlanetVM
    {
        public string name { get; set; }
      
        public string url { get; set; }
    }
}
