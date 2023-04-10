﻿namespace Task6Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Male");
            Console.WriteLine(animal);
            
            Dog dog = new Dog("Araz", "Golden Retriever");

            Console.WriteLine(dog);


        }


    }
    internal record Animal
    {


        private string _gender;
        private int _birthday;
        public string Gender
        {
            get
            {

                return _gender;
            }
            set
            {
                _gender = value;

            }
        }

        public int BirthYear
        {
            get
            {
                return _birthday;
            }
            init
            {

                _birthday = value;

            }


        }
        public Animal(string gender, int birthyear=2023)
        {
            Gender = gender;
            BirthYear = birthyear;
        }
        public Animal()
        {
            
        }




    }
    internal record Dog:Animal
    {
        private string _name;
        private string _breed;

        public string Name { get  { return _name; } set { _name = value; } }
        public string Breed { get { return _breed; } init { _breed = value; } }


        public Dog(string name , string breed ) 
        {
            Name = name;
            Breed = breed;
        }
    } 
    
}