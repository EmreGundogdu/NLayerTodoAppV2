using System.Threading.Tasks;
using TekrarProje.DataAccess.Interfaces;
using TekrarProjesi.Entities.Concrete;

namespace TekrarProje.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChanges();
    }
}
