
using ChallangeApp;

/*

Tak, w nawiasie podane są parametry konstruktora klasy Employee, które określają imię, 
nazwisko i wiek pracownika. Konstruktor jest specjalną metodą, 
która jest wywoływana podczas tworzenia nowego obiektu danej klasy. 
Parametry konstruktora pozwalają na ustawienie wartości pól obiektu przy jego tworzeniu. 
To jak podanie danych osobowych przy rejestracji.

*/

Employee employee1 = new Employee("Łukasz", "Sambor", 29);    // tworzenie obiektu z odpowiednim parametrem konstruktora klasy Employee 
Employee employee2 = new Employee("Piotr", "Nowak", 22);       // konstruktor to specjalna metoda, która jest wywołana przez tworzenie nowego obiektu danej klasy
Employee employee3 = new Employee("Krzysztof", "Sałata", 33);   // Parametry konstruktora pozwalają na ustawienie wartości pól obiektu przy jego tworzeniu 

employee1.AddScore(5);     // na piechotę przydzielanie punktów 
employee1.AddScore(9);
employee1.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);
employee3.AddScore(9);
employee3.AddScore(7);
employee3.AddScore(3);

List<Employee> scoreBoard = new List<Employee>()    //tworzymy listę typie naszego obiektu ! 
{
    employee1, employee2, employee3
};





int maxResult = -1;      // zmienna przechowująca maksymalny wynik
Employee employeeWithMaxResult = null;  // kontenerek na przechowanie najlepszego pracownika 

foreach (var employee in scoreBoard)    // wyszukiwanie pracownika z najlpeszym wynikiem 
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee; 
    }
}
Console.WriteLine("Imię : " + employeeWithMaxResult.Name);
Console.WriteLine("Nazwisko : " + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek : " + employeeWithMaxResult.Age);
Console.WriteLine("Wynik : " + employeeWithMaxResult.Result);