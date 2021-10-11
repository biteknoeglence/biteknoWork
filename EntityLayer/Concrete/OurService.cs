using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        public class About
        {
            [Key]
            public int ServiceID { get; set; }
            public string ServiceTitle { get; set; }
            public string ServiceContent { get; set; }
            public string ServiceImage { get; set; }
            public bool AboutStatus { get; set; }
        }
    }
}
