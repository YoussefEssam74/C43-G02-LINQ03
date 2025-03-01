using System;
using System.Linq;
using System.Collections.Generic;
using Assignment_ef01.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AssignmentEF03
{
    public class Program
    {
        public static void Main()
        {
            #region insert

            // using (var context = new ItiDbContext())
            // {
            //     // Ensure the department exists
            //     var department = context.Departments.Find(1);
            //     if (department == null)
            //     {
            //         Console.WriteLine("Error: Department with ID 1 does not exist!");
            //         return;
            //     }
            //
            //     // Insert the student only if the department exists
            //     var student = new Student
            //     {
            //         FName = "Ali",
            //         LName = "Ahmed",
            //         Age = 22,
            //         Address = "Cairo",
            //         Dep_Id = 1 // Ensure this ID exists in Departments
            //     };
            //
            //     context.Students.Add(student);
            //     context.SaveChanges();
            // } 
            #endregion
            #region select
            // using (var context = new ItiDbContext())
            // {
            //     var students = context.Students.ToList();
            //     foreach (var student in students)
            //     {
            //         Console.WriteLine($"{student.ID}: {student.FName} {student.LName}");
            //     }
            // } 
            #endregion
        }
    }
}
    




