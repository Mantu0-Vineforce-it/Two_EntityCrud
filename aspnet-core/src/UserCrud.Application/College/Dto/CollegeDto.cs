using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCrud.College.Dto
{
    public class CollegeDto:FullAuditedEntityDto<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
