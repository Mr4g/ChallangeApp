using ChallangeApp;

var employee1 = new Employee("Łukasz", "Sambor");  // tworzenie obiektu 

employee1.AddGrade("Łukasz");  // dodawanie punktów do obiektów 
employee1.AddGrade("2000");
employee1.AddGrade(2);
employee1.AddGrade(6);

var statistics = employee1.GetStatistics(); // wyciąganie modelu danych // zwracanie obiektu (referencji) // Tworzenie obiektu o nazwie statistics która zwróci na obiekcie funkcję employee1.GetStatistics


Console.WriteLine($"Average:  {statistics.Average:N2}");  // jeśli $ to intelopracaj jest aktywna! 
Console.WriteLine($"Min:  {statistics.Min}");             // N2 - określenie precyzji ile miejsc po , wyświetlić
Console.WriteLine($"Max:  {statistics.Max}");

