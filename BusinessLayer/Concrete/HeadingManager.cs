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
    public class HeadingManager : IHeadingService
        {
            IHeadingDal _headinDal;

            public HeadingManager(IHeadingDal headinDal)
            {
                _headinDal = headinDal;
            }

            public List<Heading> GetList()
            {
                return _headinDal.List();
            }

            public void HeadingAdd(Heading heading)
            {
                _headinDal.Insert(heading);
            }

            public void HeadingDelete(Heading heading)
            {
                heading.HeadingStatus = false;
                _headinDal.Update(heading);
            }

            public void HeadingUpdate(Heading heading)
            {
                _headinDal.Update(heading);
            }

            public Heading GetByID(int id)
            {
                return _headinDal.GET(x => x.HeadingID == id);
            }

        }
    }
