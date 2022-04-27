namespace DemoLibrary
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; } = string.Empty;

        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
                TotalDownloadsLeft--;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}