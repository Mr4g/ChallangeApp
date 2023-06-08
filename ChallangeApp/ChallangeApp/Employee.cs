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
            this.grades.Add(grade);
            
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
