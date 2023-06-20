using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingID(int id); //İD YE GÖRE BÜTÜN LİSTEYİ DÖNDÜR
        void ContentAdd(Content content);
        Content GetByID(int id);  //IREPOSİTORYDEN ALCAĞI ŞARTI MİNİMİZE ETMİŞ OLDUK
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
