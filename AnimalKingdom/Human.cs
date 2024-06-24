using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Human : Animal
    {
        public Human(string name) : base( 2, true, name)
        { }
        public override void Eat()
        {
            Console.WriteLine(base.GetName() + " it's having a quater pound with double cheese!");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine(base.GetName() + ".. in the kitchen ^^");
        }
    }
}
