using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //By implementing IProduct model on this interface, mean we now can have 2 contracts a class needs to adhere too
    public interface IDigitalProductModel : IProductModel
    {
        //By implementing IProductModel, we are now adding more stuff to our contract that implements IDigitalProductModel and this is how it fits into the OOP Inheritence 
        int TotalDownloadsLeft { get; }
    }
}
