using ExchangeData.BLL.Models;
using System.Collections.Generic;


namespace ExchangeData.BLL
{
     public class MassageTextService
     {
        public static MessageModel GetBy(int id)
        {
            ExchangeDataClient.MessageTextService.ExchangeMessageServiceClient client = new ExchangeDataClient.MessageTextService.ExchangeMessageServiceClient();
            var x = client.GetBy(id).Name;

            return new MessageModel(client.GetBy(id).Id, client.GetBy(id).Name, client.GetBy(id).PhoneNumber, client.GetBy(id).Email, client.GetBy(id).MessageHeading, client.GetBy(id).Message);
        }

        public static List<MessageModel> GetAll()
        {

            ExchangeDataClient.MessageTextService.ExchangeMessageServiceClient client = new ExchangeDataClient.MessageTextService.ExchangeMessageServiceClient();
            List<MessageModel> messageList = new List<MessageModel>();
            var t = client.GetAll();
            foreach (ExchangeDataClient.MessageTextService.SendTextModel i in client.GetAll())
            {
                var x = new MessageModel(i.Id, i.Name, i.PhoneNumber, i.Email, i.MessageHeading, i.Message);
                messageList.Add(x);
            }

            return messageList;
        }
    }
}
