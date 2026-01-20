using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCrud.Student.Dto
{
    public class StudentDto:FullAuditedEntity<int>
    {

            public string Name { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }

            public int CollegeId { get; set; }
            public string CollegeName { get; set; }


       

}
}
