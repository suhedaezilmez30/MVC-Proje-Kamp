using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IWriteService
    {
        List<Writer> GetList();
        void WriteAdd(Writer writer);
        void WriteDelete(Writer writer);
        void WriteUpdate(Writer writer);
        Writer GetByID(int id);
    }
}
