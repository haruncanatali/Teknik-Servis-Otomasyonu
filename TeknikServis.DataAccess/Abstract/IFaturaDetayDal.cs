using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IFaturaDetayDal:IEntityRepository<FaturaDetay>
    {
        List<FaturaDetay> ListForFaturaDetay(Expression<Func<FaturaDetay, bool>> filter = null);
        FaturaDetay GetForFaturaDetay(Expression<Func<FaturaDetay, bool>> filter);
    }
}
