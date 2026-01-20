using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCrud.Studentsss
{
    public class Studentss : FullAuditedEntity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public int CollegeId { get; set; }

        [ForeignKey(nameof(CollegeId))]
        public Collage.CollageEntity CollageEntity { get; set; }

    }
}
