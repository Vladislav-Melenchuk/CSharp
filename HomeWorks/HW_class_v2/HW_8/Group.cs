using HW_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    public class Group
    {
        public List<Student> Students { get; set; }
        public string GroupName { get; set; }
        public string Specialization { get; set; }
        public int NumberOfCourse { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }

        public void DisplayStudents()
        {
            Console.WriteLine($"Группа: {GroupName}, Специализация: {Specialization}");
            var sortedStudents = Students.OrderBy(s => s.Surname).ThenBy(s => s.Name).ToList();
            for (int i = 0; i < sortedStudents.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedStudents[i].Surname} {sortedStudents[i].Name}");
            }
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void EditStudent(int index, Student updatedStudent)
        {
            if (index >= 0 && index < Students.Count)
            {
                Students[index] = updatedStudent;
            }
            else
            {
                Console.WriteLine("Некорректный индекс студента.");
            }
        }

        public void EditGroup(string groupName, string specialization, int courseNumber)
        {
            GroupName = groupName;
            Specialization = specialization;
            NumberOfCourse = courseNumber;
        }

        public void TransferStudent(Group targetGroup, int studentIndex)
        {
            if (studentIndex >= 0 && studentIndex < Students.Count)
            {
                var student = Students[studentIndex];
                Students.RemoveAt(studentIndex);
                targetGroup.AddStudent(student);
            }
            else
            {
                Console.WriteLine("Некорректный индекс студента для перевода.");
            }
        }

        public void LowestStudent()
        {
            if (Students.Count > 0)
            {
                var lowestStudent = Students.OrderBy(GetAverageGrade).First();
                Students.Remove(lowestStudent);
            }
            else
            {
                Console.WriteLine("В группе нет студентов для отчисления.");
            }
        }

        private double GetAverageGrade(Student student)
        {
            var allGrades = student.Credits.Concat(student.Coursework).Concat(student.Exams).ToList();
            if (allGrades.Count == 0)
                return 0;
            return allGrades.Average();
        }

        public static bool operator true(Group group)
        {
            return group.Students.Count > 0;
        }

        public static bool operator false(Group group)
        {
            return group.Students.Count == 0;
        }


        public static bool operator >(Group g1, Group g2)
        {
            return g1.Students.Count > g2.Students.Count;
        }

        public static bool operator <(Group g1, Group g2)
        {
            return g1.Students.Count < g2.Students.Count;
        }
        public static bool operator ==(Group g1, Group g2)
        {
            return g1.Students.Count == g2.Students.Count && g1.GroupName == g2.GroupName;
        }

        public static bool operator !=(Group g1, Group g2)
        {
            return !(g1 == g2);
        }
    }
}