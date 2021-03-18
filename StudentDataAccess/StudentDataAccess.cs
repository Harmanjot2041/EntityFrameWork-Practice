using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities;
using System.Linq;

namespace StudentDataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        private readonly StudentEntities.Entities.EmployeeDbCOntext _context;
        public StudentDataAccess(StudentEntities.Entities.EmployeeDbCOntext context)
        {
            _context = context;
        }

        public int AddStudent(StudentsTable model)
        {

            throw new NotImplementedException();
        }

        public int DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public int EditStudent()
        {
            throw new NotImplementedException();
        }

        public List<StudentsTable> GetStudent()
        {
            return _context.StudentsTables.ToList();
        }
    }
}
