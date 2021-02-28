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
    public class FaturaBilgiDal : EntityRepositoryBase<FaturaBilgi, TeknikServisDbContext>, IFaturaBilgiDal
    {
        TeknikServisDbContext context = new TeknikServisDbContext();
        public FaturaBilgi GetForFaturaBilgi(Expression<Func<FaturaBilgi, bool>> filter)
        {
            return context.FaturaBilgi.Include(c=>c.FaturaDetaylari).Include(c=>c.Musteri).Include(c=>c.Personel).SingleOrDefault(filter);
        }

        public List<FaturaBilgi> ListForFaturaBilgi(Expression<Func<FaturaBilgi, bool>> filter = null)
        {
            return filter == null ? context.FaturaBilgi.Include(c => c.FaturaDetaylari).Include(c => c.Musteri).Include(c => c.Personel).ToList() :
                context.FaturaBilgi.Include(c => c.FaturaDetaylari).Where(filter).ToList();
        }
    }
}
