using System;
using System.Linq;
using System.Collections.Generic;

#pragma warning disable

internal static class Application
{
    private static void Main()
    {
        Student[] students = new Student[4];

        for (int iterator = 0; iterator < students.Length; iterator++)
            students[iterator] = new Student().MakeStudent();

        students.Where(student => student.Age > 18).ForEach();
    }

    private static void ForEach(this IEnumerable<IPrintable> sources)
    {
        foreach (IPrintable source in sources)
            source.Print();
    }
}

internal class Student : IPrintable
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public string Group { get; private set; }

    public Student MakeStudent()
    {
        Student student = new Student();

        Console.WriteLine("Заполни информацию о студенте: ");
        Console.Write("Введите имя: ");
        FirstName = Console.ReadLine() ?? string.Empty;

        Console.Write("Введите фамилию: ");
        LastName = Console.ReadLine() ?? string.Empty;

        Console.Write("Введите возраст: ");
        if (int.TryParse(Console.ReadLine() ?? string.Empty, out int result))
            Age = result;

        Console.Write("Введите группу: ");
        Group = Console.ReadLine() ?? string.Empty;

        return student;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {FirstName}");
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Группа: {Group}");
    }
}

public interface IPrintable
{
    void Print();
}
