using IdentityCoreSetup.Data;
using IdentityCoreSetup.Entities;

namespace IdentityCoreSetup.Services
{
    public class RentServices
    {
       
        public List<Rent> GetRents()
        {
            using (var context = new ApplicationDbContext())
            {
                var data = context.rents.ToList();
                data.Reverse();
                return data;
            }
        }


        public Entities.Rent GetRentById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.rents.Find(id);

            }
        }

        public void CreateRent(Rent Rent)
        {
            using (var context = new ApplicationDbContext())
            {
                context.rents.Add(Rent);
                context.SaveChanges();
            }
        }

        public void UpdateRent(Rent Rent)
        {
            using (var context = new ApplicationDbContext())
            {
                context.rents.Update(Rent);
                context.SaveChanges();
            }
        }
        public void DeleteRent(int id)
        {
            var data = GetRentById(id);

            using (var context = new ApplicationDbContext())
            {
                context.rents.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
