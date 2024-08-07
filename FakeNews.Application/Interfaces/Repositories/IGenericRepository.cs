using System.Linq.Expressions;
using FakeNews.Domain.Models;

namespace FakeNews.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> GetById(Guid id);
    Task Delete(T entity);
    Task Update(T entity);
    Task Add(T entity);
    Task<IEnumerable<T>> FindWithInclude(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties);
}