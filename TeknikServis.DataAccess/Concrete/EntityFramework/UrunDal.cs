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
    public class UrunDal : EntityRepositoryBase<Urun, TeknikServisDbContext>, IUrunDal
    {
        TeknikServisDbContext context = new TeknikServisDbContext();
        public Urun GetForUrun(Expression<Func<Urun, bool>> filter)
        {
            return context.Urun.Include(c => c.UrunHareketler).Include(c=>c.Kategori).Include(c => c.UrunKabuller).Include(c => c.UrunTakipler).SingleOrDefault(filter);
        }

        public List<Urun> ListForUrun(Expression<Func<Urun, bool>> filter = null)
        {
            return filter == null ? context.Urun.Include(c => c.UrunHareketler).Include(c => c.Kategori).Include(c => c.UrunKabuller).Include(c => c.UrunTakipler).ToList() : context.Urun.Include(c => c.UrunHareketler).Include(c => c.Kategori).Include(c => c.UrunKabuller).Include(c => c.UrunTakipler).Where(filter).ToList();
        }
    }
}
