using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCrud.Student.Dto
{
    public class UpdateStudentDto:FullAuditedEntity<int>
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int CollegeId { get; set; }
        
    }
}
