using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GenericRepository.Abstract
{
    public interface IGenericRepository<T> where T : class, new()
    {

        List<T> List(Expression<Func<T, bool>> filter=null);


    }
}
