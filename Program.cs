using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise nutshell = new Exercise("nutshell", "React");
            Exercise holidayRoad = new Exercise("Holiday Road", "JavaScript");
            Exercise fitted = new Exercise("Fitted", "React");
            Exercise Bangazon = new Exercise("Bangazon", "C# and .Net");

            Student kevin = new Student("Kevin", "Penny", "kpen3", "Cohort 36");
            Student james = new Student("James", "Nitz", "jitzynitzy", "Cohort 37");
            Student audrey = new Student("Audrey", "Borgra", "BigBrainBorgra", "Cohort 36");
            Student namita = new Student("Namita", "Manohar", "namitabannana", "Cohort 37");
            Student jansen = new Student("Jansen", "Vanderspuy", "simplyJantastic", "Cohort 35");

            Cohort cohort37 = new Cohort("Cohort 37");
            Cohort cohort36 = new Cohort("Cohort 36");
            Cohort cohort35 = new Cohort("Cohort 35");

            cohort35.AddStudent(jansen);
            cohort36.AddStudent(kevin);
            cohort36.AddStudent(audrey);
            cohort37.AddStudent(james);
            cohort37.AddStudent(namita);

            Instructor steve = new Instructor("Steve", "Brownlee", "choortlehort", "Cohort 37", "dad jokes");
            Instructor mo = new Instructor("Mo", "Silvera", "MoCodeLessProblems", "Cohort 36", "Cheesecakes");
            Instructor leah = new Instructor("Leah", "Hoeffling", "LeahLemurLady", "Cohort 35", "petting lemurs");

        }
    }
}