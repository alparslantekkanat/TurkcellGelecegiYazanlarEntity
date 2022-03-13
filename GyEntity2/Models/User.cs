using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyEntity2.Models
{
    public class User
    {
       
        public int Id { get; set; }
        

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName { get; set; }

        public string Mail { get; set; }
        public string GSM { get; set; }
        public string Address { get; set; }

        public Gender Gender { get; set; }
        public int?  GenderId { get; set; }
        public Blood Blood { get; set; }
        public int?   BloodId { get; set; }
        public Country Country { get; set; }
        public int? CountryId { get; set; }

        public List<Cart> Carts { get; set; }




    }
}
