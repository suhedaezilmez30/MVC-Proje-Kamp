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
    public class ImageFaileManager :IImageFileService
    {
        IImageFileDal _ImageDal;

        public ImageFaileManager(IImageFileDal ımageDal)
        {
            _ImageDal = ımageDal;
        }

        public List<Image> GetList()
        {
           return _ImageDal.List();
        }
    }
}
