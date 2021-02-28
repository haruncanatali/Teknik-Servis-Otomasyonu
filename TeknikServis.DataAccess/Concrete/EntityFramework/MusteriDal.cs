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
    public class MusteriDal : EntityRepositoryBase<Musteri, TeknikServisDbContext>, IMusteriDal
    {
        TeknikServisDbContext context = new TeknikServisDbContext();
        public Musteri GetForMusteri(Expression<Func<Musteri, bool>> filter)
        {
            return context.Musteri.Include(c => c.FaturaBilgiler).Include(c => c.UrunHareketler).Include(c => c.UrunKabuller).SingleOrDefault(filter);
        }

        public List<Musteri> ListForMusteri(Expression<Func<Musteri, bool>> filter = null)
        {
            return filter == null ? context.Musteri.Include(c => c.FaturaBilgiler).Include(c => c.UrunHareketler).Include(c => c.UrunKabuller).ToList() : context.Musteri.Include(c => c.FaturaBilgiler).Include(c => c.UrunHareketler).Include(c => c.UrunKabuller).Where(filter).ToList();
        }
    }
}
