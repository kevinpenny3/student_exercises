using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

        public Student(string aName, string bName, string slack, Cohort cohortName)
        {
            FirstName = aName;
            LastName = bName;
            SlackHandle = slack;
            Cohort = cohortName;
        }

    }
}