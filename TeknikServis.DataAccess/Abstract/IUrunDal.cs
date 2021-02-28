using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IUrunDal:IEntityRepository<Urun>
    {
        List<Urun> ListForUrun(Expression<Func<Urun, bool>> filter = null);
        Urun GetForUrun(Expression<Func<Urun, bool>> filter);
    }
}
