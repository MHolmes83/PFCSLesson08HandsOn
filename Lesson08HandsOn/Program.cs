using System;

namespace Lesson08HandsOn
{
    public interface Mammal
        {
            string speak();
            string run();
        }

    public interface Animal
    {
        string eat();
    }

    public class Dog : Mammal, Animal
    {
        private string name;

        public Dog(string name)
        {
            this.name = name;
        }

        public string speak()
        {
            return "Bark!";
        }
        
        public string run()
        {
            return "Dogs can run at a top speen of 45 mph!";
        }

        public string eat()
        {
            return "Dogs eat bones.";
        }
    }

    public class Cat : Mammal, Animal
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public string speak()
        {
            return "Meow!";
        }

        public string run()
        {
            return "Cats can run at a top speed of 30 mph!";
        }

        public string eat()
        {
            return "Cats eat mice.";
        }
    }

    public class Cow : Mammal, Animal
    {
        private string name;

        public Cow(string name)
        {
            this.name = name;
        }

        public string speak()
        {
            return "Moo!";
        }

        public string run()
        {
            return "Cows can run at a top speed of 25 mph";
        }

        public string eat()
        {
            return "Cows eat grass.";
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Dog spot = new Dog("Spot");
            Console.WriteLine(spot.speak());
            Console.WriteLine(spot.run());
            Console.WriteLine(spot.eat());

            Cat fluffy = new Cat("Fluffy");
            Console.WriteLine(fluffy.speak());
            Console.WriteLine(fluffy.run());
            Console.WriteLine(fluffy.eat());

            Cow bessie = new Cow("Bessie");
            Console.WriteLine(bessie.speak());
            Console.WriteLine(bessie.run());
            Console.WriteLine(bessie.eat());
        }
    }
}