using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_
{
    public interface IBusinessLayer
    {
        IList<Standard> getAllStandards();
        Standard GetStandardByID(int id);
        void addStandard(Standard standard);
        void updateStandard(Standard standard);
        void removeStandard(Standard standard);
        IList<Student> getAllStudents();
        Student GetStudentByID(int id);
        void addStudent(Student student);
        void UpdateStudent(Student student);
        void RemoveStudent(Student student);
    }
}
