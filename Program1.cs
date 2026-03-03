using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Бобик", 3, 5);
            Dog dog1 = new Dog("Сова", 1, 6, "мышь");

            Animal hiddenDog = new Dog("Жв", 6, 4, "мясо");

            hiddenDog.Simple();
            hiddenDog.Print();

            //animal1.Simple();
            //animal1.Print();

            //dog1.Simple();
            //dog1.Print();

            Animal[] qq = new Animal[] { animal1, dog1, hiddenDog };
            for (int i =0; i<qq.Length; i++)
            {
                if (qq[i] is Dog)
                {
                    Dog s = qq[i] as Dog; // as приводит к типу который указали
                    Console.WriteLine(s.Food);
                }
            }
        }
    }

    public class Animal
    {
        protected string _name;
        protected int _fur;
        protected int _age;


        public Animal(string name, int fur, int age)
        {
            _name = name;
            _fur = fur;
            _age = age;
        }

        public void Simple()
        {
            Console.WriteLine("Вызов животного");
        }

        public virtual void Print()
        {
            Console.WriteLine($"Animal: {_name}, возраст: {_age}, длина шерсти: {_fur}");
        }
    }

    public class Dog : Animal
    {
        private string _food;
        public string Food => _food;
        public Dog(string name, int fur, int age, string food) : base(name, fur, age)
        {
            _food = food;
        }

        public new void Simple()
        {
            Console.WriteLine("Вызов собаки");
        }

        public override void Print() //переопределение метода
        {
            Console.WriteLine($"Dog: {_name}, возраст: {_age}, длина шерсти: {_fur}, корм: {_food}");
        }
    }
}
