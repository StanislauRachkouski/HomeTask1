using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1
{
    class Employee
    {
        int exp;
        int skill;
        public string surname;
        string name;


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

        public string getVolume()
        {
            string empl = this.name + " " + this.surname;
            return empl;

        }
       

        
        public int getBonusPercent()
        {

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

            


        }


    }

}

       