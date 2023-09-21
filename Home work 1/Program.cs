using System;


namespace Home_work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Функция проверяющая корректность введенного целого числа, возвращает в кортеже число и истину
            (int, bool) checking_for_valid_int_input(string number_str)
            {
                bool result = int.TryParse(number_str, out int converted_number);
                return (converted_number, result);
            }
            // Упражнение 2.1
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("В этой задаче пользователь вводит свое имя и программа выводит его обратно с приветствием");
            Console.Write("Введите ваше имя: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {username}!");
            // Упражнение 2.2
            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("В этой задаче пользователь вводит два целых, а на выходе получает поделенное первое число на второе");
            Console.Write("Введите первое число: ");
            string first_variable_str = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string second_variable_str = Console.ReadLine();
            int first_variable = checking_for_valid_int_input(first_variable_str).Item1;
            bool first_truth = checking_for_valid_int_input(first_variable_str).Item2;

            int second_variable = checking_for_valid_int_input(second_variable_str).Item1;
            bool second_truth = checking_for_valid_int_input(second_variable_str).Item2;
            if (first_truth && second_truth)
            {
                if (second_variable != 0)
                {
                    double divided_number = Convert.ToDouble(first_variable) / second_variable;
                    Console.WriteLine($"Результат: {divided_number}");
                }
                else
                {
                    Console.WriteLine("Нелья делить на ноль");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
            // Домашнее задание 2.1
            Console.WriteLine("Домашнее задание 2.1");
            Console.WriteLine("В этой задаче пользователь вводит букву и программа возвращет следующую по алфавиту букву");
            Console.Write("Введите букву: ");
            string variable = Console.ReadLine();
            if (variable.Length == 1)
            {
                if (!checking_for_valid_int_input(variable).Item2)
                {
                    char variable_char = Convert.ToChar(variable);
                    if (variable_char == 'z' | variable_char == 'Z')
                    {
                        Console.WriteLine($"Следующая по алфавиту букву сначала: {Convert.ToChar(Convert.ToInt32(variable_char) - 25)}");
                    }
                    else if (variable_char == 'я' | variable_char == 'Я')
                    {
                        Console.WriteLine($"Следующая по алфавиту букву сначала: {Convert.ToChar(Convert.ToInt32(variable_char) - 32)}");
                    }
                    else
                    {
                        Console.WriteLine($"Следующая по алфавиту букву: {Convert.ToChar(Convert.ToInt32(variable_char) + 1)}");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели число");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели более одного символа или не ввели ничего");
            }
            // Домашнее задание 2.2
            Console.WriteLine("Домашнее задание 2.2");
            Console.WriteLine("В этой задаче пользователь вводит коэффиценты квадратного уравнения и программа выводит его корни при наличии");
            Console.Write("Введите коэффицент a: ");
            string coefficient_a_str = Console.ReadLine();
            Console.Write("Введите коэффицент b: ");
            string coefficient_b_str = Console.ReadLine();
            Console.Write("Введите коэффицент c: ");
            string coefficient_c_str = Console.ReadLine();
            if (checking_for_valid_int_input(coefficient_a_str).Item2 & checking_for_valid_int_input(coefficient_b_str).Item2 
                & checking_for_valid_int_input(coefficient_c_str).Item2)
            {
                double coefficient_a = double.Parse(coefficient_a_str);
                double coefficient_b = double.Parse(coefficient_b_str);
                double coefficient_c = double.Parse(coefficient_c_str);
                double discriminant = (Math.Pow(coefficient_b, 2)) - (4 * coefficient_a * coefficient_c);
                if (discriminant > 0)
                {
                    double x1 = ((-coefficient_b + Math.Sqrt(discriminant)) / (2 * coefficient_a));
                    double x2 = ((-coefficient_b - Math.Sqrt(discriminant)) / (2 * coefficient_a));
                    Console.WriteLine($"Первый корень: {x1}\nВторой корень: {x2}");
                }
                else if (discriminant == 0)
                {
                    double x = ((-coefficient_b) / (2 * coefficient_a));
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Дискриминант меньше нуля, решения нет");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.ReadKey();
        }
    }
}
