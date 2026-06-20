using _16_API_MVC_CRUD.Models;

namespace _16_API_MVC_CRUD.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);

        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);


    }
}
