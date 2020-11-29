using System;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee();
            firstEmployee.setExp(4);
            firstEmployee.setSkill(6);
            firstEmployee.setSurname("Mike");
            firstEmployee.setName("Nike");

            
            Console.WriteLine("Employee is  " + firstEmployee.getVolume());
            Console.WriteLine("BonusPercent is  " + firstEmployee.getBonusPercent());
        }
    }
}
