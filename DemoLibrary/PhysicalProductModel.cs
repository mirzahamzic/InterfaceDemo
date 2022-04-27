﻿namespace DemoLibrary
{
    public class PhysicalProductModel : PhysicalProductBase, IProductModel
    {
        public string Title { get; set; } = string.Empty;
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {customer.FirstName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}