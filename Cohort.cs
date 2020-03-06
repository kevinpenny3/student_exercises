using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string Name { get; set; }
        public List<Student> cohortStudents = new List<Student>();
        public List<Instructor> cohortInstructors = new List<Instructor>();
        public Cohort(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            cohortStudents.Add(student);
        }
        public void AddInstructor(Instructor instructor)
        {
            cohortInstructors.Add(instructor);
        }
    }
}