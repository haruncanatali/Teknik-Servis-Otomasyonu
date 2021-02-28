using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Business.Fluent_Validation;
using TeknikServis.Business.Ninject;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal dal;
        AdminValidator validator;

        public AdminManager()
        {
            dal = InstanceFactory.Get<IAdminDal>();
            validator = new AdminValidator();
        }

        public void Add(Admin entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Admin entity)
        {
            dal.Delete(entity);
        }

        public Admin Get(Expression<Func<Admin, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<Admin> List(Expression<Func<Admin, bool>> filter = null)
        {
            return dal.List(filter);
        }

        public void Update(Admin entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
