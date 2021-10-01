using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Part
    {
        [Key]
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string PartExplanation { get; set; }
        public string PartThumbImage { get; set; }
        public string PartImage { get; set; }
        public DateTime PartCreateDate { get; set; }
        public bool PartStatus { get; set; }

        public int HeadingID { get; set; }
        public Heading Heading { get; set; }

        public List<Product> Products { get; set; }
    }
}
