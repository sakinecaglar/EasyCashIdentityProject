using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountdal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountdal)
        {
            _customerAccountdal = customerAccountdal; 
        }

        public void TDelete(CustomerAccount t)
        {
            _customerAccountdal.Delete(t);
        }

        public CustomerAccount TGetByID(int id)
        {
            return _customerAccountdal.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountdal.GetList();
        }

        public void TInsert(CustomerAccount t)
        {
            _customerAccountdal.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAccountdal.Update(t);
        }
    }
}
