using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserCrud.College.Dto;

namespace UserCrud.Collage
{
    public class CollageAppService : ApplicationService, ICollageAppService
    {
        private readonly IRepository<CollageEntity, int> _collageRepository;

        public CollageAppService(IRepository<CollageEntity, int> collageRepository)
        {
            _collageRepository = collageRepository;
        }

        public async Task<List<CollageDto>> GetAllAsync()
        {
            var collages = await _collageRepository.GetAllListAsync();
            return ObjectMapper.Map<List<CollageDto>>(collages);
        }


        public async Task<CollageDto> CreateAsync(CreateCollege input)
        {
            var collage = ObjectMapper.Map<CollageEntity>(input);
            var insertedCollage = await _collageRepository.InsertAsync(collage);
            return ObjectMapper.Map<CollageDto>(insertedCollage);
        }

        public async Task<CollageDto> UpdateAsync(UpdateCollege input)
        {
            var collage = await _collageRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
            ObjectMapper.Map(input, collage);
            await _collageRepository.UpdateAsync(collage);
            return ObjectMapper.Map<CollageDto>(collage);
        }

        public async Task DeleteAsync(int id)
        {
            var collage = await _collageRepository.FirstOrDefaultAsync(id);
            if (collage == null)
                throw new UserFriendlyException("Collage not found");

            await _collageRepository.DeleteAsync(collage);
        }

        
    }

    public class CollageDto
    {
    }
}
