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

        public static int theBestScore;


        public Employee(string name, string surname, int age) // tworzymy konstruktor 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public Employee(string name)
        {
            this.Name=name;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set;}
        
        private List<int> Score = new List<int>();   // tworzenie listy liczb całkowitych 

        
        public int Result 
        {
            get
            {
                return this.Score.Sum();
            }
        }

        public void AddScore(int points)
        {
            this.Score.Add(points);
            
        }
        


    }
}
