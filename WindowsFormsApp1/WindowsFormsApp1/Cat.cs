using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cat
    {
        private string _name;
        private int _age;
        private int _weight;
        private int _satiety; //уровень сытости кота 
        public static uint _amountOfCats;

        public Cat()
        {

        }

        public Cat(string name, int age, int weight)
        {
            Random rnd = new Random();
            _name = name;
            _age = age;
            _satiety = (int)rnd.Next(101);
            _weight = weight;
            ++_amountOfCats;
        }

        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public int GetWeight()
        {
            return _weight;
        }
        public void SetWeight(int weight)
        {
            _weight = weight;
        }
        public int GetSatiety()
        {
            return _satiety;
        }
        public void SetSatiety(int satiety)
        {
            _satiety = satiety;
        }

        public void GetInformationAboutTheCat()
        {

        }
    }

   
}
