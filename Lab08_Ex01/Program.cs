using System;

class Program
{
    static void Main()
    {
        Person p = new Person();
        System.Console.WriteLine($"Type of p is {p.GetType()}");
    }
}

class Person
{
    // อาจมี properties หรือ methods ที่เกี่ยวข้อง
}
