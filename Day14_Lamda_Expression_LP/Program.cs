﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Person> listpersonInCity = new List<Person>();
            AddRecords(listpersonInCity);
            Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listpersonInCity);
            CheckingForTeenagerPerson(listpersonInCity);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
            // Console.WriteLine(listPersonInCity.ToString());
            // listPersonInCity.ForEach(x => Console.WriteLine("{0}\t",x.Name.ToString()));

        }


        private static void CheckingForTeenagerPerson(List<Person> listpersonInCity)
        {
            if (listpersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("yes, we have some teenager in the list");
            }
            else
                Console.WriteLine("no , we dont have any teen ager in the list");
        }

        private static void Retrieving_TopTwoRecord_ForAgels_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())

            {
                Console.WriteLine("Name::" + person.Name + "\t\tAge::" + person.Age);
            }
        }

    }
}
