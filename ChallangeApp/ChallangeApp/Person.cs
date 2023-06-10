
namespace ChallangeApp
{
    public class Person   
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string surname, string age, char sex)         
        {   
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
            this.Sex = sex; 
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }

        public string Age { get; private set; }

        public char Sex { get; private set;}

    } 
}
