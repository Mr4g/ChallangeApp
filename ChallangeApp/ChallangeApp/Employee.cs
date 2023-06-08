/* 
1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek 
oraz punkty pracownika w postaci liczby całkowitych.

2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu od 1 do 10. 


3. Napisz program w kótórym wyszukasz pracownika z najwyższa liczbą ocen 
a następnie wyświetl jego dane oraz wynik. 

*/


namespace ChallangeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();   // tworzenie listy liczb zmiennoprzecinkowych


        public Employee(string name, string surname) // tworzymy konstruktor 
        {
            this.Name = name;
            this.Surname = surname;
            
        }
        public Employee(string name)
        {
            this.Name=name;
        }

        public string Name { get; private set; }  // tworzenie zmiennych z propertis
        public string Surname { get; private set; }


        public void AddGrade(float grade)   // tworzenie funkcji void, która nic nie zwraca 
        {
            //Rzutowanie to inna możliwość zamiany naszego typu zmiennych 
            int valueInInt = (int)grade;   // zamiana dokona się z float na int ale obetnie
                                           // całkowice nasze końcówki 
            int valueInInt1 = (int)Math.Ceiling(grade); // zaokręglanie do górnej warości 
            int valieInInt2 = (int)Math.Floor(grade);   // zaokrąglenie do dolnej wartoścu

            if (grade >= 0 && grade <= 100)      // podstawowa walidacja danych 
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");  // jeśli wykryjemy złe
            }                                               // dane wyśliwetlimy to na consoli
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


        public void AddGrade(string grade)   // tworzenie funkcji o tej samej nazwie
                                             // z innym parametrem
        {
            if(float.TryParse(grade, out float result))  // TryParse sprawdza czy zmienną 
            {                                            // możemy sparcować na float 
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }


        // tworzenie metody do zwracania całych obiektów 
        public Statistics GetStatistics() 
        { 
            var statistics = new Statistics();    // tworzenie nowego obiektu statistics i poniże jego wypełnienie
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades) // this. odwołuje się do obiektu w którym jesteśmy !! 
                                               // więc przejdziemy przez wszystkie oceny w tej liście 
            {                                  // która jest w tej klasie ! 
                statistics.Max = Math.Max(statistics.Max, grade);  // przy pierwszym obiegu pętli każdy "grade"
                statistics.Min = Math.Min(statistics.Min, grade);  // będzie większy niż float.MinValue 
                statistics.Average += grade;                       // ta funkcja z Math.Max będzie porównywać wartości 
                                                                   // między statistics.Max a grade i będzie przypisywać do 
                                                                   // statistic.Max maksymalną wartość !! 

            }
     
            statistics.Average /= this.grades.Count;    // dzielenie w uproszczeniu 

            return statistics;
        }
    }
}
