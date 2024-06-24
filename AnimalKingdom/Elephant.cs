using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(4, false, name)
        { }
       
        public override void Move()
        {
            base.Move();
            Console.WriteLine("but don't get too close to him. "+base.GetName()+" its a big guy, he could smash you.");
        }
    }
}
