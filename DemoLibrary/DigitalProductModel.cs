using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //public class DigitalProductModel : IProductModel, IDigitalProductModel
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        //Changed signature from what's in the interface. Thats okay because the get is still public. Internally, it's a private setter.
        //Interfaces don't lock you into what's only in the contract, just the minimum required to satisfy the contract
        public bool HasOrderBeenCompleted { get; private set; }

        //Not in the contract and not common across all items in cart.....
        public int TotalDownloadsLeft { get; private set; } = 5;
        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if(TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
