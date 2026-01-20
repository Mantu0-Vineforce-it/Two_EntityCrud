using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserCrud.Authorization;
using UserCrud.Student.Dto;
using UserCrud.Students;
using Abp.UI;
using System;
using UserCrud.Studentsss;


namespace UserCrud.Student
{
    [AbpAuthorize]
    public class StudentAppService : ApplicationService, IStudentAppService
    {
        private readonly IRepository<Students.Student, int> _studentRepository;
        private readonly IRepository<Studentsss.Studentss, int> _studentsRepository;


        public StudentAppService(IRepository<Students.Student, int> studentRepository, IRepository<Studentsss.Studentss, int> studentsRepository)
        {
            _studentRepository = studentRepository;
            _studentsRepository = studentsRepository;
        }


        public async Task<Studentss> CreateStudentssssAsync(Studentss student)
        {
            try
            {

                // Insert entity into repository
                await _studentsRepository.InsertAsync(student);

                return student; // The student now has its ID populated
            }
            catch (Exception ex)
            {
                // Optional: log the original exception
                throw new UserFriendlyException($"Failed to create Student: {ex.Message}");
            }
        }


        public async Task<List<StudentDto>> GetAllAsync()
        {

            try
            {
                var students = await _studentRepository.GetAllListAsync();
                var data = ObjectMapper.Map<List<StudentDto>>(students);
                return data;
            }
            catch (Exception)
            {
                throw new UserFriendlyException(
                    "unable to fatch the student at Movement.Please try Again Later");
            }
        }

        public async Task<Students.Student> CreateAsync(CreateStudentDto input)
        {
            if (input == null)
                throw new UserFriendlyException("Input cannot be null");

            try
            {
                // Map DTO to entity
                var student = ObjectMapper.Map<Students.Student>(input);

                // Insert entity into repository
                await _studentRepository.InsertAsync(student);

                // At this point, in ABP application services, 
                // the Unit of Work will automatically save changes
                // when the method completes successfully.

                return student; // The student now has its ID populated
            }
            catch (Exception ex)
            {
                // Optional: log the original exception
                throw new UserFriendlyException($"Failed to create Student: {ex.Message}");
            }
        }


        public async Task<Students.Student> UpdateAsync(UpdateStudentDto input)
        {
            try
            {
                var student = await _studentRepository.GetAsync(input.Id);
                ObjectMapper.Map(input, student);
                return await _studentRepository.UpdateAsync(student);
            }
            catch (Exception)
            {
                throw new UserFriendlyException("Unable to update Student Details");
            }
        }

        public async Task DeleteAsync(EntityDto<int> input)
        {
            try
            { await _studentRepository.DeleteAsync(input.Id); }
            catch (Exception)
            {
                throw new UserFriendlyException("Unable to delete the Student");
            }
        }
    }
}
