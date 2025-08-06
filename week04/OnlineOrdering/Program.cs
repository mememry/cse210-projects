using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Create the list of customers and addresses
        */
        Customer newCustomer;

        newCustomer.CreateCustomer("Jon", "spring street", "MyTown", "WA", "98571", "USA");
        Console.WriteLine(newCustomer);
        

        /*
        Create the list of products
        */

        /* 
        Create at least two orders with 2 - 3 products per order 
        */

        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}