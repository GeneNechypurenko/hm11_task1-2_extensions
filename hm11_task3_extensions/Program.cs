using hm11_task3_extensions;

Person[] people = new Person[]
{
    new Person("John", "Doe", 31),
    new Person("Sam", "Smith", 22),
    new Person("Mathew", "Price", 32),
    new Person("Alex", "Bell", 20),
    new Person("George", "Bush", 28)
};

Person oldestPerson = people.FindOldest();
Person youngestPerson = people.FindYoungest();
double averageAge = people.AverageAge();

Console.WriteLine($"Oldest person: {oldestPerson.FirstName} {oldestPerson.LastName}, Age: {oldestPerson.Age}");
Console.WriteLine($"Youngest person: {youngestPerson.FirstName} {youngestPerson.LastName}, Age: {youngestPerson.Age}");
Console.WriteLine($"Average age: {averageAge}");