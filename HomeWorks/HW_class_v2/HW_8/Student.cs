using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    public class Student
    {

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<int> Credits { get; set; }
        public List<int> Coursework { get; set; }
        public List<int> Exams { get; set; }


        public Student()
        {
            this.Surname = "unknow";
            this.Name = "unknow";
            this.Otchestvo = "unknow";
        }

        public Student(string Surname, string Name, string Otchestvo, string birthday)
      : this(Surname, Name, Otchestvo, birthday, "", "", new List<int>(), new List<int>(), new List<int>())
        {
        }

        public Student(string Surname, string Name, string Otchestvo, string birthday, string address, string phoneNumber, List<int> credits, List<int> coursework, List<int> exams)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Otchestvo = Otchestvo;
            Birthday = birthday;
            Address = address;
            PhoneNumber = phoneNumber;
            Credits = credits;
            Coursework = coursework;
            Exams = exams;
        }


        public void Info()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Отчество: {Otchestvo}");
            Console.WriteLine($"Дата рождения: {Birthday}");
            Console.WriteLine($"Адрес: {Address}");
            Console.WriteLine($"Телефон: {PhoneNumber}");
            Console.WriteLine($"Зачёты: {string.Join(", ", Credits)}");
            Console.WriteLine($"Курсовые работы: {string.Join(", ", Coursework)}");
            Console.WriteLine($"Экзамены: {string.Join(", ", Exams)}");
        }

        public double GetAverageGrade()
        {
            var allGrades = Credits.Concat(Coursework).Concat(Exams).ToList();
            if (allGrades.Count == 0)
            {
                return 0;
            }

            return allGrades.Average();
        }

        public static bool operator true(Student student)
        {
            return student.GetAverageGrade() >= 7;
        }

        public static bool operator false(Student student)
        {
            return student.GetAverageGrade() < 7;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.GetAverageGrade() > s2.GetAverageGrade();
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.GetAverageGrade() < s2.GetAverageGrade();
        }

      
        public static bool operator ==(Student s1, Student s2)
        {
            return s1.GetAverageGrade() == s2.GetAverageGrade();
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return s1.GetAverageGrade() != s2.GetAverageGrade();
        }
    }
}
