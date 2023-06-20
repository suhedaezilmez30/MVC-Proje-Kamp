using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriteService
    {
        IWriterDal _WriterDal;

      public WriterManager(IWriterDal writerDal)
        {
            _WriterDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _WriterDal.GET(x=>x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _WriterDal.List();
        }

        public void WriteAdd(Writer writer)
        {
           _WriterDal.Insert(writer);
        }

        public void WriteDelete(Writer writer)
        {
            _WriterDal.Delete(writer);
        }

        public void WriteUpdate(Writer writer)
        {
            _WriterDal.Update(writer);
        }
    }
}
