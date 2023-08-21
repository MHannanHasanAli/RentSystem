using IdentityCoreSetup.Entities;
using IdentityCoreSetup.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCoreSetup.Controllers
{
    [Authorize]

    public class RentCardController : Controller
    {
        RentCardServices rentCardServices = new RentCardServices();
        CustomerServices CustomerServices = new CustomerServices();
        RentCardServices RentCardServices = new RentCardServices();
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult CreateRentCard(RentCard RentCard)
        {
            var customer = CustomerServices.GetCustomerById(RentCard._CustomerId);
            customer._RentCard = "Filled";
            CustomerServices.UpdateCustomer(customer);
            rentCardServices.CreateRentCard(RentCard);
            return new JsonResult("Added");

        }
        public JsonResult Edit(int id)
        {
            var data = RentCardServices.GetRentCardByCustomerId(id);
            return new JsonResult(data);
        }
        public JsonResult Update(Customer Customer)
        {
            Customer._RentCard = "Filled";
            CustomerServices.UpdateCustomer(Customer);
            return new JsonResult("Record Updated");
        }
    }
}
