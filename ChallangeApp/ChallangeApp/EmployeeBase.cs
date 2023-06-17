
namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public virtual void AddGrade(float grade)     // metoda abstrakcyjna oznacza, że dopiero klasa która będzie dziedziczyć klasę bazową 
        {
            if (GradeAdded != null)      // czy ktokolowiek na ten event jest podpięty 
            {
                GradeAdded(this, new EventArgs());    // wywołanie evnetu ( this. - senderem jesteśmy my więc jest this.)
            }
        }                                        // będzie musiała mieć zdefiniowaną to metodę jak ona będzie się zachowywać ! 
        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
 
    }
}
