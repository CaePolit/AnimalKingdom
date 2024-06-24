using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Turtle : Animal
    {
        public Turtle(string name) : base(4, false, name)
        { }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("but honestly..."+base.GetName+" is waaaay too slow...");
        }

    }
}
