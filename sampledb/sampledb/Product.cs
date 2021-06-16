namespace sampledb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
