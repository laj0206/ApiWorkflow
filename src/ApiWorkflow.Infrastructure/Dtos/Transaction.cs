using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiWorkflow.Infrastructure.Dtos
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public ActionType ActionType { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        public Account Account { get; set; } = default!;
    }

    public enum ActionType
    {
        Withdraw = 0,
        Deposit = 1
    }
}
