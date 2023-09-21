using System;

namespace Home_work_2
{
    internal class Program
    {
        //Функция проверяющая корректность введенного целого числа, возвращает в кортеже число и истину
        public static (int, bool) checking_for_valid_int_input(string number_str)
        {
            bool result = int.TryParse(number_str, out int converted_number);
            return (converted_number, result);
        }
        enum Bank_account
        {
            Savings_account = 1,
            Current_account = 2
        }

        struct Bank_account_information
        {
            public long account_number;
            public string account_type;
            public int account_balance;
            public void Print()
            {
                Console.WriteLine($"Номер счета: {account_number}\nТип счета: {account_type}\nБаланас счета: {account_balance}");
            }
        }

        enum Higher_education_institution
        {
            КГУ = 1,
            КФУ = 2,
            КХТИ = 3
        }
        struct Employee_of_a_higher_educational_institution
        {
            public string name;
            public string place_of_work;
            public void Print()
            {
                Console.WriteLine($"Имя работника: {name}\nМесто его работы: {place_of_work}");
            }
        }

        static void Main(string[] args)
        {
            // Упражение 3.1
            Console.WriteLine("Упражнение 3.1");
            Console.WriteLine("В этой задаче нужно создать перечислимый тип данных отображающий виды банковского\r\n" +
                "счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей\r\n" +
                "значение и вывести это значение на печать");
            Bank_account check_1 = Bank_account.Current_account;
            Bank_account check_2 = Bank_account.Savings_account;
            Console.WriteLine($"Счет {check_1} имеет знчачение {(int)check_1}\nСчет {check_2} имеет знчачение {(int)check_2}");

            // Упражение 3.2
            Console.WriteLine("Упражнение 3.2");
            Console.WriteLine("В этой задаче нужно cоздать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс.\r\n" +
                "Создать переменную такого типа, заполнить структуру значениями и напечатать результат");
            Bank_account_information bank_account_information_of_person_1 = new Bank_account_information();
            bank_account_information_of_person_1.account_number = 1234_5678_9012_3456;
            bank_account_information_of_person_1.account_type = "Current_account";
            bank_account_information_of_person_1.account_balance = 140000;
            bank_account_information_of_person_1.Print();

            // Домашнее задание 3.1
            Console.WriteLine("Домашнее задание 3.1");
            Console.WriteLine("В этой задаче нужно создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать \r\n" +
                "структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и распечатать.");
            Console.Write("Введите свое имя: ");
            Employee_of_a_higher_educational_institution employee_characteristics = new Employee_of_a_higher_educational_institution();
            employee_characteristics.name = Console.ReadLine();
            Console.Write("Введите номер места работы(КГУ-1, КФУ-2, КХТИ-3): ");
            string number_place_of_work = Console.ReadLine();
            if (checking_for_valid_int_input(number_place_of_work).Item2)
            {
                employee_characteristics.place_of_work = Enum.GetName(typeof(Higher_education_institution), (checking_for_valid_int_input(number_place_of_work).Item1));
                employee_characteristics.Print();
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
            Console.ReadKey();
        }
    }
}
