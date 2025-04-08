// See https://aka.ms/new-console-template for more information


using RefreshConsoleApp;
using RefreshConsoleApp.Compisition;






//CustomerOrder();

//PersonDetails();

//HttpCookie();
// Inheritance()




static void Composition()
{
    var dbMigrator = new DbMigration(new Logger());

    
    var logger = new Logger();
    var installer = new Installer(logger);

    dbMigrator.Mygrate();
    installer.Install();
}


static void Inheritance()
{
    var text = new Text();
    text.Width = 100;
    text.Height = 100;
    text.Copy();
}


static void HttpCookie()
{
    var cookie = new HttpCookie();
    cookie["name"] = "Ange";
    Console.WriteLine(cookie["name"]);
}



static void PersonDetails()
{
    var person = new Person(new DateTime(1987, 11, 30));
    Console.WriteLine(person.Age);
}




static void CustomerOrder()
{
    var customer = new Customer(1, "customer 1");
    customer.GetOrders().Add(new Order());
    customer.GetOrders().Add(new Order());
    Console.WriteLine(customer.GetOrders().Count);
}


static void ConversionParse()
{
    // var number = int.Parse("abc"); // this will give an error
    int number;
    var result = int.TryParse("abc", out number);
    if (result)
        Console.WriteLine(number);
    else
        Console.WriteLine("Conversion failed");

}


static void UseParams()
{
    var calculator = new Calculator();
    Console.WriteLine(calculator.Add(1, 2));
    Console.WriteLine(calculator.Add(1, 2, 3));
    Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
    Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 })); // not good to create new int[] since there is params in the method already
}


static void UsePoints()
{
    try
    {
        var point = new Point(15, 3);
        point.Move(null);
        Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An unexpected error occured: ", ex);
    }
}