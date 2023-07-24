namespace ExchangeData.DAL.ExchangeDataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SendMessage")]

    public partial class SendMessage
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(75)]
        public string MessageHeading { get; set; }

        [Column(Order = 2)]
        public string Message { get; set; }

        
        [Column(Order = 3)]
        [StringLength(50)]
        public string Date { get; set; }
    }
}
