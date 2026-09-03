using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopBoard.Domain.Entities
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public string? LogoURL { get; set; }

        public string? Wepsite {  get; set; }
        [Required]
        public string Industry { get; set; }
        [Required]
        public string OwnerUserId { get; set; }

        public bool IsVerified { get; set; } = false;
    }
}
