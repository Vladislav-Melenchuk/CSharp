using System;


// task 1
//class Program
//{
//    static void Main()
//    {

//        string[] num = new string[4000];

//        for (int i = 1; i <= 3999; i++)
//        {
//            num[i - 1] = ConvertToRoman(i);
//        }

//        for (int i = 0; i < 3999; i++)
//        {
//            Console.WriteLine($"{i + 1}: {num[i]}");
//        }
//    }

//    static string ConvertToRoman(int number)
//    {
//        string[] thousands = { "", "M", "MM", "MMM" };
//        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
//        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
//        string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

//        return thousands[number / 1000] +
//               hundreds[(number % 1000) / 100] +
//               tens[(number % 100) / 10] +
//               units[number % 10];
//    }
//}


//task 2
//class Program
//{
//    static void Main()
//    {

//        int[,] array = new int[5, 6];


//        int value = 1;
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                array[i, j] = value++;
//                Console.Write(array[i, j]+ " ");

//            }
//            Console.WriteLine();
//        }
//    }
//}

//task 3
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string text = Console.ReadLine();


//        int wordCount = 0;
//        int vowelCount = 0;
//        int consonantCount = 0;
//        int punctuationCount = 0;
//        int digitCount = 0;
//        int otherCount = 0;
//        bool inWord = false;  


//        string vowels = "аеёиоуыэюяAEЁИОУЫЭЮЯ";
//        string consonants = "бвгдеёжзийклмнпрстфхцчшщБВГДЕЁЖЗИЙКЛМНПрСТФХЦЧШЩ";
//        string punctuation = ".,!?;:()[]{}\"'<>-_+=|\\^$#@%&*/";


//        for (int i = 0; i < text.Length; i++)
//        {
//            char c = text[i];


//            if (Char.IsLetter(c))
//            {
//                if (!inWord)  
//                {
//                    wordCount++;
//                    inWord = true;
//                }


//                if (vowels.Contains(c))
//                {
//                    vowelCount++;
//                }

//                else if (consonants.Contains(c))
//                {
//                    consonantCount++;
//                }
//            }
//            else if (Char.IsDigit(c))  
//            {
//                digitCount++;
//            }
//            else if (punctuation.Contains(c)) 
//            {
//                punctuationCount++;
//            }
//            else if (!Char.IsWhiteSpace(c))  
//            {
//                otherCount++;
//            }
//            else 
//            {
//                inWord = false;
//            }
//        }


//        int totalChars = text.Length;
//        Console.WriteLine($"Всего символов – {totalChars}, из них:");
//        Console.WriteLine($"Слов – {wordCount}");
//        Console.WriteLine($"Гласных – {vowelCount}");
//        Console.WriteLine($"Согласных – {consonantCount}");
//        Console.WriteLine($"Знаков пунктуации – {punctuationCount}");
//        Console.WriteLine($"Цифр – {digitCount}");
//        Console.WriteLine($"Др. символов – {otherCount}");
//    }
//}
