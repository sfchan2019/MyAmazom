namespace MyAmazon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Catagory { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
