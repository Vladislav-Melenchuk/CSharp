using HW_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_interface
{
    public class Group : ICloneable
    {
        private List<Student> students;
        private string groupName;
        private string specialization;
        private int numberOfCourse;


        //set
        public void SetStudents(List<Student> Students)
        {
            try
            {
                if (Students == null)
                    throw new ArgumentException("Список студентов не может быть пустым!");

                students = Students;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetGroupName(string GroupName)
        {
            try
            {
                if (GroupName == null || GroupName == "")
                    throw new ArgumentException("Название группы не может быть пустым!");

                groupName = GroupName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetSpecialization(string Specialization)
        {
            try
            {
                if (Specialization == null || Specialization == "")
                    throw new ArgumentException("Специализация не может быть пустой");

                specialization = Specialization;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetNumberOfCourse(int NumberOfCourse)
        {
            try
            {
                if (NumberOfCourse <= 0 || NumberOfCourse > 5)
                    throw new ArgumentException("Номер курса должен быть от 1 до 5");

                numberOfCourse = NumberOfCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }


        //get
        public List<Student> GetStudents()
        {
            return students;
        }
        public string GetGroupName()
        {
            return groupName;
        }

        public string GetSpecialization()
        {
            return specialization;
        }

        public int GetNumberOfCourse()
        {
            return numberOfCourse;
        }


        public Group(string GroupName, string Specialization, int NumberOfCourse, List<Student> students)
        {
            this.groupName = GroupName;
            this.specialization = Specialization;
            this.numberOfCourse = NumberOfCourse;
            this.students = new List<Student>(students);
        }

        public void DisplayStudents()
        {
            Console.WriteLine($"Группа: {groupName}, Специализация: {specialization}");
            var sortedStudents = students.OrderBy(s => s.surname).ThenBy(s => s.name).ToList();
            for (int i = 0; i < sortedStudents.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedStudents[i].surname} {sortedStudents[i].name}");
            }
        }



        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void EditStudent(int index, Student updatedStudent)
        {
            if (index >= 0 && index < students.Count)
            {
                students[index] = updatedStudent;
            }
            else
            {
                Console.WriteLine("Некорректный индекс студента.");
            }
        }

        public void EditGroup(string GroupName, string Specialization, int CourseNumber)
        {
            groupName = GroupName;
            specialization = Specialization;
            numberOfCourse = CourseNumber;
        }

        public void TransferStudent(Group targetGroup, int studentIndex)
        {
            if (studentIndex >= 0 && studentIndex < students.Count)
            {
                var student = students[studentIndex];
                students.RemoveAt(studentIndex);
                targetGroup.AddStudent(student);
            }
            else
            {
                Console.WriteLine("Некорректный индекс студента для перевода.");
            }
        }

        public void LowestStudent()
        {
            if (students.Count > 0)
            {
                var lowestStudent = students.OrderBy(GetAverageGrade).First();
                students.Remove(lowestStudent);
            }
            else
            {
                Console.WriteLine("В группе нет студентов для отчисления.");
            }
        }

        private double GetAverageGrade(Student student)
        {
            var allGrades = student.credits.Concat(student.coursework).Concat(student.exams).ToList();
            if (allGrades.Count == 0)
                return 0;
            return allGrades.Average();
        }

        public static bool operator true(Group group)
        {
            return group.students.Count > 0;
        }

        public static bool operator false(Group group)
        {
            return group.students.Count == 0;
        }


        public static bool operator >(Group g1, Group g2)
        {
            return g1.students.Count > g2.students.Count;
        }

        public static bool operator <(Group g1, Group g2)
        {
            return g1.students.Count < g2.students.Count;
        }
        public static bool operator ==(Group g1, Group g2)
        {
            return g1.students.Count == g2.students.Count && g1.groupName == g2.groupName;
        }

        public static bool operator !=(Group g1, Group g2)
        {
            return !(g1 == g2);
        }

        public object Clone()
        {
            return new Group(groupName, specialization, numberOfCourse,
                             students.Select(s => (Student)s.Clone()).ToList());
        }
    }
}
