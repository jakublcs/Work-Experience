using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;
using System.Text.Json;
using static ClassLibrary.Class1;
using static ClassLibrary.Class1.Methods;

namespace FormsProj
{
    public partial class Form1 : Form
    {
        public string realName = "";
        public int realAge = 0;
        public int numOfPets = 0;
        public int index = 0;
        public List<Pet> pet1 = [];
        public List<String> pets = [];
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            realName = "";
            string data = textBox1.Text;
            string name = ValidateName(data);
            if (name != "false")
            {
                textBox1.ReadOnly = true;
                button1.Enabled = false;
                realName = textBox1.Text;
            }
            else
            {
                label5.Show();
                MessageBox.Show("Real name please.");
                textBox1.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            realAge = 0;
            bool invalidAge = true;
            while (invalidAge)
            {
                string age;
                age = textBox2.Text;
                char[] numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (age[0] == numbers[i])
                    {
                        invalidAge = false;
                        int ageInt = Convert.ToInt32(age);
                        realAge = ageInt;
                        age = "";
                        textBox2.ReadOnly = true;
                        button2.Enabled = false;
                        break;
                    }
                    else
                    {
                        if (i + 1 == numbers.Length)
                        {
                            if (age != "")
                            {
                                invalidAge = false;
                                label6.Show();
                                MessageBox.Show("Real age please.");
                                textBox2.Text = null;
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool invalidNum = true;
            while (invalidNum)
            {
                string number;
                number = textBox3.Text;
                char[] numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (number[0] == numbers[i])
                    {
                        invalidNum = false;
                        int num = Convert.ToInt32(number);
                        numOfPets = num;
                        number = "";
                        textBox3.ReadOnly = true;
                        button3.Enabled = false;
                        break;
                    }
                    else
                    {
                        if (i + 1 == numbers.Length)
                        {
                            if (number != "")
                            {
                                invalidNum = false;
                                label7.Show();
                                MessageBox.Show("Real number please.");
                                textBox3.Text = null;
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            if (numOfPets > 0)
            {
                label4.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                button4.Show();
            }
            else
            {
                var human = new Person("", 0)
                {
                    Age = realAge,
                    Name = realName,
                    Pets = pets,
                };
                string humanJson = JsonSerializer.Serialize<Person>(human, new JsonSerializerOptions()
                {
                    WriteIndented = true
                });
                string tempdata = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json");
                if (tempdata == "")
                {
                    File.AppendAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json", "[" + humanJson + "]");
                }
                else
                {
                    string newdata = tempdata.Remove(tempdata.Length - 1, 1);
                    newdata = newdata + "," + humanJson + "]";
                    File.WriteAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json", newdata);
                }
                button5.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var pet = new Pet();
            pet.Path = "C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json";
            if (numOfPets < 2)
            {
                pet.Name = textBox4.Text;
                pet.Species = textBox5.Text;
                pet.Id = Convert.ToInt32(textBox6.Text);
                if (pet.Name == textBox4.Text && pet.Species == textBox5.Text && pet.Id == Convert.ToInt32(textBox6.Text))
                {
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    button4.Enabled = false;
                    pets.Add(JsonSerializer.Serialize(pet, new JsonSerializerOptions() { WriteIndented = true }));
                    var human = new Person("", 0)
                    {
                        Age = realAge,
                        Name = realName,
                        Pets = pets,
                    };
                    string humanJson = JsonSerializer.Serialize<Person>(human, new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    });
                    string tempdata = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json");
                    if (tempdata == "")
                    {
                        File.AppendAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json", "[" + humanJson + "]");
                        pets = [];
                    }
                    else
                    {
                        string newdata = tempdata.Remove(tempdata.Length - 1, 1);
                        newdata = newdata + "," + humanJson + "]";
                        File.WriteAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json", newdata);
                        pets = [];
                    }
                    button5.Show();
                }
                else
                {
                    MessageBox.Show("Enter valid details please.");
                }
            }
            else
            {
                pet.Name = textBox4.Text;
                pet.Species = textBox5.Text;
                pet.Id = Convert.ToInt32(textBox6.Text);
                if (pet.Name == textBox4.Text && pet.Species == textBox5.Text && pet.Id == Convert.ToInt32(textBox6.Text))
                {
                    numOfPets--;
                    textBox6.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    pets.Add(JsonSerializer.Serialize(pet, new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    }));
                }
                else
                {
                    MessageBox.Show("Enter valid details please.");
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            richTextBox1.Hide();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            label4.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            button4.Hide();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label1.Show();
            label2.Show();
            label3.Show();
            button5.Hide();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pet1.Clear() ;
            button6.Hide();
            index = 0;
            string text = "";
            richTextBox1.Show();
            button7.Show();
            button8.Show();
            var personJson = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json");
            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(personJson);
            for (int i = 0; i < persons[index].Pets.Count; i++)
            {
                var pet2 = JsonSerializer.Deserialize<Pet>(persons[index].Pets[i]);
                pet1.Add(pet2);

            }
                text = $"Name: {persons[index].Name}\nAge: {persons[index].Age}\nPets:\n";
                for (int i = 0; i < pet1.Count; i++)
                {
                    text = text + "\tName: " + pet1[i].Name + "\n\t Species: " + pet1[i].Species + "\n\t ID: " + pet1[i].Id + "\n\n";
                }
                richTextBox1.Text = text;
                text = "";
                pet1 = [];
        }
        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.Show();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pet1.Clear();
            var personJson = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json");
            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(personJson);
            index+=1;
            string text = "";
            richTextBox1.Show();
            button7.Show();
            button8.Show();
            for (int i = 0; i < persons[index].Pets.Count; i++)
            {
                var pet2 = JsonSerializer.Deserialize<Pet>(persons[index].Pets[i]);
                pet1.Add(pet2);

            }
            string name = persons[index].Name;
            text = $"Name: {persons[index].Name}\nAge: {persons[index].Age}\nPets:\n";
            for (int i = 0; i < pet1.Count; i++)
            {
                text = text + "\tName: " + pet1[i].Name + "\n\t Species: " + pet1[i].Species + "\n\t ID: " + pet1[i].Id + "\n\n";
            }
            richTextBox1.Text = text;
            text = "";
            pet1 = [];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pet1.Clear();
            index-=1;
            string text = "";
            richTextBox1.Show();
            button7.Show();
            button8.Show();
            var personJson = File.ReadAllText("C:\\Users\\Localadmin\\source\\repos\\WorkExperience\\WinFormsApp\\people.json");
            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(personJson);
            for (int i = 0; i < persons[index].Pets.Count; i++)
            {
                var pet2 = JsonSerializer.Deserialize<Pet>(persons[index].Pets[i]);
                pet1.Add(pet2);

            }
            text = $"Name: {persons[index].Name}\nAge: {persons[index].Age}\nPets:\n";
            for (int i = 0; i < pet1.Count; i++)
            {
                text = text + "\tName: " + pet1[i].Name + "\n\t Species: " + pet1[i].Species + "\n\t ID: " + pet1[i].Id + "\n\n";
            }
            richTextBox1.Text = text;
            text = "";
            pet1 = [];
        }
    }
}
