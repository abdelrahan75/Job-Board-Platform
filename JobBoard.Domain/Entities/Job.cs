using JopBoard.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopBoard.Domain.Entities
{
    public class Job
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Requirements { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public WorkType WorkType { get; set; }

        public decimal? MaxSalary { get; set; }

        public decimal? MinSalary { get; set; }

        public StatusJop Status { get; set; } = StatusJop.Open;

        public DateTime? DeadLine { get; set; }

        [Required,ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }

        public int ViewsCount { get; set; } = 0;
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

    }
}
