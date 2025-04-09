﻿using System.Text.Json;

namespace Work_Experience
{
    public class Person
    {
        public string Name
        {
            get;
            set
            {
                try
                {
                    _ = Convert.ToInt32(value);
                    throw new EntryPointNotFoundException();
                }
                catch (EntryPointNotFoundException)
                {
                    Environment.Exit(1);
                }
                catch (Exception)
                {
                    field = value;
                }
            }
        }
        public int Age
        {
            get;
            set => field = value >= 0 ? value : throw new IndexOutOfRangeException();
        }
        //public required List<Pet> Pets { get; set; }
    }

    public class Pet
    {
        public string Name
        {
            get;
            set
            {
                try
                {
                    _ = Convert.ToInt32(value);
                    throw new EntryPointNotFoundException();
                }
                catch (EntryPointNotFoundException)
                {
                    Environment.Exit(1);
                }
                catch (Exception)
                {
                    field = value;
                }
            }
        }
        public string Species
        {
            get;
            set
            {
                try
                {
                    _ = Convert.ToInt32(value);
                    throw new EntryPointNotFoundException();
                }
                catch (EntryPointNotFoundException)
                {
                    Environment.Exit(1);
                }
                catch (Exception)
                {
                    field = value;
                }
            }
        }
        public long Id
        {
            get;
            set => field = value >= 0 ? value : throw new IndexOutOfRangeException();
        }
    }

    class Program
    {
        static string? AddOrAccess()
        {
            bool unknown = true;
            while (unknown)
            {
                Console.WriteLine(
                    "Would you like to add a person or access the list? (type add or access)"
                );
                string decision = Console.ReadLine();
                Console.Write("\n");
                if (decision.ToLower() == "add")
                {
                    return "add";
                }
                else if (decision.ToLower() == "access")
                {
                    return "access";
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        static string? ContinueOrNot()
        {
            bool unknown = true;
            while (unknown)
            {
                Console.WriteLine("Would you like to continue the program? (type yes or no)");
                string decision = Console.ReadLine();
                Console.Write("\n");
                if (decision.ToLower() == "yes")
                {
                    return "yes";
                }
                else if (decision.ToLower() == "no")
                {
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
                Console.WriteLine("What is your first name? "); //Asks for first name

                string firstName = Console.ReadLine(); //Reads first name

                Console.WriteLine("\nWhat is your last name? "); //Asks for last name

                string lastName = Console.ReadLine(); //Reads last name

                string fullName = firstName + " " + lastName;

                int invalidCharacters = 0;
                int validCharactersTotal = 0;
                string validCharactersString =
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
                char[] validCharacters = validCharactersString.ToCharArray(); //Suitable characters for a name

                while (validCharactersTotal != fullName.Length && invalidCharacters == 0) //Iterates through the name and checks all characters are valid
                {
                    for (int i = 0; i < fullName.Length; i += 1)
                    {
                        _ = fullName[i];

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
                age = Console.ReadLine();
                char[] numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (age[0] == numbers[i])
                    {
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
                            ;
                        continue;
                    }
                }
            }
            return -1;
        }

        static List<string>? GetPets()
        {
            bool unknownNumber = true;
            int numOfPets = 0;
            while (unknownNumber)
            {
                Console.WriteLine("\nHow many pets do you have? ");
                numOfPets = Convert.ToInt32(Console.ReadLine());
                if (numOfPets == 0)
                {
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
            List<string> pets = [];
            for (int i = 0; i < numOfPets; i++)
            {
                Console.WriteLine("\nWhat is your pet's name? ");
                string petName = Console.ReadLine();
                Console.WriteLine("\nWhat is your pet's ID? ");
                int petID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nWhat species is your pet? ");
                string petSpecies = Console.ReadLine().ToUpper();
                Pet pet =
                    new()
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
            List<string> humanList = [];
            while (cont == "yes")
            {
                string add = AddOrAccess();
                if (add == "add")
                {
                    Person human = new() { Name = GetName(), Age = GetAge(), };
                    List<string> pets = GetPets();

                    ShowResult(human.Name, human.Age);

                    string humanJson = JsonSerializer.Serialize(human);
                    // save it as a json array so that you can just deseriaze to a list
                    // so you will need to deserialise the whole list first, then add to it, then serialise again
                    // You also don't need to do Pets:..., as Pets can just be a property in the Person json.
                    // This will happen automatically when you make Pets a property in the Person Class
                    File.AppendAllText(
                        "C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\people.txt",
                        humanJson + "\nPets: "
                    );
                    for (int i = 0; i < pets.Count(); i++)
                    {
                        string datatemp = pets[i];
                        File.AppendAllText(
                            "C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\people.txt",
                            datatemp
                        );
                    }
                    File.AppendAllText(
                        "C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\people.txt",
                        "\n"
                    );
                    cont = ContinueOrNot();
                }
                else if (add == "access")
                {
                    /* you are just outputting the contents of the text file.
                     try outputting in a nicer, more friendlier format. eg:
                    
                    Bob Smith, 20
                    Pets:
                      - Gizmo, Dog
                      - Fred, Fish

                    Sara Wilson, 55
                    Pets: None
                    
                    
                    to do this, you'll need to deserialize.
                    */
                    // humanlist.clear
                    humanList.RemoveRange(0, humanList.Count());
                    StreamReader reader =
                        new("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\people.txt");
                    string data = reader.ReadLine();
                    while (data != null)
                    {
                        humanList.Add(data);
                        data = reader.ReadLine();
                    }
                    for (int i = 0; i < humanList.Count; i++)
                    {
                        Console.WriteLine(humanList[i]);
                    }
                    reader.Close();
                    Console.Write("\n");
                    cont = ContinueOrNot();
                }
            }
        }
    }
}
