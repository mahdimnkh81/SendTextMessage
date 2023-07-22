using System;


namespace ExchangeData.BLL.Models
{
    public class MessageModel
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MessageHeading { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }

        public MessageModel(long id, string name, string phoneNumber, string email, string messageHeading, string message)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            MessageHeading = messageHeading;
            Message = message;
            Date = DateTime.Now.ToString();

        }
    }
}
