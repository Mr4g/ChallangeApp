
namespace ChallangeApp
{
    public abstract class Person        //  klasa abstrakcyjną jest dla typów ogólnych których nie da się dokładnie sprecyzować 
    {                                   // animal / mebel itp. 
                                        // nie możemy tworzyć instacji (obiektów) dla klas abstrakcyjnych jest to zabronione
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
