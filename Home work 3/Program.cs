using System;
using System.CodeDom.Compiler;

namespace Home_work_3
{
    internal class Program
    {
        //Функция проверяющая корректность введенного целого числа, возвращает в кортеже число и истину
        public static (int, bool) checking_for_valid_int_input(string number_str)
        {
            bool result = int.TryParse(number_str, out int converted_number);
            return (converted_number, result);
        }
        // Вычисление контрольной суммы
        public static int calculating_the_checksum(string barcode_str)
        {
            int temp = 0;
            int number = 0;
            for (int i = barcode_str.Length - 2; i > -1; i--)
            {
                number += 1;
                if (number % 2 == 0)
                {
                    temp += int.Parse(barcode_str[i].ToString());
                }
                else
                {
                    temp += int.Parse(barcode_str[i].ToString()) * 3;
                }
            }
            return ( 10 - ((temp) % 10));
        }

        public struct User
        {
            public string name;
            public int age;
            public int pincod;
        }
        static void Main(string[] args)
        {
            // Задача 1
            Console.WriteLine("Задача 1");
            Console.WriteLine("Задча заключается в выводе информацию о каждом типе данных в виде");
            Console.WriteLine("Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine($"byte- максимальное значение: {byte.MinValue}- минимальное значение {byte.MaxValue}");
            Console.WriteLine($"sbyte- максимальное значение: {sbyte.MinValue}- минимальное значение {sbyte.MaxValue}");
            Console.WriteLine($"short- максимальное значение: {short.MinValue}- минимальное значение {short.MaxValue}");
            Console.WriteLine($"ushort- максимальное значение: {ushort.MinValue}- минимальное значение {ushort.MaxValue}");
            Console.WriteLine($"int- максимальное значение: {int.MinValue}- минимальное значение {int.MaxValue}");
            Console.WriteLine($"uint- максимальное значение: {uint.MinValue}- минимальное значение {uint.MaxValue}");
            Console.WriteLine($"long- максимальное значение: {long.MinValue}- минимальное значение {long.MaxValue}");
            Console.WriteLine($"ulong- максимальное значение: {ulong.MinValue}- минимальное значение {ulong.MaxValue}");
            Console.WriteLine($"float- максимальное значение: {float.MinValue}- минимальное значение {float.MaxValue}");
            Console.WriteLine($"double- максимальное значение: {double.MinValue}- минимальное значение {double.MaxValue}");
            Console.WriteLine($"decimal- максимальное значение: {decimal.MinValue}- минимальное значение {decimal.MaxValue}");

            // Задача 2
            Console.WriteLine("Задача 2");
            Console.WriteLine("Напишите программу, в которой принимаются данные пользователя в виде имени,\r\n" +
                "города, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\n" +
                "переменной, а затем распечатайте всю информацию в правильном формате.");
            User user;
            Console.Write("Введите имя пользователя: ");
            string name_user = Console.ReadLine();
            user.name = name_user;
            Console.WriteLine("Введите возраст: ");
            user.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Пин-код: ");
            user.pincod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя пользователя: {user.name}\nВозраст пользоавтеля{user.age}\nПин код пользователя{user.pincod}");



            // Задача 4
            Console.WriteLine("\nЗадача 4: Введите строку, введите подстроку.Необходимо найти количество вхождений и вывести на экран.");
            Console.Write("Введите произвольную строку: ");
            string str = Console.ReadLine();
            if (str == "") 
            { 
                Console.WriteLine("Вы ввели пустую строку"); 
            }
            else
            {
                Console.Write("Введите подстроку: ");
                string sub_str = Console.ReadLine();
                if (sub_str == "") 
                { 
                    Console.WriteLine("Подстрока пуста"); 
                }
                else
                {
                    string temp_str = str.Replace(sub_str, "");
                    Console.WriteLine($"Указанная подстрока встечается в строке {(str.Length - temp_str.Length) / (sub_str.Length)} раз(а)");
                }
            }


            // Задача 7
            Console.WriteLine("Задача 7");
            Console.WriteLine("Задача заключается в получении штрихкрода ean13 и вычислении контрольной суммы этого кода");
            Console.Write("Введите 12 цифр штрих-кода: ");
            string barcode_str = Console.ReadLine();
            if (checking_for_valid_int_input(barcode_str).Item2 | barcode_str.Length == 12)
            {
                Console.WriteLine($"Контрольная сумма пользователя: {calculating_the_checksum(barcode_str)}");
            }
            else
            {
                Console.WriteLine("Неверно введен штрих код");
            }
        }
    }
}
