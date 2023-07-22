using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ExchangeData.DAL.ExchangeDataEntity;
using ExchangeData.DAL.ExchangeDataModel;

namespace ExchangeData.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ExchangeMessageService : IExchangeMessageService
    {
        public List<SendTextModel> GetAll()
        {
            using (var db = new ExchangeDataDb())
            {
                return db.SendMessages.Select(x => new SendTextModel
                {


                    Name = x.Name,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                    MessageHeading = x.MessageHeading,
                    Message = x.Message,
                    Date = x.Date


                }).ToList();
            }
        }

        public SendTextModel GetBy(int id)
        {
            using (var db = new ExchangeDataDb())
            {
                return db.SendMessages.Select(x => new SendTextModel
                {

                    Id = id,
                    Name = x.Name,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                    MessageHeading = x.MessageHeading,
                    Message = x.Message,
                    Date = x.Date
                }).FirstOrDefault(x => x.Id == id);
            }
        }

        public bool SaveMessage(SendTextModel message)
        {
            throw new NotImplementedException();
        }
    }
}
