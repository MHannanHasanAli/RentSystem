using IdentityCoreSetup.Entities;
using IdentityCoreSetup.Services;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCoreSetup.Controllers
{
    public class CustomerController : Controller
    {
        CustomerServices CustomerServices = new CustomerServices();

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult CustomerIndex()
        {
            var data = CustomerServices.GetCustomers();
            return new JsonResult(data);
        }
       
        [HttpPost]
        public JsonResult Create(Customer Customer)
        {
            CustomerServices.CreateCustomer(Customer);
            return new JsonResult("Customer Added");

        }

        public JsonResult Delete(int id)
        {
            CustomerServices.DeleteCustomer(id);
            return new JsonResult("Customer Removed");
        }

        public JsonResult Edit(int id)
        {
            var data = CustomerServices.GetCustomerById(id);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(Customer Customer)
        {
            CustomerServices.UpdateCustomer(Customer);
            return new JsonResult("Record Updated");
        }
        public JsonResult UpdatethroughRent(int id, DateTime Nextdate)
        {
            var customer = CustomerServices.GetCustomerById(id);
            customer._NextDueDate = Nextdate;
            CustomerServices.UpdateCustomer(customer);
            return new JsonResult("Record Updated");
        }
    }
}
