using DataAccess.Abstract;
using DataAccess.GenericRepository.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
