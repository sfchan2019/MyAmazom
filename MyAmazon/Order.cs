namespace MyAmazon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Customer_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total_Price { get; set; }
    }
}
