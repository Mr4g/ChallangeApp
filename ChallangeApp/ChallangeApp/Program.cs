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

var sup = new EmployeeInFile("Łukasz", "Sambor");
sup.GradeAdded += SupGradeAdded;                              
                                                           
                                                               
void SupGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano punkt"); 
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ...");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try                                                   
    {
        sup.AddGrade(input);
    }
    catch (Exception ex)                                
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}
var statistics = sup.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
