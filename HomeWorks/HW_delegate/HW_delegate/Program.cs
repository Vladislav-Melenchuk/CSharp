using HW_interface;
using System;
using System.Collections.Generic;

namespace HW_interface
{
    class Program
    {

        delegate void Menu();

        static List<Student> students = new List<Student> 
        {
        new Student { surname = "Коваленко", name = "Алексей", otchestvo = "Иванович", birthday = "2005-04-15", address = "Одесса", exams = new List<int> { 12, 12, 12 }, credits = new List<int> { 12, 10 }, coursework = new List<int> { 10, 11 } },
        new Student { surname = "Петров", name = "Марина", otchestvo = "Сергеевна", birthday = "2004-11-20", address = "Одесса", exams = new List<int> { 12, 2, 2 }, credits = new List<int> { 2, 3 }, coursework = new List<int> { 5, 12 } }

        };
        static void Main()
        {

            List<Menu> menu = new List<Menu>
            {
               AddStudent,
               RemoveStudent,
               ShowAllStudents,
               ShowOtlichnik,
               ShowDvoishnik

            };

            while (true)
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("Меню:");
                Console.WriteLine("0 - Добавить студента в группу");
                Console.WriteLine("1 - Удалить студента из группы");
                Console.WriteLine("2 - Показать всех студентов");
                Console.WriteLine("3 - Показать всех отличников");
                Console.WriteLine("4 - Показать всех студентов, у которых есть двойки");
                Console.WriteLine("Любое другое значение - выход из программы");
                Console.WriteLine("Введите число от 0 до 3 для выбора действия, или любой другой символ для выхода:");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= 0 && choice <= 4)
                {
                    menu[choice]();
                }
                else
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Введите фамилию студента:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите имя студента:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите отчество студента:");
            string Otchestvo = Console.ReadLine();
            Console.WriteLine("Введите дату рождения(ХХХХ-ХХ-ХХ):");
            string Birthday = Console.ReadLine();
            Console.WriteLine("Введите адресс:");
            string Address = Console.ReadLine();
           

            students.Add(new Student { surname = Surname, name = Name, otchestvo = Otchestvo, birthday = Birthday, address = Address});
            Console.WriteLine("Студент добавлен в группу.");
        }

        static void RemoveStudent()
        {
            Console.WriteLine("Введите фамилию студента, которого нужно удалить:");
            string surname = Console.ReadLine();

            
            bool removed = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].surname == surname)
                {
                    students.RemoveAt(i);
                    Console.WriteLine($"Студент с фамилией {surname} удален.");
                    removed = true;
                    break;
                }
            }

            if (!removed)
            {
                Console.WriteLine("Студент с такой фамилией не найден.");
            }
        }

        static void ShowOtlichnik()
        {
            Console.WriteLine(" ");
            int x = 1;
            Console.WriteLine("Отличники:");

            List<Student> otlichniki = new List<Student>();

            foreach (var student in students)
            {
                bool otlichnik = true;

                foreach (var exam in student.exams)
                {
                    if (exam < 12)
                    {
                        otlichnik = false;
                        break;
                    }
                }

                if (otlichnik)
                {
                    otlichniki.Add(student);
                }
            }

            foreach (var student in otlichniki)
            {
                Console.WriteLine($"{x}.{student.surname} {student.name} {student.otchestvo}");
                x++;
            }
 
        }
        static void ShowDvoishnik()
        {
            Console.WriteLine(" ");
            int x = 1;
            Console.WriteLine("Студенты с двойками:");

            foreach (var student in students)
            {
                
                foreach (var exam in student.exams)
                {
                    if (exam == 2)  
                    {
                        Console.WriteLine($"{x} - {student.surname} {student.name} {student.otchestvo}");
                        x++;
                        break;  
                    }
                }
            }
        }

        static void ShowAllStudents()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Все студенты:");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.surname} {student.name} {student.otchestvo}");
            }

            Console.WriteLine("============================================================");
        }


    }
}
