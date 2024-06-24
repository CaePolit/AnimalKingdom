using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Lizard : Animal
    {
        public Lizard(string name) : base(4, true, name)
        { }
        public override void Eat()
        {

            Console.WriteLine("Those little flies will be no match for "+base.GetName);
        }

    }
}
