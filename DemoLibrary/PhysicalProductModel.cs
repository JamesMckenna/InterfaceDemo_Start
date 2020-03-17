using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //public class PhysicalProductModel : IProductModel, PhysicalProductBase
    //the above is incorrect because the first thing after the semi-colon is what we are inheriting from 
    //This would be correct is needed: public class PhysicalProductModel : PhysicalProductBase, IProductModel AND we can **IMPLEMENT** many interfaces, but only 1 class
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
