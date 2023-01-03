using BLL.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Entities;
using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BLL.RepositoryPattern.Base_Abstract_
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyDbContext db;
        private readonly DbSet<T> table;
        public BaseRepository(MyDbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
        public async Task<T> AddAsync(T item)
        {
            await table.AddAsync(item);
            await db.SaveChangesAsync();
            return item;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteUser = await GetByIdAsync(id);
            table.Remove(deleteUser);
            await db.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> UpdateAsync(T item)
        {
            table.Update(item);
            await db.SaveChangesAsync();
            return item;
        }
    }
}
