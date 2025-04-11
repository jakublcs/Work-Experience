using System.Text.Json;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Text.Json.Serialization;
using static ClassLibrary.Class1;
using static ClassLibrary.Class1.Methods;
using static ClassLibrary.Class1.Person;


namespace Greeting
{
    class Program
    {
        static string AddOrAccess()
        {
            bool unknown = true;
            while (unknown)
            {
                Console.WriteLine("Would you like to add a person or access the list? (type add or access)");
                string decision = Console.ReadLine() ?? "";
                Console.Write("\n");
                if (decision.ToLower() == "add")
                {
                    unknown = false;
                    return "add";
                }
                else if (decision.ToLower() == "access")
                {
                    unknown = false;
                    return "access";
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        static string ContinueOrNot()
        {
            bool unknown = true;
            while (unknown)
            {
                Console.WriteLine("Would you like to continue the program? (type yes or no)");
                string decision = Console.ReadLine() ?? "";
                Console.Write("\n");
                if (decision.ToLower() == "yes")
                {
                    unknown = false;
                    return "yes";
                }
                else if (decision.ToLower() == "no")
                {
                    unknown = false;
                    return "no";
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        static string GetName()
        {
            bool validName = false;

            while (validName != true)
            {
                Console.WriteLine("What is your first name? ");  //Asks for first name

                string firstName = Console.ReadLine() ?? "";  //Reads first name

                Console.WriteLine("\nWhat is your last name? ");   //Asks for last name

                string lastName = Console.ReadLine() ?? ""; //Reads last name

                string fullName = firstName + " " + lastName;

                string name = ValidateName(fullName);

                if (name != "false")
                {
                    validName = true;
                    return name;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }
        static int GetAge()
        {
            bool invalidAge = true;
            while (invalidAge)
            {
                string age;
                Console.WriteLine("\nHow old are you? ");
                age = Console.ReadLine() ?? "0";
                char[] numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (age[0] == numbers[i])
                    {
                        invalidAge = false;
                        int ageInt = Convert.ToInt32(age);
                        return ageInt;
                    }
                    else
                    {
                        if (i + 1 == numbers.Length)
                        {
                            invalidAge = true;
                            Console.Write("\n");
                            continue;
                        }
                        else
                        {
                            continue;

                        }
                    }
                }
            }
            return -1;
        }

        static List<String> GetPets()
        {
            bool unknownNumber = true;
            int numOfPets = 0;
            while (unknownNumber)
            {
                Console.WriteLine("\nHow many pets do you have? ");
                numOfPets = Convert.ToInt32(Console.ReadLine() ?? "0");
                if (numOfPets == 0)
                {
                    unknownNumber = false;
                    return null;
                }
                else if (numOfPets > 0)
                {
                    unknownNumber = false;
                }
                else
                {
                    continue;
                }
            }
            List<String> pets = new List<string>();
            for (int i = 0; i < numOfPets; i++)
            {
                Console.WriteLine("\nWhat is your pet's name? ");
                string petName = Console.ReadLine() ?? "";
                Console.WriteLine("\nWhat is your pet's ID? ");
                int petID = Convert.ToInt32(Console.ReadLine() ?? "0");
                Console.WriteLine("\nWhat species is your pet? ");
                string petSpecies = Console.ReadLine().ToUpper() ?? "";
                Pet pet = new Pet
                {
                    Name = petName,
                    Species = petSpecies,
                    Id = petID,
                };
                string petJson = JsonSerializer.Serialize(pet, new JsonSerializerOptions()
                {
                    WriteIndented = true
                });
                pets.Add(petJson);
                
            }
            return pets;
        }

        static void ShowResult(string name, int age)
        {
            Console.WriteLine($"\nHello {name}, you are {age} years old!\n");
        }

        static void Main(string[] args)
        {
            string cont = "yes";
            List<String> humanList = new List<string>();
            while (cont == "yes")
            {
                string add = AddOrAccess();
                if (add == "add")
                {
                    Person human = new Person("", 0)
                    {
                        Name = GetName(),
                        Age = GetAge(),
                        Pets = GetPets(),
                    };
                    ShowResult(human.Name, human.Age);
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string humanJson = JsonSerializer.Serialize<Person>(human, new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    });
                    var tempdata = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\ConsoleApp\\people.json");
                    if (tempdata == null)
                    {
                        File.AppendAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\ConsoleApp\\people.json", "[" + humanJson + "]");
                    }
                    else
                    {
                        string newdata = tempdata.Remove(tempdata.Length - 1, 1);
                        newdata = newdata + "," + humanJson + "]";
                        File.WriteAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\ConsoleApp\\people.json", newdata);
                    }
                    cont = ContinueOrNot();
                }
                else if (add == "access")
                {
                    var personJson = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\ConsoleApp\\people.json");
                    List<Person> persons = JsonSerializer.Deserialize<List<Person>>(personJson); 
                    
                    for (int i = 0; i < persons.Count(); i++)
                    {
                        var dePerson = persons[i];
                        Console.Write($"Name: {dePerson.Name}\nAge: {dePerson.Age}\nPets:");
                        for (int y = 0; y < dePerson.Pets.Count(); y++)
                        {
                            var pet = JsonSerializer.Deserialize<Pet>(dePerson.Pets[y]);
                            Console.Write($"\n\tName: {pet.Name}\n\tSpecies: {pet.Species}\n\tID: {pet.Id}\n");
                        }
                        if (dePerson.Pets.Count() == 0)
                        {
                            Console.Write("\n\tNone");
                        }
                        Console.Write("\n");
                    }
                    cont = ContinueOrNot();
                }
            }
        }

    }
}

