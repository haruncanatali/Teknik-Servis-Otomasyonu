using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IMusteriDal:IEntityRepository<Musteri>
    {
        List<Musteri> ListForMusteri(Expression<Func<Musteri, bool>> filter = null);
        Musteri GetForMusteri(Expression<Func<Musteri, bool>> filter);
    }
}
