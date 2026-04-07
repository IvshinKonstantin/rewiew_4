using System.Linq;

namespace Task1
{
    //FIX_ME: Отступы 2 пробела
    public class Name : IDisplayable
    {
        //FIX_ME: Имена переменных/свойств в lower_case_with_underscores
        //public string LastName { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string patronymic { get; set; }

        //FIX_ME: Имя метода lower_case_with_underscores
        //public string GetText()
        public string get_text()
        {
            //FIX_ME: Переменная parts в snake_case
            //string[] parts = { LastName, FirstName, Patronymic };
            string[] parts = { last_name, first_name, patronymic };
            return string.Join(" ", parts.Where(p => !string.IsNullOrWhiteSpace(p)));
        }
    }

    public class House : IDisplayable
    {
        //FIX_ME: Поле в snake_case
        //public int Floors { get; }
        public int floors_count { get; }

        //FIX_ME: Конструктор: скобка на той же строке
        //public House(int floors) => Floors = floors;
        public House(int floors)
        {
            floors_count = floors;
        }

        public string get_text()
        {
            string suffix = "этажами";
            //FIX_ME: Имена переменных lower_case_with_underscores
            //int lastDigit = Floors % 10;
            int last_digit = floors_count % 10;
            int last_two = floors_count % 100;

            if (last_two >= 11 && last_two <= 14)
            {
                suffix = "этажами";
            }
            else if (last_digit == 1)
            {
                suffix = "этажом";
            }

            //FIX_ME: Использование snake_case переменной
            //return $"дом с {Floors} {suffix}";
            return $"дом с {floors_count} {suffix}";
        }
    }
}
