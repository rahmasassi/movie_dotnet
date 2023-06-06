using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using movie.Data.Base;

namespace movie.Models
{
    public class Order : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
