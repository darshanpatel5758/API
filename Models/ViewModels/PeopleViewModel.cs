using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.ViewModels
{
    public class PeopleViewModel
    {

        public IEnumerable<PeopleVM> Peoples { get; set; }
        
    }

    public class PeopleVM
    {
        public string name { get; set; }

        public string url { get; set; }
    }

}
