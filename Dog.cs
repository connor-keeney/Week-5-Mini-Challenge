using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public enum Gender
    {
        Male,
        Female
    }
    class Dog
    {
        private string name;
        private string owner;
        private int age;
        private Gender gender;

        public Dog(string _name, string _owner, int _age, Gender _gender)
        {
            name = _name;
            owner = _owner;
            age = _age;
            gender = _gender;
        }
        public Dog()
        {
            name = "unknown";
            owner = "unknown";
            age = 0;
            gender = Gender.Male;
        }

        public void Bark(int numberOfWoofs)
        {
            for (int i = 0; i < numberOfWoofs; i++)
            { 
                Console.WriteLine("Woof!");
            }
        }

        public string getTag()
        {
            string RetVal = "";
            string HeShe = "she";
            string HisHers = "her";
            string YrYrs = "year";

            if(gender == Gender.Male)
            {
                HeShe = "he";
                HisHers = "his";
            }

            if(age > 1)
            {
                YrYrs = "years";
            }

            RetVal = "If lost, call " + owner + " " + HisHers + " name is " + name + " and " + HeShe + " is " + age.ToString() + " " + YrYrs + " old.";
            return RetVal;
        }
        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public int Age { get => age; set => age = value; }
        public Gender Gender { get => gender; set => gender = value; }


    }
}
