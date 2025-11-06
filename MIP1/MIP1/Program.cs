using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.IO;
using System.Xml.Linq;
using MIP1;
/*
 * public class Address
{
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string postalCode { get; set; }

    public Address (string street, string city, string state, string postalCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.postalCode = postalCode;
    }
    public override string ToString()
    {
        return "Street:" + street + ", City:" + city + ", State:" + state + ", Postal code:" + postalCode;
    }
}
 */



class Program
{
    static void Main()
    {
        /*
        var home = new Address(
            "123 Main St",
            "New York",
            "NY",
            "10001"
        );

     */
        /*var job = new Employee(
            "TechCorp",
            "Developer",
            5
        );
        var job1 = new Employee(
            "TechCorp",
            "Cleaner",
            13,

            );
        */
    
        /*
        var person = new Person(
            "John",          // firstName
            "Doe",           // lastName
            30,              // age
            "john.doe@example.com" // email
        );
        */
        var e1 = new Employee(
            "James",
            "Cole",
            37,
            "jamescole@gmail.com",
            "TechCorp",
            "Employee",
            7,
            2500
            );
        var m1 = new Manager(
            "Jack",
            "Randy",
            45,
            "jackrandy@gmail.com",
            "TechCorp",
            "Manager",
            15,
            3400,
            800
            );
        var m2 = new Manager(
           "Michael",
           "Kors",
           38,
           "michaelkros@gmail.com",
           "TechCorp",
           "Manager",
           12,
           3100,
           500
           );
        Director d1 = Director.GetInstance(
            "Alex",
            "Fang",
            45,
            "alexfang@gmail.com",
            "TechCorp",
            "Director",
            22,
            4500,
            1200
            );

        ArrayList PersonList = new ArrayList();
        PersonList.Add(e1);
        PersonList.Add(m1);
        PersonList.Add(m2);
        PersonList.Add(d1);
        for (int i = 0; i < PersonList.Count; i++)
        {
            Console.WriteLine(PersonList[i].ToString());
        }
        
        Console.WriteLine(e1.ToString());
        e1.Introduction();

        Console.WriteLine("\n" + m1.ToString());
        m1.Introduction();

        Console.WriteLine("\n" + m2.ToString());
        m2.Introduction();

        Console.WriteLine("\n" + d1.ToString());
        d1.Introduction();
        
        Console.WriteLine("\n\nPersonok szama: " + Person.getCounter());
        Console.WriteLine("\nManagerek szama: " + Manager.getManagerCount());
        //Console.WriteLine(job1);    
    }
}