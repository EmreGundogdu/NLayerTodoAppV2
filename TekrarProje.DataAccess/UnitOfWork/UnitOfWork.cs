using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarProje.DataAccess.Context;
using TekrarProje.DataAccess.Interfaces;
using TekrarProje.DataAccess.Repositories;
using TekrarProjesi.Entities.Concrete;

namespace TekrarProje.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ReTodoContext _context;

        public UnitOfWork(ReTodoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
