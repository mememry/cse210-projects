using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        /*
        Create the list of customers and addresses
        */
        List<Customer> customerList = new List<Customer>();
        Customer newCustomer = new Customer("Jon Frye", "9324 Anne Avenue", "Avonlea", "PEI", "PE9805", "Canada");
        customerList.Add(newCustomer);
        newCustomer = new Customer("Brian Allestad", "98356 Ditto Street", "Clackamas", "Oregon", "97023", "USA");
        customerList.Add(newCustomer);
        newCustomer = new Customer("Kyle Noir", "123 Washougal Street", "Washougal", "Washington", "98125", "US");
        customerList.Add(newCustomer);
        newCustomer = new Customer("Craig Shelley", "145 Rio de los Angeles", "Trujillo", "La Libertad", "LAF987", "Peru");
        customerList.Add(newCustomer);

        /*
        Create the list of products
        */

        List<Product> productList = new List<Product>();
        Product newProduct = new Product("A", "Vanilla Planifolia, Miniature Vanllia Orchid Mounted on Cypress Board", 19.69);
        productList.Add(newProduct);
        newProduct = new Product("B", "The Greatest Showman Soundtrack", 11.51);
        productList.Add(newProduct);
        newProduct = new Product("C", "anezus 20 Gauge Jewelry Wire, 28 Yards Craft Wire Tarnish Resistant Copper Beading Wire for Jewelry Making Supplies and Crafting(Black)", 11.99);
        productList.Add(newProduct);
        newProduct = new Product("D", "Ready or Not: A Disaster Survival Handbook", 14.99);
        productList.Add(newProduct);
        newProduct = new Product("E", "Kitchen Garden Revival: A modern guide to creating a stylish, small-scale, low-maintenance, edible garden", 17.25);
        productList.Add(newProduct);
        newProduct = new Product("F", "Treasure Gurus Miniature Bag Pipe Musical Instrument Realistic Ornament", 18.48);
        productList.Add(newProduct);
        newProduct = new Product("G", "Frontier Bulk Sarsaparilla Root, Indian C/S, 1 Pound", 24.50);
        productList.Add(newProduct);
        newProduct = new Product("H", "Spirograph Die-cast Collector’s Set, Multi, 14 piece (1021RZ)", 27.82);
        productList.Add(newProduct);
        newProduct = new Product("I", "REEBOW GEAR Military Tactical Backpack Large Army 3 Day Assault Pack Molle Bag Backpacks (Woodland Camo)", 35.99);
        productList.Add(newProduct);
        newProduct = new Product("J", "MANO Steamer Pot for Cooking 11 inch Steam Pots with Lid 2-tier Multipurpose Stainless Steel Steaming Pot Cookware with Handle for Vegetable, Dumpling, Stock, Sauce, Food", 37.98);
        productList.Add(newProduct);
        newProduct = new Product("K", "Zip Top Reusable Food Storage Bags | 3 Dish Set [Lavender] | Silicone Meal Prep Container | Microwave, Dishwasher and Freezer Safe | Made in the USA", 54.95);
        productList.Add(newProduct);
        newProduct = new Product("L", "MQ 10 inch Moon Pendant Lamp with Remote Control, 3000K-6500K Brightness Adjustable, 3D Printing Ceiling Light for Home, Office, Bars and Cafe, 12W E26 LED Bulb Included", 79.99);
        productList.Add(newProduct);
        newProduct = new Product("M", "Drain Sticks Drain Stix DrainStix Drain Cleaner Sticks Drain Cleaner and Sticks Disposal Sticks Enzyme for Odor Clogs Remover Sink Septic Sticks for Drain As Seen On TV", 8.99);
        productList.Add(newProduct);
        newProduct = new Product("N", "The Wolf in Me", 9.99);
        productList.Add(newProduct);

        /* 
        Create at least two orders with 2 - 3 products per order 
        Create the order by selecting a customer and then selecting between 2 and 3 items
        */
        List<PurchaseOrder> orderList = new List<PurchaseOrder>();

        Random random = new Random();
        int randomCustomer = random.Next(0, 4);
        int numberItems = random.Next(2,4);
        int randomItem = 0;
        Customer thisCustomer = customerList[randomCustomer];
        
        Product thisProduct = new Product();
        int orderQuantity = 0;
        for (int counter = 0; counter < numberItems; counter++)
        {
            orderQuantity = random.Next(0, 21);
            randomItem = random.Next(0, 15);
            thisProduct = productList[randomItem];
            orderList[0].AddToOrder(thisProduct, orderQuantity);
        }
        
        Customer thisCustomer = customerList[randomCustomer];

        Product thisProduct = new Product();
        int orderQuantity = 0;
        for (int counter = 0; counter < numberItems; counter++)
        {
            orderQuantity = random.Next(0, 21);
            randomItem = random.Next(0, 15);
            thisProduct = productList[randomItem];
            orderList[0].AddToOrder(thisProduct, orderQuantity);
        }

        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}