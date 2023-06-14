
namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);     // metoda abstrakcyjna oznacza, że dopiero klasa która będzie dziedziczyć klasę bazową 
                                                        // będzie musiała mieć zdefiniowaną to metodę jak ona będzie się zachowywać ! 
        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
 
    }
}
