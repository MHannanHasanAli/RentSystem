using IdentityCoreSetup.Constants;
using IdentityCoreSetup.Data;
using IdentityCoreSetup.Entities;
using IdentityCoreSetup.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCoreSetup.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        CustomerServices CustomerServices = new CustomerServices();
        ParentServices ParentServices = new ParentServices();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerForm()
        {
            return View();
        }


        //public JsonResult Deadlines()
        //{
        //    List<Customer> DeadlineCustomers = new List<Customer>();
        //    var customers = CustomerServices.GetCustomers();
        //    var todayDate = DateTime.Today;


        //foreach (var customer in customers)
        //{
        //    if (customer._TypeOfRent == "annually")
        //    {
        //        var givenDate = customer._NextDueDate;

        //        var daysDifference = (givenDate.Date - todayDate).Days;

        //        if (daysDifference <= 90 && daysDifference >= 0)
        //        {
        //            DeadlineCustomers.Add(customer);

        //        }
        //    }
        //    else
        //    {
        //        var givenDate = customer._NextDueDate;

        //        var daysDifference = (givenDate.Date - todayDate).Days;

        //        if (daysDifference <= 5 && daysDifference >= 0)
        //        {
        //            DeadlineCustomers.Add(customer);

        //        }
        //    }
        //}


        //    return new JsonResult(DeadlineCustomers);

        //}
        //public JsonResult Defaulter()
        //{
        //    List<Customer> DefaultCustomers = new List<Customer>();
        //    var customers = CustomerServices.GetCustomers();
        //    var todayDate = DateTime.Today;


        //    foreach (var customer in customers)
        //    {
        //        var givenDate = customer._NextDueDate;               

        //        if (todayDate > givenDate)
        //        {
        //            DefaultCustomers.Add(customer) ;
        //        }
        //    }


        //    return new JsonResult(DefaultCustomers);

        //}
        static int customerid;
        public JsonResult CustomerIndex()
        {
            var data = CustomerServices.GetCustomers();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult CreateParents(Parents Parents)
        {
            if (ModelState.IsValid)
            {
                Parents._CustomerId = customerid;
                ParentServices.CreateParents(Parents);
                customerid = 0;
                return new JsonResult("Customer Added");
            }
            else
            {
                var errorMessage = ModelState.Values.SelectMany(v => v.Errors)
                           .Select(e => e.ErrorMessage)
                           .FirstOrDefault();

                return new JsonResult("Customer not Added: " + errorMessage);
            }

        }
        [HttpPost]
        public JsonResult Create(Customer customer)
        {
            customer._RentCard = "Not Filled";
                using (var context = new ApplicationDbContext())
                {
                    context.customers.Add(customer);
                    context.SaveChanges();
                }
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
        [HttpGet]
        public JsonResult CardStatus(int id)
        {
            var data = CustomerServices.GetStatus(id);
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
            //customer._NextDueDate = Nextdate;
            CustomerServices.UpdateCustomer(customer);
            return new JsonResult("Record Updated");
        }
    }
}
