using DataAccess.GenericRepository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GenericRepository.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class,new()
    {
    

 
     
        public List<T> List(Expression<Func<T, bool>> filter=null)
        {
            using (var context = new ReaContext())
            {

                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

   
    }
}
