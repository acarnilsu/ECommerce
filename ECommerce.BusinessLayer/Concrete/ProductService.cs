using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(IGenericDal<Product> genericDal, IUnitOfWork unitOfWork) : base(genericDal, unitOfWork)
        {
        }
    }
}
