using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public abstract class Animal
    {
        protected short _legsCount;

        protected bool _predator;

        private string _name;

        public Animal (short legsCount, bool predator, string name)
        {
            this._legsCount = legsCount;
            this._predator = predator;
            _name = name;


        }

        public virtual void Move()
        {
            if (_predator) { Console.WriteLine("be Carefull! " + _name + " it's up for the hunt!"); }
            else { Console.WriteLine("aww.. " + _name + " looks very playfull :)"); }
        }

        public virtual void Eat()
        {
            Console.WriteLine(_name + " eats");
        }

        public string GetName() { return _name; }



    }
}
