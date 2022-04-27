// See https://aka.ms/new-console-template for more information

using DemoLibrary;

List<IProductModel> cart = AddSampleData();
CustomerModel customer = GetCustomer();

foreach (IProductModel prod in cart)
{
    prod.ShipItem(customer);

    if (prod is IDigitalProductModel digital)
    {
        Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
    }
}

static CustomerModel GetCustomer()
{
    return new CustomerModel
    {
        FirstName = "Time",
        LastName = "Corey",
        City = "Scranton",
        EmailAddress = "tim@tim.ba",
        PhoneNumber = "555-12345"
    };
}

static List<IProductModel> AddSampleData()
{
    List<IProductModel> output = new List<IProductModel>();

    output.Add(new PhysicalProductModel { Title = "Nerf Football" });
    output.Add(new PhysicalProductModel { Title = "Shirt" });
    output.Add(new PhysicalProductModel { Title = "Hard Drive" });
    output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
    output.Add(new CourseProductModel { Title = "Net Core Start" });

    return output;
}