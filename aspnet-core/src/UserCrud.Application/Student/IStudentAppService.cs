using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCrud.Student.Dto;

namespace UserCrud.Student
{
    public interface IStudentAppService: IApplicationService
    {

         
        Task<List<StudentDto>> GetAllAsync();
        Task<Students.Student> CreateAsync(CreateStudentDto input);
        Task<Students.Student> UpdateAsync(UpdateStudentDto input);
        Task DeleteAsync(EntityDto<int> input);
    }
}

