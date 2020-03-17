using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        /*
         An interface is a contract. Whatever class that implements the contract here's a thing that it will have
        */
        static void Main(string[] args)
        {
            //List<PhysicalProductModel> cart = AddSampleData();
            //Because we are using IProductModel Interface, we can now put more tha 1 type into the List<T>
            //List<IProductModel> cart = AddSampleData();
            //Also need to change AddSampleData method signature to accept an IProductModel rather then a PhysicalProductModel
            List<IProductModel> cart = AddSampleData();

            CustomerModel customer = GetCustomer();

            //foreach (PhysicalProductModel prod in cart)
            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                //By IDigitalProductModel implementing IProductModel, Whenever using IProductModel, we have access to whatever is in IDigitalProductModel
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        //Need to change method signature because we are now under contract to use an Interface
        //private static List<PhysicalProductModel> AddSampleData()
        private static List<IProductModel> AddSampleData()
        {
            //List<PhysicalProductModel> output = new List<PhysicalProductModel>();
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            //we can now add a digital product to our cart without needing to create another class!!!!!! In this case, a better way than using Inheritence from a base class
            //but it still fits into Inheritence 
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            //So without changing any of our code, business logic, we can add another type/class of Product to our app. Implement the proper interface/s and off we go.
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish" });

            return output;
        }
    }
}
