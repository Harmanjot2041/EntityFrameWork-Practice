using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities;

namespace BusinessLayer
{
    public interface IStudentComponent
    {
        List<StudentEntities.Entities.StudentsTable> GetStudents();
    }
}
