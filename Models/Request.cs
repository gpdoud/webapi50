using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi50.Models {

    public record Request {
        public int Id { get; set; } = 0;
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        [StringLength(80)]
        public string Justification { get; set; } = string.Empty;
        [StringLength(80)]
        public string? RejectionReason { get; set; } = null;
        [StringLength(30)]
        public string DeliveryMode { get; set; } = "Pickup";
        [StringLength(15)]
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; } = 0;

        public int UserId { get; set; } = 0;
        public virtual User? User { get; set; } = null;
    }
}
