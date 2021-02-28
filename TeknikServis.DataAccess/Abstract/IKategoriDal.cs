using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IKategoriDal:IEntityRepository<Kategori>
    {
        List<Kategori> ListForKategori(Expression<Func<Kategori, bool>> filter = null);
        Kategori GetForKategori(Expression<Func<Kategori, bool>> filter);
    }
}
