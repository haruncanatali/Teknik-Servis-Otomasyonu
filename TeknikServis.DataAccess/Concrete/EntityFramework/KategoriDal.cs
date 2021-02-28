using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Concrete.EntityFramework
{
    public class KategoriDal : EntityRepositoryBase<Kategori, TeknikServisDbContext>, IKategoriDal
    {
        TeknikServisDbContext context = new TeknikServisDbContext();
        public Kategori GetForKategori(Expression<Func<Kategori, bool>> filter)
        {
            return context.Kategori.Include(c => c.Urunler).SingleOrDefault(filter);
        }

        public List<Kategori> ListForKategori(Expression<Func<Kategori, bool>> filter = null)
        {
            return filter == null ? context.Kategori.Include(c => c.Urunler).ToList() : context.Kategori.Include(c => c.Urunler).Where(filter).ToList();
        }
    }
}
