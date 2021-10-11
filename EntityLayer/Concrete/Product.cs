using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductContent { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public DateTime ProductDate { get; set; }
        public bool ProductStatus { get; set; }

        public int HeadingID { get; set; }
        public Heading Heading { get; set; }

        public int MemberID { get; set; }
        public Member Member { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
