﻿using EntityAssignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insert();

        }
        static void insert()
        {
            var database = new timilehindbContext();
            var student = new Student();
            student.Name = "Sandrah";
            student.Department = "fineart";
            student.Year = 400;
            database.Students.Add(student);
            var final = database.SaveChanges();
        }
    }
}