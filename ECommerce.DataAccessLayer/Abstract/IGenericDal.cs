using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity);
        void Remove(T entity);  //Güncelleme ve silmede async kullanılmıyor
        void Update(T entity);
    }
}
