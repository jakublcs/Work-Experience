using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using static ClassLibrary.Class1;

namespace ClassLibrary
{
    public class Class1
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
            private string path = "C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\ConsoleApp\\people.json";
            private string name;
            private string species;
            private int id;
            public string Path
            {
                get; set;
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
                    else
                    {
                        id = value;
                    }
                }
            }
        }

        public abstract class Methods()
        {
            public static string ValidateName(string fullName)
            {
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
                        continue;
                    }
                }
                return "false";
            }
        }
    }
}
