using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1
{
   public class TestUnit
    {
        [Test]
        public void checkExperienceLessThan0()
        {
            Employee firstEmployee = new Employee(0, 1, "Mike", "Nike");
            Assert.IsTrue(firstEmployee.getBonusPercent() == 0);
        }

        [Test]
        public void checkExperienceLessFrom_0_To_5()
        {
            Employee secondEmployee = new Employee(3, 1, "Oslo", "Luko");
            Assert.IsTrue(secondEmployee.getBonusPercent() == 5);
        }

        [Test]
        public void checkExperienceAbove_5_Skill_less_3()
        {
            Employee thirdEmployee = new Employee(6, 2, "Ricky", "Russo");
            Assert.IsTrue(thirdEmployee.getBonusPercent() == 10);
        }


        [Test]
        public void checkExperienceAbove_5_Skill_from_3_to_4()
        {
            Employee fourthEmployee = new Employee(7, 4, "Mark", "Twen");
            Assert.IsTrue(fourthEmployee.getBonusPercent() == 15);
        }

        [Test]
        public void checkExperienceAbove_5_Skill_from_5()
        {
            Employee fifthEmployee = new Employee(8, 5, "John", "Right");
            Assert.IsFalse(fifthEmployee.getBonusPercent() == 21);
        }
        [Test]
        public void checkExperienceAbove_5_Skill_from_5_Error()
        {
            Employee fifthEmployee = new Employee(8, 5, "John", "Right");
            Assert.IsTrue(fifthEmployee.getBonusPercent() == 21);
        }
    }
}
