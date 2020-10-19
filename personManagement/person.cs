using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace personManagement
{
    class Person
    {

        public string SSn;
        public string Name;
        public string Address;
        public int Age;


        public Person(string ssn, string name, string adr, int age)
        {
            SSn = ssn;
            Name = name;
            Address = adr;
            Age = age;
        }
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Reterieving_TopTwoRecord_forAgels_LessThanSixty(listPersonInCity);
            CheckingForTeenagerPerson(listPersonInCity);
            CheckingAverageAgeInList(listPersonInCity);
            //CheckNameIsPresentOrNot(listPersonInCity);
            //SkipRecordLess60(listPersonInCity);
            //RemoveSpecificName(listPersonInCity);

            Console.ReadKey();

        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));

            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
        }
        private static void Reterieving_TopTwoRecord_forAgels_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
        }
        private static void CheckingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("yes,we have some teenager in list");
            }
            else
            {
                Console.WriteLine("no,we dont have");
            }
        }
        private static void CheckingAverageAgeInList(List<Person> listPersonInCity)
        {

            Console.WriteLine(" Average of all the person is...");
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);


        }
    }
}
