using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
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
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;
        public BusinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
        }

        public void addStandard(Standard standard)
        {
            _standardRepository.Insert(standard);
        }

        public void addStudent(Student student)
        {
            _studentRepository.Insert(student);
        }

        public IList<Standard> getAllStandards()
        {
           return _standardRepository.GetAll().ToList();
        }

        public IList<Student> getAllStudents()
        {
            return _studentRepository.GetAll().ToList();
        }

        public Standard GetStandardByID(int id)
        {
            return _standardRepository.GetById(id);
        }

        public Student GetStudentByID(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void removeStandard(Standard standard)
        {
            _standardRepository.Delete(standard);
        }

        public void RemoveStudent(Student student)
        {
            _studentRepository.Delete(student);
        }

        public void updateStandard(Standard standard)
        {
            _standardRepository.Update(standard);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }

    }
}