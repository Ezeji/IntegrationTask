using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Model
{
    public class Stock
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string MerchantId { get; set; }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public string Price { get; set; }

        public DateTime CreatedDate { get; set; }     

    }
}
