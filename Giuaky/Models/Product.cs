namespace Giuaky.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column("Short Name")]
        [StringLength(100)]
        public string Short_Name { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [Column("Category ID")]
        public int Category_ID { get; set; }

        public virtual Category Category { get; set; }
    }
}
