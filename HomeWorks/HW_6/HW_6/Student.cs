using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
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
    }
}
