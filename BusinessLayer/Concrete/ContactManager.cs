using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    {
        IContactDal _IContactDal;

        public ContactManager(IContactDal ıContactDal)
        {
            _IContactDal = ıContactDal;
        }

        public void ContactAdd(Contact contact)
        {
            _IContactDal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _IContactDal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _IContactDal.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _IContactDal.GET(x=>x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _IContactDal.List();
        }
    }
}
