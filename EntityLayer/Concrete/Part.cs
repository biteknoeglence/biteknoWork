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

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Heading> Headings { get; set; }
    }
}
