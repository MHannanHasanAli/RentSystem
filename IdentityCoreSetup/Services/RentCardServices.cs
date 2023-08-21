using IdentityCoreSetup.Data;
using IdentityCoreSetup.Entities;

namespace IdentityCoreSetup.Services
{
    public class RentCardServices
    {
        public List<RentCard> GetRentCards()
        {
            using (var context = new ApplicationDbContext())
            {
                var data = context.rentcards.ToList();
                data.Reverse();
                return data;
            }
        }

        public RentCard GetRentCardByCustomerId(int customerId)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.rentcards.FirstOrDefault(card => card._CustomerId == customerId);
            }
        }
        public Entities.RentCard GetRentCardById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.rentcards.Find(id);

            }
        }

        public void CreateRentCard(RentCard RentCard)
        {
            using (var context = new ApplicationDbContext())
            {
                context.rentcards.Add(RentCard);
                context.SaveChanges();
            }
        }

        public void UpdateRentCard(RentCard RentCard)
        {
            using (var context = new ApplicationDbContext())
            {
                context.rentcards.Update(RentCard);
                context.SaveChanges();
            }
        }
        public void DeleteRentCard(int id)
        {
            var data = GetRentCardById(id);

            using (var context = new ApplicationDbContext())
            {
                context.rentcards.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
