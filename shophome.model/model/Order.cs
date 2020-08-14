using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shophome.model.model
{
    [Table("Orders")]
    public class Order
    {
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(50)]
        public string CustomerMobole { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }
        [Required]
        [MaxLength(256)]
        public string Paymentmethod{ set; get; }
     
        public string PaymentStatus{ set; get; }
        public DateTime? CreatedData { set; get; }
        public string CreatedBy { set; get; }
        public bool Status { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
