using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserCrud.College.Dto;

namespace UserCrud.Collage
{
    public interface ICollageAppService : IApplicationService
    {
        Task<List<CollageDto>> GetAllAsync();
        Task<CollageDto> CreateAsync(CreateCollege input);
        Task<CollageDto> UpdateAsync(UpdateCollege input);
        Task DeleteAsync(int Id);


    }


}
