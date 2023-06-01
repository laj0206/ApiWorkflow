using System.ComponentModel.DataAnnotations;

namespace ApiWorkflow.Infrastructure.Dtos
{
    public class User
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        [MaxLength(20)]
        public string? ContactPhone { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; } = default!;
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public ICollection<Account>? Accounts { get; set; }
    }
}
