using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Concrete.EntityFramework
{
    public class GiderDal:EntityRepositoryBase<Gider,TeknikServisDbContext>,IGiderDal
    {
    }
}
