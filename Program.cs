using System.Text.Json;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Greeting
{

    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set     
            {
                try
                {
                    Convert.ToInt32(name);
                    throw new FormatException();
                }
                catch (FormatException)
                {
                    throw new FormatException();
                }
                catch (Exception e)
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age > 0)
                {
                    age = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }       
        }

    }
    
    class Program
    {

        static string GetName()
        {
            bool validName = false;
            while (validName != true)
            {
                Console.WriteLine("What is your first name? ");  //Asks for first name

                string firstName = Console.ReadLine();  //Reads first name

                Console.WriteLine("\nWhat is your last name? ");   //Asks for last name

                string lastName = Console.ReadLine(); //Reads last name

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
                age = Console.ReadLine();
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

        static void ShowResult(string name, int age)
        {
            Console.WriteLine($"\nHello {name}, you are {age} years old!");
        }

        static void Main(string[] args)
        {
            Person human = new Person
            {
                Name = GetName(),
                Age = GetAge(),
            };
        ShowResult(human.Name, human.Age);

            string humanJson = JsonSerializer.Serialize(human);
            StreamWriter writer = new StreamWriter("C:\\Users\\Localadmin\\source\\repos\\Work Experience\\people.txt");
            writer.WriteLine(humanJson);    
            writer.Close();
        }

    }


    
}
