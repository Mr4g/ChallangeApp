

namespace ChallangeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();   

        public Employee(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;

        }
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }  
        public string Surname { get; private set; }


        public void AddGrade(float grade)   
        {
            if (grade >= 0 && grade <= 100)     
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");  
            }                                               
        }

        public void AddGrade(int grade)
        {
            float intGrade = grade;
            this.grades.Add(intGrade);
        }

        public void AddGrade(double grade)
        {
            float doubleGrade = (float)grade;
            this.grades.Add(doubleGrade);
        }

        public void AddGrade(long grade)
        {
            float longGrade = (float)grade;
            this.grades.Add(longGrade);
        }


        public void AddGrade(string grade)                                              
        {
            if (float.TryParse(grade, out float result))  
            {                                            
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
 
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();    
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {

                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;    
            return statistics;
        }
    }
}
