using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiWorkflow.Infrastructure.Dtos
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = default!;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Balance { get; set; }
        public User User { get; set; } = default!;
    }
}