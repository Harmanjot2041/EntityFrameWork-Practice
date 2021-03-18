using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities;
using StudentDataAccess;
using System.Linq;

namespace BusinessLayer
{
    public class StudentComponent : IStudentComponent
    {
        private readonly IStudentDataAccess _studentDataAccess;
        public StudentComponent(IStudentDataAccess studentDataAccess)
        {
            _studentDataAccess = studentDataAccess;
        } 
        public List<StudentsTable> GetStudents()
        {
            return _studentDataAccess.GetStudent().ToList();
        }
    }
}
