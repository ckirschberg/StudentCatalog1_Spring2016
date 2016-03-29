using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentCatalog3.Models;
using System.Data.Entity;

namespace StudentCatalog3.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public Student Find(int id)
        {
            return db.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public void InsertOrUpdate(Student student)
        {
            if (student.StudentId == 0)
            {
                db.Students.Add(student);
            }
            else
            {
                db.Entry(student).State = EntityState.Modified;
            }
            db.SaveChanges();
        }
    }
}