using System.Runtime.Serialization;


namespace ExchangeData.DAL.ExchangeDataModel
{
    [DataContract]
    public class SendTextModel
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string MessageHeading { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Date { get; set; }

    }
}
