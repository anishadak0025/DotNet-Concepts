using System;

public delegate void MyDelegate();

class Student
{
    public void Study()
    {
        Console.WriteLine("Student is studying");
    }

    public void Sleep()
    {
        Console.WriteLine("Student is sleeping");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        MyDelegate activity;

        activity = s.Study;

        activity += s.Sleep;

        activity();
    }
}
