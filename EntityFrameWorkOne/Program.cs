using EntityFrameWorkOne.Models;
using System;
using System.Linq;

namespace EntityFrameWorkOne {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            //var students = context.Students
            //    .Where(s => s.GPA >= 3)
            //    .OrderByDescending(s => s.Lastname)
            //    .ToArray(); // Students pointing to the property called students in the appdbcontext class

            //var students = context.Students.OrderBy(s => s.Firstname).ToList();
            // var students = context.Students.Where(s => s.SAT >= 1000).OrderByDescending(s => s.SAT).ToList();
            var students = context.Students.Average(s => s.SAT);
            Console.WriteLine($"Average SAT scores {students}");

            //foreach (var stud in students) {    //The function after Students is called Extension Method
            //    Console.WriteLine($"{stud.Firstname} {stud.Lastname} {stud.SAT}");
            ////}

        }
    }
}
