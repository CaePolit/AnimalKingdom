using AnimalKingdom;
using System;

class Program
{
    public static void Main(string[] args)
    {
        //on  creer une liste avec les differents animaus instanciés depuis les methodes AddAnimal
        //(AddHuman,AddMonkey, AddLizard, AddElephant, AddTurtoise)
        // Dans la liste<animal> on peur en trouver tous les animaux issus des methodes d'en haut
        Animal[] animalsSet = new Animal[5];

        Human human = new Human("Jules");
        animalsSet[0] = human;
        Elephant elephant = new Elephant("Dumbo");
        animalsSet[1] = elephant;
        Monkey monkey = new Monkey("Mico");
        animalsSet[2] = monkey;
        Turtle turtle = new Turtle("Franklin");
        animalsSet[3] = turtle;
        Lizard lizard = new Lizard("Jango");
        animalsSet[4] = lizard;

        foreach (Animal animal in animalsSet)

        {
            animal.Move();
            animal.Eat(); // Dog and Cat eat in the same manner !
        }

    }
}