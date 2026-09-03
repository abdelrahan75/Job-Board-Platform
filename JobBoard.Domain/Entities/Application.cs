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
    public class Application
    {
        [Key]
        public Guid Id { get; set; }
        [Required,ForeignKey(nameof(Job))]
        public Guid JopId { get; set; }
        [Required,ForeignKey(nameof(Job))]
        public string JobSeekerId { get; set; }
        [Required,ForeignKey(nameof(Resume))]
        public Guid ResumeId { get; set; }
        [MaxLength(1000)]
        public string? Coverletter {  get; set; }

        public StutesApplication StutesApplication { get; set; } = StutesApplication.Applied;

        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;

        public DateTime? StutesUpdateAt { get; set; }

       
    }
}
