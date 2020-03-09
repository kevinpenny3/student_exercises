using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // create the exercises
            Exercise nutshell = new Exercise("nutshell", "React");
            Exercise holidayRoad = new Exercise("Holiday Road", "C#");
            Exercise fitted = new Exercise("Fitted", "React");
            Exercise bangazon = new Exercise("Bangazon", "C#");

            //create the students
            Student kevin = new Student("Kevin", "Penny", "kpen3", "Cohort 36");
            Student james = new Student("James", "Nitz", "jitzynitzy", "Cohort 37");
            Student audrey = new Student("Audrey", "Borgra", "BigBrainBorgra", "Cohort 36");
            Student namita = new Student("Namita", "Manohar", "namitabannana", "Cohort 37");
            Student jansen = new Student("Jansen", "Vanderspuy", "simplyJantastic", "Cohort 35");

            //create the cohorts
            Cohort cohort37 = new Cohort("Cohort 37");
            Cohort cohort36 = new Cohort("Cohort 36");
            Cohort cohort35 = new Cohort("Cohort 35");

            // create the instructors
            Instructor steve = new Instructor("Steve", "Brownlee", "choortlehort", "Cohort 37", "dad jokes");
            Instructor mo = new Instructor("Mo", "Silvera", "MoCodeLessProblems", "Cohort 36", "Cheesecakes");
            Instructor leah = new Instructor("Leah", "Hoeffling", "LeahLemurLady", "Cohort 35", "petting lemurs");

            // assign the students to cohorts
            cohort35.AddStudent(jansen);
            cohort36.AddStudent(kevin);
            cohort36.AddStudent(audrey);
            cohort37.AddStudent(james);
            cohort37.AddStudent(namita);

            // assign instructors to cohorts
            cohort35.AddInstructor(leah);
            cohort36.AddInstructor(mo);
            cohort37.AddInstructor(steve);

            // assing exercises to students
            mo.AddExercise(kevin, fitted);
            mo.AddExercise(kevin, nutshell);
            mo.AddExercise(audrey, holidayRoad);
            mo.AddExercise(audrey, fitted);
            leah.AddExercise(jansen, nutshell);
            leah.AddExercise(jansen, bangazon);
            steve.AddExercise(namita, nutshell);
            steve.AddExercise(namita, holidayRoad);
            steve.AddExercise(james, nutshell);
            steve.AddExercise(james, bangazon);

            // create list of students
            var studentsList = new List<Student>();
            studentsList.Add(kevin);
            studentsList.Add(namita);
            studentsList.Add(audrey);
            studentsList.Add(james);
            studentsList.Add(jansen);

            // create list of exercises
            var exercisesList = new List<Exercise>();
            exercisesList.Add(nutshell);
            exercisesList.Add(fitted);
            exercisesList.Add(holidayRoad);
            exercisesList.Add(bangazon);

            foreach (Exercise exercise in exercisesList)
            {
                Console.WriteLine($"--- {exercise.Name.ToUpper()} ---");
                foreach (Student student in studentsList)
                {
                    foreach (Exercise singleExercise in student.Exercises)
                    {
                        if (singleExercise.Name == exercise.Name)
                        {
                            Console.WriteLine($@"{student.FirstName} {student.LastName}");
                            Console.WriteLine(" ");
                        }
                    }
                }
            }

            var allReactExercises = exercisesList.Where(langExercise =>
            {
                return langExercise.Language == "React";
            });

            foreach (var langExercise in allReactExercises)
            {
                Console.WriteLine(langExercise.Name);
            }

        }
    }
}