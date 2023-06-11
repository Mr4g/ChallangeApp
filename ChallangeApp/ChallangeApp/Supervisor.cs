namespace ChallangeApp
{
    internal class Supervisor : IEmployee
    {

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Surname { get; private set; }
        public string Name { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid value");
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
            bool isPlus = grade.Contains('+');     // .Contains metoda sprawdza czy w grade znajduję się znak '+' i ustawia wartośc na true
            bool isMinus = grade.Contains('-');

            if (isPlus && isMinus)
            {
                throw new Exception("Ocena nie może zawierać znaku + i - jednocześnie");
            }

            var trimmedGrade = grade.Trim(new char[] { '+', '-', ' ' });   // var trimmedGrade (deklaracja nowej zmiennej)
            int scoreForGrade;                                                              // new char[] { '+', '-', ' ' }  to tablica znaków, która zawiera znaki '+', '-', i spacje ' '.
            switch (trimmedGrade)                                                               // Jest to argument przekazywany do metody Trim(), określający, jakie znaki mają zostać usunięte.
            {
                case "6":
                    scoreForGrade = 100;
                    break;
                case "5":
                    scoreForGrade = 80;
                    break;
                case "4":
                    scoreForGrade = 60;
                    break;
                case "3":
                    scoreForGrade = 40;
                    break;
                case "2":
                    scoreForGrade = 20;
                    break;
                case "1":
                    scoreForGrade = 0;
                    break;
                default:
                    throw new Exception("Błedna ocena. Ocena musi być w przedziale od 1 do 6");
            }

            if (isPlus == true)
            {
                scoreForGrade += 5;
            }
            else if (isMinus == true)
            {
                scoreForGrade -= 5;
            }
            grades.Add(Math.Max(0, scoreForGrade));   //Math.Max(0, scoreForGrade) zwraca większą wartość spośród 0 i scoreForGrade.
        }                                             //Jeśli scoreForGrade jest większe niż 0, to zostanie zachowane, jeśli jest mniejsze niż 0,
                                                      //zostanie zastąpione przez 0 Wynik z Math.Max zostaje dodany do listy grades za pomocą metody Add(). 
        public void AddGrade(char grade)
        {
            switch (grade)
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