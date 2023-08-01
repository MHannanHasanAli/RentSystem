using IdentityCoreSetup.Constants;
using IdentityCoreSetup.Entities;
using IdentityCoreSetup.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCoreSetup.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RentController : Controller
    {
        RentServices RentServices = new RentServices();
        CustomerServices CustomerServices = new CustomerServices();
        public IActionResult Index()
        {
            return View();
        }


        public JsonResult RentIndex()
        {
            var data = RentServices.GetRents();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Create(Rent Rent)
        {
            var customer = CustomerServices.GetCustomerById(Rent._CustomerId);
            Rent._CustomerName = customer._Name;
            RentServices.CreateRent(Rent);
            return new JsonResult("Rent Added");

        }

        public JsonResult Delete(int id)
        {
            RentServices.DeleteRent(id);
            return new JsonResult("Rent Removed");
        }

        public JsonResult Edit(int id)
        {
            var data = RentServices.GetRentById(id);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(Rent Rent)
        {
            RentServices.UpdateRent(Rent);
            return new JsonResult("Record Updated");
        }
    }
}
