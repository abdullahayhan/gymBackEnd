using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T item);
        Task<T> UpdateAsync(T item);
        Task DeleteAsync(int id);
    }
}
