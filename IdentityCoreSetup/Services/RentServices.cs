using IdentityCoreSetup.Data;
using IdentityCoreSetup.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityCoreSetup.Services
{
    public class RentServices
    {

        public List<Rent> GetRents(string SearchTerm = "")
        {
            using (var context = new ApplicationDbContext())
            {
                if (SearchTerm != "")
                {
                    return context.rents.Where(p => p._CustomerName != null && p._CustomerName.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x._CustomerName)
                                            .ToList();
                }
                else
                {
                    return context.rents.OrderBy(x => x._CustomerName).ToList();
                }
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
