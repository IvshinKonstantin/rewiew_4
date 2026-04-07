using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 2: ОТДЕЛ IT ===");
            var it = new Department { Name = "IT" };
            var kozlov = new Employee { Name = "Козлов", CurrentDepartment = it };
            it.Manager = kozlov;

            var petrov = new Employee { Name = "Петров", CurrentDepartment = it };

            Console.WriteLine(petrov.GetInfo());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(kozlov.GetInfo());
            Console.ResetColor();
        }
    }
}
