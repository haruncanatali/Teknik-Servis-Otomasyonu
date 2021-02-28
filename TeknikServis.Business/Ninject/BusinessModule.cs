using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Business.Concrete;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.DataAccess.Concrete.EntityFramework;

namespace TeknikServis.Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdminService>().To<AdminManager>().InTransientScope();
            Bind<IAdminDal>().To<AdminDal>().InTransientScope();

            Bind<IArizaDetayService>().To<ArizaDetayManager>().InTransientScope();
            Bind<IArizaDetayDal>().To<ArizaDetayDal>().InTransientScope();

            Bind<IDepartmanService>().To<DepartmanManager>().InTransientScope();
            Bind<IDepartmanDal>().To<DepartmanDal>().InTransientScope();

            Bind<IFaturaBilgiService>().To<FaturaBilgiManager>().InTransientScope();
            Bind<IFaturaBilgiDal>().To<FaturaBilgiDal>().InTransientScope();

            Bind<IFaturaDetayService>().To<FaturaDetayManager>().InTransientScope();
            Bind<IFaturaDetayDal>().To<FaturaDetayDal>().InTransientScope();

            Bind<IGiderService>().To<GiderManager>().InTransientScope();
            Bind<IGiderDal>().To<GiderDal>().InTransientScope();

            Bind<IKategoriService>().To<KategoriManager>().InTransientScope();
            Bind<IKategoriDal>().To<KategoriDal>().InTransientScope();

            Bind<IMusteriService>().To<MusteriManager>().InTransientScope();
            Bind<IMusteriDal>().To<MusteriDal>().InTransientScope();

            Bind<INotlarService>().To<NotlarManager>().InTransientScope();
            Bind<INotlarDal>().To<NotlarDal>().InTransientScope();

            Bind<IPersonelService>().To<PersonelManager>().InTransientScope();
            Bind<IPersonelDal>().To<PersonelDal>().InTransientScope();

            Bind<IUrunHareketService>().To<UrunHareketManager>().InTransientScope();
            Bind<IUrunHareketDal>().To<UrunHareketDal>().InTransientScope();

            Bind<IUrunKabulService>().To<UrunKabulManager>().InTransientScope();
            Bind<IUrunKabulDal>().To<UrunKabulDal>().InTransientScope();

            Bind<IUrunService>().To<UrunManager>().InTransientScope();
            Bind<IUrunDal>().To<UrunDal>().InTransientScope();

            Bind<IUrunTakipService>().To<UrunTakipManager>().InTransientScope();
            Bind<IUrunTakipDal>().To<UrunTakipDal>().InTransientScope();
        }
    }
}
