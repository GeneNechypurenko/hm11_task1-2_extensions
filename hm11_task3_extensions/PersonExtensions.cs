using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm11_task3_extensions
{
    internal static class PersonExtensions
    {
        public static Person FindOldest(this Person[] people)
        {
            if (people.Length == 0)
            {
                throw new InvalidOperationException("The array is empty.");
            }

            Person oldestPerson = people[0];

            foreach (var person in people)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }

        public static Person FindYoungest(this Person[] people)
        {
            if (people.Length == 0)
            {
                throw new InvalidOperationException("The array is empty.");
            }

            Person youngestPerson = people[0];

            foreach (var person in people)
            {
                if (person.Age < youngestPerson.Age)
                {
                    youngestPerson = person;
                }
            }

            return youngestPerson;
        }

        public static double AverageAge(this Person[] people)
        {
            if (people.Length == 0)
            {
                throw new InvalidOperationException("The array is empty.");
            }

            int totalAge = 0;

            foreach (var person in people)
            {
                totalAge += person.Age;
            }

            return (double)totalAge / people.Length;
        }
    }
}
