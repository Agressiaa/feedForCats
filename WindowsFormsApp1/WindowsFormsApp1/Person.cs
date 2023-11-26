using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        private string _name;
        private int _id;
        private List<string> _cats;
        private Dictionary<string, List<string>> _usersCats;

        public Person(string name)
        {
            _name = name;
            _id++;
            _cats = new List<string>();
            _usersCats = new Dictionary<string, List<string>>()
                {
                    { _name, _cats}

                };
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public int GetId()
        {
            return _id;
        }

        public void AddUsersCats(string nameOfTheCat)
        {
            _cats.Add(nameOfTheCat);
        }

        public void ShowCats()
        {
            foreach (KeyValuePair<string, List<string>> pair in _usersCats)
            {
                Console.Write("Имя хозяина " + pair.Key + ", питомцы: ");
                for (int i = 0; i < pair.Value.ToArray().Length; i++)
                {
                    Console.Write((i + 1) + "." + pair.Value.ToArray()[i] + " ");
                }
            }
        }
    }
}
