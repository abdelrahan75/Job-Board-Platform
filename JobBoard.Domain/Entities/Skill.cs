using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopBoard.Domain.Entities
{
    public class Skill
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Guid JopId { get; set; }

        public Guid SkillId { get; set; }

       
    }
}
