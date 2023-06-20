using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICaregoryService
    {
        List<Category> GetList ();
        void CategoryAdd(Category category);
        Heading GetByID(int id);  //IREPOSİTORYDEN ALCAĞI ŞARTI MİNİMİZE ETMİŞ OLDUK
       void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
    
    }
}
