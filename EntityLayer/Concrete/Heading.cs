using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public string HeadingExplanation { get; set; }
        public DateTime HeadingCreateDate { get; set; }
        public bool HeadingStatus { get; set; }

        public int PartID { get; set; }
        public Part Part { get; set; }

        public List<Product> Products { get; set; }
    }
}
