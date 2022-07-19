using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces
{
    public interface Shape
    {
        double area();
    }

    public class Square
    {
        double length;

        public Square(double length)
        {
            this.length = length;
        }

        public double area()
        {
            return length * length;
        }
    }

    public class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            return 3.14 * radius * radius;
        }
    }

    public interface FoodConsumer
    {
        string eat();
    }

    public interface Animal
    {
        string sound();
    }

    public class Mammal
    {
        private string name;

        public Mammal(string name)
        {
            this.name = name;
        }

        public string greet()
        {
            return "Hello, I'm " + this.name + ".";
        }
    }

    public class Dog : Mammal, FoodConsumer, Animal
    {
        public Dog(string name) : base(name)
        {}

        public string eat()
        {
            return "Yum yum!";
        }

        public string sound()
        {
            return "Woof!";
        }
    }

    public abstract class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void sayHello();

        public int getAge()
        {
            return this.age;
        }
    }

    public class Teacher : Person
    {
        string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            setSubject(subject);
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
        }

        public override void sayHello()
        {
            Console.WriteLine("Hellow, my name is " + this.name + ", and I teach " + this.subject + ".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 19.50;
            Square sq = new Square(squareLength);
            double area = sq.area();
            Console.WriteLine(area);

            double circleRadius = 4;
            Circle cir = new Circle(circleRadius);
            double circleArea = cir.area();
            Console.WriteLine(circleArea);

            Dog spot = new Dog("Spot");
            Console.WriteLine(spot.greet());
            Console.WriteLine(spot.eat());
            Console.WriteLine(spot.sound());

            Teacher teacher = new Teacher("Tim Boyd", 35, "English");
            teacher.sayHello();

            var animals = new List<string>();
            animals.Add("bird");
            animals.Add("horse");
            animals.Add("dog");
            animals.Add("cat");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal + " ");
            }

            var newAnimals = new ArrayList();
            newAnimals.Add("lizard");
            newAnimals.Add("snake");
            newAnimals.Add("bat");
            newAnimals.Add("rat");

            foreach (var newAnimal in newAnimals)
            {
                Console.WriteLine(newAnimal + " ");
            }
        }
    }
}