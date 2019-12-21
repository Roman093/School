using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Auditoriya
    {
        public Auditoriya()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        List<Teacher> Teachers;
        List<Student> Students;
        
        public void TeacherAdd(Teacher teacher)
        {
                Teachers.Add(teacher);
        }

        public void StudentAdd(Student student)
        {
            Students.Add(student);
        }
    }
}
