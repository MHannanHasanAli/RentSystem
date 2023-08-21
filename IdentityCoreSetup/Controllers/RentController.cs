
using IdentityCoreSetup.Constants;
using IdentityCoreSetup.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using static IdentityCoreSetup.ViewModel.RentViewModel;

namespace ImperialNova.Controllers
{

    [Authorize]
    public class RentController : Controller
    {
        RentServices RentServices = new RentServices();
        CustomerServices CustomerServices = new CustomerServices();
        public ActionResult Index(string SearchTerm = "")
        {
            RentListingViewModel model = new RentListingViewModel();
            model.SearchTerm = SearchTerm;
            model.Rents = RentServices.GetRents(SearchTerm);
            return View("Index", model);
        }


        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            var months = new List<string>
{
    "January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December"
};
            RentActionViewModel model = new RentActionViewModel();
            model.Customer = CustomerServices.GetCustomersWithFilledRentCard();
            model.Months = months;
            if (ID != 0)
            {
                var Rent = RentServices.GetRentById(ID);
                model._Id           = Rent._Id;
                model._CustomerName = Rent._CustomerName;
                model._AmountPaid   = Rent._AmountPaid;
                model._Arrears      = Rent._Arrears;
                model._Month  = Rent._Month;
                model._Receiver = Rent._Receiver;
            }
            return View("Action", model);
        }


        [HttpPost]
        public ActionResult Action(RentActionViewModel model)
        {

            if (model._Id != 0)
            {
                var Rent = RentServices.GetRentById(model._Id);

                Rent._Id = model._Id;
                Rent._CustomerName = model._CustomerName;
                Rent._AmountPaid = model._AmountPaid;
                Rent._Arrears = model._Arrears;
                Rent._Month = model._Month;
                Rent._Receiver = model._Receiver;
                RentServices.UpdateRent(Rent);

            }
            else
            {
                var Rent = new IdentityCoreSetup.Entities.Rent();
                Rent._Id = model._Id;
                Rent._CustomerName = model._CustomerName;
                Rent._AmountPaid = model._AmountPaid;
                Rent._Arrears = model._Arrears;
                Rent._Month = model._Month;
                Rent._Receiver = model._Receiver;
                RentServices.CreateRent(Rent);
            }


            return Json(new { success = true });
        }



        [HttpGet]
        public ActionResult Delete(int ID)
        {
            RentListingViewModel model = new RentListingViewModel();
            var Rent = RentServices.GetRentById(ID);
            model._Id = Rent._Id;
            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(RentListingViewModel model)
        {
            if (model._Id != 0)
            {
                var Rent = RentServices.GetRentById(model._Id);

                RentServices.DeleteRent(Rent._Id);
            }

            return Json(new { success = true });
        }
    }
}
