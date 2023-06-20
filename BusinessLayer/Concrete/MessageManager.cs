using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager:IMessageService
    {
        IMessageDal _MessageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _MessageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _MessageDal.GET(x => x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _MessageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _MessageDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _MessageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
