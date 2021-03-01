using System;
using System.Collections.Generic;
using System.Text;

namespace InformationXmlHW
{
    public class Student
    {
        private String course, specialization;

        public Student(String name, String course, String specialization)
        {
            super(name);
            this.course = course;
            this.specialization = specialization;
        }

        private void super(string name)
        {
            throw new NotImplementedException();
        }

        public String getCourse()
        {
            return course;
        }

        public String getSpecialization()
        {
            return specialization;
        }

        public String toString()
        {
            return "Студент отличник " + getName() + " " + course + "-го курса, обучающийся по специальности " + specialization;
        }

        private string getName()
        {
            throw new NotImplementedException();
        }
    }
}
