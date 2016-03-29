using StudentCatalog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCatalog3.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student Find(int id);
        void Delete(int id);
        void InsertOrUpdate(Student student);

        //GetAll() - (should return the students)
        //Find - (should return one student based on id)
        //Delete (should delete a student based on id)
        //InsertOrUpdate (should insert or update 
        //a student to the database)
    }
}
