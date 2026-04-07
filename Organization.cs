namespace Task2
{
    public class Department
    {
        public string Name { get; set; }
        public Employee Manager { get; set; }
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public Department CurrentDepartment { get; set; }

        public string GetInfo()
        {
            if (CurrentDepartment?.Manager == this)
                return $"{Name} начальник отдела {CurrentDepartment.Name}";
            return $"{Name} работает в отделе {CurrentDepartment?.Name}, начальник которого {CurrentDepartment?.Manager?.Name ?? "Не назначен"}";
        }
    }
}
