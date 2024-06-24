using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Monkey : Animal
    {
        public Monkey(string name) : base(2, false, name)
        { }
        public override void Eat()
        {
            
            Console.WriteLine(base.GetName() + " it's having a mango!");
        }
      
    }
}
