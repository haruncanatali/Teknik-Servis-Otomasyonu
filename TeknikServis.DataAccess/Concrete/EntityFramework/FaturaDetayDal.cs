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
    public class FaturaDetayDal : EntityRepositoryBase<FaturaDetay, TeknikServisDbContext>, IFaturaDetayDal
    {
        public FaturaDetay GetForFaturaDetay(Expression<Func<FaturaDetay, bool>> filter)
        {
            using (TeknikServisDbContext context = new TeknikServisDbContext())
            {
                return context.FaturaDetay.Include(c => c.Fatura).FirstOrDefault(filter);
            }
        }

        public List<FaturaDetay> ListForFaturaDetay(Expression<Func<FaturaDetay, bool>> filter = null)
        {
            using (TeknikServisDbContext context = new TeknikServisDbContext())
            {
                return filter == null ? context.FaturaDetay.Include(c => c.Fatura).ToList() : context.FaturaDetay.Include(c => c.Fatura).Where(filter).ToList();
            }
        }
    }
}
