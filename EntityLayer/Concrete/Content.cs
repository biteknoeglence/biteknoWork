using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        public string ContentTitle { get; set; }
        public string ContentSelf { get; set; }
        public DateTime ContentCreateDate { get; set; }
        public bool ContentStatus { get; set; }
    }
}
