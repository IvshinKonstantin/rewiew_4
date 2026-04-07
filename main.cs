using System;
using System.Xml.Linq;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== ЗАДАНИЕ 1: ИМЕНА И ДОМА ===");
            Console.ResetColor();

            // Демонстрация Имен
            //FIX_ME: Имена свойств должны соответствовать стилю snake_case, а скобка { быть на той же строке
            //var n1 = new Name { FirstName = "Клеопатра" };
            var n1 = new Name { first_name = "Клеопатра" };

            //FIX_ME: Использование snake_case для свойств
            //var n2 = new Name { LastName = "Пушкин", FirstName = "Александр", Patronymic = "Сергеевич" };
            var n2 = new Name
            {
                last_name = "Пушкин",
                first_name = "Александр",
                patronymic = "Сергеевич"
            };

            //FIX_ME: Вызов метода в стиле snake_case
            //Console.WriteLine($"Имя 1: {n1.GetText()}\nИмя 2: {n2.GetText()}");
            Console.WriteLine($"Имя 1: {n1.get_text()}\nИмя 2: {n2.get_text()}");

            // Ввод Дома с проверкой
            //FIX_ME: Имя метода read_int
            //int floors = ReadInt("\nВведите количество этажей для нового дома: ", 1, 200);
            int floors = read_int("\nВведите количество этажей для нового дома: ", 1, 200);

            House h = new House(floors);
            Console.ForegroundColor = ConsoleColor.Green;

            //FIX_ME: Имя метода get_text
            //Console.WriteLine($"Результат: {h.GetText()}");
            Console.WriteLine($"Результат: {h.get_text()}");
            Console.ResetColor();
        }

        //FIX_ME: Имя метода lower_case_with_underscores, отступы 2 пробела, скобка на той же строке
        //static int ReadInt(string prompt, int min, int max)
        static int read_int(string prompt, int min, int max)
        {
            int val;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out val) && val >= min && val <= max)
                {
                    return val;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Ошибка] Введите число от {min} до {max}");
                Console.ResetColor();
            }
        }
    }
}
