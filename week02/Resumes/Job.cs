using System;

public class Job
{
    public string _company;
    public string _title;
    public int _start;
    public int _end;


    public void DisplayJob()
    {
        Console.Write($"{_title}    ");
        Console.Write($"({_company})     ");
        Console.Write($"{_start}-");
        Console.WriteLine(_end);
    }

}