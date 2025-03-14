using HW_tryCatch;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        Student st = new Student();

        st.SetSurname("");
        st.SetName("");

        Console.WriteLine(st.GetSurname());


    }
}
