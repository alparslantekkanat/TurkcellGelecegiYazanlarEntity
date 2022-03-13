using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyEntity2.Models
{
    public class Cart
    {
        
        public int Id { get; set; }
        

        public User User { get; set; }
        public int UserId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        //public List<Product> Products { get; set; }
    }
}
