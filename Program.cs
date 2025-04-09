using System.Text.Json;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.IO.Compression;


namespace Greeting
{

    public class Person
    {
        private string name;
        private int age;
        private List<String> pets;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, "\"[^a-zA-z]\"g"))
                {
                    throw new ArgumentException();
                }

                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                age = value;
            }
        }
        public required List<string> Pets
        {
            get { return pets; }
            set { pets = value; }
        }
    }

    public class Pet
    {
        public void Person(string name, int id, string species)
        {
            this.name = name;
            this.id = id;
            this.species = species;
        }

        private string name;
        private string species;
        private int id;
        public string Name
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, "\"[^a-zA-z]\"g"))
                {
                    throw new ArgumentException();
                }

                name = value;
            }
        }
        public string Species
        {
            get { return species; }
            set
            {
                if (Regex.IsMatch(value, "\"[^a-zA-z]\"g"))
                {
                    throw new ArgumentException();
                }

                species = value;
            }
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                id = value;
            }
        }
    }

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

                int invalidCharacters = 0;
                int validCharactersTotal = 0;
                string validCharactersString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
                char[] validCharacters = validCharactersString.ToCharArray();    //Suitable characters for a name

                while (validCharactersTotal != fullName.Length && invalidCharacters == 0)           //Iterates through the name and checks all characters are valid
                {
                    for (int i = 0; i < fullName.Length; i += 1)
                    {
                        char letter1temp = fullName[i];

                        for (int z = 0; z < validCharacters.Length; z += 1)
                        {
                            char letter2temp = validCharacters[z];

                            if (fullName[i] == letter2temp)
                            {
                                validCharactersTotal += 1;
                                continue;
                            }
                            else
                            {
                                if (z + 1 == validCharacters.Length)
                                {
                                    invalidCharacters = 1;
                                }
                                else
                                {
                                    invalidCharacters = 0;
                                    continue;
                                }
                            }
                        }
                    }
                    if (validCharactersTotal == fullName.Length)
                    {
                        invalidCharacters = 0;
                    }
                    if (invalidCharacters == 0)
                    {
                        return fullName;
                    }
                    else
                    {
                        Console.Write("\n");
                        continue;
                    }
                }
            }
            return "false";
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
                        else;
                        continue;
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
                string petJson = JsonSerializer.Serialize(pet);
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

                    string humanJson = JsonSerializer.Serialize(human);
                    File.AppendAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\people.txt", humanJson);
                    cont = ContinueOrNot();
                }
                else if (add == "access")
                {
                    humanList.Clear();
                    StreamReader reader = new StreamReader("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\people.txt");
                    string data = reader.ReadLine();
                    while (data != null)
                    {
                        humanList.Add(data);
                        data = reader.ReadLine();
                    }
                    humanList = JsonSerializer.Deserialize(data);
                    Console.Write(humanList);
                    reader.Close();
                    Console.Write("\n");
                    cont = ContinueOrNot();
                }
            }
        }

    }
}

