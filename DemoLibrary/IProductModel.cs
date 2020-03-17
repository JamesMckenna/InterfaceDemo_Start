using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IProductModel
    {
        //Everything in a Interface is public because it's a contract...so no accessors need (public, private ect..)
        //No implementation. Just declarations.
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }

        void ShipItem(CustomerModel customer);
    }
}
