using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities;

namespace StudentDataAccess
{
    public interface IStudentDataAccess
    {
        List<StudentEntities.Entities.StudentsTable> GetStudent();
        int AddStudent(StudentEntities.Entities.StudentsTable model);
        int DeleteStudent();
        int EditStudent();
    }
}
