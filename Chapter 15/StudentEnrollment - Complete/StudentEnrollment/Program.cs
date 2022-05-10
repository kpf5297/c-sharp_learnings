using System;

namespace StudentEnrollment
{
    class Program
    {
        static void doWork()
        {
            var enrollments = new Enrollment[4];
            enrollments[0] = new Enrollment(StudentID: 1, CourseName: "Physics", DateEnrolled: new DateOnly(2021, 07, 20));
            enrollments[1] = new Enrollment(StudentID: 1, CourseName: "Chemistry", DateEnrolled: new DateOnly(2021, 07, 20));
            enrollments[2] = enrollments[0];
            enrollments[3] = enrollments[0] with { StudentID = 2};

            foreach (var enrollment in enrollments)
            {
                Console.WriteLine($"{enrollment}");
            }

            var firstEnrollment = enrollments[0];
            foreach (var enrollment in enrollments[1..4])
            {
                Console.WriteLine($"{firstEnrollment == enrollment}");
            }

            //enrollments[0].DateEnrolled = new DateOnly(2021, 08, 15);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
