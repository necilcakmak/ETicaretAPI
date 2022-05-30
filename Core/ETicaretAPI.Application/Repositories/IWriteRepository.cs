using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entites);
        bool Update(T entity);
        bool Delete(T entity);
        Task<bool> DeleteByIdAsync(string id);
        bool RemoveRange(List<T> entites);

        Task<int> SaveAsync();

    }
}
