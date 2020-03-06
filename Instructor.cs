namespace StudentExercises
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public string Specialty { get; set; }

        public void AddExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }

        public Instructor(string aName, string bName, string slack, string cohort, string specialty)
        {
            FirstName = aName;
            LastName = bName;
            SlackHandle = slack;
            Cohort = cohort;
            Specialty = specialty;
        }

    }
}