using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_tryCatch
{
    public class Student
    {

        public string surname;
        public string name;
        public string otchestvo;
        public string birthday;
        public string address;
        public int phoneNumber;

        public List<int> credits;
        public List<int> coursework;
        public List<int> exams;


        //set
        public void SetSurname(string Surname)
        {
            try
            {
                if (Surname == null || Surname == "")
                    throw new ArgumentException("Фамилия не может быть пустой!");

                surname = Surname;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }


        public void SetName(string Name)
        {
            try
            {
                if (Name == null || Name == "")
                    throw new ArgumentException("Имя не может быть пустым");

                name = Name;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetOtchestvo(string Otchestvo)
        {
            try
            {
                if (Otchestvo == null || Otchestvo == "")
                    throw new ArgumentException("Отчество не может быть пустым");

                otchestvo = Otchestvo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetBirthday(string Birthday)
        {
            try
            {
                if (Birthday == null || Birthday == "")
                    throw new ArgumentException("Дата Рождения не может быть пустым");

                birthday = Birthday;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetAddress(string Address)
        {
            address = Address;
        }

        public void SetPhoneNumber(int PhoneNumber)
        {
            try
            {
                if (PhoneNumber.ToString().Length != 10)
                    throw new ArgumentException("Номер телефона должен содержать ровно 10 цифр.");

                phoneNumber = PhoneNumber;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetCredits(List<int> Credits)
        {
            try
            {
                if (Credits == null)
                    throw new ArgumentException("Список зачётов не может быть пустым!");

                credits = Credits;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetCoursework(List<int> Coursework)
        {
            try
            {
                if (Coursework == null)
                    throw new ArgumentException("Список курсовых работ не может быть пустым!");

                coursework = Coursework;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void SetExams(List<int> Exams)
        {
            try
            {
                if (Exams == null)
                    throw new ArgumentException("Список экзаменов не может быть пустым!");

                exams = Exams;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }



        //get
        public string GetSurname()
        {
            return surname;
        }

        public string GetName()
        {
            return name;
        }

        public string GetOtchestvo()
        {
            return otchestvo;
        }

        public string GetBirthday()
        {
            return birthday;
        }

        public string GetAddress()
        {
            return address;
        }

        public int GetPhoneNumber()
        {
            return phoneNumber;
        }

        public List<int> GetCredits()
        {
            return credits;
        }

        public List<int> GetCoursework()
        {
            return coursework;
        }

        public List<int> GetExams()
        {
            return exams;
        }



        public Student()
        {
            this.surname = "";
            this.name = "";
            this.otchestvo = "";
        }

        public Student(string Surname, string Name, string Otchestvo, string birthday, int PhoneNumber)
      : this(Surname, Name, Otchestvo, birthday, "", PhoneNumber, new List<int>(), new List<int>(), new List<int>())
        {
        }

        public Student(string Surname, string Name, string Otchestvo, string Birthday, string Address, int PhoneNumber, List<int> Credits, List<int> Coursework, List<int> Exams)
        {
            this.surname = Surname;
            this.name = Name;
            this.otchestvo = Otchestvo;
            birthday = Birthday;
            address = Address;
            phoneNumber = PhoneNumber;
            credits = Credits;
            coursework = Coursework;
            exams = Exams;
        }


        public void Info()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {otchestvo}");
            Console.WriteLine($"Дата рождения: {birthday}");
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Телефон: {phoneNumber}");
            Console.WriteLine($"Зачёты: {string.Join(", ", credits)}");
            Console.WriteLine($"Курсовые работы: {string.Join(", ", coursework)}");
            Console.WriteLine($"Экзамены: {string.Join(", ", exams)}");
        }

        public double GetAverageGrade()
        {
            var allGrades = credits.Concat(coursework).Concat(exams).ToList();
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
