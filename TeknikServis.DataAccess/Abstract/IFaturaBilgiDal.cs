using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IFaturaBilgiDal:IEntityRepository<FaturaBilgi>
    {
        List<FaturaBilgi> ListForFaturaBilgi(Expression<Func<FaturaBilgi, bool>> filter = null);
        FaturaBilgi GetForFaturaBilgi(Expression<Func<FaturaBilgi, bool>> filter);
    }
}
