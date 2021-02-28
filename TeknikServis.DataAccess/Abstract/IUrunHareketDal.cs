using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IUrunHareketDal:IEntityRepository<UrunHareket>
    {
        List<UrunHareket> ListForUrunHareketler(Expression<Func<UrunHareket, bool>> filter = null);
        UrunHareket GetForUrunHareket(Expression<Func<UrunHareket, bool>> filter);
    }
}
