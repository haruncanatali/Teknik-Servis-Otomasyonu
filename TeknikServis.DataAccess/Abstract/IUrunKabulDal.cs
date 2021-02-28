using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IUrunKabulDal:IEntityRepository<UrunKabul>
    {
        List<UrunKabul> ListForUrunKabul(Expression<Func<UrunKabul, bool>> filter = null);
        UrunKabul GetForUrunKabul(Expression<Func<UrunKabul, bool>> filter);
    }
}
