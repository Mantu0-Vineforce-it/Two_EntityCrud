using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserCrud.Collage.Dto;

namespace UserCrud.Collage
{
    public interface ICollageAppService : IApplicationService
    {
        Task<List<CollegeDto>> GetAllAsync();
        Task<CollegeDto> CreateAsync(CreateCollege input);
        Task<CollegeDto> UpdateAsync(UpdateCollege input);
        Task DeleteAsync(EntityDto<int> input);


    }


}