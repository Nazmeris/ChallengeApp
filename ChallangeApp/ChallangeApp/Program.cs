﻿using ChallangeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

Console.WriteLine("System Ocen:");
Console.WriteLine("Ocena od 0-100 oraz A=100, B=80, C=60, D=40, E=20");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika, żeby zakończyć wciśnij q:");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avarge: {statistics.Avarge}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvargeLatter {statistics.AvargeLatter}");

