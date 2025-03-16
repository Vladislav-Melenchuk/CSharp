using HW_interface;
using System;
using System.Collections.Generic;

namespace HW_interface
{
    class Program
    {
        static void Main()
        {
            
            Student student1 = new Student("Мел", "Олег", "Кирилович", "2000-01-01", "Одесса", 1234567890,
                                           new List<int> { 5, 4, 3 }, new List<int> { 5, 4 }, new List<int> { 4, 3 });

            Student student2 = new Student("Кун", "Никита", "Олегович", "1999-02-02", "Одесса", 1234567890,
                                           new List<int> { 3, 4, 5 }, new List<int> { 4, 3 }, new List<int> { 5, 4 });

           
            Group originalGroup = new Group("Группа 101", "Комп-Науки", 2, new List<Student> { student1, student2 });


            Group cloned = (Group)originalGroup.Clone();


            cloned.GetStudents()[0].name = "Владислав";


            Console.WriteLine("Оригинальная группа:");
            Console.WriteLine(originalGroup.GetStudents()[0].name);


            Console.WriteLine("Клонированная группа:");
            Console.WriteLine(cloned.GetStudents()[0].name);
        }
    }
}
