using HW_8;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student(
            Surname: "Коробка",
            Name: "Илья",
            Otchestvo: "Иванович",
            birthday: "2005-12-15",
            address: "г. Одесса, ул. Левитана, д. 116",
            phoneNumber: "+380 (96) 8074523",
            credits: new List<int> { 5, 4, 3 },
            coursework: new List<int> { 4, 5 },
            exams: new List<int> { 5, 5, 4 }
        );


        Console.WriteLine("Информация о первом студенте:");
        student1.Info();


        Student student2 = new Student("Меленук", "Владислав", "Олегович", "2004-12-3");

        student2.Info();


    }
}
