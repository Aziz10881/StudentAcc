using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class StudentRepository :RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) :base(repositoryContext)
        {

        }

        //CarExhibition class methods must be written in repository
        public IEnumerable<Student> GetAllStudents()
        {
            return FindAll().OrderBy(st => st.Name).ToList();
        }

        public Student GetStudentById(Guid studentId)
        {
            return FindByCondition(student => student.Id.Equals(studentId)).FirstOrDefault();
        }

        public Student GetStudentWithDetails(Guid studentId)
        {
            return FindByCondition(student => student.Id.Equals(studentId))
                .Include(ac => ac.Accounts)
                .FirstOrDefault();
        }

        public void CreateStudent(Student student)
        {
            Create(student);
        }

        public void UpdateStudent(Student student)
        {
            Update(student);
        }

        public void DeleteStudent(Student student)
        {
            Delete(student);
        }
    }
}
