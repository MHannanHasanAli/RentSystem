using IdentityCoreSetup.Data;
using IdentityCoreSetup.Entities;

namespace IdentityCoreSetup.Services
{
    public class CustomerServices
    {
        
        //public List<string> GetCustomerNames()
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        var data = context.customers.Select(c => c._Name).ToList();
        //        data.Reverse();
        //        return data;
        //    }
        //}
        public List<Customer> GetCustomers()
        {
            using (var context = new ApplicationDbContext())
            {
                var data = context.customers.ToList();
                data.Reverse();
                return data;
            }
        }


        public Entities.Customer GetCustomerById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.customers.Find(id);

            }
        }

        public void CreateCustomer(Customer Customer)
        {
            using (var context = new ApplicationDbContext())
            {
                context.customers.Add(Customer);
                context.SaveChanges();
            }
        }

        public void UpdateCustomer(Customer Customer)
        {
            using (var context = new ApplicationDbContext())
            {
                context.customers.Update(Customer);
                context.SaveChanges();
            }
        }
        public void DeleteCustomer(int id)
        {
            var data = GetCustomerById(id);

            using (var context = new ApplicationDbContext())
            {
                context.customers.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
