using ChallangeApp;

var employee1 = new Employee("Łukasz", "Sambor");  // tworzenie obiektu 

employee1.AddGrade("10");  // dodawanie punktów do obiektów 
employee1.AddGrade("10");
employee1.AddGrade(10);
employee1.AddGrade(10);


var statistics = employee1.GetStatisticsForeach();
var statisticsFor = employee1.GetStatisticsWithFor();           // wyciąganie modelu danych // zwracanie obiektu (referencji) // Tworzenie obiektu o nazwie statistics która zwróci na obiekcie funkcję employee1.GetStatistics
var statisticsDoWhile = employee1.GetStatisticsWithDoWhile();
var statisticsWhile = employee1.GetStatisticsWithWhile();

Console.WriteLine($"Average:  {statistics.Average:N2}");        // jeśli $ to intelopracaj jest aktywna! 
Console.WriteLine($"Min:  {statistics.Min}");                   // N2 - określenie precyzji ile miejsc po , wyświetlić
Console.WriteLine($"Max:  {statistics.Max}");

Console.WriteLine($"Average:  {statisticsFor.Average:N2}");     // jeśli $ to intelopracaj jest aktywna! 
Console.WriteLine($"Min:  {statisticsFor.Min}");                 // N2 - określenie precyzji ile miejsc po , wyświetlić
Console.WriteLine($"Max:  {statisticsFor.Max}");

Console.WriteLine($"Average:  {statisticsDoWhile.Average:N2}");     
Console.WriteLine($"Min:  {statisticsDoWhile.Min}");                
Console.WriteLine($"Max:  {statisticsDoWhile.Max}");

Console.WriteLine($"Average:  {statisticsWhile.Average:N2}");
Console.WriteLine($"Min:  {statisticsWhile.Min}");
Console.WriteLine($"Max:  {statisticsWhile.Max}");