using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopBoard.Domain.Entities
{
    public class Resume
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Job)),Required]
        public string JobSeekerId { get; set; }
        [Required]
        public string FileUrl { get; set; }

        public string? Summary {  get; set; }

        public int yearsOfExperience { get; set; } = 0;

        public ICollection<Skill> skills { get; set; }
    }
}
