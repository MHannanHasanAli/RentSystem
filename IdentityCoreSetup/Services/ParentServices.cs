using IdentityCoreSetup.Data;
using IdentityCoreSetup.Entities;

namespace IdentityCoreSetup.Services
{
    public class ParentServices
    {
        public List<Parents> GetParents()
        {
            using (var context = new ApplicationDbContext())
            {
                var data = context.parents.ToList();
                data.Reverse();
                return data;
            }
        }


        public Entities.Parents GetParentsById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.parents.Find(id);

            }
        }

        public void CreateParents(Parents Parents)
        {
            using (var context = new ApplicationDbContext())
            {
                context.parents.Add(Parents);
                context.SaveChanges();
            }
        }

        public void UpdateParents(Parents Parents)
        {
            using (var context = new ApplicationDbContext())
            {
                context.parents.Update(Parents);
                context.SaveChanges();
            }
        }
        public void DeleteParents(int id)
        {
            var data = GetParentsById(id);

            using (var context = new ApplicationDbContext())
            {
                context.parents.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
