﻿using System;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee();
            firstEmployee.setExp(0);
            firstEmployee.setSkill(0);
            firstEmployee.setSurname("Mike");
            firstEmployee.setName("Nike");
                        
            Console.WriteLine("Employee is  " + firstEmployee.getVolume() + " expirience is " + //firstEmployee.setExp() + 
                "   BonusPercent is  " + firstEmployee.getBonusPercent());
            //Console.WriteLine("BonusPercent is  " + firstEmployee.getBonusPercent());

            Employee secondEmployee = new Employee();
            secondEmployee.setExp(3);
            secondEmployee.setSkill(0);
            secondEmployee.setSurname("Oslo");
            secondEmployee.setName("Luko");


            Console.WriteLine("Employee is  " + secondEmployee.getVolume() + "   BonusPercent is  " + secondEmployee.getBonusPercent());
            // Console.WriteLine("BonusPercent is  " + secondEmployee.getBonusPercent());

            Employee thierdEmployee = new Employee();
            thierdEmployee.setExp(6);
            thierdEmployee.setSkill(2);
            thierdEmployee.setSurname("Oslo");
            thierdEmployee.setName("Luko");


            Console.WriteLine("Employee is  " + thierdEmployee.getVolume() + "   BonusPercent is  " + thierdEmployee.getBonusPercent());
            // Console.WriteLine("BonusPercent is  " + thierdEmployee.getBonusPercent());

            Employee fourthEmployee = new Employee();
            fourthEmployee.setExp(7);
            fourthEmployee.setSkill(4);
            fourthEmployee.setSurname("Mark");
            fourthEmployee.setName("Twen");


            Console.WriteLine("Employee is  " + fourthEmployee.getVolume() + "   BonusPercent is  " + fourthEmployee.getBonusPercent());
            // Console.WriteLine("BonusPercent is  " + fourthEmployee.getBonusPercent());

            Employee fifthEmployee = new Employee();
            fifthEmployee.setExp(8);
            fifthEmployee.setSkill(5);
            fifthEmployee.setSurname("John");
            fifthEmployee.setName("Right");


            Console.WriteLine("Employee is  " + fifthEmployee.getVolume() + "   BonusPercent is  " + fifthEmployee.getBonusPercent());
            // Console.WriteLine("BonusPercent is  " + fifthEmployee.getBonusPercent());
        }

    }
}
