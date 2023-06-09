using ChallangeApp;

var employee1 = new Employee("Łukasz", "Sambor"); 
employee1.AddGrade("10");  
employee1.AddGrade("10");
employee1.AddGrade(10);
employee1.AddGrade(10);


var statistics = employee1.GetStatistics();


Console.WriteLine($"Average:  {statistics.Average:N2}");        
Console.WriteLine($"Min:  {statistics.Min}");                   
Console.WriteLine($"Max:  {statistics.Max}");

