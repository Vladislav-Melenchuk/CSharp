using HW_interface;
using System;
using System.Collections.Generic;

namespace HW_interface
{
    class Program
    {
        static void Main()
        {

            Student student1 = new Student("Мел", "Олег", "Кирилович", "2000-01-01", "Одесса", 1234567890, new List<int> { 5, 4, 3 }, new List<int> { 1, 4 }, new List<int> { 4, 2 });

            Student student2 = new Student("Кун", "Никита", "Олегович", "1999-02-02", "Одесса", 1234567890, new List<int> { 3, 5, 5 }, new List<int> { 4, 3 }, new List<int> { 5, 4 });

            Student student3 = new Student("Кун", "Александр", "Олегович", "1999-04-03", "Одесса", 1234567890, new List<int> { 3, 4, 5 }, new List<int> { 3, 3 }, new List<int> { 6, 7 });


            Group originalGroup = new Group("Группа 101", "Комп-Науки", 2, new List<Student> { student1, student2, student3 });


            //List<Student> students = new List<Student> { student1, student2, student3 };


            //students.Sort(new Student.SortByAverageGrade());
            //Console.WriteLine("Сортировка по среднему баллу:");
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.surname} {student.name} {student.otchestvo} - Средний балл: {student.GetAverageGrade():F2}");
            //}

            //students.Sort(new Student.SortByFullName());
            //Console.WriteLine("\nСортировка по ФИО:");
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.surname} {student.name} {student.otchestvo}");
            //}

            originalGroup.PrintAllStudents();

        }
    }
}
