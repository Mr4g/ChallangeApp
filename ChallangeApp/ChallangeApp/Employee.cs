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
                throw new Exception("Invalid grade value");   
            }                                               
        }

        public void AddGrade(int grade)
        {
             float intGrade = grade;
             this.AddGrade(intGrade);        
        }
        public void AddGrade(double grade)
        {
            float doubleGrade = (float)grade;
            this.AddGrade(doubleGrade);
        }

        public void AddGrade(long grade)
        {
            float longGrade = (float)grade;
            this.AddGrade(longGrade);
        }


        public void AddGrade(string grade)                                              
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
        public void AddGrade(char grade)   
        {
            switch(grade)     
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;    
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Latter");                
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

            switch (statistics.Average)
            {
                case var average when average >= 80:    // jeżeli ta wartość która przychodzi 
                    statistics.AverageLetter = 'A';     // statistics.Average jest >= 80 to
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
