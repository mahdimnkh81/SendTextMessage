using ExchangeData.DAL.ExchangeDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeData.WCF
{
    [ServiceContract]
    public interface IExchangeMessageService
    {
        [OperationContract]
        SendTextModel GetBy(int id);

        [OperationContract]
        List<SendTextModel> GetAll();

        [OperationContract]
        bool CreateMessage(SendTextModel message);
    }
}
