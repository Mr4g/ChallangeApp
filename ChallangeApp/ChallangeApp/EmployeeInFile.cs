using System.IO.Enumeration;

namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> grades = new List<float>();

        private const string fileName = "grades.txt";                 // przechowujemy nazwę pliku // dlatego const
        
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)                   // metoda do dodawania punktów do pliku 
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)      // czy ktokolowiek na ten event jest podpięty 
                {
                    GradeAdded(this, new EventArgs());    // wywołanie evnetu ( this. - senderem jesteśmy my więc jest this.)
                }
            }
        }

        public override void AddGrade(int grade)
        {
            float intGrade = grade;
            this.AddGrade(intGrade);
        }

        public override void AddGrade(double grade)
        {
            float doubleGrade = (float)grade;
            this.AddGrade(doubleGrade);
        }

        public override void AddGrade(long grade)
        {
            float longGrade = (float)grade;
            this.AddGrade(longGrade);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");   // rzucanie (throw) Exception in feature AddGrade 
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Latter");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }



        private Statistics CountStatistics(List<float> grades)
        {
            {
                var statistics = new Statistics();
                
                foreach (var grade in grades)
                {
                    statistics.AddGrade(grade);
                }

                return statistics;
            }
        }
    }
}
