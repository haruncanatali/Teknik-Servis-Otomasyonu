using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IPersonelDal:IEntityRepository<Personel>
    {
        List<Personel> ListForPersonel(Expression<Func<Personel, bool>> filter = null);
        Personel GetForPersonel(Expression<Func<Personel, bool>> filter);
    }
}
