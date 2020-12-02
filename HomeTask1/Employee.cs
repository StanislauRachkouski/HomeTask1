using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1
{
    class Employee
    {

        int exp;
        int skill;
        string surname;
        string name;

        /*
        public void setExp(int param)
        {
            this.exp = param;
           
        }


        public void setSkill(int param)
        {
            this.skill = param;

        }

        public void setSurname(string param)
        {
            this.surname = param;
        }

        public void setName(string param)
        {
            this.name = param;

        }
        */

        public Employee(int exp, int skill, string surname, string name)
        {
            this.exp = exp; 
            this.skill=skill;
            this.surname=surname;
            this.name=name;
        }
        public string getVolume()
        {
            string empl = this.name + " " + this.surname;
            return empl;

        }
       public int getExp()
        {
            return exp;
        }

        public int getSkill()
        {
            if ((skill > 5) || (skill < 1))
            {
                Console.WriteLine("Vvedite verniy skill");
                
            }
            return skill;
        }

        public int getBonusPercent()
        {
            /*
            int per=0;


            if (this.exp < 1)
            {
               per = 0;
                return per;
            }
            if (this.exp < 5)
            {
                per = 5;
                return per;
            }
            if ((this.exp >= 5) && (this.skill < 3))
            {
                per = 10;
                return per;
            }
            if ((this.exp > 5) && (this.skill >= 3) && (this.skill <= 4))
            {
                per = 15;
                return per;
            }
            if ((this.exp > 5) && (this.skill == 5))
            {
                per = 20;
                return per;
            }

            else Console.WriteLine("Vvedite vernie parametry");

            return per;
            */
            {
                if (this.exp < 1) return 0;
                if (this.exp < 5) return 5;
                if ((this.exp >= 5) && (this.skill < 3)) return 10;
                if ((this.exp > 5) && this.skill >= 3 && this.skill <= 4) return 15;
                if (this.exp > 5 && this.skill == 5) return 20;

                else Console.WriteLine("Vvedite vernie parametry");
                return -1;
            }

        }
    }

}

       