﻿using ChallangeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

//try
//{
//    Employee emp = null;
//    var name = emp.Surname;
//}
//catch(Exception exception)                        // jeśli chcemy wywołać wiadomość z Exception 
//{
//    Console.WriteLine(exception.Message);         // wywołanie tej wiadomości w catch ! 
//}
//finally
//{
//    Console.WriteLine("BOK WYKONA SIĘ ZAWSZE!");   // niezależnie od tego czy wystąpi exception czy nie 
//}                                                  // finally wykona się zawsze ! 

var employee = new Employee("Łukasz");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ...");
    var input = Console.ReadLine();

    if(input == "q")
    {
        break;
    }

    try                                                   // creating an exception for the AddGrade function in the while loop 
    {
        employee.AddGrade(input);
    }
    catch(Exception ex)                                  // catch Exception and write a message for exception 
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





// działająca aplikacja do oceny pracownika 
// działające testy jednostkowe wraz z sprawdzeniem liter A/B/C 
// na github ! 



